Imports System.Data.SqlClient

Public Class BAO
    Private _conn As String = System.Configuration.ConfigurationManager.ConnectionStrings("FDA_MDC27ConnectionString").ConnectionString
    Private _con_CPN As String = System.Configuration.ConfigurationManager.ConnectionStrings("LGTCPNConnectionString").ConnectionString
    Private _conn_CPN As String = System.Configuration.ConfigurationManager.ConnectionStrings("LGTPERMISSIONConnectionString").ConnectionString
    Private _conn_CFS As String = System.Configuration.ConfigurationManager.ConnectionStrings("FDA_CFS_CENTERConnectionString").ConnectionString



    Public Function SP_GET_DRUG_PRODUCT_ESUB(ByVal register As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_DRUG_PRODUCT_ESUB @register= '" & register & "'"
        Dim dta As New DataTable
        Try
            dta = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dta
    End Function
    Public Function SP_SYSISOCNT() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_SYSISOCNT"
        Dim dta As New DataTable
        dta = clsds.dsQueryselect(sql, _con_CPN).Tables(0)
        Return dta
    End Function

    Public Function SP_SIP_UNIT() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_SIP_UNIT"
        Dim dta As New DataTable
        dta = clsds.dsQueryselect(sql, _conn).Tables(0)
        Return dta
    End Function

    Public Function SP_GET_DRDOSAGE() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_DRDOSAGE"
        Dim dta As New DataTable
        dta = clsds.dsQueryselect(sql, _conn).Tables(0)
        Return dta
    End Function

    Public Function SP_GET_LOCATION_ADDR(ByVal NITI_IDENTIFY As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_LOCATION_ADDR @IDENTIFY= '" & NITI_IDENTIFY & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception
            '           	@CTZNO as nvarchar(255),
            '@NITI_CTZNO as nvarchar(255),
            '@SYSTEM_ID as nvarchar(255)
        End Try
        Return dts
    End Function
    Public Function SP_LOCATION_MDC(ByVal NITI_IDENTIFY As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_LOCATION_MDC @IDENTIFY= '" & NITI_IDENTIFY & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception
            '           	@CTZNO as nvarchar(255),
            '@NITI_CTZNO as nvarchar(255),
            '@SYSTEM_ID as nvarchar(255)
        End Try
        Return dts
    End Function





    Public Function SP_CHECK_PERMISSON_SYSTEM(ByVal CTZNO As String, ByVal NITI_IDENTIFY As String, ByVal systemid As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_CHECK_PERMISSON_SYSTEM @CTZNO= '" & CTZNO & "',@NITI_CTZNO ='" & NITI_IDENTIFY & "',@SYSTEM_ID='" & systemid & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn_CPN).Tables(0)
        Catch ex As Exception
            '           	@CTZNO as nvarchar(255),
            '@NITI_CTZNO as nvarchar(255),
            '@SYSTEM_ID as nvarchar(255)
        End Try
        Return dts
    End Function




    Public Function SP_GET_FILE_BOX(ByVal TR_ID As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_FILE_BOX @TR_ID ='" & TR_ID & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

    Public Function SP_GET_SHARE_BOX(ByVal TR_ID As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_SHARE_BOX @TR_ID ='" & TR_ID & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

    Public Function SP_GET_PRODUCT_TYPE(ByVal PRODUCT_GROUP As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_PRODUCT_TYPE @PRODUCT_GROUP = N'" & PRODUCT_GROUP & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

    Public Function SP_GET_INV_HISTORY(ByVal CTZNO As String)
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_INV_HISTORY @CTZNO ='" & CTZNO & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function
    Public Function SP_GET_PROCESS(ByVal ORG As String, ByVal PROCESS_TYPE As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_PROCESS @PROCESS_ORG ='" & ORG & "',@PROCESS_TYPE=N'" & PROCESS_TYPE & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function



    Public Function SP_GET_ISO() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_ISO"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

    Public Function SP_GET_BOX_CTZNO(ByVal CTZNO As String, ByVal REF_LCN As String, ByVal LCN_TYPE As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_BOX_CTZNO @CTZNO ='" & CTZNO & "',@REF_LCN='" & REF_LCN & "',@LCN_TYPE=N'" & LCN_TYPE & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function



    Public Function SP_GET_BOX_STAFF_STATUS(ByVal ORG As String, ByVal STATUS As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_BOX_STAFF_STATUS @ORG='" & ORG & "',@STATUS='" & STATUS & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

    Public Function SP_GET_BOX_STAFF(ByVal ORG As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_BOX_STAFF @ORG='" & ORG & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

    Public Function SP_GET_BOX_APPROVE(ByVal TR_ID As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_BOX_APPROVE @TR_ID='" & TR_ID & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

#Region "CER CPP"
    Public Function SP_GET_CER_DRUG_APPROVED(ByVal rcvno As String, ByVal ref_code As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_CER_DRUG_APPROVED @rcvno ='" & rcvno & "',@ref_code = '" & ref_code & "'"
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _conn_CFS).Tables(0)

        Return dt
    End Function

    Public Function SP_GET_CER_DRUG_ALL_RCV(ByVal process_id As Integer)
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_CER_DRUG_ALL_RCV @FK_PROCESS_ID=" & process_id
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _conn_CFS).Tables(0)

        Return dt
    End Function

    Public Function SP_GET_CER_DRUG_APPROVED_PROCESS(ByVal process_id As Integer)
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_CER_DRUG_APPROVED_PROCESS @process =" & process_id
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _conn_CFS).Tables(0)

        Return dt
    End Function

    Public Function SP_GET_DRUG_LCN_IDEN(ByVal iden As String)
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_DRUG_LCN_IDEN @iden ='" & iden & "'"
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _conn_CFS).Tables(0)

        Return dt
    End Function
#End Region

    'Public Function SP_GEN_NO(ByVal PROCESS_ID As Integer, ByVal IDA As Integer)
    '    Dim GEN_NO As Integer
    '    Dim dao As New DAO.TB_GEN_NO
    '    dao.GETDATABY_GEN_NO_MAX(PROCESS_ID)
    '    If IsNothing(dao.fields.GEN_NO) = True Then
    '        GEN_NO = 0
    '     
    '    Else
    '        GEN_NO = dao.fields.GEN_NO
    '    End If
    '    GEN_NO = GEN_NO + 1

    '    dao = New DAO.TB_GEN_NO
    '    With dao.fields
    '        .GEN_NO = GEN_NO
    '        .PROCESS_ID = PROCESS_ID
    '        .FK_BOX_IDA = IDA
    '    End With
    '    dao.insert()

    '    Return GEN_NO
    'End Function

End Class
