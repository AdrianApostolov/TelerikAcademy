/*
 By an array of people find the most common first and
 last name. Use underscore.
 */

(function () {
    // Check if running on Node.js
    if (typeof require !== 'undefined') {
        // Load underscore.js on Node.js
        _ = require("../node_modules/underscore/underscore.js")
    }

    var people = [
        {firstName: 'Pesho', lastName: "Ivanov"},
        {firstName: 'Gosho', lastName: "Petrov"},
        {firstName: 'Gosho', lastName: "Stoev"},
        {firstName: 'Irina', lastName: "Metodieva"},
        {firstName: 'Andrei', lastName: "Andreev"},
        {firstName: 'Ivan', lastName: "Ivanov"},
        {firstName: 'Gosho', lastName: "Petrov"},
        {firstName: 'Ivan', lastName: "Stoev"},
        {firstName: 'Gosho', lastName: "Stoqnov"},
        {firstName: 'Andrei', lastName: "Andreev"}
    ];

    function findMostCommonBy(collection, searchParameter) {
        var mostCommon = _.chain(collection)
            .groupBy(searchParameter)
            .max(function (group) {
                return group.length;
            })
            .value();

        console.log(mostCommon[0][searchParameter] + ' --> ' + mostCommon.length + ' time(s)');
    }

    console.log('Most common first name:');
    findMostCommonBy(people, 'firstName');

    console.log('----------------');

    console.log('Most common last name:');
    findMostCommonBy(people, 'lastName');
}());