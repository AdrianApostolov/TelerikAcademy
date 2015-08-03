/* globals $ */

/* 

 Create a function that takes an id or DOM element and an array of contents

 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neight `string` or `number`
 * In that case, the content of the element **must not be** changed
 */

module.exports = function () {

    return function (element, contents) {
        var selectedElement,
            lastChild,
            documentFragment,
            newDiv,
            currentDiv;


        if (typeof (element) !== 'string' && !(element instanceof HTMLElement)) {
            throw  new Error('First parameter must be string or existing DOM element')
        }

        if (typeof (element) === 'string') {
            selectedElement = document.getElementById(element);
        } else {
            selectedElement = element;
        }

        if (!contents) {
            throw new Error("Contents must exist");
        }

        if (contents.some(function (item) {
                return (typeof (item) !== 'string' && typeof (item) !== 'number')
            })) {
            throw  new Error('Any of the contents should be string or number')
        }

        lastChild = selectedElement.lastChild;
        while(selectedElement.lastChild){
            selectedElement.removeChild(lastChild);
            lastChild = lastChild.previousSibling;
        }

        newDiv = document.createElement('div');
        documentFragment = document.createDocumentFragment();

        for (var i = 0, len = contents.length; i < len; i+=1) {
            currentDiv = newDiv.cloneNode(true);
            currentDiv.innerHTML = contents[i];
            documentFragment.appendChild(currentDiv);
        }

        selectedElement.appendChild(documentFragment);
    };
};