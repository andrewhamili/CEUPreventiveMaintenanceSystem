<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.tf_setpassword = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.tf_setusername = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.tf_setport = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.tf_setdatabase = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tf_setserver = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btn_savedbsettings = New MetroFramework.Controls.MetroButton()
        Me.btn_mlclose = New MetroFramework.Controls.MetroLink()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.tf_setpassword)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.tf_setusername)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.tf_setport)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.tf_setdatabase)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.tf_setserver)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 187)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Database Settings"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(27, 148)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel5.TabIndex = 21
        Me.MetroLabel5.Text = "&Password:"
        '
        'tf_setpassword
        '
        '
        '
        '
        Me.tf_setpassword.CustomButton.Image = Nothing
        Me.tf_setpassword.CustomButton.Location = New System.Drawing.Point(165, 1)
        Me.tf_setpassword.CustomButton.Name = ""
        Me.tf_setpassword.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tf_setpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tf_setpassword.CustomButton.TabIndex = 1
        Me.tf_setpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tf_setpassword.CustomButton.UseSelectable = True
        Me.tf_setpassword.CustomButton.Visible = False
        Me.tf_setpassword.Lines = New String(-1) {}
        Me.tf_setpassword.Location = New System.Drawing.Point(99, 144)
        Me.tf_setpassword.MaxLength = 32767
        Me.tf_setpassword.Name = "tf_setpassword"
        Me.tf_setpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tf_setpassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tf_setpassword.SelectedText = ""
        Me.tf_setpassword.SelectionLength = 0
        Me.tf_setpassword.SelectionStart = 0
        Me.tf_setpassword.Size = New System.Drawing.Size(187, 23)
        Me.tf_setpassword.TabIndex = 15
        Me.tf_setpassword.UseSelectable = True
        Me.tf_setpassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tf_setpassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(22, 119)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel4.TabIndex = 20
        Me.MetroLabel4.Text = "&Username:"
        '
        'tf_setusername
        '
        '
        '
        '
        Me.tf_setusername.CustomButton.Image = Nothing
        Me.tf_setusername.CustomButton.Location = New System.Drawing.Point(165, 1)
        Me.tf_setusername.CustomButton.Name = ""
        Me.tf_setusername.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tf_setusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tf_setusername.CustomButton.TabIndex = 1
        Me.tf_setusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tf_setusername.CustomButton.UseSelectable = True
        Me.tf_setusername.CustomButton.Visible = False
        Me.tf_setusername.Lines = New String(-1) {}
        Me.tf_setusername.Location = New System.Drawing.Point(99, 115)
        Me.tf_setusername.MaxLength = 32767
        Me.tf_setusername.Name = "tf_setusername"
        Me.tf_setusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tf_setusername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tf_setusername.SelectedText = ""
        Me.tf_setusername.SelectionLength = 0
        Me.tf_setusername.SelectionStart = 0
        Me.tf_setusername.Size = New System.Drawing.Size(187, 23)
        Me.tf_setusername.TabIndex = 14
        Me.tf_setusername.UseSelectable = True
        Me.tf_setusername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tf_setusername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(56, 90)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel3.TabIndex = 19
        Me.MetroLabel3.Text = "&Port:"
        '
        'tf_setport
        '
        '
        '
        '
        Me.tf_setport.CustomButton.Image = Nothing
        Me.tf_setport.CustomButton.Location = New System.Drawing.Point(165, 1)
        Me.tf_setport.CustomButton.Name = ""
        Me.tf_setport.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tf_setport.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tf_setport.CustomButton.TabIndex = 1
        Me.tf_setport.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tf_setport.CustomButton.UseSelectable = True
        Me.tf_setport.CustomButton.Visible = False
        Me.tf_setport.Lines = New String(-1) {}
        Me.tf_setport.Location = New System.Drawing.Point(99, 86)
        Me.tf_setport.MaxLength = 32767
        Me.tf_setport.Name = "tf_setport"
        Me.tf_setport.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tf_setport.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tf_setport.SelectedText = ""
        Me.tf_setport.SelectionLength = 0
        Me.tf_setport.SelectionStart = 0
        Me.tf_setport.Size = New System.Drawing.Size(187, 23)
        Me.tf_setport.TabIndex = 13
        Me.tf_setport.UseSelectable = True
        Me.tf_setport.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tf_setport.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(27, 61)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 18
        Me.MetroLabel2.Text = "&Database:"
        '
        'tf_setdatabase
        '
        '
        '
        '
        Me.tf_setdatabase.CustomButton.Image = Nothing
        Me.tf_setdatabase.CustomButton.Location = New System.Drawing.Point(165, 1)
        Me.tf_setdatabase.CustomButton.Name = ""
        Me.tf_setdatabase.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tf_setdatabase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tf_setdatabase.CustomButton.TabIndex = 1
        Me.tf_setdatabase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tf_setdatabase.CustomButton.UseSelectable = True
        Me.tf_setdatabase.CustomButton.Visible = False
        Me.tf_setdatabase.Lines = New String(-1) {}
        Me.tf_setdatabase.Location = New System.Drawing.Point(99, 57)
        Me.tf_setdatabase.MaxLength = 32767
        Me.tf_setdatabase.Name = "tf_setdatabase"
        Me.tf_setdatabase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tf_setdatabase.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tf_setdatabase.SelectedText = ""
        Me.tf_setdatabase.SelectionLength = 0
        Me.tf_setdatabase.SelectionStart = 0
        Me.tf_setdatabase.Size = New System.Drawing.Size(187, 23)
        Me.tf_setdatabase.TabIndex = 12
        Me.tf_setdatabase.UseSelectable = True
        Me.tf_setdatabase.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tf_setdatabase.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(42, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel1.TabIndex = 17
        Me.MetroLabel1.Text = "&Server:"
        '
        'tf_setserver
        '
        '
        '
        '
        Me.tf_setserver.CustomButton.Image = Nothing
        Me.tf_setserver.CustomButton.Location = New System.Drawing.Point(165, 1)
        Me.tf_setserver.CustomButton.Name = ""
        Me.tf_setserver.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tf_setserver.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tf_setserver.CustomButton.TabIndex = 1
        Me.tf_setserver.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tf_setserver.CustomButton.UseSelectable = True
        Me.tf_setserver.CustomButton.Visible = False
        Me.tf_setserver.Lines = New String(-1) {}
        Me.tf_setserver.Location = New System.Drawing.Point(99, 26)
        Me.tf_setserver.MaxLength = 32767
        Me.tf_setserver.Name = "tf_setserver"
        Me.tf_setserver.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tf_setserver.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tf_setserver.SelectedText = ""
        Me.tf_setserver.SelectionLength = 0
        Me.tf_setserver.SelectionStart = 0
        Me.tf_setserver.Size = New System.Drawing.Size(187, 23)
        Me.tf_setserver.TabIndex = 11
        Me.tf_setserver.UseSelectable = True
        Me.tf_setserver.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tf_setserver.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(230, 256)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 16
        Me.MetroButton1.Text = "Continue"
        Me.MetroButton1.UseSelectable = True
        '
        'btn_savedbsettings
        '
        Me.btn_savedbsettings.Location = New System.Drawing.Point(9, 256)
        Me.btn_savedbsettings.Name = "btn_savedbsettings"
        Me.btn_savedbsettings.Size = New System.Drawing.Size(107, 23)
        Me.btn_savedbsettings.TabIndex = 17
        Me.btn_savedbsettings.Text = "Save Configuration"
        Me.btn_savedbsettings.UseSelectable = True
        '
        'btn_mlclose
        '
        Me.btn_mlclose.Image = Global.CEUPreventiveMaintenanceSystem.My.Resources.Resources.power_1
        Me.btn_mlclose.ImageSize = 32
        Me.btn_mlclose.Location = New System.Drawing.Point(287, 6)
        Me.btn_mlclose.Name = "btn_mlclose"
        Me.btn_mlclose.NoFocusImage = Global.CEUPreventiveMaintenanceSystem.My.Resources.Resources.power_2
        Me.btn_mlclose.Size = New System.Drawing.Size(34, 33)
        Me.btn_mlclose.TabIndex = 29
        Me.btn_mlclose.UseSelectable = True
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 295)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_mlclose)
        Me.Controls.Add(Me.btn_savedbsettings)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSettings"
        Me.Resizable = False
        Me.Text = "&Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tf_setpassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tf_setusername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tf_setport As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tf_setdatabase As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tf_setserver As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_savedbsettings As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_mlclose As MetroFramework.Controls.MetroLink
End Class
