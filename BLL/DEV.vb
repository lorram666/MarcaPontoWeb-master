
#Region "REGRAS DEV"

' Classe inicial onde as requisições são feitas, código apenas em hardcode.
' todo o esboço é feito em hard code e as regras de negócio são descritas aqui.

#End Region

Imports System.Data

Public Class DEV
    '' Criada: 21/06/2022 - Leonardo Ferreti
    '' Motivo: Exibir o grid de usuários no form XYZ
    Public Function RetornaUsuarios() As DataTable

        '' preciso de um datatable com os campos nome, login e senha de todos os usuarios do sistema por ordem de nome ascendente.
        Dim dt As New DataTable
        With dt
            ' COLUNAS
            .Columns.Add("NOME")
            .Columns.Add("LOGIN")
            .Columns.Add("SENHA")

            ' LINHAS
            .Rows.Add("LEONARDO FERRETI", "MAONOVOLANTE", "12345678")
            .Rows.Add("LAURENT SILVA", "MAONOVOLANTE", "123123123")
            .Rows.Add("GISELE PAIVA", "MAONOVOLANTE", "012332100")
            .Rows.Add("NATHALIA BERMUDEZ", "LULINHA", "PT13ROBAMASFAZ")

        End With

        Return dt

    End Function

End Class
