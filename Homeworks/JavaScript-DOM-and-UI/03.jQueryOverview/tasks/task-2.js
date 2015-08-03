/* globals $ */

/*
 Create a function that takes a selector and:
 * Finds all elements with class `button` or `content` within the provided element
 * Change the content of all `.button` elements with "hide"
 * When a `.button` is clicked:
 * Find the topmost `.content` element, that is before another `.button` and:
 * If the `.content` is visible:
 * Hide the `.content`
 * Change the content of the `.button` to "show"
 * If the `.content` is hidden:
 * Show the `.content`
 * Change the content of the `.button` to "hide"
 * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
 * Throws if:
 * The provided ID is not a **jQuery object** or a `string`

 */
function solve() {
    return function (selector) {

        if ($(selector).length === 0 || typeof (selector) !== 'string') {
            throw new Error();
        }

        var $domElement = $(selector);

        $domElement.find('.button').text('hide');

        $domElement.on('click', '.button', function () {
            var $clickedButton = $(this);
            var $content = $($clickedButton.next());

            while($content && !$content.hasClass('button')){
                if($content.hasClass('content')){
                    if($content.css('display') === 'none'){
                        $clickedButton.text('hide');
                        $content.css('display', '')
                    }else {
                        $clickedButton.text('show');
                        $content.css('display', 'none')
                    }
                    break;
                }
                $content = $content.next();
            }
        })
    };
}

module.exports = solve;