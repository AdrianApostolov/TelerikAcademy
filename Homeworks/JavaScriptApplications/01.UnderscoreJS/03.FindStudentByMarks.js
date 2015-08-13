/*
 3. Write a function that by a given array of students
 finds the student with highest marks
 */

(function () {
    // Check if running on Node.js
    if (typeof require !== 'undefined') {
        // Load underscore.js on Node.js
        _ = require("../node_modules/underscore/underscore.js")
    }

    var students = [
        {firstName: 'Pesho', lastName: "Ivanov", marks: [2, 5, 6, 6, 2]},
        {firstName: 'Gosho', lastName: "Petrov", marks: [4, 5, 6, 3, 6]},
        {firstName: 'Ivan', lastName: "Stoev", marks: [6, 5, 6, 6, 2]},
        {firstName: 'Irina', lastName: "Stoqnova", marks: [4, 5, 3, 4, 4]},
        {firstName: 'Andrei', lastName: "Andreev", marks: [5, 6, 6, 6, 5]}
    ];
    var studentWithHighestMarks = [],
        highestAverageMark = 0;

    _.chain(students)
        .each(function (student) {
            var studentAverageMark = _.reduce(student.marks, function (sum, n) {
                return sum + n;
            }) / student.marks.length;

            if (studentAverageMark > highestAverageMark) {
                studentWithHighestMarks = [];
                highestAverageMark = studentAverageMark;
            }

            if (studentAverageMark === highestAverageMark) {
                studentWithHighestMarks.push(student);
            }
        });

        console.log(JSON.stringify(studentWithHighestMarks[0]));
}());