Public Class nuevoproducto


    Private Sub txtnuevoproducto_Click(sender As Object, e As EventArgs) Handles txtnuevoproducto.Click


        If txtproducto.Text = "" Then
            MsgBox("el campo nombre no puede quedar vacio", MsgBoxStyle.Exclamation, "campo vacío")



        ElseIf txtprecioproducto.Text = "" Then
            MsgBox("el campo precio no puede quedar vacio", MsgBoxStyle.Exclamation, "campo vacío")




        ElseIf txtdescripcionproducto.Text = "" Then
            MsgBox("el campo descripción no puede quedar vacio", MsgBoxStyle.Exclamation, "campo vacío")




        ElseIf txtcobertura.Text = "" Then
            MsgBox("el campo cobertura no puede quedar vacio", MsgBoxStyle.Exclamation, "campo vacío")



                    Else

            Dim nombre As String
            Dim precio As Double
            Dim descripcion As String
            Dim cobertura As Integer




            nombre = Me.txtproducto.Text
            precio = Me.txtprecioproducto.Text
            descripcion = Me.txtdescripcionproducto.Text
            cobertura = Me.txtcobertura.Text


            cmd.CommandType = CommandType.Text
            cmd.Connection = con

            sql = "INSERT INTO PRODUCTOS( NOMBRE, PRECIO, DESCRIPCION,COBERTURAXMESES)"
            sql += "VALUES ('" & nombre & "','" & precio & "','" & descripcion & "'," & cobertura & ")"



            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Ingresado Correctamente")



            Catch ex As Exception
                If ex.ToString.Contains("valores duplicados") Then
                    MsgBox("Ya se encuentra un registro con el mismo nombre ", MsgBoxStyle.Critical, "Duplicado")
                    txtproducto.Text = ""
                Else
                    MsgBox(ex.ToString)
                End If
            End Try


        End If

        'EVENTO EVENTO EVENTO EVENTO

        If txtproducto.Text <> "" Then

            Dim nombre As String
            Dim precio As Double
            Dim descripcion As String
            Dim cobertura As Integer
            Dim accion As String = "alta"
            Dim usuario As String = labelusuario




            nombre = Me.txtproducto.Text
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


            Me.txtproducto.Text = ""
            Me.txtprecioproducto.Text = ""
            Me.txtdescripcionproducto.Text = ""
            Me.txtcobertura.Text = ""
        End If







    End Sub

    Private Sub btncerrar0_Click(sender As Object, e As EventArgs) Handles btncerrar0.Click
        Productos.Show()
        Me.Close()


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub



    Private Sub txtcobertura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcobertura.KeyPress
        solonumeros(e)
    End Sub


End Class