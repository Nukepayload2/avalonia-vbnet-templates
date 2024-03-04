$OutputEncoding = New-Object -typename System.Text.UTF8Encoding
$env:DOTNET_CLI_UI_LANGUAGE="en"
dotnet new uninstall Nukepayload2.Templates.Avalonia
Remove-Item bin/**/*.nupkg
$result = dotnet pack | select-string "Successfully created package '(.*)'" -AllMatches
$package = $result.Matches.Groups[1]
dotnet new install $package