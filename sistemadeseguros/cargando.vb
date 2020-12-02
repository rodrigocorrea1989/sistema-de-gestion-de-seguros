Public Class cargando
    Private Sub cargando_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarbd()
        login.Show()
        Me.Close()



    End Sub
End Class