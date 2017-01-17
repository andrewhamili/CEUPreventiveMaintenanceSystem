Imports MySql.Data.MySqlClient
Public Class AccountActivity
    Public dbdataset As New DataTable

    Private Sub AccountActivity_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub AccountActivity_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Load_Table()
    End Sub
    Public Sub Load_Table()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        dbdataset.Clear()
        MySQLConn.ConnectionString = connstring & database
        Dim query As String
        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Try
            MySQLConn.Open()
            query = "SELECT * FROM accountactivity"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView_AccountActivity.DataSource = bsource
            adapter.Update(dbdataset)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try


    End Sub

    Private Sub Button_Clear_Click(sender As System.Object, e As System.EventArgs) Handles Button_Clear.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("DELETE FROM accountactivity", MySQLConn)
            reader = comm.ExecuteReader
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
        Load_Table()
    End Sub
End Class