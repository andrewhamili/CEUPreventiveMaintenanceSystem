Imports MySql.Data.MySqlClient

Module GlobalVariableModule1
    Public MySQLConn As New MySqlConnection
    Public connstring As String = "server=" & My.Settings.Server & ";port=" & My.Settings.Port & ";userid=" & Actions.ToInsecureString(Actions.DecryptString(My.Settings.Username)) & ";password=" & Actions.ToInsecureString(Actions.DecryptString(My.Settings.Password)) & ";database=" & My.Settings.Database
    Public comm As MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As New MySqlDataAdapter
    Public username As String
    Public activeuserfname As String
    Public activeuserlname As String
    Public usertype As String

    Public tempequipmentnumber As String
    Public tempequipmentname As String
    Public tempequipmentmodel As String
    Public tempequipmentserial As String
    Public tempequipmentdatepurchase As Date
    Public tempequipmentlocation As String
    Public tempequipmentowner As String
    Public tempprice As Decimal
    Public tempbranch As String
    Public tempmaintenancesched As String
    Public temppersonincharge As String

    Public systemversion As Integer = 1000


End Module
