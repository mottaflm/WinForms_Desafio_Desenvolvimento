

Partial Public Class dsChamados
    Partial Public Class TableDataTable
        Private Sub TableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DataAberturaColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
