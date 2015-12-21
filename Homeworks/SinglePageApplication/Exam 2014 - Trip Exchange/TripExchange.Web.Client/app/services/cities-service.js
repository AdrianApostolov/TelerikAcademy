(function(){
    'use strict'

    function citiesData(data) {
        function getCities() {
            return data.get('api/cities')
        }

        return {
            getCities: getCities
        }
    }

    angular.module('tripExchange')
        .factory('citiesData', ['data' , citiesData])
}());