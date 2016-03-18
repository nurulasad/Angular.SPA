(function () {
    angular.module('spaApp')
    .service('constantService', [constantService]);

    function constantService() {
        pub = this;

        pub.ITEMS_PER_PAGE = 10;

        pub.Tabs = [
           { "name": "home", "text": "Home" },
           { "name": "animal", "text": "Animal Quiz" }
        ];

        pub.findNavigationByName = function (tab) {
            return $.grep(pub.Tabs, function (e) {
                return e.name == tab.name;
            });
        };
    }
})();
