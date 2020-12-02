Public Class factura

    Private Sub btncobrar_Click(sender As Object, e As EventArgs) Handles btncobrar.Click

        PrintDialog1.PrinterSettings = imprimirfactura.PrinterSettings


        Dim a As Integer = Label24.Text
        Dim b As Integer = Label27.Text

        If a > b Then
            MsgBox("no hay mas saldos que pagar ")




        ElseIf txtnumerodepoliza.Text <> "" Then

            Dim pagonum As Integer
            Dim numdepoliza As String
            Dim dni As String
            Dim nombre As String
            Dim apellido As String
            Dim direccion As String
            Dim usuario As String
            Dim vencimientodepago As Date
            Dim fechadeabono As Date
            Dim vencimientodepoliza As Date
            Dim seguro As String
            Dim monto As Double



            usuario = labelusuario
            dni = Label21.Text
            numdepoliza = Label2.Text
            nombre = Label4.Text
            apellido = Label6.Text
            direccion = Label8.Text
            vencimientodepago = Label12.Text
            fechadeabono = Label10.Text
            vencimientodepoliza = Label17.Text
            seguro = Label15.Text
            monto = Label20.Text
            pagonum = Label24.Text





            cmd.CommandType = CommandType.Text
            cmd.Connection = con



            sql = " INSERT INTO FACTURACION(USUARIO,NUMDEPOLIZA,DNI,NOMBRE,APELLIDO,DIRECCION,FECHADEABONO,VENCIMIENTODEPAGO,SEGURO,VENCIMIENTODEPOLIZA,MONTO,PAGONUM)"
            sql += "VALUES ('" & usuario & "'," & numdepoliza & ",'" & dni & "','" & nombre
            sql += "','" & apellido & "','" & direccion & "','" & fechadeabono & "','" & vencimientodepago & "','" & seguro & "','" & vencimientodepoliza & "','" & monto
            sql += "'," & pagonum & ")"





            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
                btncobrar.Hide()
                Label28.Show()
                MsgBox("Cobro realizado")

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try


            Label14.Hide()
            txtnumerodepoliza.Hide()

            Label14.Hide()
            txtnumerodepoliza.Hide()
            Label29.Hide()
            TextBox1.Hide()
            Label30.Hide()
            generar.Hide()
            Dim ask As MsgBoxResult = MsgBox("desea imprimir el comprobante", MsgBoxStyle.YesNo, "Impresión")
            If ask = MsgBoxResult.Yes Then

                imprimirfactura.Print()




                MsgBox("se esta imprimiendo comprobante")

            Else
                Me.Close()

                End If

                Me.Close()











            End If





    End Sub


    Private Sub factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label28.Hide()

    End Sub

    Private Sub generar_Click(sender As Object, e As EventArgs) Handles generar.Click
        Label24.Text = 0

        Dim meses As Integer



        meses = TextBox1.Text


        If txtnumerodepoliza.Text <> "" Then
            buscarpoliza(Me.txtnumerodepoliza.Text)

            Dim n As Date = Now
            Dim n2 As Date = n.AddMonths(meses)


            If dr.Read Then
                Label21.Text = dr(7).ToString()
                Label4.Text = dr(0).ToString()
                Label2.Text = txtnumerodepoliza.Text
                Label6.Text = dr(1).ToString()
                Label8.Text = dr(3).ToString()
                Label10.Text = n
                Label12.Text = n2
                Label15.Text = dr(4).ToString()
                Label17.Text = dr(8).ToString()
                dr.Close()


            End If




        End If

        If Label15.Text <> "" Then
            preciodescripcionproducto(Label15.Text)

            If dr.Read Then

                Label3.Text = dr(2).ToString()
                Label27.Text = dr(3).ToString()
                Label20.Text = dr(1).ToString() * meses
            End If
            dr.Close()
        End If



        If Label24.Text = 0 Then
            Label24.Text = Label24.Text + meses
        End If

        If txtnumerodepoliza.Text <> "" Then
            pagnum(txtnumerodepoliza.Text)

            If dr.Read Then
                If dr(0).ToString() <> "" Then
                    Dim ns As Date
                    Label24.Text = dr(0).ToString() + meses
                    ns = dr(1).ToString
                    Label12.Text = ns.AddMonths(meses)
                End If
                dr.Close()

            End If

        End If



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txtnumerodepoliza_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumerodepoliza.KeyPress
        solonumeros(e)
    End Sub


End Class