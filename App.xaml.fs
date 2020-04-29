namespace Todo

open Avalonia
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.Markup.Xaml
open Todo.Services
open Todo.ViewModels
open Todo.Views

type App() =
    inherit Application()
    
    override this.Initialize() =
        AvaloniaXamlLoader.Load(this)
        
    override this.OnFrameworkInitializationCompleted() =
        match this.ApplicationLifetime with
        | :? IClassicDesktopStyleApplicationLifetime as desktop ->
            let db = Database()
            desktop.MainWindow <- MainWindow(DataContext = MainWindowViewModel(db))
        | _ -> ()
        
        base.OnFrameworkInitializationCompleted()