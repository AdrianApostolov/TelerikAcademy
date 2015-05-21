/*
 Write a function that counts how many times given number appears in given array.
 Write a test function to check if the function is working correctly.
 */

var jsConsole,
    counter = 0,
    i,
    numbers = [1, 5, 8, 2, 4, 8, 8, 7],
    number = 8;


function countNumberAppears() {
    for (i = 0; i < numbers.length; i += 1) {
        if (numbers[i] === number) {
            counter++;
        }
    }
    return counter;
}

function testFunction(expected){
    return countNumberAppears() === expected;
}
jsConsole.writeLine('The given number ' + number + ' appears '
    + countNumberAppears() + ' time(s).');
jsConsole.writeLine('Is countNumberAppears() function working correctly: '
    + testFunction(counter));

console.log('The given number ' + number + ' appears '
    + countNumberAppears() + ' time(s).');
console.log('Is countNumberAppears() function working correctly: '
    + testFunction(counter));