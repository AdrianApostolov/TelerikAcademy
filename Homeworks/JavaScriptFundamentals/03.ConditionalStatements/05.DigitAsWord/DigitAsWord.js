/*
 Write script that asks for a digit and depending on
 the input shows the name of that digit (in English)
 using a switch statement.
 */

var jsConsole;
var button = document.getElementById('translate');

button.onclick = translateDigitAsWord;

function translateDigitAsWord() {
    var input = jsConsole.readInteger('#input-number');

    switch (input) {
        case 0:
            jsConsole.writeLine('The input digit is Zero');
            break;
        case 1:
            jsConsole.writeLine('The input digit is One');
            break;
        case 2:
            jsConsole.writeLine('The input digit is Two');
            break;
        case 3:
            jsConsole.writeLine('The input digit is Three');
            break;
        case 4:
            jsConsole.writeLine('The input digit is Four');
            break;
        case 5:
            jsConsole.writeLine('The input digit is Five');
            break;
        case 6:
            jsConsole.writeLine('The input digit is Six');
            break;
        case 7:
            jsConsole.writeLine('The input digit is Seven');
            break;
        case 8:
            jsConsole.writeLine('The input digit is Eight');
            break;
        case 9:
            jsConsole.writeLine('The input digit is Nine');
            break;
    }
}