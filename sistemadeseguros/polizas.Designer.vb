<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class polizas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnbaja = New System.Windows.Forms.Button()
        Me.btnalta = New System.Windows.Forms.Button()
        Me.btncerrar0 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usuario = New System.Windows.Forms.Label()
        Me.btnperfilcliente = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnmodificar
        '
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.Location = New System.Drawing.Point(406, 159)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(286, 66)
        Me.btnmodificar.TabIndex = 8
        Me.btnmodificar.Text = "Modificación"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnbaja
        '
        Me.btnbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbaja.Location = New System.Drawing.Point(406, 231)
        Me.btnbaja.Name = "btnbaja"
        Me.btnbaja.Size = New System.Drawing.Size(286, 66)
        Me.btnbaja.TabIndex = 7
        Me.btnbaja.Text = "Baja"
        Me.btnbaja.UseVisualStyleBackColor = True
        '
        'btnalta
        '
        Me.btnalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalta.Location = New System.Drawing.Point(406, 87)
        Me.btnalta.Name = "btnalta"
        Me.btnalta.Size = New System.Drawing.Size(286, 66)
        Me.btnalta.TabIndex = 6
        Me.btnalta.Text = "Alta"
        Me.btnalta.UseVisualStyleBackColor = True
        '
        'btncerrar0
        '
        Me.btncerrar0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar0.Location = New System.Drawing.Point(445, 502)
        Me.btncerrar0.Name = "btncerrar0"
        Me.btncerrar0.Size = New System.Drawing.Size(201, 36)
        Me.btncerrar0.TabIndex = 10
        Me.btncerrar0.Text = "cerrar"
        Me.btncerrar0.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(55, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Usuario:"
        '
        'usuario
        '
        Me.usuario.AutoSize = True
        Me.usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.usuario.Location = New System.Drawing.Point(176, 109)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(110, 31)
        Me.usuario.TabIndex = 11
        Me.usuario.Text = "usuario"
        '
        'btnperfilcliente
        '
        Me.btnperfilcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnperfilcliente.Location = New System.Drawing.Point(406, 15)
        Me.btnperfilcliente.Name = "btnperfilcliente"
        Me.btnperfilcliente.Size = New System.Drawing.Size(286, 66)
        Me.btnperfilcliente.TabIndex = 13
        Me.btnperfilcliente.Text = "Buscar Póliza"
        Me.btnperfilcliente.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(406, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(286, 66)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Eventos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(406, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(286, 66)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Consultas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'polizas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1099, 586)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnperfilcliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.btncerrar0)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnbaja)
        Me.Controls.Add(Me.btnalta)
        Me.MaximumSize = New System.Drawing.Size(1115, 625)
        Me.MinimumSize = New System.Drawing.Size(1115, 625)
        Me.Name = "polizas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pólizas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnbaja As Button
    Friend WithEvents btnalta As Button
    Friend WithEvents btncerrar0 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents usuario As Label
    Friend WithEvents btnperfilcliente As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
