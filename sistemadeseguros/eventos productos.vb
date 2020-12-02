Imports System.Data
Imports System.Data.OleDb
Public Class eventos_productos
    Private Sub eventos_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "SELECT * FROM EVENTOSPRODUCTOS"
        oda = New OleDbDataAdapter(consulta, con)
        ods.Tables.Add("EVENTOSPRODUCTOS")
        oda.Fill(ods.Tables("EVENTOSPRODUCTOS"))

        DataGridView1.DataSource = ods.Tables("EVENTOSPRODUCTOS")
        With DataGridView1
            .Columns("usuario").DisplayIndex = 0
            .Columns("usuario").DisplayIndex = 1
            .Columns("actividad").DisplayIndex = 2
        End With




    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        llenarExcel(DataGridView1)
    End Sub


End Class