namespace Todo.Services

open Todo.Models

type Database() =
    member _.GetItems() = seq {
        { Description = "Walk the dog"; IsChecked = false }
        { Description = "Buy some milk"; IsChecked = false }
        { Description = "Learn Avalonia"; IsChecked = true }
    }

