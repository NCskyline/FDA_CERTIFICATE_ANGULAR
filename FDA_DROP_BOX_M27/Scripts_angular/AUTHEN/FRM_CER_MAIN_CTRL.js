app.controller('FRM_CER_MAIN_CTRL', function ($scope, CENTER_SV, $http, $location) {

   
    $scope.loading = true;

   
    $scope.DOC_ID = 0;
    $scope.DOC_TITLE = "TEST";
    $scope.IS_USE = 0;
    $scope.rcvno = '';
    $scope.ref_code = '';
    $scope.cpp = '';
    $scope.cpp1 = '';
    $scope.cpp5 = '';
    $scope.cfs = '';
    


    
    

    $scope.Pageload = function (KEY) {

        if (KEY == 'MAIN') {
            var getdata = CENTER_SV.SP_GET_DATA_CER_ALL($scope.rcvno, $scope.ref_code);
            getdata.then(function (datas) {
                $scope.LIST_CER = datas.data;

            }, function () { });

            var Datacpp = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950002');
            Datacpp.then(function (datas) {
                $scope.RCV_CER = datas.data;
                $scope.cpp = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datacpp1 = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950003');
            Datacpp1.then(function (datas) {
                $scope.RCV_CER = datas.data;
                $scope.cpp1 = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datacpp5 = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950004');
            Datacpp5.then(function (datas) {
                $scope.RCV_CER = datas.data;
                $scope.cpp5 = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datacfs = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950001');
            Datacfs.then(function (datas) {
                $scope.RCV_CER = datas.data;
                $scope.cfs = $scope.RCV_CER[0].count_cer;
            }, function () { });

            listree();
        }

        else if (KEY == 'LCN') {
            alert();
        }

    };

    $scope.DATA_CPP = function (PROCESS_ID) {
        var getdata = CENTER_SV.SP_GET_CER_DRUG_APPROVED_PROCESS(PROCESS_ID);
        getdata.then(function (datas) {
            $scope.LIST_CER = datas.data;
            
        }, function () { });
    };

    $scope.BTN_Search = function (CITIZEN_ID) {
        sessionStorage.CITIZEN_ID_REPLACEMENT = CITIZEN_ID;
        var url = "/LCN/FRM_SELECT_LCN";
        REDIRECT(url);
    };
    
    $scope.currentPage = 0;
    $scope.paging = {
        total: 10,
        current: 1,
        onPageChanged: loadPages
    };

    function loadPages() {
        console.log('Current page is : ' + $scope.paging.current);

        // TODO : Load current page Data here

        $scope.currentPage = $scope.paging.current;
    }

}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);

function Openmodel() {
    $('#myModal').modal('toggle'); // เป็นคำสั่งเปิดปิด
}

app.filter('startFrom', function () {
    return function (input, start) {
        if (input) {
            start = +start;
            return input.slice(start);
        }
        return [];
    };
});

