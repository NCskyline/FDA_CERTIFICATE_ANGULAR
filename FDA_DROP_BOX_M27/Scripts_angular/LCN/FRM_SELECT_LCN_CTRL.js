app.controller('FRM_SELECT_LCN_CTRL', function ($scope, CENTER_SV, $http, $location) {

    CHK_TOKEN();
    $scope.loading = true;

    



}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);

function Openmodel() {
    $('#myModal').modal('toggle'); // เป็นคำสั่งเปิดปิด
}

