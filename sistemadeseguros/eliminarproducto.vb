Imports System.Data.OleDb

Public Class eliminarproducto
    Private Sub eliminarproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Public Sub cargarcomboeliminarpromotres()


        Dim t As New DataTable
        Dim c As String = "SELECT NOMBRE FROM PRODUCTOS"
        Dim a As New OleDbDataAdapter(c, con)



        a.Fill(t)

        comboeliminar.DataSource = t

        comboeliminar.DisplayMember = "NOMBRE"







    End Sub


    Private Sub comboeliminar_Click(sender As Object, e As EventArgs) Handles comboeliminar.Click
        cargarcomboeliminarpromotres()

    End Sub


    Private Sub comboeliminar_Leave(sender As Object, e As EventArgs) Handles comboeliminar.Leave
        If comboeliminar.Text <> "SELECCIONAR PRODUCTO" Then
            preciodescripcionproducto(comboeliminar.Text)
            If dr.Read Then
                txtprecioproducto.Text = dr(1).ToString
                txtdescripcionproducto.Text = dr(2).ToString
                txtcobertura.Text = dr(3).ToString

            End If
            dr.Close()


        End If
    End Sub

    Private Sub btncerrar0_Click(sender As Object, e As EventArgs) Handles btncerrar0.Click
        Productos.Show()
        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub txtnuevoproducto_Click(sender As Object, e As EventArgs) Handles txtnuevoproducto.Click
        cmd.CommandType = CommandType.Text
        cmd.Connection = con

        Dim n As String

        n = comboeliminar.Text

        sql = "DELETE * FROM PRODUCTOS WHERE NOMBRE='" & n & "'"


        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()


            MsgBox("registro ELIMINADO correctamente")

        Catch ex As Exception
            MsgBox(ex.ToString)


        End Try

        'EVENTO EVENTO EVENTO EVENTO

        If comboeliminar.Text <> "" Then

            Dim nombre As String
            Dim precio As Double
            Dim descripcion As String
            Dim cobertura As Integer
            Dim accion As String = "eliminar"
            Dim usuario As String = labelusuario




            nombre = Me.comboeliminar.Text
            precio = Me.txtprecioproducto.Text
            descripcion = Me.txtdescripcionproducto.Text
            cobertura = Me.txtcobertura.Text


            cmd.CommandType = CommandType.Text
            cmd.Connection = con

            sql = "INSERT INTO EVENTOSPRODUCTOS( NOMBRE, PRECIO, DESCRIPCION,COBERTURAXMESES,USUARIO,ACTIVIDAD)"
            sql += "VALUES ('" & nombre & "','" & precio & "','" & descripcion & "'," & cobertura & ",'" & usuario & "','" & accion & "')"



            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                MsgBox("evento registrado")



            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try


            Me.comboeliminar.Text = ""
            Me.txtprecioproducto.Text = ""
            Me.txtdescripcionproducto.Text = ""
            Me.txtcobertura.Text = ""
        End If




    End Sub

    Private Sub comboeliminar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboeliminar.SelectedIndexChanged

    End Sub
End Class