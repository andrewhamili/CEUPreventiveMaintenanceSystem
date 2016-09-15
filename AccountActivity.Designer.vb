<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountActivity
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
        Me.DataGridView_AccountActivity = New System.Windows.Forms.DataGridView()
        Me.Button_Clear = New System.Windows.Forms.Button()
        CType(Me.DataGridView_AccountActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_AccountActivity
        '
        Me.DataGridView_AccountActivity.AllowUserToAddRows = False
        Me.DataGridView_AccountActivity.AllowUserToDeleteRows = False
        Me.DataGridView_AccountActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_AccountActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_AccountActivity.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_AccountActivity.Name = "DataGridView_AccountActivity"
        Me.DataGridView_AccountActivity.ReadOnly = True
        Me.DataGridView_AccountActivity.Size = New System.Drawing.Size(537, 189)
        Me.DataGridView_AccountActivity.TabIndex = 0
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(238, 195)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 1
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'AccountActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 224)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.DataGridView_AccountActivity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "AccountActivity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccountActivity"
        CType(Me.DataGridView_AccountActivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView_AccountActivity As System.Windows.Forms.DataGridView
    Friend WithEvents Button_Clear As System.Windows.Forms.Button
End Class
