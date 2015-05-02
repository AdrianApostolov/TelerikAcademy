/*
 Write an expression that checks for given integer if
 its third digit (right-to-left) is 7. E. g. 1732 ? true.
 */

var jsConsole;
var button = document.getElementById('check');

button.onclick = checkNumber;

function checkNumber() {
    var input = jsConsole.readInteger('#input');
    var thirdDigit = Math.floor(input / 100) % 10;
    var isSeven = thirdDigit === 7;

    jsConsole.writeLine('Third digit of number ' + input + ' is 7: ' + isSeven);
    console.log('Third digit of number ' + input + ' is 7: ' + isSeven);
}