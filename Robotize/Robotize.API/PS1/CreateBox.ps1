Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing
[System.Windows.Forms.Application]::EnableVisualStyles()

$form = New-Object System.Windows.Forms.Form
$form.TransparencyKey   = $form.BackColor
$form.Text = 'Data Entry Form'
Add-Type -AssemblyName System.Windows.Forms
$Screen = [System.Windows.Forms.Screen]::PrimaryScreen
$width = $Screen.WorkingArea.Width   # .WorkingArea ignores the taskbar, .Bounds is whole screen
$height = $Screen.WorkingArea.Height

$form.Size = New-Object System.Drawing.Size($width ,$height)
$form.StartPosition = 'CenterScreen'

$x = Select-Object ScreenWidth
$index = 1
For ($i=0; $i -le $width; $i+=100) {
    For ($j=0; $j -le $height; $j+=100) {
       $LabelClick = New-Object System.Windows.Forms.label
       $LabelClick.Location = New-Object System.Drawing.Point($i, $j) #$global:ButtonPosY)
       $LabelClick.Size = New-Object System.Drawing.Size(100,100)
       $Font = New-Object System.Drawing.Font(“Arial”,14,[System.Drawing.FontStyle]::Regular)
       $LabelClick.Font = $Font
       $LabelClick.Text = $index
       $index = $index + 1
       New-Variable -name ButtonClick$global:Counter -Value $LabelClick -Scope Global -Force
       $Form.controls.Add($((Get-Variable -name ButtonClick$global:Counter).value))
    }
}

$cancelButton = New-Object System.Windows.Forms.Button
$cancelButton.Location = New-Object System.Drawing.Point(150,120)
$cancelButton.Size = New-Object System.Drawing.Size(75,23)
$cancelButton.Text = 'Cancel'
$cancelButton.DialogResult = [System.Windows.Forms.DialogResult]::Cancel
$form.CancelButton = $cancelButton
$form.Controls.Add($cancelButton)

$form.Topmost = $true

$result = $form.ShowDialog()
if ($result -eq [System.Windows.Forms.DialogResult]::OK)
{
    $x = $textBox.Text
    $x
}