'use strict';

var tripExchange = angular.module('tripExchange', ['ngRoute', 'ngResource', 'ngCookies', 'kendo.directives']).
    config(['$routeProvider', function($routeProvider) {
        $routeProvider
            .when('/home', {
                templateUrl: 'templates/home/home.html',
                controller: 'HomeController',
                controllerAs: 'vm'
            })
            .when('/unauthorized', {
                templateUrl: 'templates/auth/unauthorized.html'
            })
            .when('/register', {
                templateUrl: 'templates/auth/register.html',
                controller: 'SignUpCtrl'
            })
            .when('/drivers', {
                templateUrl: 'templates/drivers/drivers.html',
                controller: 'DriversController',
                controllerAs: 'vm'
            })
            .when('/drivers/:id', {
                templateUrl: 'templates/drivers/drivers-details.html',
                controller: 'DriverDetailsController',
                controllerAs: 'vm'
            })
            .when('/trips', {
                templateUrl: 'templates/trips/trips.html',
                controller: 'TripsController',
                controllerAs: 'vm'
            })
            .when('/trips/create', {
                templateUrl: 'templates/trips/create-trip.html',
                controller: 'TripsCreateController',
                controllerAs: 'vm'
            })
            .when('/trips/:id', {
                templateUrl: 'templates/trips/trip-details.html',
                controller: 'TripsDetailsController',
                controllerAs: 'vm'
            })
            .otherwise({ redirectTo: '/home' });
    }])
    .value('toastr', toastr)
    //.constant('baseServiceUrl', 'http://localhost:1337/');
    .constant('baseServiceUrl', 'http://spa2014.bgcoder.com/');