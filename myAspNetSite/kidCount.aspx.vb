
Partial Class kidCount

    Inherits System.Web.UI.Page

    Protected Sub bCompute_Click(sender As Object, e As EventArgs) Handles bCompute.Click

        Dim numBoys As Integer
        Dim numGirls As Integer
        Dim numKids As Integer
        Dim numFamilies As Integer
        Dim randomValue As Integer

        Randomize()

        numFamilies = CInt(tbNumFam.Text)

        ' For index As Integer = 1 To numFamilies

        While numFamilies > 0
            randomValue = CInt(Math.Floor((2) * Rnd())) + 1

            If randomValue = 1 Then
                ' value is 1 then it's a boy
                numBoys = numBoys + 1
                numKids = numKids + 1
                numFamilies = numFamilies - 1

            Else
                'it's a girl
                numGirls = numGirls + 1
                numKids = numKids + 1

            End If

        End While

        lbBoys.Text = "Number of Boys: " + CStr(numBoys)
        lbGirls.Text = "Number of Girls: " + CStr(numGirls)
        lbKids.Text = "Number of Kids: " + CStr(numKids)

    End Sub
End Class
