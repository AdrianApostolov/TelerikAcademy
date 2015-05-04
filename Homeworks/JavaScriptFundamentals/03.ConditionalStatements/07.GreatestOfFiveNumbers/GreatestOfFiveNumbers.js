/*
 Write a script that finds the greatest of given 5
 variables.
 */

var jsConsole;
var button = document.getElementById('check');

button.onclick = checkGreatestVariable;

function checkGreatestVariable() {
    var firstNumber = jsConsole.readInteger('#first-number');
    var secondNumber = jsConsole.readInteger('#second-number');
    var thirdNumber = jsConsole.readInteger('#third-number');
    var fourthNumber = jsConsole.readInteger('#fourth-number');
    var fifthNumber = jsConsole.readInteger('#fifth-number');

    var arr = [fifthNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber];

    var greatestNumber = firstNumber;

    for(var i=1; i<=arr.length; i++){
        if(arr[i] > greatestNumber){
            greatestNumber = arr[i];
        }
    }

    jsConsole.writeLine('The greatest number is: ' + greatestNumber);
    console.log('The greatest number is: ' + greatestNumber);

}