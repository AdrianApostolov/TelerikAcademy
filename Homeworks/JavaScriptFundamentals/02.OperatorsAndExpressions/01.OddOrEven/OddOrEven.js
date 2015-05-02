//Write an expression that checks if given integer is odd or even.

var jsConsole;
var button = document.getElementById('check');
button.onclick = checkNumber;

function checkNumber(){
    var inputNumber = jsConsole.readInteger('#input');

    if(inputNumber % 2 === 0){
        jsConsole.writeLine('Number ' + inputNumber + ' is even')
    }
    else{
        jsConsole.writeLine('Number ' + inputNumber + ' is odd')
    }
}