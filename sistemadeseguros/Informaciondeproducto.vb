Imports System.Data.OleDb

Public Class Informaciondeproducto


    Public Sub cargarcomboinformacionprodcuto()


        Dim t As New DataTable
        Dim c As String = "SELECT NOMBRE FROM PRODUCTOS"
        Dim a As New OleDbDataAdapter(c, con)



        a.Fill(t)

        comboinformacionproducto.DataSource = t

        comboinformacionproducto.DisplayMember = "NOMBRE"







    End Sub



    Private Sub comboinformacionproducto_Click(sender As Object, e As EventArgs) Handles comboinformacionproducto.Click

        cargarcomboinformacionprodcuto()

    End Sub

    Private Sub btncerrar0_Click(sender As Object, e As EventArgs) Handles btncerrar0.Click
        Me.Close()
        Productos.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub comboinformacionproducto_Leave(sender As Object, e As EventArgs) Handles comboinformacionproducto.Leave

        If comboinformacionproducto.Text <> "SELECCIONAR PRODUCTO" Then
            preciodescripcionproducto(comboinformacionproducto.Text)
            If dr.Read Then
                txtinfoprecio.Text = dr(1).ToString
                txtinfocobertura.Text = dr(3).ToString
                txtdescripcionproductoinfo.Text = dr(2).ToString

            End If
            dr.Close()


        End If

    End Sub
End Class