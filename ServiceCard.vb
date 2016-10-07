Imports MySql.Data.MySqlClient

Public Class ServiceCard

    Private Sub ServiceCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_username.Text = activeuserfname + " " + activeuserlname
        txt_repaircost.Text = "0.00"
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        If CheckBox1.Checked = True Then
            txt_remarks.Text = "CONDEMNED AS OF " & DateTimePicker1.Text & " " & txt_remarks.Text
        End If

            Dim query As String
            Dim prev As String
            Dim servicetype As String


            If rdio_no.Checked = True Then
                prev = "No"
            End If

            If rdio_yes.Checked = True Then
                prev = "Yes"
            End If

            If rdio_inbound.Checked = True Then
                servicetype = "Inbound"
            End If

            If rdio_outbound.Checked = True Then
                servicetype = "Outbound"
            End If


            MySQLConn.ConnectionString = connstring

            Try
                MySQLConn.Open()
            query = "INSERT INTO maintenance VALUES(@date, @remarks, @servicetype, @prevmaintenance, @cost, @servicedby, @deviceserial);UPDATE equipmentlist set remarks=(SELECT remarks FROM maintenance WHERE equipmentserial=@deviceserial ORDER BY date DESC LIMIT 1) WHERE equipmentserial=@deviceserial;"
                comm = New MySqlCommand(query, MySQLConn)
                comm.Parameters.AddWithValue("date", Format(CDate(DateTimePicker.Text), "yyyy/MM/dd"))
                comm.Parameters.AddWithValue("remarks", txt_remarks.Text)
                comm.Parameters.AddWithValue("servicetype", servicetype)
                comm.Parameters.AddWithValue("prevmaintenance", prev)
                comm.Parameters.AddWithValue("cost", Format(CDec(txt_repaircost.Text)))
                comm.Parameters.AddWithValue("servicedby", txt_username.Text)
                comm.Parameters.AddWithValue("deviceserial", Device.equipserial)
                reader = comm.ExecuteReader
            MySQLConn.Close()
                MsgBox("Successfully Saved", MsgBoxStyle.Information, "CEU TLTD Preventive Maintenance System")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        Device.Maintenance_Log()
        Frm_Main.load_table()
            Me.Dispose()
    End Sub

    Private Sub txt_repaircost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_repaircost.KeyPress


        If txt_repaircost.Text.Contains(".") Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        Else
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

    End Sub

    Private Sub txt_repaircost_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txt_repaircost.PreviewKeyDown


        If e.KeyCode = Keys.Back Then
            If txt_repaircost.Text.Length > 0 Then
                txt_repaircost.Text = txt_repaircost.Text.Substring(0, txt_repaircost.Text.Length - 1)
                txt_repaircost.Select(txt_repaircost.Text.Length, 0)
            End If

        End If

    End Sub

    Private Sub Button1_Click() Handles Button1.Click, MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            DateTimePicker1.Enabled = True
        Else
            DateTimePicker1.Enabled = False
        End If
    End Sub
End Class