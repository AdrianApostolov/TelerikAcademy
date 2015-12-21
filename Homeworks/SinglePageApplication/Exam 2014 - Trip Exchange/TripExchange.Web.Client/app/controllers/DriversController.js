(function(){
    'use strict'

    function DriversController(driversData, identity) {
        var vm = this;
        vm.identity = identity

        if (identity.isAuthenticated()) {
            vm.request = {
                page: 1
            }

            vm.previousPage = function () {
                if (vm.request.page > 1) {
                    vm.request.page--;
                    vm.filter(vm.request);
                }
            }

            vm.nextPage = function () {
                vm.request.page++;
                vm.filter(vm.request);
            }

            vm.filter = function (request) {
                driversData.getDrivers(request)
                    .then(function (drivers) {
                        vm.drivers = drivers
                    })
                    
            }
        }
            driversData.getDrivers()
           .then(function (drivers) {
               vm.drivers = drivers;
           })
    }

    angular.module('tripExchange')
        .controller('DriversController', ['driversData', 'identity', DriversController])
}())