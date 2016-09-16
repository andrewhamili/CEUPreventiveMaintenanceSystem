Imports MySql.Data.MySqlClient
Imports MetroFramework
Public Class FrmSettings
    Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        AcceptButton = MetroButton1

        tf_setserver.Text = My.Settings.Server
        tf_setdatabase.Text = My.Settings.Database
        tf_setport.Text = My.Settings.Port
    End Sub

    Public Sub savesettings()
        My.Settings.Server = tf_setserver.Text
        My.Settings.Database = tf_setdatabase.Text
        My.Settings.Port = tf_setport.Text
        If String.IsNullOrEmpty(tf_setusername.Text) And String.IsNullOrEmpty(tf_setpassword.Text) Then
            'NO ACTION
        Else
            My.Settings.Username = Actions.EncryptString(Actions.ToSecureString(tf_setusername.Text))
            My.Settings.Password = Actions.EncryptString(Actions.ToSecureString(tf_setpassword.Text))
        End If
        My.Settings.Save()
    End Sub

    Private Sub btn_savedbsettings_Click(sender As Object, e As EventArgs) Handles btn_savedbsettings.Click
        savesettings()
        MetroMessageBox.Show(Me, "Settings Saved!", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Frm_Login.Show()
        Me.Hide()
    End Sub

    Private Sub btn_mlclose_Click(sender As Object, e As EventArgs) Handles btn_mlclose.Click

        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to exit?", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If a = vbYes Then
            Application.ExitThread()

        Else


        End If

    End Sub

    Private Sub btn_mlminimize_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class