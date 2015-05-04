/*
 Write a script that prints all the numbers from 1 to N
 */

var jsConsole;
var button = document.getElementById('print');

button.onclick = printNumbers;

function printNumbers(){
    var n = jsConsole.readInteger('#input');

    for (var i = 1; i <= n; i++){

        if(i === n){
            jsConsole.write(i);
            console.log(i);
            break;
        }
        jsConsole.write(i + ', ');
        console.log(i + ', ');
    }
}