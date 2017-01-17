Imports MySql.Data.MySqlClient
Imports MetroFramework
Imports System.IO
Imports System.Threading



Public Class Frm_Main


    Public dbdataset As New DataTable
    Public charactersAllowed As String = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"
    Public MarqueeTextThread As System.Threading.Thread

    Private Sub Frm_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MetroLabel1.Text = "Welcome, " & activeuserfname & " " & activeuserlname & "!"
        Control.CheckForIllegalCrossThreadCalls = False

        Dim UpdateInstaller As New FileInfo("setup.exe")
        Dim UpdateArchive As New FileInfo("update.exe")
        If UpdateInstaller.Exists Then
            UpdateInstaller.Delete()
        End If
        If UpdateArchive.Exists Then
            UpdateArchive.Delete()
        End If

        load_table()
        lbl_server.Text = "Server: " + My.Settings.Server
        About.btn_CheckUpdate_Click()
        'BackgroundWorker_MarqueeText.RunWorkerAsync()
        'BackgroundWorker_MySQL_ServerOnline.RunWorkerAsync()
        MarqueeTextThread = New System.Threading.Thread(AddressOf MarqueeText)
        MarqueeTextThread.Start()

    End Sub

    Private Sub btn_mlclose_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to exit?", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If a = vbYes Then
            Application.ExitThread()

        Else


        End If
    End Sub
    Private Sub MetroButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_accountmanagement.Click
        If usertype = "Administrator" Then
            Frm_Accounts.ShowDialog()
        Else
            MetroMessageBox.Show(Me, "You do not have the privilege to manage the User Accounts!", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub


    Private Sub MetroButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton4.Click
        Me.TopMost = False
        Dim a As Integer
        a = MetroMessageBox.Show(Me, "Are you sure you want to exit?", "CEU TLTD Preventive Maintenance System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If a = 6 Then
            'BackgroundWorker_MarqueeText.CancelAsync()
            'BackgroundWorker_MySQL_ServerOnline.CancelAsync()
            MarqueeTextThread.Abort()
            Me.Dispose()
            Dim form As New Frm_Login

            form.Show()
            form.Focus()
        End If
    End Sub
    Private Sub btn_mlminimize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_mlminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public Sub load_table()


        main_datagrid.Columns.Clear()
        dbdataset.Clear()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If


        MySQLConn.ConnectionString = connstring & database

        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim query As String
        Dim equipmentserial As DataGridViewRow
        Try

            MySQLConn.Open()
            query = "SELECT equipmentnumber as 'EquipmentNumber', equipmentname as 'EquipmentName', equipmentmodel as 'Equipment Model', equipmentserial as 'SerialNumber', equipmentlocation as 'Location', equipmentdatepurchase as 'Date purchased', format(equipmentprice, 2) as 'Price', equipmentbranch as 'Branch', maintenancesched as 'Maintenance Schedule', personincharge as 'Person in Charge', remarks as 'Status' FROM equipmentlist ORDER BY dateadded DESC"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            main_datagrid.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        Dim theText As String = TextBox1.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextBox1.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TextBox1.Text.Length - 1
            Letter = TextBox1.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TextBox1.Text = theText
        TextBox1.Select(SelectionIndex - Change, 0)

        'If TextBox2.Focused = True Then
        '    TextBox3.Text = ""
        '    ComboBox1.Text = ""
        'ElseIf TextBox3.Focused = True Then
        '    TextBox2.Text = ""
        '    ComboBox1.Text = ""
        'ElseIf ComboBox1.Focused = True Then
        '    TextBox2.Text = ""
        '    TextBox3.Text = ""
        'Else
        '    TextBox2.Text = ""
        '    TextBox3.Text = ""
        '    ComboBox1.Text = ""
        'End If

        'Dim dv As New DataView(dbdataset)
        'dv.RowFilter = String.Format("EquipmentName  Like '%{0}%'", TextBox1.Text)
        'main_datagrid.DataSource = dv

        Dim dv As New DataView(dbdataset)
        dv.RowFilter = String.Format("EquipmentName LIKE '%{0}%' and EquipmentNumber LIKE '%{1}%' and SerialNumber LIKE '%{2}%' and Branch LIKE '%{3}%'", TextBox1.Text, TextBox2.Text, TextBox3.Text, ComboBox1.Text)
        main_datagrid.DataSource = dv
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

        Dim theText As String = TextBox2.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextBox2.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TextBox2.Text.Length - 1
            Letter = TextBox2.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TextBox2.Text = theText
        TextBox2.Select(SelectionIndex - Change, 0)

        'If TextBox1.Focused = True Then
        '    TextBox3.Text = ""
        '    ComboBox1.Text = ""
        'ElseIf TextBox3.Focused = True Then
        '    TextBox1.Text = ""
        '    ComboBox1.Text = ""
        'ElseIf ComboBox1.Focused = True Then
        '    TextBox1.Text = ""
        '    TextBox3.Text = ""
        'Else

        '    TextBox1.Text = ""
        '    TextBox3.Text = ""
        '    ComboBox1.Text = ""
        'End If

        'Dim dv As New DataView(dbdataset)
        'dv.RowFilter = String.Format("EquipmentNumber  Like '%{0}%'", TextBox2.Text)
        'main_datagrid.DataSource = dv

        Dim dv As New DataView(dbdataset)
        dv.RowFilter = String.Format("EquipmentName LIKE '%{0}%' and EquipmentNumber LIKE '%{1}%' and SerialNumber LIKE '%{2}%' and Branch LIKE '%{3}%'", TextBox1.Text, TextBox2.Text, TextBox3.Text, ComboBox1.Text)
        main_datagrid.DataSource = dv
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

        Dim theText As String = TextBox3.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextBox3.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TextBox3.Text.Length - 1
            Letter = TextBox3.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TextBox3.Text = theText
        TextBox3.Select(SelectionIndex - Change, 0)

        'If TextBox1.Focused = True Then
        '    TextBox2.Text = ""
        '    ComboBox1.Text = ""
        'ElseIf TextBox2.Focused = True Then
        '    TextBox1.Text = ""
        '    ComboBox1.Text = ""
        'ElseIf ComboBox1.Focused = True Then
        '    TextBox1.Text = ""
        '    TextBox2.Text = ""
        'Else
        '    TextBox1.Text = ""
        '    TextBox2.Text = ""
        '    ComboBox1.Text = ""
        'End If

        'Dim dv As New DataView(dbdataset)
        'dv.RowFilter = String.Format("SerialNumber  LIKE'%{0}%'", TextBox3.Text)
        'main_datagrid.DataSource = dv

        Dim dv As New DataView(dbdataset)
        dv.RowFilter = String.Format("EquipmentName LIKE '%{0}%' and EquipmentNumber LIKE '%{1}%' and SerialNumber LIKE '%{2}%' and Branch LIKE '%{3}%'", TextBox1.Text, TextBox2.Text, TextBox3.Text, ComboBox1.Text)
        main_datagrid.DataSource = dv
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        'If TextBox1.Focused = True Then
        '    TextBox2.Text = ""
        '    TextBox3.Text = ""
        'ElseIf TextBox2.Focused = True Then
        '    TextBox1.Text = ""
        '    TextBox3.Text = ""
        'ElseIf TextBox3.Focused = True Then
        '    TextBox1.Text = ""
        '    TextBox2.Text = ""
        'Else
        '    TextBox1.Text = ""
        '    TextBox2.Text = ""
        '    TextBox3.Text = ""
        'End If

        'Dim dv As New DataView(dbdataset)
        'dv.RowFilter = String.Format("Branch  Like '%{0}%'", ComboBox1.Text)
        'main_datagrid.DataSource = dv
        Dim dv As New DataView(dbdataset)
        dv.RowFilter = String.Format("EquipmentName LIKE '%{0}%' and EquipmentNumber LIKE '%{1}%' and SerialNumber LIKE '%{2}%' and Branch LIKE '%{3}%'", TextBox1.Text, TextBox2.Text, TextBox3.Text, ComboBox1.Text)
        main_datagrid.DataSource = dv

    End Sub

    Private Sub btn_equipmentmanagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_equipmentmanagement.Click
        Frm_EquipmentManagement.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        MaintenanceStaffPrinting.ShowDialog()

    End Sub

    Private Sub main_datagrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles main_datagrid.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = main_datagrid.Rows(e.RowIndex)

            Device.equipnum = row.Cells(0).Value.ToString


            Device.equipname = row.Cells(1).Value.ToString

            Device.equipmodel = row.Cells(2).Value.ToString

            Device.equipserial = row.Cells(3).Value.ToString

            Device.equiplocation = row.Cells(4).Value.ToString

            Device.equipdatepurchase = row.Cells(5).Value.ToString

            Device.equipprice = row.Cells(6).Value.ToString

            Device.equipbranch = row.Cells(7).Value.ToString

            Device.equipmaintenancesched = row.Cells(8).Value.ToString

            Device.equippersonincharge = row.Cells(9).Value.ToString

            Me.ShowInTaskbar = False

            Device.ShowDialog()
        End If
    End Sub

    Private Sub btn_activitylog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_activitylog.Click
        ActivityLog.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        About.ShowDialog()
    End Sub
    Private Sub MarqueeText()
        Do
            Dim a As Integer = 1290
            Label_MarqueeDevelopers.Location = New Point(a, 611)
            Do Until a = -1300 Or Me.IsDisposed

                Label_MarqueeDevelopers.Location = New Point(a, 611)
                a -= 1
                Thread.Sleep(5)
            Loop
        Loop
    End Sub
End Class