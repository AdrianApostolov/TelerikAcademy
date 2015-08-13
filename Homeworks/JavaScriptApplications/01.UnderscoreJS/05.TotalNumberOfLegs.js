/*
 By a given array of animals, find the total number of
 legs
 ? Each animal can have 2, 4, 6, 8 or 100 legs
 */

(function () {
    // Check if running on Node.js
    if (typeof require !== 'undefined') {
        // Load underscore.js on Node.js
        _ = require("../node_modules/underscore/underscore.js")
    }

    var animals = [
        {species: 'mammals', family: 'dog', numberOfLegs: 4},
        {species: 'mammals', family: 'cat', numberOfLegs: 4},
        {species: 'fish', family: 'carp', numberOfLegs: 0},
        {species: 'birds', family: 'parrot', numberOfLegs: 2},
        {species: 'fish', family: 'shark', numberOfLegs: 0},
        {species: 'insects', family: 'bee', numberOfLegs: 6},
        {species: 'amphibians', family: 'frog', numberOfLegs: 4}];

    var totalNumberOfLegs = _.chain(animals)
        .reduce(function (totalNumberOfLegs, animal) {
            return totalNumberOfLegs + animal.numberOfLegs;
        }, 0);

    console.log('Total number of legs: ' + totalNumberOfLegs);

}());