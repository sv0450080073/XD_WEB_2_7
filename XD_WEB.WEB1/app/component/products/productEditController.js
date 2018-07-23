(function (app) {
    app.controller('productEditController', productEditController);

    productEditController.$inject = ['apiService', '$scope', 'notificationService', '$state', 'commonService','$stateParams'];

    function productEditController(apiService, $scope, notificationService, $state, commonService, $stateParams) {
        $scope.product = {


        };
        //ckeditor nha
        $scope.ckeditorOptions = {
            languague: 'vi',
            height: '200px'
        }
        //thêm thể lọai danh mục mới
        $scope.UpdateProduct = UpdateProduct;
        //getseo

        $scope.GetSeoTitle = GetSeoTitle;

        function GetSeoTitle() {
            $scope.product.Alias = commonService.getSeoTitle($scope.product.Name);
        }

        function loadProductDetail() {
            apiService.get('/api/product/getbyid/' + $stateParams.id, null, function (result) {
                $scope.product = result.data;
            }, function (error) {
                notificationService.displayError(error.data);
            });

        }

        function UpdateProduct() {
            apiService.put('/api/product/update', $scope.product, function (result) {
                notificationService.displaySuccess(result.data.Name + 'đã được update.');
                $state.go('products');
            }, function (error) {
                notificationService.displayError('Cập nhật ko thành công');
            });
        }

        //lấy danh mục cha ra 
        function loadProductCategory() {
            apiService.get('/api/productcategory/getallparents', null, function (result) {
                $scope.productCategories = result.data;
            }, function () {
                console.log('Cannot get list parent');
            });
        }
        $scope.ChooseImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.product.Image = fileUrl;
            }
            finder.popup();
        }

        loadProductCategory();
        loadProductDetail();

    }
})(angular.module('xd_web.products'));