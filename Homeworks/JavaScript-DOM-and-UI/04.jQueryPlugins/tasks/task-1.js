function solve() {
    return function (selector) {
        var $selectList = $(selector).hide(),
            $options = $selectList.find('option'),
            $divContainer = $('<div />').addClass('dropdown-list').append($selectList),
            $divCurrentSelection = $('<div />').addClass('current')
                .attr('data-value', '')
                .text('Select a value'),
            $divOptionsContainer = $('<div />').addClass('options-container')
                .css({
                    'display': 'none',
                    'position': 'absolute'
                });

        for (var i = 0, len = $options.length; i < len; i += 1) {
            var $divOption = $('<div />')
                .addClass('dropdown-item')
                .attr('data-value', $($options[i]).val())
                .attr('data-index', i)
                .text($($options[i]).text());

            $divOptionsContainer.append($divOption);
        }

        $divCurrentSelection.on('click', function () {
            var container = $('.options-container');
            container.css('display', 'block');
        });

        $divOptionsContainer.on('click', 'div', function () {
            var clickedDiv = $(this);
            $divCurrentSelection.attr('data-value', clickedDiv.attr('data-value'))
                .text(clickedDiv.text());

            $divOptionsContainer.css('display', 'none');

            for (var i = 0, len = $options.length; i < len; i += 1) {
                var currentOption = $($options[i]);
                if (currentOption.val() === clickedDiv.attr('data-value')) {
                    currentOption.attr('selected', '');
                }
            }
        });

        $('body').append($divContainer);
        $divContainer.append($divCurrentSelection);
        $divContainer.append($divOptionsContainer);
    };
}

module.exports = solve;