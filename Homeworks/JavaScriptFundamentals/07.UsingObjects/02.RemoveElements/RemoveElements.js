/*
 Write a function that removes all elements with a given value.
 Attach it to the array type.
 Read about prototype and how to attach methods.

 var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
 arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];
 */

var jsConsole,
    arrayNumbers = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
    removeNumber = 1;


Array.prototype.remove = function (array, removeNumber) {
    for (var i = 0; i < array.length; i+=1) {
        if (removeNumber === array[i]) {
            array.splice(i, 1);
        }
    }
    return array;
};

//jsConsole.writeLine('Array is: ' + arrayNumbers);
console.log(arrayNumbers);

//jsConsole.writeLine('Array after remove elements is: ' + arrayNumbers.remove(arrayNumbers, removeNumber));
console.log(arrayNumbers.remove(arrayNumbers, removeNumber));