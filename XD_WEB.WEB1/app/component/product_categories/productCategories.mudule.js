//// <reference path="/assets/admin/libss/bower_components/angular/angular.js" />
(function () {
    angular.module('xd_web.product_categories', ['xd_web.common']).config(config);
    //tiêm
    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('product_categories',
            {
                url: "/product_categories",
                templateUrl: "/app/component/product_categories/productCategoryListView.html",

                controller: "productCategoryListController"
            }).state('add_product_category',
                {
                    url: "/add_product_category",
                    templateUrl: "/app/component/product_categories/productCategoryAddView.html",
                    controller: "productCategoryAddController"
                });
    }
})();// bắt buộc phải có nha () ko có báo lổi đó 