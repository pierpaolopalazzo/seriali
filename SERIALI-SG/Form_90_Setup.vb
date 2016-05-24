Public Class Form_90_Setup
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMemorizza.Click
        My.Settings.SqlServerIPAddress = SQL_IP.Text
        My.Settings.SqlServerUsername = SQL_User.Text
        My.Settings.SqlServerPassword = SQL_Pass.Text
        My.Settings.SqlServerDB = SQL_DB.Text
        My.Settings.MySqlIPAddress = MySql_IP.Text
        My.Settings.MySqlUsername = MySql_User.Text
        My.Settings.MySqlPassword = MySql_Pass.Text
        My.Settings.MySqlDB = MySql_DB.Text
        My.Settings.Save()
    End Sub

    Private Sub Form_90_Setup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_00_HOME.Show()
        Me.Hide()
    End Sub

    Private Sub Form_90_Setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQL_IP.Text = My.Settings.SqlServerIPAddress
        SQL_IP.Text = My.Settings.SqlServerIPAddress
        SQL_User.Text = My.Settings.SqlServerUsername
        SQL_Pass.Text = My.Settings.SqlServerPassword
        SQL_DB.Text = My.Settings.SqlServerDB
        MySql_IP.Text = My.Settings.MySqlIPAddress
        MySql_User.Text = My.Settings.MySqlUsername
        MySql_Pass.Text = My.Settings.MySqlPassword
        MySql_DB.Text = My.Settings.MySqlDB

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim righe As Integer

        DoBrowse("SELECT Bolle.*, BolleTipi.Descrizione, [Descrizione causale] FROM Bolle INNER JOIN BolleTipi ON Bolle.[Tipo documento] = BolleTipi.IdTipoDocumento LEFT OUTER JOIN [Causali bolle] ON Bolle.[Causale bolla] = [Causali bolle].[ID causale] WHERE (Bolle.[Tipo documento] = 5 OR Bolle.[Tipo documento] = 13) and ([Causali bolle].[Tipo documento]=5 or [Causali bolle].[Tipo documento]=13) and Bolle.[Data bolla]>='" & data1Conv & "'  and Bolle.[Data bolla]<='" & data2Conv & "' and [Descrizione causale] like '%ACQUISTO%'", "Bolle")
        Try
            righe = DSSQL.Tables("Bolle").Rows.Count
        Catch
            MsgBox("test fallito")
            Return
        End Try
        If righe > 0 Then
            MsgBox("test ok")
            Return
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class