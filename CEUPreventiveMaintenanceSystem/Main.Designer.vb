<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits Telerik.WinControls.UI.RadForm

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
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.Equipments = New Telerik.WinControls.UI.RadPageViewPage()
        Me.Accounts = New Telerik.WinControls.UI.RadPageViewPage()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPageView1
        '
        Me.RadPageView1.Controls.Add(Me.Equipments)
        Me.RadPageView1.Controls.Add(Me.Accounts)
        Me.RadPageView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadPageView1.Location = New System.Drawing.Point(0, 0)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.Equipments
        Me.RadPageView1.Size = New System.Drawing.Size(471, 333)
        Me.RadPageView1.TabIndex = 0
        Me.RadPageView1.Text = "RadPageView1"
        Me.RadPageView1.ThemeName = "VisualStudio2012Dark"
        Me.RadPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage
        '
        'Equipments
        '
        Me.Equipments.ItemSize = New System.Drawing.SizeF(102.0!, 33.0!)
        Me.Equipments.Location = New System.Drawing.Point(205, 4)
        Me.Equipments.Name = "Equipments"
        Me.Equipments.Size = New System.Drawing.Size(262, 325)
        Me.Equipments.Text = "Equipments"
        '
        'Accounts
        '
        Me.Accounts.ItemSize = New System.Drawing.SizeF(79.0!, 45.0!)
        Me.Accounts.Location = New System.Drawing.Point(205, 4)
        Me.Accounts.Name = "Accounts"
        Me.Accounts.Size = New System.Drawing.Size(262, 325)
        Me.Accounts.Text = "Accounts"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 333)
        Me.Controls.Add(Me.RadPageView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Name = "Main"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Main"
        Me.ThemeName = "VisualStudio2012Dark"
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents Equipments As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents Accounts As Telerik.WinControls.UI.RadPageViewPage
End Class

