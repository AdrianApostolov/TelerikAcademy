/*
 Write a boolean expression for finding if the bit 3
 (counting from 0) of a given integer is 1 or 0.
 */

var jsConsole;
var button = document.getElementById('check');

button.onclick = extractThirdBit;

function extractThirdBit(){
    var number = jsConsole.readInteger('input');
    var binary = number.toString(2);

    var mask = 1 << 3;
    var maskAndNumber = number & mask;
    var result = maskAndNumber >> 3;

    jsConsole.writeLine('Binary representation of input number is: ' + binary);
    jsConsole.writeLine('Third bit is: ' + result);

    console.log('Binary representation of input number is: ' + binary);
    console.log('Third bit is: ' + result);
}