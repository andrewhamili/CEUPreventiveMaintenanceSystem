Imports MySql.Data.MySqlClient
Imports MetroFramework
Imports System.Drawing.Printing
Imports System.IO
Imports System.ComponentModel
Imports System.Text
Public Class Frm_Accounts
    Dim Command As MySqlCommand
    Dim dbdataset As New DataTable
    Dim reader As MySqlDataReader

    Public editing As Boolean = False

    Private Sub Frm_Accounts_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub


    Private Sub Frm_Accounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_update.Enabled = False
        btn_delete.Enabled = False
        refresh_lb_accounts()

    End Sub

    Private Sub btn_save_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_save.Click

        If tf_password.Text = "" Or tf_retypepass.Text = "" Then
            MsgBox("Please enter a password", MsgBoxStyle.Critical, "CEU Preventive Maintenance System")
        Else
            If MySQLConn.State = ConnectionState.Open Then
                MySQLConn.Close()
            End If

            If tf_username.Text = "" Then

            ElseIf tf_username.Text.Contains("@ceu.edu.ph") Then

            Else
                tf_username.Text = tf_username.Text + "@ceu.edu.ph"


            End If

            Dim query As String

            MySQLConn.ConnectionString = connstring

            If tf_password.Text = tf_retypepass.Text Then
                If tf_fname.Text = "" Or tf_lname.Text = "" Or tf_username.Text = "" Or tf_password.Text = "" Or tf_retypepass.Text = "" Or cb_usertype.Text = "" Then
                    MetroMessageBox.Show(Me, "All fields with an astrisk (*) is required to be filled-up", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Try
                        MySQLConn.Open()
                        query = "SELECT * FROM userlist WHERE username=@enteredusername"
                        comm = New MySqlCommand(query, MySQLConn)
                        comm.Parameters.AddWithValue("enteredusername", tf_username.Text)
                        reader = comm.ExecuteReader
                        Dim count As Integer
                        While reader.Read
                            count += 1
                        End While
                        If count > 0 Then
                            MetroMessageBox.Show(Me, "The Username you entered already exists", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            MySQLConn.Close()
                            MySQLConn.Open()
                            query = "INSERT INTO userlist values(@firstname, @middlename, @lastname, @username, sha2(@password, 512), @usertype)"
                            comm = New MySqlCommand(query, MySQLConn)
                            comm.Parameters.AddWithValue("firstname", tf_fname.Text)
                            comm.Parameters.AddWithValue("middlename", tf_mname.Text)
                            comm.Parameters.AddWithValue("lastname", tf_lname.Text)
                            comm.Parameters.AddWithValue("username", tf_username.Text)
                            comm.Parameters.AddWithValue("password", tf_retypepass.Text)
                            comm.Parameters.AddWithValue("usertype", cb_usertype.Text)
                            reader = comm.ExecuteReader
                            MySQLConn.Close()
                            tf_fname.Text = ""
                            tf_mname.Text = ""
                            tf_lname.Text = ""
                            tf_username.Text = ""
                            tf_password.Text = ""
                            tf_retypepass.Text = ""
                            MetroMessageBox.Show(Me, "Registration Successful", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        MySQLConn.Dispose()
                    End Try
                End If
            Else
                MetroMessageBox.Show(Me, "Passwords do not match!", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            refresh_lb_accounts()
        End If

    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If tf_password.Text = "" Or tf_retypepass.Text = "" Then
            MsgBox("Please enter a password!", MsgBoxStyle.Critical, "CEU Preventive Maintenance System")
        Else
            If MySQLConn.State = ConnectionState.Open Then
                MySQLConn.Close()
            End If
            Dim query As String


            MySQLConn.ConnectionString = connstring

            tf_fname.Enabled = False
            tf_mname.Enabled = False
            tf_lname.Enabled = False


            Dim a As Integer
            If tf_password.Text = tf_retypepass.Text Then
                If tf_username.Text = "" Then
                    MetroMessageBox.Show(Me, "Please select a Username!", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    a = MetroMessageBox.Show(Me, "Are you sure you want to update this account?", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If a = vbYes Then
                        editing = True
                        Try
                            MySQLConn.Open()
                            query = "update userlist set password=sha2(@password,512), fname=@firstname, mname=@middlename, lname=@lastname,usertype=@usertype where username=@username"
                            comm = New MySqlCommand(query, MySQLConn)
                            comm.Parameters.AddWithValue("password", tf_retypepass.Text)
                            comm.Parameters.AddWithValue("firstname", tf_fname.Text)
                            comm.Parameters.AddWithValue("middlename", tf_mname.Text)
                            comm.Parameters.AddWithValue("lastname", tf_lname.Text)
                            comm.Parameters.AddWithValue("usertype", cb_usertype.Text)
                            comm.Parameters.AddWithValue("username", tf_username.Text)
                            reader = comm.ExecuteReader
                            tf_fname.Enabled = True
                            tf_mname.Enabled = True
                            tf_lname.Enabled = True

                            tf_fname.Text = ""
                            tf_mname.Text = ""
                            tf_lname.Text = ""
                            tf_username.Text = ""
                            tf_password.Text = ""
                            tf_retypepass.Text = ""
                            btn_update.Enabled = False
                            btn_save.Enabled = True
                            btn_delete.Enabled = False
                            MySQLConn.Close()
                            MetroMessageBox.Show(Me, "Account Updated", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            tf_username.Enabled = True
                            refresh_lb_accounts()
                            editing = False
                            'load_data_account_from_listbox()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        Finally
                            MySQLConn.Dispose()
                        End Try
                    End If
                End If
            Else
                MetroMessageBox.Show(Me, "The passwords do not match", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

        
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        MySQLConn = New MySqlConnection
        MySQLConn.ConnectionString = connstring

        Dim a As Integer

        If tf_username.Text = "" Then
            MetroMessageBox.Show(Me, "No selected user.", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            a = MetroMessageBox.Show(Me, "Are you sure you want to delete this account?", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If a = vbYes Then
                Dim tempusername As String

                Try
                    MySQLConn.Open()
                    Dim query As String
                    query = "Delete from userlist where username='" & tf_username.Text & "'"
                    comm = New MySqlCommand(query, MySQLConn)
                    reader = comm.ExecuteReader
                    tempusername = lb_useraccounts.Text
                    lb_useraccounts.Items.Remove(tempusername)


                    cb_usertype.Text = "-"
                    tf_fname.Text = ""
                    tf_mname.Text = ""
                    tf_lname.Text = ""
                    tf_username.Text = ""
                    tf_password.Text = ""
                    tf_retypepass.Text = ""
                    MySQLConn.Close()
                    MetroMessageBox.Show(Me, "Account Deleted!", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    btn_update.Enabled = False
                    btn_delete.Enabled = False
                    tf_username.Enabled = True
                    btn_save.Enabled = True
                    refresh_lb_accounts()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MySQLConn.Dispose()
                End Try
            Else
            End If
        End If
        



    End Sub

    Private Sub ListBoxUserAccounts_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lb_useraccounts.SelectedIndexChanged
        If editing = False Then
            btn_update.Enabled = True
            btn_delete.Enabled = True
            btn_save.Enabled = False
            load_data_account_from_listbox()
            tf_username.Enabled = False
        End If
    End Sub

    Private Sub btn_mlclose_Click(sender As Object, e As EventArgs) Handles btn_mlclose.Click
        Me.Dispose()
    End Sub
    Private Sub btn_mlminimize_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub load_data_account_from_listbox()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        Dim query As String


        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()
            query = "Select * from userlist where username='" & lb_useraccounts.Text & "'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader

            While reader.Read
                tf_fname.Text = reader.GetString("fname")
                tf_mname.Text = reader.GetString("mname")
                tf_lname.Text = reader.GetString("lname")
                cb_usertype.Text = reader.GetString("usertype")
                tf_username.Text = reader.GetString("username")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub refresh_lb_accounts()

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Dim query As String

        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()
            query = "Select * from userlist"

            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader


            While reader.Read
                lb_useraccounts.Items.Remove(reader.GetString("username"))
                lb_useraccounts.Items.Add(reader.GetString("username"))
            End While
            MySQLConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AccountActivity.ShowDialog()
    End Sub
End Class