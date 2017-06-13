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

ctx.font <- "Georgia 20px"
ctx.fillText("Hello, world!", 20.0, 10.0, 100.0)
docs.innerHTML <- "Hello, docs!"
userInput.value <- "Hello, user input!"
