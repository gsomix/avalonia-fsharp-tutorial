namespace Todo.ViewModels

open System
open System.Collections.Generic
open System.Text

type MainWindowViewModel() =
    inherit ViewModelBase()  
    member _.Greeting = "Hello World!"