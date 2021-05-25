app.controller('FRM_SELECT_LCN_CTRL', function ($scope, CENTER_SV, $http, $location) {

    //CHK_TOKEN();
    //$scope.loading = true;
    pageload();

    function pageload() {

        var CITIZEN_ID_REPLACEMENT = sessionStorage.CITIZEN_ID_REPLACEMENT;

        //var DataLCN = CENTER_SV.SP_MAINCOMPANY_IDENTIFY(CITIZEN_ID_REPLACEMENT);
        //DataLCN.then(function (datas) {
        //    $scope.DATA_LCN = datas.data;
        //});

        var Getdata = CENTER_SV.SP_GET_CER_DRUG_LCN(CITIZEN_ID_REPLACEMENT);
        Getdata.then(function (datas) {
            $scope.LIST_LCN = datas.data;           
        });

    }
   


}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);

function Openmodel() {
    $('#myModal').modal('toggle'); // เป็นคำสั่งเปิดปิด
}

