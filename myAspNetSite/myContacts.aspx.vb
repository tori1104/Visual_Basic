
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI




Partial Class myContacts
    Inherits System.Web.UI.Page

    Private Sub initFields()
        tbLname.Text = ""
        tbFname.Text = ""
        tbBdate.Text = ""
        tbAdate.Text = ""
        bDelete.Visible = False
        lbContacts.SelectedIndex = -1  ' reset selected to none
        Session("ID") = -1

        Session("PhID") = -1
        bDelete.Visible = False
        lbPhType.Visible = False
        lbPhNo.Visible = False
        tbPhNo.Visible = False
        lbxPhIds.Visible = False
        lbxPhNo.Visible = False
        bPhSave.Visible = False
        bPhDelete.Visible = False

    End Sub
    Protected Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click

        Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("myDB").ConnectionString)
        con.Open()

        Dim myCommand As SqlCommand
        Dim insertCmd As String

        If Session("ID") <> -1 Then
            insertCmd = "Update contacts  set lname = '" & tbLname.Text & "', " &
                "fname = '" & tbFname.Text & "', " &
                "bDate = '" & tbBdate.Text & "', " &
                "anDate = '" & tbAdate.Text & "' where id = " & Session("ID")

        Else
            insertCmd = "insert into contacts (lname,fname,bDate,anDate) values " & _
            " ('" & tbLname.Text & _
            "','" & tbFname.Text & _
            "','" & tbBdate.Text & _
            "','" & tbAdate.Text & _
            "');"
        End If

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
            initFields()
            loadContacts()

        Catch ex As SqlException


            Dim mp As New Site()

            mp.msgLog("Error creating Contact table", insertCmd)
        End Try
        loadContacts()

    End Sub



    Private Sub loadContact()


        Dim myCommand As SqlCommand

        Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("myDB").ConnectionString)
        con.Open()

        Dim selectCmd As String
        Dim dr As SqlDataReader

        selectCmd = "Select lName,fName,bDate,anDate,id from contacts where id = " & Session("ID")
        myCommand = New SqlCommand(selectCmd, con)
        dr = myCommand.ExecuteReader()


        Do While dr.Read()
            tbLname.Text = dr.GetString(0)
            tbFname.Text = dr.GetString(1)
            tbBdate.Text = dr.GetDateTime(2).ToString("yyyy-MM-dd")
            tbAdate.Text = dr.GetDateTime(2).ToString("yyyy-MM-dd")



            bDelete.Visible = True
            lbPhType.Visible = True
            lbPhNo.Visible = True
            tbPhNo.Visible = True
            lbxPhIds.Visible = True
            lbxPhNo.Visible = True
            bPhSave.Visible = True

        Loop

    End Sub


    Private Sub loadContacts()
        Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("myDB").ConnectionString)
        con.Open()

        Dim command As SqlCommand = New SqlCommand("select ID,fName,lName from contacts;", con)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then

            lbContacts.Items.Clear()
            lbIDs.Items.Clear()

            Do While reader.Read()
                lbContacts.Items.Add(reader.GetString(1) & ", " & reader.GetString(2))
                lbIDs.Items.Add(reader.GetInt32(0).ToString())
            Loop


        Else
            lbContacts.Items.Add("No contacts")
        End If


    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load


        If Not Page.IsPostBack Then

            loadContacts()
            Session("ID") = -1
            Session("PhID") = -1
        End If


    End Sub

    Protected Sub lbContacts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbContacts.SelectedIndexChanged


        Dim index As Integer

        index = -1
        Dim li As ListItem
        For Each li In lbContacts.Items
            index += 1
            If li.Selected = True Then
                Exit For
            End If
        Next

        Session("ID") = lbIDs.Items(index).ToString()

        loadContact()


    End Sub




    Protected Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("myDB").ConnectionString)
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


            Dim mp As New Site()

            mp.msgLog("Error creating Contact table", insertCmd)
        End Try
        loadContacts()
    End Sub

    Protected Sub lbIDs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbIDs.SelectedIndexChanged

    End Sub

    Protected Sub bPhSave_Click(sender As Object, e As EventArgs) Handles bPhSave.Click

        Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("myDB").ConnectionString)
        con.Open()

        Dim myCommand As SqlCommand
        Dim insertCmd As String

        If Session("PhID") <> -1 Then
            insertCmd = "Update contacts  set lname = '" & tbLname.Text & "', " &
                "fname = '" & tbFname.Text & "', " &
                "bDate = '" & tbBdate.Text & "', " &
                "anDate = '" & tbAdate.Text & "' where id = " & Session("ID")

        Else

            insertCmd = "insert into phoneNos (contactId,type,phoneNo) values " & _
            " ('" & Session("ID") & _
            "','" & tbPhType.Text & _
            "','" & tbPhNo.Text & _
            "');"
        End If

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
            initFields()
            loadContacts()

        Catch ex As SqlException


            Dim mp As New Site()

            mp.msgLog("Error creating Contact table", insertCmd)
        End Try
        loadContacts()
    End Sub
End Class
