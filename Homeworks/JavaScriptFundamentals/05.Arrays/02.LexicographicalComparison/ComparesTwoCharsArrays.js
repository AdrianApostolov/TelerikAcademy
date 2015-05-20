/*
 Write a script that compares two char arrays
 lexicographically (letter by letter).
 */

var jsConsole;

var firstArr = ['p','e','s','h','o'];
var secondArr = ['g','o','s','h','o'];


var isCharEqual = true;
if (firstArr.length === secondArr.length) {

    for (var i = 0; i < firstArr.length; i++) {

        if (firstArr[i] !== secondArr[i]) {
            isCharEqual = false;
            break;
        }


    }
}
else {
    isCharEqual = false;
}

jsConsole.writeLine('Is char arrays equal?: ' + isCharEqual);
console.log('Is char arrays equal?: ' + isCharEqual);