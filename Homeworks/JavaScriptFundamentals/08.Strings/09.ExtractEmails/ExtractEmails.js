/*
 Write a function for extracting all email addresses from given text.
 All sub-strings that match the format @… should be recognized as emails.
 Return the emails as array of strings.
 */


var jsConsole,
    text = 'Hello my name is Balkan, my email address is ' +
        "BalkanSuperman@yahoo.com and i can't get in to my account and i forgot my password?" +
        "My another email is balkan_bicarata@gmail.com please send me password there";

extractEmails(text);

function extractEmails(text) {
    var words = text.split(' '),
        result = [];

    for (var i = 0; i < words.length; i++) {
        if (words[i].indexOf("@") > 0) {

            if (words[i][words[i].length - 1] == '.') {

                words[i] = words[i].substr(0, words[i].length - 1);
            }

            if (words[i].indexOf(".") > 0) {

                if (words[i].indexOf('@') < words[i].indexOf('.')) {

                    result.push(words[i]);
                }
            }
        }
    }

    for (i in result) {
        console.log(result[i]);
        jsConsole.writeLine(result[i]);
    }
}
