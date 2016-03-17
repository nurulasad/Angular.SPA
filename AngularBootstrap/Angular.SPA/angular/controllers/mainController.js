(function () {

    angular.module('spaApp')
    .controller('mainController', ["$scope", "$rootScope", mainController]);

    function mainController($scope, $rootScope) {
        var vm = $scope;

        $scope.message = 'Everyone come and see how good I look!';
        
    };

})();
