<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintMode
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintMode))
        Me.rdio_staff_list = New System.Windows.Forms.RadioButton()
        Me.rdio_equipmentlist = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rdio_staff_list
        '
        Me.rdio_staff_list.AutoSize = True
        Me.rdio_staff_list.Location = New System.Drawing.Point(44, 77)
        Me.rdio_staff_list.Margin = New System.Windows.Forms.Padding(4)
        Me.rdio_staff_list.Name = "rdio_staff_list"
        Me.rdio_staff_list.Size = New System.Drawing.Size(305, 22)
        Me.rdio_staff_list.TabIndex = 0
        Me.rdio_staff_list.Text = "List of Staff with Preventive Maintenance"
        Me.rdio_staff_list.UseVisualStyleBackColor = True
        '
        'rdio_equipmentlist
        '
        Me.rdio_equipmentlist.AutoSize = True
        Me.rdio_equipmentlist.Checked = True
        Me.rdio_equipmentlist.Location = New System.Drawing.Point(44, 48)
        Me.rdio_equipmentlist.Name = "rdio_equipmentlist"
        Me.rdio_equipmentlist.Size = New System.Drawing.Size(130, 22)
        Me.rdio_equipmentlist.TabIndex = 1
        Me.rdio_equipmentlist.TabStop = True
        Me.rdio_equipmentlist.Text = "Equipment List"
        Me.rdio_equipmentlist.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(437, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(313, 116)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PrintMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 167)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rdio_equipmentlist)
        Me.Controls.Add(Me.rdio_staff_list)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PrintMode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose a page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdio_staff_list As System.Windows.Forms.RadioButton
    Friend WithEvents rdio_equipmentlist As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
