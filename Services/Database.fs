namespace Todo.Services

open Todo.Models

type Database() =
    member _.GetItems() = seq {
        { TodoItem.defaultItem with Description = "Walk the dog" }
        { TodoItem.defaultItem with Description = "Buy some milk" }
        { TodoItem.defaultItem with Description = "Learn Avalonia"; IsChecked = true }
    }

