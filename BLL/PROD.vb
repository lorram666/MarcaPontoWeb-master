Imports System.Data
Imports System.Data.SqlClient

<Assembly: CLSCompliant(True)>

#Region "REGRAS PROD"

' Classe final consumindo o BD, rotinas criadas por solicitações feitas na parte de DEV.

#End Region

Public Class PROD

    '' Criada: 21/06/2022 - Laurent Silva
    '' Ultima Modificacao: 21/06/2022
    '' Motivo: Atender solicitação de rotina DEV:RetornaUsuarios criada: 20/06/2022
    Public Function RetornaUsuarios() As DataTable

        Dim dt As DataTable = ExecutaProc("SP_RetornaUsuarios")
        Return dt

    End Function

    '' Criada: 21/06/2022 - Laurent Silva
    '' Ultima Modificacao: 20/06/2022
    '' Motivo: Rotina interna de acesso ao BD executando procedure e retornando DataTable
    Private Function ExecutaProc(Proc As String) As DataTable

        Using con As New SqlConnection("Conexao")
            Using cmd As New SqlCommand(Proc)
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                Using sda As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    sda.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

End Class
