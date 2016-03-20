(function () {

    angular.module('spaApp')
    .controller('animalController', ["$scope", "dataService", "constantService", animalController]);

    function animalController($scope, dataService, constantService) {
        var vm = $scope;

        vm.animals = [
        {
            "item": "lion.gif",
            "name": "Lion",
            "code": "LION",
            "answers": [{ "code": "HORSE", "text": "Horse" }, { "code": "LION", "text": "Lion" }]
        }];

        dataService.get(constantService.REOTE_BACKEND + '/api/elearning/GetAllAnimal').then(function (result) {

            console.log(result.data);
        })


    };

})();
