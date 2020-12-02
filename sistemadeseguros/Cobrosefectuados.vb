Imports System.Data
Imports System.Data.OleDb

Public Class Cobrosefectuados
    Private Sub Cobrosefectuados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "SELECT * FROM FACTURACION"
        oda = New OleDbDataAdapter(consulta, con)
        ods.Tables.Add("FACTURACION")
        oda.Fill(ods.Tables("FACTURACION"))

        DataGridView1.DataSource = ods.Tables("FACTURACION")
        With DataGridView1
            .Columns("nombre").DisplayIndex = 4
            .Columns("vencimientodepago").DisplayIndex = 7
        End With




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        llenarExcel(DataGridView1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n As Date = Now

        If Button2.Text = "PAGOS VENCIDOS" Then

            For i = 0 To DataGridView1.RowCount - 1


                If DataGridView1.Rows.Item(i).Cells(7).Value > n Then
                    DataGridView1.Rows.Item(i).Cells(6).Value = ""
                    DataGridView1.Rows.Item(i).Cells(5).Value = ""
                    DataGridView1.Rows.Item(i).Cells(4).Value = ""
                    DataGridView1.Rows.Item(i).Cells(3).Value = ""
                    DataGridView1.Rows.Item(i).Cells(3).Value = ""
                    DataGridView1.Rows.Item(i).Cells(1).Value = ""
                    DataGridView1.Rows.Item(i).Cells(7).Value = ""
                    DataGridView1.Rows.Item(i).Cells(8).Value = ""
                    DataGridView1.Rows.Item(i).Cells(9).Value = ""
                    DataGridView1.Rows.Item(i).Cells(11).Value = ""
                    DataGridView1.Rows.Item(i).Cells(12).Value = ""
                    DataGridView1.Rows.Item(i).Cells(10).Value = DBNull.Value
                    DataGridView1.Rows.Item(i).Cells(0).Value = DBNull.Value
                    DataGridView1.Rows.Item(i).Cells(2).Value = DBNull.Value




                End If



            Next
            DataGridView1.Sort(DataGridView1.Columns(7), ComponentModel.ListSortDirection.Descending)
            Button2.Text = "VOLVER"
            Button2.ForeColor = Color.Black




        ElseIf Button2.Text = "VOLVER" Then
            Button2.Text = "PAGOS VENCIDOS"
            Button2.ForeColor = Color.Red
                mostrar()
            End If


    End Sub




End Class