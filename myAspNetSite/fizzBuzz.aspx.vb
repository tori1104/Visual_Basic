
Partial Class fizzBuzz

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        For ndx As Integer = 1 To 100
            Response.Write(CStr(ndx))

            If ndx Mod 3 = 0 Then
                Response.Write(" Fizz")
            End If

            If ndx Mod 5 = 0 Then
                Response.Write(" Buzz")
            End If
            Response.Write("<br>")

        Next

    End Sub
End Class
