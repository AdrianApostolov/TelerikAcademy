/*
 Write a JavaScript function to check if in a given expression the brackets are put correctly.
 Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

var jsConsole,
    firstExpression = '((a+b)/5-d)',
    secondExpression = ')(a+b))',
    brackets = 0;


function isBracketsCorrect(expression) {
    var isCorrect = false;

    for (var i = 0; i < expression.length; i += 1) {

        if (expression[i] === '(') {
            brackets += 1;
        }
        else if (expression[i] === ')') {
            brackets -= 1;
        }
    }

    if (brackets === 0) {
        isCorrect = true;
    }

    return isCorrect;
}

jsConsole.writeLine('Is brackets correct: ' + isBracketsCorrect(firstExpression));
console.log('Is brackets correct: ' + isBracketsCorrect(firstExpression));

jsConsole.writeLine('Is brackets correct: ' + isBracketsCorrect(secondExpression));
console.log('Is brackets correct: ' + isBracketsCorrect(secondExpression));