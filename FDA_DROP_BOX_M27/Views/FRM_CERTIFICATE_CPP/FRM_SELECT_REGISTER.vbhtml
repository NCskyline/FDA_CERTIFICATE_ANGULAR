<div>

    <table>
        <tr>
            <td>ชื่อบริษัท</td>
            <td></td>
            <td style="margin-left:2%">(เลขที่ใบอนุญาต : {{LCNNO}} )</td>
        </tr>
        <tr>
            <td>ที่อยู่</td>
            <td></td>
        </tr>
        <tr>
            <td>สถานที่</td>
            <td></td>
        </tr>
    </table>
    <hr style="width:70%" />
    <div><h3>เลือกรายการ</h3></div>
    <div class="row">
        <div class="col-sm-12">
            <div class="search-item">
                <input class="search-input" type="text" placeholder="ค้นหา...เลขทะเบียน หรือ ชื่อผลิตภัณฑ์" ng-model="filter">
                <i class="fa fa-search search-icon"></i>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-12">
            <div class="card" ng-repeat="datas in LIST_LCN | filter : filter" style=" border-top: 10px solid #277210;">

                <div class="card-body" style="padding:unset;font-size: 15px;">
                    <div class="row">
                        <div class="col-sm-10">
                            <div class="row">
                                <div class="col-sm-2 set-topic">
                                    เลขทะเบียน :
                                </div>
                                <div class="col-sm-10">
                                    {{datas.LCNNO}}
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-2 set-topic">
                                    ชื่อผลิตภัณฑ์(ไทย) :
                                </div>
                                <div class="col-sm-10">
                                    {{datas.NAME}}
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-2 set-topic">
                                    ชื่อผลิตภัณฑ์(อังกฤษ) :
                                </div>
                                <div class="col-sm-10">
                                    {{datas.ADDR}}
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-2 set-topic">
                                    วันที่อนุมัติ :
                                </div>
                                <div class="col-sm-10">
                                    {{datas.LCN_TYPE}}
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

