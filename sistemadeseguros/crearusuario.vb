Public Class crearusuario
    Private Sub btncrearusuario_Click(sender As Object, e As EventArgs) Handles btncrearusuario.Click
        If (Me.txtdninuevousuario.Text = "") Then
            MsgBox("el campo identificacion no puede estar vacio", MsgBoxStyle.Critical, "atencion")
            Me.txtdninuevousuario.Select()
        Else
            Dim dni As Integer
            Dim nombreusuario As String
            Dim contraseña As String
            Dim tipo As String
            Dim nombre As String
            Dim apellido As String

            dni = Me.txtdninuevousuario.Text
            nombreusuario = Me.txtusuarionuevo.Text
            contraseña = Me.txtpasswordnuevo.Text
            tipo = ComboBox1.Text
            nombre = TextBox2.Text
            apellido = TextBox1.Text


            cmd.CommandType = CommandType.Text
            cmd.Connection = con

            sql = "INSERT INTO USUARIOS(DNI, NOMBREUSUARIO, CONTRASEÑA, TIPO, NOMBRE, APELLIDO)"
            sql += "VALUES (" & dni & ",'" & nombreusuario & "','" & contraseña & "','" & tipo & "','" & nombre & "','" & apellido & "')"




            cmd.CommandText = sql


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Se creo el usuario correctamente")





            Catch ex As Exception
                If ex.ToString.Contains("valores duplicados") Then
                    MsgBox("Ya se encuentra DNI o nombre de usuario registrado, contactese con sporte técnico ", MsgBoxStyle.Critical, "Duplicado")

                Else
                    MsgBox(ex.ToString)
                End If
            End Try

        End If






        txtdninuevousuario.Text = ""
        txtusuarionuevo.Text = ""
        txtpasswordnuevo.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = ""

        Me.Close()



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


        If ComboBox1.Text = "ADMIN" Then
            lblprivi.Text = "usuario con privilegio total"

        End If
        If ComboBox1.Text = "USER" Then
            lblprivi.Text = "Usuario con acceso a POLIZAS" + vbCr
            lblprivi.Text += "acceso a Facturación solo para realizar cobros" + vbCr
            lblprivi.Text += "no permite crear usuarios" + vbCr
            lblprivi.Text += "eventos de polizas restringido" + vbCr
            lblprivi.Text += "Acceso a PRODUCTOS restringido"

        End If

        If ComboBox1.Text = "PROMOTOR" Then
            lblprivi.Text = "Usuario con acceso a POLIZAS" + vbCr
            lblprivi.Text += "acceso a ALTA, MODIFICACION, BUSCAR POLIZA" + vbCr
            lblprivi.Text += "Acceso a FACTURACIÓN restringido" + vbCr
            lblprivi.Text += "Acceso a PRODUCTOS restringido" + vbCr
            lblprivi.Text += "no permite crear usuarios"



        End If

    End Sub


    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.KeyChar = ""
    End Sub


    Private Sub txtdninuevousuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdninuevousuario.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txtusuarionuevo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusuarionuevo.KeyPress
        sololetras(e)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        sololetras(e)
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        sololetras(e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vertodos.Show()

    End Sub


End Class