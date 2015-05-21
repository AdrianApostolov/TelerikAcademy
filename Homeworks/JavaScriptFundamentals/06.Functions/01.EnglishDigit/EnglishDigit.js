/*
 Write a function that returns the last digit of given integer as an English word.
 Examples: 512 ? "two", 1024 ? "four", 12309 ? "nine".
 */
var jsConsole,
    button = document.getElementById('check'),
    lastDigit,
    inputNumber;

button.onclick = digitAsWord;

function digitAsWord() {
    inputNumber = jsConsole.readInteger("#number");

    lastDigit = inputNumber % 10;

    switch(lastDigit) {
        case 0:
            jsConsole.writeLine('The last digit is Zero');
            console.log('The last digit is Zero');
            break;
        case 1:
            jsConsole.writeLine('The last digit is One');
            console.log('The last digit is One');
            break;
        case 2:
            jsConsole.writeLine('The last digit is Two');
            console.log('The last digit is Two');
            break;
        case 3:
            jsConsole.writeLine('The last digit is Three');
            console.log('The last digit is Three');
            break;
        case 4:
            jsConsole.writeLine('The last digit is Four');
            console.log('The last digit is Four');
            break;
        case 5:
            jsConsole.writeLine('The last digit is Five');
            console.log('The last digit is Five');
            break;
        case 6:
            jsConsole.writeLine('The last digit is Six');
            console.log('The last digit is Six');
            break;
        case 7:
            jsConsole.writeLine('The last digit is Seven');
            console.log('The last digit is Seven');
            break;
        case 8:
            jsConsole.writeLine('The last digit is Eight');
            console.log('The last digit is Eight');
            break;
        case 9:
            jsConsole.writeLine('The last digit is Nine');
            console.log('The last digit is Nine');
            break;
    }
}