<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class nuevoproducto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.txtprecioproducto = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtdescripcionproducto = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btncerrar0 = New System.Windows.Forms.Button()
        Me.txtnuevoproducto = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcobertura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nuevo Producto"
        '
        'txtproducto
        '
        Me.txtproducto.AccessibleDescription = ""
        Me.txtproducto.Location = New System.Drawing.Point(357, 146)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(305, 20)
        Me.txtproducto.TabIndex = 1
        '
        'txtprecioproducto
        '
        Me.txtprecioproducto.Location = New System.Drawing.Point(440, 181)
        Me.txtprecioproducto.Name = "txtprecioproducto"
        Me.txtprecioproducto.Size = New System.Drawing.Size(98, 20)
        Me.txtprecioproducto.TabIndex = 2
        '
        'txtdescripcionproducto
        '
        Me.txtdescripcionproducto.Location = New System.Drawing.Point(357, 243)
        Me.txtdescripcionproducto.Name = "txtdescripcionproducto"
        Me.txtdescripcionproducto.Size = New System.Drawing.Size(305, 131)
        Me.txtdescripcionproducto.TabIndex = 3
        Me.txtdescripcionproducto.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(332, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Precio $"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(219, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripción"
        '
        'btncerrar0
        '
        Me.btncerrar0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncerrar0.Location = New System.Drawing.Point(760, 282)
        Me.btncerrar0.Name = "btncerrar0"
        Me.btncerrar0.Size = New System.Drawing.Size(201, 36)
        Me.btncerrar0.TabIndex = 13
        Me.btncerrar0.Text = "Volver"
        Me.btncerrar0.UseVisualStyleBackColor = True
        '
        'txtnuevoproducto
        '
        Me.txtnuevoproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnuevoproducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtnuevoproducto.Location = New System.Drawing.Point(398, 413)
        Me.txtnuevoproducto.Name = "txtnuevoproducto"
        Me.txtnuevoproducto.Size = New System.Drawing.Size(201, 36)
        Me.txtnuevoproducto.TabIndex = 14
        Me.txtnuevoproducto.Text = "Aceptar"
        Me.txtnuevoproducto.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(553, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Mensual"
        '
        'txtcobertura
        '
        Me.txtcobertura.Location = New System.Drawing.Point(440, 217)
        Me.txtcobertura.Name = "txtcobertura"
        Me.txtcobertura.Size = New System.Drawing.Size(98, 20)
        Me.txtcobertura.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(219, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(215, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tiempo de Cobertura "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(553, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Meses"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(760, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 36)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nuevoproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1099, 586)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcobertura)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnuevoproducto)
        Me.Controls.Add(Me.btncerrar0)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdescripcionproducto)
        Me.Controls.Add(Me.txtprecioproducto)
        Me.Controls.Add(Me.txtproducto)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaximumSize = New System.Drawing.Size(1115, 625)
        Me.MinimumSize = New System.Drawing.Size(1115, 625)
        Me.Name = "nuevoproducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "nuevoproducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents txtprecioproducto As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtdescripcionproducto As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btncerrar0 As Button
    Friend WithEvents txtnuevoproducto As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcobertura As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
