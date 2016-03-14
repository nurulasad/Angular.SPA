(function () {

    angular.module('spaApp')
    .controller('navigationController', ["$scope", "$rootScope", "$sessionStorage", "constantService", navigationController]);

    function navigationController($scope, $rootScope, $sessionStorage, constantService) {
        var vm = $scope;
        vm.storage = $sessionStorage;

        vm.tabs = constantService.Tabs;

        var navigationChangedListener = $rootScope.$on('navigationChanged', function (event, data) {

            vm.onClickTab(vm.tabs[data.tabIndex]);
        });

        vm.$on('$destroy', navigationChangedListener);


        var currentTab = vm.storage.currentTab;

        if (!currentTab) {
            vm.storage.currentTab = vm.tabs[0];
        }

        vm.onClickTab = function (tab) {

            var tabInList = constantService.findNavigationByName(tab);

            angular.forEach(vm.tabs, function (aTab) {
                aTab.selectedClass = "";
            });

            tabInList[0].selectedClass = "active";
            vm.storage.currentTab = tabInList[0];
        };


        vm.init = function () {

            vm.onClickTab(vm.storage.currentTab);

        };

        vm.init();
    };

})();
