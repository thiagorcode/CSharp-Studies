Public Class Aluno
    Inherits Pessoa
    Private rgm As String
    Sub Aluno(ByVal nome As String, ByVal rgm As String, ByVal cpf As String)
        Me.pnome = nome
        Me.pcpf = cpf
        Me.rgm = rgm
    End Sub
    Property prgm() As String
        Get
            Return rgm
        End Get
        Set(ByVal valor As String)
            Me.rgm = valor
        End Set
    End Property
End Class
