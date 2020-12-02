
Public Class fechaaltaestadopoliza
    Public Sub txtnumerodepoliza_Leave(sender As Object, e As EventArgs) Handles txtnumerodepoliza.Leave


        If txtnumerodepoliza.Text <> "" Then
            buscarpoliza(Me.txtnumerodepoliza.Text)

            If dr.Read Then
                txtdniperfil.Text = dr(7).ToString()
                txtnombreperfil.Text = dr(0).ToString()
                txtapellidoperfil.Text = dr(1).ToString()
                txttelefonoperfil.Text = dr(2).ToString()
                txtdireccionperfil.Text = dr(3).ToString()
                txtproductoperfil.Text = dr(4).ToString()
                fechadealta.Value = dr(5).ToString
                txtdescripcionperfil.Text = dr(6).ToString()
                fechavencimientoestado.Value = dr(8).ToString()
                txtemailestado.Text = dr(9).ToString()
                txtpromotorestadopoliza.Text = dr(10).ToString
                lblestado.Text = dr(11).ToString




                dr.Close()
                Dim n As Date = Now
                If fechavencimientoestado.Value <= n Then
                    lblestado.Text = "VENCIDO"
                    Labelalert.Show()
                    Labelalert.Text = "debe crear un nuevo alta de poliza"
                Else

                    lblestado.Text = "ACTIVO"

                End If

            Else

                MsgBox("no se ha encontrado el registro en la base de datos")


            End If

        End If

        If txtproductoperfil.Text <> "" Then
            preciodescripcionproducto(txtproductoperfil.Text)

            If dr.Read Then


                txtbeneficiosperfil.Text = dr(2).ToString()
                txtvalidopormesestado.Text = dr(3).ToString()
                txtprecioestadopoliza.Text = dr(1).ToString()
            End If

        End If

        dr.Close()




        If lblestado.Text = "ACTIVO" Then
            Labelalert.Hide()
            lblestado.BackColor = Color.Green
            lbl1.BackColor = Nothing
            lbl2.BackColor = Nothing
            lbl3.BackColor = Nothing
            lbl4.BackColor = Nothing
            lbl5.BackColor = Nothing
            lbl6.BackColor = Nothing
            lbl7.BackColor = Nothing
            lbl8.BackColor = Nothing
            lbl9.BackColor = Nothing
            lbl10.BackColor = Nothing
            lbl11.BackColor = Nothing
            lbl12.BackColor = Nothing
            lbl13.BackColor = Nothing


        ElseIf lblestado.Text = "VENCIDO" Then
            lblestado.BackColor = Color.Red
            lbl1.BackColor = Color.Red
            lbl2.BackColor = Color.Red
            lbl3.BackColor = Color.Red
            lbl4.BackColor = Color.Red
            lbl5.BackColor = Color.Red
            lbl6.BackColor = Color.Red
            lbl7.BackColor = Color.Red
            lbl8.BackColor = Color.Red
            lbl9.BackColor = Color.Red
            lbl10.BackColor = Color.Red
            lbl11.BackColor = Color.Red
            lbl12.BackColor = Color.Red
            lbl13.BackColor = Color.Red
            Labelalert.BackColor = Color.Red





        End If


    End Sub

    Private Sub buscarpóliza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnumerodepoliza.Select()
        Labelalert.Hide()


    End Sub

    Private Sub btncerrar0_Click(sender As Object, e As EventArgs)
        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        polizas.Show()
        Me.Close()


    End Sub

    Private Sub txtnumerodepoliza_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumerodepoliza.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txtdniperfil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdniperfil.KeyPress
        solonumeros(e)
    End Sub

    Private Sub Facturar_Click(sender As Object, e As EventArgs) 




    End Sub


End Class