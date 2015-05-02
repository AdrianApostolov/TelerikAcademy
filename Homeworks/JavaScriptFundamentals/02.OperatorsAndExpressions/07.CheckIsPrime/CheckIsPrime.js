/*
 Write an expression that checks if given positive
 integer number n (n ? 100) is prime. E.g. 37 is prime.
 */

var jsConsole;
var button = document.getElementById('check');

button.onclick = checkIsPrime;

function checkIsPrime() {
    var input = jsConsole.readInteger('input');

    if (input <= 0 || input > 100 || isNaN(input)) {
        alert('The number should be between 0 and 100!');
        return;
    }

    if (input === 1 || input === 2) {
        jsConsole.writeLine('The number ' + input + ' is prime');
        console.log('The number ' + input + ' is prime');
    }

    for (var i = 2; i < Math.sqrt(input); i++) {


        if (input % 2 === 0 && input > 2) {
            jsConsole.writeLine('The number ' + input + ' is NOT prime');
            console.log('The number' + input + 'is NOT prime');
            return;
        }
    }

    jsConsole.writeLine('The number ' + input + ' is prime');
    console.log('The number ' + input + ' is prime');
}