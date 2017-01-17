Imports MySql.Data.MySqlClient
Imports System.IO
Class About

    Private Sub About_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub About_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbl_version.Text = systemversion
    End Sub

    Public Sub btn_CheckUpdate_Click() Handles btn_CheckUpdate.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim updateYN As DialogResult
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM systemupdate ORDER BY systemversion DESC LIMIT 1", MySQLConn)
            reader = comm.ExecuteReader
            Dim updatestatus As Integer = 0
            While reader.Read
                If reader.GetString("systemversion") > systemversion Then
                    updatestatus = 1
                End If
            End While
            If updatestatus > 0 Then
                updateYN = MsgBox("A new update is available. Do you want to update now?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "CEU TLTD Preventive Maintenance System")
            Else
                MsgBox("There are no available updates for the System as of now.", MsgBoxStyle.Information, "CEU TLTD Preventive Manintenance SYstem")
            End If
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
        If updateYN = Windows.Forms.DialogResult.Yes Then
            DownloadAndInstallUpdate()
        End If
    End Sub
    Public Sub DownloadAndInstallUpdate()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Dim arrImage() As Byte
        Dim downloadedversion As String
        Dim downloadcount As Integer

        MySQLConn.ConnectionString = connstring
        Dim query As String
        Try
            MySQLConn.Open()
            query = "SELECT * FROM systemupdate ORDER BY systemversion DESC LIMIT 1"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                arrImage = reader.Item("file")
                downloadcount = reader.GetInt32("downloadcount")
                downloadedversion = reader.GetString("systemversion")
            End While
            File.WriteAllBytes(Directory.GetCurrentDirectory + "\update.7z", arrImage)

            Console.WriteLine(Directory.GetCurrentDirectory)
            MySQLConn.Close()
            MySQLConn.Open()
            query = "UPDATE systemupdate set downloadcount=@newcount WHERE systemversion=@version"
            comm = New MySqlCommand(query, MySQLConn)
            comm.Parameters.AddWithValue("newcount", downloadcount = downloadcount + 1)
            comm.Parameters.AddWithValue("version", downloadedversion)
            reader = comm.ExecuteReader
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
        Dim confirm As New FileInfo("update.7z")
        If confirm.Exists = True Then
            Dim extract As New Process
            Dim update As New Process
            extract.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            extract.StartInfo.CreateNoWindow = True
            extract.StartInfo.FileName = "7z.exe"
            extract.StartInfo.Arguments = ("e update.7z -aoa -p99adc231b045331e514a516b4b7680f588e3823213abe901738bc3ad67b2f6fcb3c64efb93d18002588d3ccc1a49efbae1ce20cb43df36b38651f11fa75678e8")
            extract.Start()
            extract.WaitForExit()

            update.StartInfo.FileName = "setup.exe"
            update.Start()
            Application.ExitThread()
        Else
            MsgBox("The update was not downloaded", MsgBoxStyle.Critical, "CEU TLTD Preventive Maintenance")
        End If



    End Sub
End Class