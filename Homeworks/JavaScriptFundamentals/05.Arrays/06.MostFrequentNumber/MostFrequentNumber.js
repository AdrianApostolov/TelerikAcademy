/*
 Write a program that finds the most frequent number in an array.
 Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} ? 4 (5 times)
 */

var jsConsole,
    arrayNumbers = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    maxCount = 0,
    counter = 1,
    number = Number.MIN_VALUE, i;

if(arrayNumbers.length === 1){
    maxCount = 1;
    number = arrayNumbers[0];
}

arrayNumbers.sort();

for(i = 1; i < arrayNumbers.length; i+=1){
    if(arrayNumbers[i] === arrayNumbers[i -1]){
        counter++;
    }
    else{
        counter = 1;
    }

    if(counter > maxCount){
        maxCount = counter;
        number = arrayNumbers[i];
    }
}

jsConsole.write('Most frequent number in an array is: '
    + number + ' (' + maxCount +' times)');

console.log('Most frequent number in an array is: '
+ number + ' (' + maxCount +' times)');