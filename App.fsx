#r "./node_modules/fable-core/Fable.Core.dll"

open Fable.Core
open Fable.Import.Browser

type Turtle = {mutable x: float; mutable y: float}

let rotate turtle degrees = 
    List.init 150 (fun index -> { turtle with x = turtle.x + float(index) })

let drawTurtle (ctx: CanvasRenderingContext2D) turtle = 
    ctx.save ()
    ctx.translate (turtle.x, turtle.y)
    ctx.lineWidth <- 1.0
    ctx.strokeStyle <- U3.Case1 "black"
    ctx.beginPath ()
    ctx.moveTo (0.0, -10.0)
    ctx.lineTo (-7.0, 10.0)
    ctx.lineTo (0.0, 10.0)
    ctx.lineTo (7.0, 10.0)
    ctx.lineTo (0.0, -10.0)
    ctx.stroke ()
    ctx.restore ()
 
let rec animate ctx turtles =
    match turtles with 
    | [] -> ()
    | x::xs -> 
        drawTurtle ctx x
        window.setTimeout ((fun _ -> animate ctx xs), 0.) |> ignore

let initCanvas ctx turtle = 
    drawTurtle ctx turtle

let canvas = document.getElementsByTagName_canvas().[0]
let ctx = canvas.getContext_2d()
let userInput = document.getElementsByTagName_textarea().[0]

let initialTurtle = {x = (canvas.width / 2.0); y = (canvas.height / 2.0)}
let runButton = document.getElementById "run"
runButton.addEventListener_click(fun _ -> animate ctx (rotate initialTurtle 30); null)

let docs = document.getElementsByTagName_div().[0]

initCanvas ctx initialTurtle
