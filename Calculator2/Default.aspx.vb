
Partial Class _Default
    Inherits System.Web.UI.Page
    'Vcitoria Humphrey
    '3-30-16
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

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
