/// <reference path="../assets/admin/libss/bower_components/angular/angular.js" />
(function () {
    angular.module('xd_web',
        ['xd_web.products',
         'xd_web.product_categories',
         'xd_web.common'])
        .config(config);

    //tiêm
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home',
            {
                url: "/admin",
                templateUrl: "/app/component/home/homeView.html",
                controller: "homeController"
            });
        $urlRouterProvider.otherwise('/admin');
    }
})();