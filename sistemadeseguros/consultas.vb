Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb

Class consultas
    Private Sub mostrarlistadepolizas()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String



        consulta = "SELECT * FROM POLIZAS"
        oda = New OleDbDataAdapter(consulta, con)
        ods.Tables.Add("POLIZAS")
        oda.Fill(ods.Tables("POLIZAS"))

        DataGridView2.DataSource = ods.Tables("POLIZAS")

        With DataGridView2
            .Columns("idpoliza").DisplayIndex = 0

        End With

        Dim n As Date = Now



        For i = 0 To DataGridView2.RowCount - 1
            If DataGridView2.Rows.Item(i).Cells(13).Value <= n Then
                DataGridView2.Rows.Item(i).Cells(11).Value = "VENCIDO"



            ElseIf DataGridView2.Rows.Item(i).Cells(13).Value > n Then

                DataGridView2.Rows.Item(i).Cells(11).Value = "ACTIVO"



            End If



        Next


    End Sub

    Private Sub listadepolizas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarlistadepolizas()





    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        llenarExcel(DataGridView2)



    End Sub



    Public Sub filtrardni()
        Dim cargar As New OleDbDataAdapter("SELECT * FROM POLIZAS WHERE DNI LIKE '" & txtadjuntardni.Text & "%'", con)
        Dim ds As New DataSet


        cargar.Fill(ds, "POLIZAS")
        DataGridView2.DataSource = ds.Tables("POLIZAS")



    End Sub
    Public Sub filtrarpromotor()
        Dim cargar As New OleDbDataAdapter("SELECT * FROM POLIZAS WHERE PROMOTOR LIKE '" & txtcomboreporte.Text & "%'", con)
        Dim ds As New DataSet


        cargar.Fill(ds, "POLIZAS")
        DataGridView2.DataSource = ds.Tables("POLIZAS")



    End Sub
    Public Sub cargarpromotres()


        Dim t As New DataTable
        Dim c As String = "SELECT NOMBREUSUARIO FROM USUARIOS"
        Dim a As New OleDbDataAdapter(c, con)



        a.Fill(t)

        txtcomboreporte.DataSource = t

        txtcomboreporte.DisplayMember = "NOMBREUSUARIO"







    End Sub

    Private Sub txtadjuntardni_TextChanged(sender As Object, e As EventArgs) Handles txtadjuntardni.TextChanged
        filtrardni()
        Button1.Enabled = False
        Button4.Enabled = False
        txtcomboreporte.Text = ""



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mostrarlistadepolizas()
        Button1.Enabled = True
        Button4.Enabled = True
    End Sub

    Private Sub txtpromotorreporte_TextChanged(sender As Object, e As EventArgs)
        filtrarpromotor()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To DataGridView2.RowCount - 1



            If DataGridView2.Rows.Item(i).Cells(11).Value <> "VENCIDO" Then



                DataGridView2.Rows.Item(i).Cells(0).Value = DBNull.Value
                DataGridView2.Rows.Item(i).Cells(1).Value = ""
                DataGridView2.Rows.Item(i).Cells(2).Value = ""
                DataGridView2.Rows.Item(i).Cells(3).Value = ""
                DataGridView2.Rows.Item(i).Cells(4).Value = ""
                DataGridView2.Rows.Item(i).Cells(5).Value = ""
                DataGridView2.Rows.Item(i).Cells(6).Value = ""
                DataGridView2.Rows.Item(i).Cells(7).Value = ""
                DataGridView2.Rows.Item(i).Cells(8).Value = DBNull.Value
                DataGridView2.Rows.Item(i).Cells(9).Value = ""
                DataGridView2.Rows.Item(i).Cells(10).Value = DBNull.Value
                DataGridView2.Rows.Item(i).Cells(11).Value = ""
                DataGridView2.Rows.Item(i).Cells(12).Value = ""
                DataGridView2.Rows.Item(i).Cells(13).Value = ""





            End If


        Next







        Button1.Enabled = False
        Button4.Enabled = False
        DataGridView2.Sort(DataGridView2.Columns(11), System.ComponentModel.ListSortDirection.Descending)
        datarojo()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To DataGridView2.RowCount - 1



            If DataGridView2.Rows.Item(i).Cells(11).Value <> "ACTIVO" Then



                DataGridView2.Rows.Item(i).Cells(0).Value = DBNull.Value
                DataGridView2.Rows.Item(i).Cells(1).Value = ""
                DataGridView2.Rows.Item(i).Cells(2).Value = ""
                DataGridView2.Rows.Item(i).Cells(3).Value = ""
                DataGridView2.Rows.Item(i).Cells(4).Value = ""
                DataGridView2.Rows.Item(i).Cells(5).Value = ""
                DataGridView2.Rows.Item(i).Cells(6).Value = ""
                DataGridView2.Rows.Item(i).Cells(7).Value = ""
                DataGridView2.Rows.Item(i).Cells(8).Value = DBNull.Value
                DataGridView2.Rows.Item(i).Cells(9).Value = ""
                DataGridView2.Rows.Item(i).Cells(10).Value = DBNull.Value
                DataGridView2.Rows.Item(i).Cells(11).Value = ""
                DataGridView2.Rows.Item(i).Cells(12).Value = ""
                DataGridView2.Rows.Item(i).Cells(13).Value = ""





            End If


        Next




        Button1.Enabled = False
        Button4.Enabled = False
        DataGridView2.Sort(DataGridView2.Columns(11), System.ComponentModel.ListSortDirection.Descending)

        dataverde()

    End Sub

    Private Sub txtcomboreporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcomboreporte.SelectedIndexChanged
        filtrarpromotor()


    End Sub

    Private Sub txtcomboreporte_Click(sender As Object, e As EventArgs) Handles txtcomboreporte.Click
        cargarpromotres()
        mostrarlistadepolizas()
        Button1.Enabled = False
        Button4.Enabled = False
        txtadjuntardni.Text = ""

    End Sub

    Private Sub txtcomboreporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcomboreporte.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub txtcomboreporte_TextChanged(sender As Object, e As EventArgs) Handles txtcomboreporte.TextChanged
        txtadjuntardni.Text = ""
    End Sub

    Private Sub datarojo()



        For i = 0 To DataGridView2.RowCount - 1


            DataGridView2.Rows.Item(i).DefaultCellStyle.ForeColor = Color.Red
        Next
    End Sub

    Private Sub dataverde()



        For i = 0 To DataGridView2.RowCount - 1


            DataGridView2.Rows.Item(i).DefaultCellStyle.ForeColor = Color.Green
        Next
    End Sub
End Class