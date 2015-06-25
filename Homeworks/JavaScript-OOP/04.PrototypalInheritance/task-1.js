/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * // method removeAttribute(attribute)
 */


/* Example

 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');

 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)

 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');

 div.content = 'Hello, world!';

 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'cuki')
 .addAttribute('bgcolor', '#012345');

 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);

 console.log(root.innerHTML);
 Outputs:
 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */


function solve() {
    var domElement = (function () {

        function typeValidation(type) {
            if (!(/[A-Za-z0-9]{1,}$/i.test(type)) || type === '' || typeof(type) !== 'string') {
                throw new Error('Type must be any non-empty string that contains only Latin letters and digits');
            }
        }

        function attributeValidation(name) {
            if (!(/^[A-Za-z0-9-]{1,}$/i).test(name)) {
                throw new Error('Valid attribute name must contain only Latin letters, digits or dashes and must not be an empty string!');
            }
        }

        function childValidation(child) {
            if (typeof(child) !== 'string' && Object.getPrototypeOf(child) !== domElement) {
                throw new Error('Child must be either string or a domElement');
            }
        }

        function parentValidation(parent) {
            if (Object.getPrototypeOf(parent) !== domElement) {
                throw new Error('Parent must be a domElement.');
            }
        }

        function contentValidation(content) {
            if (typeof(content) !== 'string') {
                throw new Error('Content must be a string.');
            }
        }

        function getSortedAttributes(attributes) {
            var attributesAsArray = [];

            for (var prop in attributes) {
                if (attributes.hasOwnProperty(prop)) {
                    attributesAsArray.push(prop)
                }
            }

            attributesAsArray = attributesAsArray.sort();

            return attributesAsArray;
        }

        var domElement = {
            init: function (type) {
                this.type = type;
                this._children = [];
                this._attributes = {};
                this._content = '';
                return this;
            },
            appendChild: function (child) {
                childValidation(child);
                this.children.push(child);
                child.parent = this;
                return this;
            },
            addAttribute: function (name, value) {
                attributeValidation(name);
                this.attributes[name] = value;
                return this;
            },
            removeAttribute: function (attribute) {
                if (!this.attributes[attribute]) {
                    throw new Error('Cannot remove a non-existing attribute.')
                }

                delete this.attributes[attribute];

                return this;
            },
            get innerHTML() {
                var result = '';
                result += '<' + this.type;

                if (this.attributes) {
                    var sortedAttributes = getSortedAttributes(this.attributes);

                    for (var i = 0, len = sortedAttributes.length; i < len; i += 1) {

                        result += ' ' + sortedAttributes[i] + '="' + this.attributes[sortedAttributes[i]] + '"';
                    }
                }

                result += '>';

                if (this.children.length > 0) {
                    for (i = 0, len = this.children.length; i < len; i += 1) {
                        if (typeof this.children[i] === 'string') {
                            result += this.children[i];
                        } else {
                            result += this.children[i].innerHTML;
                        }
                    }
                } else {
                    result += this.content;
                }

                result += '</' + this.type + '>';
                return result;
            }
        };

        Object.defineProperties(domElement, {
            type: {
                get: function () {
                    return this._type
                },
                set: function (type) {
                    typeValidation(type);

                    this._type = type;
                }
            },
            parent: {
                get: function () {
                    return this._parent;
                },
                set: function (parent) {
                    parentValidation(parent);
                    this._parent = parent;
                }
            },
            children: {
                get: function () {
                    return this._children;
                }
            },
            attributes: {
                get: function () {
                    return this._attributes;
                }
            },
            content: {
                get: function () {
                    return this._content;
                },
                set: function (value) {
                    contentValidation(value);
                    this._content = value;
                }
            }
        });

        return domElement;
    }());

    return domElement;
}
module.exports = solve;
