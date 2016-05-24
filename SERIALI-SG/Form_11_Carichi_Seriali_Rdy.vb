Imports EASendMail

Public Class Form_11_Carichi_Seriali_Rdy

    Dim totPZ As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnVerifica_Click(sender As Object, e As EventArgs) Handles btnVerifica.Click
        Dim data1 As Date = DataIns.Value
        Dim data1Conv = data1.ToString("yyyyMMdd")
        Dim data2 As Date = DataIns2.Value
        Dim data2Conv = data2.ToString("yyyyMMdd")
        Dim righetotali As Integer
        Dim paginaReady As String
        Dim paginaSeriali As String
        Dim risultato As String

        MyDoBrowse("SELECT DOC, FORNITORE, count(SERIALE) AS TOT FROM SERIALI WHERE DATA>='" & data1Conv & "' AND  DATA<='" & data2Conv & "' AND CARICATO='CARICO' GROUP BY DOC, FORNITORE ORDER BY DOC", "SERIALI")

        Try
            righetotali = DSMYSQL.Tables("SERIALI").Rows.Count
        Catch
            MsgBox("Database seriali non disponibile. Verificare Setup")
            Return
        End Try
        risultato = ""
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

                paginaReady = verificaReady(riga("DOC"), Microsoft.VisualBasic.Left(riga("FORNITORE"), 10))

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
        ris2 += "       <td style='width:50%;background-color: #B4C9F1;'>Carico Ready PRO</td>"
        ris2 += "       <td style='width:50%;background-color: #B4C9F1;'>Carico IMEI</td>"
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

    Function verificaReady(ByVal bolla As String, ByVal forn As String) As String
        Dim stringa As String = ""
        Dim riga As Data.DataRow
        Dim query As String


        query = "SELECT Bolle.*, BolleTipi.Descrizione, [Descrizione causale] FROM Bolle INNER JOIN BolleTipi ON Bolle.[Tipo documento] = BolleTipi.IdTipoDocumento LEFT OUTER JOIN [Causali bolle] ON Bolle.[Causale bolla] = [Causali bolle].[ID causale] WHERE (Bolle.[Tipo documento] = 5 OR Bolle.[Tipo documento] = 13) and ([Causali bolle].[Tipo documento]=5 or [Causali bolle].[Tipo documento]=13) and (Bolle.[Numero bolla] = '" & bolla & "' or [Documento di riferimento]='" & bolla & "') and Intestazione LIKE '" & forn & "%' and [Descrizione causale] like '%ACQUISTO%'"
        DoBrowse(query, "Bolle")
        If DSSQL.Tables("Bolle").Rows.Count > 0 Then
            riga = DSSQL.Tables("Bolle").Rows(0)
            stringa = "<table style='font-family: verdana;font-size: 10pt;margin-bottom:5px' width='100%'><tr style='background: cornflowerblue;color: #fff;font-weight: bold;'><td style='border: solid 1px #ccc;padding:5px'>Documento</td><td style='border: solid 1px #ccc;padding:5px'>Fornitore</td><td style='border: solid 1px #ccc;text-align:right'>TOTALE</td></tr>"
            stringa += "<tr class='Padding'><td style='border: solid 1px #ccc;padding:5px'>" & bolla & "</td><td style='border: solid 1px #ccc;padding:5px'>" & forn & query & "</td><td style='border: solid 1px #ccc;text-align:right'>@PEZZI</td></tr>"
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

    Private Sub btnMail_Click(sender As Object, e As EventArgs) Handles btnMail.Click
        If WebBrowser1.DocumentText = "" Then
            MsgBox("Devi effettuare la ricerca dei carichi")
        Else
            Dim oMail As New SmtpMail("TryIt")
            Dim oSmtp As New SmtpClient()

            oMail.From = "noreply@sg-trading.com"

            oMail.To = "maurorutigliano@gmail.com"

            Dim oggi As Date = Date.Now()
            Dim oggiConv = oggi.ToString("dd/MM/yyyy")
            oMail.Subject = "Carichi del " & oggiConv

            oMail.HtmlBody = WebBrowser1.DocumentText

            Dim oServer As New SmtpServer("smtp.gmail.com")

            oServer.Port = 465

            oServer.ConnectType = SmtpConnectType.ConnectSSLAuto

            oServer.User = "noreply@sg-trading.com"
            oServer.Password = "noreplySG16"
            Try
                oSmtp.SendMail(oServer, oMail)
                MsgBox("INVIATO!!")
            Catch ep As Exception
                MsgBox(ep.Message)
            End Try
        End If

    End Sub

    Private Sub Carichi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_00_HOME.Show()
        Me.Hide()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class
