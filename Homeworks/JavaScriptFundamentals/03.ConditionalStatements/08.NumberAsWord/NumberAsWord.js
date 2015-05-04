/*
 Write a script that converts a number in the range
 [0...999] to a text corresponding to its English
 pronunciation. Examples:
 0 ? 'Zero'
 273 ? 'Two hundred seventy three'
 400 ? 'Four hundred'
 501 ? 'Five hundred and one'
 711 ? 'Seven hundred and eleven'
 */

var jsConsole;
var button = document.getElementById('translate');

button.onclick = translateNumberAsWords;

function translateNumberAsWords() {
    var input = jsConsole.readInteger('#input-number');

    if (input <= 0 || input > 999 || isNaN(input)) {
        alert('The number should be between 0 and 999!');
        return;
    }

    var hundreds = Math.floor( input / 100);
    var tens = Math.floor(input / 10)% 10;
    var digits = input % 10;
    var special = 10 + digits;
    var specialText = "";
    var hundredsText = "";
    var tensText = "";
    var digitsText;

    switch (special) {
        case 11:
            specialText = "eleven";
            break;
        case 12:
            specialText = "twelve";
            break;
        case 13:
            specialText = "thirteen";
            break;
        case 14:
            specialText = "fourteen";
            break;
        case 15:
            specialText = "fifteen";
            break;
        case 16:
            specialText = "sixteen";
            break;
        case 17:
            specialText = "seventeen";
            break;
        case 18:
            specialText = "eighteen";
            break;
        case 19:
            specialText = "nineteen";
            break;
    }

    switch (hundreds) {
        case 1:
            hundredsText = 'one hundred';
            break;
        case 2:
            hundredsText = 'two hundred';
            break;
        case 3:
            hundredsText = 'three hundred';
            break;
        case 4:
            hundredsText = 'four hundred';
            break;
        case 5:
            hundredsText = 'five hundred';
            break;
        case 6:
            hundredsText = 'six hundred';
            break;
        case 7:
            hundredsText = 'seven hundred';
            break;
        case 8:
            hundredsText = 'eight hundred';
            break;
        case 9:
            hundredsText = 'nine hundred';
            break;
        case 0:
            hundredsText = '';
            break;
    }
    if (input % 100 !== 0 && input >= 100) {
        hundredsText = hundredsText + ' and ';
    }
    if (tens === 1 && digits > 0) {
        jsConsole.writeLine(hundredsText + specialText);
        console.log(hundredsText + specialText);
        hundredsText = '';
        tensText = '';
    }

    switch (tens) {
        case 1:
            tensText = 'ten';
            break;
        case 2:
            tensText = 'twenty';
            break;
        case 3:
            tensText = 'thirty';
            break;
        case 4:
            tensText = 'forty';
            break;
        case 5:
            tensText = 'fifty';
            break;
        case 6:
            tensText = 'sixty';
            break;
        case 7:
            tensText = 'seventy';
            break;
        case 8:
            tensText = 'eighty';
            break;
        case 9:
            tensText = 'ninety';
            break;
        case 0:
            tensText = '';
            break;
    }

    switch (digits) {
        case 1:
            digitsText = 'one';
            break;
        case 2:
            digitsText = 'two';
            break;
        case 3:
            digitsText = 'three';
            break;
        case 4:
            digitsText = 'four';
            break;
        case 5:
            digitsText = 'five';
            break;
        case 6:
            digitsText = 'six';
            break;
        case 7:
            digitsText = 'seven';
            break;
        case 8:
            digitsText = 'eight';
            break;
        case 9:
            digitsText = 'nine';
            break;
        default:
            digitsText = '';
            break;
    }

    if (input === 0) {
        jsConsole.writeLine('Zero');
        console.log('Zero');
        hundredsText = '';
        tensText = '';
        digitsText = '';
    }
    if (input <= 10 || input >= 20) {
        jsConsole.writeLine(hundredsText + tensText + ' ' + digitsText);
        console.log(hundredsText + tensText + ' ' + digitsText);
    }
}