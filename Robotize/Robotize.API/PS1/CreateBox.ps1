Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing

$form = New-Object System.Windows.Forms.Form
$form.Text = 'Data Entry Form'
$form.Size = New-Object System.Drawing.Size(300,200)
$Form.Opacity = 0.1
$form.StartPosition = 'CenterScreen'

$okButton = New-Object System.Windows.Forms.Button
$okButton.Location = New-Object System.Drawing.Point(75,120)
$okButton.Size = New-Object System.Drawing.Size(75,23)
$okButton.Text = 'OK'
$okButton.DialogResult = [System.Windows.Forms.DialogResult]::OK
$form.AcceptButton = $okButton
$form.Controls.Add($okButton)

$cancelButton = New-Object System.Windows.Forms.Button
$cancelButton.Location = New-Object System.Drawing.Point(150,120)
$cancelButton.Size = New-Object System.Drawing.Size(75,23)
$cancelButton.Text = 'Cancel'
$cancelButton.DialogResult = [System.Windows.Forms.DialogResult]::Cancel
$form.CancelButton = $cancelButton
$form.Controls.Add($cancelButton)

$label = New-Object System.Windows.Forms.Label
$label.Location = New-Object System.Drawing.Point(10,20)
$label.Size = New-Object System.Drawing.Size(280,20)
$label.Text = 'Please enter the information in the space below:'
$form.Controls.Add($label)

$textBox = New-Object System.Windows.Forms.TextBox
$textBox.Location = New-Object System.Drawing.Point(10,40)
$textBox.Size = New-Object System.Drawing.Size(260,20)
$form.Controls.Add($textBox)

$form.Topmost = $true

$form.Add_Shown({$textBox.Select()})
$result = $form.ShowDialog()

if ($result -eq [System.Windows.Forms.DialogResult]::OK)
{
    $x = $textBox.Text
    $x
}

$form = New-Object System.Windows.Forms.Form
$form.Text = 'Data Entry Form'
Add-Type -AssemblyName System.Windows.Forms
$Screen = [System.Windows.Forms.Screen]::PrimaryScreen
$width = $Screen.WorkingArea.Width   # .WorkingArea ignores the taskbar, .Bounds is whole screen
$height = $Screen.WorkingArea.Height

$form.Size = New-Object System.Drawing.Size($width ,$height)
$form.StartPosition = 'CenterScreen'

$x = Select-Object ScreenWidth
For ($i=0; $i -le $height; $i+=100) {
    For ($j=0; $j -le $width; $j+=100) {
       $ButtonClick = New-Object System.Windows.Forms.Button
       $ButtonClick.Location = New-Object System.Drawing.Point($i,$global:ButtonPosY)
       $ButtonClick.Size = New-Object System.Drawing.Size(50,30)
       $ButtonClick.Text = 'Click'
       New-Variable -name ButtonClick$global:Counter -Value $ButtonClick -Scope Global -Force
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
$form.Add_Shown({$textBox.Select()})

$result = $form.ShowDialog()
if ($result -eq [System.Windows.Forms.DialogResult]::OK)
{
    $x = $textBox.Text
    $x
}