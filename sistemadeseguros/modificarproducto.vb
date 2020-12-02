Imports System.Data.OleDb
Public Class modificarproducto
    Private Sub combomodificarproducto_Click(sender As Object, e As EventArgs) Handles combomodificarproducto.Click
        cargarcombomodificar()


    End Sub




    Public Sub cargarcombomodificar()


        Dim t As New DataTable
        Dim c As String = "SELECT NOMBRE FROM PRODUCTOS"
        Dim a As New OleDbDataAdapter(c, con)



        a.Fill(t)

        combomodificarproducto.DataSource = t

        combomodificarproducto.DisplayMember = "NOMBRE"







    End Sub
    Private Sub combomodificarproducto_Leave(sender As Object, e As EventArgs) Handles combomodificarproducto.Leave
        If combomodificarproducto.Text <> "SELECCIONAR PRODCUTO" Then
            txtprecioproductomodificar.Enabled = True
            txtcoberturamodificar.Enabled = True
            txtdescripcionproductomodificar.Enabled = True
            preciodescripcionproducto(combomodificarproducto.Text)
            If dr.Read Then
                txtprecioproductomodificar.Text = dr(1).ToString
                txtcoberturamodificar.Text = dr(3).ToString
                txtdescripcionproductomodificar.Text = dr(2).ToString
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

    Private Sub btnmodificarproducto_Click(sender As Object, e As EventArgs) Handles btnmodificarproducto.Click
        Dim precio As Double
        Dim tiempodecobertura As Integer
        Dim descripcion As String
        Dim nombre As String

        precio = txtprecioproductomodificar.Text
        tiempodecobertura = txtcoberturamodificar.Text
        descripcion = txtdescripcionproductomodificar.Text
        nombre = combomodificarproducto.Text


        cmd.CommandType = CommandType.Text
        cmd.Connection = con


        sql = "UPDATE PRODUCTOS SET"
        sql += " COBERTURAXMESES = " & tiempodecobertura & ","
        sql += " DESCRIPCION = '" & descripcion & "',"
        sql += " PRECIO = '" & precio & "'"
        sql += "WHERE NOMBRE='" & nombre & "'"

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            MsgBox("registro MODIFICADO correctamente")



        Catch ex As Exception
            MsgBox(ex.ToString)


        End Try

        'EVENTO EVENTO EVENTO EVENTO

        If combomodificarproducto.Text <> "" Then


            Dim cobertura As Integer
            Dim accion As String = "modificación"
            Dim usuario As String = labelusuario




            nombre = combomodificarproducto.Text
            precio = Me.txtprecioproductomodificar.Text
            descripcion = txtdescripcionproductomodificar.Text
            cobertura = Me.txtcoberturamodificar.Text


            cmd.CommandType = CommandType.Text
            cmd.Connection = con

            sql = "INSERT INTO EVENTOSPRODUCTOS( NOMBRE, PRECIO, DESCRIPCION,COBERTURAXMESES,USUARIO,ACTIVIDAD)"
            sql += "VALUES ('" & nombre & "','" & precio & "','" & descripcion & "'," & cobertura & ",'" & usuario & "','" & accion & "')"



            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                MsgBox("evento registrado")
                txtprecioproductomodificar.Text = ""
                txtcoberturamodificar.Text = ""
                txtdescripcionproductomodificar.Text = ""
                combomodificarproducto.Text = "SELECCIONAR PRODUCTO"
                txtprecioproductomodificar.Enabled = False
                txtcoberturamodificar.Enabled = False
                txtdescripcionproductomodificar.Enabled = False


            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try




        End If

    End Sub



    Private Sub txtcoberturamodificar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcoberturamodificar.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txtprecioproductomodificar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecioproductomodificar.KeyPress

    End Sub


End Class