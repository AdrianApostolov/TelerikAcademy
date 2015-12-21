(function () {
    'use strict'

    function statisticsData($http, $q, data) {

        function getStats() {
            return data.get('api/stats')
        }

        return {
            getStats : getStats
        }
    }

    angular.module('tripExchange')
        .factory('statistics', ['$http', '$q', 'data', statisticsData])
}());