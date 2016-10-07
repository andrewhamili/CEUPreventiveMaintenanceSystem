<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintenanceStaffPrinting
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintenanceStaffPrinting))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ComboBoxStaffPrintFilter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_schoolyear = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxStaffNames = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EquipmentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.Size = New System.Drawing.Size(1331, 307)
        Me.ReportViewer1.TabIndex = 0
        '
        'ComboBoxStaffPrintFilter
        '
        Me.ComboBoxStaffPrintFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStaffPrintFilter.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ComboBoxStaffPrintFilter.FormattingEnabled = True
        Me.ComboBoxStaffPrintFilter.Items.AddRange(New Object() {"Monthly", "Quarterly", "Semi-Annually", "Annually"})
        Me.ComboBoxStaffPrintFilter.Location = New System.Drawing.Point(553, -1)
        Me.ComboBoxStaffPrintFilter.Name = "ComboBoxStaffPrintFilter"
        Me.ComboBoxStaffPrintFilter.Size = New System.Drawing.Size(185, 24)
        Me.ComboBoxStaffPrintFilter.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(470, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Schedule"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label2.Location = New System.Drawing.Point(772, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "School Year: "
        '
        'lbl_schoolyear
        '
        Me.lbl_schoolyear.AutoSize = True
        Me.lbl_schoolyear.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.lbl_schoolyear.Location = New System.Drawing.Point(881, 4)
        Me.lbl_schoolyear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_schoolyear.Name = "lbl_schoolyear"
        Me.lbl_schoolyear.Size = New System.Drawing.Size(50, 21)
        Me.lbl_schoolyear.TabIndex = 3
        Me.lbl_schoolyear.Text = "2016"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label3.Location = New System.Drawing.Point(966, 4)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Staff: "
        '
        'ComboBoxStaffNames
        '
        Me.ComboBoxStaffNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStaffNames.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ComboBoxStaffNames.FormattingEnabled = True
        Me.ComboBoxStaffNames.Location = New System.Drawing.Point(1017, 1)
        Me.ComboBoxStaffNames.Name = "ComboBoxStaffNames"
        Me.ComboBoxStaffNames.Size = New System.Drawing.Size(185, 24)
        Me.ComboBoxStaffNames.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1210, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Match All"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EquipmentListToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(154, 48)
        '
        'EquipmentListToolStripMenuItem
        '
        Me.EquipmentListToolStripMenuItem.Name = "EquipmentListToolStripMenuItem"
        Me.EquipmentListToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.EquipmentListToolStripMenuItem.Text = "Equipment List"
        '
        'MaintenanceStaffPrinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1331, 307)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxStaffNames)
        Me.Controls.Add(Me.ComboBoxStaffPrintFilter)
        Me.Controls.Add(Me.lbl_schoolyear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MaintenanceStaffPrinting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MaintenanceStaffPrinting"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ComboBoxStaffPrintFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_schoolyear As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxStaffNames As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EquipmentListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
