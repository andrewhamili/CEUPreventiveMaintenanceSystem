<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EquipmentManagement
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_EquipmentManagement))
        Me.equip_n_l = New MetroFramework.Controls.MetroLabel()
        Me.equip_N = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txt_branch_eq = New MetroFramework.Controls.MetroComboBox()
        Me.btn_save = New MetroFramework.Controls.MetroButton()
        Me.btn_add = New MetroFramework.Controls.MetroButton()
        Me.btn_cancel = New MetroFramework.Controls.MetroButton()
        Me.btn_clear = New MetroFramework.Controls.MetroButton()
        Me.txt_equip_name = New System.Windows.Forms.TextBox()
        Me.txt_equip_no = New System.Windows.Forms.TextBox()
        Me.txt_dev_model = New System.Windows.Forms.TextBox()
        Me.txt_serial_no = New System.Windows.Forms.TextBox()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.txt_date_eq = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.disp_data_eq = New MetroFramework.Controls.MetroGrid()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btn_delete = New MetroFramework.Controls.MetroButton()
        Me.btn_save2 = New MetroFramework.Controls.MetroButton()
        Me.txt_price_eq = New System.Windows.Forms.TextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txt_maintenance_sched = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txt_owner = New System.Windows.Forms.TextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txt_personincharge = New MetroFramework.Controls.MetroComboBox()
        Me.btn_mlclose = New MetroFramework.Controls.MetroLink()
        Me.txt_search_equipmentname = New System.Windows.Forms.TextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.ProgressBarLoaders = New System.Windows.Forms.ProgressBar()
        Me.TimerProgressBarProgress = New System.Windows.Forms.Timer(Me.components)
        Me.txt_search_equipmentserial = New System.Windows.Forms.TextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.Button_Reload_data = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.disp_data_eq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'equip_n_l
        '
        Me.equip_n_l.AutoSize = True
        Me.equip_n_l.Location = New System.Drawing.Point(54, 160)
        Me.equip_n_l.Name = "equip_n_l"
        Me.equip_n_l.Size = New System.Drawing.Size(115, 19)
        Me.equip_n_l.TabIndex = 0
        Me.equip_n_l.Text = "Equipment Name:"
        '
        'equip_N
        '
        Me.equip_N.AutoSize = True
        Me.equip_N.Location = New System.Drawing.Point(40, 128)
        Me.equip_N.Name = "equip_N"
        Me.equip_N.Size = New System.Drawing.Size(128, 19)
        Me.equip_N.TabIndex = 1
        Me.equip_N.Text = "Equipment Number:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(53, 192)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(115, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Brand and Model:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(113, 231)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Serial #:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(108, 269)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Location:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(86, 345)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(96, 19)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "Date Acquired:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(-1, 388)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(194, 19)
        Me.MetroLabel5.TabIndex = 7
        Me.MetroLabel5.Text = "Unit Cost (in PHP currency only)"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(117, 430)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel6.TabIndex = 8
        Me.MetroLabel6.Text = "Branch"
        '
        'txt_branch_eq
        '
        Me.txt_branch_eq.FormattingEnabled = True
        Me.txt_branch_eq.ItemHeight = 23
        Me.txt_branch_eq.Items.AddRange(New Object() {"Manila", "Malolos", "Makati"})
        Me.txt_branch_eq.Location = New System.Drawing.Point(193, 426)
        Me.txt_branch_eq.Name = "txt_branch_eq"
        Me.txt_branch_eq.Size = New System.Drawing.Size(210, 29)
        Me.txt_branch_eq.TabIndex = 8
        Me.txt_branch_eq.UseSelectable = True
        '
        'btn_save
        '
        Me.btn_save.Enabled = False
        Me.btn_save.Location = New System.Drawing.Point(314, 613)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(115, 32)
        Me.btn_save.TabIndex = 19
        Me.btn_save.Text = "Save"
        Me.btn_save.UseSelectable = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(193, 613)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(115, 32)
        Me.btn_add.TabIndex = 20
        Me.btn_add.Text = "Add"
        Me.btn_add.UseSelectable = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Enabled = False
        Me.btn_cancel.Location = New System.Drawing.Point(260, 651)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(115, 32)
        Me.btn_cancel.TabIndex = 21
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseSelectable = True
        '
        'btn_clear
        '
        Me.btn_clear.Enabled = False
        Me.btn_clear.Location = New System.Drawing.Point(114, 651)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(115, 32)
        Me.btn_clear.TabIndex = 22
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseSelectable = True
        '
        'txt_equip_name
        '
        Me.txt_equip_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_equip_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_equip_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_equip_name.Location = New System.Drawing.Point(191, 160)
        Me.txt_equip_name.Name = "txt_equip_name"
        Me.txt_equip_name.Size = New System.Drawing.Size(210, 20)
        Me.txt_equip_name.TabIndex = 1
        '
        'txt_equip_no
        '
        Me.txt_equip_no.Location = New System.Drawing.Point(191, 128)
        Me.txt_equip_no.Name = "txt_equip_no"
        Me.txt_equip_no.Size = New System.Drawing.Size(210, 20)
        Me.txt_equip_no.TabIndex = 0
        '
        'txt_dev_model
        '
        Me.txt_dev_model.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_dev_model.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_dev_model.Location = New System.Drawing.Point(191, 192)
        Me.txt_dev_model.Name = "txt_dev_model"
        Me.txt_dev_model.Size = New System.Drawing.Size(210, 20)
        Me.txt_dev_model.TabIndex = 2
        '
        'txt_serial_no
        '
        Me.txt_serial_no.Location = New System.Drawing.Point(191, 231)
        Me.txt_serial_no.Name = "txt_serial_no"
        Me.txt_serial_no.Size = New System.Drawing.Size(210, 20)
        Me.txt_serial_no.TabIndex = 3
        '
        'txt_location
        '
        Me.txt_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_location.Location = New System.Drawing.Point(191, 269)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(210, 20)
        Me.txt_location.TabIndex = 4
        '
        'txt_date_eq
        '
        Me.txt_date_eq.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_date_eq.Location = New System.Drawing.Point(193, 345)
        Me.txt_date_eq.Name = "txt_date_eq"
        Me.txt_date_eq.Size = New System.Drawing.Size(210, 20)
        Me.txt_date_eq.TabIndex = 6
        Me.txt_date_eq.Value = New Date(2016, 6, 30, 19, 23, 25, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.disp_data_eq)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Location = New System.Drawing.Point(449, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(865, 514)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Existing Equipments"
        '
        'disp_data_eq
        '
        Me.disp_data_eq.AllowUserToAddRows = False
        Me.disp_data_eq.AllowUserToDeleteRows = False
        Me.disp_data_eq.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.disp_data_eq.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.disp_data_eq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.disp_data_eq.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.disp_data_eq.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.disp_data_eq.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.disp_data_eq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.disp_data_eq.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.disp_data_eq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.disp_data_eq.DefaultCellStyle = DataGridViewCellStyle3
        Me.disp_data_eq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.disp_data_eq.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.disp_data_eq.EnableHeadersVisualStyles = False
        Me.disp_data_eq.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.disp_data_eq.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.disp_data_eq.Location = New System.Drawing.Point(3, 16)
        Me.disp_data_eq.Name = "disp_data_eq"
        Me.disp_data_eq.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.disp_data_eq.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.disp_data_eq.RowHeadersVisible = False
        Me.disp_data_eq.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.disp_data_eq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.disp_data_eq.Size = New System.Drawing.Size(859, 495)
        Me.disp_data_eq.TabIndex = 31
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(86, 80)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(219, 20)
        Me.DateTimePicker1.TabIndex = 32
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.Location = New System.Drawing.Point(72, 613)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(115, 32)
        Me.btn_delete.TabIndex = 33
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseSelectable = True
        '
        'btn_save2
        '
        Me.btn_save2.Enabled = False
        Me.btn_save2.Location = New System.Drawing.Point(314, 613)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(115, 32)
        Me.btn_save2.TabIndex = 34
        Me.btn_save2.Text = "Save"
        Me.btn_save2.UseSelectable = True
        '
        'txt_price_eq
        '
        Me.txt_price_eq.Location = New System.Drawing.Point(193, 387)
        Me.txt_price_eq.MaxLength = 9
        Me.txt_price_eq.Name = "txt_price_eq"
        Me.txt_price_eq.Size = New System.Drawing.Size(210, 20)
        Me.txt_price_eq.TabIndex = 7
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(48, 494)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(139, 19)
        Me.MetroLabel7.TabIndex = 8
        Me.MetroLabel7.Text = "Maintenance Schedule"
        '
        'txt_maintenance_sched
        '
        Me.txt_maintenance_sched.FormattingEnabled = True
        Me.txt_maintenance_sched.ItemHeight = 23
        Me.txt_maintenance_sched.Items.AddRange(New Object() {"-", "Monthly", "Quarterly", "Semi-Annualy", "Annualy"})
        Me.txt_maintenance_sched.Location = New System.Drawing.Point(193, 484)
        Me.txt_maintenance_sched.Name = "txt_maintenance_sched"
        Me.txt_maintenance_sched.Size = New System.Drawing.Size(210, 29)
        Me.txt_maintenance_sched.TabIndex = 9
        Me.txt_maintenance_sched.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(121, 309)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel8.TabIndex = 5
        Me.MetroLabel8.Text = "Owner:"
        '
        'txt_owner
        '
        Me.txt_owner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_owner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_owner.Location = New System.Drawing.Point(191, 308)
        Me.txt_owner.Name = "txt_owner"
        Me.txt_owner.Size = New System.Drawing.Size(210, 20)
        Me.txt_owner.TabIndex = 5
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(48, 537)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(111, 19)
        Me.MetroLabel9.TabIndex = 8
        Me.MetroLabel9.Text = "Person-in-charge"
        '
        'txt_personincharge
        '
        Me.txt_personincharge.FormattingEnabled = True
        Me.txt_personincharge.ItemHeight = 23
        Me.txt_personincharge.Items.AddRange(New Object() {"-"})
        Me.txt_personincharge.Location = New System.Drawing.Point(193, 527)
        Me.txt_personincharge.Name = "txt_personincharge"
        Me.txt_personincharge.Size = New System.Drawing.Size(210, 29)
        Me.txt_personincharge.TabIndex = 10
        Me.txt_personincharge.UseSelectable = True
        '
        'btn_mlclose
        '
        Me.btn_mlclose.Image = Global.CEUPreventiveMaintenanceSystem.My.Resources.Resources.power_1
        Me.btn_mlclose.ImageSize = 32
        Me.btn_mlclose.Location = New System.Drawing.Point(1277, 18)
        Me.btn_mlclose.Name = "btn_mlclose"
        Me.btn_mlclose.NoFocusImage = Global.CEUPreventiveMaintenanceSystem.My.Resources.Resources.power_2
        Me.btn_mlclose.Size = New System.Drawing.Size(34, 33)
        Me.btn_mlclose.TabIndex = 37
        Me.btn_mlclose.UseSelectable = True
        '
        'txt_search_equipmentname
        '
        Me.txt_search_equipmentname.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txt_search_equipmentname.Location = New System.Drawing.Point(773, 86)
        Me.txt_search_equipmentname.Name = "txt_search_equipmentname"
        Me.txt_search_equipmentname.Size = New System.Drawing.Size(116, 23)
        Me.txt_search_equipmentname.TabIndex = 38
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(609, 90)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(158, 19)
        Me.MetroLabel10.TabIndex = 1
        Me.MetroLabel10.Text = "Search Equipment Name:"
        '
        'ProgressBarLoaders
        '
        Me.ProgressBarLoaders.Location = New System.Drawing.Point(449, 632)
        Me.ProgressBarLoaders.Name = "ProgressBarLoaders"
        Me.ProgressBarLoaders.Size = New System.Drawing.Size(865, 23)
        Me.ProgressBarLoaders.TabIndex = 39
        '
        'TimerProgressBarProgress
        '
        '
        'txt_search_equipmentserial
        '
        Me.txt_search_equipmentserial.Location = New System.Drawing.Point(1055, 89)
        Me.txt_search_equipmentserial.Name = "txt_search_equipmentserial"
        Me.txt_search_equipmentserial.Size = New System.Drawing.Size(116, 20)
        Me.txt_search_equipmentserial.TabIndex = 40
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(895, 90)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(154, 19)
        Me.MetroLabel11.TabIndex = 1
        Me.MetroLabel11.Text = "Search Equipment Serial:"
        '
        'Button_Reload_data
        '
        Me.Button_Reload_data.Location = New System.Drawing.Point(452, 77)
        Me.Button_Reload_data.Name = "Button_Reload_data"
        Me.Button_Reload_data.Size = New System.Drawing.Size(86, 29)
        Me.Button_Reload_data.TabIndex = 41
        Me.Button_Reload_data.Text = "Reload Data"
        Me.Button_Reload_data.UseSelectable = True
        '
        'Frm_EquipmentManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 696)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_Reload_data)
        Me.Controls.Add(Me.txt_search_equipmentserial)
        Me.Controls.Add(Me.ProgressBarLoaders)
        Me.Controls.Add(Me.btn_save2)
        Me.Controls.Add(Me.txt_search_equipmentname)
        Me.Controls.Add(Me.btn_mlclose)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_date_eq)
        Me.Controls.Add(Me.txt_price_eq)
        Me.Controls.Add(Me.txt_owner)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.txt_serial_no)
        Me.Controls.Add(Me.txt_dev_model)
        Me.Controls.Add(Me.txt_equip_no)
        Me.Controls.Add(Me.txt_equip_name)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_personincharge)
        Me.Controls.Add(Me.txt_maintenance_sched)
        Me.Controls.Add(Me.txt_branch_eq)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.equip_N)
        Me.Controls.Add(Me.equip_n_l)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_EquipmentManagement"
        Me.Text = "Equipment Management"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.disp_data_eq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_branch_eq As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txt_equip_name As TextBox
    Friend WithEvents txt_equip_no As TextBox
    Friend WithEvents txt_dev_model As TextBox
    Friend WithEvents txt_serial_no As TextBox
    Friend WithEvents txt_location As TextBox
    Friend WithEvents txt_date_eq As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents disp_data_eq As MetroFramework.Controls.MetroGrid
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_price_eq As System.Windows.Forms.TextBox
    Friend WithEvents txt_maintenance_sched As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txt_owner As System.Windows.Forms.TextBox
    Friend WithEvents txt_personincharge As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txt_search_equipmentname As System.Windows.Forms.TextBox
    Private WithEvents equip_n_l As MetroFramework.Controls.MetroLabel
    Private WithEvents equip_N As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Private WithEvents btn_save As MetroFramework.Controls.MetroButton
    Private WithEvents btn_add As MetroFramework.Controls.MetroButton
    Private WithEvents btn_cancel As MetroFramework.Controls.MetroButton
    Private WithEvents btn_clear As MetroFramework.Controls.MetroButton
    Private WithEvents btn_delete As MetroFramework.Controls.MetroButton
    Private WithEvents btn_save2 As MetroFramework.Controls.MetroButton
    Private WithEvents btn_mlclose As MetroFramework.Controls.MetroLink
    Private WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ProgressBarLoaders As System.Windows.Forms.ProgressBar
    Friend WithEvents TimerProgressBarProgress As System.Windows.Forms.Timer
    Friend WithEvents txt_search_equipmentserial As System.Windows.Forms.TextBox
    Private WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Private WithEvents Button_Reload_data As MetroFramework.Controls.MetroButton
End Class
