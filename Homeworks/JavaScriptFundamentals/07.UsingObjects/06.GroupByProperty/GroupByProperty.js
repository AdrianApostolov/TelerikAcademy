/*
 Write a function that groups an array of people by age, first or last name.
 The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
 Use function overloading (i.e. just one function)

 Example:

 var people = {…};
 var groupedByFname = group(people, 'firstname');
 var groupedByAge= group(people, 'age');
 */

var jsConsole,
    people = [
        {firstName: 'Gosho', lastName: 'Petrov', age: 20},
        {firstName: 'Bay', lastName: 'Ivanov', age: 81},
        {firstName: 'Stamat', lastName: 'Ivanov', age: 12},
        {firstName: 'Pesho', lastName: 'Georgiev', age: 35},
        {firstName: 'Pesho', lastName: 'Petrov', age: 20}];


function group(arrayPeople, key) {
    var filterPeople = {};
    for (var i = 0; i < arrayPeople.length; i++) {
        var keyValue = arrayPeople[i][key];
        filterPeople[keyValue] = [];
        for (var k = 0; k < arrayPeople.length; k++) {
            if (keyValue == arrayPeople[k][key]) {
                filterPeople[keyValue].push(arrayPeople[k]);
            }
        }

    }
    return filterPeople;
}

var groupedByFname = group(people, "firstName");
var groupedByAge = group(people, "age");

for (var group in groupedByFname) {
    jsConsole.writeLine(group);
    console.log(group);
    for (var i = 0; i < groupedByFname[group].length; i++) {

        jsConsole.writeLine("FirstName: " + groupedByFname[group][i].firstName +
            "; LastName: " + groupedByFname[group][i].lastName + "; Age: " + groupedByFname[group][i].age);
        console.log("FirstName: " + groupedByFname[group][i].firstName +
            "; LastName: " + groupedByFname[group][i].lastName + "; Age: " + groupedByFname[group][i].age);
    }
}
for (var group in groupedByAge) {
    jsConsole.writeLine(group);
    console.log(group);
    for (i = 0; i < groupedByAge[group].length; i++) {

        jsConsole.writeLine("FirstName: " + groupedByAge[group][i].firstName +
            "; LastName: " + groupedByAge[group][i].lastName + "; Age: " + groupedByAge[group][i].age);
        console.log("FirstName: " + groupedByAge[group][i].firstName +
            "; LastName: " + groupedByAge[group][i].lastName + "; Age: " + groupedByAge[group][i].age);
    }
}