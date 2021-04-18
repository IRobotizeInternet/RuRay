Add-Type -AssemblyName System.Windows.Forms
 
$X = [System.Windows.Forms.Cursor]::Position.X
$Y = [System.Windows.Forms.Cursor]::Position.Y
 
[hashtable]$Coordinate = @{} 
$Coordinate.X = [int]$X 
$Coordinate.Y = [int]$Y 
Return $Coordinate 
