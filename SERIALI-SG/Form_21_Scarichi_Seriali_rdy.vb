Public Class Form_21_Scarichi_Seriali_rdy

    Dim totPZ As Integer = 0

    Private Sub btnVerifica_Click(sender As Object, e As EventArgs) Handles btnVerifica.Click
        verifica()
    End Sub
    Sub verifica()

        Dim data1 As Date = DataIns.Value
        Dim data1Conv = data1.ToString("yyyyMMdd")
        Dim data2 As Date = DataIns2.Value
        Dim data2Conv = data2.ToString("yyyyMMdd")

        Dim righetotali As Integer
        Dim paginaReady As String
        Dim paginaSeriali As String
        Dim risultato As String = ""

        MyDoBrowse("SELECT DOC, DATA, FORNITORE, DATADOC, count(SERIALE) AS TOT, IFNULL(num_fattura, 'VUOTO') as FATTURA FROM SERIALI WHERE DATA>='" & data1Conv & "' AND  DATA<='" & data2Conv & "' AND CARICATO='SCARICO' GROUP BY DOC, DATA, FORNITORE, datadoc ORDER BY DOC", "SERIALI")

        Try
            righetotali = DSMYSQL.Tables("SERIALI").Rows.Count
        Catch
            MsgBox("Database seriali non disponibile. Verificare Setup")
            Return
        End Try

        'aggiungo i risultati alla griglia
        Dim dt As DataTable = DSMYSQL.Tables("seriali")
        DataGridView1.DataSource = dt

        'creo il pulsante per la modifica del numero fattura
        If DataGridView1.Columns("btnMod") Is Nothing Then
            Dim btnMod As New DataGridViewButtonColumn
            btnMod.HeaderText = "MOD."
            btnMod.Text = "Mod."
            btnMod.Name = "btnMod"
            btnMod.UseColumnTextForButtonValue = True
            DataGridView1.Columns.Insert(6, btnMod)
        End If

        DataGridView1.Refresh()

        If righetotali > 0 Then
            For Each riga As Data.DataRow In DSMYSQL.Tables("SERIALI").Rows

                paginaSeriali = "<table style='font-family: verdana;font-size: 10pt;margin-bottom:5px' width='100%'>"
                paginaSeriali += "  <tr style='background: cornflowerblue;color: #fff;font-weight: bold;'>"
                paginaSeriali += "      <td style='border: solid 1px #ccc;padding:5px'>Documento</td>"
                paginaSeriali += "      <td style='border: solid 1px #ccc;padding:5px'>Fornitore</td>"
                paginaSeriali += "      <td style='width:80px; text-align:right'>Tot</td>"
                paginaSeriali += "  </tr>"
                paginaSeriali += "  <tr class='Padding'>"
                paginaSeriali += "      <td style='border: solid 1px #ccc;padding:5px'>" & riga("DOC") & "</td>"
                paginaSeriali += "      <td style='border: solid 1px #ccc;padding:5px'>" & riga("FORNITORE") & "</td>"
                paginaSeriali += "      <td style='width:80px; text-align:right;border: solid 1px #ccc;'>" & riga("TOT") & "</td>"
                paginaSeriali += "  </tr>"
                paginaSeriali += Dettagli(riga("DOC"), riga("FORNITORE"))
                paginaSeriali += "</table>"

                paginaReady = verificaReady(riga("FATTURA"), Microsoft.VisualBasic.Left(riga("FORNITORE"), 10), riga("datadoc"))

                risultato += "<table id='tableID' style='width:100%;font-family: verdana;font-size: 10pt;margin-bottom:5px'>"
                risultato += "  <tr style='vertical-align:top;'>"
                risultato += "      <td align='right' style='width:50%'>" & paginaReady & "</td>"
                risultato += "      <td align='left' style='width:50%'>" & paginaSeriali & "</td>"
                risultato += "  </tr>"
                risultato += "</table>"
                risultato += "<hr />"
            Next
        End If

        Dim ris2 As String

        ris2 = ""

        ris2 = "<table style='font-family: verdana;font-size: 14pt;width:100%;text-align:center;'>"
        ris2 += "   <tr>"
        ris2 += "       <td style='width:50%;background-color: #B4C9F1;'>Scarico Ready PRO</td>"
        ris2 += "       <td style='width:50%;background-color: #B4C9F1;'>Scarico IMEI</td>"
        ris2 += "   </tr>"
        ris2 += "</table>"
        ris2 += risultato
        WebBrowser1.DocumentText = ris2

        'WebBrowser1.DocumentText = "<table style='font-family: verdana;font-size: 14pt;width:100%;text-align:center;'><tr><td style='width:50%;background-color: #B4C9F1;'>Carico IMEI</td><td style='width:50%;background-color: #E8A4A5;'>Carico Ready PRO</td></tr></table>" & risultato

    End Sub
    Function Dettagli(ByVal doc As String, ByVal forn As String) As String
        Dim risultato As String = ""
        Dim righetotali As Integer
        MyDoBrowse2("SELECT CODICE, NMU_DA_SCARICO, COUNT(SERIALE) AS TOT FROM SERIALI WHERE DOC='" & doc & "' AND FORNITORE='" & forn & "' GROUP BY CODICE, NMU_DA_SCARICO ORDER BY NMU_DA_SCARICO", "SERIALI")
        righetotali = DSMYSQL2.Tables("SERIALI").Rows.Count
        If righetotali > 0 Then
            risultato = "<tr style='background: #DEE8F7;font-weight: bold;color:#333;'><td style='border: solid 1px #ccc;padding:5px'>Codice</td><td style='border: solid 1px #ccc;padding:5px'>Cod. Art</td><td style='width:80px; text-align:right'>Pezzi</td></tr>"
            For Each riga As Data.DataRow In DSMYSQL2.Tables("SERIALI").Rows
                risultato += "<tr><td style='border: solid 1px #ccc;padding:5px'>" & riga("CODICE") & "</td><td style='border: solid 1px #ccc;padding:5px'>" & riga("NMU_DA_SCARICO") & "</td><td style='width:80px; text-align:right;border: solid 1px #ccc;text-align:right;padding:5px;'>" & riga("TOT") & "</td></tr>"
            Next
        End If
        Return risultato
    End Function

    Function verificaReady(ByVal bolla As String, ByVal forn As String, ByVal datadoc As String) As String
        Dim stringa As String = ""
        Dim riga As Data.DataRow
        Dim query As String


        'query = "SELECT Bolle.*, BolleTipi.Descrizione, [Descrizione causale] FROM Bolle INNER JOIN BolleTipi ON Bolle.[Tipo documento] = BolleTipi.IdTipoDocumento LEFT OUTER JOIN [Causali bolle] ON Bolle.[Causale bolla] = [Causali bolle].[ID causale] WHERE (Bolle.[Tipo documento] = 1 OR Bolle.[Tipo documento] = 2) and [Data Bolla]=CONVERT(datetime,'" & datadoc & "', 103) and ([Causali bolle].[Tipo documento]=1 or [Causali bolle].[Tipo documento]=2) and (Bolle.[Numero bolla] = '" & bolla & "' or [Documento di riferimento]='" & bolla & "') and Intestazione LIKE '" & forn & "%' and [Descrizione causale] like '%VENDITA%'"
        query = "SELECT Bolle.*, BolleTipi.Descrizione, [Descrizione causale] FROM Bolle INNER JOIN BolleTipi ON Bolle.[Tipo documento] = BolleTipi.IdTipoDocumento LEFT OUTER JOIN [Causali bolle] ON Bolle.[Causale bolla] = [Causali bolle].[ID causale] WHERE (Bolle.[Tipo documento] = 1 OR Bolle.[Tipo documento] = 2)  and ([Causali bolle].[Tipo documento]=1 or [Causali bolle].[Tipo documento]=2) and (Bolle.[Numero bolla] = '" & bolla & "' or [Documento di riferimento]='" & bolla & "') and Intestazione LIKE '" & forn & "%' and [Descrizione causale] like '%VENDITA%'"
        DoBrowse(query, "Bolle")
        If DSSQL.Tables("Bolle").Rows.Count > 0 Then
            riga = DSSQL.Tables("Bolle").Rows(0)
            stringa = "<table style='font-family: verdana;font-size: 10pt;margin-bottom:5px' width='100%'><tr style='background: cornflowerblue;color: #fff;font-weight: bold;'><td style='border: solid 1px #ccc;padding:5px'>Documento</td><td style='border: solid 1px #ccc;padding:5px'>Fornitore</td><td style='border: solid 1px #ccc;text-align:right'>TOTALE</td></tr>"
            stringa += "<tr class='Padding'><td style='border: solid 1px #ccc;padding:5px'>" & bolla & "</td><td style='border: solid 1px #ccc;padding:5px'>" & forn & "</td><td style='border: solid 1px #ccc;text-align:right'>@PEZZI</td></tr>"
            stringa += dettaglioReady(riga("Id bolla"))
            stringa += "</table>"
            stringa = Replace(stringa, "@PEZZI", totPZ)
            totPZ = 0
        Else
            stringa = "<table style='font-family: verdana;font-size: 10pt;margin-bottom:5px;width:100%;background:red;'><tr style='background: cornflowerblue;color: #fff;font-weight: bold;'><td style='border: solid 1px #ccc;padding:5px'>Documento</td><td colspan='2' style='border: solid 1px #ccc;'>Fornitore</td></tr>"
            stringa += "<tr class='Padding'><td style='border: solid 1px #ccc;padding:5px'>" & bolla & "</td><td style='border: solid 1px #ccc;padding:5px'>" & forn & "</td></tr>"
            stringa += "<tr><td colspan='3' style='border: solid 1px #ccc;'><b>Nessun carico trovato!</b></td></tr>"
            stringa += "</table>"
        End If
        Return stringa
    End Function

    Function dettaglioReady(ByVal cod As Integer) As String

        Dim risultato As String = ""
        DoBrowse2("SELECT [Bolle dettaglio].*, isnull(Barcodes.Barcode,'nessuno') as Barcode FROM [Bolle dettaglio] LEFT JOIN Barcodes ON [Bolle dettaglio].[ID articolo] = Barcodes.[ID articolo] WHERE [Bolle dettaglio].[Id bolla]=" & cod & " AND [Codice articolo] <> '' ORDER BY [Codice articolo]", "Bolle dettaglio")
        If DSSQL2.Tables("Bolle dettaglio").Rows.Count > 0 Then
            risultato = "<tr style='background: #DEE8F7;font-weight: bold;color:#333;'><td style='border: solid 1px #ccc;padding:5px'>Codice</td><td style='border: solid 1px #ccc;padding:5px'>Cod. Art</td><td style='width:80px; text-align:right'>Pezzi</td></tr>"
            For Each riga As Data.DataRow In DSSQL2.Tables("Bolle dettaglio").Rows
                risultato += "<tr><td style='border: solid 1px #ccc;padding:5px'><a href='#' title='" & riga("Descrizione") & "'>" & riga("Barcode") & "</a></td><td style='border: solid 1px #ccc;padding:5px'><a href='#' title='" & riga("Descrizione") & "'>" & riga("Codice articolo") & "</a></td><td style='width:80px; text-align:right;border: solid 1px #ccc;text-align:right;padding:5px;'>" & riga("Quantita'") & "</td></tr>"
                totPZ += riga("Quantita'")
            Next
        End If
        Return risultato

    End Function

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 6 Then
            Dim risultato As Integer = 0

            Dim doc As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Dim fornitore As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            Dim data As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            Dim numFattura As String = DataGridView1.Rows(e.RowIndex).Cells(5).Value

            If numFattura = "VUOTO" Then
                MsgBox("Devi inserire il numero di fattura corrispondente!!")
            Else
                risultato = updateFatt(numFattura, doc, fornitore, data)
                If risultato > 0 Then
                    MsgBox("Fattura inserita correttmente... " & risultato & " righe modificate")
                    DataGridView1.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.Green
                Else
                    MsgBox("Problema!!!! " & risultato & " righe modificate")
                    DataGridView1.Rows(e.RowIndex).Cells(4).Value = "VUOTO"
                    DataGridView1.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.Red
                End If
            End If
            'MsgBox(("Row : " + e.RowIndex.ToString & "  Col : ") + e.ColumnIndex.ToString + "contenuto: " & DataGridView1.Rows(e.RowIndex).Cells(4).Value)
        End If
    End Sub

    Private Sub Carichi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_00_HOME.Show()
        Me.Hide()
    End Sub

    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.TabIndexChanged
        Dim prova As String = TabControl1.SelectedTab.ToString
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        verifica()
    End Sub
End Class