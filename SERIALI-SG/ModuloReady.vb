Imports System.Data.SqlClient

Module ModuloReady
    Public ConnSQL As New SqlConnection
    Public DASQL As New SqlDataAdapter
    Public DSSQL As New Data.DataSet
    Public DASQL2 As New SqlDataAdapter
    Public DSSQL2 As New Data.DataSet

    Sub ApriConnessione()
        ConnSQL.Close()
        ConnSQL.ConnectionString = "Data Source=" & My.Settings.SqlServerIPAddress & ";Initial Catalog=" & My.Settings.SqlServerDB & ";User ID=" & My.Settings.SqlServerUsername & ";Password=" & My.Settings.SqlServerPassword 'ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
        ConnSQL.Open()
    End Sub

    Sub ChiudiConnessione()
        ConnSQL.Close()
    End Sub

    Function DoBrowse(ByVal str As String, ByVal tab As String) As Boolean
        Try
            ApriConnessione()
            DSSQL.Clear()
            DASQL.SelectCommand = New SqlCommand(str, ConnSQL)
            DASQL.Fill(DSSQL, tab)
            ChiudiConnessione()
            Return True
        Catch e As Exception
            Return False
        End Try
    End Function
    Function DoBrowse2(ByVal str As String, ByVal tab As String) As Boolean
        Try
            ApriConnessione()
            DSSQL2.Clear()
            DASQL2.SelectCommand = New SqlCommand(str, ConnSQL)
            DASQL2.Fill(DSSQL2, tab)
            ChiudiConnessione()
            Return True
        Catch e As Exception
            Return False
        End Try
    End Function

End Module
