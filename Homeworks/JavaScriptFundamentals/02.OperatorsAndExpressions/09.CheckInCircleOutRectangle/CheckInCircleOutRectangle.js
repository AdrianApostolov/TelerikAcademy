/*
 Write an expression that checks for given point (x, y)
 if it is within the circle K( (1,1), 3) and out of the
 rectangle R(top=1, left=-1, width=6, height=2).
 */

var jsConsole;
var button = document.getElementById('check');

button.onclick = checkInCircleOutRectangle;

function checkInCircleOutRectangle(){
    var x = jsConsole.readFloat("#x");
    var y = jsConsole.readFloat("#y");

    var isInCircle = Math.sqrt((x * x) + (y * y)) <= 3;
    var isOutofRectangle = ((x > -1 || x > 5) && (y > -1 || y > 1));

    var isInCircleOutRectangle = isInCircle && isOutofRectangle;

    jsConsole.writeLine('Is point in circle and out of the rectangle: ' + isInCircleOutRectangle);
    console.log('Is point in circle and out of the rectangle: ' + isInCircleOutRectangle);
}