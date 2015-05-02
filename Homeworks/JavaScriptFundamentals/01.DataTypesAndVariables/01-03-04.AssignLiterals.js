//01.Assign all the possible JavaScript literals to different variables.
//03.Try typeof on all variables you created
//04.Create null, undefined variables and try typeof on them.

var jsConsole;
var integer = 123;
var float = 3.14;
var string = 'Stamat';
var boolean = true;
var array = ['BMW', 'Mercedes', 'Audi'];
var object = {firstName: 'Pesho', lastName: 'Goshov', age: 30};
var nullVariable = null;
var undefinedVariable;

var variables = [integer, float, string, boolean, array, object, nullVariable, undefinedVariable];

for (var i = 0; i < variables.length; i++) {
    console.log('Type is:', typeof (variables[i]));
}

for (var i = 0; i < variables.length; i++) {
    jsConsole.write('Type of ' + JSON.stringify(variables[i]) + ' is: ');
    jsConsole.writeLine((typeof (variables[i])));
}