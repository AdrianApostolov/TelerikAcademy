/*
 Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
 Use the function from the previous exercise.
 */

var jsConsole,
    arrayNumbers = [5, 12, 8, 33, 40, 21, 58, 44, 89, 23, 76],
    i;

function checkFirstLargerThanNeighbours(array) {
    var index = -1;
    for (i = 0; i < array.length; i += 1) {

        if (i < array.length - 1 && i > 0) {
            if ((array[i] > array[i + 1]) && (array[i] > array[i - 1])) {
                return index = i;
            }
            else {
                return index;
            }

        }
    }
}

jsConsole.writeLine('Test array is [' + arrayNumbers + ']');
console.log('Test array is [' + arrayNumbers + ']');

jsConsole.writeLine('Index of the first element in array that ' +
    'is larger than its neighbours: ' + checkFirstLargerThanNeighbours(arrayNumbers));
console.log('Index of the first element in array that ' +
    'is larger than its neighbours: ' + checkFirstLargerThanNeighbours(arrayNumbers));