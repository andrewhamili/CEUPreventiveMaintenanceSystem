<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Accounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Accounts))
        Me.lbl_fname1 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_mname1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_username1 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_pass1 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_reppass1 = New MetroFramework.Controls.MetroLabel()
        Me.tf_fname = New System.Windows.Forms.TextBox()
        Me.tf_mname = New System.Windows.Forms.TextBox()
        Me.tf_lname = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tf_username = New System.Windows.Forms.TextBox()
        Me.tf_password = New System.Windows.Forms.TextBox()
        Me.tf_retypepass = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb_usertype = New System.Windows.Forms.ComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.btn_update = New MetroFramework.Controls.MetroButton()
        Me.btn_save = New MetroFramework.Controls.MetroButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lb_useraccounts = New System.Windows.Forms.ListBox()
        Me.btn_delete = New MetroFramework.Controls.MetroButton()
        Me.btn_mlclose = New MetroFramework.Controls.MetroLink()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_fname1
        '
        Me.lbl_fname1.AutoSize = True
        Me.lbl_fname1.Location = New System.Drawing.Point(96, 37)
        Me.lbl_fname1.Name = "lbl_fname1"
        Me.lbl_fname1.Size = New System.Drawing.Size(82, 19)
        Me.lbl_fname1.TabIndex = 2
        Me.lbl_fname1.Text = "First Name:*"
        '
        'lbl_mname1
        '
        Me.lbl_mname1.AutoSize = True
        Me.lbl_mname1.Location = New System.Drawing.Point(79, 63)
        Me.lbl_mname1.Name = "lbl_mname1"
        Me.lbl_mname1.Size = New System.Drawing.Size(93, 19)
        Me.lbl_mname1.TabIndex = 3
        Me.lbl_mname1.Text = "Middle Name:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(98, 87)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Last Name:*"
        '
        'lbl_username1
        '
        Me.lbl_username1.AutoSize = True
        Me.lbl_username1.Location = New System.Drawing.Point(75, 52)
        Me.lbl_username1.Name = "lbl_username1"
        Me.lbl_username1.Size = New System.Drawing.Size(103, 19)
        Me.lbl_username1.TabIndex = 5
        Me.lbl_username1.Text = "Gmail Account:*"
        '
        'lbl_pass1
        '
        Me.lbl_pass1.AutoSize = True
        Me.lbl_pass1.Location = New System.Drawing.Point(106, 78)
        Me.lbl_pass1.Name = "lbl_pass1"
        Me.lbl_pass1.Size = New System.Drawing.Size(73, 19)
        Me.lbl_pass1.TabIndex = 6
        Me.lbl_pass1.Text = "Password:*"
        '
        'lbl_reppass1
        '
        Me.lbl_reppass1.AutoSize = True
        Me.lbl_reppass1.Location = New System.Drawing.Point(54, 103)
        Me.lbl_reppass1.Name = "lbl_reppass1"
        Me.lbl_reppass1.Size = New System.Drawing.Size(126, 19)
        Me.lbl_reppass1.TabIndex = 13
        Me.lbl_reppass1.Text = "Re-Type Password:*"
        '
        'tf_fname
        '
        Me.tf_fname.Location = New System.Drawing.Point(178, 36)
        Me.tf_fname.Name = "tf_fname"
        Me.tf_fname.Size = New System.Drawing.Size(217, 20)
        Me.tf_fname.TabIndex = 14
        '
        'tf_mname
        '
        Me.tf_mname.Location = New System.Drawing.Point(178, 62)
        Me.tf_mname.Name = "tf_mname"
        Me.tf_mname.Size = New System.Drawing.Size(217, 20)
        Me.tf_mname.TabIndex = 15
        '
        'tf_lname
        '
        Me.tf_lname.Location = New System.Drawing.Point(178, 86)
        Me.tf_lname.Name = "tf_lname"
        Me.tf_lname.Size = New System.Drawing.Size(217, 20)
        Me.tf_lname.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tf_lname)
        Me.GroupBox1.Controls.Add(Me.lbl_fname1)
        Me.GroupBox1.Controls.Add(Me.tf_mname)
        Me.GroupBox1.Controls.Add(Me.lbl_mname1)
        Me.GroupBox1.Controls.Add(Me.tf_fname)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 127)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User's Name"
        '
        'tf_username
        '
        Me.tf_username.Location = New System.Drawing.Point(178, 51)
        Me.tf_username.Name = "tf_username"
        Me.tf_username.Size = New System.Drawing.Size(217, 20)
        Me.tf_username.TabIndex = 18
        '
        'tf_password
        '
        Me.tf_password.Location = New System.Drawing.Point(178, 77)
        Me.tf_password.Name = "tf_password"
        Me.tf_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tf_password.Size = New System.Drawing.Size(217, 20)
        Me.tf_password.TabIndex = 19
        '
        'tf_retypepass
        '
        Me.tf_retypepass.Location = New System.Drawing.Point(178, 102)
        Me.tf_retypepass.Name = "tf_retypepass"
        Me.tf_retypepass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tf_retypepass.Size = New System.Drawing.Size(217, 20)
        Me.tf_retypepass.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_usertype)
        Me.GroupBox2.Controls.Add(Me.tf_password)
        Me.GroupBox2.Controls.Add(Me.tf_username)
        Me.GroupBox2.Controls.Add(Me.MetroLabel3)
        Me.GroupBox2.Controls.Add(Me.lbl_username1)
        Me.GroupBox2.Controls.Add(Me.lbl_pass1)
        Me.GroupBox2.Controls.Add(Me.tf_retypepass)
        Me.GroupBox2.Controls.Add(Me.lbl_reppass1)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 150)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User's Account"
        '
        'cb_usertype
        '
        Me.cb_usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_usertype.FormattingEnabled = True
        Me.cb_usertype.Items.AddRange(New Object() {"Administrator", "Staff"})
        Me.cb_usertype.Location = New System.Drawing.Point(178, 20)
        Me.cb_usertype.Name = "cb_usertype"
        Me.cb_usertype.Size = New System.Drawing.Size(217, 21)
        Me.cb_usertype.TabIndex = 21
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(108, 22)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "Usertype:*"
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(210, 361)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(115, 32)
        Me.btn_update.TabIndex = 22
        Me.btn_update.Text = "Update"
        Me.btn_update.UseSelectable = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(331, 361)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(115, 32)
        Me.btn_save.TabIndex = 23
        Me.btn_save.Text = "Register"
        Me.btn_save.UseSelectable = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lb_useraccounts)
        Me.GroupBox3.Location = New System.Drawing.Point(452, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(194, 281)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Existing Accounts"
        '
        'lb_useraccounts
        '
        Me.lb_useraccounts.FormattingEnabled = True
        Me.lb_useraccounts.Location = New System.Drawing.Point(6, 19)
        Me.lb_useraccounts.Name = "lb_useraccounts"
        Me.lb_useraccounts.Size = New System.Drawing.Size(181, 251)
        Me.lb_useraccounts.TabIndex = 0
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(25, 361)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(115, 32)
        Me.btn_delete.TabIndex = 26
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseSelectable = True
        '
        'btn_mlclose
        '
        Me.btn_mlclose.Image = Global.CEUPreventiveMaintenanceSystem.My.Resources.Resources.power_1
        Me.btn_mlclose.ImageSize = 32
        Me.btn_mlclose.Location = New System.Drawing.Point(620, 5)
        Me.btn_mlclose.Name = "btn_mlclose"
        Me.btn_mlclose.NoFocusImage = Global.CEUPreventiveMaintenanceSystem.My.Resources.Resources.power_2
        Me.btn_mlclose.Size = New System.Drawing.Size(34, 33)
        Me.btn_mlclose.TabIndex = 27
        Me.btn_mlclose.UseSelectable = True
        '
        'Frm_Accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 407)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_mlclose)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Accounts"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Account Management"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_fname1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_mname1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_username1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_pass1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_reppass1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tf_fname As System.Windows.Forms.TextBox
    Friend WithEvents tf_mname As System.Windows.Forms.TextBox
    Friend WithEvents tf_lname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tf_username As System.Windows.Forms.TextBox
    Friend WithEvents tf_password As System.Windows.Forms.TextBox
    Friend WithEvents tf_retypepass As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_update As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_save As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cb_usertype As System.Windows.Forms.ComboBox
    Friend WithEvents lb_useraccounts As ListBox
    Friend WithEvents btn_delete As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_mlclose As MetroFramework.Controls.MetroLink
End Class
