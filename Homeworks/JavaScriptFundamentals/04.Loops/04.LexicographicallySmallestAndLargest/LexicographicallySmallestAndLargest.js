/*
 Write a script that finds the lexicographically
 smallest and largest property in document, window
 and navigator objects.
 */

var jsConsole;

function getProperties(element) {
    var elements = Object.getOwnPropertyNames(element);
    elements.sort();

    jsConsole.writeLine("Element " + element.toString());
    jsConsole.writeLine("Lexicographically first: " + elements[0] +
        " and last: " + elements[elements.length - 1]);
    jsConsole.writeLine();
}
getProperties(document);
getProperties(window);
getProperties(navigator);