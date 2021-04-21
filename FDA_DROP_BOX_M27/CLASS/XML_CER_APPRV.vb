Imports FDA_SIP_CER.FDA_SIP_CER

Public Class XML_CER_APPRV



    Private _CER_LIST As New CER_SIP
    Public Property CER_LIST() As CER_SIP
        Get
            Return _CER_LIST
        End Get
        Set(ByVal value As CER_SIP)
            _CER_LIST = value
        End Set
    End Property



End Class

