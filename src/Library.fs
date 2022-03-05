namespace MyPSModule
open System.Management.Automation
open System.Management.Automation.Runspaces

[<Cmdlet("Add","Seven")>]  //cmdlet attribute declaration
type GetNum () =
    inherit PSCmdlet () //inheriting the PSCmdlet class
//    override x.BeginProcessing () =
//        let message = "Enter Integer Value"
//        x.WriteVerbose(message);
  
    [<Parameter(Position=0)>] //allows the cmdlet to take default input

                               // Positional parameter to allow cmdlet to take input without specifying the variable
    member val Num : string = "" with get, set
     
    override x.EndProcessing () =
    let num=x.Num|>int // Typecasting String to Integer 
    x.WriteObject (7+num)
    base.EndProcessing ()
    
    
   
        
       
