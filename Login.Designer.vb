<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.txtbox_username = New System.Windows.Forms.TextBox()
        Me.txtbox_password = New System.Windows.Forms.TextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.lbl_connectionindicator = New System.Windows.Forms.Label()
        Me.BackgroundWorker_SystemStatusChecker = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'txtbox_username
        '
        Me.txtbox_username.Location = New System.Drawing.Point(153, 85)
        Me.txtbox_username.Name = "txtbox_username"
        Me.txtbox_username.Size = New System.Drawing.Size(143, 20)
        Me.txtbox_username.TabIndex = 0
        '
        'txtbox_password
        '
        Me.txtbox_password.Location = New System.Drawing.Point(153, 112)
        Me.txtbox_password.Name = "txtbox_password"
        Me.txtbox_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(51)
        Me.txtbox_password.Size = New System.Drawing.Size(143, 20)
        Me.txtbox_password.TabIndex = 2
        Me.txtbox_password.UseSystemPasswordChar = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(13, 86)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(134, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Gmail Account (CEU):"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(13, 113)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Password:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(204, 163)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(110, 23)
        Me.MetroButton1.TabIndex = 5
        Me.MetroButton1.Text = "Login"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(59, 163)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(110, 23)
        Me.MetroButton2.TabIndex = 6
        Me.MetroButton2.Text = "Cancel"
        Me.MetroButton2.UseSelectable = True
        '
        'lbl_connectionindicator
        '
        Me.lbl_connectionindicator.AutoSize = True
        Me.lbl_connectionindicator.Location = New System.Drawing.Point(-3, 211)
        Me.lbl_connectionindicator.Name = "lbl_connectionindicator"
        Me.lbl_connectionindicator.Size = New System.Drawing.Size(37, 13)
        Me.lbl_connectionindicator.TabIndex = 7
        Me.lbl_connectionindicator.Text = "Offline"
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_connectionindicator)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtbox_password)
        Me.Controls.Add(Me.txtbox_username)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Login"
        Me.Resizable = False
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbox_username As TextBox
    Friend WithEvents txtbox_password As TextBox
    Friend WithEvents lbl_connectionindicator As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker_SystemStatusChecker As System.ComponentModel.BackgroundWorker
    Private WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Private WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
