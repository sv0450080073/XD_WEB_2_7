(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope', 'apiService', 'notificationService'];

    function productCategoryListController($scope, apiService, notificationService) {
        $scope.productCategories = [];
        //phân trang 
        $scope.page = 0;
        $scope.pagesCount = 0;
        //$scope.totalCount = 0;
        $scope.getProductCategories = getProductCategories;
        $scope.keyword = '';
        $scope.search = search;


        function search() {
            getProductCategories();
        }
        function getProductCategories(page) {
            //phân trang 
            page = page || 0;
            var config = {
                params: {
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 20
                }
            }


            apiService.get('/api/productcategory/getall', config, function (result) {
                //Thông báo cho người dùng 
                if (result.data.TotalCount == 0) { 
                    notificationService.displayWarning('Không có bản ghi nào được tìm thấy.');
                }
                else {
                    notificationService.displaySuccess('Đã tìm thấy ' + result.data.TotalCount +' bản ghi.');
                }
               
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