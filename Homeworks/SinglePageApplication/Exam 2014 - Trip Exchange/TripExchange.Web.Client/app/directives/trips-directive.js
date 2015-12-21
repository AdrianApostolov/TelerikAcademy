(function(){
    'use strict'

    function tripsDirective() {
        return {
            restrict: 'A',
            templateUrl: 'templates/directives/trips.html',
        }
    }

    angular.module('tripExchange')
        .directive('trips', [tripsDirective])
}());