<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartamentosEditar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartamentosEditar))
        Me.tlpLayoutRoot = New System.Windows.Forms.TableLayoutPanel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.tlpLayoutRoot.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpLayoutRoot
        '
        Me.tlpLayoutRoot.ColumnCount = 3
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpLayoutRoot.Controls.Add(Me.lblID, 0, 0)
        Me.tlpLayoutRoot.Controls.Add(Me.txtID, 1, 0)
        Me.tlpLayoutRoot.Controls.Add(Me.lblDescricao, 0, 1)
        Me.tlpLayoutRoot.Controls.Add(Me.txtDescricao, 1, 1)
        Me.tlpLayoutRoot.Controls.Add(Me.btnSalvar, 2, 3)
        Me.tlpLayoutRoot.Controls.Add(Me.btnFechar, 1, 3)
        Me.tlpLayoutRoot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayoutRoot.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayoutRoot.Name = "tlpLayoutRoot"
        Me.tlpLayoutRoot.RowCount = 4
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLayoutRoot.Size = New System.Drawing.Size(624, 441)
        Me.tlpLayoutRoot.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblID.Location = New System.Drawing.Point(3, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(114, 40)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID:"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(123, 10)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'lblDescricao
        '
        Me.lblDescricao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescricao.Location = New System.Drawing.Point(3, 40)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(114, 40)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        Me.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(123, 50)
        Me.txtDescricao.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(378, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.disk
        Me.btnSalvar.Location = New System.Drawing.Point(507, 404)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(114, 34)
        Me.btnSalvar.TabIndex = 10
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.door_open_in
        Me.btnFechar.Location = New System.Drawing.Point(374, 404)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(127, 34)
        Me.btnFechar.TabIndex = 10
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frmDepartamentosEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.tlpLayoutRoot)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDepartamentosEditar"
        Me.Text = "Netspeed - Desafio Desenvolvimento"
        Me.tlpLayoutRoot.ResumeLayout(False)
        Me.tlpLayoutRoot.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpLayoutRoot As TableLayoutPanel
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblDescricao As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFechar As Button
End Class
