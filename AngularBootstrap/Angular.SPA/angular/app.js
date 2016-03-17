(function () {
    angular.module("spaApp", ['ui.router', 'ngRoute','ngStorage'])
    .config(["$routeProvider", appStateProvider])
    

    function appStateProvider($routeProvider) {

        $routeProvider
          .when('/', {
              templateUrl: 'angular/controllers/views/home.tpl.html',
              controller: 'mainController'
          })
          .otherwise({ redirectTo: '/' });
    }

})();
