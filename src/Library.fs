namespace MyPSModule
open System.Management.Automation
open System.Management.Automation.Runspaces
[<Cmdlet("Get", "Num")>]
type GetNum () =
    inherit PSCmdlet ()
    [<Parameter>]
    member val Num : string = "" with get, set
    
    override x.EndProcessing () =
       
        x.WriteObject (x.Num)
        base.EndProcessing ()
    
   // Get-Num value1 -Parameter2 value2
        
       