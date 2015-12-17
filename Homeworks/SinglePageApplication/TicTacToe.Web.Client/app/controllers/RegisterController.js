'use strict';

app.controller('RegisterController', ['$scope', '$location', 'auth', 'toastr', function ($scope, $location, auth, toastr) {
    $scope.signup = function (user) {
        auth.signup(user).then(function () {
            toastr.success('Registration successful!');
            $location.path('/');
        })
    }
}]);