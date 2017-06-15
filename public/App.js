var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

import { setType } from "fable-core/Symbol";
import _Symbol from "fable-core/Symbol";
import { compareRecords, equalsRecords } from "fable-core/Util";
export var Turtle = function () {
  function Turtle(x, y) {
    _classCallCheck(this, Turtle);

    this.x = x;
    this.y = y;
  }

  _createClass(Turtle, [{
    key: _Symbol.reflection,
    value: function () {
      return {
        type: "App.Turtle",
        interfaces: ["FSharpRecord", "System.IEquatable", "System.IComparable"],
        properties: {
          x: "number",
          y: "number"
        }
      };
    }
  }, {
    key: "Equals",
    value: function (other) {
      return equalsRecords(this, other);
    }
  }, {
    key: "CompareTo",
    value: function (other) {
      return compareRecords(this, other);
    }
  }]);

  return Turtle;
}();
setType("App.Turtle", Turtle);
export function drawTurtle(ctx, turtle) {
  ctx.save();
  ctx.translate(turtle.x, turtle.y);
  ctx.beginPath();
  ctx.moveTo(0, -10);
  ctx.lineTo(-7, 10);
  ctx.lineTo(0, 10);
  ctx.lineTo(7, 10);
  ctx.lineTo(0, -10);
  ctx.stroke();
  ctx.restore();
}
export function initCanvas(ctx, turtle) {
  ctx.font = "30px Georgia";
  ctx.fillText("Canvas", 0, 26, 400);
  drawTurtle(ctx, turtle);
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
export var initialTurtle = new Turtle(canvas.width / 2, canvas.height / 2);
initCanvas(ctx, initialTurtle);