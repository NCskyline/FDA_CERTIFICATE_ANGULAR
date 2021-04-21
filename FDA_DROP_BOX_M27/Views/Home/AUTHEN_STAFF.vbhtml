@Code
    ViewData("Title") = "Home Page"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/AUTHEN_STAFF_CTRL.js?v1"></script>

<div class="ic" ng-controller="AUTHEN_STAFF_CTRL" ng-app="ANGULAR_APP">

    <div class="title-ic">
        รายการ ผู้ผลิตต่างประเทศ<i class="tt-ic fas fa-bookmark"></i>
    </div>
    <div class="ic-item-list">
        <div class="wrap-ic-item-list">
            <div class="ic-item active" style="width:50%">
                <div class="text-label">ผู้ผลิตต่างประเทศทั้งหมด</div>
                <div class="number-label">{{LIST_CER.length}}</div>
            </div>
            
            <div class="clearfix"></div>
        </div>
    </div>
    <div>
        <table>

            <tr>
                <td>เลขผู้รับอนุญาต</td>
                <td>
                    0000000000000
                </td>
            </tr>
            <tr>
                <td>ชื่อผู้รับอนุญาต</td>
                <td>
                    บริษัท ทดสอบ จำกัด
                </td>
            </tr>
            <tr>
                <td>ที่อยู่ผู้รับอนุญาต</td>
                <td>
                    บ้านเลขที่ 2/139 ถนนพระยาสุเรนทร์  แขวง บางชัน เขต คลองสามวา จังหวัด กรุงเทพมหานคร 10510
                </td>
            </tr>

        </table>
    </div>
    <hr />
    <div class="search-item">
        <input class="search-input" type="text" placeholder="ค้นหา...">
        <i class="fa fa-search search-icon"></i>
    </div>
    <div ng-repeat="datas in LIST_CER">
        <div class="box-list-data">
            <div class="box-data-according">
                <div class="box-header">
                    <div class="header-cicle" ng-click="CER_GET(datas)"><span class="circle"></span></div>
                    <div class="header-text">
                        <div class="main-text">{{datas.Producer_Name}}</div>
                        <div class="sub-text">{{datas.frgn_addr}}</div>
                        <div class="sub-text">{{datas.cntcd}}</div>
                        <div class="sub-text">จำนวนผลิตภัณฑ์ {{datas.total}}</div>
                    </div>
                    
                    <div class="header-menu">
                        <i class="fa fa-ellipsis-h"></i>
                    </div>
                </div>
                <div class="clearfix"></div>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>

</div>

