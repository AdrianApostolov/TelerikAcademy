'use strict';

var app = angular.module('TicTacToe', ['ngRoute', 'ngResource', 'ngCookies', 'ngAnimate', 'xtForm'])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/home', {
                templateUrl: 'templates/home.html'
            })
            .when('/register', {
                templateUrl: 'templates/auth/register.html',
                controller: 'RegisterController'
            })
            .when('/games', {
                templateUrl: 'templates/games/all-games.html',
                controller: 'GameController',
                controllerAs: 'vm'
            })
            .when('/games/:id', {
                templateUrl: 'templates/games/game-details.html',
                controller: 'PlayGameController',
                controllerAs: 'vm'
            })
            .otherwise({ redirectTo: '/home' });
    }])
    .value('toastr', toastr)
    .constant('baseServiceUrl', 'http://localhost:33257');