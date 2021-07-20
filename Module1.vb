Imports System.Data.OleDb
Module Module1
    Public CONN As OleDbConnection
    Public DA As OleDbDataAdapter
    Public DS As DataSet
    Public CMD As OleDbCommand
    Public DR As OleDbDataReader
    Public STR As String
    Public RECORD As New BindingSource

    Sub Koneksi()
        STR = "provider=microsoft.ace.oledb.12.0; data source=" & Application.StartupPath & "\persedianbarang.accdb"
        CONN = New OleDbConnection(STR)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub

End Module
