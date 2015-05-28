/*
 Write a JavaScript function that finds how many times a substring is contained in a given text
 (perform case insensitive search).

 Example:
 The target sub-string is in

 The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine
 is very tight. So we are drinking all the day. We will move out of it in 5 days.

 The result is: 9
 */

var jsConsole,
    text = 'We are living in an yellow submarine. We don\'t have anything else. ' +
        'Inside the submarine is very tight. So we are drinking all the day. ' +
        'We will move out of it in 5 days.',
    searchedSubstring = 'in',
    counter = 0;


function substringCounter(text, substringForSearch) {

    for (var i = 0; i <= text.length - substringForSearch.length; i += 1) {
        var substring = text.substr(i, substringForSearch.length);
        if (substringForSearch.toLowerCase() === substring.toLowerCase()) {
            counter += 1;
        }
    }

    return counter;
}

jsConsole.writeLine('The result is: ' + substringCounter(text, searchedSubstring));
console.log('The result is: ' + substringCounter(text, searchedSubstring));
