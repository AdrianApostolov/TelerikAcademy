/*
 Write an expression that calculates rectangle’s area
 by given width and height.
 */

var jsConsole;
var button = document.getElementById('calculate');

button.onclick = calculateRectangleArea;

function calculateRectangleArea(){
    var width = jsConsole.readInteger('#width');
    var height = jsConsole.readInteger('#height');

    var area = width * height;

    jsConsole.writeLine('Rectangle area is: ' + area);
    console.log('Rectangle area is: ' + area);
}