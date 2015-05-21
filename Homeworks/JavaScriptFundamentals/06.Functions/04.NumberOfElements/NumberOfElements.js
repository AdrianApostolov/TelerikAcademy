/*
 Write a function to count the number of div elements on the web page.
 */

var jsConsole,
    divs,
    divsCount;


function divsCounter() {
    divs = document.getElementsByTagName('div');
    divsCount = divs.length;

    jsConsole.writeLine('The number of div elements is: ' + divsCount);
    console.log('The number of div elements is: ' + divsCount);
}

divsCounter();
