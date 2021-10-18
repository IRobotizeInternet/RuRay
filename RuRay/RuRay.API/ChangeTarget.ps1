# This script will create/replace a new shortcut of google chrome 
# The newly created shortcut will have custom remote debugged port set to 9222
# If you change the shortcut file path you must chage in the ServiceBrowers.cs as well
$ShortcutFile = [environment]::GetFolderPath('Desktop') + "\chrome.exe - Shortcut.lnk"
$WScriptShell = New-Object -ComObject WScript.Shell
$Shortcut = $WScriptShell.CreateShortcut($ShortcutFile)
#$Shortcut.TargetPath = "`"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe`""
$Shortcut.TargetPath = "`"C:\Program Files\Google\Chrome\Application\chrome.exe`""
$Shortcut.Arguments = '--remote-debugging-port=9222 '
# If you wish to use multiple chrome user you need to find and add profile directory ex: --profile-directory="Profile 10"
#$Shortcut.Arguments = '--remote-debugging-port=9222 --profile-directory="Profile 10"'
$Shortcut.IconLocation = "C:\Program Files\Google\Chrome\Application\chrome.exe, 0"
#$Shortcut.IconLocation = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe, 0"
$Shortcut.Save()

# TODO Make this file run through ms build
# https://docs.microsoft.com/en-us/aspnet/web-forms/overview/deployment/advanced-enterprise-web-deployment/running-windows-powershell-scripts-from-msbuild-project-files