/*
 Write a script that prints all the numbers from 1 to
 N, that are not divisible by 3 and 7 at the same time
 */

var jsConsole;
var button = document.getElementById('print');

button.onclick = printNumbers;

function printNumbers() {
    var n = jsConsole.readInteger('#input');

    for (var i = 1; i <= n; i++) {

        if (i % 3 === 0 && i % 7 === 0 ) {
            continue;
        }

        if (i === n) {
            jsConsole.write(i);
            console.log(i);
            break;
        }
        jsConsole.write(i + ', ');
        console.log(i + ', ');
    }
}