/// <reference path="../assets/admin/libss/bower_components/angular/angular.js" />
(function () {
    angular.module('xd_web',
        ['xd_web.products',
            'xd_web.product_categories',
            'xd_web.common'])
        .config(config);
       // .config(configAuthentication);

    //tiêm
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider
            /*.state('base', {
                url: '',
                templateUrl: '/app/share/views/baseView.html',
                abstract:true
            })
            .state('login',
                {
                    url: "/login",
                  
                    templateUrl: "/app/component/login/loginView.html",
                    controller: "loginController"
                })*/


            .state('home',
            {
                url: "/admin",
               // parent:'base',
                templateUrl: "/app/component/home/homeView.html",
                controller: "homeController"
            });
        $urlRouterProvider.otherwise('/admin');
    }

    /*function configAuthentication($httpProvider) {
        $httpProvider.interceptors.push(function ($q, $location) {
            return {
                request: function (config) {

                    return config;
                },
                requestError: function (rejection) {

                    return $q.reject(rejection);
                },
                response: function (response) {
                    if (response.status == "401") {
                        $location.path('/login');
                    }
                    //the same response/modified/or a new one need to be returned.
                    return response;
                },
                responseError: function (rejection) {

                    if (rejection.status == "401") {
                        $location.path('/login');
                    }
                    return $q.reject(rejection);
                }
            };
        });
    }*/
})();