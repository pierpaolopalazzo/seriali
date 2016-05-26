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
End Class