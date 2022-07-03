Public Class Validation

    Private Const MAX_INPUT_LENGTH As Integer = 100
    Private Const MIN_INPUT_LENGTH As Integer = 3

    Public Shared Function ValidateString(ByVal input As String) As ValidationResult

        If (input.Length < MIN_INPUT_LENGTH) Then
            Return ValidationResult.TooSmall
        End If

        If (input.Length > MAX_INPUT_LENGTH) Then
            Return ValidationResult.TooLarge
        End If

        Return ValidationResult.Valid

    End Function

    Public Shared Function ValidateDate(ByVal input As DateTime) As ValidationResult

        If (input < DateTime.Today) Then
            Return ValidationResult.Invalid
        End If

        Return ValidationResult.Valid

    End Function

    Public Shared Function ValidationMessage(ByVal validation As ValidationResult) As String

        Select Case validation

            Case ValidationResult.Invalid
                Return "Entrada inválida!"
            Case ValidationResult.TooSmall
                Return $"Entrada com menos de {MIN_INPUT_LENGTH} caracteres!"
            Case ValidationResult.TooLarge
                Return $"Entrada com mais de {MAX_INPUT_LENGTH} caracteres!"
            Case Else
                Return "Não foi possível validar as entradas deste formulário!"

        End Select

    End Function

End Class
