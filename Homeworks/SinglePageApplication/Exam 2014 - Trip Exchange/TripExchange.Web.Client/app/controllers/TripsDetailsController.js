(function () {
    'use strict'

    function TripsDetailsController($routeParams, $location, tripsData, identity, toastr) {
        var vm = this;

        tripsData.getTripById($routeParams.id)
           .then(function (trip) {
               vm.trip = trip;
               vm.passengers = trip.passengers.join(', ');

               vm.disableJoinButton = function (trip) {
                   if (trip.numberOfFreeSeats < 1) {
                       return true;
                   }

                   if (trip.departureDate < (new Date()).toISOString()) {
                       return true;
                   }

                    for (var i = 0; i <= trip.passengers.length; i++) {
                        if (trip.passengers[i] == identity.getCurrentUser().userName) {
                            return true;
                        }
                    }
                   
                   return false;
               };
           })

        vm.joinTrip = function (id) {
            tripsData.joinTrip(id)
                .then(function () {
                    $location.path('/trips');
                    toastr.success('Successfully joined the trip');
                })
        }
    }

    angular.module('tripExchange')
        .controller('TripsDetailsController', ['$routeParams', '$location', 'tripsData', 'identity', 'toastr', TripsDetailsController])
}());