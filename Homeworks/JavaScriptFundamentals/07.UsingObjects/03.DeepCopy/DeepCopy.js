/*
 Write a function that makes a deep copy of an object.
 The function should work for both primitive and reference types.
 */

var jsConsole,
    cloned,
    testObject = [1,4,6,3, ['Pesho', 'Gosho', 2], [1,5,7]];

function cloneObject(obj) {

    var clone = obj instanceof Array ? [] : {};
    for (var i in obj) {
        if (obj.hasOwnProperty(i)) {
            if (typeof(obj[i]) == "object" && obj[i] != null)
                clone[i] = cloneObject(obj[i]);
            else
                clone[i] = obj[i];
        }
    }
    return clone;
}
cloned = cloneObject(testObject);

jsConsole.writeLine('Initial array is: ' + JSON.stringify(testObject));
jsConsole.writeLine('Cloned array is: ' +JSON.stringify(cloned));

jsConsole.writeLine(testObject === cloned);