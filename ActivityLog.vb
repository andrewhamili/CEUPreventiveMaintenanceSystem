Imports MySql.Data.MySqlClient

Public Class ActivityLog

    Private Sub ActivityLog_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub ActivityLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring & database

        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Dim query As String

        Try

            MySQLConn.Open()
            query = "SELECT logdate as Date, logaction as 'Action', deviceserial as 'Equipment Serial', changes as Changes, username, equipmentnumber as 'Equipment Number', equipmentname as 'Equipment Name', equipmentmodel as 'Equipment Brand and Model', equipmentserial as 'Equipment Serial', equipmentlocation as 'Equipment Location', equipmentowner as 'Owner', equipmentdatepurchase as 'Acquisition Date', equipmentprice as Price, equipmentbranch as 'Branch', maintenancesched as 'Maintenance Schedule', personincharge as 'Person-in-charge' from systemlog ORDER BY logdate DESC"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
End Class