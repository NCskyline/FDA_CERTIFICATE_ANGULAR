Public Class DAO_DRUG
    Public MustInherit Class MAINCONTEXT
        Public db As New LINQ_DRUGDataContext
        Public datas
    End Class

    Public Class TB_TRANSACTION_UPLOAD
        Inherits MAINCONTEXT

        Public fields As New TRANSACTION_UPLOAD

        Public Sub insert()
            db.TRANSACTION_UPLOADs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub

        Public Sub delete()
            db.TRANSACTION_UPLOADs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In db.TRANSACTION_UPLOADs Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_GEN(ByVal YEAR As String, ByVal Process_id As String)
            'datas = (From p In db.GEN_NO_01s Where p.IDA = YEAR Order By p.IDA Descending Select p)
            datas = (From p In db.TRANSACTION_UPLOADs Where p.YEAR = YEAR And p.PROCESS_ID_STR = Process_id Order By CInt(p.GEN_NO) Descending Select p).Take(1)
            For Each Me.fields In datas
            Next
        End Sub
        Public Function Count_GEN_NO(ByVal _YEAR As String, ByVal Process_id As String, ByVal gen_no As Integer) As Integer
            Dim i As Integer = 0
            datas = (From p In db.TRANSACTION_UPLOADs Where p.YEAR = _YEAR And p.PROCESS_ID_STR = Process_id And p.GEN_NO = gen_no Select p)
            For Each Me.fields In datas
                i += 1
            Next
            Return i
        End Function
        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In db.TRANSACTION_UPLOADs Where p.DESCRIPTION = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_TR_ID_Process(ByVal tr_id As String, ByVal process_id As String)

            datas = (From p In db.TRANSACTION_UPLOADs Where p.DESCRIPTION = tr_id And p.PROCESS_ID_STR = process_id Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_MAS_STAFF_OFFER
        Inherits MAINCONTEXT

        Public fields As New MAS_STAFF_OFFER

        Public Sub GetDataby_IDA(ByVal name As String)
            datas = (From p In db.MAS_STAFF_OFFERs Where p.ENG_POSITION_NAME = name Select p)
            For Each Me.fields In datas

            Next
        End Sub


    End Class

    Public Class TB_DALCN_LOCATION_ADDRESS
        Inherits MAINCONTEXT

        Public fields As New DALCN_LOCATION_ADDRESS
        Public Sub GetDataby_IDA(ByVal ida As Integer)
            datas = (From p In db.DALCN_LOCATION_ADDRESSes Where p.IDA = ida Select p)
            For Each Me.fields In datas

            Next
        End Sub
    End Class
    Public Class TB_DALCN_LOCATION_BSN
        Inherits MAINCONTEXT

        Public fields As New DALCN_LOCATION_BSN
        Public Sub GetDataby_IDA(ByVal ida As Integer)
            datas = (From p In db.DALCN_LOCATION_BSNs Where p.LCN_IDA = ida Select p)
            For Each Me.fields In datas

            Next
        End Sub
    End Class
    Public Class TB_DALCN
        Inherits MAINCONTEXT

        Public fields As New dalcn
        Public Sub GetDataby_IDA(ByVal ida As Integer)
            datas = (From p In db.dalcns Where p.IDA = ida Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_IDEN(ByVal IDEN As String)
            datas = (From p In db.dalcns Where p.CITIZEN_ID_AUTHORIZE = IDEN Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_IDEN_LCNNO(ByVal IDEN As String, ByVal LCNNO As Integer)
            datas = (From p In db.dalcns Where p.CITIZEN_ID_AUTHORIZE = IDEN And p.lcnno = LCNNO Select p)
            For Each Me.fields In datas

            Next
        End Sub
    End Class
    Public Class TB_drrqt
        Inherits MAINCONTEXT
        Public fields As New drrqt
        Public Sub Getdataby_name(ByVal rgtno As String, ByVal rgttpcd As String, ByVal product_name As String)
            datas = (From p In db.drrqts Where p.rgtno = rgtno And p.rgttpcd = rgttpcd And p.engdrgnm = product_name Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub insert()
            db.drrqts.InsertOnSubmit(fields)
            db.SubmitChanges()

        End Sub

    End Class
End Class
