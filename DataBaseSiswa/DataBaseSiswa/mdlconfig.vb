Imports System.Data.OleDb
Module mdlconfig
    Public CONN As OleDbConnection
    Public DA As OleDbDataAdapter
    Public DS As DataSet
    Public CMD As OleDbCommand
    Public DR As OleDbDataReader

    Sub koneksiDB()
        Try
            CONN = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0; data source=data.accdb")
            CONN.Open()
            'MsgBox("Data base sukses")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
