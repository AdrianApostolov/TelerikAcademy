'use strict'

function boardFilter() {
    return function (input) {
        switch (input) {
            case '-': return " "; break
            case 'X': return 'X'; break
            case 'O': return 'O'; break
        }
    }
}

angular.module('TicTacToe')
    .filter('boardFilter', [boardFilter])