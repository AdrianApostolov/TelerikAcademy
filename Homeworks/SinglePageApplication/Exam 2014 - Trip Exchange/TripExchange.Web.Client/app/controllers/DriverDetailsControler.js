(function () {
    'use strict'

    function DriverDetailsControler($routeParams, $location, driversData, identity) {
        var vm = this;

        //if (!identity.isAuthenticated()) {
        //    $location.path('/unauthorized');
        //}

        driversData.getDriverById($routeParams.id)
            .then(function (driver) {
                vm.driver = driver;
                vm.trips = driver.trips;
            })

        vm.onOnlyDriverCheckboxChange = function () {
            if (vm.onlyDriver) {
                console.log(vm.onlyDriver)
                vm.currentDriver = vm.driver.id;
            }
            else {
                vm.currentDriver = undefined;
            }
        }
    }

    angular.module('tripExchange')
        .controller('DriverDetailsController', ['$routeParams', '$location', 'driversData', 'identity', DriverDetailsControler])
}());