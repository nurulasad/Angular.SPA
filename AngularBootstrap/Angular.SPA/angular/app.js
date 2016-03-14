(function () {
    angular.module("spaApp", ['ui.router', 'ngStorage'])
    .config(["$stateProvider", appStateProvider])
    .run(['$state', '$rootScope', function ($state, $rootScope) {
        $state.transitionTo('home');
        $rootScope.Success = false;
    }]
    ).controller('mainCtrl', ['$scope', function ($scope) {
        $scope.message = "Spa Application";
    }])

    function appStateProvider($stateProvider) {

        $stateProvider
            .state('home', {
                url: '/',
                templateUrl: 'angular/controllers/views/home.tpl.html'
            });
            
            
    }
})();
