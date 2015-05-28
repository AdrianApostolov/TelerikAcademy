/*
 Write a function that formats a string using placeholders.
 The function should work with up to 30 placeholders and all types.
 Examples:

 var str = stringFormat('Hello {0}!', 'Peter');
 //str = 'Hello Peter!';

 var frmt = '{0}, {1}, {0} text {2}';
 var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
 //str = '1, Pesho, 1 text Gosho'
 */

var jsConsole;


function stringFormat() {
    var string = arguments[0],
        placeholder;

    if (arguments.length > 1) {
        for (var i = 1; i < arguments.length; i += 1)  {
            placeholder = "{" + (i - 1) + "}";
            for (var j = 0; j < string.length; j+=1) {
                string = string.replace(placeholder, arguments[i]);
            }
        }
    }

    return string;
}

jsConsole.writeLine(stringFormat('{0}, {1}, {0} text {2}',  1, 'Pesho', 'Gosho'));
console.log(stringFormat('{0}, {1}, {0} text {2}',  1, 'Pesho', 'Gosho'));