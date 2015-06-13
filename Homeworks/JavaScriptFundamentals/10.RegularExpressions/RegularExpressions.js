// 1. Format with placeholders: Write a function that formats a string. The function should have placeholders, as shown in the example Add the function to the String.prototype
String.prototype.format = function (options) {
    var placeholder,
        _this = this;

    for (var prop in options) {
        placeholder = new RegExp('#{' + prop + '}', 'g');
        _this = _this.replace(placeholder, options[prop]);
    }

    return _this;
};

//var options = {name: 'John', age: 13};
//console.log('My name is #{name} and I am #{age}-years-old'.format(options));
//-----------------------------------------------------------------------------------------------
// 2. HTML binding: Write a function that puts the value of an object into the content/attributes of HTML tags. Add the function to the String.prototype
String.prototype.bind = function (str, options) {
    var rgxContent,
        rgxLink,
        rgxClass;

    for (var prop in options) {
        rgxContent = new RegExp('(<.*?data-bind-content="' + prop + '".*?>)(.*?)(<.*?>)', 'g'),
            rgxLink = new RegExp('(<.*?data-bind-href="' + prop + '".*?)()>', 'g'),
            rgxClass = new RegExp('(<.*?data-bind-class="(' + prop + '").*?>)', 'g');

        function contentReplacer(match, start, content, end) {
            return [start, options[prop], end].join('');
        }

        function linkReplacer(match, start, content) {
            return [start, ' href="', options[prop], '"'].join('');
        }

        function classReplacer(match, start, content) {
            return [start, ' class="', options[prop], '">'].join('');
        }

        str = str.replace(rgxContent, contentReplacer);
        str = str.replace(rgxLink, linkReplacer);
        str = str.replace(rgxClass, classReplacer);
    }

    return str;
};

//var str = '<div data-bind-content="name"></div>';
//console.log(str.bind(str, {name: 'Steven'}));
//
//// <div data-bind-content="name">Steven</div>
//
//var bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>'
//console.log(str.bind(bindingString, {name: 'Elena', link: 'http://telerikacademy.com'}));
//
//// <a data-bind-content="name" data-bind-href="link" data-bind-class="name" href="http://telerikacademy.com" class="Elena">Elena</à>
//-----------------------------------------------------------------------------------------------