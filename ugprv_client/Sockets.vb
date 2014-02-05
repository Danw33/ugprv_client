Public Class Sockets

    Public Function Configure(ByVal Address As String, ByVal Port As Integer) As Socket
        Return New Socket(Address, Port)
    End Function

    Public Class Socket

        Private _connected As Boolean = False
        Private _address As String = ""
        Private _port As Integer = 0

        Sub New(Address As String, Port As Integer)
            _address = Address
            _port = Port
        End Sub

        Public Function Connect() As Socket
            Me._connected = True
            Return Me
        End Function

        Public Function Disconnect() As Socket
            Me._connected = False
            Return Me
        End Function

        Public Function getStatus() As Boolean
            Return Me._connected
        End Function

        Public Function getAddress() As String
            Return Me._address
        End Function

        Public Function getPort() As Integer
            Return Me._port
        End Function

        Public Function setAddress(Address As String) As Socket
            Me._address = Address
            Return Me
        End Function

        Public Function setPort(Port As Integer) As Socket
            Me._port = Port
            Return Me
        End Function
    End Class

End Class
