/*
 Problem 1: MakePerson
 Write a functio for creating persons.
 Each person must have firstname, lastname, age and gender (true is female, false is male)
 Generate an array with ten person with different names, ages and genders.
 */

var jsConsole;

function Person(fname, lname, age, gender) {
    this.firstName = fname;
    this.lastName = lname;
    this.age = age;
    this.gender = gender;
}


var persons = [
    new Person('Pesho', 'Ivanov', 25, 'male'),
    new Person('Gosho ', 'Marinov', 29, 'male'),
    new Person('Stancho', 'Dimitrov', 15, 'male'),
    new Person('Ivanka', 'Petrova', 17, 'female'),
    new Person('Maria', 'Koleva', 32, 'female'),
    new Person('Stamat', 'Balkanov', 39, 'male'),
    new Person('Stilqn', 'Kolev', 21, 'male'),
    new Person('Kichka', 'Bodurova', 41, 'female'),
    new Person('Lili', 'Ivanova', 99, 'female'),
    new Person('Pencho', 'Petrov', 29, 'male')
];
console.log('Problem 1: MakePerson');
persons.forEach(function (item, index) {
    console.log('Array element ' + index + ' ' + JSON.stringify(item));
});

jsConsole.writeLine('Problem 1: MakePerson');
persons.forEach(function (item, index) {
    jsConsole.writeLine(index + ' ' + JSON.stringify(item));
});

console.log(new Array(41).join('-'));
jsConsole.writeLine(new Array(80).join('-'));

/*
 Problem 2: People of age
 Write a function that checks if an array of person contains only people of age (with age 18 or greater)
 Use only array methods and no regular loops (for, while)
 */

var overEighteen = persons.every(function (item) {
    return item.age > 18
});
console.log('Problem 2: People of age');
jsConsole.writeLine('Problem 2: People of age');

console.log('Is array of persons contains only people over eighteen: ' + overEighteen);
jsConsole.writeLine('Is array of persons contains only people over eighteen: ' + overEighteen);

console.log(new Array(41).join('-'));
jsConsole.writeLine(new Array(80).join('-'));

/*
 Problem 3. Underage people

 Write a function that prints all underaged persons of an array of person
 Use Array#filter and Array#forEach
 Use only array methods and no regular loops (for, while)
 */

var underAge = persons.filter(function (item) {
    return item.age < 25;
});
jsConsole.writeLine('Problem 3. Underage people');
console.log('Problem 3. Underage people');

jsConsole.writeLine('Persons under 25: ');
jsConsole.writeLine(JSON.stringify(underAge));
console.log('Persons under 25: \n' + JSON.stringify(underAge));

console.log(new Array(41).join('-'));
jsConsole.writeLine(new Array(80).join('-'));

/*
 Problem 4. Average age of females

 Write a function that calculates the average age of all females, extracted from an array of persons
 Use Array#filter
 Use only array methods and no regular loops (for, while)
 */

var females= persons.filter(function (item) {

    if (item.gender === 'female') {
        return item.gender;
    }
});

var averageAge = females.reduce(function(sum, item){
    return sum + item.age / females.length
}, 0);

jsConsole.writeLine('Problem 4. Average age of females');
console.log('Problem 4. Average age of females');

console.log('The average age of all females is ' + averageAge);
jsConsole.writeLine('The average age of all females is ' + averageAge);

console.log(new Array(41).join('-'));
jsConsole.writeLine(new Array(80).join('-'));


/*
 Problem 5. Youngest person

 Write a function that finds the youngest male person in a given array of people and prints his full name
 Use only array methods and no regular loops (for, while)
 Use Array#find
 */


if (!Array.prototype.find) {
    Array.prototype.find = function(callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    };
}

var youngestMale =
    persons.sort(function(a, b) {
        return a.age - b.age;
    }).find(function(item) {
        if (item !== undefined) {
            return item;
        }
 });

jsConsole.writeLine('Problem 5. Youngest person');
console.log('Problem 5. Youngest person');

console.log('The youngest male is: ' +youngestMale.firstName + ' ' + youngestMale.lastName);
jsConsole.writeLine('The youngest male is: ' +youngestMale.firstName + ' ' + youngestMale.lastName);

console.log(new Array(41).join('-'));
jsConsole.writeLine(new Array(80).join('-'));

/*
 Problem 6. Group people

 Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
 Use Array#reduce
 Use only array methods and no regular loops (for, while)
 */

var result = persons.reduce(function(obj, item) {
    if (obj[item.firstName[0]]) {
        obj[item.firstName[0]].push(item);
    } else {
        obj[item.firstName[0]] = [item];
    }
    return obj;
}, {});

jsConsole.writeLine('Problem 6. Group people');
console.log('Problem 6. Group people');

console.log(result);
jsConsole.writeLine(JSON.stringify(result));