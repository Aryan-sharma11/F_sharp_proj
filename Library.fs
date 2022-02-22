namespace MyPSModule
open System.Management.Automation
open System.Management.Automation.Runspaces
[<Cmdlet("Get", "Num")>]
type GetNum () =
    inherit PSCmdlet ()
    [<Parameter>]

    member val num : string = "" with get, set
    
    override x.EndProcessing () =
        let intnum = x.num |> int
        x.WriteObject (7+intnum)
        base.EndProcessing ()
