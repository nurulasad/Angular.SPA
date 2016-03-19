(function () {
    'use strict';

    angular
        .module('spaApp')
        .factory('dataService', dataService);

    dataService.$inject = ['$http'];
    function dataService($http) {

  
        var pub = this;
        var pri = {};


        pri.onError = function (data, status) {
            console.log('Something went wrong . Please contact the support.')
        };


        pub.get = function (url) {

            return $http.get(url)//
            .success(function (data) {

                return data;
            })//
            .error(function (data, status) {

                pri.onError(data, status);
            });
        };

        pub.post = function (url, data) {

            return $http({
                method: 'POST',
                url: url,
                data: data
            })//
            .success(function (data) {

                return data;
            })//
            .error(function (data, status) {

                pri.onError(data, status);
            });
        };

        pub.put = function (url, data) {


            return $http({
                method: 'PUT',
                url: url,
                data: data
            })//
            .success(function (data) {

                return data;
            })//
            .error(function (data, status) {

                pri.onError(data, status);
            });
        };


        return pub;
    }
})();