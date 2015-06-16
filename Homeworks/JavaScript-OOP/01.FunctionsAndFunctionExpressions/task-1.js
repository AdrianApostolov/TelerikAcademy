/* Task Description */
/* 
 Write a function that sums an array of numbers:
 numbers must be always of type Number
 returns `null` if the array is empty
 throws Error if the parameter is not passed (undefined)
 throws if any of the elements is not convertible to Number

 */

function sum(input) {
    function isNotANumber(element, index, array) {
        return isNaN(element);
    }

    if (input === 'undefined') {
        throw new Error;
    } else if (input.length === 0) {
        return null;
    } else if (input.some(isNotANumber)) {
        throw new Error;
    }

    return input.reduce(function (result, item) {
        return result += +item;
    }, 0);
}

module.exports = sum;