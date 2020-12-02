Imports System.Data.OleDb

Public Class modificar



    Private Sub btncerrar0_Click(sender As Object, e As EventArgs) Handles btncerrar0.Click
        Me.Close()



    End Sub

    Public Sub cargarpromotres()


        Dim t As New DataTable
        Dim c As String = "SELECT NOMBREUSUARIO FROM USUARIOS"
        Dim a As New OleDbDataAdapter(c, con)



        a.Fill(t)

        ComboBox1.DataSource = t

        ComboBox1.DisplayMember = "NOMBREUSUARIO"







    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        polizas.Show()

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

        Dim dni As String
        Dim nombre As String
        Dim apellido As String
        Dim telefono As String
        Dim direccion As String
        Dim productos As String
        Dim descripcion As String
        Dim idpoliza As Integer
        Dim promotor As String
        Dim email As String

        nombre = Me.txtmodificarnombre.Text
        apellido = Me.txtmodificarapellido.Text
        telefono = Me.txtmodificartelefono.Text
        direccion = Me.txtmodificardireccion.Text
        dni = Me.txtmodificardni.Text
        productos = Me.combonombreproductos.Text
        descripcion = Me.txtdescripcionmodificar.Text
        idpoliza = Me.txtnumerodepolizamodificar.Text
        promotor = ComboBox1.Text
        email = txtemailmodificar.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = con


        sql = "UPDATE POLIZAS SET"
        sql += " NOMBRE = '" & nombre & "',"
        sql += " APELLIDO = '" & apellido & "',"
        sql += " TELEFONO= '" & telefono & "',"
        sql += " DIRECCION = '" & direccion & "',"
        sql += " PRODUCTO = '" & productos & "',"
        sql += " DESCRIPCION = '" & descripcion & "',"
        sql += " DNI = '" & dni & "',"
        sql += " EMAIL = '" & email & "',"
        sql += " PROMOTOR = '" & promotor & "'"

        sql += "WHERE IDPOLIZA=" & idpoliza & ""

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            MsgBox("registro MODIFICADO correctamente")


        Catch ex As Exception
            MsgBox(ex.ToString)


        End Try

        If (Me.txtmodificarnombre.Text = "") Then
            MsgBox("el campo identificacion no puede estar vacio", MsgBoxStyle.Critical, "atencion")
            Me.txtmodificardni.Select()
        Else
            Dim actividad As String
            Dim usuario As String

            actividad = "MODIFICACIÓN"
            usuario = labelusuario




            cmd.CommandType = CommandType.Text
            cmd.Connection = con



            sql = " INSERT INTO EVENTOS(USUARIO, ACTIVIDAD, NOMBRECLI, APELLIDOCLI, TELEFONOCLI, DIRECCIONCLI,PRODUCTO, DESCRIPCION, IDPOLIZA,DNICLI,EMAIL,PROMOTOR)"
            sql += "VALUES ('" & usuario & "','" & actividad & "','" & nombre & "','" & apellido & "','" & telefono
            sql += "','" & direccion & "','" & productos & "','" & descripcion & "'," & idpoliza & ",'" & dni & "','" & email & "','" & promotor & "')"





            cmd.CommandText = sql



            Try
                cmd.ExecuteNonQuery()
                MsgBox("evento registrado")





            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try





        End If

        Me.txtnumerodepolizamodificar.Text = ""
        Me.txtmodificardni.Text = ""
        Me.txtmodificarnombre.Text = ""
        Me.txtmodificarapellido.Text = ""
        Me.txtmodificarapellido.Text = ""
        Me.txtmodificartelefono.Text = ""
        Me.txtmodificardireccion.Text = ""
        Me.txtdescripcionmodificar.Text = ""
        txtbeneficiosmodificar.Text = ""
        ComboBox1.Text = ""
        txtemailmodificar.Text = ""
        combonombreproductos.Text = ""
        txtmodificarcovertura.Text = ""
        txtpreciomodificar.Text = ""
        Me.txtnumerodepolizamodificar.Enabled = True
        Me.txtmodificardni.Enabled = False
        Me.txtmodificarnombre.Enabled = False
        Me.txtmodificarapellido.Enabled = False
        Me.txtmodificarapellido.Enabled = False
        Me.txtmodificartelefono.Enabled = False
        Me.txtmodificardireccion.Enabled = False
        Me.txtdescripcionmodificar.Enabled = False
        txtemailmodificar.Enabled = False
        combonombreproductos.Enabled = False



    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.txtnumerodepolizamodificar.Text = ""
        Me.txtmodificardni.Text = ""
        Me.txtmodificarnombre.Text = ""
        Me.txtmodificarapellido.Text = ""
        Me.txtmodificarapellido.Text = ""
        Me.txtmodificartelefono.Text = ""
        Me.txtmodificardireccion.Text = ""
        Me.txtdescripcionmodificar.Text = ""
        ComboBox1.Text = ""
        txtemailmodificar.Text = ""
        txtbeneficiosmodificar.Text = ""
        txtmodificarcovertura.Text = ""
        txtpreciomodificar.Text = ""
        combonombreproductos.Text = ""



        Me.txtnumerodepolizamodificar.Enabled = True
        Me.txtmodificardni.Enabled = False
        Me.txtmodificarnombre.Enabled = False
        Me.txtmodificarapellido.Enabled = False
        Me.txtmodificarapellido.Enabled = False
        Me.txtmodificartelefono.Enabled = False
        Me.txtmodificardireccion.Enabled = False
        Me.txtdescripcionmodificar.Enabled = False
        txtemailmodificar.Enabled = False
        combonombreproductos.Enabled = False


    End Sub





    Public Sub cargarcombo()


        Dim tabla As New DataTable
        Dim consulta As String = "SELECT NOMBRE, PRECIO, DESCRIPCION FROM PRODUCTOS"
        Dim adaptador As New OleDbDataAdapter(consulta, con)



        adaptador.Fill(tabla)

        combonombreproductos.DataSource = tabla

        combonombreproductos.DisplayMember = "NOMBRE"







    End Sub

    Private Sub combonombreproductos_Click(sender As Object, e As EventArgs) Handles combonombreproductos.Click

        cargarcombo()

    End Sub

    Private Sub combonombreproductos_Leave(sender As Object, e As EventArgs) Handles combonombreproductos.Leave
        If combonombreproductos.Text <> "" Then
            preciodescripcionproducto(combonombreproductos.Text)

            If dr.Read Then


                txtpreciomodificar.Text = dr(1).ToString()
                txtbeneficiosmodificar.Text = dr(2).ToString()
                txtmodificarcovertura.Text = dr(3).ToString()

            End If



        End If

        dr.Close()


    End Sub



    Private Sub txtnumerodepolizamodificar_Leave(sender As Object, e As EventArgs) Handles txtnumerodepolizamodificar.Leave



        If txtnumerodepolizamodificar.Text <> "" Then
            consultarpersona(Me.txtnumerodepolizamodificar.Text)
            Me.txtnumerodepolizamodificar.Enabled = False


            If dr.Read Then
                Me.txtmodificarnombre.Enabled = True
                Me.txtmodificarapellido.Enabled = True
                Me.txtmodificartelefono.Enabled = True
                Me.txtmodificardireccion.Enabled = True
                Me.txtmodificardni.Enabled = True
                Me.txtdescripcionmodificar.Enabled = True
                txtemailmodificar.Enabled = True

                Me.txtmodificardni.Text = dr(6).ToString
                Me.txtmodificarnombre.Text = dr(0).ToString
                Me.txtmodificarapellido.Text = dr(1).ToString
                Me.txtmodificartelefono.Text = dr(2).ToString
                Me.txtmodificardireccion.Text = dr(3).ToString
                Me.combonombreproductos.Text = dr(4).ToString
                Me.txtdescripcionmodificar.Text = dr(5).ToString
                Me.txtemailmodificar.Text = dr(7).ToString
                ComboBox1.Text = dr(10).ToString
                DateTimePicker1.Value = dr(9).ToString
                DateTimePicker2.Value = dr(8).ToString

                dr.Close()
                btnmodificar.Enabled = True
                btncancelar.Enabled = True





            Else
                Me.txtmodificarnombre.Text = ""
                Me.txtmodificarapellido.Text = ""
                Me.txtmodificartelefono.Text = ""
                Me.txtmodificardireccion.Text = ""
                MsgBox("no se ha encontrado el registro en la base de datos")
                Me.txtnumerodepolizamodificar.Enabled = True


            End If

            If combonombreproductos.Text <> "" Then
                preciodescripcionproducto(combonombreproductos.Text)



                If dr.Read Then
                    If combonombreproductos.Text = dr(0).ToString Then
                        txtbeneficiosmodificar.Text = dr(2).ToString
                        txtpreciomodificar.Text = dr(1).ToString
                        txtmodificarcovertura.Text = dr(3).ToString

                    End If


                End If



            End If

            dr.Close()


        End If


        dr.Close()





    End Sub

    Private Sub txtmodificardni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmodificardni.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txtnumerodepolizamodificar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumerodepolizamodificar.KeyPress
        solonumeros(e)
    End Sub

    Private Sub combonombreproductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combonombreproductos.SelectedIndexChanged

    End Sub

    Private Sub combonombreproductos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles combonombreproductos.KeyPress
        e.KeyChar = ""


    End Sub


    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        cargarpromotres()

    End Sub


End Class