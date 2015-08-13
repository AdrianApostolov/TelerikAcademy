/*
 2. Write function that finds the first name and last
 name of all students with age between 18 and 24.
 Use Underscore.js
 */

(function () {
    // Check if running on Node.js
    if (typeof require !== 'undefined') {
        // Load underscore.js on Node.js
        _ = require("../node_modules/underscore/underscore.js")
    }

    var students = [
        {firstName: 'Pesho', lastName: "Ivanov", age: 18},
        {firstName: 'Gosho', lastName: "Petrov", age: 28},
        {firstName: 'Ivan', lastName: "Stoev", age: 21},
        {firstName: 'Irina', lastName: "Stoqnova", age: 35},
        {firstName: 'Andrei', lastName: "Andreev", age: 23}
    ];

    _.chain(students)
        .filter(function (student) {
            return student.age >= 18 && 24 >= student.age
        })
        .each(function (student) {
            console.log(student.firstName + ' ' + student.lastName +
                        ' is ' + student.age + ' year old');
        })
}());