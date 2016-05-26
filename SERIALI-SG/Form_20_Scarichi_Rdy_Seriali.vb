Public Class Form_20_Scarichi_Rdy_Seriali
    Private Sub Form_20_Scarichi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_00_HOME.Show()
        Me.Hide()
    End Sub

    Dim totPZ As Integer = 0

    Private Sub btnCerca_Click(sender As Object, e As EventArgs) Handles btnCerca.Click
        CercaReady()
    End Sub

    Sub CercaReady()
        Dim data1 As Date = DataIns.Value
        Dim data1Conv = data1.ToString("yyyy-MM-dd")
        Dim data2 As Date = DataIns2.Value
        Dim data2Conv = data2.ToString("yyyy-MM-dd")
        Dim paginaSeriali As String
        Dim paginaReady As String
        Dim righe As Integer
        Dim risultato As String
        Dim fornitore As String
        Dim docrif As String

        DoBrowse("SELECT Bolle.*, BolleTipi.Descrizione, [Descrizione causale] FROM Bolle INNER JOIN BolleTipi ON Bolle.[Tipo documento] = BolleTipi.IdTipoDocumento LEFT OUTER JOIN [Causali bolle] ON Bolle.[Causale bolla] = [Causali bolle].[ID causale] WHERE (Bolle.[Tipo documento] = 1 OR Bolle.[Tipo documento] = 2) and ([Causali bolle].[Tipo documento]=1 or [Causali bolle].[Tipo documento]=2) and Bolle.[Data bolla]>='" & data1Conv & "'  and Bolle.[Data bolla]<='" & data2Conv & "' and [Descrizione causale] like '%VENDITA%'", "Bolle")
        Try
            righe = DSSQL.Tables("Bolle").Rows.Count
        Catch
            MsgBox("Database Ready non disponibile. Verificare Setup")
            Return
        End Try
        risultato = ""
        If righe > 0 Then
            For Each riga As Data.DataRow In DSSQL.Tables("Bolle").Rows
                fornitore = Microsoft.VisualBasic.Left(riga("Intestazione"), 15)
                paginaReady = "<table  width='100%'>"
                paginaReady += "    <tr style='background: cornflowerblue;color: #fff;font-weight: bold;'>"
                paginaReady += "        <td>Documento</td>"
                paginaReady += "        <td>Fornitore</td>"
                paginaReady += "        <td text-align:right'>TOTALE</td>"
                paginaReady += "    </tr>"
                paginaReady += "    <tr class='Padding'>"
                paginaReady += "        <td>" & riga("numero bolla") & "</td>"
                paginaReady += "        <td>" & fornitore & "</td>"
                paginaReady += "        <td style='text-align:right'>@PEZZI</td>"
                paginaReady += "    </tr>"
                paginaReady += dettaglioReady(riga("Id bolla"))
                paginaReady += "</table>"
                paginaReady = Replace(paginaReady, "@PEZZI", totPZ)
                totPZ = 0

                Try
                    docrif = riga("Documento di riferimento")
                Catch
                    docrif = ""
                End Try
                paginaSeriali = caricaSeriali(riga("Numero bolla"), docrif, Microsoft.VisualBasic.Left(fornitore, 10))

                risultato += "<table id='tableID' style='width:100%'>"
                risultato += "  <tr style='vertical-align:top;'>"
                risultato += "      <td align='left' style='width:50%'>" & paginaReady & "</td>"
                risultato += "      <td align='right' style='width:50%'>" & paginaSeriali & "</td>"
                risultato += "  </tr>"
                risultato += "</table>"
                risultato += "<hr />"
            Next
        End If
        DSSQL.Dispose()
        WebBrowser1.DocumentText = "<style>#tableID{font-family: verdana;font-size: 10pt;margin-bottom:5px} #tableID table{font-family: verdana;font-size: 10pt;margin-bottom:5px;width:100%} #tableID table td{padding:5px;border: solid 1px #ccc;}</style><table style='font-family: verdana;font-size: 14pt;width:100%;text-align:center;'><tr><td style='width:50%;background-color: #B4C9F1;'>Scarico Ready PRO</td><td style='width:50%;background-color: #B4C9F1;'>Scarico IMEI</td></tr></table>" & risultato
    End Sub

    Function dettaglioReady(ByVal cod As Integer) As String
        Dim risultato As String = ""
        DoBrowse2("SELECT [Bolle dettaglio].*, isnull(Barcodes.Barcode,'nessuno') as Barcode FROM [Bolle dettaglio] LEFT JOIN Barcodes ON [Bolle dettaglio].[ID articolo] = Barcodes.[ID articolo] WHERE [Bolle dettaglio].[Id bolla]=" & cod & " AND [Codice articolo] <> '' ORDER BY [Codice articolo]", "Bolle dettaglio")
        If DSSQL2.Tables("Bolle dettaglio").Rows.Count > 0 Then
            risultato = "<tr style='background: #DEE8F7;font-weight: bold;color:#333;'><td>Codice</td><td>Cod. Art</td><td style='width:80px; text-align:right'>Pezzi</td></tr>"
            For Each riga As Data.DataRow In DSSQL2.Tables("Bolle dettaglio").Rows
                risultato += "<tr><td><a href='#' title='" & riga("Descrizione") & "'>" & riga("Barcode") & "</a></td><td><a href='#' title='" & riga("Descrizione") & "'>" & riga("Codice articolo") & "</a></td><td style='width:80px; text-align:right;border: solid 1px #ccc;text-align:right'>" & riga("Quantita'") & "</td></tr>"
                totPZ += riga("Quantita'")
            Next
        End If
        DSSQL2.Dispose()
        Return risultato
    End Function

    Function caricaSeriali(ByVal cod As String, ByVal rif As String, ByVal fornitore As String) As String
        Dim paginaSeriali As String = ""
        MyDoBrowse("SELECT CODICE, NMU_DA_SCARICO, DOC, COUNT(SERIALE) AS TOT FROM SERIALI WHERE FORNITORE LIKE'%" & fornitore & "%' AND (DOC='" & cod & "' OR DOC='" & rif & "')  ", "SERIALI")
        Try
            If DSMYSQL.Tables("seriali").Rows.Count > 0 Then
                For Each riga As Data.DataRow In DSMYSQL.Tables("SERIALI").Rows
                    paginaSeriali += "<table><tr style='background: cornflowerblue;color: #fff;font-weight: bold;'><td>Documento</td><td>Fornitore</td><td style='width:80px; text-align:right'>Tot</td></tr>"
                    paginaSeriali += "<tr class='Padding'><td>DOC " & cod & " - DOC RIFERIMENTO " & rif & "</td><td>" & fornitore & "</td><td style='width:80px; text-align:right;'>" & riga("TOT") & "</td></tr>"
                    paginaSeriali += Dettagli(riga("DOC"), fornitore) & "</table>"
                Next
            Else
                paginaSeriali = "<table style='font-family: verdana;font-size: 10pt;width:100%'><tr style='background: maroon;color: #fff;font-weight: bold;'><td>DOC " & cod & " - DOC RIFERIMENTO " & rif & "</td><td>" & fornitore & "</td><td style='width:80px; text-align:right'>0 pezzi</td></tr></table><p style='height: 65px;font-size: 20pt;text-align: center;line-height: 40pt;color: #fff;margin: 0;background-color:red;'>nessun risultato</p>"
            End If
        Catch ex As Exception
            paginaSeriali = "<table style='font-family: verdana;font-size: 10pt;width:100%'><tr style='background: maroon;color: #fff;font-weight: bold;'><td>DOC " & cod & " - DOC RIFERIMENTO " & rif & "</td><td>" & fornitore & "</td><td style='width:80px; text-align:right'>0 pezzi</td></tr></table><p style='height: 65px;font-size: 20pt;text-align: center;line-height: 40pt;color: #fff;margin: 0;background-color:red;'>nessun risultato</p>"
        End Try
        DSMYSQL.Dispose()
        Return paginaSeriali
    End Function

    Function Dettagli(ByVal doc As String, ByVal forn As String) As String
        Dim risultato As String = ""
        MyDoBrowse2("SELECT CODICE, NMU_DA_SCARICO, COUNT(SERIALE) AS TOT FROM SERIALI WHERE DOC='" & doc & "' AND FORNITORE like '%" & forn & "%'  GROUP BY CODICE, NMU_DA_SCARICO ORDER BY NMU_DA_SCARICO", "SERIALI")
        Dim righetotali As Integer = DSMYSQL2.Tables("SERIALI").Rows.Count
        If righetotali > 0 Then
            risultato = "<tr style='background: #DEE8F7;font-weight: bold;color:#333;'><td>Codice</td><td>Cod. Art</td><td style='width:80px; text-align:right'>Pezzi</td></tr>"
            For Each riga As Data.DataRow In DSMYSQL2.Tables("SERIALI").Rows
                risultato += "<tr><td>" & riga("CODICE") & "</td><td>" & riga("NMU_DA_SCARICO") & "</td><td style='width:80px; text-align:right;border: solid 1px #ccc;text-align:right'>" & riga("TOT") & "</td></tr>"
            Next
        End If
        DSMYSQL2.Dispose()
        Return risultato
    End Function
End Class