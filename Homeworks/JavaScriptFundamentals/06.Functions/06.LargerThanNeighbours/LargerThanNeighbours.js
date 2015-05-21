/*
 Write a function that checks if the element at given position in given array
 of integers is bigger than its two neighbours (when such exist).
 */

var jsConsole,
    arrayNumbers = [5,12,8,33,40,21,58,44,89,23,76],
    position = 6,
    isLarger;
function checkIfLargerThanNeighbours(array, position){


    if (position < array.length - 1 && position > 0)
    {
        if ((array[position] > array[position + 1]) && (array[position] > array[position - 1]))
        {
           return isLarger = true;
        }
    }

    return isLarger = false;
}

jsConsole.writeLine('Test array is [' + arrayNumbers + ']');
console.log('Test array is [' + arrayNumbers + ']');


jsConsole.writeLine('Test position is ' + position);
console.log('Test position is ' + position);


jsConsole.writeLine('Larger than neighbors: ' +
    checkIfLargerThanNeighbours(arrayNumbers, position));
console.log('Larger than neighbors: ' +
    checkIfLargerThanNeighbours(arrayNumbers, position));


