
@Code
    ViewData("Title") = "Home Page"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/AUTHEN/FRM_CER_MAIN_CTRL.js?v1"></script>

<div class="ic" ng-controller="FRM_CER_MAIN_CTRL" ng-app="ANGULAR_APP">

    <table width="100%">
        <tr>
            <td colspan="5"><h3><asp:Label>TEST</asp:Label></h3></td>
        </tr>
        <tr>

            <td class="ob-margin">
                <a ng-click="SELECT_LCN()">
                    เลือก
                </a>
            </td>
        </tr>
    </table>

</div>


