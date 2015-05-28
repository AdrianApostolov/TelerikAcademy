/*
 Write a function that replaces non breaking white-spaces in a text with &nbsp;
 */

var jsConsole,
    text = 'We are living in an yellow submarine. We don\'t have anything else. ' +
        'Inside the submarine is very tight. So we are drinking all the day. ' +
        'We will move out of it in 5 days.',
    result = '';

function replaceWhiteSpaces(text) {

    result = text.replace(/ /g, '&nbsp');

    return result;
}


console.log(text);
console.log(replaceWhiteSpaces(text));