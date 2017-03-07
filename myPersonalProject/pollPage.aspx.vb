
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI




Partial Class pollPage
    Inherits System.Web.UI.Page

    Private Sub initFields()
        fTB.Text = ""
        lTB.Text = ""
        favShowTB.Text = ""
        favShowDD.Text = ""
        favMovieTB.Text = ""
        favMovieDD.Text = ""
        bDelete.Visible = False
        lbPollPage.SelectedIndex = -1  ' reset selected to none
        Session("ID") = -1

    End Sub
    Protected Sub bSubmit_Click(sender As Object, e As EventArgs) Handles bSubmit.Click

        Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("ppDB").ConnectionString)
        con.Open()

        Dim myCommand As SqlCommand
        Dim insertCmd As String
        Dim tmp As String

        tmp = fTB.Text
        tmp = lTB.Text()

        If Session("ID") <> -1 Then
            insertCmd = "Update contacts set fTB = '" & fTB.Text & "', " &
                "lTB = '" & lTB.Text & "', " & "' where id = " & Session("ID")

        Else
            insertCmd = "insert into contacts (fTB,lTB) values " & _
            " ('" & fTB.Text & _
            "','" & lTB.Text & _
            "');"
        End If

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
            initFields()
            loadContacts()

        Catch ex As SqlException


            Dim mp As New site()

            mp.msgLog("Error creating Contact table", insertCmd)
        End Try
        loadContacts()

    End Sub

    Private Sub loadContact()


        Dim myCommand As SqlCommand

        Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("ppDB").ConnectionString)
        con.Open()

        Dim selectCmd As String
        Dim dr As SqlDataReader

        selectCmd = "Select fTB,lTB,id from contacts where id = " & Session("ID")
        myCommand = New SqlCommand(selectCmd, con)
        dr = myCommand.ExecuteReader()


        Do While dr.Read()
            fTB.Text = dr.GetString(0)
            lTB.Text = dr.GetString(1)

            bDelete.Visible = True

        Loop

    End Sub


    Private Sub loadContacts()
        Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("ppDB").ConnectionString)
        con.Open()

        Dim command As SqlCommand = New SqlCommand("select ID, fTB, lTB from contacts;", con)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then

            lbPollPage.Items.Clear()
            lbIDs.Items.Clear()

            Do While reader.Read()
                lbPollPage.Items.Add(reader.GetString(1) & ", " & reader.GetString(2))
                lbIDs.Items.Add(reader.GetInt32(0).ToString())
            Loop


        Else
            lbPollPage.Items.Add("No contacts")
        End If


    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load


        If Session("ID") Is Nothing Then

            loadContacts()
            Session("ID") = -1
        End If


    End Sub

    Protected Sub lbPollPage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPollPage.SelectedIndexChanged


        Dim index As Integer

        index = -1
        Dim li As ListItem
        For Each li In lbPollPage.Items
            index += 1
            If li.Selected = True Then
                Exit For
            End If
        Next

        Session("ID") = lbIDs.Items(index).ToString()

        loadContact()


    End Sub




    Protected Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("ppDB").ConnectionString)
        con.Open()

        Dim myCommand As SqlCommand
        Dim insertCmd As String


        insertCmd = "Delete from contacts where id = " & Session("ID")

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
            initFields()
            loadContacts()

        Catch ex As SqlException


            Dim mp As New site()

            mp.msgLog("Error creating contacts table", insertCmd)
        End Try
        loadContacts()
    End Sub

End Class
