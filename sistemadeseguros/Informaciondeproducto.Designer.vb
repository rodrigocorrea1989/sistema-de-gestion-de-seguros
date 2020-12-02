<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informaciondeproducto
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtinfocobertura = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btncerrar0 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdescripcionproductoinfo = New System.Windows.Forms.RichTextBox()
        Me.txtinfoprecio = New System.Windows.Forms.TextBox()
        Me.comboinformacionproducto = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(789, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 36)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(582, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 24)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Meses"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(248, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(215, 24)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Tiempo de Cobertura "
        '
        'txtinfocobertura
        '
        Me.txtinfocobertura.Location = New System.Drawing.Point(469, 213)
        Me.txtinfocobertura.Name = "txtinfocobertura"
        Me.txtinfocobertura.ReadOnly = True
        Me.txtinfocobertura.Size = New System.Drawing.Size(98, 20)
        Me.txtinfocobertura.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(582, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 24)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Mensual"
        '
        'btncerrar0
        '
        Me.btncerrar0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncerrar0.Location = New System.Drawing.Point(789, 271)
        Me.btncerrar0.Name = "btncerrar0"
        Me.btncerrar0.Size = New System.Drawing.Size(201, 36)
        Me.btncerrar0.TabIndex = 36
        Me.btncerrar0.Text = "Volver"
        Me.btncerrar0.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(248, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 24)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(361, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 24)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Precio $"
        '
        'txtdescripcionproductoinfo
        '
        Me.txtdescripcionproductoinfo.Location = New System.Drawing.Point(386, 271)
        Me.txtdescripcionproductoinfo.Name = "txtdescripcionproductoinfo"
        Me.txtdescripcionproductoinfo.ReadOnly = True
        Me.txtdescripcionproductoinfo.Size = New System.Drawing.Size(305, 131)
        Me.txtdescripcionproductoinfo.TabIndex = 33
        Me.txtdescripcionproductoinfo.Text = ""
        '
        'txtinfoprecio
        '
        Me.txtinfoprecio.Location = New System.Drawing.Point(469, 170)
        Me.txtinfoprecio.Name = "txtinfoprecio"
        Me.txtinfoprecio.ReadOnly = True
        Me.txtinfoprecio.Size = New System.Drawing.Size(98, 20)
        Me.txtinfoprecio.TabIndex = 32
        '
        'comboinformacionproducto
        '
        Me.comboinformacionproducto.FormattingEnabled = True
        Me.comboinformacionproducto.Location = New System.Drawing.Point(386, 79)
        Me.comboinformacionproducto.Name = "comboinformacionproducto"
        Me.comboinformacionproducto.Size = New System.Drawing.Size(298, 21)
        Me.comboinformacionproducto.TabIndex = 31
        Me.comboinformacionproducto.Text = "SELECCIONAR PRODUCTO"
        '
        'Informaciondeproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1099, 586)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtinfocobertura)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btncerrar0)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdescripcionproductoinfo)
        Me.Controls.Add(Me.txtinfoprecio)
        Me.Controls.Add(Me.comboinformacionproducto)
        Me.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.MaximumSize = New System.Drawing.Size(1115, 625)
        Me.MinimumSize = New System.Drawing.Size(1115, 625)
        Me.Name = "Informaciondeproducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información de producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtinfocobertura As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btncerrar0 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdescripcionproductoinfo As RichTextBox
    Friend WithEvents txtinfoprecio As TextBox
    Friend WithEvents comboinformacionproducto As ComboBox
End Class
