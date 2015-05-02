/*
 Write an expression that calculates trapezoid's area
 by given sides a and b and height h.
 */

var jsConsole;
var button = document.getElementById('calculate');

button.onclick = calculateTrapezoidArea;

function calculateTrapezoidArea(){
    var a = jsConsole.readFloat('#a');
    var b = jsConsole.readFloat('#b');
    var h = jsConsole.readFloat('#h');

    var result = ((a + b) / 2) * h;

    jsConsole.writeLine('The area of the trapezoid is: ' + result);
    console.log('The area of the trapezoid is: ' + result);
}
