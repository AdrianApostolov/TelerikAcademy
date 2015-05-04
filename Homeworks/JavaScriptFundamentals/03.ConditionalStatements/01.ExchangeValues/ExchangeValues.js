/*
 Write an if statement that examines two integer
 variables and exchanges their values if the first one
 is greater than the second one.
 */

var jsConsole;
var button = document.getElementById('check');

button.onclick = checkAndExchangeValues;

function checkAndExchangeValues(){
    var firstNumber = jsConsole.readInteger('#first-number');
    var secondNumber = jsConsole.readInteger('#second-number');

    if(firstNumber > secondNumber){
        var temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;
    }

    jsConsole.writeLine('First number is: ' + firstNumber);
    jsConsole.writeLine('Second number is: ' + secondNumber);

    console.log('First number is: ' + firstNumber);
    console.log('Second number is: ' + secondNumber);
}