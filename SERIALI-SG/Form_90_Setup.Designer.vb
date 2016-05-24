<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_90_Setup
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelReadyIP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SQL_IP = New System.Windows.Forms.TextBox()
        Me.SQL_User = New System.Windows.Forms.TextBox()
        Me.SQL_Pass = New System.Windows.Forms.TextBox()
        Me.MySql_Pass = New System.Windows.Forms.TextBox()
        Me.MySql_User = New System.Windows.Forms.TextBox()
        Me.MySql_IP = New System.Windows.Forms.TextBox()
        Me.btnMemorizza = New System.Windows.Forms.Button()
        Me.SQL_DB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MySql_DB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelReadyIP
        '
        Me.LabelReadyIP.AutoSize = True
        Me.LabelReadyIP.Location = New System.Drawing.Point(31, 26)
        Me.LabelReadyIP.Name = "LabelReadyIP"
        Me.LabelReadyIP.Size = New System.Drawing.Size(150, 13)
        Me.LabelReadyIP.TabIndex = 0
        Me.LabelReadyIP.Text = "Indirizzo IP SQL Server Ready"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username SQL Server Ready"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password SQL Server Ready"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Indirizzo IP MySQL Server Seriali"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username MySQL Server Seriali"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password MySQL Server Seriali"
        '
        'SQL_IP
        '
        Me.SQL_IP.Location = New System.Drawing.Point(242, 18)
        Me.SQL_IP.Name = "SQL_IP"
        Me.SQL_IP.Size = New System.Drawing.Size(100, 20)
        Me.SQL_IP.TabIndex = 1
        Me.SQL_IP.Text = "127.0.0.1"
        '
        'SQL_User
        '
        Me.SQL_User.Location = New System.Drawing.Point(242, 43)
        Me.SQL_User.Name = "SQL_User"
        Me.SQL_User.Size = New System.Drawing.Size(100, 20)
        Me.SQL_User.TabIndex = 2
        Me.SQL_User.Text = "sa"
        '
        'SQL_Pass
        '
        Me.SQL_Pass.Location = New System.Drawing.Point(242, 69)
        Me.SQL_Pass.Name = "SQL_Pass"
        Me.SQL_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.SQL_Pass.Size = New System.Drawing.Size(100, 20)
        Me.SQL_Pass.TabIndex = 3
        Me.SQL_Pass.Text = "password"
        '
        'MySql_Pass
        '
        Me.MySql_Pass.Location = New System.Drawing.Point(242, 220)
        Me.MySql_Pass.Name = "MySql_Pass"
        Me.MySql_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.MySql_Pass.Size = New System.Drawing.Size(100, 20)
        Me.MySql_Pass.TabIndex = 7
        Me.MySql_Pass.Text = "password"
        '
        'MySql_User
        '
        Me.MySql_User.Location = New System.Drawing.Point(242, 194)
        Me.MySql_User.Name = "MySql_User"
        Me.MySql_User.Size = New System.Drawing.Size(100, 20)
        Me.MySql_User.TabIndex = 6
        Me.MySql_User.Text = "root"
        '
        'MySql_IP
        '
        Me.MySql_IP.Location = New System.Drawing.Point(242, 169)
        Me.MySql_IP.Name = "MySql_IP"
        Me.MySql_IP.Size = New System.Drawing.Size(100, 20)
        Me.MySql_IP.TabIndex = 5
        Me.MySql_IP.Text = "127.0.0.1"
        '
        'btnMemorizza
        '
        Me.btnMemorizza.Location = New System.Drawing.Point(142, 366)
        Me.btnMemorizza.Name = "btnMemorizza"
        Me.btnMemorizza.Size = New System.Drawing.Size(137, 30)
        Me.btnMemorizza.TabIndex = 9
        Me.btnMemorizza.Text = "Memorizza setup"
        Me.btnMemorizza.UseVisualStyleBackColor = True
        '
        'SQL_DB
        '
        Me.SQL_DB.Location = New System.Drawing.Point(242, 95)
        Me.SQL_DB.Name = "SQL_DB"
        Me.SQL_DB.Size = New System.Drawing.Size(100, 20)
        Me.SQL_DB.TabIndex = 4
        Me.SQL_DB.Text = "ReadyDB"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "DB SQL Server Ready"
        '
        'MySql_DB
        '
        Me.MySql_DB.Location = New System.Drawing.Point(242, 246)
        Me.MySql_DB.Name = "MySql_DB"
        Me.MySql_DB.Size = New System.Drawing.Size(100, 20)
        Me.MySql_DB.TabIndex = 8
        Me.MySql_DB.Text = "seriali"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "DB MySQL Server Seriali"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(34, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(308, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "memorizza + test DB Ready (solo connessione)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(34, 269)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(308, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "memorizza + test DB seriali (solo connessione)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form_90_Setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 433)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MySql_DB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SQL_DB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnMemorizza)
        Me.Controls.Add(Me.MySql_Pass)
        Me.Controls.Add(Me.MySql_User)
        Me.Controls.Add(Me.MySql_IP)
        Me.Controls.Add(Me.SQL_Pass)
        Me.Controls.Add(Me.SQL_User)
        Me.Controls.Add(Me.SQL_IP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelReadyIP)
        Me.Name = "Form_90_Setup"
        Me.Text = "Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelReadyIP As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SQL_IP As TextBox
    Friend WithEvents SQL_User As TextBox
    Friend WithEvents SQL_Pass As TextBox
    Friend WithEvents MySql_Pass As TextBox
    Friend WithEvents MySql_User As TextBox
    Friend WithEvents MySql_IP As TextBox
    Friend WithEvents btnMemorizza As Button
    Friend WithEvents SQL_DB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MySql_DB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
