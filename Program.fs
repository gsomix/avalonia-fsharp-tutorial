﻿open Avalonia
open Avalonia.Logging.Serilog
open Avalonia.ReactiveUI

open Todo

let buildAvaloniaApp() =
    AppBuilder.Configure<App>()
        .UsePlatformDetect()
        .LogToDebug()
        .UseReactiveUI()

[<EntryPoint>]
let main argv =
    buildAvaloniaApp().StartWithClassicDesktopLifetime(argv)
