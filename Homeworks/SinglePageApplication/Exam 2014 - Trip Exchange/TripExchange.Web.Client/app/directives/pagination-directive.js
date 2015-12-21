(function () {
    'use strict';

    function pagination() {
        return {
            restrict: 'A',
            templateUrl: 'templates/directives/pagination.html',
            link: function (scope, element, attrs) {
                scope.vm.previousPage = function () {
                    
                    if (scope.vm.request.page == 1) {
                        return;
                    }

                    scope.vm.request.page--;
                    scope.vm.filterTrips();
                }

                scope.vm.nextPage = function () {
                    if (!scope.vm.trips || scope.vm.trips.length == 0) {
                        return;
                    }

                    scope.vm.request.page++;
                    scope.vm.filterTrips();
                }
            }
        }
    }

    angular.module('tripExchange')
        .directive('pagination', [pagination])
}());