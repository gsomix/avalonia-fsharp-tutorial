namespace Todo.ViewModels

open System
open ReactiveUI

open Todo.Models

type AddItemViewModel() as this =
    inherit ViewModelBase()
    
    let mutable description = String.Empty
    
    member this.Description
        with get() = description
        and set(value) = this.RaiseAndSetIfChanged(&description, value) |> ignore
    
    member val Ok =
        ReactiveCommand.Create<_>(
            (fun () -> { TodoItem.defaultItem with Description = this.Description }),
            this.WhenAnyValue(
                (fun x -> x.Description),
                (fun x -> String.IsNullOrWhiteSpace(x) |> not)
            )
        )       
        
     member val Cancel = ReactiveCommand.Create(fun () -> ())
