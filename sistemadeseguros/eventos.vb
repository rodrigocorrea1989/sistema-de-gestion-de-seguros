Imports System.Data
Imports System.Data.OleDb
Public Class eventos
    Private Sub eventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

    Private Sub mostrar()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "SELECT * FROM EVENTOS"
        oda = New OleDbDataAdapter(consulta, con)
        ods.Tables.Add("EVENTOS")
        oda.Fill(ods.Tables("EVENTOS"))

        DataGridView1.DataSource = ods.Tables("EVENTOS")


        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        With DataGridView1
            .Columns("id").DisplayIndex = 0
            .Columns("usuario").DisplayIndex = 1
            .Columns("actividad").DisplayIndex = 2
            .Columns("idpoliza").DisplayIndex = 3
            .Columns("dnicli").DisplayIndex = 4
        End With



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        segurosis.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        llenarExcel(DataGridView1)


    End Sub
End Class