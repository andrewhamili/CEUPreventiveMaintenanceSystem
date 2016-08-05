Imports MySql.Data.MySqlClient
Imports MetroFramework

Public Class serv_card_eq
    Dim ds As New DataSet
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim svYN As System.Windows.Forms.DialogResult
    Dim addYN As System.Windows.Forms.DialogResult
    Dim editYN As System.Windows.Forms.DialogResult
    Dim cancelYN As System.Windows.Forms.DialogResult
    Dim updateYN As System.Windows.Forms.DialogResult
    Dim deleteYN As DialogResult
    Dim doneYN As System.Windows.Forms.DialogResult
    Public Sub Load_Table()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=root;database=equip_management"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select  serial_no as 'Serial Number' , sched_date as 'Date Scheduled' , remarks_eq as 'Remarks' , mainte_eq as 'Preventive Maintenance' , cost_eq as 'Cost of Repair' , serv_eq as 'Service by'  from equip_management.sched_info"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            disp_sched_info.DataSource = bSource
            disp_sched_info.ReadOnly = True
            SDA.Update(dbDataSet)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try



    End Sub

    Public Sub serv_card_eq_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select  serial_no as 'Serial Number' , sched_date as 'Date Scheduled' , remarks_eq as 'Remarks' , mainte_eq as 'Preventive Maintenance' , cost_eq as 'Cost of Repair' , serv_eq as 'Service by'  from equip_management.sched_info"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            disp_sched_info.DataSource = bSource
            disp_sched_info.ReadOnly = True
            SDA.Update(dbDataSet)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


        btn_done1.Hide()
        btn_clear1.Hide()
        btn_update1.Hide()
        btn_save1.Hide()
        btn_delete1.Hide()
        btn_cancel1.Hide()
        txt_cost_eq.Enabled = False
        txt_mainte_eq.Enabled = False
        txt_remarks_eq.Enabled = False
        txt_sched_date.Enabled = False
        txt_serial_eq.Enabled = False
        txt_serv_eq.Enabled = False
    End Sub






    Private Sub btn_add1_Click(sender As System.Object, e As System.EventArgs) Handles btn_add1.Click
        addYN = MetroMessageBox.Show(Me, "Are you sure you want to Create? ", "Create Student Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If addYN = MsgBoxResult.Yes Then
            btn_add1.Enabled = False
            btn_save1.Show()
            btn_clear1.Show()
            btn_cancel1.Show()
            btn_clear1.Enabled = True
            txt_cost_eq.Enabled = True
            txt_mainte_eq.Enabled = True
            txt_remarks_eq.Enabled = True
            txt_sched_date.Enabled = True
            txt_serial_eq.Enabled = True
            txt_serv_eq.Enabled = True
        End If
    End Sub




    Private Sub btn_save1_Click(sender As System.Object, e As System.EventArgs) Handles btn_save1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=root;database=equip_management"
        Dim READER As MySqlDataReader
        svYN = MetroMessageBox.Show(Me, "Are you sure you want to Save/Register this Information? ", "Register Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If svYN = MsgBoxResult.Yes Then
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "insert into equip_management.sched_info (serial_no,sched_date,remarks_eq,mainte_eq,cost_eq,serv_eq) values ('" & txt_serial_eq.Text & "','" & Format(CDate(txt_sched_date.Value), "yyyy-MM-dd") & "' , '" & txt_remarks_eq.Text & "','" & txt_mainte_eq.Text & "','" & txt_cost_eq.Text & "','" & txt_serv_eq.Text & "')"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Register Complete!")
                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
                btn_done1.Enabled = True
                btn_done1.Show()
                btn_cancel1.Hide()
                txt_cost_eq.Text = " "
                txt_mainte_eq.Text = " "
                txt_remarks_eq.Text = " "
                txt_serial_eq.Text = " "
                txt_serv_eq.Text = " "
                Load_Table()
            End Try

        End If
    End Sub

    Private Sub btn_done1_Click(sender As System.Object, e As System.EventArgs) Handles btn_done1.Click
        doneYN = MetroMessageBox.Show(Me, "Are you done storing Informations? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If doneYN = MsgBoxResult.Yes Then


            btn_done1.Hide()
            btn_clear1.Hide()
            btn_update1.Hide()
            btn_save1.Hide()
            btn_delete1.Hide()
            btn_cancel1.Hide()
            btn_add1.Enabled = True
            txt_cost_eq.Enabled = False
            txt_mainte_eq.Enabled = False
            txt_remarks_eq.Enabled = False
            txt_sched_date.Enabled = False
            txt_serial_eq.Enabled = False
            txt_serv_eq.Enabled = False
            txt_cost_eq.Text = " "
            txt_mainte_eq.Text = " "
            txt_remarks_eq.Text = " "
            txt_serial_eq.Text = " "
            txt_serv_eq.Text = " "
        End If
    End Sub

    Private Sub btn_cancel1_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel1.Click

        cancelYN = MetroMessageBox.Show(Me, "Are you sure you want to Cancel? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If cancelYN = MsgBoxResult.Yes Then
            btn_done1.Hide()
            btn_clear1.Hide()
            btn_update1.Hide()
            btn_save1.Hide()
            btn_delete1.Hide()
            btn_cancel1.Hide()
            btn_add1.Enabled = True
            txt_cost_eq.Enabled = False
            txt_mainte_eq.Enabled = False
            txt_remarks_eq.Enabled = False
            txt_sched_date.Enabled = False
            txt_serial_eq.Enabled = False
            txt_serv_eq.Enabled = False
            txt_cost_eq.Text = " "
            txt_mainte_eq.Text = " "
            txt_remarks_eq.Text = " "
            txt_serial_eq.Text = " "
            txt_serv_eq.Text = " "
        End If
    End Sub


    Private Sub disp_sched_info_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles disp_sched_info.CellContentClick
        editYN = MetroMessageBox.Show(Me, "Are you sure you want to update this Information? ", "Update Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If editYN = MsgBoxResult.Yes Then
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = disp_sched_info.Rows(e.RowIndex)
                txt_serial_eq.Text = row.Cells("Serial Number").Value.ToString
                txt_sched_date.Text = row.Cells("Date Scheduled").Value.ToString
                txt_remarks_eq.Text = row.Cells("Remarks").Value.ToString
                txt_mainte_eq.Text = row.Cells("Preventive Maintenance").Value.ToString
                txt_cost_eq.Text = row.Cells("Cost of Repair").Value.ToString
                txt_serv_eq.Text = row.Cells("Service by").Value.ToString
                
                btn_clear1.Enabled = False
                btn_add1.Enabled = False
                btn_delete1.Enabled = True
                btn_delete1.Show()
                btn_cancel1.Show()
                btn_update1.Show()
                btn_done1.Hide()
                btn_cancel1.Enabled = True

                txt_cost_eq.Enabled = True
                txt_mainte_eq.Enabled = True
                txt_remarks_eq.Enabled = True
                txt_sched_date.Enabled = True
                txt_serial_eq.Enabled = True
                txt_serv_eq.Enabled = True

            End If
        End If
    End Sub

    Private Sub btn_update1_Click(sender As System.Object, e As System.EventArgs) Handles btn_update1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=root;database=equip_management"
        Dim READER As MySqlDataReader
        updateYN = MetroMessageBox.Show(Me, "Are you sure you want to Save this changes? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If updateYN = MsgBoxResult.Yes Then
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "update equip_management.sched_info set serial_no='" & txt_serial_eq.Text & "' , sched_date = '" & Format(CDate(txt_sched_date.Value), "yyyy-MM-dd") & "' , remarks_eq='" & txt_remarks_eq.Text & "' , mainte_eq = '" & txt_mainte_eq.Text & "' , cost_eq = '" & txt_cost_eq.Text & "'  ,  serv_eq = '" & txt_serv_eq.Text & "'   where serial_no ='" & txt_serial_eq.Text & "'"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Update Complete!")

                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
                Load_Table()
                btn_cancel1.Hide()
                btn_done1.Show()

            End Try

        End If
    End Sub

    Private Sub btn_delete1_Click(sender As System.Object, e As System.EventArgs) Handles btn_delete1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=root;database=equip_management"
        Dim READER As MySqlDataReader
        deleteYN = MetroMessageBox.Show(Me, "Are you sure you want to Delete ? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If deleteYN = MsgBoxResult.Yes Then
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "delete from sched_info where serial_no = '" & txt_serial_eq.Text & "'"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MetroMessageBox.Show(Me, "Delete Complete!", "Delete")
                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
                Load_Table()

            End Try
            btn_cancel1.Hide()
            btn_done1.Show()
            btn_done1.Enabled = True
            txt_cost_eq.Text = " "
            txt_mainte_eq.Text = " "
            txt_remarks_eq.Text = " "
            txt_serial_eq.Text = " "
            txt_serv_eq.Text = " "

        End If
    End Sub

    Private Sub btn_clear1_Click(sender As System.Object, e As System.EventArgs) Handles btn_clear1.Click
        txt_cost_eq.Text = " "
        txt_mainte_eq.Text = " "
        txt_remarks_eq.Text = " "
        txt_serial_eq.Text = " "
        txt_serv_eq.Text = " "
    End Sub

    Private Sub btn_mlminimize_Click(sender As Object, e As EventArgs) Handles btn_mlminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_mlclose_Click(sender As Object, e As EventArgs) Handles btn_mlclose.Click
        Me.Hide()

    End Sub
End Class