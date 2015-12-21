(function(){
    'use strict'

    function TripsController(identity, tripsData, citiesData) {
        var vm = this;
        vm.identity = identity;
        vm.currentPage = 1;

        vm.request = {
            page: 1
        }

        vm.search = function (request, page) {
            request = request || {};
            vm.request.page = page

            vm.currentPage = page;

            tripsData.getTrips(request)
                .then(function (trips) {
                vm.trips = trips
            })

            //cats.searchCats(request)
            //    .then(function (filteredCats) {
            //        vm.cats = filteredCats;
            //    });
        }

        //vm.prevPage = function () {
        //    if (vm.request.page == 1) {
        //        return;
        //    }

        //    vm.request.page--;
        //    vm.filterTrips();
        //}

        //vm.nextPage = function () {
        //    if (!vm.trips || vm.trips.length == 0) {
        //        return;
        //    }

        //    vm.request.page++;
        //    vm.filterTrips();
        //}

        vm.filterTrips = function () {
            tripsData.getTrips(vm.request)
                .then(function (filteredTrips) {
                    vm.trips = filteredTrips;

                    var pages = [];
                    for (var i = 1; i <= vm.trips.length; i++) {
                        pages.push(i);
                    }

                    vm.pages = pages;
                });
        }

        citiesData.getCities()
            .then(function (cities) {
                vm.cities = cities;
            })

        tripsData.getTrips()
            .then(function (trips) {
                vm.trips = trips
            })
        
    }

    angular.module('tripExchange')
        .controller('TripsController', ['identity','tripsData', 'citiesData', TripsController])
}());