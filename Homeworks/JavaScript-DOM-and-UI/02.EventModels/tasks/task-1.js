/* globals $ */

/*
 Create a function that takes an id or DOM element and:
 If an id is provided, select the element
 Finds all elements with class button or content within the provided element
 Change the content of all .button elements with "hide"
 When a .button is clicked:
 Find the topmost .content element, that is before another .button and:
 If the .content is visible:
 Hide the .content
 Change the content of the .button to "show"
 If the .content is hidden:
 Show the .content
 Change the content of the .button to "hide"
 If there isn't a .content element after the clicked .button and before other .button, do nothing
 Throws if:
 The provided DOM element is non-existant
 The id is either not a string or does not select any DOM element
 */

//function solve() {
//    return function (selector) {
//
//        if (typeof (selector) !== 'string' && !(selector instanceof HTMLElement)) {
//            throw new Error('Selector must be string or DOM element');
//        }
//
//        if (document.getElementById(selector) === null) {
//            throw new Error('The provided DOM element is non-existent');
//        }
//
//        var allButtons = document.getElementsByClassName('button');
//
//        for (var i = 0, len = allButtons.length; i < len; i += 1) {
//            allButtons[i].innerHTML = 'hide';
//            allButtons[i].addEventListener('click', function (ev) {
//                var clickedButton = ev.target;
//                var content = clickedButton.nextElementSibling;
//
//                while (content) {
//                    if (content.className === 'content') {
//                        break;
//                    }
//                    content = content.nextElementSibling;
//                }
//
//                if(content.style.display === ''){
//                    clickedButton.innerHTML = 'show';
//                    content.style.display = 'none'
//                }else if(content.style.display === 'none'){
//                    clickedButton.innerHTML = 'hide';
//                    content.style.display = '';
//                }
//            })
//        }
//    };
//}

function solve() {
    return function (selector) {
        //var domElement = document.querySelector(selector);
        var domElement = document.getElementById(selector);

        if (typeof (selector) !== 'string' && !(selector instanceof HTMLElement)) {
            throw new Error('Selector must be string or DOM element');
        }

        if (domElement === null) {
            throw new Error('The provided DOM element is non-existent');
        }

        //var allButtons = document.getElementsByClassName('button');
        var allButtons = domElement.getElementsByClassName('button');

        for (var i = 0, len = allButtons.length; i < len; i += 1) {
            allButtons[i].innerHTML = 'hide';
        }

        domElement.addEventListener('click', function (ev) {
            var clickedButton = ev.target;
            if (clickedButton.className.indexOf('button') > -1) {
                var content = clickedButton.nextElementSibling;

                while (content && content.className.indexOf('button' < 0)) {
                    if (content.className.indexOf('content') > -1) {
                        if (content.style.display === '') {
                            clickedButton.innerHTML = 'show';
                            content.style.display = 'none'
                        } else if (content.style.display === 'none') {
                            clickedButton.innerHTML = 'hide';
                            content.style.display = '';
                        }

                        break;
                    }

                    content = content.nextElementSibling;
                }
            }
        });
    };
}

module.exports = solve;




