(function(){
    'use strict'

    function driversDirective() {
        return {
            restrict: 'A',
            templateUrl: 'templates/directives/drivers.html',
        }
    }

    angular.module('tripExchange')
        .directive('drivers', [driversDirective])
}());