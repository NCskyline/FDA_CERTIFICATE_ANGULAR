
<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/AUTHEN/FRM_CER_MAIN_CTRL.js"></script>
<div ng-controller="FRM_CER_MAIN_CTRL" ng-app="ANGULAR_APP">
    <div>
        <h3>รับเรื่องแทนผู้ประกอบการ</h3>
    </div>
    <hr />
    <table width="50%" align="center">
        <tr>
            <td align="center">เลขนิติบุคคล</td>
            <td><input type="text" ng-model="CITIZEN_ID" /></td>
        </tr>
    </table>
    <hr />
    <div align="center"><input type="button" ng-click="BTN_Search(CITIZEN_ID)" value="ตกลง" /></div>
</div>
