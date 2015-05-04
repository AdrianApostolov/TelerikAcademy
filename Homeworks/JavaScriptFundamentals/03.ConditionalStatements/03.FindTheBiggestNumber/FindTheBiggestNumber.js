/*
 Write a script that finds the biggest of three integers
 using nested if statements.
 */

var jsConsole;
var button = document.getElementById('check');

button.onclick = checkBiggestNumber;

function checkBiggestNumber() {
    var firstNumber = jsConsole.readInteger('#first-number');
    var secondNumber = jsConsole.readInteger('#second-number');
    var thirdNumber = jsConsole.readInteger('#third-number');

    if (firstNumber > secondNumber) {
        if (firstNumber > thirdNumber) {
            jsConsole.writeLine('The biggest number is: ' + firstNumber);
            console.log('The biggest number is: ' + firstNumber);
        }
        else {
            jsConsole.writeLine('The biggest number is: ' + thirdNumber);
            console.log('The biggest number is: ' + thirdNumber);
        }
    }
    else {
        if (secondNumber > thirdNumber) {
            jsConsole.writeLine('The biggest number is: ' + secondNumber);
            console.log('The biggest number is: ' + secondNumber);
        }
        else {
            jsConsole.writeLine('The biggest number is: ' + thirdNumber);
            console.log('The biggest number is: ' + thirdNumber);
        }
    }
}