/*
 Sort 3 real values in descending order using nested if
 statements.
 */

var jsConsole;
var button = document.getElementById('sort');

button.onclick = sortNumber;

function sortNumber() {
    var firstNumber = jsConsole.readInteger('#first-number');
    var secondNumber = jsConsole.readInteger('#second-number');
    var thirdNumber = jsConsole.readInteger('#third-number');

    if (firstNumber >= secondNumber) {
        if (secondNumber >= thirdNumber) {
            jsConsole.writeLine('Sorted number in descending order is: '
                + firstNumber + ', ' + secondNumber + ', ' + thirdNumber);

            console.log('Sorted number in descending order is: '
                + firstNumber + ', ' + secondNumber + ', ' + thirdNumber);
        }
        else if (thirdNumber > firstNumber) {
            jsConsole.writeLine('Sorted number in descending order is: '
                + thirdNumber + ', ' + firstNumber + ', ' + secondNumber);

            console.log('Sorted number in descending order is: '
                + thirdNumber + ', ' + firstNumber + ', ' + secondNumber);
        }
        else {
            jsConsole.writeLine('Sorted number in descending order is: '
                + firstNumber + ', ' + thirdNumber + ', ' + secondNumber);

            console.log('Sorted number in descending order is: '
                + firstNumber + ', ' + thirdNumber + ', ' + secondNumber);
        }
    }
    else {
        if (secondNumber >= thirdNumber) {
            if (thirdNumber >= firstNumber) {
                jsConsole.writeLine('Sorted number in descending order is: '
                    + secondNumber + ', ' + thirdNumber + ', ' + firstNumber);

                console.log('Sorted number in descending order is: '
                    + secondNumber + ', ' + thirdNumber + ', ' + firstNumber);
            }
            else {
                jsConsole.writeLine('Sorted number in descending order is: '
                    + secondNumber + ', ' + firstNumber + ', ' + thirdNumber);

                console.log('Sorted number in descending order is: '
                    + secondNumber + ', ' + firstNumber + ', ' + thirdNumber);
            }
        }
        else {
            jsConsole.writeLine('Sorted number in descending order is: '
                + thirdNumber + ', ' + secondNumber + ', ' + firstNumber);

            console.log('Sorted number in descending order is: '
                + thirdNumber + ', ' + secondNumber + ', ' + firstNumber);
        }
    }
}
