#!/bin/bash

# Start SQL Server in the background
echo "Starting SQL Server..."
/opt/mssql/bin/sqlservr &
PID=$!

# Wait for SQL Server to start
echo "Waiting for SQL Server to be ready..."
for i in $(seq 1 30); do
    /opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "$SA_PASSWORD" -Q "SELECT 1" -C > /dev/null 2>&1
    if [ $? -eq 0 ]; then
        echo "SQL Server is ready. Running init script..."
        /opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "$SA_PASSWORD" -i /docker-entrypoint-initdb.d/init.sql -C
        echo "Init script completed."
        break
    fi
    echo "Attempt $i: SQL Server not ready yet, waiting 3s..."
    sleep 3
done

# Keep container running by waiting for the SQL Server process
wait $PID
