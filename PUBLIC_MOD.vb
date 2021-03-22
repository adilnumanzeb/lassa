Module PUBLIC_MOD
    Public Function GET_ONLY_MOBNO(INPUT_MOBILE_NO As String)
        Dim ONLY_MOBILE_NUMBER = ""
        Dim mytext As String = INPUT_MOBILE_NO
        Dim myChars() As Char = mytext.ToCharArray()
        For Each ch As Char In myChars
            If Char.IsDigit(ch) Then
                ONLY_MOBILE_NUMBER += ch
            End If
        Next
        Return ONLY_MOBILE_NUMBER
    End Function

End Module
