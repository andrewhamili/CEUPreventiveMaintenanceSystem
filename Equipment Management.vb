Imports MySql.Data.MySqlClient
Imports MetroFramework

Public Class Frm_EquipmentManagement
    Dim ds As New DataSet
    
    Dim dbDataSet As New DataTable
    Dim svYN As System.Windows.Forms.DialogResult
    Dim addYN As System.Windows.Forms.DialogResult
    Dim editYN As System.Windows.Forms.DialogResult
    Dim cancelYN As System.Windows.Forms.DialogResult
    Dim updateYN As System.Windows.Forms.DialogResult
    Dim deleteYN As System.Windows.Forms.DialogResult
    Dim doneYN As System.Windows.Forms.DialogResult

    Public addevicependingRowCounter As Integer
    Public charactersAllowed As String = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"
    Public editmode As Boolean = False
    Private Sub Equipmentmanagement_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Load_EquipmentNames()
        
        Load_users()
        Load_Table()
        BackgroundWorker_Loaders.RunWorkerAsync()

        DateTimePicker1.Text = Date.Now
        txt_branch_eq.Text = ""
        txt_date_eq.Text = ""
        txt_dev_model.Text = ""
        txt_equip_name.Text = ""
        txt_equip_no.Text = ""
        txt_location.Text = ""
        txt_owner.Text = ""
        txt_price_eq.Text = ""
        txt_serial_no.Text = ""
        txt_branch_eq.Enabled = False
        txt_date_eq.Enabled = False
        txt_dev_model.Enabled = False
        txt_equip_name.Enabled = False
        txt_equip_no.Enabled = False
        txt_location.Enabled = False
        txt_owner.Enabled = False
        txt_price_eq.Enabled = False
        txt_serial_no.Enabled = False
        txt_maintenance_sched.Enabled = False
        txt_personincharge.Enabled = False

        btn_save.Hide()
        btn_save2.Hide()
        btn_cancel.Hide()
        btn_clear.Hide()
        Me.TopMost = True
        Me.TopMost = False
    End Sub



    Public Sub Load_Table()

        'Dim equipmentnumber As String
        'Dim equipmentname As String
        'Dim equipmentmodel As String
        'Dim equipmentserial As String
        'Dim equipmentlocation As String
        'Dim equipmentowner As String
        'Dim equipmentdatepurchase As Date
        'Dim equipmentprice As Decimal
        'Dim equipmentbranch As String
        'Dim equipmentmaintenancesched As String
        'Dim equipmentpersonincharge As String

        'If MySQLConn.State = ConnectionState.Open Then
        '    MySQLConn.Close()
        'End If

        'disp_data_eq.Rows.Clear()
        'Try
        '    MySQLConn.Open()
        '    Dim Query As String
        '    Query = "SELECT * FROM equipmentlist order by dateadded DESC"
        '    comm = New MySqlCommand(Query, MySQLConn)
        '    reader = comm.ExecuteReader
        '    Dim counter As Integer
        '    Dim tempprice As Decimal
        '    counter = 0
        '    While reader.Read
        '        equipmentnumber = reader.GetString("equipmentnumber")
        '        equipmentname = reader.GetString("equipmentname")
        '        equipmentmodel = reader.GetString("equipmentmodel")
        '        equipmentserial = reader.GetString("equipmentserial")
        '        equipmentlocation = reader.GetString("equipmentlocation")
        '        equipmentowner = reader.GetString("equipmentowner")
        '        tempprice = reader.GetString("equipmentprice")
        '        equipmentprice = reader.GetDecimal("equipmentprice")
        '        equipmentbranch = reader.GetString("equipmentbranch")
        '        equipmentmaintenancesched = reader.GetString("maintenancesched")
        '        equipmentpersonincharge = reader.GetString("personincharge")
        '        equipmentdatepurchase = Format(CDate(reader.GetString("equipmentdatepurchase")), "MM/dd/yyyy")
        '        DateTimePicker1.Value = Format(CDate(reader.GetString("dateadded")), "yyyy/MM/dd")

        '        txt_equip_name.AutoCompleteCustomSource.Remove(reader.GetString("equipmentname"))
        '        txt_equip_name.AutoCompleteCustomSource.Add(reader.GetString("equipmentname"))

        '        txt_dev_model.AutoCompleteCustomSource.Remove(reader.GetString("equipmentmodel"))
        '        txt_dev_model.AutoCompleteCustomSource.Add(reader.GetString("equipmentmodel"))

        '        txt_location.AutoCompleteCustomSource.Remove(reader.GetString("equipmentlocation"))
        '        txt_location.AutoCompleteCustomSource.Add(reader.GetString("equipmentlocation"))

        '        txt_owner.AutoCompleteCustomSource.Remove(reader.GetString("equipmentowner"))
        '        txt_owner.AutoCompleteCustomSource.Add(reader.GetString("equipmentowner"))

        '        With disp_data_eq
        '            .Rows.Add()
        '            .Rows(counter).Cells("equipmentnumber").Value = equipmentnumber
        '            .Rows(counter).Cells("equipmentname").Value = equipmentname
        '            .Rows(counter).Cells("equipmentmodel").Value = equipmentmodel
        '            .Rows(counter).Cells("equipmentserial").Value = equipmentserial
        '            .Rows(counter).Cells("equipmentlocation").Value = equipmentlocation
        '            .Rows(counter).Cells("equipmentowner").Value = equipmentowner
        '            .Rows(counter).Cells("equipmentprice").Value = tempprice.ToString("#,##0.00")
        '            .Rows(counter).Cells("equipmentbranch").Value = equipmentbranch
        '            .Rows(counter).Cells("equipmentdate").Value = Format(equipmentdatepurchase, "MM/dd/yyyy")
        '            .Rows(counter).Cells("dateadded").Value = Format(DateTimePicker1.Value, "MM/dd/yyyy")
        '            .Rows(counter).Cells("maintenancesched").Value = equipmentmaintenancesched
        '            .Rows(counter).Cells("personincharge").Value = equipmentpersonincharge
        '        End With

        '        counter += 1

        '    End While
        '    'txt_branch_eq.Text = ""
        '    'txt_date_eq.Text = ""
        '    'txt_dev_model.Text = ""
        '    'txt_equip_name.Text = ""
        '    'txt_equip_no.Text = ""
        '    'txt_location.Text = ""
        '    'txt_price_eq.Text = ""
        '    'txt_serial_no.Text = ""

        '    MySQLConn.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        '    MySQLConn.Dispose()
        'End Try

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        dbDataSet.Clear()
        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim query As String

        Try

            MySQLConn.Open()
            query = "SELECT equipmentnumber as 'EquipmentNumber', equipmentname as 'EquipmentName', equipmentmodel as 'Equipment Model', equipmentserial as 'SerialNumber', equipmentlocation as 'Location', equipmentowner as 'Equipment Owner', equipmentdatepurchase as 'Date purchased', format(equipmentprice, 2) as 'Price', equipmentbranch as 'Branch', maintenancesched as 'Maintenance Schedule', personincharge as 'Person in Charge' FROM equipmentlist ORDER BY dateadded DESC"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbDataSet)
            bsource.DataSource = dbDataSet
            disp_data_eq.DataSource = bsource
            adapter.Update(dbDataSet)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try


    End Sub


    Private Sub btn_add_Click(sender As System.Object, e As System.EventArgs) Handles btn_add.Click

        addYN = MetroMessageBox.Show(Me, "Are you sure you want to Create? ", "Create Student Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If addYN = MsgBoxResult.Yes Then

            btn_add.Enabled = False
            btn_clear.Show()
            btn_save.Show()
            btn_cancel.Show()
            btn_save.Enabled = True
            btn_clear.Enabled = True
            btn_cancel.Enabled = True
            txt_branch_eq.Enabled = True
            txt_date_eq.Enabled = True
            txt_dev_model.Enabled = True
            txt_equip_name.Enabled = True
            txt_equip_no.Enabled = True
            txt_location.Enabled = True
            txt_owner.Enabled = True
            txt_price_eq.Enabled = True
            txt_serial_no.Enabled = True
            txt_maintenance_sched.Enabled = True
            txt_personincharge.Enabled = True
            txt_equip_no.Focus()
            editmode = True

        End If
    End Sub

    Private Sub btn_save_Click(sender As System.Object, e As System.EventArgs) Handles btn_save.Click

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        Dim query As String


        svYN = MetroMessageBox.Show(Me, "Are you sure you want to Register this Equipment Information? ", "Register Equipement Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If svYN = MsgBoxResult.Yes Then
            If txt_equip_no.Text = "" Or txt_serial_no.Text = "" Or txt_branch_eq.Text = "" Or txt_dev_model.Text = "" Or txt_location.Text = "" Or txt_owner.Text = "" Or txt_price_eq.Text = "" Or txt_equip_name.Text = "" Or txt_maintenance_sched.Text = "" Or txt_personincharge.Text = "" Then
                MetroMessageBox.Show(Me, "All fileds are required to be filled up!", "Register Equipement Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Try
                    MySQLConn.Open()
                    query = "SELECT * FROM equipmentlist where equipmentserial=@equipmentserial"
                    comm = New MySqlCommand(query, MySQLConn)
                    comm.Parameters.AddWithValue("equipmentserial", txt_serial_no.Text)
                    reader = comm.ExecuteReader
                    Dim count As Integer

                    While reader.Read
                        count += 1
                    End While

                    If count > 0 Then
                        MetroMessageBox.Show(Me, "The Serial Number you have entered has been assigned to a device and cannot be assigned to another.", "Register Equipement Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        MySQLConn.Close()
                        MySQLConn.Open()
                        query = "INSERT INTO equipmentlist(equipmentnumber, equipmentname, equipmentmodel, equipmentserial, equipmentlocation, equipmentowner, equipmentdatepurchase, equipmentprice, equipmentbranch, maintenancesched, personincharge, dateadded) VALUES(@equipmentnumber, @equipmentname, @equipmentmodel, @equipmentserial, @equipmentlocation, @equipmentowner, @equipmentdatepurchase, @equipmentprice, @equipmentbranch, @maintenancesched, @personincharge, @dateadded)"
                        comm = New MySqlCommand(query, MySQLConn)
                        comm.Parameters.AddWithValue("equipmentname", txt_equip_name.Text)
                        comm.Parameters.AddWithValue("equipmentnumber", txt_equip_no.Text)
                        comm.Parameters.AddWithValue("equipmentmodel", txt_dev_model.Text)
                        comm.Parameters.AddWithValue("equipmentserial", txt_serial_no.Text)
                        comm.Parameters.AddWithValue("equipmentlocation", txt_location.Text)
                        comm.Parameters.AddWithValue("equipmentowner", txt_owner.Text)
                        comm.Parameters.AddWithValue("equipmentdatepurchase", Format(CDate(txt_date_eq.Value), "yyyy/MM/dd"))
                        comm.Parameters.AddWithValue("equipmentprice", txt_price_eq.Text)
                        comm.Parameters.AddWithValue("equipmentbranch", txt_branch_eq.Text)
                        comm.Parameters.AddWithValue("maintenancesched", txt_maintenance_sched.Text)
                        comm.Parameters.AddWithValue("personincharge", txt_personincharge.Text)
                        comm.Parameters.AddWithValue("dateadded", Date.Now.ToString("yyyy/MM/dd"))
                        reader = comm.ExecuteReader

                        MySQLConn.Close()
                        MessageBox.Show("Register Complete!")
                        MySQLConn.Open()
                        query = "INSERT INTO systemlog values(@datetoday, @logaction, @deviceserial, 'NONE', @username, '-', '-', '-', '-', '-', '-', '2000-01-01', '-', '-', '-', '-')"
                        comm = New MySqlCommand(query, MySQLConn)
                        comm.Parameters.AddWithValue("datetoday", Date.Now.ToString("yyyy/MM/dd"))
                        comm.Parameters.AddWithValue("logaction", "ADD")
                        comm.Parameters.AddWithValue("deviceserial", txt_serial_no.Text)
                        comm.Parameters.AddWithValue("username", username)
                        reader = comm.ExecuteReader
                        MySQLConn.Close()

                        MessageBox.Show("Log Saved")



                        Load_Table()

                    End If


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        cancelYN = MetroMessageBox.Show(Me, "Are you sure you want to Cancel? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If cancelYN = MsgBoxResult.Yes Then
            btn_save.Hide()
            btn_save2.Hide()
            btn_cancel.Hide()
            btn_clear.Hide()
            btn_add.Enabled = True
            btn_delete.Enabled = False
            txt_branch_eq.Text = ""
            txt_maintenance_sched.Text = ""
            txt_dev_model.Text = ""
            txt_equip_name.Text = ""
            txt_equip_no.Text = ""
            txt_location.Text = ""
            txt_owner.Text = ""
            txt_price_eq.Text = ""
            txt_serial_no.Text = ""
            txt_branch_eq.Enabled = False
            txt_date_eq.Enabled = False
            txt_dev_model.Enabled = False
            txt_equip_name.Enabled = False
            txt_equip_no.Enabled = False
            txt_location.Enabled = False
            txt_owner.Enabled = False
            txt_price_eq.Enabled = False
            txt_serial_no.Enabled = False
            txt_maintenance_sched.Enabled = False
            txt_personincharge.Enabled = False
            editmode = False


        End If
    End Sub

    Private Sub btn_save2_Click(sender As System.Object, e As System.EventArgs) Handles btn_save2.Click

        Dim origserial As String
        Dim query As String

        origserial = tempequipmentserial
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        Dim devicechange As String

        If txt_equip_no.Text <> tempequipmentnumber Then
            devicechange = devicechange + ",NUMBER"

        End If

        If txt_equip_name.Text <> tempequipmentname Then
            devicechange = devicechange + ",NAME"
        End If

        If txt_dev_model.Text <> tempequipmentmodel Then
            devicechange = devicechange + ",MODEL"
        End If

        If txt_serial_no.Text <> tempequipmentserial Then
            devicechange = devicechange + ",SERIAL"
        End If

        If txt_location.Text <> tempequipmentlocation Then
            devicechange = devicechange + ",LOCATION"
        End If

        If txt_owner.Text <> tempequipmentowner Then
            devicechange = devicechange + ", OWNER"
        End If

        If txt_date_eq.Value <> tempequipmentdatepurchase Then
            devicechange = devicechange + ",DATE"
        End If

        If txt_price_eq.Text <> tempprice Then
            devicechange = devicechange + ",PRICE"
        End If

        If txt_branch_eq.Text <> tempbranch Then
            devicechange = devicechange + ",BRANCH"
        End If

        If txt_maintenance_sched.Text <> tempmaintenancesched Then
            devicechange = devicechange + ",SCHED"
        End If

        If txt_personincharge.Text <> temppersonincharge Then
            devicechange = devicechange + ", PERSON"
        End If


        If devicechange = "" Then
            MsgBox("No changes have been made")

            txt_branch_eq.Text = ""
            txt_date_eq.Text = ""
            txt_dev_model.Text = ""
            txt_equip_name.Text = ""
            txt_equip_no.Text = ""
            txt_location.Text = ""
            txt_price_eq.Text = ""
            txt_serial_no.Text = ""

            Load_Table()

            txt_branch_eq.Text = ""
            txt_date_eq.Text = ""
            txt_dev_model.Text = ""
            txt_equip_name.Text = ""
            txt_equip_no.Text = ""
            txt_location.Text = ""
            txt_owner.Text = ""
            txt_price_eq.Text = ""
            txt_serial_no.Text = ""

            txt_branch_eq.Enabled = False
            txt_date_eq.Enabled = False
            txt_dev_model.Enabled = False
            txt_equip_name.Enabled = False
            txt_equip_no.Enabled = False
            txt_location.Enabled = False
            txt_owner.Enabled = False
            txt_price_eq.Enabled = False
            txt_serial_no.Enabled = False
            txt_personincharge.Enabled = False

            btn_save.Hide()
            btn_save2.Hide()
            btn_cancel.Hide()
            btn_clear.Hide()
            btn_add.Enabled = True
            btn_delete.Enabled = False

        ElseIf txt_serial_no.Text = origserial Then

            Try
                MySQLConn.Open()
                query = "UPDATE equipmentlist SET equipmentnumber=@equipmentnumber, equipmentname=@equipmentname, equipmentmodel=@equipmentmodel, equipmentserial=@equipmentserial, equipmentlocation=@equipmentlocation, equipmentowner=@equipmentowner, equipmentprice=@equipmentprice, equipmentdatepurchase=@equipmentdatepurchase, maintenancesched=@sched, personincharge=@personincharge, equipmentbranch=@equipmentbranch where equipmentserial=@origserial"
                comm = New MySqlCommand(query, MySQLConn)

                comm.Parameters.AddWithValue("equipmentname", txt_equip_name.Text)
                comm.Parameters.AddWithValue("equipmentnumber", txt_equip_no.Text)
                comm.Parameters.AddWithValue("equipmentmodel", txt_dev_model.Text)
                comm.Parameters.AddWithValue("equipmentserial", txt_serial_no.Text)
                comm.Parameters.AddWithValue("equipmentlocation", txt_location.Text)
                comm.Parameters.AddWithValue("equipmentowner", txt_owner.Text)
                comm.Parameters.AddWithValue("equipmentdatepurchase", Format(CDate(txt_date_eq.Value), "yyyy/MM/dd"))
                comm.Parameters.AddWithValue("equipmentprice", txt_price_eq.Text)
                comm.Parameters.AddWithValue("equipmentbranch", txt_branch_eq.Text)
                comm.Parameters.AddWithValue("sched", txt_maintenance_sched.Text)
                comm.Parameters.AddWithValue("personincharge", txt_personincharge.Text)
                comm.Parameters.AddWithValue("origserial", tempequipmentserial)

                reader = comm.ExecuteReader
                Load_Table()
                MySQLConn.Close()
                MessageBox.Show("Update Complete!")
                MySQLConn.Open()
                query = "INSERT INTO systemlog VALUES(@datetoday, 'EDIT', @deviceserial, @changes, @username, @equipmentnumber, @equipmentname, @equipmentmodel, @equipmentserial, @equipmentlocation, @equipmentowner, @equipmentdatepurchase, @equipmentprice, @equipmentbranch, @maintenancesched, @personincharge)"
                comm = New MySqlCommand(query, MySQLConn)
                comm.Parameters.AddWithValue("datetoday", Date.Now.ToString("yyyy/MM/dd"))
                comm.Parameters.AddWithValue("deviceserial", txt_serial_no.Text)
                comm.Parameters.AddWithValue("changes", devicechange)
                comm.Parameters.AddWithValue("username", username)
                comm.Parameters.AddWithValue("equipmentnumber", tempequipmentnumber)
                comm.Parameters.AddWithValue("equipmentname", tempequipmentname)
                comm.Parameters.AddWithValue("equipmentmodel", tempequipmentmodel)
                comm.Parameters.AddWithValue("equipmentserial", tempequipmentserial)
                comm.Parameters.AddWithValue("equipmentlocation", tempequipmentlocation)
                comm.Parameters.AddWithValue("equipmentowner", tempequipmentowner)
                comm.Parameters.AddWithValue("equipmentdatepurchase", tempequipmentdatepurchase)
                comm.Parameters.AddWithValue("equipmentprice", tempprice)
                comm.Parameters.AddWithValue("equipmentbranch", tempbranch)
                comm.Parameters.AddWithValue("maintenancesched", tempmaintenancesched)
                comm.Parameters.AddWithValue("personincharge", temppersonincharge)


                reader = comm.ExecuteReader
                MySQLConn.Close()
                MsgBox("Log Saved")

                If devicechange.Contains("SERIAL") Then
                    MySQLConn.Open()
                    query = "UPDATE maintenance SET equipmentserial=@newserial WHERE equipmentserial=@oldserial"
                    comm = New MySqlCommand(query, MySQLConn)
                    comm.Parameters.AddWithValue("newserial", txt_serial_no.Text)
                    comm.Parameters.AddWithValue("oldserial", origserial)
                    reader = comm.ExecuteReader
                    MySQLConn.Close()
                End If

                txt_branch_eq.Text = ""
                txt_date_eq.Text = ""
                txt_dev_model.Text = ""
                txt_equip_name.Text = ""
                txt_equip_no.Text = ""
                txt_location.Text = ""
                txt_owner.Text = ""
                txt_price_eq.Text = ""
                txt_serial_no.Text = ""

                txt_branch_eq.Enabled = False
                txt_date_eq.Enabled = False
                txt_dev_model.Enabled = False
                txt_equip_name.Enabled = False
                txt_equip_no.Enabled = False
                txt_location.Enabled = False
                txt_owner.Enabled = False
                txt_price_eq.Enabled = False
                txt_serial_no.Enabled = False
                txt_personincharge.Enabled = False

                btn_save.Hide()
                btn_save2.Hide()
                btn_cancel.Hide()
                btn_clear.Hide()
                btn_add.Enabled = True
                btn_delete.Enabled = False
                editmode = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MySQLConn.Close()
            Try
                MySQLConn.Open()
                query = "SELECT * FROM equipmentlist where equipmentserial=@serial"
                comm = New MySqlCommand(query, MySQLConn)
                comm.Parameters.AddWithValue("serial", txt_serial_no.Text)
                reader = comm.ExecuteReader
                Dim count As Integer
                While reader.Read
                    count = count + 1
                End While
                If count > 0 Then

                    MsgBox("Duplicate serial")
                Else

                    MySQLConn.Close()
                    MySQLConn.Open()
                    query = "UPDATE equipmentlist  SET equipmentnumber=@equipmentnumber, equipmentname=@equipmentname, equipmentmodel=@equipmentmodel, equipmentserial=@equipmentserial, equipmentlocation=@equipmentlocation, equipmentowner=@equipmentowner, equipmentprice=@equipmentprice, equipmentdatepurchase=@equipmentdatepurchase, equipmentbranch=@equipmentbranch personincharge=@personincharge where equipmentserial=@origserial"
                    comm = New MySqlCommand(query, MySQLConn)

                    comm.Parameters.AddWithValue("equipmentname", txt_equip_name.Text)
                    comm.Parameters.AddWithValue("equipmentnumber", txt_equip_no.Text)
                    comm.Parameters.AddWithValue("equipmentmodel", txt_dev_model.Text)
                    comm.Parameters.AddWithValue("equipmentserial", txt_serial_no.Text)
                    comm.Parameters.AddWithValue("equipmentlocation", txt_location.Text)
                    comm.Parameters.AddWithValue("equipmentowner", txt_owner.Text)
                    comm.Parameters.AddWithValue("equipmentdatepurchase", Format(CDate(txt_date_eq.Value), "yyyy/MM/dd"))
                    comm.Parameters.AddWithValue("equipmentprice", txt_price_eq.Text)
                    comm.Parameters.AddWithValue("equipmentbranch", txt_branch_eq.Text)
                    comm.Parameters.AddWithValue("origserial", tempequipmentserial)
                    comm.Parameters.AddWithValue("personincharge", txt_personincharge.Text)

                    reader = comm.ExecuteReader

                    Load_Table()



                    MySQLConn.Close()
                    MessageBox.Show("Update Complete!")
                    MySQLConn.Open()
                    query = "INSERT INTO systemlog VALUES(@datetoday, 'EDIT', @deviceserial, @changes, @username, @equipmentnumber, @equipmentname, @equipmentmodel, @equipmentserial, @equipmentlocation, @equipmentowner, @equipmentdatepurchase, @equipmentprice, @equipmentbranch, @maintenancesched, @personincharge)"
                    comm = New MySqlCommand(query, MySQLConn)
                    comm.Parameters.AddWithValue("datetoday", Date.Now.ToString("yyyy/MM/dd"))
                    comm.Parameters.AddWithValue("deviceserial", txt_serial_no.Text)
                    comm.Parameters.AddWithValue("changes", devicechange)
                    comm.Parameters.AddWithValue("username", username)
                    comm.Parameters.AddWithValue("equipmentnumber", tempequipmentnumber)
                    comm.Parameters.AddWithValue("equipmentname", tempequipmentname)
                    comm.Parameters.AddWithValue("equipmentmodel", tempequipmentmodel)
                    comm.Parameters.AddWithValue("equipmentserial", tempequipmentserial)
                    comm.Parameters.AddWithValue("equipmentlocation", tempequipmentlocation)
                    comm.Parameters.AddWithValue("equipmentowner", tempequipmentowner)
                    comm.Parameters.AddWithValue("equipmentdatepurchase", tempequipmentdatepurchase)
                    comm.Parameters.AddWithValue("equipmentprice", tempprice)
                    comm.Parameters.AddWithValue("equipmentbranch", tempbranch)
                    comm.Parameters.AddWithValue("maintenancesched", tempmaintenancesched)
                    comm.Parameters.AddWithValue("personincharge", temppersonincharge)

                    reader = comm.ExecuteReader
                    MySQLConn.Close()
                    MsgBox("Log Saved")
                    If devicechange.Contains("SERIAL") Then
                        MySQLConn.Open()
                        query = "UPDATE maintenance SET equipmentserial=@newserial WHERE equipmentserial=@oldserial"
                        comm = New MySqlCommand(query, MySQLConn)
                        comm.Parameters.AddWithValue("newserial", txt_serial_no.Text)
                        comm.Parameters.AddWithValue("oldserial", origserial)
                        reader = comm.ExecuteReader
                        MySQLConn.Close()
                    End If
                    


                    txt_branch_eq.Text = ""
                    txt_date_eq.Text = ""
                    txt_dev_model.Text = ""
                    txt_equip_name.Text = ""
                    txt_equip_no.Text = ""
                    txt_location.Text = ""
                    txt_price_eq.Text = ""
                    txt_serial_no.Text = ""

                    txt_branch_eq.Enabled = False
                    txt_date_eq.Enabled = False
                    txt_dev_model.Enabled = False
                    txt_equip_name.Enabled = False
                    txt_equip_no.Enabled = False
                    txt_location.Enabled = False
                    txt_price_eq.Enabled = False
                    txt_serial_no.Enabled = False
                    txt_personincharge.Enabled = False

                    btn_save.Hide()
                    btn_save2.Hide()
                    btn_cancel.Hide()
                    btn_clear.Hide()
                    btn_add.Enabled = True
                    btn_delete.Enabled = False
                    editmode = False

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub Frm_EquipmentManagement_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        btn_mlclose_Click()
    End Sub
    Private Sub btn_delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_delete.Click

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        deleteYN = MetroMessageBox.Show(Me, "Are you sure you want to Delete ? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If deleteYN = MsgBoxResult.Yes Then
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "DELETE FROM equipmentlist WHERE equipmentserial=@equipmentserial"
                comm = New MySqlCommand(Query, MySQLConn)
                comm.Parameters.AddWithValue("equipmentserial", txt_serial_no.Text)
                reader = comm.ExecuteReader

                MetroMessageBox.Show(Me, "Delete Complete!", "Delete")
                MySQLConn.Close()
                MySQLConn.Open()
                Query = "INSERT INTO systemlog VALUES(@datetoday, 'DELETE', @deviceserial, 'NONE', @username, @equipmentnumber, @equipmentname, @equipmentmodel, @equipmentserial, @equipmentlocation, @equipmentowner, @equipmentdatepurchase, @equipmentprice, @equipmentbranch, @maintenancesched, @personincharge)"
                comm = New MySqlCommand(Query, MySQLConn)
                comm.Parameters.AddWithValue("datetoday", Date.Now.ToString("yyyy/MM/dd"))
                comm.Parameters.AddWithValue("deviceserial", txt_serial_no.Text)
                comm.Parameters.AddWithValue("username", username)
                comm.Parameters.AddWithValue("equipmentnumber", tempequipmentnumber)
                comm.Parameters.AddWithValue("equipmentname", tempequipmentname)
                comm.Parameters.AddWithValue("equipmentmodel", tempequipmentmodel)
                comm.Parameters.AddWithValue("equipmentserial", tempequipmentserial)
                comm.Parameters.AddWithValue("equipmentlocation", tempequipmentlocation)
                comm.Parameters.AddWithValue("equipmentowner", tempequipmentowner)
                comm.Parameters.AddWithValue("equipmentdatepurchase", tempequipmentdatepurchase)
                comm.Parameters.AddWithValue("equipmentprice", tempprice)
                comm.Parameters.AddWithValue("equipmentbranch", tempbranch)
                comm.Parameters.AddWithValue("maintenancesched", tempmaintenancesched)
                comm.Parameters.AddWithValue("personincharge", txt_personincharge.Text)
                reader = comm.ExecuteReader
                MySQLConn.Close()
                MsgBox("Log Saved")
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()

            End Try

            Load_Table()

            btn_cancel.Hide()
            txt_branch_eq.Text = ""
            txt_dev_model.Text = ""
            txt_equip_name.Text = ""
            txt_equip_no.Text = ""
            txt_location.Text = ""
            txt_price_eq.Text = ""
            txt_serial_no.Text = ""

            btn_cancel.Hide()
            btn_save.Hide()
            btn_save2.Hide()
            btn_cancel.Hide()
            btn_clear.Hide()
            btn_add.Enabled = True
            btn_delete.Enabled = False
            txt_branch_eq.Enabled = False
            txt_date_eq.Enabled = False
            txt_dev_model.Enabled = False
            txt_equip_name.Enabled = False
            txt_equip_no.Enabled = False
            txt_location.Enabled = False
            txt_owner.Enabled = False
            txt_price_eq.Enabled = False
            txt_serial_no.Enabled = False
            txt_personincharge.Enabled = False
            editmode = False

        End If
    End Sub

    Private Sub btn_done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        doneYN = MetroMessageBox.Show(Me, "Are you done storing information? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If doneYN = MsgBoxResult.Yes Then
            btn_cancel.Hide()
            btn_save.Hide()
            btn_save2.Hide()
            btn_cancel.Hide()
            btn_clear.Hide()
            btn_add.Enabled = True
            btn_delete.Enabled = False
            txt_branch_eq.Text = ""
            txt_dev_model.Text = ""
            txt_equip_name.Text = ""
            txt_equip_no.Text = ""
            txt_location.Text = ""
            txt_price_eq.Text = ""
            txt_serial_no.Text = ""
            txt_branch_eq.Enabled = False
            txt_date_eq.Enabled = False
            txt_dev_model.Enabled = False
            txt_equip_name.Enabled = False
            txt_equip_no.Enabled = False
            txt_location.Enabled = False
            txt_price_eq.Enabled = False
            txt_serial_no.Enabled = False
        End If
    End Sub

    Private Sub btn_mlclose_Click() Handles btn_mlclose.Click
        If editmode = True Then
            Dim ans As Integer
            ans = MsgBox("You are currently in the Device Add or Edit Mode, are you sure  you want to exit now? Clicking YES will discard all unsaved changes.", MsgBoxStyle.YesNo, "Exiting...")

            If ans = 6 Then
                Me.Dispose()
                Frm_Main.dbdataset.Clear()
                Frm_Main.load_table()
                editmode = False
            End If
        Else
            Me.Dispose()
            Frm_Main.dbdataset.Clear()
            Frm_Main.load_table()
        End If


    End Sub

    Private Sub btn_mlminimize_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        txt_branch_eq.Text = ""
        txt_maintenance_sched.Text = ""
        txt_dev_model.Text = ""
        txt_equip_name.Text = ""
        txt_equip_no.Text = ""
        txt_location.Text = ""
        txt_owner.Text = ""
        txt_price_eq.Text = ""
        txt_serial_no.Text = ""
    End Sub

    Private Sub txt_price_eq_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_price_eq.KeyPress

        If txt_price_eq.Text.Contains(".") Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        Else
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If


    End Sub

    Private Sub txt_price_eq_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txt_price_eq.PreviewKeyDown
        If e.KeyCode = Keys.Back Then
            If txt_price_eq.Text.Length > 0 Then
                txt_price_eq.Text = txt_price_eq.Text.Substring(0, txt_price_eq.Text.Length - 1)
                txt_price_eq.Select(txt_price_eq.Text.Length, 0)
            End If

        End If
    End Sub

    Public Sub Load_users()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        Dim query As String
        Dim fnamelist As String
        Dim lnamelist As String

        MySQLConn.ConnectionString = connstring
        
        Try
            MySQLConn.Open()
            query = "SELECT * FROM userlist where username!='hamili1308215@ceu.edu.ph'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer
            While reader.Read
                fnamelist = reader.GetString("fname")
                lnamelist = reader.GetString("lname")
                txt_personincharge.Items.Remove(fnamelist + " " + lnamelist)
                txt_personincharge.Items.Add(fnamelist + " " + lnamelist)
            End While
        Catch ex As Exception

        End Try

    End Sub

    Private Sub disp_data_eq_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles disp_data_eq.CellDoubleClick
        editYN = MetroMessageBox.Show(Me, "Are you sure you want to Edit this Information? ", "Edit Equipment Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If editYN = MsgBoxResult.Yes Then


            Dim comma As String = ","
            Dim Currency As String = "Php."
            Dim RemoveCommaOnPrice As String
            Dim price As String
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = disp_data_eq.Rows(e.RowIndex)

                txt_equip_no.Text = row.Cells(0).Value.ToString
                tempequipmentnumber = row.Cells(0).Value.ToString


                txt_equip_name.Text = row.Cells(1).Value.ToString
                tempequipmentname = row.Cells(1).Value.ToString

                txt_dev_model.Text = row.Cells(2).Value.ToString
                tempequipmentmodel = row.Cells(2).Value.ToString

                txt_serial_no.Text = row.Cells(3).Value.ToString
                tempequipmentserial = row.Cells(3).Value.ToString

                txt_location.Text = row.Cells(4).Value.ToString
                tempequipmentlocation = row.Cells(4).Value.ToString

                txt_owner.Text = row.Cells(5).Value.ToString
                tempequipmentowner = row.Cells(5).Value.ToString

                txt_date_eq.Value = row.Cells(6).Value
                tempequipmentdatepurchase = row.Cells(6).Value

                RemoveCommaOnPrice = row.Cells(7).Value.ToString.Replace(comma, "")
                price = RemoveCommaOnPrice.Replace(Currency, "")
                tempprice = price
                txt_price_eq.Text = price

                txt_branch_eq.Text = row.Cells(8).Value.ToString
                tempbranch = row.Cells(8).Value.ToString

                txt_maintenance_sched.Text = row.Cells(9).Value.ToString
                tempmaintenancesched = row.Cells(9).Value.ToString

                txt_personincharge.Text = row.Cells(10).Value.ToString
                temppersonincharge = row.Cells(10).Value.ToString

                btn_clear.Enabled = False
                btn_add.Enabled = False
                btn_delete.Enabled = True
                btn_cancel.Hide()
                btn_cancel.Show()
                btn_save2.Show()
                btn_save2.Enabled = True
                btn_cancel.Enabled = True
                txt_branch_eq.Enabled = True
                txt_date_eq.Enabled = True
                txt_dev_model.Enabled = True
                txt_equip_name.Enabled = True
                txt_equip_no.Enabled = True
                txt_location.Enabled = True
                txt_owner.Enabled = True
                txt_price_eq.Enabled = True
                txt_serial_no.Enabled = True
                txt_maintenance_sched.Enabled = True
                txt_personincharge.Enabled = True
                editmode = True


            End If



        End If
    End Sub

    Private Sub txt_search_equipmentname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search_equipmentname.TextChanged
        Dim theText As String = txt_search_equipmentname.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = txt_search_equipmentname.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To txt_search_equipmentname.Text.Length - 1
            Letter = txt_search_equipmentname.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        txt_search_equipmentname.Text = theText
        txt_search_equipmentname.Select(SelectionIndex - Change, 0)

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

        Dim dv As New DataView(dbDataSet)
        dv.RowFilter = String.Format("EquipmentName  Like '%{0}%'", txt_search_equipmentname.Text)
        disp_data_eq.DataSource = dv
    End Sub
    Public Sub Load_EquipmentNames()
        txt_equip_name.AutoCompleteCustomSource.Clear()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String
        Try
            MySQLConn.Open()
            query = "SELECT DISTINCT equipmentname FROM equipmentlist"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                txt_equip_name.AutoCompleteCustomSource.Add(reader.GetString("equipmentname"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
    Public Sub Load_BrandAndModel()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String
        Try
            MySQLConn.Open()
            query = "SELECT DISTINCT equipmentmodel FROM equipmentlist"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                txt_dev_model.AutoCompleteCustomSource.Remove(reader.GetString("equipmentmodel"))
                txt_dev_model.AutoCompleteCustomSource.Add(reader.GetString("equipmentmodel"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
    Public Sub Load_EquipemntLocations()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String
        Try
            MySQLConn.Open()
            query = "SELECT DISTINCT equipmentlocation FROM equipmentlist"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                txt_location.AutoCompleteCustomSource.Remove(reader.GetString("equipmentlocation"))
                txt_location.AutoCompleteCustomSource.Add(reader.GetString("equipmentlocation"))
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker_Loaders_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_Loaders.DoWork
        Load_EquipemntLocations()
        Load_BrandAndModel()
    End Sub
End Class