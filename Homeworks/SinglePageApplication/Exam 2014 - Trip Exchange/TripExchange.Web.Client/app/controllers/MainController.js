(function () {
    function MainController(scope, location, routeAuths, identity) {

        scope.$on('$locationChangeStart', function (event, newVal, oldVal) {
            var routeAuth = routeAuths.get(location.path());
            if (routeAuth.access === 'restricted') {
                if (!identity.isAuthenticated()) {
                    location.path('/unauthorized');
                }
            }
        });
    }

    angular.module('tripExchange')
  .controller('MainController', ['$scope', '$location', 'routeAuths', 'identity', MainController]);
}());