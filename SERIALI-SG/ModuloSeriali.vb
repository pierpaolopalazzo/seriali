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

    Function updateFatt(ByVal Nfatt As String, ByVal doc As String, ByVal cliente As String, ByVal datadoc As String) As Integer
        Dim operatore As String = System.Net.Dns.GetHostName & " - " & System.Environment.UserName
        Dim result As Integer = 0
        Dim cmd As New MySqlCommand
        Dim controlloIns As Integer = 0
        cmd.Connection = ConnMYSQL
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "UPDATE seriali set num_fattura='" & Nfatt & "', data_controllo='" & Date.Now.ToString("yyyyMMdd") & "', oreminutisecondi='" & Date.Now.ToString("hhmmss") & "', oper_controllo='" & operatore & "' where doc='" & doc & "' and fornitore ='" & cliente & "' and data='" & datadoc & "'"
        'ConnMYSQL.Open()
        result = cmd.ExecuteNonQuery()
        ConnMYSQL.Close()
        Return result
    End Function
End Module
