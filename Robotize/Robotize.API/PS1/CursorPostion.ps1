param($FilePath)
Add-Type -AssemblyName System.Windows.Forms

$X = [System.Windows.Forms.Cursor]::Position.X
$Y = [System.Windows.Forms.Cursor]::Position.Y
 
[hashtable]$Coordinate = @{} 
$Coordinate.X = [int]$X 
$Coordinate.Y = [int]$Y 

$coordinateObject = {
		param($xCoordinate, $yCoordinate)

        Write-Host $propertyName

        $retObj = @{}

        $retObj | Add-Member -Name xAxis -MemberType ScriptProperty -Value {
            $xCoordinate
        }.GetNewClosure()

        $retObj | Add-Member -Name yAxis -MemberType ScriptProperty -Value {
            $yCoordinate
        }.GetNewClosure()

        return $retObj
}

$res = (& $coordinateObject -xCoordinate $Coordinate.X -yCoordinate $Coordinate.Y)
$res | ConvertTo-Json -depth 3 > $FilePath
Return $Coordinate 
