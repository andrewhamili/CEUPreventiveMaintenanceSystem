<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Device
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Device))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.info_equipnum = New System.Windows.Forms.Label()
        Me.info_equipname = New System.Windows.Forms.Label()
        Me.info_equipmodel = New System.Windows.Forms.Label()
        Me.info_equipserialnum = New System.Windows.Forms.Label()
        Me.info_equiplocation = New System.Windows.Forms.Label()
        Me.info_equipdatepurchase = New System.Windows.Forms.Label()
        Me.info_equipprice = New System.Windows.Forms.Label()
        Me.info_equipbranch = New System.Windows.Forms.Label()
        Me.info_equipmaintenancesched = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.datagrid_logs = New MetroFramework.Controls.MetroGrid()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.info_equippersonincharge = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datagrid_logs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(34, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Equipment Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(34, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Equipment Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(34, 184)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Equipment Brand and Model"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(34, 220)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Equipment Serial #"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(34, 409)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Maintenance Schedule"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(34, 255)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Location"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(34, 295)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Date acquired"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(34, 331)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Unit Cost"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(34, 371)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Branch"
        '
        'info_equipnum
        '
        Me.info_equipnum.AutoSize = True
        Me.info_equipnum.Location = New System.Drawing.Point(299, 108)
        Me.info_equipnum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info_equipnum.Name = "info_equipnum"
        Me.info_equipnum.Size = New System.Drawing.Size(142, 18)
        Me.info_equipnum.TabIndex = 0
        Me.info_equipnum.Text = "Equipment Number"
        '
        'info_equipname
        '
        Me.info_equipname.AutoSize = True
        Me.info_equipname.Location = New System.Drawing.Point(299, 148)
        Me.info_equipname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info_equipname.Name = "info_equipname"
        Me.info_equipname.Size = New System.Drawing.Size(142, 18)
        Me.info_equipname.TabIndex = 0
        Me.info_equipname.Text = "Equipment Number"
        '
        'info_equipmodel
        '
        Me.info_equipmodel.AutoSize = True
        Me.info_equipmodel.Location = New System.Drawing.Point(299, 187)
        Me.info_equipmodel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info_equipmodel.Name = "info_equipmodel"
        Me.info_equipmodel.Size = New System.Drawing.Size(142, 18)
        Me.info_equipmodel.TabIndex = 0
        Me.info_equipmodel.Text = "Equipment Number"
        '
        'info_equipserialnum
        '
        Me.info_equipserialnum.AutoSize = True
        Me.info_equipserialnum.Location = New System.Drawing.Point(299, 223)
        Me.info_equipserialnum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info_equipserialnum.Name = "info_equipserialnum"
        Me.info_equipserialnum.Size = New System.Drawing.Size(142, 18)
        Me.info_equipserialnum.TabIndex = 0
        Me.info_equipserialnum.Text = "Equipment Number"
        '
        'info_equiplocation
        '
        Me.info_equiplocation.AutoSize = True
        Me.info_equiplocation.Location = New System.Drawing.Point(299, 258)
        Me.info_equiplocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info_equiplocation.Name = "info_equiplocation"
        Me.info_equiplocation.Size = New System.Drawing.Size(142, 18)
        Me.info_equiplocation.TabIndex = 0
        Me.info_equiplocation.Text = "Equipment Number"
        '
        'info_equipdatepurchase
        '
        Me.info_equipdatepurchase.AutoSize = True
        Me.info_equipdatepurchase.Location = New System.Drawing.Point(299, 298)
        Me.info_equipdatepurchase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info_equipdatepurchase.Name = "info_equipdatepurchase"
        Me.info_equipdatepurchase.Size = New System.Drawing.Size(142, 18)
        Me.info_equipdatepurchase.TabIndex = 0
        Me.info_equipdatepurchase.Text = "Equipment Number"
        '
        'info_equipprice
        '
        Me.info_equipprice.AutoSize = True
        Me.info_equipprice.Location = New System.Drawing.Point(299, 334)
        Me.info_equipprice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info_equipprice.Name = "info_equipprice"
        Me.info_equipprice.Size = New System.Drawing.Size(142, 18)
        Me.info_equipprice.TabIndex = 0
        Me.info_equipprice.Text = "Equipment Number"
        '
        'info_equipbranch
        '
        Me.info_equipbranch.AutoSize = True
        Me.info_equipbranch.Location = New System.Drawing.Point(299, 374)
        Me.info_equipbranch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info_equipbranch.Name = "info_equipbranch"
        Me.info_equipbranch.Size = New System.Drawing.Size(142, 18)
        Me.info_equipbranch.TabIndex = 0
        Me.info_equipbranch.Text = "Equipment Number"
        '
        'info_equipmaintenancesched
        '
        Me.info_equipmaintenancesched.AutoSize = True
        Me.info_equipmaintenancesched.Location = New System.Drawing.Point(299, 412)
        Me.info_equipmaintenancesched.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info_equipmaintenancesched.Name = "info_equipmaintenancesched"
        Me.info_equipmaintenancesched.Size = New System.Drawing.Size(142, 18)
        Me.info_equipmaintenancesched.TabIndex = 0
        Me.info_equipmaintenancesched.Text = "Equipment Number"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.datagrid_logs)
        Me.GroupBox1.Location = New System.Drawing.Point(683, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 336)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maintenance Log"
        '
        'datagrid_logs
        '
        Me.datagrid_logs.AllowUserToAddRows = False
        Me.datagrid_logs.AllowUserToDeleteRows = False
        Me.datagrid_logs.AllowUserToOrderColumns = True
        Me.datagrid_logs.AllowUserToResizeRows = False
        Me.datagrid_logs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagrid_logs.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_logs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrid_logs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datagrid_logs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_logs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid_logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_logs.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid_logs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid_logs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagrid_logs.EnableHeadersVisualStyles = False
        Me.datagrid_logs.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagrid_logs.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_logs.Location = New System.Drawing.Point(3, 22)
        Me.datagrid_logs.Name = "datagrid_logs"
        Me.datagrid_logs.ReadOnly = True
        Me.datagrid_logs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_logs.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid_logs.RowHeadersVisible = False
        Me.datagrid_logs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagrid_logs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_logs.Size = New System.Drawing.Size(589, 311)
        Me.datagrid_logs.Style = MetroFramework.MetroColorStyle.Blue
        Me.datagrid_logs.TabIndex = 1
        Me.datagrid_logs.UseCustomBackColor = True
        Me.datagrid_logs.UseCustomForeColor = True
        Me.datagrid_logs.UseStyleColors = True
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(1002, 60)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(161, 49)
        Me.MetroButton4.TabIndex = 17
        Me.MetroButton4.Text = "Add Manitenance Log"
        Me.MetroButton4.UseSelectable = True
        '
        'info_equippersonincharge
        '
        Me.info_equippersonincharge.AutoSize = True
        Me.info_equippersonincharge.Location = New System.Drawing.Point(299, 448)
        Me.info_equippersonincharge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info_equippersonincharge.Name = "info_equippersonincharge"
        Me.info_equippersonincharge.Size = New System.Drawing.Size(142, 18)
        Me.info_equippersonincharge.TabIndex = 0
        Me.info_equippersonincharge.Text = "Equipment Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(34, 445)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(160, 23)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Person-in-charge"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CEUPreventiveMaintenanceSystem.My.Resources.Resources.giphy
        Me.PictureBox2.Location = New System.Drawing.Point(1169, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(108, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CEUPreventiveMaintenanceSystem.My.Resources.Resources.power_1
        Me.PictureBox1.Location = New System.Drawing.Point(1208, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Device
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 487)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroButton4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.info_equippersonincharge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.info_equipmaintenancesched)
        Me.Controls.Add(Me.info_equipbranch)
        Me.Controls.Add(Me.info_equipprice)
        Me.Controls.Add(Me.info_equipdatepurchase)
        Me.Controls.Add(Me.info_equiplocation)
        Me.Controls.Add(Me.info_equipserialnum)
        Me.Controls.Add(Me.info_equipmodel)
        Me.Controls.Add(Me.info_equipname)
        Me.Controls.Add(Me.info_equipnum)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Device"
        Me.Padding = New System.Windows.Forms.Padding(30, 83, 30, 28)
        Me.Resizable = False
        Me.Text = "Device"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.datagrid_logs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents info_equipnum As System.Windows.Forms.Label
    Friend WithEvents info_equipname As System.Windows.Forms.Label
    Friend WithEvents info_equipmodel As System.Windows.Forms.Label
    Friend WithEvents info_equipserialnum As System.Windows.Forms.Label
    Friend WithEvents info_equiplocation As System.Windows.Forms.Label
    Friend WithEvents info_equipdatepurchase As System.Windows.Forms.Label
    Friend WithEvents info_equipprice As System.Windows.Forms.Label
    Friend WithEvents info_equipbranch As System.Windows.Forms.Label
    Friend WithEvents info_equipmaintenancesched As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents datagrid_logs As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents info_equippersonincharge As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
