<!DOCTYPE html>
<html>
<head>
    <title></title>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name='created_by' content='This is example, please fill you name.'>

    <!-- Core template -->
    <link rel="stylesheet" type="text/css" href="~/css/fonts.css" />
    <link rel="stylesheet" type="text/css" href="~/css/icomoon/styles.css" />
    <link rel="stylesheet" type="text/css" href="~/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="~/css/bootstrap_limitless.min.css" />
    <link rel="stylesheet" type="text/css" href="~/css/layout.min.css" />
    <link rel="stylesheet" type="text/css" href="~/css/components.min.css" />
    <link rel="stylesheet" type="text/css" href="~/css/colors.min.css" />
    <link rel="stylesheet" type="text/css" href="~/css/fontawesome-all.min.css" />
    <link rel="stylesheet" type="text/css" href="~/css/home.css" />
    <link href="~/css/addition_css_20200408.css" rel="stylesheet" />
    <script type="text/javascript">var base_url = "./"; base_url_lang = "./en/"; var lang = "en";</script>
    @*<script type="text/javascript" src="/js/jquery-3.3.1.min.js"></script>*@
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/angular_material/1.1.12/angular-material.min.css">


    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>


    <!-- CSS page -->
    <link rel="stylesheet" type="text/css" href="~/css/page.css" />
    <!-- End CSS page -->
    <!-- JS page -->
    <script type="text/javascript" src="~/js/common.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@8"></script>
    <script src="~/Scripts/angular.js"></script>
    <script src="~/Scripts/angular-animate.js"></script>
    <script src="~/Scripts/angular-aria.js"></script>
    <script src="~/Scripts/angular-messages.js"></script>
    <script src="~/Scripts/ng-file-upload.js"></script>
    <script src="~/Scripts/angular-material.js"></script>
    <link href="~/css/spinners.css" rel="stylesheet" />
    <script src="~/Scripts_angular/JS_COMMON.js"></script>
    <script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    @*<script src="//code.jquery.com/jquery-1.11.0.min.js"></script>*@
</head>
<body>
    @Html.Partial("header", Nothing)
    <div id="main-content" ng-app="ANGULAR_APP">
        <div class="loading-spiner-holder" data-loading style="background:#04adfd40;width: 100%;height: 100%;position: fixed;z-index: 99999;">
            <div class="loading-spiner">
                <span class="dots-loader" style="position: fixed;z-index: 100000;top: 50%;left: 50%;">Loading&#8230;</span>

            </div>
        </div>
            <nav class="navbar navbar-expand-sm" style="background-color:#329704">
                <!-- Brand -->
                <a class="navbar-brand" href="#">Logo</a>

                <!-- Links -->
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link" href="#" style="color:white">หน้าแรก</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#" style="color:white">ค้นหาผลิตภัณฑ์</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#" style="color:white">รับเรื่องแทนผู้ประกอบการ</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="http://privus.fda.moph.go.th/" style="color:white">ออกจากระบบ</a>
                    </li>
                    <!-- Dropdown -->
                    @*<li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="navbardrop" data-toggle="dropdown">
                        Dropdown link
                    </a>
                    <div class="dropdown-menu">
                        <a class="dropdown-item" href="#">Link 1</a>
                        <a class="dropdown-item" href="#">Link 2</a>
                        <a class="dropdown-item" href="#">Link 3</a>
                    </div>
                </li>*@
                </ul>
            </nav>
        
        <div class="wrap-main-content">
            <div id="page">
                <div class="content-overlay"></div>
                @*@Html.Partial("menu_popup", Nothing)*@
                <div id="page-adr-2019">
                    <div class="page-header">
                        <div class="card-tab-control page-header-content header-elements-md-inline container"></div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="page-content container ">
                        <div class="content-wrapper">
                            <div class="content">
                                <div class="no-pm no-bg card no-border card-tab card-tab1 active">
                                    @RenderBody()
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <footer>
        <div class="ft1">
            สำนักงานคณะกรรมการอาหารและยา กระทรวงสาธารณสุข
        </div>
        <div class="ft2">
            88/24 ถนนติวานนท์ อ.เมือง จ.นนทบุรี 11000 <br>
            โทรศัพท์ 0-2590-7000
        </div>
    </footer>
</body>
</html>


