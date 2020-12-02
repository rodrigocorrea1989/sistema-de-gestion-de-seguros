<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class segurosis
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.btncerrar0 = New System.Windows.Forms.Button()
        Me.btnproductos = New System.Windows.Forms.Button()
        Me.usuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncambiarcontraseña = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.agregarusuario = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.hora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.fecha = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnclientes
        '
        Me.btnclientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclientes.Location = New System.Drawing.Point(402, 98)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(286, 66)
        Me.btnclientes.TabIndex = 0
        Me.btnclientes.Text = "Pólizas"
        Me.btnclientes.UseVisualStyleBackColor = True
        '
        'btncerrar0
        '
        Me.btncerrar0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar0.Location = New System.Drawing.Point(444, 447)
        Me.btncerrar0.Name = "btncerrar0"
        Me.btncerrar0.Size = New System.Drawing.Size(201, 36)
        Me.btncerrar0.TabIndex = 6
        Me.btncerrar0.Text = "Cerrar Sesión"
        Me.btncerrar0.UseVisualStyleBackColor = True
        '
        'btnproductos
        '
        Me.btnproductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproductos.Location = New System.Drawing.Point(402, 170)
        Me.btnproductos.Name = "btnproductos"
        Me.btnproductos.Size = New System.Drawing.Size(286, 66)
        Me.btnproductos.TabIndex = 8
        Me.btnproductos.Text = "Productos"
        Me.btnproductos.UseVisualStyleBackColor = True
        '
        'usuario
        '
        Me.usuario.AutoSize = True
        Me.usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.usuario.Location = New System.Drawing.Point(170, 71)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(110, 31)
        Me.usuario.TabIndex = 9
        Me.usuario.Text = "usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(49, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Usuario:"
        '
        'btncambiarcontraseña
        '
        Me.btncambiarcontraseña.Location = New System.Drawing.Point(86, 208)
        Me.btncambiarcontraseña.Name = "btncambiarcontraseña"
        Me.btncambiarcontraseña.Size = New System.Drawing.Size(111, 23)
        Me.btncambiarcontraseña.TabIndex = 11
        Me.btncambiarcontraseña.Text = "Cambiar Contraseña"
        Me.btncambiarcontraseña.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(49, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 31)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Tipo:"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltipo.Location = New System.Drawing.Point(135, 115)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(62, 31)
        Me.lbltipo.TabIndex = 14
        Me.lbltipo.Text = "tipo"
        '
        'agregarusuario
        '
        Me.agregarusuario.Location = New System.Drawing.Point(86, 251)
        Me.agregarusuario.Name = "agregarusuario"
        Me.agregarusuario.Size = New System.Drawing.Size(111, 23)
        Me.agregarusuario.TabIndex = 15
        Me.agregarusuario.Text = "Crear Usuario"
        Me.agregarusuario.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(402, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(286, 66)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Facturación"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(444, 503)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 36)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Cerrar Programa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(843, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(201, 36)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Soporte Técnico"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'hora
        '
        Me.hora.AutoSize = True
        Me.hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hora.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.hora.Location = New System.Drawing.Point(49, 481)
        Me.hora.Name = "hora"
        Me.hora.Size = New System.Drawing.Size(65, 29)
        Me.hora.TabIndex = 21
        Me.hora.Text = "hora"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.fecha.Location = New System.Drawing.Point(49, 447)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(76, 29)
        Me.fecha.TabIndex = 22
        Me.fecha.Text = "fecha"
        '
        'segurosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1099, 586)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.hora)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.agregarusuario)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btncambiarcontraseña)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.btnproductos)
        Me.Controls.Add(Me.btncerrar0)
        Me.Controls.Add(Me.btnclientes)
        Me.MaximumSize = New System.Drawing.Size(1115, 625)
        Me.MinimumSize = New System.Drawing.Size(1115, 625)
        Me.Name = "segurosis"
        Me.Text = "seguros sis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnclientes As Button
    Friend WithEvents btncerrar0 As Button
    Friend WithEvents btnproductos As Button
    Friend WithEvents usuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btncambiarcontraseña As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbltipo As Label
    Friend WithEvents agregarusuario As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents hora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents fecha As Label
End Class
