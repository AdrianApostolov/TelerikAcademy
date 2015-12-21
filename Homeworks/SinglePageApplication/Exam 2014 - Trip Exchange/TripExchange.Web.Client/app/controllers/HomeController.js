(function () {
    'use strict'

    function HomeController(statistics, tripsData, driversData) {
        var vm = this

        statistics.getStats()
            .then(function (stats) {
                vm.stats = stats;
            })

        tripsData.getTrips()
            .then(function (trips) {
                vm.trips = trips;
            })

        driversData.getDrivers()
            .then(function (drivers) {
                vm.drivers = drivers;
            })
    }

    angular.module('tripExchange')
        .controller('HomeController', ['statistics', 'tripsData', 'driversData', HomeController])
}());