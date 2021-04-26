app.controller('FRM_CER_MAIN_CTRL', function ($scope, CENTER_SV, $http, $location) {

    CHK_TOKEN();
    $scope.loading = true;

    $scope.SET_SUB_MAIN_PAGE = "../LCN/FRM_SELECT_LCN";
    $scope.DOC_ID = 0;
    $scope.DOC_TITLE = "TEST";
    $scope.IS_USE = 0;


    $scope.SELECT_LCN = function () {
        var url = "/LCN/FRM_SELECT_LCN";
        REDIRECT(url);
    };
    


}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);

function Openmodel() {
    $('#myModal').modal('toggle'); // เป็นคำสั่งเปิดปิด
}


