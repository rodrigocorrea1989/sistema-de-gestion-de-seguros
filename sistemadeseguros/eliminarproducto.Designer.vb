<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eliminarproducto
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
        Me.comboeliminar = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcobertura = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnuevoproducto = New System.Windows.Forms.Button()
        Me.btncerrar0 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdescripcionproducto = New System.Windows.Forms.RichTextBox()
        Me.txtprecioproducto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'comboeliminar
        '
        Me.comboeliminar.FormattingEnabled = True
        Me.comboeliminar.Location = New System.Drawing.Point(378, 82)
        Me.comboeliminar.Name = "comboeliminar"
        Me.comboeliminar.Size = New System.Drawing.Size(298, 21)
        Me.comboeliminar.TabIndex = 0
        Me.comboeliminar.Text = "SELECCIONAR PRODUCTO"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(781, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 36)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(574, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 24)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Meses"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(240, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(215, 24)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Tiempo de Cobertura "
        '
        'txtcobertura
        '
        Me.txtcobertura.Location = New System.Drawing.Point(461, 209)
        Me.txtcobertura.Name = "txtcobertura"
        Me.txtcobertura.ReadOnly = True
        Me.txtcobertura.Size = New System.Drawing.Size(98, 20)
        Me.txtcobertura.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(574, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 24)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Mensual"
        '
        'txtnuevoproducto
        '
        Me.txtnuevoproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnuevoproducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtnuevoproducto.Location = New System.Drawing.Point(419, 405)
        Me.txtnuevoproducto.Name = "txtnuevoproducto"
        Me.txtnuevoproducto.Size = New System.Drawing.Size(201, 36)
        Me.txtnuevoproducto.TabIndex = 25
        Me.txtnuevoproducto.Text = "Eliminar"
        Me.txtnuevoproducto.UseVisualStyleBackColor = True
        '
        'btncerrar0
        '
        Me.btncerrar0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncerrar0.Location = New System.Drawing.Point(781, 274)
        Me.btncerrar0.Name = "btncerrar0"
        Me.btncerrar0.Size = New System.Drawing.Size(201, 36)
        Me.btncerrar0.TabIndex = 24
        Me.btncerrar0.Text = "Volver"
        Me.btncerrar0.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(240, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 24)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(353, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 24)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Precio $"
        '
        'txtdescripcionproducto
        '
        Me.txtdescripcionproducto.Location = New System.Drawing.Point(378, 235)
        Me.txtdescripcionproducto.Name = "txtdescripcionproducto"
        Me.txtdescripcionproducto.ReadOnly = True
        Me.txtdescripcionproducto.Size = New System.Drawing.Size(305, 131)
        Me.txtdescripcionproducto.TabIndex = 21
        Me.txtdescripcionproducto.Text = ""
        '
        'txtprecioproducto
        '
        Me.txtprecioproducto.Location = New System.Drawing.Point(461, 173)
        Me.txtprecioproducto.Name = "txtprecioproducto"
        Me.txtprecioproducto.ReadOnly = True
        Me.txtprecioproducto.Size = New System.Drawing.Size(98, 20)
        Me.txtprecioproducto.TabIndex = 20
        '
        'eliminarproducto
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
        Me.Controls.Add(Me.txtdescripcionproducto)
        Me.Controls.Add(Me.txtprecioproducto)
        Me.Controls.Add(Me.comboeliminar)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MaximumSize = New System.Drawing.Size(1115, 625)
        Me.MinimumSize = New System.Drawing.Size(1115, 625)
        Me.Name = "eliminarproducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eliminar producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboeliminar As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcobertura As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnuevoproducto As Button
    Friend WithEvents btncerrar0 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdescripcionproducto As RichTextBox
    Friend WithEvents txtprecioproducto As TextBox
End Class
