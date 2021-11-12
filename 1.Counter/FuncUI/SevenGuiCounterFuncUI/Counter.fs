namespace SevenGuiCounterFuncUI

open Avalonia.Controls
open Avalonia.FuncUI.DSL
open Avalonia.FuncUI.Types
open Avalonia.Layout

module Counter =
    type State = { CounterValue: int }
    type Message = Click

    let init () : State =
        { CounterValue = 0 }

    let update (_: Message) (state: State) : State =
        { CounterValue = state.CounterValue + 1 }

    let view (state: State) (dispatch: Message -> unit) : IView<StackPanel> =
        StackPanel.create [
            StackPanel.orientation Orientation.Horizontal
            StackPanel.margin 16.0
            StackPanel.spacing 8.0
            StackPanel.verticalAlignment VerticalAlignment.Top
            StackPanel.children [
                TextBox.create [
                    TextBox.isReadOnly true
                    TextBox.text (string state.CounterValue)
                ]

                Button.create [
                    Button.content "Click"
                    Button.onClick (fun _ -> dispatch Click)
                ]
            ]
        ]
