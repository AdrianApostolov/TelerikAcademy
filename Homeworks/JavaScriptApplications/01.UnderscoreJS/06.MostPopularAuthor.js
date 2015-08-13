/*
 06. By a given collection of books, find the most popular
 author (the author with the highest number of
 books)

 */

(function () {
    // Check if running on Node.js
    if (typeof require !== 'undefined') {
        // Load underscore.js on Node.js
        _ = require("../node_modules/underscore/underscore.js")
    }

    var books = [
        {title: 'The Da Vinci Code', author: 'Dan Brown'},
        {title: 'Angels & Demons', author: 'Dan Brown'},
        {title: 'The Lost Symbol', author: 'Dan Brown'},
        {title: 'The Adventures of Sherlock Holmes', author: 'Sir Arthur Conan Doyle'},
        {title: 'The Memoirs of Sherlock Holmes', author: 'Sir Arthur Conan Doyle'},
        {title: 'A Game of Thrones: A Song of Ice and Fire', author: 'George R. R. Martin'}];


    var mostPopularAuthor = _.chain(books)
        .groupBy('author')
        .max(function (authorBooks) {
            return authorBooks.length;
        })
        .value();

    console.log('Most popular author: ' + mostPopularAuthor[0].author + ' with ' +
                 mostPopularAuthor.length +' book(s)');
}());