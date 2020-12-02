Public Class segurosis


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btncerrar0.Click



        login.Show()

        Me.Close()






    End Sub



    Private Sub btnproductos_Click(sender As Object, e As EventArgs) Handles btnproductos.Click
        Productos.Show()



    End Sub


    Private Sub segurosis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuario.Text = labelusuario
        lbltipo.Text = labeltipo









        If lbltipo.Text = "USER" Then
            agregarusuario.Enabled = False
            btnproductos.Enabled = False
        End If
        If lbltipo.Text = "PROMOTOR" Then
            agregarusuario.Enabled = False
            btnproductos.Enabled = False
            Button2.Enabled = False
        End If

    End Sub

    Private Sub btnclientes_Click(sender As Object, e As EventArgs) Handles btnclientes.Click
        polizas.Show()


    End Sub

    Private Sub btncambiarcontraseña_Click(sender As Object, e As EventArgs) Handles btncambiarcontraseña.Click
        cambiar_contraseña.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        eventos.Show()
        Me.Close()


    End Sub

    Private Sub lbltipo_Click(sender As Object, e As EventArgs) Handles lbltipo.Click

    End Sub

    Private Sub agregarusuario_Click(sender As Object, e As EventArgs) Handles agregarusuario.Click
        crearusuario.Show()


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Facturación.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        soporte.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        hora.Text = TimeOfDay.TimeOfDay.ToString
        fecha.Text = Today
    End Sub
End Class
