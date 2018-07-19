(function (app) {
    app.factory('notificationService', notificationService);

    //trang chủ toastr
    function notificationService() {
        toastr.options = {
            "debug": false,
            "positionClass": "toast-top-right",
            "onclick": null,
            "falseIn": 300,
            "fadeOut": 1000,
            "timeOut": 3000,
            "extendedTimeOut": 1000
        };

        function displaySuccess(message) {
            toastr.success(message);
        }
        function displayError(error) {
            if (Array.isArray(error)) {
                error.each(function (err) {
                    toastr.error(err);
                });
            }

            else {
                toastr.error(error);
            }
        }
        function displayWarning(message) {
            toastr.warning(message);
        }
        function displayInfo(message) {
            toastr.info(message);
        }
        return {
            displaySuccess: displaySuccess,
            displayError: displayError,
            displayWarning: displayWarning,
            displayInfo: displayInfo
        }
    }
})(angular.module('xd_web.common'));