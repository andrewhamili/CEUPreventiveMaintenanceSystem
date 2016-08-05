<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Main
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.main_datagrid = New MetroFramework.Controls.MetroGrid()
        Me.equipmentnumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equipmentname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equipmentmodel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equipmentserial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equipmentlocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equipmentdatepurchase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equipmentprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equipmentbranch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.btn_accountmanagement = New MetroFramework.Controls.MetroButton()
        Me.btn_equipmentmanagement = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.btn_activitylog = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_mlminimize = New MetroFramework.Controls.MetroLink()
        Me.GroupBox1.SuspendLayout()
        CType(Me.main_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(102, 25)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "User name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.main_datagrid)
        Me.GroupBox1.Location = New System.Drawing.Point(242, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1074, 450)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'main_datagrid
        '
        Me.main_datagrid.AllowUserToAddRows = False
        Me.main_datagrid.AllowUserToDeleteRows = False
        Me.main_datagrid.AllowUserToOrderColumns = True
        Me.main_datagrid.AllowUserToResizeRows = False
        Me.main_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.main_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.main_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.main_datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.main_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.main_datagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.main_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.main_datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.equipmentnumber, Me.equipmentname, Me.equipmentmodel, Me.equipmentserial, Me.equipmentlocation, Me.equipmentdatepurchase, Me.equipmentprice, Me.equipmentbranch})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.main_datagrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.main_datagrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.main_datagrid.EnableHeadersVisualStyles = False
        Me.main_datagrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.main_datagrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.main_datagrid.Location = New System.Drawing.Point(3, 16)
        Me.main_datagrid.Name = "main_datagrid"
        Me.main_datagrid.ReadOnly = True
        Me.main_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.main_datagrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.main_datagrid.RowHeadersVisible = False
        Me.main_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.main_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.main_datagrid.Size = New System.Drawing.Size(1068, 431)
        Me.main_datagrid.Style = MetroFramework.MetroColorStyle.Blue
        Me.main_datagrid.TabIndex = 0
        Me.main_datagrid.UseCustomBackColor = True
        Me.main_datagrid.UseCustomForeColor = True
        Me.main_datagrid.UseStyleColors = True
        '
        'equipmentnumber
        '
        Me.equipmentnumber.HeaderText = "Equipment Number"
        Me.equipmentnumber.Name = "equipmentnumber"
        Me.equipmentnumber.ReadOnly = True
        '
        'equipmentname
        '
        Me.equipmentname.HeaderText = "Equipment Name"
        Me.equipmentname.Name = "equipmentname"
        Me.equipmentname.ReadOnly = True
        '
        'equipmentmodel
        '
        Me.equipmentmodel.HeaderText = "Equipment Model"
        Me.equipmentmodel.Name = "equipmentmodel"
        Me.equipmentmodel.ReadOnly = True
        '
        'equipmentserial
        '
        Me.equipmentserial.HeaderText = "Equipment Serial"
        Me.equipmentserial.Name = "equipmentserial"
        Me.equipmentserial.ReadOnly = True
        '
        'equipmentlocation
        '
        Me.equipmentlocation.HeaderText = "Location"
        Me.equipmentlocation.Name = "equipmentlocation"
        Me.equipmentlocation.ReadOnly = True
        '
        'equipmentdatepurchase
        '
        Me.equipmentdatepurchase.HeaderText = "Date Purchased"
        Me.equipmentdatepurchase.Name = "equipmentdatepurchase"
        Me.equipmentdatepurchase.ReadOnly = True
        '
        'equipmentprice
        '
        Me.equipmentprice.HeaderText = "Price"
        Me.equipmentprice.Name = "equipmentprice"
        Me.equipmentprice.ReadOnly = True
        '
        'equipmentbranch
        '
        Me.equipmentbranch.HeaderText = "Branch"
        Me.equipmentbranch.Name = "equipmentbranch"
        Me.equipmentbranch.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MetroLabel6)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.MetroLabel4)
        Me.GroupBox3.Controls.Add(Me.MetroLabel3)
        Me.GroupBox3.Controls.Add(Me.MetroLabel2)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(225, 260)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(12, 193)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel6.TabIndex = 13
        Me.MetroLabel6.Text = "Branch"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Manila", "Makati", "Malolos"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 215)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(207, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(12, 138)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel4.TabIndex = 11
        Me.MetroLabel4.Text = "Serial Number"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(12, 83)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(125, 19)
        Me.MetroLabel3.TabIndex = 10
        Me.MetroLabel3.Text = "Equipment Number"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(12, 27)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(112, 19)
        Me.MetroLabel2.TabIndex = 9
        Me.MetroLabel2.Text = "Equipment Name"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 160)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(207, 20)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 105)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(207, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 20)
        Me.TextBox1.TabIndex = 0
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 75)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel5.TabIndex = 11
        Me.MetroLabel5.Text = "Time"
        '
        'btn_accountmanagement
        '
        Me.btn_accountmanagement.Location = New System.Drawing.Point(50, 385)
        Me.btn_accountmanagement.Name = "btn_accountmanagement"
        Me.btn_accountmanagement.Size = New System.Drawing.Size(160, 50)
        Me.btn_accountmanagement.TabIndex = 13
        Me.btn_accountmanagement.Text = "Account Management"
        Me.btn_accountmanagement.UseSelectable = True
        '
        'btn_equipmentmanagement
        '
        Me.btn_equipmentmanagement.Location = New System.Drawing.Point(50, 441)
        Me.btn_equipmentmanagement.Name = "btn_equipmentmanagement"
        Me.btn_equipmentmanagement.Size = New System.Drawing.Size(160, 50)
        Me.btn_equipmentmanagement.TabIndex = 14
        Me.btn_equipmentmanagement.Text = "Equipment Management"
        Me.btn_equipmentmanagement.UseSelectable = True
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(1197, 91)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(113, 49)
        Me.MetroButton4.TabIndex = 16
        Me.MetroButton4.Text = "Logout"
        Me.MetroButton4.UseSelectable = True
        '
        'btn_activitylog
        '
        Me.btn_activitylog.Location = New System.Drawing.Point(50, 568)
        Me.btn_activitylog.Name = "btn_activitylog"
        Me.btn_activitylog.Size = New System.Drawing.Size(160, 50)
        Me.btn_activitylog.TabIndex = 14
        Me.btn_activitylog.Text = "Activity Log"
        Me.btn_activitylog.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(245, 121)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(268, 19)
        Me.MetroLabel7.TabIndex = 9
        Me.MetroLabel7.Text = "To add a Service Card, double-click an item."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CEUPreventiveMaintenanceSystem.My.Resources.Resources.giphy
        Me.PictureBox1.Location = New System.Drawing.Point(1078, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'btn_mlminimize
        '
        Me.btn_mlminimize.Image = Global.CEUPreventiveMaintenanceSystem.My.Resources.Resources.minimize_1
        Me.btn_mlminimize.ImageSize = 32
        Me.btn_mlminimize.Location = New System.Drawing.Point(1278, 11)
        Me.btn_mlminimize.Name = "btn_mlminimize"
        Me.btn_mlminimize.NoFocusImage = Global.CEUPreventiveMaintenanceSystem.My.Resources.Resources.minimize_2
        Me.btn_mlminimize.Size = New System.Drawing.Size(38, 33)
        Me.btn_mlminimize.TabIndex = 40
        Me.btn_mlminimize.UseSelectable = True
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1318, 629)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_mlminimize)
        Me.Controls.Add(Me.MetroButton4)
        Me.Controls.Add(Me.btn_activitylog)
        Me.Controls.Add(Me.btn_equipmentmanagement)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.btn_accountmanagement)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Main"
        Me.Text = "Preventive Maintenance"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.main_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents main_datagrid As MetroFramework.Controls.MetroGrid
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btn_accountmanagement As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_equipmentmanagement As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_mlminimize As MetroFramework.Controls.MetroLink
    Friend WithEvents btn_activitylog As MetroFramework.Controls.MetroButton
    Friend WithEvents equipmentnumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents equipmentname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents equipmentmodel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents equipmentserial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents equipmentlocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents equipmentdatepurchase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents equipmentprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents equipmentbranch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
