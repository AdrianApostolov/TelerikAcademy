/*
 Write a script that finds the max and min number
 from a sequence of numbers
 */

var jsConsole;
var button = document.getElementById('find');

button.onclick = findMinAndMaxNumber;

function getSequence() {
    var sequence = jsConsole.read('#input').split(',');

    return sequence;
}

function findMinAndMaxNumber() {
    var numbers = getSequence();
    var maxNumber = Number.MIN_VALUE;
    var minNumber = Number.MAX_VALUE;

    for (var i = 0; i < numbers.length; i++) {
        if (maxNumber < numbers[i] * 1) {
            maxNumber = numbers[i] * 1;
        }

        if (minNumber > numbers[i] * 1) {
            minNumber = numbers[i] * 1;
        }
    }

    jsConsole.writeLine('Max number is: ' + maxNumber);
    jsConsole.writeLine('Min number is: ' + minNumber);

    console.log('Max number is: ' + maxNumber);
    console.log('Min number is: ' + minNumber);
}