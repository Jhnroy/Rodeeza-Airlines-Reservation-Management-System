
Imports MySql.Data.MySqlClient

Module Module1
    Public myadocon, conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public cmdRead As MySqlDataReader
    Public db_server = "'localhost'"
    Public db_uid = "'root'"
    Public db_pwd = "''"
    Public db_port = "'3306'"
    Public db_name = "'customer'"
    Public strConnection As String = "server=" & db_server & "; port=" & db_port & ";uid=" & db_uid & ";password=" & db_pwd & ";database=" & db_name & ";"


    Public Sub readquery(ByVal sql As String)
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strConnection
                .Open()
            End With
            With cmd
                .Connection = conn
                .CommandText = sql
                cmdRead = .ExecuteReader
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
