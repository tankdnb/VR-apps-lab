param(
    [string[]]$Repo,
    [string]$RepoFile,
    [string]$BasePath = (Join-Path (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path '.research-sources\github'),
    [switch]$UpdateExisting
)

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'

if (-not (Get-Command gh -ErrorAction SilentlyContinue)) {
    throw "GitHub CLI (gh) is required."
}

$repoList = [System.Collections.Generic.List[string]]::new()

if ($Repo) {
    foreach ($entry in $Repo) {
        if (-not [string]::IsNullOrWhiteSpace($entry)) {
            $repoList.Add($entry.Trim())
        }
    }
}

if ($RepoFile) {
    if (-not (Test-Path $RepoFile)) {
        throw "Repo file not found: $RepoFile"
    }

    foreach ($line in Get-Content $RepoFile) {
        $value = $line.Trim()
        if ($value -and -not $value.StartsWith('#')) {
            $repoList.Add($value)
        }
    }
}

$repoList = $repoList | Sort-Object -Unique

if (-not $repoList) {
    throw "No repositories were provided. Use -Repo or -RepoFile."
}

New-Item -ItemType Directory -Force -Path $BasePath | Out-Null

foreach ($entry in $repoList) {
    if ($entry -notmatch '^[^/]+/[^/]+$') {
        Write-Warning "Skipping invalid repo identifier: $entry"
        continue
    }

    $parts = $entry.Split('/')
    $owner = $parts[0]
    $name = $parts[1]

    $ownerPath = Join-Path $BasePath $owner
    $repoPath = Join-Path $ownerPath $name

    New-Item -ItemType Directory -Force -Path $ownerPath | Out-Null

    if (Test-Path $repoPath) {
        if ($UpdateExisting) {
            Write-Host "Updating $entry" -ForegroundColor Cyan
            git -C $repoPath fetch --all --tags --prune
            git -C $repoPath pull --ff-only
        }
        else {
            Write-Host "Skipping existing $entry" -ForegroundColor Yellow
        }
        continue
    }

    Write-Host "Cloning $entry" -ForegroundColor Green
    gh repo clone $entry $repoPath -- --depth 1
}
