
Partial Class calculator
    Inherits System.Web.UI.Page


    Protected Sub btCalculate_Click(sender As Object, e As EventArgs) Handles btCalculate.Click
        Dim answer As Double

        Select Case ddOp.Text
            Case "+"
                answer = CDbl(tbValue1.Text) + CDbl(tbValue2.Text)
            Case "-"
                answer = CDbl(tbValue1.Text) - CDbl(tbValue2.Text)
            Case "*"
                answer = CDbl(tbValue1.Text) * CDbl(tbValue2.Text)
            Case "/"
                answer = CDbl(tbValue1.Text) / CDbl(tbValue2.Text)
        End Select

        lbTheAnswer.Text = CStr(answer)
        tbAnswer.Text = CStr(answer)
        'Calculate two values together
    End Sub
End Class
