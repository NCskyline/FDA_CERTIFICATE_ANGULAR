Namespace BAO_STOREPROCUDURE
    Public MustInherit Class SP_CENTER
        ''' <summary>
        ''' ใส่ค่าว่างใน DT
        ''' </summary>
        ''' <param name="dt"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function AddDatatable(ByVal dt As DataTable) As DataTable
            Dim dr As DataRow = dt.NewRow
            For Each c As DataColumn In dt.Columns
                If c.DataType.Name.ToString() = "String" Then
                    dr(c.ColumnName) = ""
                ElseIf c.DataType.Name.ToString() = "Int32" Then
                    dr(c.ColumnName) = 0
                ElseIf c.DataType.Name.ToString() = "DateTime" Then
                    'dr(c.ColumnName) = Nothing 'Date.Now
                    dr(c.ColumnName) = DBNull.Value 'Date.Now
                Else
                    Try
                        dr(c.ColumnName) = Nothing
                    Catch ex As Exception
                        dr(c.ColumnName) = 0
                    End Try


                End If

            Next

            dt.Rows.Add(dr)
            Return dt
        End Function
    End Class

    Public Class DRUG
        Inherits SP_CENTER
        ''' <summary>
        ''' ทะเบียน ยา SP_GET_STRFF_NAMEENG conn1
        ''' </summary>
        ''' <remarks></remarks>
        Public conn As String = System.Configuration.ConfigurationManager.ConnectionStrings("FDA_CFS_CENTERConnectionString").ConnectionString
        Public conn1 As String = System.Configuration.ConfigurationManager.ConnectionStrings("LGT_DRUGConnectionString").ConnectionString

        Public Function SP_GET_STRFF_NAMEENG(ByVal identify As String)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_STRFF_NAMEENG @IDA = '" & identify & "'"
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn1).Tables(0)
            dt.TableName = "SP_GET_STRFF_NAMEENG"
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function
        Public Function SP_GET_LORPOR(ByVal newcode As String)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_LORPOR @newcode = '" & newcode & "'"
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_LORPOR"
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function
        Public Function SP_GET_DRUG_LORPOR_OUTPUT(ByVal TR_ID As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRUG_LORPOR_OUTPUT @TR_ID = '" & TR_ID & "'"
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_DRUG_LORPOR_OUTPUT"
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function

        Public Function SP_GET_DRUG_LORPOR_LOTRELEASE(ByVal REG_NO As String)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRUG_LORPOR_LOTRELEASE @REG_NO = '" & REG_NO & "'"
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_DRUG_LORPOR_LOTRELEASE"
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function

        Public Function SP_GET_NAME_STRFF_APPROVE()
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_NAME_STRFF_APPROVE"
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn1).Tables(0)
            dt.TableName = "SP_GET_NAME_STRFF_APPROVE"
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function

        Public Function SP_GET_DRUG_drrgt(ByVal lcnsid As Integer, ByVal lcnno As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRUG_drrgt @lcnsid=" & lcnsid & ",@lcnno=" & lcnno
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_DRUG_drrgt"
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function
        Public Function SP_GET_DRUG(ByVal lcnsid As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRUG @lcnsid=" & lcnsid
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_DRUG"
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function

        Public Function SP_GET_DRUG_drrgt_IDA(ByVal newcode As String)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRUG_drrgt_IDA @newcode = '" & newcode & "'"
            Dim dt As New DataTable
            Try
                dt = clsds.dsQueryselect(sql, conn).Tables(0)
                dt.TableName = "SP_GET_DRUG_drrgt_IDA"
                If dt.Rows.Count() = 0 Then
                    dt = AddDatatable(dt)
                End If
            Catch ex As Exception
            End Try
            Return dt
        End Function

        Public Function SP_GET_DRUG_CHORVOR_ADDR(ByVal newcode As String)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRUG_CHORVOR_ADDR @newcode = '" & newcode & "'"
            Dim dt As New DataTable
            Try
                dt = clsds.dsQueryselect(sql, conn).Tables(0)
                dt.TableName = "SP_GET_DRUG_CHORVOR_ADDR"
                If dt.Rows.Count() = 0 Then
                    dt = AddDatatable(dt)
                End If
            Catch ex As Exception
            End Try
            Return dt
        End Function



        Public Function SP_GET_DRREXP_DROPDOWN(ByVal rgtno As String, ByVal rgttpcd As String, ByVal lcnno As String)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRREXP_DROPDOWN @rgtno = '" & rgtno & "',@rgttpcd='" & rgttpcd & "',@lcnno='" & lcnno & "'"
            Dim dt As New DataTable
            Try
                dt = clsds.dsQueryselect(sql, conn).Tables(0)
                dt.TableName = "SP_GET_DRREXP_DROPDOWN"
                If dt.Rows.Count() = 0 Then
                    dt = AddDatatable(dt)
                End If
            Catch ex As Exception
            End Try
            Return dt
        End Function

        Public Function SP_GET_FML_EACH_UNIT(ByVal rgtno As String, ByVal rgttpcd As String, ByVal drgtpcd As String, ByVal pvncd As String)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_FML_EACH_UNIT @rgtno = '" & rgtno & "',@rgttpcd='" & rgttpcd & "',@drgtpcd='" & drgtpcd & "',@pvncd = '" & pvncd & "'"
            Dim dt As New DataTable
            Try
                dt = clsds.dsQueryselect(sql, conn).Tables(0)
                dt.TableName = "SP_GET_FML_EACH_UNIT"
                If dt.Rows.Count() = 0 Then
                    dt = AddDatatable(dt)
                End If
            Catch ex As Exception
            End Try
            Return dt
        End Function

        Public Function SP_GET_CER_DRUG(ByVal process_id As Integer, ByVal NEWCODE As String, ByVal name_pro As String, ByVal regnos As String, ByVal status As String, ByVal date_from As String, ByVal date_to As String, ByVal chk_status As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_CER_DRUG @FK_PROCESS_ID =" & process_id & ",@NEWCODE = '" & NEWCODE & "',@NAME_PRODUCT='" & name_pro.Replace("'", "''") & "',@REG_NUMBER='" & regnos & "',@STATUS_ID='" & status & "',@DATE_FROM='" & date_from & "',@DATE_TO='" & date_to & "',@CHK_STATUS=" & chk_status
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_CER_DRUG"
            If dt.Rows.Count() = 0 Then
                'dt = AddDatatable(dt)
            End If
            Return dt
        End Function

        Public Function SP_GET_CER_DRUG_PRODUCT_NAME(ByVal process_id As Integer, ByVal NEWCODE As String, ByVal name_pro As String, ByVal regnos As String, ByVal status As String, ByVal date_from As String, ByVal date_to As String, ByVal chk_status As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_CER_DRUG_PRODUCT_NAME @FK_PROCESS_ID =" & process_id & ",@NEWCODE = '" & NEWCODE & "',@NAME_PRODUCT='" & name_pro & "',@REG_NUMBER='" & regnos & "',@STATUS_ID='" & status & "',@DATE_FROM='" & date_from & "',@DATE_TO='" & date_to & "',@CHK_STATUS=" & chk_status
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_CER_DRUG_PRODUCT_NAME"
            If dt.Rows.Count() = 0 Then
                'dt = AddDatatable(dt)
            End If
            Return dt
        End Function
        Public Function SP_GET_DRUG_LORPOR(ByVal process_id As Integer, ByVal NEWCODE As String, ByVal name_pro As String, ByVal regnos As String, ByVal status As String, ByVal date_from As String, ByVal date_to As String, ByVal chk_status As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRUG_LORPOR @PROCESS_ID =" & process_id & ",@NEWCODE = '" & NEWCODE & "',@NAME_PRODUCT='" & name_pro & "',@REG_NUMBER='" & regnos & "',@STATUS_ID='" & status & "',@DATE_FROM='" & date_from & "',@DATE_TO='" & date_to & "',@CHK_STATUS=" & chk_status
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_DRUG_LORPOR"
            If dt.Rows.Count() = 0 Then
                'dt = AddDatatable(dt)
            End If
            Return dt
        End Function
        Public Function SP_GET_DRUG_IMPORT(ByVal process_id As Integer, ByVal NEWCODE As String, ByVal name_pro As String, ByVal regnos As String, ByVal status As String, ByVal date_from As String, ByVal date_to As String, ByVal chk_status As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRUG_IMPORT @PROCESS_ID =" & process_id & ",@NEWCODE = '" & NEWCODE & "',@NAME_PRODUCT='" & name_pro & "',@REG_NUMBER='" & regnos & "',@STATUS_ID='" & status & "',@DATE_FROM='" & date_from & "',@DATE_TO='" & date_to & "',@CHK_STATUS=" & chk_status
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_DRUG_IMPORT"
            If dt.Rows.Count() = 0 Then
                'dt = AddDatatable(dt)
            End If
            Return dt
        End Function


        ''' <summary>
        ''' ดึงชื่อเจ้าหน้าที่ผู้อนุมัติ
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function SP_GET_DURG_STAFF_NAME()
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DURG_STAFF_NAME"
            Dim dt As New DataTable
            Try
                dt = clsds.dsQueryselect(sql, conn).Tables(0)
                dt.TableName = "SP_GET_DURG_STAFF_NAME"
                If dt.Rows.Count() = 0 Then
                    dt = AddDatatable(dt)
                End If
            Catch ex As Exception
            End Try
            Return dt
        End Function



        ''' <summary>
        ''' ดึงชื่อเจ้าหน้าที่ผู้อนุมัติ
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function SP_GET_DRUG_STAFF_NAME_CITIZEN(ByVal citizen As String)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRUG_STAFF_NAME_CITIZEN @CITIZEN ='" & citizen & "'"
            Dim dt As New DataTable
            Try
                dt = clsds.dsQueryselect(sql, conn).Tables(0)
                dt.TableName = "SP_GET_DRUG_STAFF_NAME_CITIZEN"
                If dt.Rows.Count() = 0 Then
                    dt = AddDatatable(dt)
                End If
            Catch ex As Exception
            End Try
            Return dt
        End Function




        Public Function SP_GET_CER_DRUG_APPROVED(ByVal rcvno As String, ByVal ref_code As String)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_CER_DRUG_APPROVED @rcvno ='" & rcvno & "',@ref_code = '" & ref_code & "'"
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_CER_DRUG_APPROVED"
            'If dt.Rows.Count() = 0 Then
            '    dt = AddDatatable(dt)
            'End If
            Return dt
        End Function

        Public Function SP_GET_CER_DRUG_APPROVED_PROCESS(ByVal process_id As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_CER_DRUG_APPROVED_PROCESS @process =" & process_id
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_CER_DRUG_APPROVED_PROCESS"
            'If dt.Rows.Count() = 0 Then
            '    dt = AddDatatable(dt)
            'End If
            Return dt
        End Function

        Public Function SP_GET_ADDRESS_EDIT(ByVal ida_reg As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_ADDRESS_EDIT @FK_REGISTER_IDA =" & ida_reg
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_ADDRESS_EDIT"
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function

        Public Function SP_GET_CER_DRUG_ALL_RCV(ByVal process_id As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_CER_DRUG_ALL_RCV @FK_PROCESS_ID=" & process_id
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_CER_DRUG_ALL_RCV"
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function

        Public Function SP_GET_ALL_DATE_CER_DRUG_OUTPUT(ByVal ida As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_ALL_DATE_CER_DRUG_OUTPUT @ida=" & ida
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_ALL_DATE_CER_DRUG_OUTPUT"
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function

        Public Function SP_GET_SEARCH_CER_NARCOTIC(ByVal product_name As String, ByVal company_name As String, ByVal year As String, ByVal process_id As String, ByVal year_to As String)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_SEARCH_CER_NARCOTIC @product_name='" & product_name & "',@company_name='" & company_name & "',@year='" & year & "',@process_id='" & process_id & "',@year_to ='" & year_to & "'"
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_SEARCH_CER_NARCOTIC"
            If dt.Rows.Count() = 0 Then
                'dt = AddDatatable(dt)
            End If
            Return dt
        End Function

        Public Function SP_GET_DRUG_LCN(ByVal lcnsid As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRUG_LCN @lcnsid = " & lcnsid
            Dim dt As New DataTable
            Try
                dt = clsds.dsQueryselect(sql, conn).Tables(0)
                dt.TableName = "SP_GET_DRUG_LCN"
            Catch ex As Exception
            End Try
            Return dt
        End Function

        Public Function SP_GET_DRUG_LCN_IDA(ByVal IDA As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRUG_LCN_IDA @IDA = " & IDA
            Dim dt As New DataTable
            Try
                dt = clsds.dsQueryselect(sql, conn).Tables(0)
                dt.TableName = "SP_GET_DRUG_LCN_IDA"
            Catch ex As Exception
            End Try
            Return dt
        End Function
        Public Function SP_GET_DRUG_LCN_IDEN(ByVal iden As String)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRUG_LCN_IDEN @iden ='" & iden & "'"
            Dim dt As New DataTable
            Try
                dt = clsds.dsQueryselect(sql, conn).Tables(0)
                dt.TableName = "SP_GET_DRUG_LCN_IDEN"
            Catch ex As Exception
            End Try
            Return dt
        End Function


        Public Function SP_GET_EQ_TO(ByVal newcode As String)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_EQ_TO @newcode='" & newcode & "'"
            Dim dt As New DataTable
            Try
                dt = clsds.dsQueryselect(sql, conn).Tables(0)

            Catch ex As Exception
            End Try
            dt.TableName = "SP_GET_EQ_TO"
            Return dt
        End Function

        Public Function SP_GET_DRUG_drrgt_search(ByVal lcnsid As Integer, ByVal lcnno As Integer, ByVal name As String, ByVal rgtno As String, ByVal chk_name As Integer, ByVal chk_rgtno As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRUG_drrgt_search @lcnsid=" & lcnsid & ",@lcnno=" & lcnno & ",@name='" & name & "',@rgtno='" & rgtno & "',@chk_name=" & chk_name & ",@chk_rgtno=" & chk_rgtno
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_DRUG_drrgt_search"
            If dt.Rows.Count() = 0 Then
                'dt = AddDatatable(dt)
            End If
            Return dt
        End Function
        Public Function SP_GET_DRUG_drrgt_search_citi(ByVal citizen_authorize As String, ByVal name As String, ByVal rgtno As String, ByVal chk_name As Integer, ByVal chk_rgtno As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRUG_drrgt_search_citi @citizen_autorize='" & citizen_authorize & "'" & ",@name='" & name & "',@rgtno='" & rgtno & "',@chk_name=" & chk_name & ",@chk_rgtno=" & chk_rgtno
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_DRUG_drrgt_search_citi"
            If dt.Rows.Count() = 0 Then
                'dt = AddDatatable(dt)
            End If
            Return dt
        End Function
        Public Function SP_GET_DRUG_drrgt_search_newcode_not(ByVal newcode_not As String, ByVal name As String, ByVal rgtno As String, ByVal chk_name As Integer, ByVal chk_rgtno As Integer)
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_GET_DRUG_drrgt_search_newcode_not @newcode_not='" & newcode_not & "'" & ",@name='" & name & "',@rgtno='" & rgtno & "',@chk_name=" & chk_name & ",@chk_rgtno=" & chk_rgtno
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_GET_DRUG_drrgt_search_newcode_not"
            If dt.Rows.Count() = 0 Then
                'dt = AddDatatable(dt)
            End If
            Return dt
        End Function
    End Class
   


    Public Class CPN
        Inherits SP_CENTER

        Public conn As String = System.Configuration.ConfigurationManager.ConnectionStrings("LGTCPNConnectionString").ConnectionString







        Public Function SP_SYSISOCNT()
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_SYSISOCNT"
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_SYSISOCNT"
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function

        ''' <summary>
        ''' ดึงข้อมูล จังหวัด
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function SP_SP_SYSCHNGWT() As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_SYSCHNGWT"
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_SYSCHNGWT"
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function


        ''' <summary>
        ''' ดึงข้อมูล อำเภอ
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function SP_SP_SYSAMPHR() As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_SYSAMPHR"
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_SYSAMPHR"
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function

        ''' <summary>
        ''' ดึงข้อมูล ตำบล
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function SP_SP_SYSTHMBL() As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_SYSTHMBL"
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            dt.TableName = "SP_SYSTHMBL"
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function

        ''' <summary>
        ''' ดึงข้อมูลจากเลขบัตรประชาชน
        ''' </summary>
        ''' <param name="CTZNO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function SP_MAINPERSON_CTZNO(ByVal CTZNO As String) As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_MAINPERSON_CTZNO @ctzno = '" & CTZNO & "'"
            Dim dt As New DataTable
            Try
                dt = clsds.dsQueryselect(sql, conn).Tables(0)
                dt.TableName = "SP_MAINPERSON_CTZNO"
                If dt.Rows.Count() = 0 Then
                    dt = AddDatatable(dt)
                End If
            Catch ex As Exception

            End Try
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function
        ''' <summary>
        ''' ดึงข้อมูลจากเลขบัตรประชาชน
        ''' </summary>
        ''' <param name="CTZNO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function SP_MAINPERSON_CTZNO_SEARCH(ByVal CTZNO As String) As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_MAINPERSON_CTZNO @ctzno = '" & CTZNO & "'"
            Dim dt As New DataTable
            Try
                dt = clsds.dsQueryselect(sql, conn).Tables(0)
                dt.TableName = "SP_MAINPERSON_CTZNO"
            Catch ex As Exception

            End Try
            Return dt
        End Function

        Public Function SP_MAINCOMPANY_IDENTIFY(ByVal CITIZEN_AUTHORIZE As String) As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_MAINCOMPANY_IDENTIFY @identify = '" & CITIZEN_AUTHORIZE & "'"
            Dim dt As New DataTable
            Try
                dt = clsds.dsQueryselect(sql, conn).Tables(0)
                dt.TableName = "SP_MAINCOMPANY_IDENTIFY"
                If dt.Rows.Count() = 0 Then
                    dt = AddDatatable(dt)
                End If
            Catch ex As Exception

            End Try
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            Return dt
        End Function

        Public Function SP_MEMBER_THANM_THANM_by_thanm_and_IDENTIFY(ByVal THANM As String, ByVal IDENTIFY As String) As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_MEMBER_THANM_THANM_by_thanm_and_IDENTIFY @THANM= '" & THANM & "' ,@IDENTIFY = '" & IDENTIFY & "' "
            Dim dt As New DataTable
            dt = clsds.dsQueryselect(sql, conn).Tables(0)
            Return dt
        End Function



    End Class
    
    

 

End Namespace


