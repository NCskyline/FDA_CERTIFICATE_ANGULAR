
app.service("CENTER_SV", function ($http, Upload) {

    this.SP_MAINCOMPANY_IDENTIFY = function (IDENTIFY) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_MAINCOMPANY_IDENTIFY"),
            params: { 
                IDENTIFY: IDENTIFY     
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

    this.SP_GET_DATA_CER_ALL = function (rcvno, ref_code) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_DATA_CER_ALL"),
            params: {
                rcvno: rcvno,
                ref_code: ref_code
            }
        });
        return response;
    };

    this.SP_GET_CER_DRUG_ALL_RCV = function (process_id) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_CER_DRUG_ALL_RCV"),
            params: {
                process_id: process_id
            }
        });
        return response;
    };

    this.SP_GET_CER_DRUG_APPROVED_PROCESS = function (process_id) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_CER_DRUG_APPROVED_PROCESS"),
            params: {
                process_id: process_id
            }
        });
        return response;
    };

    this.SP_GET_CER_DRUG_LCN = function (CITIZEN) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_CER_DRUG_LCN"),
            params: {
                CITIZEN: CITIZEN
            }
        });
        return response;
    };
});