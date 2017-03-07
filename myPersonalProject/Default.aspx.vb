
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub startTB_Click(sender As Object, e As EventArgs) Handles startTB.Click
        Server.Transfer("pollPage.aspx", True)
    End Sub

    Protected Sub createTable_Click(sender As Object, e As EventArgs) Handles createTable.Click
        Server.Transfer("createtables.aspx", True)
    End Sub
End Class
