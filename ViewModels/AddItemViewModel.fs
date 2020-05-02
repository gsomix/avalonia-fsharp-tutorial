namespace Todo.ViewModels

open System

type AddItemViewModel() =
    inherit ViewModelBase()
    
    member val Description = String.Empty with get, set