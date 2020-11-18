Public Class Pessoa
    Dim cpf As String
    Dim nome As String
    Property pcpf() As String
        Get
            Return cpf
        End Get
        Set(ByVal valor As String)
            Me.cpf = valor
        End Set
    End Property
    Property pnome() As String
        Get
            Return nome
        End Get
        Set(ByVal valor As String)
            Me.nome = valor
        End Set
    End Property
End Class
