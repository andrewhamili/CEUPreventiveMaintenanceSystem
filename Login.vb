Imports MySql.Data.MySqlClient
Imports MetroFramework
Imports System.Threading

Public Class Frm_Login

    Public dbconnectionstatus As Boolean = False
    Public loginsuccess As Boolean = False

    Private Sub MetroButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MetroButton1.Click

        If txtbox_username.Text = "" Then

        ElseIf txtbox_username.Text.Contains("@ceu.edu.ph") Then

        Else
            txtbox_username.Text = txtbox_username.Text + "@ceu.edu.ph"


        End If

        Dim query As String
        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()
            query = "SELECT * FROM userlist where username=@username and password=sha2(@password, 512)"
            comm = New MySqlCommand(query, MySQLConn)
            comm.Parameters.AddWithValue("@username", txtbox_username.Text)
            comm.Parameters.AddWithValue("@password", txtbox_password.Text)
            reader = comm.ExecuteReader
            Dim count As Integer
            While reader.Read
                count = count + 1
                activeuserfname = reader.GetString("fname")
                activeuserlname = reader.GetString("lname")
                username = reader.GetString("username")
                usertype = reader.GetString("usertype")
            End While
            If count >= 1 Then
                MetroMessageBox.Show(Me, "Welcome " & activeuserfname & " " & activeuserlname & "!", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Frm_Main.Show()
                loginsuccess = True


            Else
                'MsgBox("The username or password is incorrect.", MsgBoxStyle.Critical)
                MetroMessageBox.Show(Me, "The Username or Password is incorrect!", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtbox_password.Clear()
                txtbox_username.Clear()
                txtbox_username.Focus()
            End If
            MySQLConn.Close()
            If loginsuccess = True Then
                MySQLConn.Open()
                query = "INSERT INTO accountactivity(username) VALUES(@username)"
                comm = New MySqlCommand(query, MySQLConn)
                comm.Parameters.AddWithValue("username", username)
                reader = comm.ExecuteReader
                MySQLConn.Close()
            End If
        Catch ex As Exception
            MsgBox("MySql error" & ex.Message)
        Finally
            MySQLConn.Dispose()

        End Try


    End Sub

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        End
    End Sub

    Private Sub Frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        AcceptButton = MetroButton1
        CancelButton = MetroButton2

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()
            dbconnectionstatus = True
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox("MySQL Database Connection error" & ex.Message)
            End
        Finally
            MySQLConn.Dispose()
            If dbconnectionstatus = True Then
                lbl_connectionindicator.Text = "Online"
                lbl_connectionindicator.ForeColor = Color.Green
            Else
                lbl_connectionindicator.Text = "Offline"
                lbl_connectionindicator.ForeColor = Color.Red
            End If
        End Try
        Me.TopMost = True
        Me.TopMost = False
    End Sub

    Private Sub txtbox_username_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbox_username.GotFocus
        If txtbox_username.Text.Length > 0 Then
            txtbox_username.SelectAll()
        End If
    End Sub

    Private Sub txtbox_password_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbox_password.GotFocus
        If txtbox_password.Text.Length > 0 Then
            txtbox_password.SelectAll()
        End If
    End Sub
End Class
