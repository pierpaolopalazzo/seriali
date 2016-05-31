Imports MySql.Data.MySqlClient
Public Class Form_23_Dettaglio_scarico

    Private docum As String

    Public Property VarDoc() As String
        Get
            Return docum
        End Get

        Set(ByVal Value As String)
            docum = Value
        End Set
    End Property

    Private fornitore As String
    Public Property VarForn() As String
        Get
            Return fornitore
        End Get

        Set(ByVal Value As String)
            fornitore = Value
        End Set
    End Property

    Private Data As String
    Public Property VarData() As String
        Get
            Return Data
        End Get

        Set(ByVal Value As String)
            Data = Value
        End Set
    End Property

    Private Sub Form_Dettaglio_scarico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MyDoBrowse("SELECT CODICE, NMU_DA_SCARICO, COUNT(SERIALE) AS TOT FROM SERIALI WHERE DOC='" & docum & "' AND FORNITORE='" & fornitore & "' AND data='" & Data & "' GROUP BY CODICE, NMU_DA_SCARICO ORDER BY NMU_DA_SCARICO", "SERIALI")
        Me.Text = "Documento num. " & docum & " del " & Data & " Cliente " & fornitore
        Dim DSMYSQLdett As New Data.DataSet
        Dim DAMYSQLdett As New MySqlDataAdapter

        ModuloSeriali.ApriConnessione()
        DAMYSQLdett.SelectCommand = New MySqlCommand("SELECT CODICE, EAN_DA_SCARICO, NMU_DA_SCARICO, COUNT(SERIALE) AS TOTALE_PEZZI FROM SERIALI WHERE DOC='" & docum & "' AND FORNITORE='" & fornitore & "' AND data='" & Data & "' GROUP BY CODICE, NMU_DA_SCARICO ORDER BY NMU_DA_SCARICO", ConnMYSQL)
        DAMYSQLdett.Fill(DSMYSQLdett, "seriali")
        ModuloSeriali.ChiudiConnessione()

        Dim dt As DataTable = DSMYSQLdett.Tables("seriali")

        DataGridDettaglio.DataSource = dt
        DataGridDettaglio.Refresh()
        'MsgBox(docum & " " & fornitore & " " & Data)
    End Sub
    Sub caricaRDY(ByVal cod As Integer)
        DoBrowse2("SELECT [Bolle dettaglio].*, isnull(Barcodes.Barcode,'nessuno') as Barcode FROM [Bolle dettaglio] LEFT JOIN Barcodes ON [Bolle dettaglio].[ID articolo] = Barcodes.[ID articolo] WHERE [Bolle dettaglio].[Id bolla]=" & cod & " AND [Codice articolo] <> '' ORDER BY [Codice articolo]", "Bolle dettaglio")
        If DSSQL2.Tables("Bolle dettaglio").Rows.Count > 0 Then
            Dim dt As DataTable = DSSQL2.Tables("[Bolle dettaglio]")
            DataGridRDY.DataSource = dt
            DataGridRDY.Refresh()

            'risultato = "<tr style='background: #DEE8F7;font-weight: bold;color:#333;'><td style='border: solid 1px #ccc;padding:5px'>Codice</td><td style='border: solid 1px #ccc;padding:5px'>Cod. Art</td><td style='width:80px; text-align:right'>Pezzi</td></tr>"
            'For Each riga As Data.DataRow In DSSQL2.Tables("Bolle dettaglio").Rows
            '    risultato += "<tr><td style='border: solid 1px #ccc;padding:5px'><a href='#' title='" & riga("Descrizione") & "'>" & riga("Barcode") & "</a></td><td style='border: solid 1px #ccc;padding:5px'><a href='#' title='" & riga("Descrizione") & "'>" & riga("Codice articolo") & "</a></td><td style='width:80px; text-align:right;border: solid 1px #ccc;text-align:right;padding:5px;'>" & riga("Quantita'") & "</td></tr>"
            '    totPZ += riga("Quantita'")
            'Next
        End If
    End Sub
End Class