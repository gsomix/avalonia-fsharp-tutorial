namespace Todo.ViewModels

open System.Collections.ObjectModel
open Todo.Models

type TodoListViewModel(items: TodoItem seq) =
    inherit ViewModelBase()
    
    member _.Items = ObservableCollection<_>(items)