'use strict';

tripExchange.factory('authorization', ['identity', function (identity) {
    return {
        getAuthorizationHeader: function () {
            if (!identity.getCurrentUser()) {
                return {};
            }

            return {
                'Authorization': 'Bearer ' + identity.getCurrentUser()['access_token']
            }
        }
    }
}]);