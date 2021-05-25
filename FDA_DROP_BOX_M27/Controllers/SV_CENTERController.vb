Imports System.IO
Imports System.Web.Mvc
Imports System.Web.Script.Serialization
Imports System.Xml
Imports System.Xml.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Controllers
    Public Class SV_CENTERController
        Inherits Controller


        Public _APP As String = System.Configuration.ConfigurationManager.AppSettings("APP")
        Public _SYSTEM_ID As String = System.Configuration.ConfigurationManager.AppSettings("SYSTEM_ID")
        Public _PATH_BOX As String = System.Configuration.ConfigurationManager.AppSettings("PATH_BOX")
        Public _PATH_BOX_TEMPLATE As String = System.Configuration.ConfigurationManager.AppSettings("PATH_BOX_TEMPLATE")
        Dim msg_r As New MODEL_RESULT
        Dim BAO_L As New BAO_DROPBOX


#Region "PDF"

#End Region

#Region "STORE"
        Function SP_GET_CER_DRUG_ALL_RCV(ByVal PROCESS_ID As Integer) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_GET_CER_DRUG_ALL_RCV(PROCESS_ID)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_CER_DRUG_LCN(ByVal CITIZEN As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_GET_DRUG_LCN_IDEN(CITIZEN)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_GET_CER_DRUG_APPROVED_PROCESS(ByVal PROCESS_ID As Integer) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_GET_CER_DRUG_APPROVED_PROCESS(PROCESS_ID)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_DATA_CER_ALL(ByVal RCVNO As String, ByVal REF_CODE As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_GET_CER_DRUG_APPROVED(RCVNO, REF_CODE)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_BOX_APPROVE(ByVal TR_ID As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_GET_BOX_APPROVE(TR_ID)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_PRODUCT_TYPE(ByVal PRODUCT_GROUP As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_PRODUCT_TYPE(PRODUCT_GROUP)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_DRUG_PRODUCT_ESUB(ByVal register As String) As JsonResult
            Dim DT As New DataTable
            Dim bao As New BAO
            DT = bao.SP_GET_DRUG_PRODUCT_ESUB(register)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_ISO(ByVal CTZNO As String, ByVal TOKEN As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_ISO()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function
        Function SP_GET_BOX_CTZNO(ByVal LCN_IDA As String, ByVal CTZNO As String, ByVal LCN_TYPE As String, ByVal TOKEN As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_BOX_CTZNO(CTZNO, LCN_IDA, LCN_TYPE)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_BOX_STAFF(ByVal ORG As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_BOX_STAFF(_APP)

            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function


        Function SP_GET_BOX_STAFF_STATUS(ByVal ORG As String, ByVal STATUS As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_BOX_STAFF_STATUS(_APP, STATUS)

            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_SYSISOCNT() As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_SYSISOCNT()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_SIP_UNIT() As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_SIP_UNIT()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_DRDOSAGE() As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_DRDOSAGE()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_PROCESS(ByVal ORG As String, ByVal PROCESS_TYPE As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_PROCESS(ORG, PROCESS_TYPE)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function




#End Region

#Region "GET_DATA"


        Function GET_LIST_LCN(ByVal IDENTIFY As String, ByVal TOKEN As String, ByVal CTZNO As String) As JsonResult
            Dim MODEL_LIST As New List(Of MODEL_LCN)

            Dim bao_sp As New BAO
            Dim dt As New DataTable


            'dt = bao_sp.SP_LOCATION_MDC(IDENTIFY)
            'For Each dr As DataRow In dt.Rows
            '    Dim M_LCN As New MODEL_LCN
            '    With M_LCN
            '        .ADDR = dr("licen_addr")
            '        .LCNNO = dr("LCN_DISPLAY")
            '        .LCN_IDA = dr("Newcode")
            '        .NAME = dr("thanm")
            '        .LCN_TYPE = dr("rgttpnm")
            '        .SYSTEM_NAME = "MDC"
            '    End With
            '    MODEL_LIST.Add(M_LCN)
            'Next


            dt = bao_sp.SP_GET_LOCATION_ADDR(IDENTIFY)
            For Each dr As DataRow In dt.Rows
                Dim M_LCN As New MODEL_LCN
                With M_LCN
                    .ADDR = dr("fulladdr")
                    Try
                        .LCNNO = dr("LCNNO")
                    Catch ex As Exception

                    End Try

                    .LCN_IDA = dr("IDA")
                    .NAME = dr("nameplace")
                    .LCN_TYPE = "นำเข้า"
                    .SYSTEM_NAME = "CENTER"
                End With
                MODEL_LIST.Add(M_LCN)
            Next

            Return Json(MODEL_LIST, JsonRequestBehavior.AllowGet)
        End Function



        Function GET_AUTHEN(ByVal TOKEN As String) As JsonResult
            'CHECK_URL()

            Dim _CLS As New CLS_SESSION

            If TOKEN = "PASS" Then
                _CLS.CITIZEN_ID = "0105522020724" ''"1100400181875"
                _CLS.CITIZEN_ID_AUTHORIZE = "0105522020724" '"0105540078852"
                _CLS.COMPANY_NAME = "บริษัท เทสออนลี่ จำกัด มหาขน"
                _CLS.THANM = "นายทดสอบ ระบบ"
                _CLS.TOKEN = TOKEN
                _CLS.CODE = "900"
            Else


                Dim ws As New WS_AUTHEN.Authentication
                Dim xml As String = ""
                xml = ws.Authen_Login(TOKEN)

                Dim clsxml As New Cls_XML
                clsxml.ReadData(xml)
                _CLS.CITIZEN_ID = clsxml.Get_Value_XML("Citizen_ID")
                _CLS.CITIZEN_ID_AUTHORIZE = clsxml.Get_Value_XML("CITIEZEN_ID_AUTHORIZE")
                _CLS.TOKEN = TOKEN
                _CLS.GROUPS = clsxml.Get_Value_XML("Groups")
                _CLS.SYSTEM_ID = clsxml.Get_Value_XML("System_ID")
                _CLS.PVCODE = clsxml.Get_Value_XML("pvcode")
                _CLS.THANM = clsxml.Get_Value_XML("Name")
                _CLS.CODE = clsxml.Get_Value_XML("CODE")

                'Dim xml_c As String = ""
                'ดึงชื่อคน LOGIN เข้าระบบ
                Dim ws_c As New WS_GET_CPN.WS_DATA_CENTER
                'xml_c = ws_c.GET_DATA_IDENTIFY(_CLS.CITIZEN_ID, "0994000165676", "FUSION", "P@ssw0rdfusion440")
                'clsxml.ReadData(xml_c)
                'Dim CUSTOMER_NAME As String = clsxml.Get_Value_XML("thanm")
                '_CLS.THANM = CUSTOMER_NAME

                Dim xml_COM As String = ""
                xml_COM = ws_c.GET_DATA_IDENTIFY(_CLS.CITIZEN_ID_AUTHORIZE, "0994000165676", "FUSION", "P@ssw0rdfusion440")
                clsxml.ReadData(xml_COM)
                Dim COMPANY_NAME As String = clsxml.Get_Value_XML("prefixnm") & " " & clsxml.Get_Value_XML("thanm") & " " & clsxml.Get_Value_XML("thalnm")
                _CLS.COMPANY_NAME = COMPANY_NAME
                _CLS.ADDR = clsxml.Get_Value_XML("Fulladdr")

                'If CUSTOMER_NAME = "" Then 'กรณีไม่เจอ
                '    'ดึงกรมการปกครอง
                '    xml_c = ws_c.FDA_IDENTIFY(_CLS.CITIZEN_ID, "0994000165676", "FUSION", "P@ssw0rdfusion440")
                '    clsxml.ReadData(xml_c) 'อ่าน XML อีกรอบ
                '    CUSTOMER_NAME = clsxml.Get_Value_XML("prefixnm") & " " & clsxml.Get_Value_XML("thanm")
                '    If CUSTOMER_NAME = "" Then 'เป็นค่าว่งอีกรอบเอาจาก สพร 
                '        Dim dao_e As New DAO_CPN.TB_SYSEMAIL
                '        dao_e.GetDataby_CTZNO(_CLS.CITIZEN_ID)
                '        CUSTOMER_NAME = dao_e.fields.NAME
                '    End If
                '    _CLS.THANM_CUSTOMER = CUSTOMER_NAME
                'Else
                '    _CLS.THANM_CUSTOMER = clsxml.Get_Value_XML("prefixnm") & " " & clsxml.Get_Value_XML("thanm")
                'End If




            End If



            Return Json(_CLS, JsonRequestBehavior.AllowGet)
        End Function


#End Region

#Region "MODEL DATA"
        Public Function SETMODEL() As JsonResult
            Dim MODEL As New MODEL_BOX


            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function


        Public Function SETMODEL_LIST() As JsonResult
            Dim MODEL As New MODEL_FILELIST
            Dim filelist As New FILE_LIST
            filelist.FILENAME = ""
            filelist.DES = ""
            filelist.FILE_DATA = ""
            filelist.PIORITY = ""
            filelist.PATH = ""
            filelist.FLAG = ""
            MODEL.FILE_LISTs.Add(filelist)
            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function
#End Region

#Region "UPLOAD PDF"
        Public Function UPLOAD_PDF(ByVal CITIZEN_ID As String, ByVal TOKEN As String) As JsonResult
            Dim filename As String = ""
            Dim path As String = _PATH_BOX_TEMPLATE & "\" & CITIZEN_ID & "\" & TOKEN
            Directory.CreateDirectory(path)
            Dim PATHs As String = ""
            Dim path_file As String = ""
            Try
                For Each s As String In Request.Files
                    filename = Request.Files(0).FileName
                    path_file = path & "\" & Date.Now.ToOADate & ".pdf"
                    Dim postedFile As HttpPostedFileBase = Request.Files(0)

                    postedFile.SaveAs(path_file)
                Next
                msg_r.MSG_CODE = "200"
                msg_r.MSG_RESULT = "SUCCESS"
                msg_r.DATA_VALUE = path_file
            Catch ex As Exception
                msg_r.MSG_CODE = "401"
                msg_r.MSG_RESULT = "ERR"
                msg_r.MSG_DES = ex.Message.ToString
                msg_r.DATA_VALUE = ""
            End Try


            Return Json(msg_r, JsonRequestBehavior.AllowGet)
        End Function

        Public Function UPLOAD_PDF_V2(ByVal model As String) As String
            Dim result As String = ""
            Try

                'JArray jsonArray = JArray.Parse(jsonArrayString);
                Dim TR_ID As String = ""
                Dim MODEL_LIST As New MODEL_FILELIST

                Dim jsonArray As JArray = JArray.Parse(model)
                For Each parsedObject As JObject In jsonArray.Children(Of JObject)()
                    Dim filelist As New FILE_LIST
                    Dim kkk As String = parsedObject("TR_ID")
                    For Each parsedProperty As JProperty In parsedObject.Properties()
                        Dim propertyName As String = parsedProperty.Name
                        If propertyName = "TR_ID" Then
                            TR_ID = CStr(parsedProperty.Value)
                            filelist.TR_ID = CStr(parsedProperty.Value)
                        ElseIf propertyName = "FILENAME" Then
                            filelist.FILENAME = CStr(parsedProperty.Value)
                        ElseIf propertyName = "DES" Then
                            filelist.DES = CStr(parsedProperty.Value)
                        ElseIf propertyName = "PATH" Then
                            filelist.PATH = CStr(parsedProperty.Value)
                        ElseIf propertyName = "FLAG" Then
                            filelist.FLAG = CStr(parsedProperty.Value)
                        ElseIf propertyName = "PIORITY" Then
                            filelist.PIORITY = CStr(parsedProperty.Value)
                        ElseIf propertyName = "PROCESS_NAME" Then
                            filelist.PROCESS_NAME = CStr(parsedProperty.Value)
                        End If
                    Next
                    MODEL_LIST.FILE_LISTs.Add(filelist)
                Next



                'Dim dao_m As New DAO.TB_S_BOX
                'dao_m.GETDATA_BY_TR_ID(TR_ID)
                'Dim version As String = dao_m.fields.VERSION
                'Dim path As String = _PATH_BOX & "\" & TR_ID & "\" & version
                'Directory.CreateDirectory(path) 'สร้าง PATH รอ
                'Dim i As Integer = 0
                'For Each f As FILE_LIST In MODEL_LIST.FILE_LISTs
                '    Dim filepath As String = f.PATH

                '    Dim dao_f As New DAO.TB_FILE_BOX
                '    With dao_f.fields
                '        .CREATE_DATE = Date.Now
                '        .TITEL = f.DES
                '        .TR_ID = TR_ID
                '        .PRIORITY = f.PIORITY
                '        .REMARK = ""
                '        .REF_TR_ID = ""
                '    End With
                '    dao_f.insert()
                '    If filepath = "" Then

                '    Else
                '        If HAVE_FILE(filepath) = True Then 'กรณีเจอไฟล์
                '            Dim output_file As String = path & "\" & dao_f.fields.IDA & ".pdf"
                '            COPY_FILE(filepath, output_file)
                '            dao_f.fields.FILENAME = f.FILENAME
                '            dao_f.fields.PATH_FILE = output_file
                '            dao_f.fields.REF_TR_ID = filepath
                '            dao_f.fields.REMARK = f.PROCESS_NAME
                '            dao_f.update()
                '        Else

                '        End If
                '    End If
                'Next
                result = "success"
            Catch ex As Exception
                result = "ERR"
            End Try
            Return result
        End Function


        Public Function UPLOAD_PDF_V3(ByVal model As String) As String
            Dim result As String = ""
            Try
                'JArray jsonArray = JArray.Parse(jsonArrayString);
                Dim TR_ID As String = ""
                Dim MODEL_LIST As New MODEL_FILELIST

                Dim jsonArray As JArray = JArray.Parse(model)
                For Each parsedObject As JObject In jsonArray.Children(Of JObject)()
                    Dim filelist As New FILE_LIST
                    For Each parsedProperty As JProperty In parsedObject.Properties()
                        Dim propertyName As String = parsedProperty.Name
                        If propertyName = "TR_ID" Then
                            TR_ID = CStr(parsedProperty.Value)
                            filelist.TR_ID = CStr(parsedProperty.Value)
                        ElseIf propertyName = "FILENAME" Then
                            filelist.FILENAME = CStr(parsedProperty.Value)
                        ElseIf propertyName = "DES" Then
                            filelist.DES = CStr(parsedProperty.Value)
                        ElseIf propertyName = "PIORITY" Then
                            filelist.PIORITY = CStr(parsedProperty.Value)
                        ElseIf propertyName = "TYPE" Then
                            filelist.TYPE = CStr(parsedProperty.Value)
                        ElseIf propertyName = "PATH" Then
                            filelist.PATH = CStr(parsedProperty.Value)
                        ElseIf propertyName = "FLAG" Then
                            filelist.FLAG = CStr(parsedProperty.Value)
                        ElseIf propertyName = "IDA" Then
                            filelist.IDA = CStr(parsedProperty.Value)
                        End If
                    Next
                    MODEL_LIST.FILE_LISTs.Add(filelist)
                Next
                Dim chk_del As Boolean = True
                For Each f As FILE_LIST In MODEL_LIST.FILE_LISTs
                    Dim IDA As String = f.IDA
                    If IDA = "" Or IDA = "0" Then 'หมายถึงการ INSERT

                    Else 'หมายถึงมี IDA แสดงว่าไม่มีการปรับ PROCESS จะมี IDA ติด
                        chk_del = False
                    End If
                Next
                'If chk_del = True Then
                '    Dim dao As New DAO.TB_FILE_BOX
                '    dao.GETDATA_BY_TR_ID(TR_ID)
                '    dao.DeleteALL()
                'End If

                'Dim dao_m As New DAO.TB_S_BOX
                'dao_m.GETDATA_BY_TR_ID(TR_ID)
                'Dim version As String = "0"
                'Dim path As String = _PATH_BOX & "\" & TR_ID & "\" & version
                'Directory.CreateDirectory(path)
                'Dim i As Integer = 0
                'For Each f As FILE_LIST In MODEL_LIST.FILE_LISTs
                '    Dim IDA As String = f.IDA
                '    Dim f_path As String = f.PATH
                '    Dim filename As String = f.FILENAME


                '    If IDA = "" Or IDA = "0" Then 'หมายถึงการ INSERT
                '        If f.TYPE = "ADD" Then 'หมายถึงมีการแนบไฟล์
                '            Dim dao_f As New DAO.TB_FILE_BOX
                '            With dao_f.fields
                '                .CREATE_DATE = Date.Now
                '                .FILENAME = filename
                '                .TITEL = f.DES
                '                .TR_ID = TR_ID
                '                .PRIORITY = f.PIORITY
                '            End With
                '            dao_f.insert()

                '            If HAVE_FILE(f_path) = True Then 'กรณีเจอไฟล์
                '                Dim path_file As String = path & "\" & dao_f.fields.IDA & ".pdf"
                '                COPY_FILE(f_path, path_file)
                '                dao_f.fields.PATH_FILE = path_file
                '                dao_f.fields.REF_TR_ID = f_path
                '            End If

                '            dao_f.update()
                '            i = i + 1
                '        Else
                '            Dim dao_f As New DAO.TB_FILE_BOX
                '            With dao_f.fields
                '                .CREATE_DATE = Date.Now
                '                .TITEL = f.DES
                '                .TR_ID = TR_ID
                '                .REMARK = ""
                '                .REF_TR_ID = ""
                '                .PRIORITY = f.PIORITY
                '            End With
                '            dao_f.insert()
                '        End If
                '    Else ' หมายถึง UPDATE
                '        If f.TYPE = "ADD" Then 'หมายถึงมีการแนบไฟล์
                '            Dim dao_f As New DAO.TB_FILE_BOX
                '            dao_f.GETDATA_BY_IDA(IDA)
                '            If HAVE_FILE(f_path) = True Then 'กรณีเจอไฟล์
                '                Dim path_file As String = path & "\" & IDA & ".pdf"
                '                COPY_FILE(f_path, path_file)
                '                With dao_f.fields
                '                    .FILENAME = filename
                '                    .TITEL = f.DES
                '                    .UPDATE_DATE = Date.Now
                '                    .PATH_FILE = path_file
                '                    .REF_TR_ID = f_path
                '                    .PRIORITY = f.PIORITY
                '                End With

                '            Else
                '                With dao_f.fields
                '                    .FILENAME = filename
                '                    .TITEL = f.DES
                '                    .UPDATE_DATE = Date.Now
                '                    .PRIORITY = f.PIORITY
                '                End With
                '            End If
                '            dao_f.update()
                '            i = i + 1
                '        Else
                '            Dim dao_f As New DAO.TB_FILE_BOX
                '            dao_f.GETDATA_BY_IDA(IDA)


                '            If HAVE_FILE(f_path) = True Then 'กรณีเจอไฟล์
                '                Dim path_file As String = path & "\" & dao_f.fields.IDA & ".pdf"
                '                COPY_FILE(f_path, path_file)
                '                With dao_f.fields
                '                    .TITEL = f.DES
                '                    .UPDATE_DATE = Date.Now
                '                    .PRIORITY = f.PIORITY
                '                    .PATH_FILE = path_file
                '                    .REF_TR_ID = f_path
                '                End With
                '            Else
                '                With dao_f.fields
                '                    .TITEL = f.DES
                '                    .UPDATE_DATE = Date.Now
                '                    .PRIORITY = f.PIORITY
                '                End With
                '            End If


                '            dao_f.update()
                '        End If
                '    End If
                'Next
                result = "success"
            Catch ex As Exception
                result = "ERR"
            End Try
            Return result
        End Function
#End Region

#Region "INSERT DATA"
        ''' <summary>
        ''' บันทึกข้อมูลเข้า S_BOX กรณีเป็นนิติบุคคล
        ''' </summary>
        ''' <param name="XML"></param>
        ''' <param name="XML2"></param>
        ''' <returns></returns>
        Function ADD_DATA_INV(ByVal XML As String, ByVal XML2 As String, ByVal TOKEN As String, ByVal CTZNO As String) As JsonResult
            Dim obj = JsonConvert.DeserializeObject(XML)
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_BOX = jss.Deserialize(XML, GetType(MODEL_BOX))
            Dim result As String = ""
            Dim chk As Boolean = True
            Dim TR_ID As String = ""


            'Dim BSN_NAME As String = ""
            'BSN_NAME = GET_BSN_NAME(bb.BNS_IDENTIFY)
            'If BSN_NAME = "" Or BSN_NAME = "  " Then
            '    msg_r.MSG_CODE = "404"
            '    msg_r.MSG_RESULT = "FAILS"
            '    msg_r.DATA_VALUE = "ไม่พบข้อมูลผู้ดำเนินกิจการในระบบของ อย. กรุณาติดต่อเจ้าหน้าที่"

            '    result = "ไม่พบข้อมูลผู้ดำเนินกิจการในระบบของ อย. กรุณาติดต่อเจ้าหน้าที่"


            'End If
            Return Json(msg_r, JsonRequestBehavior.AllowGet)

        End Function
#End Region

#Region "UPDATE_DATA"
        ''' <summary>
        ''' UPDATE STATUS ของงาน
        ''' </summary>
        ''' <param name="TR_ID"></param>
        ''' <param name="STATUS_ID"></param>
        ''' <returns></returns>
        Function UPDATE_DATA(ByVal TR_ID As String, ByVal STATUS_ID As String, ByVal TOKEN As String, ByVal CTZNO As String) As String

            Dim msg_result As String = ""
            Dim bao_drop As New BAO_DROPBOX
            Dim STATUS_NAME As String = ""
            Dim CHK_DOC As Boolean = True
            Dim RCVNO As Integer = 0






            Return msg_result
        End Function










        Function con_year(year) As String
            Dim int_year As Integer = Integer.Parse(year)
            If int_year <= 2500 Then
                int_year += 543
            End If
            Return int_year.ToString()
        End Function
#End Region


    End Class



End Namespace