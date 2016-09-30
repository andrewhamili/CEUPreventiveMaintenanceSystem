<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevicesPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevicesPrint))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxDevicesPrintFilter = New System.Windows.Forms.ComboBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker_LoadEquipmentNames = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(461, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filter"
        '
        'ComboBoxDevicesPrintFilter
        '
        Me.ComboBoxDevicesPrintFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDevicesPrintFilter.FormattingEnabled = True
        Me.ComboBoxDevicesPrintFilter.Location = New System.Drawing.Point(511, 0)
        Me.ComboBoxDevicesPrintFilter.Name = "ComboBoxDevicesPrintFilter"
        Me.ComboBoxDevicesPrintFilter.Size = New System.Drawing.Size(185, 26)
        Me.ComboBoxDevicesPrintFilter.TabIndex = 2
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.Size = New System.Drawing.Size(1251, 505)
        Me.ReportViewer1.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(702, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(186, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'BackgroundWorker_LoadEquipmentNames
        '
        Me.BackgroundWorker_LoadEquipmentNames.WorkerReportsProgress = True
        Me.BackgroundWorker_LoadEquipmentNames.WorkerSupportsCancellation = True
        '
        'DevicesPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 505)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ComboBoxDevicesPrintFilter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DevicesPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDevicesPrintFilter As System.Windows.Forms.ComboBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker_LoadEquipmentNames As System.ComponentModel.BackgroundWorker
End Class
