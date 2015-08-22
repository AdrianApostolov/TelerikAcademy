/* 
 Create a function that:
 *   **Takes** an array of animals
 *   Each animal has propeties `name`, `species` and `legsCount`
 *   **groups** the animals by `species`
 *   the groups are sorted by `species` descending
 *   **sorts** them ascending by `legsCount`
 *	if two animals have the same number of legs sort them by name
 *   **prints** them to the console in the format:

 ```
 ----------- (number of underscores is equal to the length of the GROUP_1_NAME + 1)
 GROUP_1_NAME:
 ----------- (number of underscores is equal to the length of the GROUP_1_NAME + 1)
 NAME has LEGS_COUNT legs //for the first animal in group 1
 NAME has LEGS_COUNT legs //for the second animal in group 1
 ----------- (number of underscores is equal to the length of the GROUP_2_NAME + 1)
 GROUP_2_NAME:
 ----------- (number of underscores is equal to the length of the GROUP_2_NAME + 1)
 NAME has LEGS_COUNT legs //for the first animal in the group 2
 NAME has LEGS_COUNT legs //for the second animal in the group 2
 NAME has LEGS_COUNT legs //for the third animal in the group 2
 NAME has LEGS_COUNT legs //for the fourth animal in the group 2
 ```
 *   **Use underscore.js for all operations**
 */

function solve() {
    return function (animals) {

        var groupedAndSortedAnimals = _.chain(animals)
            .sortBy(function (animal) {
                return animal.species;
            })
            .reverse()
            .groupBy(function (animal) {
                return animal.species;
            })
            .value();


        _.each(groupedAndSortedAnimals, function (values, key) {
            var sortedAnimals =  _.chain(values)
                .sortBy('legsCount')
                .sortBy(sortedAnimals, 'name')
                .value();

            console.log(new Array(key.length + 2).join('-'));
            console.log(key + ':');
            console.log(new Array(key.length + 2).join('-'));

            _.each(sortedAnimals, function (animal) {
                console.log(animal.name + ' has ' + animal.legsCount + ' legs');
            })
        })
    };
}

module.exports = solve;