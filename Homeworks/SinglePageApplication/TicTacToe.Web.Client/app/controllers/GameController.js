'use strict'

var gameController = function GameController($location, toastr, authorization, gameData) {
    var vm = this;
    var headers = authorization.getAuthorizationHeader();

    if (!headers) {
        $location.path('/home');
        toastr.error('You must login!')
        return;
    }

    vm.createGame = function () {
        gameData.createGame(headers)
                .then(function (gameId) {
                    $location.path('/games/' + gameId.data);
                    toastr.success('Game created! Waiting for second player.');
                })
    }

    vm.joinGame = function (id) {
        gameData.joinGame(id, headers)
            .then(function (currentGameId) {
                $location.path('/games/' + currentGameId);
                toastr.success('You joined successfuly.');
            })
    }

    gameData.getAll(headers)
        .then(function (games) {
            vm.allGames = games.data;
        })
}

angular.module('TicTacToe')
    .controller('GameController', ['$location', 'toastr', 'authorization', 'gameData', gameController])