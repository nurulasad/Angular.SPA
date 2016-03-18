(function () {

    angular.module('spaApp')
    .controller('animalController', ["$scope", animalController]);

    function animalController($scope) {
        var vm = $scope;

        vm.animals = [
        {
            "item": "lion.gif",
            "name": "Lion",
            "code": "LION",
            "answers": [{ "code": "HORSE", "text": "Horse" }, { "code": "LION", "text": "Lion" }]
        }];

       
    };

})();
