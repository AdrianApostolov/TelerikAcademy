(function () {
    'use strict'

    function driversData(data) {

        function getDrivers(request) {
            return data.get('api/drivers', request)
        }

        function getDriverById(id) {
            return data.getById('api/drivers/' + id)
        }

        return {
            getDrivers: getDrivers,
            getDriverById: getDriverById
        }
    }

    angular.module('tripExchange')
        .factory('driversData', ['data', driversData])
}());