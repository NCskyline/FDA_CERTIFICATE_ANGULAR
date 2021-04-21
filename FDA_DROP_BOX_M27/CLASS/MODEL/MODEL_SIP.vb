Public Class MODEL_SIP


    Private _CITIZEN_ID_AUTHROIZE As String
    Public Property CITIZEN_ID_AUTHOIRZE() As String
        Get
            Return _CITIZEN_ID_AUTHROIZE
        End Get
        Set(ByVal value As String)
            _CITIZEN_ID_AUTHROIZE = value
        End Set
    End Property

    Private _TRADER_NAME As String
    Public Property TRADER_NAME() As String
        Get
            Return _TRADER_NAME
        End Get
        Set(ByVal value As String)
            _TRADER_NAME = value
        End Set
    End Property

    Private _TRADER_ADDR As String
    Public Property TRADER_ADDR() As String
        Get
            Return _TRADER_ADDR
        End Get
        Set(ByVal value As String)
            _TRADER_ADDR = value
        End Set
    End Property



    Private _TRADER As Object
    Public Property TRADER() As Object
        Get
            Return _TRADER
        End Get
        Set(ByVal value As Object)
            _TRADER = value
        End Set
    End Property

    Private _LIST_FOOD As Object
    Public Property LIST_FOOD() As Object
        Get
            Return _LIST_FOOD
        End Get
        Set(ByVal value As Object)
            _LIST_FOOD = value
        End Set
    End Property
End Class
