namespace Todo.ViewModels

open System
open System.Collections.Generic
open System.Text
open Todo.Services

type MainWindowViewModel(db: Database) =
    inherit ViewModelBase()  
    
    member _.List = TodoListViewModel(db.GetItems())