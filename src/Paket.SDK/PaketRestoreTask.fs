namespace Paket.SDK
open System
open Microsoft.Build.Framework;
open Microsoft.Build.Utilities;
open Paket
open Paket.Logging



type PaketRestoreTask() = 
    inherit Task()
    override __.Execute() =
            use consoleTrace = Logging.event.Publish |> Observable.subscribe Logging.traceToConsole
            Dependencies.Locate().Restore() 
            let ea = BuildMessageEventArgs("Paket restore task invoked",
                                     String.Empty, "PaketRestoreTask", MessageImportance.Normal)
            __.BuildEngine.LogMessageEvent(ea)
            true;
        
    