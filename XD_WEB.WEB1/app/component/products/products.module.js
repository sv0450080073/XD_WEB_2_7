﻿//// <reference path="/assets/admin/libss/bower_components/angular/angular.js" />
(function () {
    angular.module('xd_web.products', ['xd_web.common']).config(config);
    //tiêm
    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('products',
            {
                url: "/products",
                templateUrl: "/app/component/products/productListView.html",
                controller: "productListController"
            }).state('productadd',
                {
                    url: "/productadd",
                    templateUrl: "/app/component/products/productAddView.html",
                    controller: "productAddController"
                });
    }
})();// bắt buộc phải có nha () ko có báo lổi đó 