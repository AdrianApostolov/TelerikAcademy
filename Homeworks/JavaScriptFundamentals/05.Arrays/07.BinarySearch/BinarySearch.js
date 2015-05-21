/*
 Write a program that finds the index of given element in a sorted array
 of integers by using the Binary search algorithm.
 */

var jsConsole,
    array = [1, 6, 12, 15, 19, 21, 33, 45, 54, 60, 66, 76, 80, 96, 100, 104, 115, 123],
    button = document.getElementById('check'),
    searchNumber,
    start = 0,
    end = array.length,
    index;

button.onclick = getIndex;

jsConsole.writeLine('Test array is: [' + array + ']');
console.log('Test array is: [' + array + ']');

function getIndex() {
    searchNumber = jsConsole.readInteger('#search-number');

    while ((end - start) >= 1) {

        index = start + (((end - start) / 2) | 0);

        if (array[index] === searchNumber) {
            jsConsole.writeLine(searchNumber + ' is at position ' + index);
            console.log(searchNumber + ' is at position ' + index);
            return;
        }
        else if (array[index] > searchNumber) {
            end = index;
        }
        else if (array[index] < searchNumber) {
            start = index;
        }
    }

    jsConsole.writeLine("Number not found!");
    console.log("Number not found!");
}
