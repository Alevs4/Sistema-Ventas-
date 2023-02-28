Module ValidaRut
    Public Function Validador(ByVal ElNumero As String) As String

        Dim Resultado As String = ""
        Dim Multiplicador As Integer = 2
        Dim iNum As String = 0
        Dim Suma As String = 0

        Dim num As String
        If ElNumero.Length < 8 Then
            num = "0" + ElNumero
        Else
            num = ElNumero
        End If
        For i As Integer = 8 To 1 Step -1
            iNum = Mid(num, i, 1)
            Suma += iNum * Multiplicador
            Multiplicador += 1
            If Multiplicador = 8 Then Multiplicador = 2
        Next
        Resultado = CStr(11 - (Suma Mod 11))
        If Resultado = "10" Then Resultado = "K"
        If Resultado = "11" Then Resultado = "0"
        Return num & "-" & Resultado
    End Function
End Module
