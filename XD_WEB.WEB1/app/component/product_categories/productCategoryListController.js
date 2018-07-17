(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope', 'apiService'];

    function productCategoryListController($scope, apiService) {
        $scope.productCategories = [];
        //phân trang 
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.totalCount = 0;
        $scope.keyword = '';

        $scope.search = search;
        function search() {
            getProductCategories();
        }



        $scope.getProductCategories = getProductCategories;

        function getProductCategories( page) {
            //phân trang 
            page = page || 0;
            var config = {
                params: {
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 2
                }
            }


            apiService.get('/api/productcategory/getall', config, function (result) {

                $scope.productCategories = result.data.Items;
                $scope.page = result.data.Page;
                $scope.pagesCount = result.data.TotalPages;
                $scope.totalCount = result.data.TotalCount;
            }, function () {
                console.log('Load productcategory failed');
            });
        }
        $scope.getProductCategories();
    }
})(angular.module('xd_web.product_categories'));