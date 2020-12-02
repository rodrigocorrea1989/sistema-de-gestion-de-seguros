<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class baja
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btncerrar0 = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txteliminardireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txteliminartelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txteliminarapellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txteliminarnombre = New System.Windows.Forms.TextBox()
        Me.dni = New System.Windows.Forms.Label()
        Me.txteliminardni = New System.Windows.Forms.TextBox()
        Me.txteliminarproducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdescripcionbaja = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbeneficiobaja = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnumpolizaeliminar = New System.Windows.Forms.TextBox()
        Me.EMAIL = New System.Windows.Forms.Label()
        Me.txtcorreobaja = New System.Windows.Forms.TextBox()
        Me.fechavencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtvalidopormesbaja = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpreciobaja = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtpromotorbaja = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(765, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 36)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btncerrar0
        '
        Me.btncerrar0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar0.Location = New System.Drawing.Point(765, 159)
        Me.btncerrar0.Name = "btncerrar0"
        Me.btncerrar0.Size = New System.Drawing.Size(201, 36)
        Me.btncerrar0.TabIndex = 24
        Me.btncerrar0.Text = "cerrar"
        Me.btncerrar0.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Enabled = False
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(810, 477)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(156, 35)
        Me.btneliminar.TabIndex = 23
        Me.btneliminar.Text = "ELIMINAR"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(327, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Dirección"
        '
        'txteliminardireccion
        '
        Me.txteliminardireccion.Enabled = False
        Me.txteliminardireccion.Location = New System.Drawing.Point(425, 238)
        Me.txteliminardireccion.Name = "txteliminardireccion"
        Me.txteliminardireccion.ReadOnly = True
        Me.txteliminardireccion.Size = New System.Drawing.Size(239, 20)
        Me.txteliminardireccion.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(327, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Teléfono"
        '
        'txteliminartelefono
        '
        Me.txteliminartelefono.Enabled = False
        Me.txteliminartelefono.Location = New System.Drawing.Point(425, 200)
        Me.txteliminartelefono.Name = "txteliminartelefono"
        Me.txteliminartelefono.ReadOnly = True
        Me.txteliminartelefono.Size = New System.Drawing.Size(239, 20)
        Me.txteliminartelefono.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(333, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Apellido"
        '
        'txteliminarapellido
        '
        Me.txteliminarapellido.Enabled = False
        Me.txteliminarapellido.Location = New System.Drawing.Point(425, 159)
        Me.txteliminarapellido.Name = "txteliminarapellido"
        Me.txteliminarapellido.ReadOnly = True
        Me.txteliminarapellido.Size = New System.Drawing.Size(239, 20)
        Me.txteliminarapellido.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(333, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nombre"
        '
        'txteliminarnombre
        '
        Me.txteliminarnombre.Enabled = False
        Me.txteliminarnombre.Location = New System.Drawing.Point(425, 124)
        Me.txteliminarnombre.Name = "txteliminarnombre"
        Me.txteliminarnombre.ReadOnly = True
        Me.txteliminarnombre.Size = New System.Drawing.Size(239, 20)
        Me.txteliminarnombre.TabIndex = 15
        '
        'dni
        '
        Me.dni.AutoSize = True
        Me.dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dni.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dni.Location = New System.Drawing.Point(361, 89)
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(37, 20)
        Me.dni.TabIndex = 14
        Me.dni.Text = "DNI"
        '
        'txteliminardni
        '
        Me.txteliminardni.Enabled = False
        Me.txteliminardni.Location = New System.Drawing.Point(425, 89)
        Me.txteliminardni.Name = "txteliminardni"
        Me.txteliminardni.ReadOnly = True
        Me.txteliminardni.Size = New System.Drawing.Size(239, 20)
        Me.txteliminardni.TabIndex = 13
        '
        'txteliminarproducto
        '
        Me.txteliminarproducto.Enabled = False
        Me.txteliminarproducto.Location = New System.Drawing.Point(425, 273)
        Me.txteliminarproducto.Name = "txteliminarproducto"
        Me.txteliminarproducto.ReadOnly = True
        Me.txteliminarproducto.Size = New System.Drawing.Size(239, 20)
        Me.txteliminarproducto.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(323, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Producto"
        '
        'txtdescripcionbaja
        '
        Me.txtdescripcionbaja.Location = New System.Drawing.Point(354, 397)
        Me.txtdescripcionbaja.Name = "txtdescripcionbaja"
        Me.txtdescripcionbaja.ReadOnly = True
        Me.txtdescripcionbaja.Size = New System.Drawing.Size(385, 174)
        Me.txtdescripcionbaja.TabIndex = 29
        Me.txtdescripcionbaja.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(496, 374)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Descripcion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(89, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Beneficios"
        '
        'txtbeneficiobaja
        '
        Me.txtbeneficiobaja.Location = New System.Drawing.Point(21, 124)
        Me.txtbeneficiobaja.Name = "txtbeneficiobaja"
        Me.txtbeneficiobaja.ReadOnly = True
        Me.txtbeneficiobaja.Size = New System.Drawing.Size(268, 122)
        Me.txtbeneficiobaja.TabIndex = 30
        Me.txtbeneficiobaja.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(199, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 20)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = """ingresar número de póliza"""
        '
        'txtnumpolizaeliminar
        '
        Me.txtnumpolizaeliminar.Location = New System.Drawing.Point(425, 46)
        Me.txtnumpolizaeliminar.Name = "txtnumpolizaeliminar"
        Me.txtnumpolizaeliminar.Size = New System.Drawing.Size(239, 20)
        Me.txtnumpolizaeliminar.TabIndex = 32
        '
        'EMAIL
        '
        Me.EMAIL.AutoSize = True
        Me.EMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMAIL.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EMAIL.Location = New System.Drawing.Point(327, 309)
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.Size = New System.Drawing.Size(53, 20)
        Me.EMAIL.TabIndex = 35
        Me.EMAIL.Text = "E-mail"
        '
        'txtcorreobaja
        '
        Me.txtcorreobaja.Enabled = False
        Me.txtcorreobaja.Location = New System.Drawing.Point(425, 309)
        Me.txtcorreobaja.Name = "txtcorreobaja"
        Me.txtcorreobaja.ReadOnly = True
        Me.txtcorreobaja.Size = New System.Drawing.Size(239, 20)
        Me.txtcorreobaja.TabIndex = 34
        '
        'fechavencimiento
        '
        Me.fechavencimiento.Enabled = False
        Me.fechavencimiento.Location = New System.Drawing.Point(51, 503)
        Me.fechavencimiento.Name = "fechavencimiento"
        Me.fechavencimiento.Size = New System.Drawing.Size(200, 20)
        Me.fechavencimiento.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(102, 467)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 20)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Vencimiento"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(234, 311)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 20)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "MESES"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(19, 311)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 20)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "VALIDA POR"
        '
        'txtvalidopormesbaja
        '
        Me.txtvalidopormesbaja.Location = New System.Drawing.Point(145, 311)
        Me.txtvalidopormesbaja.Name = "txtvalidopormesbaja"
        Me.txtvalidopormesbaja.ReadOnly = True
        Me.txtvalidopormesbaja.Size = New System.Drawing.Size(79, 20)
        Me.txtvalidopormesbaja.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(245, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "$ Mensual"
        '
        'txtpreciobaja
        '
        Me.txtpreciobaja.Location = New System.Drawing.Point(93, 374)
        Me.txtpreciobaja.Name = "txtpreciobaja"
        Me.txtpreciobaja.ReadOnly = True
        Me.txtpreciobaja.Size = New System.Drawing.Size(146, 20)
        Me.txtpreciobaja.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(34, 374)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 20)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Precio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(699, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 20)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Promotor"
        '
        'txtpromotorbaja
        '
        Me.txtpromotorbaja.Location = New System.Drawing.Point(781, 46)
        Me.txtpromotorbaja.Name = "txtpromotorbaja"
        Me.txtpromotorbaja.ReadOnly = True
        Me.txtpromotorbaja.Size = New System.Drawing.Size(126, 20)
        Me.txtpromotorbaja.TabIndex = 46
        '
        'baja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1099, 586)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtpromotorbaja)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtpreciobaja)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtvalidopormesbaja)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.fechavencimiento)
        Me.Controls.Add(Me.EMAIL)
        Me.Controls.Add(Me.txtcorreobaja)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnumpolizaeliminar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtbeneficiobaja)
        Me.Controls.Add(Me.txtdescripcionbaja)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txteliminarproducto)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btncerrar0)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txteliminardireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txteliminartelefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txteliminarapellido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txteliminarnombre)
        Me.Controls.Add(Me.dni)
        Me.Controls.Add(Me.txteliminardni)
        Me.MaximumSize = New System.Drawing.Size(1115, 625)
        Me.MinimumSize = New System.Drawing.Size(1115, 625)
        Me.Name = "baja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "baja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btncerrar0 As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txteliminardireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txteliminartelefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txteliminarapellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txteliminarnombre As TextBox
    Friend WithEvents dni As Label
    Friend WithEvents txteliminardni As TextBox
    Friend WithEvents txteliminarproducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdescripcionbaja As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtbeneficiobaja As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnumpolizaeliminar As TextBox
    Friend WithEvents EMAIL As Label
    Friend WithEvents txtcorreobaja As TextBox
    Friend WithEvents fechavencimiento As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtvalidopormesbaja As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtpreciobaja As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtpromotorbaja As TextBox
End Class
