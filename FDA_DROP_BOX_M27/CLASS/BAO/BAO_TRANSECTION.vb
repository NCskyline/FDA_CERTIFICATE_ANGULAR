Imports FDA_SIP_SPECIFIC.DAO
Namespace TRANSECTION

    ''' <summary>
    ''' ใช้สำหรับ บันทึกเลข TRANSECTION
    ''' </summary>
    ''' <remarks></remarks>
    Public Class TRANSECTION_UPLOAD

        Private _CITIZEN_ID As String
        Public Property CITIZEN_ID() As String
            Get
                Return _CITIZEN_ID
            End Get
            Set(ByVal value As String)
                _CITIZEN_ID = value
            End Set
        End Property

        Private _CITIZEN_ID_AUTHORIZE As String
        Public Property CITIZEN_ID_AUTHORIZE() As String
            Get
                Return _CITIZEN_ID_AUTHORIZE
            End Get
            Set(ByVal value As String)
                _CITIZEN_ID_AUTHORIZE = value
            End Set
        End Property

        Public Function insert_transection_new(ByVal processid As String) As Integer            'สร้างเลขดำเนินการ
            Dim _year As Integer
            _year = con_year(Date.Now.Year)


            'Dim byearMax As Integer = con_year(Date.Now.Year) 'Year(System.DateTime.Now)
            'If byearMax < 2500 Then
            '    byearMax = byearMax + 543
            'End If
            'Dim aa As Date = CDate("1/10/" & Year(System.DateTime.Now))
            'If CDate(System.DateTime.Now) >= CDate("1/10/" & Year(System.DateTime.Now)) Then

            '    byearMax = byearMax + 1
            'End If
            'Dim curent_year As Integer = byearMax





            Dim gen_no As Integer = 0
            gen_no = Get_NO(processid)
            Dim i As Integer = 0
            Dim dao_up As New DAO_DRUG.TB_TRANSACTION_UPLOAD
            i = dao_up.Count_GEN_NO(_year, processid, gen_no)
            Dim str_no As String = gen_no.ToString()
            If i > 0 Then
                gen_no = Get_NO(processid)


                str_no = String.Format("{0:0000000}", gen_no.ToString("0000000"))
                str_no = _year.ToString.Substring(2, 2) & str_no

                dao_up = New DAO_DRUG.TB_TRANSACTION_UPLOAD
                dao_up.fields.CITIEZEN_ID = _CITIZEN_ID
                dao_up.fields.CITIEZEN_ID_AUTHORIZE = _CITIZEN_ID_AUTHORIZE
                dao_up.fields.PROCESS_ID_STR = processid
                Try
                    dao_up.fields.PROCESS_ID = processid
                Catch ex As Exception

                End Try
                dao_up.fields.GEN_NO = gen_no
                dao_up.fields.DESCRIPTION = str_no
                dao_up.fields.STATUS = 1
                dao_up.fields.UPLOAD_DATE = Date.Now()
                dao_up.fields.YEAR = _year 'con_year(Date.Now().Year())
                dao_up.insert() 'ปรับเป็น
            Else

                'Dim str_no As String = gen_no.ToString()
                str_no = String.Format("{0:0000000}", gen_no.ToString("0000000"))
                str_no = _year.ToString.Substring(2, 2) & str_no

                dao_up = New DAO_DRUG.TB_TRANSACTION_UPLOAD
                dao_up.fields.CITIEZEN_ID = _CITIZEN_ID
                dao_up.fields.CITIEZEN_ID_AUTHORIZE = _CITIZEN_ID_AUTHORIZE
                dao_up.fields.PROCESS_ID_STR = processid
                Try
                    dao_up.fields.PROCESS_ID = processid
                Catch ex As Exception

                End Try
                dao_up.fields.DESCRIPTION = str_no
                dao_up.fields.STATUS = 1
                dao_up.fields.GEN_NO = gen_no
                dao_up.fields.UPLOAD_DATE = Date.Now()
                dao_up.fields.YEAR = _year 'con_year(Date.Now().Year())
                dao_up.insert() 'ปรับเป็น
            End If

            Return str_no

        End Function

        Function con_year(year) As String
            Dim int_year As Integer = Integer.Parse(year)
            If int_year <= 2500 Then
                int_year += 543
            End If
            Return int_year.ToString()
        End Function

        Public Function Get_NO(ByVal _process_id) As Integer
            Dim int_no As Integer
            Dim _year As Integer
            _year = con_year(Date.Now.Year)
            Dim dao As New DAO_DRUG.TB_TRANSACTION_UPLOAD
            dao.GetDataby_GEN(_year, _process_id)
            If IsNothing(dao.fields.GEN_NO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GEN_NO
            End If

            Return int_no + 1
        End Function

        Public Function insert_transection(ByVal processid As Integer) As Integer

            Dim dao_up As New DAO_DRUG.TB_TRANSACTION_UPLOAD
            dao_up.fields.CITIEZEN_ID = _CITIZEN_ID
            dao_up.fields.CITIEZEN_ID_AUTHORIZE = _CITIZEN_ID_AUTHORIZE
            dao_up.fields.PROCESS_ID = processid
            dao_up.fields.STATUS = 1
            dao_up.fields.UPLOAD_DATE = Date.Now()
            dao_up.fields.YEAR = Date.Now.Year
            dao_up.insert() 'ปรับเป็น update
            Return dao_up.fields.ID

        End Function
    End Class


    ''' <summary>
    ''' ใช้สำหรับ บันทึกเลข DOWNLOAD_TRANSECTION
    ''' </summary>
    ''' <remarks></remarks>
    Public Class TRANSECTION_DOWNLOAD

        Private _CITIZEN_ID As String
        Public Property CITIZEN_ID() As String
            Get
                Return _CITIZEN_ID
            End Get
            Set(ByVal value As String)
                _CITIZEN_ID = value
            End Set
        End Property

        Private _CITIZEN_ID_AUTHORIZE As String
        Public Property CITIZEN_ID_AUTHORIZE() As String
            Get
                Return _CITIZEN_ID_AUTHORIZE
            End Get
            Set(ByVal value As String)
                _CITIZEN_ID_AUTHORIZE = value
            End Set
        End Property



        'Public Function insert_transection(ByVal processid As Integer) As Integer

        '    Dim dao_down As New DAO.CPN.TB_TRANSECTION_DOWNLOAD
        '    dao_down.fields.PROCESS_ID = processid
        '    dao_down.fields.CITIEZEN_ID = _CITIZEN_ID
        '    dao_down.fields.CITIEZEN_ID_AUTHORIZE = _CITIZEN_ID_AUTHORIZE
        '    dao_down.fields.STATUS = 0
        '    dao_down.fields.DOWNLOAD_DATE = Date.Now()
        '    dao_down.insert()

        '    Return dao_down.fields.ID
        'End Function
    End Class

End Namespace