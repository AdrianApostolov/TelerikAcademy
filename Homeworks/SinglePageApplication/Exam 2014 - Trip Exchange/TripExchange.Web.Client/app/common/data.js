(function () {
    'use strict';

    function data($http, $q, authorization, baseServiceUrl, toastr) {

        var headers = authorization.getAuthorizationHeader();

        function get(url, params) {
            var defered = $q.defer();

            $http
                .get(baseServiceUrl + url, { params: params, headers: headers })
                .then(function (response) {
                    defered.resolve(response.data);
                }, function (err) {
                    defered.reject(err);
                });

            return defered.promise;
        }

        function getById(url) {
            var defered = $q.defer();
            $http
                .get(baseServiceUrl + url, { headers: headers })
                .then(function (response) {
                    defered.resolve(response.data);
                }, function (error) {
                    error = getErrorMessage(error);
                    toastr.error(error);
                    defered.reject(error);
                });

            return defered.promise;
        }

        function post(url, data) {
            var defered = $q.defer();

            $http
                .post(baseServiceUrl + url, data, { headers: headers })
                .then(function (response) {
                    defered.resolve(response.data);
                }, function (error) {
                    error = getErrorMessage(error);
                    toastr.error(error);
                    defered.reject(error);
                });

            return defered.promise;
        }

        function put(url, data) {
            var defered = $q.defer();

            $http
                .put(baseServiceUrl + url, data, { headers: headers })
                .then(function (response) {
                    defered.resolve(response.data);
                }, function (error) {
                    error = getErrorMessage(error);
                    toastr.error(error);
                    defered.reject(error);
                });

            return defered.promise;
        }

        function getErrorMessage(response) {
            var error = response.data.modelState;
            if (error && error[Object.keys(error)[0]][0]) {
                error = error[Object.keys(error)[0]][0];
            }
            else {
                error = response.data.message;
            }

            return error;
        }

        return {
            get: get,
            getById: getById,
            post: post,
            put: put
        }
    }

    angular.module('tripExchange')
        .factory('data', ['$http', '$q', 'authorization', 'baseServiceUrl', 'toastr', data]);
}());
