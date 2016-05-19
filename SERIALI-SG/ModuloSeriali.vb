Imports MySql.Data.MySqlClient
Module ModuloSeriali

    Public ConnMYSQL As New MySqlConnection
    Public DAMYSQL As New MySqlDataAdapter
    Public DSMYSQL As New Data.DataSet
    Public DAMYSQL2 As New MySqlDataAdapter
    Public DSMYSQL2 As New Data.DataSet

    Sub ApriConnessione()
        ConnMYSQL.Close()
        ConnMYSQL.ConnectionString = "host=" & My.Settings.MySqlIPAddress & "; username=" & My.Settings.MySqlUsername & ";password=" & My.Settings.MySqlPassword & ";database=" & My.Settings.MySqlDB
        ConnMYSQL.Open()
    End Sub

    Sub ChiudiConnessione()
        ConnSQL.Close()
    End Sub

    Function MyDoBrowse(ByVal str As String, ByVal tab As String) As Boolean
        Try
            ApriConnessione()
            DSMYSQL.Clear()
            DAMYSQL.SelectCommand = New MySqlCommand(str, ConnMYSQL)
            DAMYSQL.Fill(DSMYSQL, tab)
            ChiudiConnessione()
            Return True
        Catch e As Exception
            Return False
        End Try
    End Function
    Function MyDoBrowse2(ByVal str As String, ByVal tab As String) As Boolean
        Try
            ApriConnessione()
            DSMYSQL2.Clear()
            DAMYSQL2.SelectCommand = New MySqlCommand(str, ConnMYSQL)
            DAMYSQL2.Fill(DSMYSQL2, tab)
            ChiudiConnessione()
            Return True
        Catch e As Exception
            Return False
        End Try
    End Function
End Module
