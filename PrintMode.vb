Public Class PrintMode

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
        Frm_Main.Show()
        Frm_Main.TopMost = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If rdio_equipmentlist.Checked = True Then
            DevicesPrint.ShowDialog()
            Me.Dispose()
        Else
            MaintenanceStaffPrinting.ShowDialog()
        End If

    End Sub

    Private Sub PrintMode_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Button2.PerformClick()
    End Sub
End Class