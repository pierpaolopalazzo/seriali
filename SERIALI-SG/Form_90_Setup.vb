Public Class Form_90_Setup
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
End Class