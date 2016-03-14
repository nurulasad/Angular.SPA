(function () {
    angular.module('spaApp')
        .factory('loadingInterceptor', ['$q', loadingInterceptor]);

    function loadingInterceptor($q) {
        var showLoading = function () {
            var loadingDiv = $('#circularG');
            var isVisible = loadingDiv.is(':visible');
            if (!isVisible) {
                loadingDiv.show();
            }
        };
        var hideLoading = function () {
            var loadingDiv = $('#circularG');
            var isVisible = loadingDiv.is(':visible');
            if (isVisible) {
                loadingDiv.hide();
            }
        };
        var loadingInjector = {
            'request': function (config) {
                showLoading();
                return config;
            },
            'response': function (response) {
                hideLoading();
                return response;
            },
            'requestError': function (rejection) {
                hideLoading();
                return $q.reject(rejection);
            },
            'responseError': function (rejection) {
                hideLoading();
                return $q.reject(rejection);
            }
        };
        return loadingInjector;
    }

})();

angular.module('spaApp').config(['$httpProvider', function ($httpProvider) {
    $httpProvider.interceptors.push('loadingInterceptor');
}]);