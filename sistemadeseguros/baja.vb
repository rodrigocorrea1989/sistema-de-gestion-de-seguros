Public Class baja
    Private Sub btncerrar0_Click(sender As Object, e As EventArgs) Handles btncerrar0.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        polizas.Show()


    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click


        Dim identificacion As Integer




        identificacion = Me.txtnumpolizaeliminar.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = con

        sql = "DELETE FROM POLIZAS WHERE IDPOLIZA=" & identificacion & ""


        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()


            MsgBox("registro ELIMINADO correctamente")
        Catch ex As Exception
            MsgBox(ex.ToString)


        End Try





        If (Me.txteliminarnombre.Text = "") Then
            MsgBox("el campo identificacion no puede estar vacio", MsgBoxStyle.Critical, "atencion")
            Me.txteliminardni.Select()
        Else
            Dim nombre As String
            Dim apellido As String
            Dim telefono As String
            Dim direccion As String
            Dim actividad As String
            Dim usuario As String
            Dim productos As String
            Dim descripcion As String
            Dim dni As String
            Dim idpoliza As String
            Dim email As String
            Dim promotor As String

            actividad = "BAJA"
            usuario = labelusuario


            email = txtcorreobaja.Text
            promotor = txtpromotorbaja.Text
            nombre = Me.txteliminarnombre.Text
            apellido = Me.txteliminarapellido.Text
            telefono = Me.txteliminartelefono.Text
            direccion = Me.txteliminardireccion.Text
            productos = Me.txteliminarproducto.Text
            descripcion = Me.txtdescripcionbaja.Text
            dni = Me.txteliminardni.Text
            idpoliza = Me.txtnumpolizaeliminar.Text



            cmd.CommandType = CommandType.Text
            cmd.Connection = con



            sql = " INSERT INTO EVENTOS(USUARIO, ACTIVIDAD, NOMBRECLI, APELLIDOCLI, TELEFONOCLI, DIRECCIONCLI,PRODUCTO,DESCRIPCION, DNICLI,IDPOLIZA,EMAIL,PROMOTOR)"
            sql += "VALUES ('" & usuario & "','" & actividad & "','" & nombre & "','" & apellido & "','" & telefono
            sql += "','" & direccion & "','" & productos & "','" & descripcion & "','" & dni & "','" & idpoliza & "','" & email & "','" & promotor & "')"





            cmd.CommandText = sql



            Try
                cmd.ExecuteNonQuery()
                MsgBox("evento registrado")





            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try





        End If


        Me.txteliminardni.Text = ""
        Me.txteliminarnombre.Text = ""
        Me.txteliminarapellido.Text = ""
        Me.txteliminartelefono.Text = ""
        Me.txteliminardireccion.Text = ""
        txtpromotorbaja.Text = ""
        txtvalidopormesbaja.Text = ""
        txtbeneficiobaja.Text = ""
        txtpreciobaja.Text = ""
        txteliminarproducto.Text = ""
        txtcorreobaja.Text = ""
        txtdescripcionbaja.Text = ""



    End Sub

    Private Sub txtnumpolizaeliminar_Leave(sender As Object, e As EventArgs) Handles txtnumpolizaeliminar.Leave





        If txtnumpolizaeliminar.Text <> "" Then
            consultarpersona(txtnumpolizaeliminar.Text)





            Me.txteliminarnombre.Enabled = True
            Me.txteliminarapellido.Enabled = True
            Me.txteliminartelefono.Enabled = True
            Me.txteliminardireccion.Enabled = True
            Me.txteliminarproducto.Enabled = True
            Me.txtdescripcionbaja.Enabled = True
            Me.txteliminardni.Enabled = True
            Me.txtcorreobaja.Enabled = True




            If dr.Read Then



                Me.txteliminarnombre.Text = dr(0).ToString()
                Me.txteliminarapellido.Text = dr(1).ToString()
                Me.txteliminartelefono.Text = dr(2).ToString()
                Me.txteliminardireccion.Text = dr(3).ToString()
                Me.txteliminarproducto.Text = dr(4).ToString()
                Me.txtdescripcionbaja.Text = dr(5).ToString()
                Me.txteliminardni.Text = dr(6).ToString()
                Me.txtcorreobaja.Text = dr(7).ToString
                Me.fechavencimiento.Value = dr(8).ToString
                Me.txtpromotorbaja.Text = dr(10).ToString
                dr.Close()
                Me.btneliminar.Enabled = True
            Else
                Me.txteliminarnombre.Text = ""
                Me.txteliminarapellido.Text = ""
                Me.txteliminartelefono.Text = ""
                Me.txteliminardireccion.Text = ""
                MsgBox("no se ha encontrado el registro en la base de datos")
                Me.btneliminar.Enabled = False

            End If
        Else
            Me.btneliminar.Enabled = False
        End If


        dr.Close()

        If txteliminarproducto.Text <> "" Then
            preciodescripcionproducto(txteliminarproducto.Text)

            If dr.Read Then

                txtpreciobaja.Text = dr(1).ToString()
                txtbeneficiobaja.Text = dr(2).ToString()
                txtvalidopormesbaja.Text = dr(3).ToString()
            End If

        End If

        dr.Close()



        If txteliminarproducto.Text <> "" Then
            preciodescripcionproducto(txteliminarproducto.Text)
            If dr.Read Then

                txtbeneficiobaja.Text = dr(2).ToString


            End If


        End If
        dr.Close()
    End Sub


    Private Sub txtnumpolizaeliminar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumpolizaeliminar.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txteliminardni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txteliminardni.KeyPress
        solonumeros(e)
    End Sub


End Class