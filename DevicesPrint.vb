Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms


Public Class DevicesPrint

    Public DeviceHeader As String
    Public comboboxadditional As String = "All"
    Public staffnames As List(Of String)
    Public Schedules As String() = {"All", "Monthly", "Quarterly", "Semi-Annually", "Annually"}
    Public equipmentlist As List(Of String)

    Private Sub DevicesPrint_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Frm_Main.Show()
    End Sub

    Private Sub DevicesPrint_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()

    End Sub

    Private Sub DevicesPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring

        Try



            MySQLConn.Open()


            Dim query As String

            query = "SELECT equipmentnumber, equipmentmodel, equipmentserial, equipmentowner, equipmentlocation, DATE_FORMAT(equipmentdatepurchase, '%m/%d/%Y') AS equipmentdatepurchase, concat('Php.', format(equipmentprice, 2)) AS equipmentprice FROM equipmentlist"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            DeviceHeader = ""
            Dim EquipmentName As New ReportParameter("equipmentname", DeviceHeader)
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)

            adapter.Fill(ds.Tables(1))

            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report2.rdlc"
            ReportViewer1.LocalReport.SetParameters(EquipmentName)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(1)))

            'Me.ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 25
            MySQLConn.Close()
            Me.ReportViewer1.RefreshReport()
            Load_equipmentnames()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

   
    Private Sub ComboBoxDevicesPrintFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxDevicesPrintFilter.SelectedIndexChanged

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        If ComboBoxDevicesPrintFilter.Text = "All" Then

            MySQLConn.ConnectionString = connstring

            Try



                MySQLConn.Open()


                Dim query As String

                query = "SELECT equipmentnumber, equipmentmodel, equipmentserial, equipmentowner, equipmentlocation, DATE_FORMAT(equipmentdatepurchase, '%m/%d/%Y') AS equipmentdatepurchase, concat('Php.', format(equipmentprice, 2)) AS equipmentprice FROM equipmentlist"
                Dim adapter As New MySqlDataAdapter
                Dim ds As New DataSet1
                DeviceHeader = ""
                Dim EquipmentName As New ReportParameter("equipmentname", DeviceHeader)
                adapter.SelectCommand = New MySqlCommand(query, MySQLConn)

                adapter.Fill(ds.Tables(1))

                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report2.rdlc"
                ReportViewer1.LocalReport.SetParameters(EquipmentName)
                ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(1)))

                'Me.ReportViewer1.RefreshReport()
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                ReportViewer1.ZoomMode = ZoomMode.Percent
                ReportViewer1.ZoomPercent = 25
                MySQLConn.Close()
                Me.ReportViewer1.RefreshReport()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        Else
            Try



                MySQLConn.Open()


                Dim query As String

                query = "SELECT equipmentnumber, equipmentmodel, equipmentserial, equipmentowner, equipmentlocation, DATE_FORMAT(equipmentdatepurchase, '%m/%d/%Y') AS equipmentdatepurchase, concat('Php.', format(equipmentprice, 2)) AS equipmentprice FROM equipmentlist where equipmentname=@chosenequipmentname"
                Dim adapter As New MySqlDataAdapter
                Dim ds As New DataSet1
                DeviceHeader = ComboBoxDevicesPrintFilter.Text
                Dim EquipmentName As New ReportParameter("equipmentname", DeviceHeader)
                adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
                adapter.SelectCommand.Parameters.AddWithValue("chosenequipmentname", ComboBoxDevicesPrintFilter.Text)

                adapter.Fill(ds.Tables(1))

                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report2.rdlc"
                ReportViewer1.LocalReport.SetParameters(EquipmentName)
                ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(1)))

                'Me.ReportViewer1.RefreshReport()
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                ReportViewer1.ZoomMode = ZoomMode.Percent
                ReportViewer1.ZoomPercent = 25
                MySQLConn.Close()
                Me.ReportViewer1.RefreshReport()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End If
    End Sub

    Public Sub Load_equipmentnames()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        Dim query As String
        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()
            query = "SELECT equipmentname FROM equipmentlist"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                ComboBoxDevicesPrintFilter.Items.Remove(reader.GetString("equipmentname"))
                ComboBoxDevicesPrintFilter.Items.Add(reader.GetString("equipmentname"))
            End While
            ComboBoxDevicesPrintFilter.Items.Add("All")
            ComboBoxDevicesPrintFilter.Text = "All"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class