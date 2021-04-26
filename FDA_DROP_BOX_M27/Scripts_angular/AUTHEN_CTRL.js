

app.controller('AUTHEN_CTRL', function ($scope, CENTER_SV, $http, $location) {


    $scope.loading = true;

    $scope.DOC_ID = 0;
    $scope.DOC_TITLE = "TEST";
    $scope.IS_USE = 0;

    pageload();

    function pageload() {
        Swal.showLoading();
        //var token = QueryString("Token");
        var token = "PASS";
        sessionStorage.token = token;

        var getData = CENTER_SV.GET_AUTHEN(token);
    

        getData.then(function (datas) {
            $scope.AUTHEN = datas.data;
            if (datas.data.CODE == '900') {
                sessionStorage.CITIZEN_ID = datas.data.CITIZEN_ID;
                sessionStorage.CITIZEN_ID_AUTHORIZE = datas.data.CITIZEN_ID_AUTHORIZE;
                sessionStorage.THANM = datas.data.THANM;
                sessionStorage.COMPANY_NAME = datas.data.COMPANY_NAME;

                
 
                window.location = "/HOME/FRM_CUSTOMER_LCN"; // << ปิดเวลาอัพขึ้นเซิร์ฟ เปิดแถวล่าง
                //window.location = "/DRUG_DROPBOX/HOME/FRM_CUSTOMER_LCN"; 
            }
            else {

                window.location = "http://privus.fda.moph.go.th";
              //  
            }
            //LOAD_JS();
        }, function () { });

      //  GET_LIST_WAIT();
    }


}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2') });
}]);



