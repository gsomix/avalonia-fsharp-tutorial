namespace Todo.ViewModels

open System
open System.Reactive.Linq
open ReactiveUI

open Todo.Models
open Todo.Services

type MainWindowViewModel(db: Database) =
    inherit ViewModelBase()  
    
    let list = TodoListViewModel(db.GetItems())
    
    let mutable content: ViewModelBase = upcast list
    
    member _.List = list
    
    member this.Content
        with get() = content
        and set(value) = this.RaiseAndSetIfChanged(&content, value) |> ignore
        
    member this.AddItem() =
        let vm = AddItemViewModel()
       
        Observable
            .Merge(vm.Ok, vm.Cancel.Select(fun _ -> TodoItem.defaultItem))
            .Take(1)
            .Subscribe(fun model ->
               if model <> TodoItem.defaultItem then
                   this.List.Items.Add(model)
               this.Content <- this.List                 
            ) |> ignore
        
        this.Content <- vm
