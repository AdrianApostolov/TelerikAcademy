/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];

		function listBooks() {
            var filter = arguments[0];

            if (filter) {
                books = books.filter(function (book) {
                    return book.category === filter.category || book.author === filter.author;
                })
            }

            books = books.sort(function (firstBook, secondBook) {
                return firstBook.ID - secondBook.ID;
            });

            return books;
		}

		function addBook(book) {
            if (book.title && (book.title.length < 2 || book.title.length > 100)) {
                throw new Error('Book title must contain between 2 and 100 characters.');
            }

            if (book.category.length < 2 || book.category.length > 100) {
                throw new Error('Book category must contain between 2 and 100 characters.');
            }

            if (!book.author.length) {
                throw new Error('Author cannot be empty string.');
            }

            if (book.isbn.length !== 10 && book.isbn.length !== 13) {
                throw new Error('Book ISBN must contain 10 or 13 digits.');
            }

            if(book.category === ''){
                book.category = 'Undefined category';
            }

            if(books.some(function(checkBook){
                    return checkBook.title === book.title;
                })){
                throw  new Error('Already exist book with the same title!');
            }

            if(books.some(function (checkBook) {
                    return checkBook.isbn === book.isbn;
            })){
                throw  new Error('Already exist book with the same ISBN!');
            }

            var newCategory = {
                category: book.category,
                ID: categories.length +2
            };

            if(categories.length === 0){
                categories.push(newCategory);
            }
            else if(categories && !categories.some(function(element){
                    return element.category === newCategory.category;
                })){
                categories.push(newCategory);
            }

			book.ID = books.length + 1;
			books.push(book);
			return book;
		}

		function listCategories() {
          return  categories.sort(function(firstCategory, secondCategory){
                return firstCategory.ID - secondCategory.ID;
            }).map(function(element){
                return element.category;
		})}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;