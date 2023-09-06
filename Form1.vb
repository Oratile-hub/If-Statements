Public Class Form1
    Private Sub btnSALanguage_Click(sender As Object, e As EventArgs) Handles btnSALanguage.Click

        Dim SALanguage As String

        SALanguage = txtSALanguage.Text.ToLower

        If SALanguage = "Setswana" Then
            MsgBox("Dumela")
        ElseIf SALanguage = "SePededi" Then
            MsgBox("Dumela")
        ElseIf SALanguage = "iSiXhosa" Then
            MsgBox("Molo")
        ElseIf SALanguage = "iSiZulu" Then
            MsgBox("Sawubona")
        ElseIf SALanguage = "English" Then
            MsgBox("Hello")
        ElseIf SALanguage = " Xitsonga" Then
            MsgBox("Avuxeni")

        End If


    End Sub
End Class
