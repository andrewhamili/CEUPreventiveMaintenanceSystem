<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServiceCard))
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.equip_N = New MetroFramework.Controls.MetroLabel()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.rdio_yes = New System.Windows.Forms.RadioButton()
        Me.rdio_no = New System.Windows.Forms.RadioButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txt_repaircost = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdio_outbound = New System.Windows.Forms.RadioButton()
        Me.rdio_inbound = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_remarks
        '
        Me.txt_remarks.Location = New System.Drawing.Point(234, 151)
        Me.txt_remarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(215, 26)
        Me.txt_remarks.TabIndex = 1
        '
        'equip_N
        '
        Me.equip_N.AutoSize = True
        Me.equip_N.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.equip_N.Location = New System.Drawing.Point(179, 83)
        Me.equip_N.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.equip_N.Name = "equip_N"
        Me.equip_N.Size = New System.Drawing.Size(47, 25)
        Me.equip_N.TabIndex = 2
        Me.equip_N.Text = "Date"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Enabled = False
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker.Location = New System.Drawing.Point(234, 82)
        Me.DateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(108, 26)
        Me.DateTimePicker.TabIndex = 3
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(150, 151)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(76, 25)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Remarks"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(34, 243)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(193, 25)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Preventive Maintenance"
        '
        'rdio_yes
        '
        Me.rdio_yes.AutoSize = True
        Me.rdio_yes.Checked = True
        Me.rdio_yes.Location = New System.Drawing.Point(13, 12)
        Me.rdio_yes.Name = "rdio_yes"
        Me.rdio_yes.Size = New System.Drawing.Size(51, 22)
        Me.rdio_yes.TabIndex = 4
        Me.rdio_yes.TabStop = True
        Me.rdio_yes.Text = "Yes"
        Me.rdio_yes.UseVisualStyleBackColor = True
        '
        'rdio_no
        '
        Me.rdio_no.AutoSize = True
        Me.rdio_no.Location = New System.Drawing.Point(97, 12)
        Me.rdio_no.Name = "rdio_no"
        Me.rdio_no.Size = New System.Drawing.Size(46, 22)
        Me.rdio_no.TabIndex = 5
        Me.rdio_no.Text = "No"
        Me.rdio_no.UseVisualStyleBackColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(109, 278)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(118, 25)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Cost of Repair"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(128, 329)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(98, 25)
        Me.MetroLabel4.TabIndex = 2
        Me.MetroLabel4.Text = "Serviced by"
        '
        'txt_repaircost
        '
        Me.txt_repaircost.Location = New System.Drawing.Point(234, 277)
        Me.txt_repaircost.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_repaircost.MaxLength = 9
        Me.txt_repaircost.Name = "txt_repaircost"
        Me.txt_repaircost.Size = New System.Drawing.Size(215, 26)
        Me.txt_repaircost.TabIndex = 1
        '
        'txt_username
        '
        Me.txt_username.Enabled = False
        Me.txt_username.Location = New System.Drawing.Point(234, 328)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(215, 26)
        Me.txt_username.TabIndex = 1
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(340, 374)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(94, 34)
        Me.btn_save.TabIndex = 7
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(213, 117)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(132, 22)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "CONDEMNED"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(179, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 34)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(120, 202)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(106, 25)
        Me.MetroLabel5.TabIndex = 2
        Me.MetroLabel5.Text = "Service Type"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdio_yes)
        Me.GroupBox1.Controls.Add(Me.rdio_no)
        Me.GroupBox1.Location = New System.Drawing.Point(237, 230)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 38)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdio_outbound)
        Me.GroupBox2.Controls.Add(Me.rdio_inbound)
        Me.GroupBox2.Location = New System.Drawing.Point(235, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 43)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'rdio_outbound
        '
        Me.rdio_outbound.AutoSize = True
        Me.rdio_outbound.Location = New System.Drawing.Point(96, 14)
        Me.rdio_outbound.Name = "rdio_outbound"
        Me.rdio_outbound.Size = New System.Drawing.Size(93, 22)
        Me.rdio_outbound.TabIndex = 1
        Me.rdio_outbound.Text = "Outbound"
        Me.rdio_outbound.UseVisualStyleBackColor = True
        '
        'rdio_inbound
        '
        Me.rdio_inbound.AutoSize = True
        Me.rdio_inbound.Checked = True
        Me.rdio_inbound.Location = New System.Drawing.Point(12, 14)
        Me.rdio_inbound.Name = "rdio_inbound"
        Me.rdio_inbound.Size = New System.Drawing.Size(80, 22)
        Me.rdio_inbound.TabIndex = 0
        Me.rdio_inbound.TabStop = True
        Me.rdio_inbound.Text = "Inbound"
        Me.rdio_inbound.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(364, 113)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 26)
        Me.DateTimePicker1.TabIndex = 3
        Me.DateTimePicker1.Value = New Date(2016, 8, 1, 9, 19, 0, 0)
        '
        'ServiceCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(503, 420)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.equip_N)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_repaircost)
        Me.Controls.Add(Me.txt_remarks)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ServiceCard"
        Me.Padding = New System.Windows.Forms.Padding(30, 83, 30, 28)
        Me.Resizable = False
        Me.Text = "Service Card"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents equip_N As MetroFramework.Controls.MetroLabel
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents rdio_yes As System.Windows.Forms.RadioButton
    Friend WithEvents rdio_no As System.Windows.Forms.RadioButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_repaircost As System.Windows.Forms.TextBox
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdio_outbound As System.Windows.Forms.RadioButton
    Friend WithEvents rdio_inbound As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
