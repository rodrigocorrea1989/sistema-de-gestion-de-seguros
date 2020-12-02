Imports System.Data.OleDb
Public Class vertodos





    Private Sub mostrar()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "SELECT * FROM USUARIOS"
        oda = New OleDbDataAdapter(consulta, con)
        ods.Tables.Add("USUARIOS")
        oda.Fill(ods.Tables("USUARIOS"))

        DataGridView1.DataSource = ods.Tables("USUARIOS")

        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        With DataGridView1
            .Columns("nombre").DisplayIndex = 5

        End With

    End Sub

    Private Sub vertodos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
End Class