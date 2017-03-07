
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager




Partial Class createTables
    Inherits System.Web.UI.Page

    Protected Sub bCreateTables_Click(sender As Object, e As EventArgs) Handles bCreateTables.Click


        Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("ppDB").ConnectionString)
        con.Open()

        Dim myCommand As SqlCommand
        Dim insertCmd As String


        ' Drop contact table
        insertCmd = "Drop TABLE contacts;"

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException

        End Try

        ' Drop shows table
        insertCmd = "Drop TABLE shows;"

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException

        End Try


        ' Drop movies table
        insertCmd = "Drop TABLE movies;"

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException

        End Try




        ' Create contacts table
        insertCmd = "CREATE TABLE contacts (" & _
            "ID int IDENTITY(1,1) PRIMARY KEY, " & _
            "lTB varchar (100) NULL," & _
            "fTB varchar (50) NULL;"

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException

            Dim mp As New Site()

            mp.msgLog("Error creating contacts table", insertCmd)

        End Try


        ' Create movies table
        insertCmd = "CREATE TABLE movies (" & _
            "ID int IDENTITY(1,1) PRIMARY KEY, " & _
            "contactId int null, " & _
            "type varchar (20)  NULL, " & _
            "movies varchar (100) NULL) ;"

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException

            Dim mp As New Site()

            mp.msgLog("Error creating movies table", insertCmd)

        End Try


        ' Create shows table
        insertCmd = "CREATE TABLE shows (" & _
            "ID int IDENTITY(1,1) PRIMARY KEY, " & _
            "contactId int null, " & _
            "type varchar (20)  NULL, " & _
            "shows varchar (100) NULL) ;"

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException

            Dim mp As New Site()

            mp.msgLog("Error creating shows table", insertCmd)

        End Try




    End Sub
End Class

