/* 
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName`, `lastName` and `age` properties
*   **finds** the students whose age is between 18 and 24
*   **prints**  the fullname of found students
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (students) {

    _.chain(students)
        .filter(function (student) {
          return student.age >= 18 && 24 >= student.age
        })
        .sortBy(function (student) {
          return (student.firstName + ' ' + student.lastName);
        })
        .each(function (student) {
          console.log(student.firstName + ' ' + student.lastName);
        })
  };
}

module.exports = solve;