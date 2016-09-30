Imports MySql.Data.MySqlClient
Public Class Device

    Public equipnum As String
    Public equipname As String
    Public equipmodel As String
    Public equipserial As String
    Public equiplocation As String
    Public equipdatepurchase As Date
    Public equipprice As String
    Public equipbranch As String
    Public equipmaintenancesched As String
    Public equippersonincharge As String


    Private Sub MetroButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton4.Click
        ServiceCard.ShowDialog()
    End Sub

    Private Sub Device_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        Frm_Main.ShowInTaskbar = True
        Frm_Main.Focus()
    End Sub

    Private Sub Device_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Maintenance_Log()
        info_equipnum.Text = equipnum
        info_equipname.Text = equipname
        info_equipmodel.Text = equipmodel
        info_equipserialnum.Text = equipserial
        info_equiplocation.Text = equiplocation
        info_equipdatepurchase.Text = equipdatepurchase.ToString("MM/dd/yyyy")
        info_equipprice.Text = equipprice
        info_equipbranch.Text = equipbranch
        info_equipmaintenancesched.Text = equipmaintenancesched
        info_equippersonincharge.Text = equippersonincharge

    End Sub

    Public Sub Maintenance_Log()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim query As String
        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        dbdataset.Clear()


        Try

            MySQLConn.Open()
            query = "SELECT date as Date, remarks as Remarks, prevmaintenance as 'Preventive Maintenance', format(cost, 2) as Cost, servicedby as 'Serviced By' FROM maintenance where equipmentserial='" & equipserial & "' ORDER BY date ASC"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            datagrid_logs.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Dispose()
        Frm_Main.ShowInTaskbar = True
        Frm_Main.Focus()
        Frm_Main.TopMost = True
        Frm_Main.TopMost = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        ServiceCardPrint.ShowDialog()
    End Sub

    Private Sub Device_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.Focus()
    End Sub

    Private Sub datagrid_logs_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagrid_logs.CellDoubleClick
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring

        If e.RowIndex >= 0 Then
            Dim query As String
            Dim row As DataGridViewRow = datagrid_logs.Rows(e.RowIndex)
            Dim datestorage As Date
            Dim servicedate As String
            Dim deviceserial As String
            Dim ans As Integer

            ans = MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo, "CEU TLTD Preventive Manitenance System")

            deviceserial = info_equipserialnum.Text


            If ans = 6 Then
                Try
                    MySQLConn.Open()
                    datestorage = row.Cells("Date").Value
                    servicedate = datestorage.ToString("yyyy/MM/dd")
                    query = "Delete from maintenance where equipmentserial=@equipmentserial and date=@maintenancedate"
                    comm = New MySqlCommand(query, MySQLConn)
                    comm.Parameters.AddWithValue("equipmentserial", info_equipserialnum.Text)
                    comm.Parameters.AddWithValue("maintenancedate", servicedate)
                    reader = comm.ExecuteReader
                    MySQLConn.Close()
                    MsgBox("The record has been deleted successfully", MsgBoxStyle.Information, "CEU Preventive Maintenance System")
                    Maintenance_Log()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class