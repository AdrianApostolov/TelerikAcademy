/*
 Write a function that reverses the digits of given decimal number.
 Example: 256 ? 652.
 */

var jsConsole,
    button = document.getElementById('check'),
    inputNumber,
    reversed;

button.onclick = reverseNumber;

function reverseNumber(){
 inputNumber = jsConsole.readInteger('#number');

 reversed = inputNumber.toString().split('').reverse().join('');

 jsConsole.writeLine('Normal number is: ' + inputNumber);
 console.log('Normal number is: ' + inputNumber);

 jsConsole.writeLine('Reversed number is: ' + reversed);
 console.log('Reversed number is: ' + reversed);
}