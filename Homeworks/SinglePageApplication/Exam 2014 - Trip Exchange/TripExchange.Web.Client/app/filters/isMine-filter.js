(function(){
    'use strict'

    tripExchange.filter('isMine', [function () {
        return function (input) {
            switch (input) {
                case true: return 'img/ok.png'; break;
                case false: return 'img/notok.png'; break;
            }
        }
    }]);

}());