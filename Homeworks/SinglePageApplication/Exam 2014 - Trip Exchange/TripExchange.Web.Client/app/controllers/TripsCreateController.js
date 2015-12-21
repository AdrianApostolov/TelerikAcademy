(function(){
    'use strict'

    function TripsCreateController($location, tripsData, citiesData, toastr) {
        var vm = this;

        citiesData.getCities()
            .then(function (cities) {
                vm.cities = cities;
            })

        vm.createTrip = function (trip) {
            tripsData.createTrip(trip)
                .then(function (createdTrip) {
                    console.log(createdTrip)
                    $location.path('/trips/' + createdTrip.id)
                    toastr.success('You successfully create trip!')
                })
        }
    }

    angular.module('tripExchange')
        .controller('TripsCreateController', ['$location','tripsData', 'citiesData', 'toastr', TripsCreateController]);
}());