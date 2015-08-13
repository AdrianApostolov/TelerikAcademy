/*
 1. Write a method that from a given array of students
 finds all students whose first name is before its last
 name alphabetically.
 Print the students in descending order by full name.
 Use Underscore.js
 */

(function () {
    // Check if running on Node.js
    if (typeof require !== 'undefined') {
        // Load underscore.js on Node.js
        _ = require("../node_modules/underscore/underscore.js")
    }

    var students = [
        {firstName : 'Pesho', lastName : "Ivanov"},
        {firstName : 'Gosho', lastName : "Petrov"},
        {firstName : 'Ivan', lastName : "Stoev"},
        {firstName : 'Irina', lastName : "Stoqnova"},
        {firstName : 'Andrei', lastName : "Andreev"}
    ];

    _.chain(students)
        .filter(function (student) {
           return student.firstName.toLowerCase() < student.lastName.toLowerCase();
        })
        .sortBy(function (student) {
          return student.firstName;
        })
        .each(function (student) {
          console.log(student.firstName + ' ' + student.lastName);
        })
}());