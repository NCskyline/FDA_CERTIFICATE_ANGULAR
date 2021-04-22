Namespace DAO.CFS

    Public MustInherit Class MAINCONTEXT
        Public db As New LINQ_CERDataContext
        Public datas
    End Class


    Public Class TB_PROCESS
        Inherits MAINCONTEXT

        Public fields As New MAS_PROCESS

        Public Sub GetDataby_PROCESS_ID(ByVal PROCESS_ID As String)
            datas = (From p In db.MAS_PROCESSes Where p.PROCESS_ID = PROCESS_ID Select p)
            For Each Me.fields In datas

            Next
        End Sub
    End Class

    
    
    Public Class TB_MAS_TEMPLATE_PROCESS
        Inherits MAINCONTEXT

        Public fields As New MAS_TEMPLATE_PROCESS

        Public Sub GetDATAby_PROCESS_ID(ByVal PROCESS_ID As String, ByVal STATUS_ID As Integer, ByVal PREVIEW As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = PROCESS_ID And p.STATUS_ID = STATUS_ID And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
       

    End Class
    Public Class TB_FILE_ATTACH
        Inherits MAINCONTEXT

        Public fields As New FILE_ATTACH

        Public Sub GetDATAby_IDA(ByVal IDA As Integer)
            datas = (From p In db.FILE_ATTACHes Where p.IDA = IDA Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDATAby_TR_ID(ByVal TR_ID As Integer, ByVal type As Integer)
            datas = (From p In db.FILE_ATTACHes Where p.TR_ID = TR_ID And p.TYPE = type Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub insert()
            db.FILE_ATTACHes.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
    End Class

    Public Class Table_GEN_RCV_NUMBER
        Inherits MAINCONTEXT
        Public fields As New GEN_RCV_NUMBER


        Public Sub insert()
            db.GEN_RCV_NUMBERs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
        Public Sub delete()
            db.GEN_RCV_NUMBERs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetDataAll()
            datas = (From p In db.GEN_RCV_NUMBERs Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_IDA(ByVal IDA As Integer)
            datas = (From p In db.GEN_RCV_NUMBERs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_REF_IDA(ByVal REF_IDA As Integer)
            datas = (From p In db.GEN_RCV_NUMBERs Where p.IDA = REF_IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_Number_last(ByVal group As Integer)
            datas = (From p In db.GEN_RCV_NUMBERs Where p.GROUP_NO = group And p.GENNO IsNot Nothing Order By p.IDA Descending Select p).Take(1)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_GEN(ByVal YEAR As String, ByVal PVCODE As String, ByVal TYPE As String, ByVal LCNNO As String, _
                        ByVal FORMAT As String, ByVal GROUP_NO As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String)
            datas = (From p In db.GEN_RCV_NUMBERs Where p.YEAR = YEAR And p.GROUP_NO = GROUP_NO Order By p.GENNO Descending Select p).Take(1)
            For Each Me.fields In datas
            Next
        End Sub

        ''' <summary>
        ''' ดึงข้อมูลเลข Gen ตาม ปี จังหวัด
        ''' </summary>
        ''' <param name="YEAR"></param>
        ''' <param name="PVCODE"></param>
        ''' <param name="GROUP_NO"></param>
        ''' <remarks></remarks>
        Public Sub GetDataby_GEN_YEAR_PVCODE(ByVal YEAR As String, ByVal PVCODE As String, ByVal GROUP_NO As String)
            datas = (From p In db.GEN_RCV_NUMBERs Where p.YEAR = YEAR And p.PVCODE = PVCODE And p.GROUP_NO = GROUP_NO Order By p.GENNO Descending Select p).Take(1)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    
    
    Public Class TB_TEMPLATE_ATTACH
        Inherits MAINCONTEXT
        Public fieldes As New TEMPLATE_ATTACH
        Public Sub GetDataby_processID(ByVal PROCESS_ID As Integer)
            datas = (From p In db.TEMPLATE_ATTACHes Where p.LCNTPCD = PROCESS_ID Select p)
            For Each Me.fieldes In datas
                'AddDetails()
            Next
        End Sub
        Private Sub AddDetails()
            Details.Add(fieldes)
            fieldes = New TEMPLATE_ATTACH
        End Sub
        Private _Details As New List(Of TEMPLATE_ATTACH)
        Public Property Details() As List(Of TEMPLATE_ATTACH)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of TEMPLATE_ATTACH))
                _Details = value
            End Set
        End Property
    End Class
    Public Class TB_CER_DURG_HEAD
        Inherits MAINCONTEXT

        Public fields As New CER_DRUG_HEAD

        Public Sub GetDataAll()
            datas = (From p In db.CER_DRUG_HEADs Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_IDA(ByVal IDA As Integer)
            datas = (From p In db.CER_DRUG_HEADs Where p.IDA = IDA Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_rcvno_last_type(ByVal process_id As Integer)
            Dim chk = Year(Date.Now)
            If chk < 2500 Then
                chk += 543
            End If
            Dim chk2 = Right(chk, 2) & "00000"
            datas = (From p In db.CER_DRUG_HEADs Where p.FK_PROCESS_ID = process_id And p.STATUS_ID >= 6 And Not p.REF_CODE Is Nothing And p.RCVNO > chk2 Order By p.REF_CODE.Substring(14, 18) Descending Select p).Take(1)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_rcvno()
            Dim chk = Year(Date.Now)
            If chk < 2500 Then
                chk += 543
            End If
            Dim chk2 = Right(chk, 2) & "00000"
            datas = (From p In db.CER_DRUG_HEADs Where p.STATUS_ID >= 6 And Not p.RCVNO Is Nothing And p.RCVNO > chk2 Order By p.RCVNO Descending Select p).Take(1)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_XML(ByVal XML As String)
            datas = (From p In db.CER_DRUG_HEADs Where p.XML_NAME = XML Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub insert()
            db.CER_DRUG_HEADs.InsertOnSubmit(fields)
            db.SubmitChanges()

        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
    End Class
    Public Class TB_CER_DRUG_LORPOR
        Inherits MAINCONTEXT

        Public fields As New CER_DRUG_LORPOR
        Public Sub GetDataby_IDA(ByVal IDA As Integer)
            datas = (From p In db.CER_DRUG_LORPORs Where p.IDA = IDA Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_rcvno_last_type(ByVal process_id As Integer)
            datas = (From p In db.CER_DRUG_LORPORs Where p.PROCESS_ID = process_id And p.STATUS_ID = 6 And Not p.REF_CODE Is Nothing Order By p.REF_CODE.Substring(14, 18) Descending Select p).Take(1)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_XML(ByVal XML As String)
            datas = (From p In db.CER_DRUG_LORPORs Where p.XML_NAME = XML Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub insert()
            db.CER_DRUG_LORPORs.InsertOnSubmit(fields)
            db.SubmitChanges()

        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
    End Class
    Public Class TB_CER_DRUG_IMPORT
        Inherits MAINCONTEXT

        Public fields As New CER_DRUG_IMPORT
        Public Sub GetDataby_IDA(ByVal IDA As Integer)
            datas = (From p In db.CER_DRUG_IMPORTs Where p.IDA = IDA Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_rcvno_last_type(ByVal process_id As Integer)
            datas = (From p In db.CER_DRUG_IMPORTs Where p.PROCESS_ID = process_id And p.STATUS_ID = 8 And Not p.REF_CODE Is Nothing Order By p.REF_CODE.Substring(14, 18) Descending Select p).Take(1)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_XML(ByVal XML As String)
            datas = (From p In db.CER_DRUG_IMPORTs Where p.XML_NAME = XML Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub insert()
            db.CER_DRUG_IMPORTs.InsertOnSubmit(fields)
            db.SubmitChanges()

        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
    End Class

    Public Class TB_CER_DURG_COUNTRY
        Inherits MAINCONTEXT

        Public fields As New CER_DRUG_COUNTRY
        Public Sub GetDataby_IDA(ByVal IDA As Integer)
            datas = (From p In db.CER_DRUG_COUNTRies Where p.IDA = IDA Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub insert()
            db.CER_DRUG_COUNTRies.InsertOnSubmit(fields)
            db.SubmitChanges()

        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
    End Class

    Public Class TB_CER_DRUG_GENNO_MAX
        Inherits MAINCONTEXT

        Public fields As New CER_DRUG_GENNO_MAX
        Public Sub insert()
            db.CER_DRUG_GENNO_MAXes.InsertOnSubmit(fields)
            db.SubmitChanges()

        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
    End Class

    Public Class TB_CER_DURG_EDIT_ADDRESS
        Inherits MAINCONTEXT

        Public fields As New CER_DRUG_EDIT_ADDRESS
        Public Sub GetDataby_IDA(ByVal IDA As Integer)
            datas = (From p In db.CER_DRUG_EDIT_ADDRESSes Where p.IDA = IDA Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_Check(ByVal CITIZEN_AUTHORIZE As String)
            datas = (From p In db.CER_DRUG_EDIT_ADDRESSes Where p.FK_REGISTER_IDA = CITIZEN_AUTHORIZE Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_Checklcn(ByVal CITIZEN_AUTHORIZE As String, ByVal LCNNO As Integer)
            datas = (From p In db.CER_DRUG_EDIT_ADDRESSes Where p.FK_REGISTER_IDA = CITIZEN_AUTHORIZE And p.LCNNO = LCNNO Select p)
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub insert()
            db.CER_DRUG_EDIT_ADDRESSes.InsertOnSubmit(fields)
            db.SubmitChanges()

        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
    End Class
    Public Class TB_CER_DRUG_NAME_EXPORT
        Inherits MAINCONTEXT

        Public fields As New CER_DRUG_NAME_EXPORT

        Public Sub GetDataby_IDA(ByVal rgtno As String, ByVal rgttpcd As String)
            datas = (From p In db.CER_DRUG_NAME_EXPORTs Where p.rgtno = rgtno And p.rgttpcd = rgttpcd Select p)
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetDataby_CHECK_EXP(ByVal rgtno As String, ByVal rgttpcd As String, ByVal rcvno As String, ByVal drgexp As String, ByVal cntcd As String)
            datas = (From p In db.CER_DRUG_NAME_EXPORTs Where p.rgtno = rgtno And p.rgttpcd = rgttpcd And p.rcvno = rcvno And p.drgexp = drgexp And p.cntcd = cntcd Select p)
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetDataby_CHECK_EXP_alpha(ByVal rgtno As String, ByVal rgttpcd As String, ByVal rcvno As String, ByVal drgexp As String)
            datas = (From p In db.CER_DRUG_NAME_EXPORTs Where p.rgtno = rgtno And p.rgttpcd = rgttpcd And p.rcvno = rcvno And p.drgexp = drgexp Order By p.rid Descending Select p).Take(1)
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetDataby_CHECK_EXP_alpha_rcvno(ByVal rgtno As String, ByVal rgttpcd As String, ByVal drgexp As String)
            datas = (From p In db.CER_DRUG_NAME_EXPORTs Where p.rgtno = rgtno And p.rgttpcd = rgttpcd And p.drgexp = drgexp Select p)
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub insert()
            db.CER_DRUG_NAME_EXPORTs.InsertOnSubmit(fields)
            db.SubmitChanges()

        End Sub

    End Class
End Namespace


