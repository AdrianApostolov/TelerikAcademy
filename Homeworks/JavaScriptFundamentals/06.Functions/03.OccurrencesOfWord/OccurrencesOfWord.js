/*
 Write a function that finds all the occurrences of word in a text
 The search can case sensitive or case insensitive
 Use function overloading
 */

var jsConsole,
    firstButton = document.getElementById('check-sensitive'),
    secondButton = document.getElementById('check-insensitive');


firstButton.onclick = buttonFirst;
secondButton.onclick = buttonSecond;

function buttonFirst() {
    checkOccurrences(true)
}
function buttonSecond() {
    checkOccurrences(false)
}

function checkOccurrences(isCaseSensitive) {
    var inputText = jsConsole.read('#text');
    var inputWord = jsConsole.read('#word');
    var arrayOfWords;
    var occurrences = 0;

    if (isCaseSensitive === true) {
        inputText = inputText.toUpperCase();
        arrayOfWords = inputText.split(/\W+/);
        inputWord = inputWord.toUpperCase();

        for (var i = 0; i < arrayOfWords.length; i += 1) {

            if (arrayOfWords[i] === inputWord) {
                occurrences++;
            }
        }

        jsConsole.writeLine('Case sensitive occurrences: ' + occurrences);
        console.log('Case sensitive occurrences: ' + occurrences);
    }
    else {
        arrayOfWords = inputText.split(/\W+/);
        for (i = 0; i < arrayOfWords.length; i += 1) {

            if (arrayOfWords[i] === inputWord) {
                occurrences++;
            }
        }
        jsConsole.writeLine('Case insensitive occurrences: ' + occurrences);
        console.log('Case insensitive occurrences: ' + occurrences);
    }
}
