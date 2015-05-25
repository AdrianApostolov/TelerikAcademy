/*
 Write a function that finds the youngest person in a given array of people and prints his/hers full name
 Each person has properties firstname, lastname and age.

 Example:

 var people = [
 { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
 { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];
 */

var jsConsole,
    people = [
        {firstName: 'Gosho', lastName: 'Petrov', age: 32},
        {firstName: 'Bay', lastName: 'Ivan', age: 81},
        {firstName: 'Stamat', lastName: 'Ivanov', age: 12},
        {firstName: 'Pesho', lastName: 'Georgiev', age: 35}];


function findYoungestPerson(people) {
    var youngestPerson = 0,
        person = {};

    for (var i = 0; i < people.length - 1; i += 1) {
        if (people[i].age < people[i + 1].age) {
            youngestPerson = people[i].age;
            person = people[i];
        }
    }

    return person;
}


jsConsole.writeLine('The youngest person: ' + JSON.stringify(findYoungestPerson(people)));
console.log('The youngest person: ' + JSON.stringify(findYoungestPerson(people)));
