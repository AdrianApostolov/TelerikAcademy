/*
 Write a JavaScript function that replaces in a HTML document given as string all the tags
 <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 */

var jsConsole,
    button = document.getElementById('replace');

button.onclick = replaceTags;

function replaceTags() {
    var input = jsConsole.read('#input-html'),
        result = '';

    for (var i = 0; i < input.length; i += 1) {
        if (input[i] === '<' && input[i + 1] === 'a') {
            result += '[URL=';
            i += 8;
        } else if (input[i] === '"' && input[i + 1] === '>') {
            result += ']';
            i += 1;
        } else if (input[i] === '<' && input[i + 1]=== '/' && input[i + 2] === 'a') {
            result += '[/URL]';
            i += 3;
        } else {
            result += input[i];
        }
    }

    jsConsole.writeLine(result);
    console.log(result);
}


