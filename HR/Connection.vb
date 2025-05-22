Public Module Connection
    Private _serverName As String

    ' Property to get or set the server name
    Public Property ServerName As String
        Get
            Return _serverName
        End Get
        Set(value As String)
            _serverName = value
        End Set
    End Property
End Module
