#r "./node_modules/fable-core/Fable.Core.dll"

open Fable.Core
open Fable.Import.Browser

let canvas = document.getElementsByTagName_canvas().[0]
let ctx = canvas.getContext_2d()
let userInput = document.getElementsByTagName_textarea().[0]
let docs = document.getElementsByTagName_div().[0]

console.log ctx
console.log userInput
console.log docs

ctx.font <- "30px Georgia"
ctx.fillText("Canvas", 0.0, 26.0, 400.0)
docs.innerHTML <- "Docs"
userInput.value <- "Input"
