/* Task description */
/*
 Write a function a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `string`
 3) it must throw an Error if any of the range params is missing
 */

function solve(from, to) {
    var primeNumbers = [],
        currentNumber,
        i;

    function isPrime(number) {
        var start = 2;
        while (start <= Math.sqrt(number)) {
            if (number % start++ < 1) return false;
        }
        return number > 1;
    }

    if (arguments.length === 0 || arguments.length === 1) {
        throw new Error;
    }

    if (isNaN(from) || isNaN(to)) {
        throw new Error;
    }

    for (i = from | 0; i <= to | 0; i += 1) {
        currentNumber = i;
        if (isPrime(currentNumber)) {
            primeNumbers.push(currentNumber);
        }
    }

    return primeNumbers;
}

module.exports = solve;