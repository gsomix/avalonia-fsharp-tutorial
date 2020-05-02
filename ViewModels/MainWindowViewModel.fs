namespace Todo.ViewModels

open System
open System.Collections.Generic
open System.Text
open ReactiveUI
open Todo.Services

type MainWindowViewModel(db: Database) =
    inherit ViewModelBase()  
    
    let list = TodoListViewModel(db.GetItems())
    let mutable content: ViewModelBase = upcast list
    
    member _.List = list
    
    member this.Content
        with get(): ViewModelBase = content
        and set(value) = this.RaiseAndSetIfChanged(&content, value) |> ignore
        
    member this.AddItem() = this.Content <- AddItemViewModel()