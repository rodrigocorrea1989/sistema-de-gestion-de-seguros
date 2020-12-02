Module moduloseguros
    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=sistemadeseguros.accdb; Persist Security Info=False")
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public sql As String = ""
    Public labelusuario As String = ""
    Public labeltipo As String = ""
    Public actividad As String = ""
    Public tipo As String = ""





    Public Sub conectarbd()


        Try

            con.Open()
            MsgBox("conexión a base de datos exitosa ")

        Catch ex As Exception

            MsgBox("error en la base de datos ")
            MsgBox(ex.ToString)





        End Try


    End Sub


    Public Sub consultarpersona(ByRef identificacion As String)
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT NOMBRE, APELLIDO, TELEFONO , DIRECCION, PRODUCTO, DESCRIPCION, DNI, EMAIL, FECHADEVENCIMIENTO,FECHA, PROMOTOR FROM POLIZAS WHERE IDPOLIZA= " & identificacion & ""

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try


    End Sub


    Public Sub logear(ByRef id As String)
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT CONTRASEÑA, TIPO FROM USUARIOS WHERE NOMBREUSUARIO= '" & id & "'"

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try


    End Sub



    Public Sub buscarpoliza(ByRef id As String)
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT NOMBRE, APELLIDO, TELEFONO, DIRECCION, PRODUCTO, FECHA ,DESCRIPCION,DNI, FECHADEVENCIMIENTO, EMAIL, PROMOTOR, ESTADO FROM POLIZAS WHERE IDPOLIZA= " & id & ""

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try


    End Sub

    Public Sub cambiarcontraseña(ByRef identificacion As String)
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT NOMBREUSUARIO FROM USUARIOS WHERE CONTRASEÑA= '" & identificacion & "'"

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try


    End Sub

    Public Sub consultaevento(ByRef identificacion As String)
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT USUARIO, ACTIVIDAD, NOMBRECLI, APELLIDOCLI, TELEFONOCLI, DIRECCIONCLI FROM EVENTOS WHERE APELLIDOCLI= '" & identificacion & "'"

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub
    Public Sub preciodescripcionproducto(ByRef identificacion As String)
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT NOMBRE,PRECIO, DESCRIPCION,COBERTURAXMESES FROM PRODUCTOS WHERE NOMBRE= '" & identificacion & "'"

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try


    End Sub

    Public Sub numerodepoliza(ByRef identificacion As String)
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT IDPOLIZA FROM POLIZAS WHERE IDPOLIZA = " & identificacion & ""

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try


    End Sub

    Public Sub pagnum(ByRef identificacion As String)
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT MAX(PAGONUM), MAX(VENCIMIENTODEPAGO) FROM FACTURACION WHERE NUMDEPOLIZA = '" & identificacion & "'"

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try


    End Sub






    Public Sub solonumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If





    End Sub


    Public Sub sololetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If


    End Sub







End Module