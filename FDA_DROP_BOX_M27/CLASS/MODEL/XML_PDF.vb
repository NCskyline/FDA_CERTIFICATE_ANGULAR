Public Class XML_PDF

    'Public XML_INFO As New S_BOX

    'Public XML_ITEM As New List(Of INV_ITEM)

    'Public XML_ITEM_OUT As New List(Of INV_ITEM)
    'Public XML_INFO_BASE As New DATA_INFO
End Class


Public Class DATA_INFO
    Private _RCV_DATE_DISPLAY As String
    Public Property RCV_DATE_DISPLAY() As String
        Get
            Return _RCV_DATE_DISPLAY
        End Get
        Set(ByVal value As String)
            _RCV_DATE_DISPLAY = value
        End Set
    End Property

    Private _APP_DATE_DISPLAY As String
    Public Property APP_DATE_DISPLAY() As String
        Get
            Return _APP_DATE_DISPLAY
        End Get
        Set(ByVal value As String)
            _APP_DATE_DISPLAY = value
        End Set
    End Property

    Private _PERSON_TYPE As String
    Public Property PERSON_TYPE() As String
        Get
            Return _PERSON_TYPE
        End Get
        Set(ByVal value As String)
            _PERSON_TYPE = value
        End Set
    End Property

    Private _MU27_CHK As String
    Public Property MU27_CHK() As String
        Get
            Return _MU27_CHK
        End Get
        Set(ByVal value As String)
            _MU27_CHK = value
        End Set
    End Property

    Private _LCN_TYPE_CHK As String
    Public Property LCN_TYPE_CHK() As String
        Get
            Return _LCN_TYPE_CHK
        End Get
        Set(ByVal value As String)
            _LCN_TYPE_CHK = value
        End Set
    End Property

    Private _M_TYPE As String
    Public Property M_TYPE() As String
        Get
            Return _M_TYPE
        End Get
        Set(ByVal value As String)
            _M_TYPE = value
        End Set
    End Property
End Class
