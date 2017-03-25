Imports MySql.Data.MySqlClient
Module Globals
    Public MySQLConn As New MySqlConnection
    Public connstring As String = "server=localhost;username=root;password=root;"
    Public database As String = "database=ceutltdprevmaintenance;"

    Public comm As New MySqlCommand
    Public reader As MySqlDataReader

End Module
