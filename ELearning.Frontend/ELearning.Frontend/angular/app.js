(function () {
    angular.module("spaApp", ['ui.router', 'ngRoute', 'ngStorage'])
    .config(["$routeProvider", appStateProvider])


    function appStateProvider($routeProvider) {

        $routeProvider
          .when('/', {
              templateUrl: 'angular/controllers/views/home.tpl.html',
              controller: 'mainController'
          })
            .when('/home', {
                templateUrl: 'angular/controllers/views/home.tpl.html',
                controller: 'mainController'
            })
          .when('/animal', {
                templateUrl: 'angular/controllers/views/animal.tpl.html',
                controller: 'animalController'
           })
          .otherwise({ redirectTo: '/notfound' });
    }

})();
