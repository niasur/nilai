Imports System
Imports System.Data
Imports System.Data.Odbc

Module Module1
    Public StrCon As String
    Public conMgr As OdbcConnection
    Public StrSQL As String
    Public objDataTable As DataTable
    Public objReader As OdbcDataReader
    Public objAdapter As OdbcDataAdapter
    Public objDataset As DataSet
    Public CommandMgr As OdbcCommand

    Public Sub koneksi()
        StrCon = "Driver={MySQL ODBC 3.51 Driver};database=db_nilai;server=localhost;uid=root"
        conMgr = New OdbcConnection("DSN=dsn_db_nilai")
        If conMgr.State = ConnectionState.Closed Then
            conMgr.Open()
        End If
    End Sub
End Module
