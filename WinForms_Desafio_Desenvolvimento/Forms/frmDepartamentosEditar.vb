Public Class frmDepartamentosEditar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

    End Sub

    Public Sub AbrirDepartamento(ByVal idDepartamento As Integer)

        Dim drDepartamento As DataRow = Dados.ObterDepartamento(idDepartamento)

        Me.txtID.Text = CInt(drDepartamento("ID")).ToString()
        Me.txtDescricao.Text = CStr(drDepartamento("Descricao"))

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        ' Correção necessária para adicionar novos departamentos
        ' Validamos se existe alguma entrada no ID e caso não tenha deixamos como 0 (conforme metodo de adicionar dados)

        Dim IDInput As String = Me.txtID.Text

        Dim ID As Integer = 0

        If (IDInput.Length > 0) Then
            ID = Integer.Parse(IDInput)
        End If

        'Fim correção

        Dim validacao = ValidateInputs()

        If (validacao = ValidationResult.Valid) Then

            Dim Descricao As String = Me.txtDescricao.Text

            Dim sucesso As Boolean = Dados.GravarDepartamento(ID, Descricao)

            If Not sucesso Then

                MessageBox.Show(Me, "Falha ao gravar Departamento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DialogResult = DialogResult.Cancel

            Else

                Me.DialogResult = DialogResult.OK

            End If

            Me.Close()

        End If


    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Function ValidateInputs() As ValidationResult

        Dim result As ValidationResult

        lblDescricao.ForeColor = Color.Black

        ' ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~
        ' ~ Validacao do input da Descricao ~

        result = Validation.ValidateString(Me.txtDescricao.Text)

        If (result <> ValidationResult.Valid) Then

            MessageBox.Show(Me, "- Descrição possui " + Validation.ValidationMessage(result), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lblDescricao.ForeColor = Color.Red

        End If

        Return result

    End Function

End Class