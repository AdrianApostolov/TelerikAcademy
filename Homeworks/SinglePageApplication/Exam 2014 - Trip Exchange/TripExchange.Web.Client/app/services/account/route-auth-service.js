(function () {
    function routeAuths() {
        // add all paths that are restricted for unauthenticated users!
        var routeAuths = [{
            path: '/trips\/.*',
            access: 'restricted'
        },
        {
            path: '/drivers\/.*',
            access: 'restricted'
        }];
        return {
            get: function (path) {
                var routeAuth;
                for (var i = 0; i < routeAuths.length; i += 1) {
                    routeAuth = routeAuths[i];
                    var routeAuthRegex = new RegExp(routeAuth.path);
                    if (routeAuthRegex.test(path)) {
                        if (routeAuth.access === 'restricted') {
                            return {
                                access: 'restricted',
                                path: path
                            };
                        }
                    }
                }
                return {
                    access: 'allowed',
                    path: path
                };
            }
        };
    };
 
    angular.module('tripExchange')
    .factory('routeAuths', routeAuths)
}());