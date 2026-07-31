[System.Reflection.Assembly]::LoadWithPartialName('Microsoft.SqlServer.SMO') | Out-Null
[System.Reflection.Assembly]::LoadWithPartialName('Microsoft.SqlServer.SmoExtended') | Out-Null

$serverName = 'AKASH\SQLEXPRESS'
$dbName     = 'ErpData'
$outFile    = 'C:\Users\Akash\Desktop\Akash\Inspection_Outcome\Inspection_Outcome\docker\init.sql'

New-Item -ItemType Directory -Force -Path (Split-Path $outFile) | Out-Null

$srv = New-Object Microsoft.SqlServer.Management.Smo.Server($serverName)
$db  = $srv.Databases[$dbName]

$scripter = New-Object Microsoft.SqlServer.Management.Smo.Scripter($srv)
$scripter.Options.ScriptDrops          = $false
$scripter.Options.WithDependencies     = $false
$scripter.Options.IncludeHeaders       = $false
$scripter.Options.SchemaQualify        = $true
$scripter.Options.DriAll               = $true
$scripter.Options.Indexes              = $true
$scripter.Options.Triggers             = $false
$scripter.Options.IncludeIfNotExists   = $true
$scripter.Options.NoFileGroup          = $true
$scripter.Options.AnsiPadding          = $false

$header = @"
-- ErpData Database Init Script (auto-generated)
-- Run this once when the SQL Server container first starts.

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'ErpData')
BEGIN
    CREATE DATABASE [ErpData];
END
GO

USE [ErpData];
GO

"@

$header | Out-File -FilePath $outFile -Encoding UTF8

# Script all tables
$urns = $db.Tables | Where-Object { -not $_.IsSystemObject } | ForEach-Object { $_.Urn }

if ($urns.Count -gt 0) {
    $scripts = $scripter.Script($urns)
    foreach ($s in $scripts) {
        ($s + "`nGO`n") | Out-File -FilePath $outFile -Encoding UTF8 -Append
    }
}

Write-Host "Done. Script written to $outFile"
Write-Host "Tables scripted: $($urns.Count)"
