app.service("CENTER_SV", function ($http, Upload) {

    this.SP_GET_BOX_CTZNO = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_BOX_CTZNO"),
            params: { 
                LCN_IDA: LCN_ID,
                CTZNO: CITIZEN_NO,
                LCN_TYPE: LCN_TYPE,
                TOKEN: TOKEN
            }
        });
        return response;
    };


    this.UPDATE_BOX_INV = function (model, model2) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/UPDATE_BOX_INV"), //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            data: {
                XML: JSON.stringify(model),
                XML2: JSON.stringify(model2)
            }
        });
        return response;
    };


    this.GETDATA_FILE_TR_ID = function (TR_ID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GETDATA_FILE_TR_ID"),
            params: {
                TR_ID: TR_ID
            }
        });
        return response;
    };

    this.SP_GET_BOX_STAFF = function (ORG) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_BOX_STAFF"),
            params: {
                ORG: ORG
            }
        });
        return response;
    };

    this.SP_GET_BOX_APPROVE = function (TR_ID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_BOX_APPROVE"),
            params: {
                TR_ID: TR_ID
            }
        });
        return response;
    };

    this.SP_GET_BOX_STAFF_STATUS = function (ORG,STATUS) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_BOX_STAFF_STATUS"),
            params: {
                ORG: ORG,
                STATUS: STATUS
            }
        });
        return response;
    };
    

    this.SP_GET_PRODUCT_TYPE = function (PRODUCT_GROUP) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_PRODUCT_TYPE"),
            params: {
                PRODUCT_GROUP: PRODUCT_GROUP
            }
        });
        return response;
    };

    this.SP_GET_ISO = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_ISO"),
            params: {
                CTZNO: CITIZEN_NO,
                TOKEN: TOKEN
            }
        });
        return response;
    };
    this.SP_GET_PROCESS  = function (ORG) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_PROCESS"),
            params: {
                ORG: ORG,
                PROCESS_TYPE : LCN_TYPE
            }
        });
        return response;
    };
    
    this.GETDATA_FILE_TEMPLATE = function (PROCESS) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GETDATA_FILE_TEMPLATE"),
            params: {
                PROCESS: PROCESS,
                LCN_TYPE: LCN_TYPE
            }
        });
        return response;
    };

    this.GET_LIST_LCN = function (IDENTIFY) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_LIST_LCN"),
            params: {
                IDENTIFY: IDENTIFY,
                TOKEN: TOKEN,
                CTZNO: CITIZEN_NO
            }
        });
        return response;
    };

    this.GETDATA_SYSISOCNT = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_SYSISOCNT")
            
        });
        return response;
    };

    this.GETDATA_SIP_UNIT = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_SIP_UNIT")

        });
        return response;
    };

    this.GETDATA_DRDOSAGE = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_DRDOSAGE")

        });
        return response;
    };

    this.GET_AUTHEN = function (TOKEN) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_AUTHEN"),
            params: {
                TOKEN: TOKEN
            }
        });
        return response;
    };
    
    this.SET_MODEL = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SETMODEL")
        });
        return response;
    };


    this.GET_DATAPROCESS = function (P_ID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_DATAPROCESS"),
            params: {
                P_ID: P_ID,
                LCN_TYPE: LCN_TYPE
            }
        });
        return response;
    };

    this.GETDATA_DRUG_PRODUCT = function (register) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_DRUG_PRODUCT_ESUB"),
            params: {
                register : register
            }
        });
        return response; 
    };

    this.SETMODEL_LIST = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SETMODEL_LIST")
        });
        return response;
    };
    
    this.GETDATA_INV_ITEM = function (TR_ID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GETDATA_INV_ITEM"),
            params: {
                TR_ID: TR_ID,
                CTZNO: CITIZEN_NO,
                TOKEN: TOKEN
            }
        });
        return response;
    };

    this.UPLOAD_PDF = function (CITIZEN_ID, TOKEN, file) { //เรียก Full model
        var response = Upload.upload({
            // url: host + "FOOD_CUST/UPLOAD_PDF",
            url: SET_URL_SV("/SV_CENTER/UPLOAD_PDF"),
            data: {
                CITIZEN_ID: CITIZEN_ID,
                TOKEN: TOKEN,
                files: file
            }
        });
        return response;
    };



    this.UPLOAD_PDF_V2 = function (model, file) { //เรียก Full model

        var response = Upload.upload({
            // url: host + "FOOD_CUST/UPLOAD_PDF",
            url: SET_URL_SV("/SV_CENTER/UPLOAD_PDF_V2"),
            data: {
                model: JSON.stringify(model),
                files: file
            }
        });
        return response;
    };


    this.UPLOAD_PDF_V3 = function (model, file) { //เรียก Full model

        var response = Upload.upload({
            // url: host + "FOOD_CUST/UPLOAD_PDF",
            url: SET_URL_SV("/SV_CENTER/UPLOAD_PDF_V3"),
            data: {
                model: JSON.stringify(model),
                files: file
            }
        });
        return response;
    };

    this.ADD_DATA_INV = function (model, model2) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/ADD_DATA_INV"), //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            data: {
                XML: JSON.stringify(model),
                XML2: JSON.stringify(model2),
                TOKEN: TOKEN,
                CTZNO: CITIZEN_NO
            }
        });
        return response;
    };

    this.GETDATA_BOX_TR_ID = function (TR_ID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GETDATA_BOX_TR_ID"),
            params: {
                TR_ID: TR_ID,
                TOKEN: TOKEN,
                CTZNO: CITIZEN_NO
            }
        });
        return response;
    };

    this.UPDATE_DATA = function (TR_ID, STATUS_ID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/UPDATE_DATA"), //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            data: {
                TR_ID: TR_ID,
                STATUS_ID: STATUS_ID,
                TOKEN: TOKEN,
                CTZNO: CITIZEN_NO
            }
        });
        return response;
    };


    


    this.UPDATE_ITEM_INVOICE_STATUS = function (IDA) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/UPDATE_ITEM_INVOICE_STATUS"), //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            data: {
                IDA: IDA
            }
        });
        return response;
    };

    this.UPDATE_DATA_STAFF = function (TR_ID, STATUS_ID, REMARK) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/UPDATE_DATA_STAFF"), //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            data: {
                TR_ID: TR_ID,
                STATUS_ID: STATUS_ID,
                REMARK: REMARK,
                TOKEN: TOKEN,
                CTZNO: CITIZEN_NO
            }
        });
        return response;
    };

    this.SP_GET_INV_HISTORY = function (CTZNO) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_INV_HISTORY"),
            params: {
                CTZNO: CTZNO
            }
        });
        return response;
    };
});