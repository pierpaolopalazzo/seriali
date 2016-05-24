<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_00_HOME
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_00_HOME))
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.LabelCarichi = New System.Windows.Forms.Label()
        Me.btnCarichiRdySeriali = New System.Windows.Forms.Button()
        Me.btnCarichiSerRdy = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelScarichi = New System.Windows.Forms.Label()
        Me.btnScarichiSerialiRdy = New System.Windows.Forms.Button()
        Me.btnScarichiRdySeriali = New System.Windows.Forms.Button()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelSetup = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(356, 104)
        Me.PictureBoxLogo.TabIndex = 0
        Me.PictureBoxLogo.TabStop = False
        '
        'LabelCarichi
        '
        Me.LabelCarichi.AutoSize = True
        Me.LabelCarichi.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCarichi.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelCarichi.Location = New System.Drawing.Point(6, 130)
        Me.LabelCarichi.Name = "LabelCarichi"
        Me.LabelCarichi.Size = New System.Drawing.Size(106, 31)
        Me.LabelCarichi.TabIndex = 1
        Me.LabelCarichi.Text = "Carichi"
        '
        'btnCarichiRdySeriali
        '
        Me.btnCarichiRdySeriali.Image = CType(resources.GetObject("btnCarichiRdySeriali.Image"), System.Drawing.Image)
        Me.btnCarichiRdySeriali.Location = New System.Drawing.Point(17, 168)
        Me.btnCarichiRdySeriali.Name = "btnCarichiRdySeriali"
        Me.btnCarichiRdySeriali.Size = New System.Drawing.Size(353, 75)
        Me.btnCarichiRdySeriali.TabIndex = 2
        Me.btnCarichiRdySeriali.UseVisualStyleBackColor = True
        '
        'btnCarichiSerRdy
        '
        Me.btnCarichiSerRdy.Image = CType(resources.GetObject("btnCarichiSerRdy.Image"), System.Drawing.Image)
        Me.btnCarichiSerRdy.Location = New System.Drawing.Point(17, 249)
        Me.btnCarichiSerRdy.Name = "btnCarichiSerRdy"
        Me.btnCarichiSerRdy.Size = New System.Drawing.Size(353, 75)
        Me.btnCarichiSerRdy.TabIndex = 3
        Me.btnCarichiSerRdy.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(8, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(379, 2)
        Me.Label2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(8, 375)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(379, 2)
        Me.Label3.TabIndex = 6
        '
        'LabelScarichi
        '
        Me.LabelScarichi.AutoSize = True
        Me.LabelScarichi.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelScarichi.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelScarichi.Location = New System.Drawing.Point(6, 344)
        Me.LabelScarichi.Name = "LabelScarichi"
        Me.LabelScarichi.Size = New System.Drawing.Size(119, 31)
        Me.LabelScarichi.TabIndex = 5
        Me.LabelScarichi.Text = "Scarichi"
        '
        'btnScarichiSerialiRdy
        '
        Me.btnScarichiSerialiRdy.Image = CType(resources.GetObject("btnScarichiSerialiRdy.Image"), System.Drawing.Image)
        Me.btnScarichiSerialiRdy.Location = New System.Drawing.Point(17, 461)
        Me.btnScarichiSerialiRdy.Name = "btnScarichiSerialiRdy"
        Me.btnScarichiSerialiRdy.Size = New System.Drawing.Size(353, 75)
        Me.btnScarichiSerialiRdy.TabIndex = 8
        Me.btnScarichiSerialiRdy.UseVisualStyleBackColor = True
        '
        'btnScarichiRdySeriali
        '
        Me.btnScarichiRdySeriali.Image = CType(resources.GetObject("btnScarichiRdySeriali.Image"), System.Drawing.Image)
        Me.btnScarichiRdySeriali.Location = New System.Drawing.Point(17, 380)
        Me.btnScarichiRdySeriali.Name = "btnScarichiRdySeriali"
        Me.btnScarichiRdySeriali.Size = New System.Drawing.Size(353, 75)
        Me.btnScarichiRdySeriali.TabIndex = 7
        Me.btnScarichiRdySeriali.UseVisualStyleBackColor = True
        '
        'btnSetup
        '
        Me.btnSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetup.Location = New System.Drawing.Point(17, 584)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(353, 75)
        Me.btnSetup.TabIndex = 11
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(8, 579)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(379, 2)
        Me.Label5.TabIndex = 10
        '
        'LabelSetup
        '
        Me.LabelSetup.AutoSize = True
        Me.LabelSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSetup.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelSetup.Location = New System.Drawing.Point(6, 548)
        Me.LabelSetup.Name = "LabelSetup"
        Me.LabelSetup.Size = New System.Drawing.Size(90, 31)
        Me.LabelSetup.TabIndex = 9
        Me.LabelSetup.Text = "Setup"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(232, 548)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        '
        'Form_00_HOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 674)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelSetup)
        Me.Controls.Add(Me.btnScarichiSerialiRdy)
        Me.Controls.Add(Me.btnScarichiRdySeriali)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelScarichi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCarichiSerRdy)
        Me.Controls.Add(Me.btnCarichiRdySeriali)
        Me.Controls.Add(Me.LabelCarichi)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Name = "Form_00_HOME"
        Me.Text = "Sistema Seriali"
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents LabelCarichi As System.Windows.Forms.Label
    Friend WithEvents btnCarichiRdySeriali As System.Windows.Forms.Button
    Friend WithEvents btnCarichiSerRdy As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelScarichi As Label
    Friend WithEvents btnScarichiSerialiRdy As Button
    Friend WithEvents btnScarichiRdySeriali As Button
    Friend WithEvents btnSetup As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelSetup As Label
    Friend WithEvents Label1 As Label
End Class
