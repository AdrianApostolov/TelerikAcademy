(function () {
    'use strict';

    function pager() {
        return {
            restrict: 'A',
            templateUrl: 'templates/directives/pager.html',
            link: function(scope){
                scope.vm.filterTrips(scope.vm.request, scope.vm.request.page)
            }
        }
    }

    angular.module('tripExchange')
        .directive('pager', [pager])
}());