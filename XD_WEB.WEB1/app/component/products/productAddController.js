(function (app) {
    app.controller('productAddController', productAddController);

    productAddController.$inject = ['apiService', '$scope', 'notificationService', '$state','commonService'];

    function productAddController(apiService, $scope, notificationService, $state, commonService) {
        $scope.product = {
            CreatedDate: new Date(),
            Status: true,

        }
        //ckeditor nha
        $scope.ckeditorOptions = {
            languague: 'vi',
            height:'200px'
        }
        //thêm thể lọai danh mục mới
        $scope.AddProduct = AddProduct;
        //getseo

        $scope.GetSeoTitle = GetSeoTitle;

        function GetSeoTitle() {
            $scope.product.Alias = commonService.getSeoTitle($scope.product.Name);
        }



        function AddProduct() {

            $scope.product.MoreImages = JSON.stringify($scope.moreImages)


            apiService.post('/api/product/create', $scope.product, function (result) {
                notificationService.displaySuccess(result.data.Name + 'đã được thêm mới.');
                $state.go('products');
            }, function (error) {
                notificationService.displayError('Thêm mới ko thành công');
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
        $scope.moreImages = [];

        $scope.ChooseImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.$apply(function () {
                    $scope.product.Image = fileUrl;
                })
            }
            finder.popup();
        }

     
        $scope.ChooseMoreImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl)
            {

                $scope.$apply(function () {
                    $scope.moreImages.push(fileUrl);
                })

               
            }
            finder.popup();

        }
        loadProductCategory();

    }
})(angular.module('xd_web.products'));