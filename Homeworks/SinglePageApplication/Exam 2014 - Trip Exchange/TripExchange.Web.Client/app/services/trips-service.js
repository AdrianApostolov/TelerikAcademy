(function () {
    'use strict'

    function tripsData(data) {

        function getTrips(request) {
            return data.get('api/trips', request)
        }

        function createTrip(trip) {
            return data.post('api/trips', trip)
        }

        function getTripById(id) {
            return data.getById('api/trips/' + id)
        }

        function joinTrip(id) {
            return data.put('api/trips/' + id)
        }

        return {
            getTrips: getTrips,
            createTrip: createTrip,
            getTripById: getTripById,
            joinTrip: joinTrip
        }
    }

    angular.module('tripExchange')
        .factory('tripsData', ['data', tripsData])
}())