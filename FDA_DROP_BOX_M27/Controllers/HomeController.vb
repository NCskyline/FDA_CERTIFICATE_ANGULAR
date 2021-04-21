Public Class HomeController
    Inherits System.Web.Mvc.Controller

    'Function Index() As ActionResult
    '    'Dim BSN_NAME As String = ""
    '    'BSN_NAME = GET_BSN_NAME("121232121")
    '    Return View()
    'End Function




    Function OPEN_DOC(ByVal IDA As Integer) As ActionResult
        Dim clsds As New ClassDataset
        ''Dim dao_f As New DAO.TB_FILE_BOX
        'dao_f.GETDATA_BY_IDA(IDA)
        'Dim PATH_FILE As String = dao_f.fields.PATH_FILE
        'Dim b_o As Byte() = clsds.UpLoadImageByte(PATH_FILE)
        Response.Buffer = True
        Response.ClearContent()
        Response.ContentType = "application/pdf"
        Response.AddHeader(“content-disposition”, "inline; filename=" + "output.pdf")
        ''Response.BinaryWrite(b_o)
        Response.End()

        Return View()
    End Function


    Function OPEN_DOC_PATH(ByVal PATH As String) As ActionResult
        Dim clsds As New ClassDataset
        Dim b_o As Byte() = clsds.UpLoadImageByte(PATH)
        Response.Buffer = True
        Response.ClearContent()
        Response.ContentType = "application/pdf"
        Response.AddHeader(“content-disposition”, "inline; filename=" + "output.pdf")
        Response.BinaryWrite(b_o)
        Response.End()

        Return View()
    End Function



End Class
