Namespace BAO_GEN
    Public Class GenNumber


      

        ' ''' <summary>
        ' ''' แปลงเลข yyxxxxx เป็น xxxxx/25yy
        ' ''' </summary>
        ' ''' <param name="str_no"></param>
        ' ''' <returns></returns>
        ' ''' <remarks></remarks>
        'Function Convert_no(ByVal str_no As String)
        '    If String.IsNullOrEmpty(str_no) = False Then
        '        Dim str_year As String = str_no.Trim().Substring(0, 2)
        '        Dim str_num As String = str_no.Trim().Substring(2, 5)
        '        Dim int_num As Integer = Integer.Parse(str_num)
        '        'str_num = String.Format("{0:00000}", int_num.ToString("00000"))
        '        str_num = int_num.ToString()
        '        str_no = str_num + "/25" + str_year
        '    End If

        '    Return str_no
        'End Function


        ''' <summary>
        ''' ออกเลขรับ โดยใช้แค่ ปี กับ จังหวัด
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GEN_RCVNO(ByVal REF_IDA As Integer, ByVal PVCODE As String, ByVal GROUP_ID As Integer) As String
            Dim Years As String = Date.Now.Year + 543
            Dim dao_gen As New DAO.CFS.Table_GEN_RCV_NUMBER
            dao_gen.GetDataby_GEN_YEAR_PVCODE(Years, PVCODE, GROUP_ID)

            Dim running As Integer = 0
            Try
                running = dao_gen.fields.GENNO
            Catch ex As Exception

            End Try

            running = running + 1

            dao_gen = New DAO.CFS.Table_GEN_RCV_NUMBER
            dao_gen.fields.REF_IDA = REF_IDA
            dao_gen.fields.DESCRIPTION = "เลขรับ สถานที่"
            dao_gen.fields.FORMAT = "1"
            dao_gen.fields.GENNO = running
            dao_gen.fields.GROUP_NO = GROUP_ID
            dao_gen.fields.LCNNO = ""
            dao_gen.fields.PVCODE = PVCODE
            dao_gen.fields.TYPE = "1"
            dao_gen.fields.YEAR = Years
            dao_gen.insert()

            Dim rcvno As String = "0"
            Dim str_no As String = running.ToString()
            str_no = String.Format("{0:00000}", running.ToString("00000"))
            str_no = Years.Substring(2, 2) & str_no
            Return str_no

        End Function


    End Class

End Namespace
