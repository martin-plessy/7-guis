namespace SevenGuiCounterFuncUI

open Elmish
open Avalonia
open Avalonia.Input
open Avalonia.FuncUI.Elmish
open Avalonia.FuncUI.Components.Hosts

type MainWindow() as this =
    inherit HostWindow()
    do
        base.Title <- "7 GUIs Counter Avalonia FuncUI"

        #if DEBUG
        this.AttachDevTools(KeyGesture(Key.F12))
        #endif

        Program.mkSimple Counter.init Counter.update Counter.view
        |> Program.withHost this
        |> Program.run
