
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager




Partial Class createTables
    Inherits System.Web.UI.Page

    Protected Sub bCreateTables_Click(sender As Object, e As EventArgs) Handles bCreateTables.Click


        Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("myDB").ConnectionString)
        con.Open()

        Dim myCommand As SqlCommand
        Dim insertCmd As String


        ' Drop contacts table
        insertCmd = "Drop TABLE contacts;"

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException

        End Try

        ' Drop emails table
        insertCmd = "Drop TABLE emails;"

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException

        End Try


        ' Drop PhonenoS table
        insertCmd = "Drop TABLE phoneNos;"

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException

        End Try


        ' Drop addresses table
        insertCmd = "Drop TABLE addresses;"

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException

        End Try


        ' Create contacts table
        insertCmd = "CREATE TABLE contacts (" & _
            "ID int IDENTITY(1,1) PRIMARY KEY, " & _
            "lname varchar (100) NULL," & _
            "fname varchar (50)  NULL," & _
            "dDate date null ," & _
            "anDate date null );"

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException

            Dim mp As New Site()

            mp.msgLog("Error creating Contact table", insertCmd)

        End Try


        ' Create PhoneNo table
        insertCmd = "CREATE TABLE phoneNos (" & _
            "ID int IDENTITY(1,1) PRIMARY KEY, " & _
            "contactId int null, " & _
            "type varchar (20)  NULL, " & _
            "phoneNo varchar (100) NULL) ;"

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException

            Dim mp As New Site()

            mp.msgLog("Error creating PhoneNos table", insertCmd)

        End Try


        ' Create emails table
        insertCmd = "CREATE TABLE emails (" & _
            "ID int IDENTITY(1,1) PRIMARY KEY, " & _
            "contactId int null, " & _
            "type varchar (20)  NULL, " & _
            "email varchar (100) NULL) ;"

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException

            Dim mp As New Site()

            mp.msgLog("Error creating emails table", insertCmd)

        End Try


        ' Create Address table
        insertCmd = "CREATE TABLE addresses (" & _
            "ID int IDENTITY(1,1) PRIMARY KEY, " & _
            "contactId int null, " & _
            "type varchar (20)  NULL, " & _
            "StreetAddress varchar (100) NULL, " & _
            "city varchar (30) NULL, " & _
            "state varchar (2) NULL, " & _
            "zip varchar (10) NULL  ) ;"

        myCommand = New SqlCommand(insertCmd, con)
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException

            Dim mp As New Site()

            mp.msgLog("Error creating Addresses table", insertCmd)

        End Try



    End Sub
End Class

