Imports System.Web.Mvc

Namespace Controllers
    Public Class LCNController
        Inherits Controller

        ' GET: LCN
        Function Index() As ActionResult
            Return View()
        End Function
        Function FRM_SELECT_LCN() As ActionResult
            Return View()
        End Function
    End Class
End Namespace