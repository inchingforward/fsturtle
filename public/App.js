export function initCanvas(ctx) {
  ctx.font = "30px Georgia";
  ctx.fillText("Canvas", 0, 26, 400);
}
export function textChanged(text) {
  console.log(text);
  return null;
}
export var canvas = document.getElementsByTagName('canvas')[0];
export var ctx = canvas.getContext('2d');
export var userInput = document.getElementsByTagName('textarea')[0];
export var docs = document.getElementsByTagName('div')[0];
userInput.addEventListener('keyup', function (e) {
  return textChanged(userInput.value);
});
initCanvas(ctx);