function QueryString(name) {
    var regexS = "[\\?&]" + name + "=([^&#]*)",
        regex = new RegExp(regexS),
        results = regex.exec(window.location.search);
    if (results === null) {
        return "";
    } else {
        return decodeURIComponent(results[1].replace(/\+/g, " "));
    }
}

function REDIRECT(urls) {
    var host = '';
    var full_url = host + urls;
    window.location = full_url;
}


function SET_URL_SV(url) {
    var host = '';
    var full_url = host + url;
    return full_url;
}

var CITIZEN_NO;
var TOKEN;
var THANM_DATA;
var EMAIL_DATA;
var TEL_DATA;
var CITIZEN_ID_AUTHORIZE;
var COMPANY_NAME;
var LCN_ID;
var LCNNO;
var LCN_TYPE;
var LCN_ADDR;
var LCN_NAME;
//var COMPANY_NAME;
function CHK_TOKEN() {


    if (sessionStorage.token == undefined) {
        window.location = "https://privus.fda.moph.go.th";
    }
    else {

        CITIZEN_NO = sessionStorage.CITIZEN_ID_AUTHORIZE;
        TOKEN = sessionStorage.token;
        THANM_DATA = sessionStorage.THANM;
        CITIZEN_ID_AUTHORIZE = sessionStorage.CITIZEN_ID_AUTHORIZE;
        LCN_ID = sessionStorage.LCN_ID;
        LCNNO = sessionStorage.LCNNO;
        LCN_TYPE = sessionStorage.LCN_TYPE;
        LCN_ADDR = sessionStorage.LCN_ADDR;
        LCN_NAME = sessionStorage.LCN_NAME;
        COMPANY_NAME = sessionStorage.COMPANY_NAME;

        //var THANM = 'ชื่อ-นามสกุล' + sessionStorage.THANM + ' ผู้รับอนุญาต ' + COMPANY_NAME;
        var THANM = 'ชื่อ-นามสกุล' + THANM_DATA + ' ผู้รับอนุญาต ' + COMPANY_NAME;
        document.getElementById("result").innerHTML = THANM;



        document.getElementById("app").innerHTML = "DRUG DROPBOX";
    }
}



       



function success_data(msg) {
    Swal.fire({
        type: 'success',
        title: 'success',
        text: msg
    });

    //window.location = "/HOME/CER_REQ";
}

function ERR_DATA(msg) {
    Swal.fire({
        icon: 'error',
        title: 'เกิดข้อผิดพลาด',
        text: msg
    });
    //window.location = "/HOME/CER_REQ";
}