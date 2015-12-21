'use strict';

app.controller('LoginController', ['$scope', '$location', 'toastr', 'identity', 'auth', function ($scope, $location, toastr, identity, auth) {
    $scope.identity = identity;

    $scope.login = function (user, loginForm) {
        if (loginForm.$valid) {
            auth.login(user).then(function (success) {
                if (success) {
                    toastr.success('Successful login!');
                }
                else {
                    toastr.error('Username/Password combination is not valid!');
                }
            });
        }
        else {
            toastr.error('Username and password are required fields!')
        }
    }

    $scope.logout = function () {
        auth.logout().then(function () {
            toastr.success('Successful logout!');
            if ($scope.user) {
                $scope.user.email = '';
                $scope.user.username = '';
                $scope.user.password = '';
            }

            $scope.loginForm.$setPristine();
            $location.path('/');
        })
    }
}])