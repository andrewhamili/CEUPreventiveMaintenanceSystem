<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class serv_card_eq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(serv_card_eq))
        Me.txt_sched_date = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txt_remarks_eq = New System.Windows.Forms.TextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_mainte_eq = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txt_cost_eq = New System.Windows.Forms.TextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txt_serv_eq = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_serial_eq = New System.Windows.Forms.TextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.disp_sched_info = New MetroFramework.Controls.MetroGrid()
        Me.btn_cancel1 = New MetroFramework.Controls.MetroButton()
        Me.btn_save1 = New MetroFramework.Controls.MetroButton()
        Me.btn_update1 = New MetroFramework.Controls.MetroButton()
        Me.btn_clear1 = New MetroFramework.Controls.MetroButton()
        Me.btn_delete1 = New MetroFramework.Controls.MetroButton()
        Me.btn_add1 = New MetroFramework.Controls.MetroButton()
        Me.btn_done1 = New MetroFramework.Controls.MetroButton()
        Me.btn_mlminimize = New MetroFramework.Controls.MetroLink()
        Me.btn_mlclose = New MetroFramework.Controls.MetroLink()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.disp_sched_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_sched_date
        '
        Me.txt_sched_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_sched_date.Location = New System.Drawing.Point(132, 75)
        Me.txt_sched_date.Name = "txt_sched_date"
        Me.txt_sched_date.Size = New System.Drawing.Size(210, 20)
        Me.txt_sched_date.TabIndex = 30
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(46, 76)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel4.TabIndex = 31
        Me.MetroLabel4.Text = "Assign Date:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(64, 106)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel1.TabIndex = 32
        Me.MetroLabel1.Text = "Remarks:"
        '
        'txt_remarks_eq
        '
        Me.txt_remarks_eq.Location = New System.Drawing.Point(132, 105)
        Me.txt_remarks_eq.Name = "txt_remarks_eq"
        Me.txt_remarks_eq.Size = New System.Drawing.Size(210, 20)
        Me.txt_remarks_eq.TabIndex = 33
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(40, 136)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(86, 38)
        Me.MetroLabel2.TabIndex = 34
        Me.MetroLabel2.Text = "Preventive" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maintenance:"
        '
        'txt_mainte_eq
        '
        Me.txt_mainte_eq.FormattingEnabled = True
        Me.txt_mainte_eq.ItemHeight = 23
        Me.txt_mainte_eq.Items.AddRange(New Object() {"Yes", "No"})
        Me.txt_mainte_eq.Location = New System.Drawing.Point(132, 145)
        Me.txt_mainte_eq.Name = "txt_mainte_eq"
        Me.txt_mainte_eq.Size = New System.Drawing.Size(210, 29)
        Me.txt_mainte_eq.TabIndex = 35
        Me.txt_mainte_eq.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(75, 184)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(51, 38)
        Me.MetroLabel3.TabIndex = 36
        Me.MetroLabel3.Text = "Cost of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Repair:"
        '
        'txt_cost_eq
        '
        Me.txt_cost_eq.Location = New System.Drawing.Point(132, 202)
        Me.txt_cost_eq.Name = "txt_cost_eq"
        Me.txt_cost_eq.Size = New System.Drawing.Size(210, 20)
        Me.txt_cost_eq.TabIndex = 37
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(54, 232)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel5.TabIndex = 38
        Me.MetroLabel5.Text = "Service by:"
        '
        'txt_serv_eq
        '
        Me.txt_serv_eq.Location = New System.Drawing.Point(132, 231)
        Me.txt_serv_eq.Name = "txt_serv_eq"
        Me.txt_serv_eq.Size = New System.Drawing.Size(210, 20)
        Me.txt_serv_eq.TabIndex = 39
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_serial_eq)
        Me.GroupBox1.Controls.Add(Me.MetroLabel6)
        Me.GroupBox1.Controls.Add(Me.txt_mainte_eq)
        Me.GroupBox1.Controls.Add(Me.txt_serv_eq)
        Me.GroupBox1.Controls.Add(Me.txt_sched_date)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.txt_cost_eq)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.txt_remarks_eq)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 293)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fill-up the Information"
        '
        'txt_serial_eq
        '
        Me.txt_serial_eq.Location = New System.Drawing.Point(132, 46)
        Me.txt_serial_eq.Name = "txt_serial_eq"
        Me.txt_serial_eq.Size = New System.Drawing.Size(210, 20)
        Me.txt_serial_eq.TabIndex = 41
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(28, 47)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel6.TabIndex = 40
        Me.MetroLabel6.Text = "Serial Number:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.disp_sched_info)
        Me.GroupBox2.Location = New System.Drawing.Point(419, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(473, 322)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information"
        '
        'disp_sched_info
        '
        Me.disp_sched_info.AllowUserToResizeRows = False
        Me.disp_sched_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.disp_sched_info.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.disp_sched_info.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.disp_sched_info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.disp_sched_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.disp_sched_info.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.disp_sched_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.disp_sched_info.DefaultCellStyle = DataGridViewCellStyle2
        Me.disp_sched_info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.disp_sched_info.EnableHeadersVisualStyles = False
        Me.disp_sched_info.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.disp_sched_info.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.disp_sched_info.Location = New System.Drawing.Point(3, 16)
        Me.disp_sched_info.Name = "disp_sched_info"
        Me.disp_sched_info.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.disp_sched_info.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.disp_sched_info.RowHeadersVisible = False
        Me.disp_sched_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.disp_sched_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.disp_sched_info.Size = New System.Drawing.Size(467, 303)
        Me.disp_sched_info.TabIndex = 0
        '
        'btn_cancel1
        '
        Me.btn_cancel1.Location = New System.Drawing.Point(777, 437)
        Me.btn_cancel1.Name = "btn_cancel1"
        Me.btn_cancel1.Size = New System.Drawing.Size(115, 32)
        Me.btn_cancel1.TabIndex = 42
        Me.btn_cancel1.Text = "Cancel"
        Me.btn_cancel1.UseSelectable = True
        '
        'btn_save1
        '
        Me.btn_save1.Location = New System.Drawing.Point(419, 437)
        Me.btn_save1.Name = "btn_save1"
        Me.btn_save1.Size = New System.Drawing.Size(115, 32)
        Me.btn_save1.TabIndex = 43
        Me.btn_save1.Text = "Save"
        Me.btn_save1.UseSelectable = True
        '
        'btn_update1
        '
        Me.btn_update1.Location = New System.Drawing.Point(419, 437)
        Me.btn_update1.Name = "btn_update1"
        Me.btn_update1.Size = New System.Drawing.Size(115, 32)
        Me.btn_update1.TabIndex = 44
        Me.btn_update1.Text = "Update"
        Me.btn_update1.UseSelectable = True
        '
        'btn_clear1
        '
        Me.btn_clear1.Location = New System.Drawing.Point(283, 411)
        Me.btn_clear1.Name = "btn_clear1"
        Me.btn_clear1.Size = New System.Drawing.Size(115, 32)
        Me.btn_clear1.TabIndex = 45
        Me.btn_clear1.Text = "Clear"
        Me.btn_clear1.UseSelectable = True
        '
        'btn_delete1
        '
        Me.btn_delete1.Location = New System.Drawing.Point(605, 437)
        Me.btn_delete1.Name = "btn_delete1"
        Me.btn_delete1.Size = New System.Drawing.Size(115, 32)
        Me.btn_delete1.TabIndex = 46
        Me.btn_delete1.Text = "Delete"
        Me.btn_delete1.UseSelectable = True
        '
        'btn_add1
        '
        Me.btn_add1.Location = New System.Drawing.Point(23, 411)
        Me.btn_add1.Name = "btn_add1"
        Me.btn_add1.Size = New System.Drawing.Size(115, 32)
        Me.btn_add1.TabIndex = 47
        Me.btn_add1.Text = "Add"
        Me.btn_add1.UseSelectable = True
        '
        'btn_done1
        '
        Me.btn_done1.Location = New System.Drawing.Point(777, 437)
        Me.btn_done1.Name = "btn_done1"
        Me.btn_done1.Size = New System.Drawing.Size(115, 32)
        Me.btn_done1.TabIndex = 48
        Me.btn_done1.Text = "Done"
        Me.btn_done1.UseSelectable = True
        '
        'btn_mlminimize
        '
        Me.btn_mlminimize.Image = Global.CEUPreventiveMaintenanceSystem.My.Resources.Resources.minimize_1
        Me.btn_mlminimize.ImageSize = 32
        Me.btn_mlminimize.Location = New System.Drawing.Point(832, 6)
        Me.btn_mlminimize.Name = "btn_mlminimize"
        Me.btn_mlminimize.NoFocusImage = Global.CEUPreventiveMaintenanceSystem.My.Resources.Resources.minimize_2
        Me.btn_mlminimize.Size = New System.Drawing.Size(38, 33)
        Me.btn_mlminimize.TabIndex = 50
        Me.btn_mlminimize.UseSelectable = True
        '
        'btn_mlclose
        '
        Me.btn_mlclose.Image = Global.CEUPreventiveMaintenanceSystem.My.Resources.Resources.power_1
        Me.btn_mlclose.ImageSize = 32
        Me.btn_mlclose.Location = New System.Drawing.Point(876, 6)
        Me.btn_mlclose.Name = "btn_mlclose"
        Me.btn_mlclose.NoFocusImage = Global.CEUPreventiveMaintenanceSystem.My.Resources.Resources.power_2
        Me.btn_mlclose.Size = New System.Drawing.Size(34, 33)
        Me.btn_mlclose.TabIndex = 49
        Me.btn_mlclose.UseSelectable = True
        '
        'serv_card_eq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 487)
        Me.Controls.Add(Me.btn_mlminimize)
        Me.Controls.Add(Me.btn_mlclose)
        Me.Controls.Add(Me.btn_done1)
        Me.Controls.Add(Me.btn_add1)
        Me.Controls.Add(Me.btn_delete1)
        Me.Controls.Add(Me.btn_clear1)
        Me.Controls.Add(Me.btn_update1)
        Me.Controls.Add(Me.btn_save1)
        Me.Controls.Add(Me.btn_cancel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "serv_card_eq"
        Me.Text = "Service Card Management"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.disp_sched_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_sched_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_remarks_eq As System.Windows.Forms.TextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_mainte_eq As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_cost_eq As System.Windows.Forms.TextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_serv_eq As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_serial_eq As System.Windows.Forms.TextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents disp_sched_info As MetroFramework.Controls.MetroGrid
    Friend WithEvents btn_cancel1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_save1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_update1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_clear1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_delete1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_add1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_done1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_mlminimize As MetroFramework.Controls.MetroLink
    Friend WithEvents btn_mlclose As MetroFramework.Controls.MetroLink
End Class
