/*
 Write a boolean expression that checks for given
 integer if it can be divided (without remainder) by 7
 and 5 in the same time.
*/

var jsConsole;
var button = document.getElementById('check');
button.onclick = checkNumber;

function checkNumber() {
    var inputNumber = (jsConsole.readInteger('#input'));

    if(inputNumber % 35 === 0){
        jsConsole.writeLine('Number ' + inputNumber + ' can be divided by 7 and 5.')
        console.log('Number ' + inputNumber + ' can be divided by 7 and 5.')
    }
    else{
        jsConsole.writeLine('Number ' + inputNumber + ' can not be divided by 7 and 5.')
        console.log('Number ' + inputNumber + ' can not be divided by 7 and 5.')
    }

}