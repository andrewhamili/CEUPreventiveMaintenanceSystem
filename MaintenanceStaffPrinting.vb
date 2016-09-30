Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class MaintenanceStaffPrinting


    Public texts As String
    Public deadline As String

    Private Sub MaintenanceStaffPrinting_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Frm_Main.Show()
        Frm_Main.TopMost = True
        Frm_Main.TopMost = False

    End Sub

    Private Sub MaintenanceStaffPrinting_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
    End Sub
    Private Sub MaintenanceStaffPrinting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
Input:


        texts = InputBox("Enter the School Year:", "Preventive Maintenance", "2016")
        If texts = "" Then
            MsgBox("The School Year Field cannot be blank!", MsgBoxStyle.Critical, "CEU TLTD Preventive Maintenance")
            GoTo Input
        End If
        PrintMode.Dispose()
        lbl_schoolyear.Text = texts
        Dim schoolyear As New ReportParameter("schoolyear", texts)
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()

            Dim query As String

            query = "SELECT equipmentname, equipmentmodel, maintenancesched, personincharge FROM equipmentlist where maintenancesched!='-'"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)

            adapter.Fill(ds.Tables(2))

            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report3.rdlc"
            ReportViewer1.LocalReport.SetParameters(schoolyear)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(2)))

            'Me.ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 75
            MySQLConn.Close()
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
        Me.ReportViewer1.RefreshReport()
        StaffNames_For_Filter()
        ComboBoxStaffPrintFilter.Text = "All"
    End Sub

    Private Sub ComboBoxStaffPrintFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxStaffPrintFilter.SelectedIndexChanged
        If ComboBoxStaffPrintFilter.Text = "All" Then
            Dim schoolyear As New ReportParameter("schoolyear", texts)
            If MySQLConn.State = ConnectionState.Open Then
                MySQLConn.Close()
            End If


            MySQLConn.ConnectionString = connstring

            Try
                MySQLConn.Open()

                Dim query As String

                query = "SELECT equipmentname, equipmentmodel, maintenancesched, personincharge FROM equipmentlist where maintenancesched!='-'"
                Dim adapter As New MySqlDataAdapter
                Dim ds As New DataSet1
                adapter.SelectCommand = New MySqlCommand(query, MySQLConn)

                adapter.Fill(ds.Tables(2))

                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report3.rdlc"
                ReportViewer1.LocalReport.SetParameters(schoolyear)
                ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(2)))

                'Me.ReportViewer1.RefreshReport()
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                ReportViewer1.ZoomMode = ZoomMode.Percent
                ReportViewer1.ZoomPercent = 75
                MySQLConn.Close()
                Me.ReportViewer1.RefreshReport()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
            Me.ReportViewer1.RefreshReport()
        Else
            Dim schoolyear As New ReportParameter("schoolyear", texts)
            If MySQLConn.State = ConnectionState.Open Then
                MySQLConn.Close()
            End If


            MySQLConn.ConnectionString = connstring

            Try
                MySQLConn.Open()

                Dim query As String

                query = "SELECT equipmentname, equipmentmodel, maintenancesched, personincharge FROM equipmentlist WHERE maintenancesched=@sched"
                Dim adapter As New MySqlDataAdapter
                Dim ds As New DataSet1
                adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
                adapter.SelectCommand.Parameters.AddWithValue("sched", ComboBoxStaffPrintFilter.Text)
                adapter.Fill(ds.Tables(2))

                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report3.rdlc"
                ReportViewer1.LocalReport.SetParameters(schoolyear)
                ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(2)))

                'Me.ReportViewer1.RefreshReport()
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                ReportViewer1.ZoomMode = ZoomMode.Percent
                ReportViewer1.ZoomPercent = 75
                MySQLConn.Close()
                Me.ReportViewer1.RefreshReport()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Public Sub StaffNames_For_Filter()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String
        Try
            MySQLConn.Open()
            query = "SELECT fname, lname FROM userlist"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                Dim first As String = reader.GetString("fname")
                Dim last As String = reader.GetString("lname")
                Dim name As String = first + " " + last
                ComboBoxStaffNames.Items.Add(name)
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Private Sub ComboBoxStaffNames_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxStaffNames.SelectedIndexChanged
        If ComboBoxStaffNames.Text = "All" Then
            Dim schoolyear As New ReportParameter("schoolyear", texts)
            If MySQLConn.State = ConnectionState.Open Then
                MySQLConn.Close()
            End If


            MySQLConn.ConnectionString = connstring

            Try
                MySQLConn.Open()

                Dim query As String

                query = "SELECT equipmentname, equipmentmodel, maintenancesched, personincharge FROM equipmentlist"
                Dim adapter As New MySqlDataAdapter
                Dim ds As New DataSet1
                adapter.SelectCommand = New MySqlCommand(query, MySQLConn)

                adapter.Fill(ds.Tables(2))

                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report3.rdlc"
                ReportViewer1.LocalReport.SetParameters(schoolyear)
                ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(2)))

                'Me.ReportViewer1.RefreshReport()
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                ReportViewer1.ZoomMode = ZoomMode.Percent
                ReportViewer1.ZoomPercent = 75
                MySQLConn.Close()
                Me.ReportViewer1.RefreshReport()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
            Me.ReportViewer1.RefreshReport()
        Else
            Dim schoolyear As New ReportParameter("schoolyear", texts)
            If MySQLConn.State = ConnectionState.Open Then
                MySQLConn.Close()
            End If


            MySQLConn.ConnectionString = connstring

            Try
                MySQLConn.Open()

                Dim query As String

                query = "SELECT equipmentname, equipmentmodel, maintenancesched, personincharge FROM equipmentlist WHERE personincharge=@name"
                Dim adapter As New MySqlDataAdapter
                Dim ds As New DataSet1
                adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
                adapter.SelectCommand.Parameters.AddWithValue("name", ComboBoxStaffNames.Text)
                adapter.Fill(ds.Tables(2))

                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report3.rdlc"
                ReportViewer1.LocalReport.SetParameters(schoolyear)
                ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(2)))

                'Me.ReportViewer1.RefreshReport()
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                ReportViewer1.ZoomMode = ZoomMode.Percent
                ReportViewer1.ZoomPercent = 75
                MySQLConn.Close()
                Me.ReportViewer1.RefreshReport()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim schoolyear As New ReportParameter("schoolyear", texts)
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()

            Dim query As String

            query = "SELECT equipmentname, equipmentmodel, maintenancesched, personincharge FROM equipmentlist where maintenancesched='" & ComboBoxStaffPrintFilter.Text & "' AND personincharge='" & ComboBoxStaffNames.Text & "'"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
                adapter.SelectCommand = New MySqlCommand(query, MySQLConn)

            adapter.Fill(ds.Tables(2))

            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report3.rdlc"
            ReportViewer1.LocalReport.SetParameters(schoolyear)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(2)))

            'Me.ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 75
            MySQLConn.Close()
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class