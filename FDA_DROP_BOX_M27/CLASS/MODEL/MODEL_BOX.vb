Public Class MODEL_BOX



    Public TR_ID As String
    Public CUSTOMER_CTZNO As String
    Public CUSTOMER_IDENTIFY As String
    Public STATUS As String
    Public ORG As String
    Public PROCESS_ID As String
    Public PROCESS_NAME As String
    Public STAFF_CTZNO As String
    Public DES As String
    Public STATUS_NAME As String
    Public DATEs As String
    Public COMPANY_NAME As String
    Public STAFF_NAME As String
    Public PRODUCT_NAME As String
    Public LINK_MANUAL As String

    Public CUSTOMER_NAME As String
    Public CUSTOMER_TEL As String
    Public CUSTOMER_EMAIL As String

    Public INV_NO As String
    Public INV_DATE As String

    Public CUSTOMER_OTHER As String
    Public REMARK As String

    Public BNS_IDENTIFY As String
    Public RCVNO As String
    Public RCVDATE As String
    Public OUT_AT As String
    Public WRITE_AT As String
    Public LPI As String

    Public REF_LCN As String


    Public LOCATION_ADDR As String
    Public LCN_TYPE As String
    Public LOCATION_NAME As String


End Class



Public Class MODEL_FILELIST
    Private _FILE_LISTs As New List(Of FILE_LIST)
    Public Property FILE_LISTs() As List(Of FILE_LIST)
        Get
            Return _FILE_LISTs
        End Get
        Set(ByVal value As List(Of FILE_LIST))
            _FILE_LISTs = value
        End Set
    End Property
End Class
Public Class FILE_LIST
    Public TR_ID As String
    Public DES As String
    Public FILENAME As String
    Public FILE_DATA As String
    Public IDA As String
    Public PATH_FILE As String
    Public PIORITY As String
    Public TYPE As String
    Public PATH As String
    Public FLAG As String
    Public PROCESS_NAME As String
End Class