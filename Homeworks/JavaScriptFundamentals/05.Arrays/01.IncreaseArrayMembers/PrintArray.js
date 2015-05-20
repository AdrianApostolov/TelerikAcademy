/*
 Write a script that allocates array of 20 integers and
 initializes each element by its index multiplied by 5.
 Print the obtained array on the console.
 */

var jsConsole;

var arr = [];

for(i = 0; i < 20; i++){

    arr[i] = i * 5;
}

jsConsole.writeLine(arr.join(', '));
console.log(arr.join(', '));