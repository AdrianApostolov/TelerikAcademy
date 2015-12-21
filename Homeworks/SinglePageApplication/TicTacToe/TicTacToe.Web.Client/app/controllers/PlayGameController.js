'use strict'

var playGameController = function PlayGameController($location, $routeParams, $interval, toastr, authorization, gameData) {
    var vm = this;
    var headers = authorization.getAuthorizationHeader();

    if ($routeParams.id) {
        vm.play = function ($event) {
            var id = $event.target.id

            var row = Math.floor(id / 3) + 1;
            var col = id % 3 + 1;

            var playMove = {
                GameId: $routeParams.id,
                Row: row,
                Col: col
            }

            gameData.play(playMove, headers);
        }

        var checkStatus = $interval(function () {
            if ($routeParams.id !== undefined) {
                getGameStatus($routeParams)
            }
        }, 2000);
    }

    function getGameStatus($routeParams) {
        gameData.getGameStatus($routeParams.id, headers)
            .then(function (currentGame) {
                vm.currentGame = currentGame;
                var board = currentGame.Board;
                var squares = [];
                for (var i = 0; i < board.length; i++) {
                    squares.push(board[i]);
                }

                vm.squares = squares;
                if (currentGame.State > 2) {
                    $interval.cancel(checkStatus);
                    var state = currentGame.State;

                    switch (state) {
                        case 3:
                            toastr.success("Game won by " + currentGame.FirstPlayerName)
                            $location.path('/games'); break
                        case 4: toastr.success("Game won by " + currentGame.SecondPlayerName)
                            $location.path('/games'); break
                        case 5: toastr.success("Draw")
                            $location.path('/games'); break
                    }
                }
            })
    }
}

angular.module('TicTacToe')
    .controller('PlayGameController', ['$location', '$routeParams', '$interval', 'toastr', 'authorization', 'gameData', playGameController]);