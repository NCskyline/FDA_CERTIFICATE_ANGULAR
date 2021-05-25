
@Code
    ViewData("Title") = "Home Page"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

    <link rel="stylesheet" href="../dist/listree.min.css" />
<script src="../js/dist/listree.umd.min.js"></script>
<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/AUTHEN/FRM_CER_MAIN_CTRL.js"></script>

<div ng-controller="FRM_CER_MAIN_CTRL" ng-app="ANGULAR_APP">
    <div class="content-part" ng-init="Pageload('MAIN')">
        <div class="part part-1-3 no-bg">
            <ul class="listree">
                <li>
                    <div class="listree-submenu-heading" >STANDARD CERTIFICATE</div>
                    <ul class="listree-submenu-items" >
                        <li>
                            <a ng-click="DATA_CPP('950002')">CERTIFICATE OF A PHARMACEUTICAL PRODUCT(CPP) </a>(<a style="color:red">{{cpp}}</a>)
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950003')">CERTIFICATE OF A PHARMACEUTICAL PRODUCT(CPP) แบบ 1 หน้า </a>(<a style="color:red">{{cpp1}}</a>)
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950004')">CERTIFICATE OF A PHARMACEUTICAL PRODUCT(CPP) แบบ 5 หน้า </a>(<a style="color:red">{{cpp5}}</a>)
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950001')">CERTIFICATE OF FREE SALE </a>(<a style="color:red">{{cfs}}</a>)
                        </li>
                    </ul>                    
                </li>
                <li>
                    <div class="listree-submenu-heading">TRANSLATION</div>
                    <ul class="listree-submenu-items">
                    </ul>                    
                </li>
                <li>
                    <div class="listree-submenu-heading">CERTIFICATE OF LOT RELEASE</div>
                    <ul class="listree-submenu-items">
                        <li>
                            <a ng-click="">รผ.01 </a>(<a style="color:red"></a>)
                        </li>
                        <li>
                            <a ng-click="">รผ.02 </a>(<a style="color:red"></a>)
                        </li>
                        <li>
                            <a ng-click="">รผ.03 </a>(<a style="color:red"></a>)
                        </li>
                        <li>
                            <a ng-click="">รผ.04 </a>(<a style="color:red"></a>)
                        </li>
                        <li>
                            <a ng-click="">รผ.05 </a>(<a style="color:red"></a>)
                        </li>
                    </ul>
                </li>
            </ul>
        </div>
        <div class="part part-2-3 no-bg">
            <div><h3>แสดงรายการ Certificate ที่ผ่านการอนุมัติแล้ว</h3></div>

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
                    <div class="card" style=" border-top: 10px solid #277210;">
                        <table style="margin-top:10px;width:100%;" class="table table-condensed" >
                            <thead>
                                <tr>
                                    <th>เลขรับ</th>
                                    <th>วันที่รับ</th>
                                    <th>ประเภท CER</th>
                                    <th>Ref.No</th>
                                    <th>รหัสดำเนินการ</th>
                                    <th>สถานะ</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr ng-repeat="datas in LIST_CER | filter : filter">

                                    <td>{{datas.RCVNO}}</td>
                                    <td>{{datas.datercvno}}</td>
                                    <td>{{datas.PROCESS_DESCRIPTION}}</td>
                                    <td>{{datas.REF_CODE}}</td>
                                    <td>{{datas.XML_NAME}}</td>
                                    <td>{{datas.STATUS_NAME}}</td>
                                    <td>
                                        <span class="fa fa-eye"></span>
                                        <a ng-click="SELECT_LCN(datas,'12')">
                                            เลือก
                                        </a>
                                    </td>
                                </tr>
                            </tbody>
                            <uib-pagination class="pagination-sm" total-items="filterData.length" ng-model="page"
                                            ng-change="pageChanged()" previous-text="&lsaquo;" next-text="&rsaquo;" items-per-page=10
                                            boundary-link-numbers="true" rotate="false" max-size="maxSize">
                            </uib-pagination>
                        </table>  
                    </div>
                </div>
            </div>
        </div>
    </div>
    
</div>


