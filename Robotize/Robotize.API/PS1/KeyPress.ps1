Add-Type -AssemblyName System.Windows.Forms
function Do-SendKeys {
    param (
        $SENDKEYS,
        $WINDOWTITLE
    )
    $wshell = New-Object -ComObject wscript.shell;
    IF ($WINDOWTITLE) {$wshell.AppActivate($WINDOWTITLE)}
    Sleep 1
    IF ($SENDKEYS) {$wshell.SendKeys($SENDKEYS)}
}

#[System.Windows.Forms.SendKeys]::SendWait('{TAB}{TAB}')
 Sleep 1
#[System.Windows.Forms.SendKeys]::SendWait('{ENTER}')
[System.Windows.Forms.SendKeys]::SendWait("Hello")
 Sleep 1
[System.Windows.Forms.SendKeys]::SendWait('{ENTER}')
 Sleep 1
#[System.Windows.Forms.SendKeys]::SendWait("World")
# Select all key press
[System.Windows.Forms.SendKeys]::SendWait("^{a}")
 Sleep 5
[System.Windows.Forms.SendKeys]::SendWait("^{c}")
Sleep 1
[System.Windows.Forms.SendKeys]::SendWait("^{x}")
Sleep 1
[System.Windows.Forms.SendKeys]::SendWait("^{v}")
Sleep 1
[System.Windows.Forms.SendKeys]::SendWait("^{v}")


#https://docs.microsoft.com/en-us/powershell/scripting/windows-powershell/ise/keyboard-shortcuts-for-the-windows-powershell-ise?view=powershell-7.1
#Key	        Code
#BACKSPACE	    {BACKSPACE}, {BS}, or {BKSP}
#BREAK	        {BREAK}
#CAPS LOCK	    {CAPSLOCK}
#DEL or DELETE	{DELETE} or {DEL}
#DOWN ARROW	    {DOWN}
#END	        {END}
#ENTER	        {ENTER} or ~
#ESC	        {ESC}
#HELP	        {HELP}
#HOME	        {HOME}
#INS or INSERT	{INSERT} or {INS}
#LEFT ARROW	    {LEFT}
#NUM LOCK	    {NUMLOCK}
#PAGE DOWN	    {PGDN}
#PAGE UP	    {PGUP}
#PRINT SCREEN	{PRTSC} (reserved for future use)
#RIGHT ARROW	{RIGHT}
#SCROLL LOCK	{SCROLLLOCK}
#TAB	        {TAB}
#UP ARROW	    {UP}
#F1	            {F1}
#F2	            {F2}
# ...           ...
#F16	        {F16}
#SHIFT	        +
#CTRL	        ^
#ALT	        %