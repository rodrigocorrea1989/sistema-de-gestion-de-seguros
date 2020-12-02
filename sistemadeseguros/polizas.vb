Public Class polizas
    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        segurosis.Show()
        Me.Close()


    End Sub

    Private Sub btncerrar0_Click(sender As Object, e As EventArgs) Handles btncerrar0.Click
        Me.Close()


    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuario.Text = labelusuario

        If labeltipo = "USER" Then
            Button1.Enabled = False
        End If
        If labeltipo = "PROMOTOR" Then
            btnbaja.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
        End If

    End Sub

    Private Sub btnalta_Click(sender As Object, e As EventArgs) Handles btnalta.Click

        alta.Show()
        Me.Close()


    End Sub

    Private Sub btnbaja_Click(sender As Object, e As EventArgs) Handles btnbaja.Click
        Me.Close()
        baja.Show()


    End Sub

    Private Sub Perfilcliente_Click(sender As Object, e As EventArgs) Handles btnperfilcliente.Click
        fechaaltaestadopoliza.Show()
        Me.Close()

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        modificar.Show()
        Me.Close()


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        eventos.Show()


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        consultas.Show()
        Me.Close()

    End Sub
End Class