<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class alta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alta))
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.dni = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncerrar0 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.usuario = New System.Windows.Forms.Label()
        Me.combonombreproductos = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprecioalta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbeneficiosalta = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdescripcionalta = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnumpoliza = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtcoverturavalidoxmeses = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.combopromotores = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.fechaalta = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.fechavencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(433, 43)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(239, 20)
        Me.txtdni.TabIndex = 0
        '
        'dni
        '
        Me.dni.AutoSize = True
        Me.dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dni.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dni.Location = New System.Drawing.Point(369, 43)
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(37, 20)
        Me.dni.TabIndex = 1
        Me.dni.Text = "DNI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(341, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(432, 80)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(239, 20)
        Me.txtnombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(340, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellido"
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(432, 121)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(239, 20)
        Me.txtapellido.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(334, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Teléfono"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(432, 159)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(239, 20)
        Me.txttelefono.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(334, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Dirección"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(432, 194)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(238, 20)
        Me.txtdireccion.TabIndex = 8
        '
        'btnaceptar
        '
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.Location = New System.Drawing.Point(818, 447)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(156, 35)
        Me.btnaceptar.TabIndex = 10
        Me.btnaceptar.Text = "ACEPTAR"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'btncerrar0
        '
        Me.btncerrar0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar0.Location = New System.Drawing.Point(806, 91)
        Me.btncerrar0.Name = "btncerrar0"
        Me.btncerrar0.Size = New System.Drawing.Size(201, 36)
        Me.btncerrar0.TabIndex = 11
        Me.btncerrar0.Text = "cerrar"
        Me.btncerrar0.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(806, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(775, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 31)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Usuario:"
        '
        'usuario
        '
        Me.usuario.AutoSize = True
        Me.usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.usuario.Location = New System.Drawing.Point(896, 31)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(110, 31)
        Me.usuario.TabIndex = 13
        Me.usuario.Text = "usuario"
        '
        'combonombreproductos
        '
        Me.combonombreproductos.FormattingEnabled = True
        Me.combonombreproductos.Location = New System.Drawing.Point(432, 271)
        Me.combonombreproductos.Name = "combonombreproductos"
        Me.combonombreproductos.Size = New System.Drawing.Size(238, 21)
        Me.combonombreproductos.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(333, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Productos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(371, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Precio"
        '
        'txtprecioalta
        '
        Me.txtprecioalta.Location = New System.Drawing.Point(476, 309)
        Me.txtprecioalta.Name = "txtprecioalta"
        Me.txtprecioalta.ReadOnly = True
        Me.txtprecioalta.Size = New System.Drawing.Size(146, 20)
        Me.txtprecioalta.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(648, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "$ Mensual"
        '
        'txtbeneficiosalta
        '
        Me.txtbeneficiosalta.Location = New System.Drawing.Point(27, 432)
        Me.txtbeneficiosalta.Name = "txtbeneficiosalta"
        Me.txtbeneficiosalta.ReadOnly = True
        Me.txtbeneficiosalta.Size = New System.Drawing.Size(268, 122)
        Me.txtbeneficiosalta.TabIndex = 21
        Me.txtbeneficiosalta.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(497, 377)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Descripcion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(100, 398)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Beneficios"
        '
        'txtdescripcionalta
        '
        Me.txtdescripcionalta.Location = New System.Drawing.Point(358, 400)
        Me.txtdescripcionalta.Name = "txtdescripcionalta"
        Me.txtdescripcionalta.Size = New System.Drawing.Size(385, 174)
        Me.txtdescripcionalta.TabIndex = 24
        Me.txtdescripcionalta.Text = resources.GetString("txtdescripcionalta.Text")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(20, 297)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 20)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Numero de póliza"
        '
        'txtnumpoliza
        '
        Me.txtnumpoliza.Location = New System.Drawing.Point(158, 297)
        Me.txtnumpoliza.Name = "txtnumpoliza"
        Me.txtnumpoliza.Size = New System.Drawing.Size(98, 20)
        Me.txtnumpoliza.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(352, 231)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 20)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "E-mail"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(432, 231)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(238, 20)
        Me.txtemail.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(482, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 31)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "ALTA"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(32, 353)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 20)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "VALIDA POR"
        '
        'txtcoverturavalidoxmeses
        '
        Me.txtcoverturavalidoxmeses.Location = New System.Drawing.Point(158, 353)
        Me.txtcoverturavalidoxmeses.Name = "txtcoverturavalidoxmeses"
        Me.txtcoverturavalidoxmeses.ReadOnly = True
        Me.txtcoverturavalidoxmeses.Size = New System.Drawing.Size(79, 20)
        Me.txtcoverturavalidoxmeses.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(247, 353)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 20)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "MESES"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(389, 341)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 20)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Promotor"
        '
        'combopromotores
        '
        Me.combopromotores.FormattingEnabled = True
        Me.combopromotores.Location = New System.Drawing.Point(476, 340)
        Me.combopromotores.Name = "combopromotores"
        Me.combopromotores.Size = New System.Drawing.Size(146, 21)
        Me.combopromotores.TabIndex = 33
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(818, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 35)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Reiniciar operacion"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(35, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(176, 20)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Fecha de Alta de Póliza"
        '
        'fechaalta
        '
        Me.fechaalta.Location = New System.Drawing.Point(36, 52)
        Me.fechaalta.Name = "fechaalta"
        Me.fechaalta.Size = New System.Drawing.Size(200, 20)
        Me.fechaalta.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(20, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(236, 20)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Fecha de Vencimiento de Póliza"
        '
        'fechavencimiento
        '
        Me.fechavencimiento.Enabled = False
        Me.fechavencimiento.Location = New System.Drawing.Point(38, 168)
        Me.fechavencimiento.Name = "fechavencimiento"
        Me.fechavencimiento.Size = New System.Drawing.Size(200, 20)
        Me.fechavencimiento.TabIndex = 39
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(39, 91)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(199, 23)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = " volver a fecha actual"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1099, 586)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.fechavencimiento)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.fechaalta)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.combopromotores)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtcoverturavalidoxmeses)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtnumpoliza)
        Me.Controls.Add(Me.txtdescripcionalta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtbeneficiosalta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtprecioalta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.combonombreproductos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btncerrar0)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.dni)
        Me.Controls.Add(Me.txtdni)
        Me.MaximumSize = New System.Drawing.Size(1115, 625)
        Me.MinimumSize = New System.Drawing.Size(1115, 625)
        Me.Name = "alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtdni As TextBox
    Friend WithEvents dni As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents btnaceptar As Button
    Friend WithEvents btncerrar0 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents usuario As Label
    Friend WithEvents combonombreproductos As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtprecioalta As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbeneficiosalta As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtdescripcionalta As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtnumpoliza As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtcoverturavalidoxmeses As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents combopromotores As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents fechaalta As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents fechavencimiento As DateTimePicker
    Friend WithEvents Button3 As Button
End Class
