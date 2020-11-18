Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles nome.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim p As New Professor
        p.Professor(“222.222.222-22”, “Beatriz”, “Linda demais”)
        txtNomeProf.Text = p.pnome
        txtTitulo.Text = p.ptitulo
    End Sub

    Private Sub exibir1_Click(sender As Object, e As EventArgs) Handles exibir1.Click
        Dim a As New Aluno
        a.Aluno(“Juliana”, “11.111-1”, “111.111.111-11”)
        txtNomeAluno.Text = a.pnome
        txtRgm.Text = a.prgm
    End Sub
End Class
