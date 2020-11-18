Public Class Professor
    Inherits Pessoa
    Private titulo As String
    Sub Professor(ByVal cpf As String, ByVal nome As String, ByVal titulo As String)
        Me.pcpf = cpf
        Me.pnome = nome
        Me.titulo = titulo
    End Sub
    Property ptitulo() As String
        Get
            Return titulo
        End Get
        Set(ByVal valor As String)
            Me.titulo = valor
        End Set
    End Property
End Class
