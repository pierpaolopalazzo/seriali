<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_21_Scarichi_Seriali_rdy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataIns2 = New System.Windows.Forms.DateTimePicker()
        Me.DataIns = New System.Windows.Forms.DateTimePicker()
        Me.btnMail = New System.Windows.Forms.Button()
        Me.btnVerifica = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtOrd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCli = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataIns2
        '
        Me.DataIns2.Location = New System.Drawing.Point(224, 9)
        Me.DataIns2.Name = "DataIns2"
        Me.DataIns2.Size = New System.Drawing.Size(200, 20)
        Me.DataIns2.TabIndex = 14
        '
        'DataIns
        '
        Me.DataIns.Location = New System.Drawing.Point(12, 9)
        Me.DataIns.Name = "DataIns"
        Me.DataIns.Size = New System.Drawing.Size(200, 20)
        Me.DataIns.TabIndex = 13
        '
        'btnMail
        '
        Me.btnMail.Location = New System.Drawing.Point(1085, 8)
        Me.btnMail.Name = "btnMail"
        Me.btnMail.Size = New System.Drawing.Size(75, 23)
        Me.btnMail.TabIndex = 12
        Me.btnMail.Text = "Invia Email"
        Me.btnMail.UseVisualStyleBackColor = True
        '
        'btnVerifica
        '
        Me.btnVerifica.Location = New System.Drawing.Point(998, 8)
        Me.btnVerifica.Name = "btnVerifica"
        Me.btnVerifica.Size = New System.Drawing.Size(75, 23)
        Me.btnVerifica.TabIndex = 11
        Me.btnVerifica.Text = "Verifica"
        Me.btnVerifica.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(6, 6)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1140, 612)
        Me.WebBrowser1.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1140, 618)
        Me.DataGridView1.TabIndex = 15
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 38)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1160, 650)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1152, 624)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Modifica"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.WebBrowser1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1152, 624)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Verifica"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtOrd
        '
        Me.txtOrd.Location = New System.Drawing.Point(511, 9)
        Me.txtOrd.Name = "txtOrd"
        Me.txtOrd.Size = New System.Drawing.Size(113, 20)
        Me.txtOrd.TabIndex = 17
        Me.txtOrd.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(436, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Num Ordine"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(636, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Cliente"
        '
        'txtCli
        '
        Me.txtCli.Location = New System.Drawing.Point(687, 9)
        Me.txtCli.Name = "txtCli"
        Me.txtCli.Size = New System.Drawing.Size(299, 20)
        Me.txtCli.TabIndex = 19
        Me.txtCli.Tag = ""
        '
        'Form_21_Scarichi_Seriali_rdy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 696)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCli)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOrd)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.DataIns2)
        Me.Controls.Add(Me.DataIns)
        Me.Controls.Add(Me.btnMail)
        Me.Controls.Add(Me.btnVerifica)
        Me.Name = "Form_21_Scarichi_Seriali_rdy"
        Me.Text = "Form_21_Scarichi_Seriali_rdy"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataIns2 As DateTimePicker
    Friend WithEvents DataIns As DateTimePicker
    Friend WithEvents btnMail As Button
    Friend WithEvents btnVerifica As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtOrd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCli As TextBox
End Class
