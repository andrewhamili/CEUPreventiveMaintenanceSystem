Public Class PrintMode

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
        Frm_Main.Show()
        Frm_Main.TopMost = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        If rdio_equipmentlist.Checked = True Then
            DevicesPrint.ShowDialog()
        Else
            MaintenanceStaffPrinting.ShowDialog()
        End If

    End Sub
End Class