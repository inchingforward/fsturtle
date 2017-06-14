#r "./node_modules/fable-core/Fable.Core.dll"

open Fable.Core
open Fable.Import.Browser

let initCanvas (ctx: CanvasRenderingContext2D) = 
    ctx.font <- "30px Georgia"
    ctx.fillText ("Canvas", 0.0, 26.0, 400.0)

let textChanged (text: string) =
    console.log(text)
    null

let canvas = document.getElementsByTagName_canvas().[0]
let ctx = canvas.getContext_2d()
let userInput = document.getElementsByTagName_textarea().[0]
let docs = document.getElementsByTagName_div().[0]
userInput.addEventListener_keyup (fun e -> textChanged userInput.value)

initCanvas ctx