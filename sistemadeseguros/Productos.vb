Public Class Productos
    Private Sub btnnuevoproducto_Click(sender As Object, e As EventArgs) Handles btnnuevoproducto.Click
        nuevoproducto.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        eliminarproducto.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Informaciondeproducto.Show()
        Me.Close()






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        modificarproducto.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        eventos_productos.Show()
        Me.Close()

    End Sub
End Class