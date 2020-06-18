namespace Todo.Models

open System

type TodoItem =
    { Description: string
      mutable IsChecked: bool  
    }
    
module TodoItem =
    let defaultItem =
        { Description = String.Empty
          IsChecked = false }
