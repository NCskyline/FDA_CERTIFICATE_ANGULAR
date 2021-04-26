
@Code
    ViewData("Title") = "Home Page"
    Layout = ""
End Code

<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN/FRM_SELECT_LCN_CTRL.js"></script>

<div class="ic" ng-controller="FRM_SELECT_LCN_CTRL" ng-app="ANGULAR_APP">

    <div class="title-ic">
        รายการสถานที่ <i class="tt-ic fas fa-bookmark"></i>
    </div>

    <hr />
    <div class="row">
        <div class="col-sm-12">
            <div class="search-item">
                <input class="search-input" type="text" placeholder="ค้นหา..." ng-model="filter">
                <i class="fa fa-search search-icon"></i>
            </div>
        </div>
    </div>
    <hr />
    <div class="row">
        <div class="col-sm-12">
            <div class="card" ng-repeat="datas in LIST_LCN | filter : filter" style=" border-top: 10px solid #277210;">

                <div class="card-body" style="padding:unset;font-size: 15px;">
                    <div class="row">
                        <div class="col-sm-10">
                            <div class="row">
                                <div class="col-sm-2 set-topic">
                                    ใบอนุญาต :
                                </div>
                                <div class="col-sm-10">
                                    {{datas.LCNNO}}
                                </div>
                            </div>
                            @*<div class="row">
                                    <div class="col-sm-2 set-topic">
                                        ประเภทสถานที่ :
                                    </div>
                                    <div class="col-sm-10">
                                        {{datas.LCN_TYPE}}
                                    </div>
                                </div>*@

                            <div class="row">
                                <div class="col-sm-2 set-topic">
                                    ชื่อสถานที่ :
                                </div>
                                <div class="col-sm-10">
                                    {{datas.NAME}}
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-2 set-topic">
                                    ที่อยู่ :
                                </div>
                                <div class="col-sm-10">
                                    {{datas.ADDR}}
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-2">
                            <div class="row set-a-btn">
                                @*<div class="col-sm-12 ">
                                        <span class="fa fa-eye"></span>
                                        <a ng-click="SELECT_LCN(datas,'11')">
                                            ผลิต
                                        </a>
                                    </div>*@

                                <div class="col-sm-12 ">
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="SELECT_LCN(datas,'12')">
                                        เลือก
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
        </div>
    </div>
</div>
