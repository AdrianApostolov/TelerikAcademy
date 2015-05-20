/*
 Write a script that finds the maximal increasing sequence in an array.
 Example: {3, 2, 3, 4, 2, 2, 4} ? {2, 3, 4}.
 */
var jsConsole;
var arr = [3, 2, 3, 4, 2, 2, 4];

var currentSequence = 1,
    maxSequence = currentSequence,
    sequenceStart;

for (var i = 1; i < arr.length; i+=1){

    if(arr[i] - 1 === arr[i - 1]){
        currentSequence++;
    }
    else{
        currentSequence = 1;
    }

    if(currentSequence > maxSequence){
        maxSequence = currentSequence;
        sequenceStart = i + 1 - maxSequence;
    }
}

jsConsole.write('{');
console.log('{');

for (var j = sequenceStart; j < sequenceStart + maxSequence; j+=1){

    if(sequenceStart + maxSequence - 1 === j){
        jsConsole.write(arr[j]);
        console.log(arr[j]);
        break;
    }
    jsConsole.write(arr[j] + ', ');
    console.log(arr[j] + ', ');
}

jsConsole.write('}');
console.log('}');