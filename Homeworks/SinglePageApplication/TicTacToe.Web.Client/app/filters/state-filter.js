'use strict'

function stateFilter() {
    return function (input) {
        switch (input.State) {
            case 0: return "Waiting For Second Player"; break
            case 1: return input.FirstPlayerName +"'s turn"; break
            case 2: return input.SecondPlayerName +"'s turn"; break
            case 3: return "Won by " + input.FirstPlayerName; break
            case 4: return "Won by " + input.SecondPlayerName; break
            case 5: return "Draw"; break
        }
    }
}

angular.module('TicTacToe')
    .filter('stateFilter', [stateFilter])