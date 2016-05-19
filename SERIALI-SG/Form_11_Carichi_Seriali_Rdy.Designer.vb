<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_11_Carichi_Seriali_Rdy
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
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnVerifica = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnMail = New System.Windows.Forms.Button()
        Me.DataIns2 = New System.Windows.Forms.DateTimePicker()
        Me.DataIns = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnVerifica
        '
        Me.btnVerifica.Location = New System.Drawing.Point(437, 11)
        Me.btnVerifica.Name = "btnVerifica"
        Me.btnVerifica.Size = New System.Drawing.Size(75, 23)
        Me.btnVerifica.TabIndex = 0
        Me.btnVerifica.Text = "Verifica"
        Me.btnVerifica.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(13, 43)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1159, 640)
        Me.WebBrowser1.TabIndex = 1
        '
        'btnMail
        '
        Me.btnMail.Location = New System.Drawing.Point(523, 11)
        Me.btnMail.Name = "btnMail"
        Me.btnMail.Size = New System.Drawing.Size(75, 23)
        Me.btnMail.TabIndex = 2
        Me.btnMail.Text = "Invia Email"
        Me.btnMail.UseVisualStyleBackColor = True
        '
        'DataIns2
        '
        Me.DataIns2.Location = New System.Drawing.Point(226, 12)
        Me.DataIns2.Name = "DataIns2"
        Me.DataIns2.Size = New System.Drawing.Size(200, 20)
        Me.DataIns2.TabIndex = 5
        '
        'DataIns
        '
        Me.DataIns.Location = New System.Drawing.Point(15, 12)
        Me.DataIns.Name = "DataIns"
        Me.DataIns.Size = New System.Drawing.Size(200, 20)
        Me.DataIns.TabIndex = 4
        '
        'Form_11_Carichi_Seriali_Rdy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 696)
        Me.Controls.Add(Me.DataIns2)
        Me.Controls.Add(Me.DataIns)
        Me.Controls.Add(Me.btnMail)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnVerifica)
        Me.Name = "Form_11_Carichi_Seriali_Rdy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confronto Carichi da Seriali a Ready"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVerifica As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents btnMail As System.Windows.Forms.Button
    Friend WithEvents DataIns2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataIns As System.Windows.Forms.DateTimePicker

End Class
