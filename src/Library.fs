namespace MyPSModule
open System.Management.Automation
open System.Management.Automation.Runspaces
[<Cmdlet("Get", "Num")>]
type GetNum () =
    inherit PSCmdlet ()
    [<Parameter>]
    member val Num : string = "" with get, set
    
    override x.EndProcessing () =
       let num=x.Num|>int
        x.WriteObject (7+num)
        base.EndProcessing ()
    
   // Get-Num value1 -Parameter2 value2
        
       
