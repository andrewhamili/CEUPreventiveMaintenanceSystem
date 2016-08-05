Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class ServiceCardPrint


    Public query As String

    Private Sub ServiceCardPrint_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        Device.Show()
        Device.Focus()
    End Sub

    Private Sub ServiceCardPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim equipmentnumber As New ReportParameter("number", Device.info_equipnum.Text)
        Dim equipmentname As New ReportParameter("name", Device.info_equipname.Text)
        Dim equipmentmodel As New ReportParameter("model", Device.info_equipmodel.Text)
        Dim equipmentserial As New ReportParameter("serial", Device.info_equipserialnum.Text)
        Dim equipmentlocation As New ReportParameter("location", Device.info_equiplocation.Text)
        Dim equipmentdateacquired As New ReportParameter("dateacquired", Device.info_equipdatepurchase.Text)
        Dim equipmentcost As New ReportParameter("unitcost", Device.info_equipprice.Text)
        Dim equipmentbranch As New ReportParameter("branch", Device.info_equipbranch.Text)
        Dim equipmentmaintenancesched As New ReportParameter("maintenancesched", Device.info_equipmaintenancesched.Text)

        MySQLConn.ConnectionString = connstring

        MySQLConn.Open()




        query = "SELECT DATE_FORMAT(date, '%m/%d/%Y') AS date, remarks, prevmaintenance, concat('Php.' ,cost) as cost, servicedby FROM maintenance WHERE equipmentserial=@equipmentserial"
        Dim adapter As New MySqlDataAdapter
        Dim ds As New DataSet1

        adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
        adapter.SelectCommand.Parameters.AddWithValue("equipmentserial", Device.equipserial)
        adapter.Fill(ds.Tables(0))

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"

        ReportViewer1.LocalReport.SetParameters(equipmentname)
        ReportViewer1.LocalReport.SetParameters(equipmentnumber)
        ReportViewer1.LocalReport.SetParameters(equipmentmodel)
        ReportViewer1.LocalReport.SetParameters(equipmentserial)
        ReportViewer1.LocalReport.SetParameters(equipmentlocation)
        ReportViewer1.LocalReport.SetParameters(equipmentdateacquired)
        ReportViewer1.LocalReport.SetParameters(equipmentcost)
        ReportViewer1.LocalReport.SetParameters(equipmentbranch)
        ReportViewer1.LocalReport.SetParameters(equipmentmaintenancesched)

        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

        'Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 25
        MySQLConn.Close()

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class