/*
 Write a JavaScript function that reverses a string and returns it.
 Example:

 input	output
 sample	elpmas
 */

var jsConsole,
    button = document.getElementById('reverse');

button.onclick = reverseString;

function reverseString() {
    var input = jsConsole.read('#input');
    var reveredInput =  [].map.call(input, function (x) {return x;}).reverse().join('');

    jsConsole.writeLine('Input string is: ' + input);
    jsConsole.writeLine('Reversed input string is: ' + reveredInput);

    console.log('Input string is: ' + input);
    console.log('Reversed input string is: ' + reveredInput);
}

