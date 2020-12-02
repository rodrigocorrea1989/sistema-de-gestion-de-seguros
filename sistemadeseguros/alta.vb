Imports System.Data.OleDb
Public Class alta



    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click


        If txtnumpoliza.Text = "" Then
            Dim maxid As Object
            Dim strid As String
            Dim intid As Integer
            cmd.CommandText = "SELECT MAX(IDPOLIZA) AS maxid FROM POLIZAS"
            maxid = cmd.ExecuteScalar
            If maxid Is DBNull.Value Then
                intid = 1
            Else
                strid = CType(maxid, String)
                intid = CType(strid, String)
                intid = intid + 1
            End If
            txtnumpoliza.Text = intid

        End If





        If (Me.txtdni.Text = "") Then
            MsgBox("el campo dni no puede estar vacio", MsgBoxStyle.Critical, "atencion")

            Me.txtdni.Select()
            combonombreproductos.Enabled = False
            Me.txtnombre.Enabled = False
            Me.txtapellido.Enabled = False
            Me.txttelefono.Enabled = False
            Me.txtdireccion.Enabled = False
            Me.txtnumpoliza.Enabled = False
            Me.txtemail.Enabled = False
            Me.txtdescripcionalta.Enabled = False
            Me.combopromotores.Enabled = False


        Else





            Dim estado As String
            Dim dni As String
            Dim nombre As String
            Dim apellido As String
            Dim telefono As String
            Dim direccion As String
            Dim descripcion As String
            Dim comboaltaproducto As String
            Dim numerodepoliza As Integer
            Dim email As String
            Dim promotor As String
            Dim fecha1 As Date
            Dim fecha2 As Date


            estado = "ACTIVO"
            comboaltaproducto = combonombreproductos.Text
            dni = Me.txtdni.Text
            nombre = Me.txtnombre.Text
            apellido = Me.txtapellido.Text
            telefono = Me.txttelefono.Text
            direccion = Me.txtdireccion.Text
            descripcion = txtdescripcionalta.Text
            numerodepoliza = Me.txtnumpoliza.Text
            email = Me.txtemail.Text
            promotor = Me.combopromotores.Text
            fecha1 = Me.fechaalta.Value
            fecha2 = Me.fechavencimiento.Value


            cmd.CommandType = CommandType.Text
            cmd.Connection = con



            sql = " INSERT INTO POLIZAS(DNI, NOMBRE, APELLIDO, TELEFONO, DIRECCION, PRODUCTO, DESCRIPCION, IDPOLIZA, EMAIL,PROMOTOR,FECHA,FECHADEVENCIMIENTO,ESTADO)"
            sql += "VALUES ('" & dni & "','" & nombre & "','" & apellido & "','" & telefono
            sql += "','" & direccion & "','" & comboaltaproducto & "','" & descripcion & "','" & numerodepoliza & "','" & email & "','" & promotor
            sql += "','" & fecha1 & "','" & fecha2 & "','" & estado & "')"





            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Ingresado Correctamente")
                MsgBox("numero de poliza=" + txtnumpoliza.Text, MsgBoxStyle.Exclamation, " Numero de poliza")





            Catch ex As Exception
                If ex.ToString.Contains("valores duplicados") Then
                    MsgBox("número de póliza duplicado, ingrese otro número o deje el espacio vacío para que se genere automaticamente ", MsgBoxStyle.Critical, "Duplicado")
                    Me.txtnombre.Text = ""

                Else



                    MsgBox(ex.ToString)


                End If


            End Try

            If (Me.txtnombre.Text = "") Then
                MsgBox("vuelva a rellenar los campos faltantes", MsgBoxStyle.Critical, "atencion")
                Me.txtnombre.Select()
            Else

                Dim actividad As String
                Dim usuario As String



                comboaltaproducto = Me.combonombreproductos.Text



                actividad = "ALTA"
                usuario = labelusuario


                descripcion = txtdescripcionalta.Text
                nombre = Me.txtnombre.Text
                apellido = Me.txtapellido.Text
                telefono = Me.txttelefono.Text
                direccion = Me.txtdireccion.Text
                numerodepoliza = Me.txtnumpoliza.Text
                dni = Me.txtdni.Text
                email = Me.txtemail.Text



                cmd.CommandType = CommandType.Text
                cmd.Connection = con



                sql = " INSERT INTO EVENTOS(USUARIO, actividad, NOMBRECLI, APELLIDOCLI, TELEFONOCLI, DIRECCIONCLI, PRODUCTO, descripcion, IDPOLIZA, DNICLI, email, promotor)"
                sql += "VALUES ('" & usuario & "','" & actividad & "','" & nombre & "','" & apellido & "','" & telefono
                sql += "','" & direccion & "','" & comboaltaproducto & "','" & descripcion & "','" & numerodepoliza & "','" & dni & "','" & email & "','" & promotor & "')"





                cmd.CommandText = sql



                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("evento registrado")

                    Me.txtdni.Enabled = True
                    combonombreproductos.Enabled = False
                    Me.txtnombre.Enabled = False
                    Me.txtapellido.Enabled = False
                    Me.txttelefono.Enabled = False
                    Me.txtdireccion.Enabled = False
                    txtdescripcionalta.Enabled = False
                    Me.txtnumpoliza.Enabled = False
                    Me.txtemail.Enabled = False
                    Me.combopromotores.Enabled = False
                    combonombreproductos.Text = ""
                    Me.txtdni.Text = ""
                    Me.txtnombre.Text = ""
                    Me.txtapellido.Text = ""
                    Me.txttelefono.Text = ""
                    Me.txtdireccion.Text = ""
                    Me.txtemail.Text = ""
                    Me.combopromotores.Text = labelusuario
                    Me.txtbeneficiosalta.Text = ""
                    Me.txtprecioalta.Text = ""
                    txtnumpoliza.Text = ""
                    txtdescripcionalta.Text = ""

                    txtdni.Select()




                Catch ex As Exception

                    MsgBox(ex.ToString)

                End Try





            End If




        End If

    End Sub

    Private Sub btncerrar0_Click(sender As Object, e As EventArgs) Handles btncerrar0.Click
        Me.Close()


    End Sub



    Private Sub alta_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        Me.txtcoverturavalidoxmeses.Text = 0

        Me.txtdni.Enabled = True
        combonombreproductos.Enabled = False
        Me.txtnombre.Enabled = False
        Me.txtapellido.Enabled = False
        Me.txttelefono.Enabled = False
        Me.txtdireccion.Enabled = False
        txtdescripcionalta.Enabled = False
        Me.txtnumpoliza.Enabled = False
        Me.txtemail.Enabled = False
        Me.combopromotores.Enabled = False


        usuario.Text = labelusuario
        combonombreproductos.Text = ""
        combopromotores.Text = labelusuario
        cn.Open()
        cmd = New OleDb.OleDbCommand("SELECT * FROM POLIZAS", cn)
        cmd.Connection = cn
        Dim maxid As Object
        Dim strid As String
        Dim intid As Integer


        cmd.CommandText = "SELECT MAX(IDPOLIZA) AS maxid FROM POLIZAS"
        maxid = cmd.ExecuteScalar
        If maxid Is DBNull.Value Then
            intid = 1
        Else
            strid = CType(maxid, String)
            intid = CType(strid, String)
            intid = intid + 1
        End If
        txtnumpoliza.Text = intid
        txtnombre.Focus()


        cn.Close()










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


                txtprecioalta.Text = dr(1).ToString()
                txtbeneficiosalta.Text = dr(2).ToString()
                txtcoverturavalidoxmeses.Text = dr(3).ToString()
            End If

        End If

        dr.Close()


    End Sub

    Private Sub txtdni_Leave(sender As Object, e As EventArgs) Handles txtdni.Leave

        If txtdni.Text <> "" Then
            Me.txtdni.Enabled = False
            combonombreproductos.Enabled = True
            Me.txtnombre.Enabled = True
            Me.txtapellido.Enabled = True
            Me.txttelefono.Enabled = True
            Me.txtdireccion.Enabled = True
            txtdescripcionalta.Enabled = True
            Me.txtnumpoliza.Enabled = True
            Me.txtemail.Enabled = True
            Me.combopromotores.Enabled = True




        End If
    End Sub



    Private Sub txtdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress
        solonumeros(e)

    End Sub


    Public Sub cargarpromotres()


        Dim t As New DataTable
        Dim c As String = "SELECT NOMBREUSUARIO FROM USUARIOS"
        Dim a As New OleDbDataAdapter(c, con)



        a.Fill(t)

        combopromotores.DataSource = t

        combopromotores.DisplayMember = "NOMBREUSUARIO"







    End Sub

    Private Sub combopromotores_Click(sender As Object, e As EventArgs) Handles combopromotores.Click
        cargarpromotres()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.txtdni.Enabled = True
        combonombreproductos.Enabled = False
        Me.txtnombre.Enabled = False
        Me.txtapellido.Enabled = False
        Me.txttelefono.Enabled = False
        Me.txtdireccion.Enabled = False
        txtdescripcionalta.Enabled = False
        Me.txtnumpoliza.Enabled = False
        Me.txtemail.Enabled = False
        Me.combopromotores.Enabled = False
        combonombreproductos.Text = ""
        Me.txtdni.Text = ""
        Me.txtnombre.Text = ""
        Me.txtapellido.Text = ""
        Me.txttelefono.Text = ""
        Me.txtdireccion.Text = ""
        Me.txtemail.Text = ""
        Me.combopromotores.Text = labelusuario
        Me.txtbeneficiosalta.Text = ""
        Me.txtprecioalta.Text = ""
        txtdni.Select()


    End Sub



    Private Sub combonombreproductos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles combonombreproductos.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub combopromotores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles combopromotores.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub txtcoverturavalidoxmeses_TextChanged(sender As Object, e As EventArgs) Handles txtcoverturavalidoxmeses.TextChanged
        If txtcoverturavalidoxmeses.Text <> 0 Then

            fechaalta.Value = Now
            Dim n As Date
            Dim d As Integer
            n = fechaalta.Value
            d = txtcoverturavalidoxmeses.Text


            fechavencimiento.Value = n.AddMonths(d).ToString


        End If
    End Sub

    Private Sub fechaalta_ValueChanged(sender As Object, e As EventArgs) Handles fechaalta.ValueChanged
        Dim n As Date
        Dim d As Integer
        n = fechaalta.Value
        d = txtcoverturavalidoxmeses.Text


        fechavencimiento.Value = n.AddMonths(d).ToString


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        fechaalta.Value = Now

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        polizas.Show()
        Me.Close()


    End Sub

    Private Sub txtdni_TextChanged(sender As Object, e As EventArgs) Handles txtdni.TextChanged

    End Sub



    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        sololetras(e)
    End Sub

    Private Sub txtnumpoliza_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumpoliza.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txtapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido.KeyPress
        sololetras(e)
    End Sub


End Class