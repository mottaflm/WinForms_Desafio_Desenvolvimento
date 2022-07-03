Public Class frmChamadosEditar

    'Usando essa flag para identificar se é uma edição ou criação de chamado (para validar a data)
    Private IsNewInput As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim dtDepartamentos As DataTable = Dados.ListarDepartamentos()
        Me.cmbDepartamento.DataSource = dtDepartamentos
        Me.cmbDepartamento.DisplayMember = "Descricao"
        Me.cmbDepartamento.ValueMember = "ID"

        IsNewInput = True

    End Sub

    Public Sub AbrirChamado(ByVal idChamado As Integer)

        IsNewInput = False

        Dim drChamado As DataRow = Dados.ObterChamado(idChamado)

        Me.txtID.Text = CInt(drChamado("ID")).ToString()
        Me.txtAssunto.Text = CStr(drChamado("Assunto"))
        Me.txtSolicitante.Text = CStr(drChamado("Solicitante"))

        Me.cmbDepartamento.SelectedValue = CInt(drChamado("Departamento"))

        Dim strDataAbertura As String = CStr(drChamado("DataAbertura"))
        Me.dtpDataAbertura.Value = DateTime.Parse(strDataAbertura)

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        ' Correção necessária para adicionar novos chamados
        ' Validamos se existe alguma entrada no ID e caso não tenha deixamos como 0 (conforme metodo de adicionar dados)

        Dim IDInput As String = Me.txtID.Text

        Dim ID As Integer = 0

        If (IDInput.Length > 0) Then
            ID = Integer.Parse(IDInput)
        End If

        'Fim correção

        'Adicionando validacao em um metodo separado retornando o state da validacao

        Dim validacao = ValidateInputs()

        If (validacao = ValidationResult.Valid) Then

            Dim Assunto As String = Me.txtAssunto.Text
            Dim Solicitante As String = Me.txtSolicitante.Text
            Dim Departamento As Integer = CInt(Me.cmbDepartamento.SelectedValue)
            Dim DataAbertura As DateTime = Me.dtpDataAbertura.Value

            Dim sucesso As Boolean = Dados.GravarChamado(ID, Assunto, Solicitante, Departamento, DataAbertura)

            If Not sucesso Then

                MessageBox.Show(Me, "Falha ao gravar o chamado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DialogResult = DialogResult.Cancel

            Else

                Me.DialogResult = DialogResult.OK

            End If

            Me.Close()

        End If

    End Sub

    'Validamos todas as entradas da tela e trocamos a cor do label respectivo caso esteja errado
    'As regras de validação estão na classe Validation, aqui somente mexemos com o VIEW
    Private Function ValidateInputs() As ValidationResult

        Dim result As ValidationResult
        Dim dialogMessage As String = ""
        Dim hasInvalidInput As Boolean = False

        lblAssunto.ForeColor = Color.Black
        lblSolicitante.ForeColor = Color.Black
        lblDepartamento.ForeColor = Color.Black
        lblDataAbertura.ForeColor = Color.Black

        ' ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~
        ' ~ Validacao do input do Assunto ~

        result = Validation.ValidateString(Me.txtAssunto.Text)

        If (result <> ValidationResult.Valid) Then

            hasInvalidInput = True

            dialogMessage += "- Assunto possui " + Validation.ValidationMessage(result)
            lblAssunto.ForeColor = Color.Red

        End If

        ' ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~
        ' ~ Validacao do input do Solicitante ~

        result = Validation.ValidateString(Me.txtSolicitante.Text)

        If (result <> ValidationResult.Valid) Then

            hasInvalidInput = True

            dialogMessage += vbNewLine + "- Solicitante possui " + Validation.ValidationMessage(result)
            lblSolicitante.ForeColor = Color.Red

        End If

        ' ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~
        ' ~ Validacao do input de Departamentos (para caso não exista departamentos na abertura de chamado) ~

        If (cmbDepartamento.Items.Count = 0) Then

            hasInvalidInput = True

            dialogMessage += vbNewLine + "- Por favor cadastre um departamento!"
            lblDepartamento.ForeColor = Color.Red

        End If

        ' ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~
        ' ~ Validacao do input da Data (Somente se for uma entrada nova) ~

        If (IsNewInput) Then

            result = Validation.ValidateDate(Me.dtpDataAbertura.Value)

            If (result <> ValidationResult.Valid) Then

                hasInvalidInput = True

                dialogMessage += vbNewLine + "- " + Validation.ValidationMessage(result) + $" Data não pode ser menor que Hoje ({DateTime.Today.ToShortDateString()})"
                lblDataAbertura.ForeColor = Color.Red

            End If

        End If

        ' ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~
        'Checamos se não ocorreu nenhum erro e mostramos eles em UMA MessageBox única

        If (hasInvalidInput) Then

            MessageBox.Show(Me, dialogMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            result = ValidationResult.Invalid

        End If

        Return result

    End Function

End Class