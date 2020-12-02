Public Class Facturación
    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btncobrar_Click(sender As Object, e As EventArgs) Handles btncobrar.Click
        factura.Show()
        Me.Hide()


    End Sub

    Private Sub btneventos_Click(sender As Object, e As EventArgs) Handles btneventos.Click
        Cobrosefectuados.Show()

    End Sub

    Private Sub Facturación_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If labeltipo = "USER" Then
            btneventos.Enabled = False
        End If
    End Sub
End Class