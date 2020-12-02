Public Class login




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnacceder.Click


        Dim usuario As String
        Dim password As String
        Dim tipo As String


        usuario = Me.txtusuario.Text
        password = Me.txtpassword.Text
        tipo = ""


        If txtusuario.Text = "" Then
            MsgBox("campo usuario se encuentra vacío")
        ElseIf txtpassword.Text = "" Then
            MsgBox("campo contraseña se encuentra vacío")
            txtpassword.Select()
        ElseIf Me.txtusuario.Text <> "" Then
            logear(Me.txtusuario.Text)


            If dr.Read Then
                tipo = dr(1).ToString

                If password = dr(0).ToString Then
                    labeltipo = tipo.ToString
                    labelusuario = usuario.ToString
                    segurosis.Show()
                    Me.Close()


                Else


                    MsgBox("contraseña incorrecto")
                    Me.txtpassword.Text = ""
                    Me.txtpassword.Select()

                End If

            Else
                MsgBox("usuario incorrecto")
                Me.txtusuario.Select()
                Me.txtusuario.Text = ""
                Me.txtpassword.Text = ""
                Me.txtpassword.Enabled = False
            End If

            dr.Close()
        End If








    End Sub

    Private Sub btncambiarcontraseña_Click(sender As Object, e As EventArgs)
        cambiar_contraseña.Show()


    End Sub



    Private Sub txtusuario_Leave(sender As Object, e As EventArgs) Handles txtusuario.Leave

        If txtusuario.Text = "" Then
            MsgBox("campo usuario se encuentra vacío")
        End If

        If Me.txtusuario.Text <> "" Then
            txtpassword.Enabled = True
            txtpassword.Select()

        End If

        If Me.txtusuario.Text = "" Then
            txtpassword.Enabled = False
        End If

    End Sub


End Class