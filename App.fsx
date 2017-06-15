#r "./node_modules/fable-core/Fable.Core.dll"

open Fable.Core
open Fable.Import.Browser

type Turtle = {mutable x: float; mutable y: float}

let drawTurtle(ctx: CanvasRenderingContext2D, turtle: Turtle) = 
    ctx.save ()
    ctx.translate (turtle.x, turtle.y)
    ctx.beginPath ()
    ctx.moveTo (0.0, -10.0)
    ctx.lineTo (-7.0, 10.0)
    ctx.lineTo (0.0, 10.0)
    ctx.lineTo (7.0, 10.0)
    ctx.lineTo (0.0, -10.0)
    ctx.stroke ()
    ctx.restore ()
    
let initCanvas (ctx: CanvasRenderingContext2D, turtle: Turtle) = 
    ctx.font <- "30px Georgia"
    ctx.fillText ("Canvas", 0.0, 26.0, 400.0)
    drawTurtle (ctx, turtle)

let textChanged (text: string) =
    console.log(text)
    null

let canvas = document.getElementsByTagName_canvas().[0]
let ctx = canvas.getContext_2d()
let userInput = document.getElementsByTagName_textarea().[0]
let docs = document.getElementsByTagName_div().[0]
userInput.addEventListener_keyup (fun e -> textChanged userInput.value)

let initialTurtle = {x = (canvas.width / 2.0); y = (canvas.height / 2.0)}
initCanvas (ctx, initialTurtle)