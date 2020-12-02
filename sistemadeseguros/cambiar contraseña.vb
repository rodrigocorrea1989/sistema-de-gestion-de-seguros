Public Class cambiar_contraseña
    Private Sub txtcontraseñaanterior_Leave(sender As Object, e As EventArgs) Handles txtcontraseñaanterior.Leave
        If txtcontraseñaanterior.Text <> "" Then
            cambiarcontraseña(Me.txtcontraseñaanterior.Text)

            If dr.Read Then
                Me.txtnombrecontraseña.Text = dr(0).ToString
                dr.Close()
                Me.btnaceptarcontraseña.Enabled = True


            End If
        Else

        End If




        dr.Close()
    End Sub

    Private Sub btnaceptarcontraseña_Click(sender As Object, e As EventArgs) Handles btnaceptarcontraseña.Click

        Dim nuevacontraseña As String
        Dim usuario As String
        nuevacontraseña = Me.txtnuevacontraseña.Text
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

        usuario = labelusuario

        If nuevacontraseña = txtconfirmarcontraseña.Text Then



            sql = "UPDATE USUARIOS SET "
            sql += " CONTRASEÑA = '" & nuevacontraseña & "'"
            sql += "WHERE NOMBREUSUARIO='" & usuario & "'"


            cmd.CommandText = sql




            Try
                cmd.ExecuteNonQuery()
                MsgBox("se cambio la contraseña correctamente")
                login.Show()
                Me.Close()
                segurosis.Close()




            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try


        Else
            MsgBox("no coinciden ambos campos")


        End If



    End Sub

    Private Sub cambiar_contraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class