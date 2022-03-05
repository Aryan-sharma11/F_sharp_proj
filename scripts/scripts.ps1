 dotnet build   <#building project and all of its dependencies#>
 dotnet publish <#compiles the appplication for deployment#>
 Import-Module .\bin\Debug\net6.0\publish\MyPSModule.dll <#adding the module to the session#>

 do{
     $num=Read-Host "Enter an Interger value" <#Reading integer input #>
     $flag= $false
 try
    {
    Add-Seven $num  <# Sending the input value as Argument in positional parameter #>
    }
catch
{
    $flag=$true
    Write-Output " Entered Value is not an Integer" <# if value is not a valid integer#>
}
 }while($flag)




