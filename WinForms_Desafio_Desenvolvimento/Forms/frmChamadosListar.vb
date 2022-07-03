
Imports System.Globalization

Public Class frmChamadosListar

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dtChamados As DataTable = Dados.ListarChamados()

        ' ~ Criamos uma nova coluna para aceitar ordenação da Data
        dtChamados.Columns.Add("DateFormated", GetType(DateTime))

        Me.dgvChamados.DataSource = dtChamados

        ' ~ Pegamos cada valor em string e "convertemos" para DateTime
        For i As Integer = 0 To dgvChamados.Rows.Count - 1

            dgvChamados.Rows.Item(i).Cells.Item("DateFormated").Value = CDate(dgvChamados.Rows.Item(i).Cells.Item("DataAbertura").Value)

        Next i

        ' ~ Removemos a antiga coluna e nomeamos a nova com o mesmo cabeçalho
        Me.dgvChamados.Columns.Remove(Me.dgvChamados.Columns.Item("DataAbertura"))
        Me.dgvChamados.Columns.Item("DateFormated").HeaderText = "DataAbertura"

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If Me.dgvChamados.SelectedRows.Count = 0 Then Exit Sub

        ' ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~

        Dim dgvr As DataGridViewRow = Me.dgvChamados.SelectedRows(0)
        Dim drv As DataRowView = DirectCast(dgvr.DataBoundItem, DataRowView)

        Dim idChamado As Integer = CInt(drv("ID"))

        Dim dlgResult As DialogResult =
            MessageBox.Show(Me, $"Confirma a exclusão do Chamado nº {idChamado} ?",
                            Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dlgResult <> DialogResult.Yes Then Exit Sub

        ' ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~

        Dim sucesso As Boolean = Dados.ExcluirChamado(idChamado)

        If sucesso Then

            ' Apenas para listar os dados novamente
            Me.frmPrincipal_Load(sender, e)

        End If

    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click

        If Me.dgvChamados.SelectedRows.Count = 0 Then Exit Sub

        ' ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~

        Dim dgvr As DataGridViewRow = Me.dgvChamados.SelectedRows(0)
        Dim drv As DataRowView = DirectCast(dgvr.DataBoundItem, DataRowView)

        Dim idChamado As Integer = CInt(drv("ID"))

        ' ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~

        Dim frm As New frmChamadosEditar()
        frm.AbrirChamado(idChamado)

        Dim dlgResult As DialogResult = frm.ShowDialog()

        If dlgResult = DialogResult.OK Then

            ' Apenas para listar os dados novamente
            Me.frmPrincipal_Load(sender, e)

        End If

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        Dim frm As New frmChamadosEditar()

        Dim dlgResult As DialogResult = frm.ShowDialog()

        'Recarregar após nova inserção
        If dlgResult = DialogResult.OK Then

            ' Apenas para listar os dados novamente
            Me.frmPrincipal_Load(sender, e)

        End If

    End Sub

    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click

        Dim frm As New frmChamadosRelatorio()
        frm.ShowDialog()

    End Sub

    Private Sub dgvChamados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChamados.CellContentDoubleClick

        'Apenas Invocamos o Abrir para edição dos dados

        btnAbrir.PerformClick()

    End Sub

End Class
