/*
 4. Write a function that by a given array of animals,
 groups them by species and sorts them by number of
 legs
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

    _.chain(animals)
        .sortBy(function (animal) {
            return animal.numberOfLegs;
        })
        .groupBy(function (animal) {
            return animal.species;
        })
        .each(function (animal) {
            console.log(animal);
            //console.log(JSON.stringify(animal));
        })
}());