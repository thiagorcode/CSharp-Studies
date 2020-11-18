<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rgm = New System.Windows.Forms.Label()
        Me.nome = New System.Windows.Forms.Label()
        Me.professor = New System.Windows.Forms.Label()
        Me.nome2 = New System.Windows.Forms.Label()
        Me.titulo = New System.Windows.Forms.Label()
        Me.txtRgm = New System.Windows.Forms.TextBox()
        Me.txtNomeAluno = New System.Windows.Forms.TextBox()
        Me.txtNomeProf = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.exibir1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ALUNO"
        '
        'rgm
        '
        Me.rgm.AutoSize = True
        Me.rgm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgm.Location = New System.Drawing.Point(128, 141)
        Me.rgm.Name = "rgm"
        Me.rgm.Size = New System.Drawing.Size(58, 24)
        Me.rgm.TabIndex = 1
        Me.rgm.Text = "RGM:"
        '
        'nome
        '
        Me.nome.AutoSize = True
        Me.nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nome.Location = New System.Drawing.Point(128, 179)
        Me.nome.Name = "nome"
        Me.nome.Size = New System.Drawing.Size(67, 24)
        Me.nome.TabIndex = 2
        Me.nome.Text = "Nome:"
        '
        'professor
        '
        Me.professor.AutoSize = True
        Me.professor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.professor.Location = New System.Drawing.Point(96, 242)
        Me.professor.Name = "professor"
        Me.professor.Size = New System.Drawing.Size(127, 24)
        Me.professor.TabIndex = 3
        Me.professor.Text = "PROFESSOR"
        '
        'nome2
        '
        Me.nome2.AutoSize = True
        Me.nome2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nome2.Location = New System.Drawing.Point(128, 293)
        Me.nome2.Name = "nome2"
        Me.nome2.Size = New System.Drawing.Size(67, 24)
        Me.nome2.TabIndex = 4
        Me.nome2.Text = "Nome:"
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo.Location = New System.Drawing.Point(128, 336)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(61, 24)
        Me.titulo.TabIndex = 5
        Me.titulo.Text = "Título:"
        '
        'txtRgm
        '
        Me.txtRgm.Location = New System.Drawing.Point(209, 145)
        Me.txtRgm.Name = "txtRgm"
        Me.txtRgm.Size = New System.Drawing.Size(175, 20)
        Me.txtRgm.TabIndex = 6
        '
        'txtNomeAluno
        '
        Me.txtNomeAluno.Location = New System.Drawing.Point(209, 184)
        Me.txtNomeAluno.Name = "txtNomeAluno"
        Me.txtNomeAluno.Size = New System.Drawing.Size(175, 20)
        Me.txtNomeAluno.TabIndex = 7
        '
        'txtNomeProf
        '
        Me.txtNomeProf.Location = New System.Drawing.Point(209, 298)
        Me.txtNomeProf.Name = "txtNomeProf"
        Me.txtNomeProf.Size = New System.Drawing.Size(175, 20)
        Me.txtNomeProf.TabIndex = 8
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(209, 340)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(175, 20)
        Me.txtTitulo.TabIndex = 9
        '
        'exibir1
        '
        Me.exibir1.Location = New System.Drawing.Point(458, 161)
        Me.exibir1.Name = "exibir1"
        Me.exibir1.Size = New System.Drawing.Size(75, 23)
        Me.exibir1.TabIndex = 10
        Me.exibir1.Text = "Exibir"
        Me.exibir1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(458, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Exibir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 521)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.exibir1)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.txtNomeProf)
        Me.Controls.Add(Me.txtNomeAluno)
        Me.Controls.Add(Me.txtRgm)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.nome2)
        Me.Controls.Add(Me.professor)
        Me.Controls.Add(Me.nome)
        Me.Controls.Add(Me.rgm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Aula 01"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rgm As Label
    Friend WithEvents nome As Label
    Friend WithEvents professor As Label
    Friend WithEvents nome2 As Label
    Friend WithEvents titulo As Label
    Friend WithEvents txtRgm As TextBox
    Friend WithEvents txtNomeAluno As TextBox
    Friend WithEvents txtNomeProf As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents exibir1 As Button
    Friend WithEvents Button2 As Button
End Class
