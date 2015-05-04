/*
 Write a script that shows the sign (+ or -) of the
 product of three real numbers without calculating it.
 Use a sequence of if statements.
 */

var jsConsole;
var button = document.getElementById('check');

button.onclick = checkSign;

function checkSign(){
    var firstNumber = jsConsole.readInteger('#first-number');
    var secondNumber = jsConsole.readInteger('#second-number');
    var thirdNumber = jsConsole.readInteger('#third-number');

    if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
    {
        jsConsole.writeLine('The sing of the product of the three real number is: +');
        console.log('The sing of the product of the three real number is: +');
    }
    else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
    {
        jsConsole.writeLine('The sing of the product of the three real number is: +');
        console.log('The sing of the product of the three real number is: +');
    }
    else if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0)
    {
        jsConsole.writeLine('The sing of the product of the three real number is: +');
        console.log('The sing of the product of the three real number is: +');
    }
    else if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0)
    {
        jsConsole.writeLine('The sing of the product of the three real number is: +');
        console.log('The sing of the product of the three real number is: +');
    }
    else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0)
    {
        jsConsole.writeLine('The sing of the product of the three real number is: +');
        console.log('The sing of the product of the three real number is: +');
    }
    else
    {
        jsConsole.writeLine('The sing of the product of the three real number is: -');
        console.log('The sing of the product of the three real number is: -');
    }
}