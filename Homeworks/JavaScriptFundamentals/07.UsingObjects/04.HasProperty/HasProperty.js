/*
 Write a function that checks if a given object contains a given property.

 var obj  = …;
 var hasProp = hasProperty(obj, 'length');
 */

var jsConsole,
    testObj = [1, 4, 6, 3, ['Pesho', 'Gosho', 2], [1, 5, 7]],
    testProperty = 'length';


function hasProperty(obj, property) {

    if (obj.hasOwnProperty(property)) {
        return true;
    }
}

jsConsole.writeLine('Object contains property' + testProperty + ': ' + hasProperty(testObj, testProperty));
console.log('Object contains property' + testProperty + ': ' + hasProperty(testObj, testProperty));
