'use strict'

var gameData = function GameData($http, $q, $cookieStore, toastr, baseServiceUrl) {
    var gamesApi = baseServiceUrl + '/api/games'

    function createGame(headers) {
        var deferred = $q.defer();

        $http.post(gamesApi + '/create', {}, { headers: headers })
                .then(function (res) {
                    deferred.resolve(res);
                }, function (err) {
                    deferred.reject(err);
                })

        return deferred.promise;
    }

    function joinGame(id ,headers) {
        var deferred = $q.defer();

        $http.post(gamesApi + '/join/' + id, {},{ headers: headers })
                .then(function (res) {
                    deferred.resolve(res.data);
                }, function (err) {
                    deferred.reject(err);
                    toastr.error('Game is not available to join!')
                })

        return deferred.promise;
    }

    function getAll(headers) {
        var deferred = $q.defer();

        $http.get(gamesApi + '/all', { headers: headers })
                .then(function (res) {
                    deferred.resolve(res);
                }, function (err) {
                    deferred.reject(err);
                    
                })

        return deferred.promise;
    }

    function getGameStatus(id, headers) {
        var deferred = $q.defer();

        $http.get(gamesApi + '/status/' + id, { headers: headers })
                .then(function (res) {
                    deferred.resolve(res.data);
                }, function (err) {
                    deferred.reject(err);
                })

        return deferred.promise;
    }

    function play(data, headers) {
        var deferred = $q.defer();

        $http.post(gamesApi + '/play/', data, { headers: headers })
                .then(function (res) {
                    deferred.resolve(res.data);
                }, function (err) {
                    toastr.error(err.data.Message);
                    deferred.reject(err);
                })

        return deferred.promise;
    }

    return {
        createGame: createGame,
        getAll: getAll,
        joinGame: joinGame,
        getGameStatus: getGameStatus,
        play: play
    }
}

angular.module('TicTacToe')
    .factory('gameData', ['$http', '$q', '$cookieStore', 'toastr', 'baseServiceUrl', gameData])