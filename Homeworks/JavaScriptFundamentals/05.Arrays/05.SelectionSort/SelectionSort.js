/*
 Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 Hint: Use a second array
 */
var jsConsole,
    arrayNumbers = [2, 11, 23, 5, 1, 19, 8],
    temp, i, j;

for (i = 0; i < arrayNumbers.length - 1; i += 1) {

    for (j = i + 1; j < arrayNumbers.length; j += 1) {

        if (arrayNumbers[i] > arrayNumbers[j]) {
            temp = arrayNumbers[i];
            arrayNumbers[i] = arrayNumbers[j];
            arrayNumbers[j] = temp;
        }
    }
}
jsConsole.write('Selection sorted array is: [' + arrayNumbers + ']');
console.log('Selection sorted array is: [' + arrayNumbers + ']');