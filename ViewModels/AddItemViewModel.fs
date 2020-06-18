namespace Todo.ViewModels

open System
open ReactiveUI

open Todo.Models

type AddItemViewModel() =
    inherit ViewModelBase()
    
    let mutable description = String.Empty
    let mutable ok = null
    
    member this.Description
        with get() = description
        and set(value) = this.RaiseAndSetIfChanged(&description, value) |> ignore
    
    member this.Ok =
        if isNull ok then
            ok <-
                ReactiveCommand.Create<_>(
                    (fun () -> { TodoItem.defaultItem with Description = this.Description }),
                    this.WhenAnyValue(
                        (fun x -> x.Description),
                        (fun x -> String.IsNullOrWhiteSpace(x) |> not)
                    )
                )       
        ok
        
     member val Cancel = ReactiveCommand.Create(fun () -> ())
