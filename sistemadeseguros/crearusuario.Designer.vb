<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crearusuario
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
        Me.txtpasswordnuevo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusuarionuevo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncrearusuario = New System.Windows.Forms.Button()
        Me.txtdninuevousuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblprivi = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtpasswordnuevo
        '
        Me.txtpasswordnuevo.Location = New System.Drawing.Point(169, 179)
        Me.txtpasswordnuevo.Name = "txtpasswordnuevo"
        Me.txtpasswordnuevo.Size = New System.Drawing.Size(195, 20)
        Me.txtpasswordnuevo.TabIndex = 7
        Me.txtpasswordnuevo.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(206, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "CONTRASEÑA"
        '
        'txtusuarionuevo
        '
        Me.txtusuarionuevo.Location = New System.Drawing.Point(169, 119)
        Me.txtusuarionuevo.Name = "txtusuarionuevo"
        Me.txtusuarionuevo.Size = New System.Drawing.Size(195, 20)
        Me.txtusuarionuevo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(165, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NOMBRE DE USUARIO"
        '
        'btncrearusuario
        '
        Me.btncrearusuario.Location = New System.Drawing.Point(210, 430)
        Me.btncrearusuario.Name = "btncrearusuario"
        Me.btncrearusuario.Size = New System.Drawing.Size(111, 23)
        Me.btncrearusuario.TabIndex = 10
        Me.btncrearusuario.Text = "aceptar"
        Me.btncrearusuario.UseVisualStyleBackColor = True
        '
        'txtdninuevousuario
        '
        Me.txtdninuevousuario.Location = New System.Drawing.Point(169, 53)
        Me.txtdninuevousuario.Name = "txtdninuevousuario"
        Me.txtdninuevousuario.Size = New System.Drawing.Size(195, 20)
        Me.txtdninuevousuario.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(241, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "DNI"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(169, 320)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(221, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "APELLIDO"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(172, 260)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(195, 20)
        Me.TextBox2.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(221, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "NOMBRE "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(500, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Privilegios"
        '
        'lblprivi
        '
        Me.lblprivi.AutoSize = True
        Me.lblprivi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprivi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblprivi.Location = New System.Drawing.Point(500, 131)
        Me.lblprivi.Name = "lblprivi"
        Me.lblprivi.Size = New System.Drawing.Size(39, 20)
        Me.lblprivi.TabIndex = 18
        Me.lblprivi.Text = "???"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"USER", "ADMIN", "PROMOTOR"})
        Me.ComboBox1.Location = New System.Drawing.Point(206, 380)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(232, 357)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "TIPO"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(835, 495)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "VER TODOS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'crearusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1009, 530)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblprivi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtdninuevousuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btncrearusuario)
        Me.Controls.Add(Me.txtpasswordnuevo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtusuarionuevo)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(1025, 569)
        Me.MinimumSize = New System.Drawing.Size(1025, 569)
        Me.Name = "crearusuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "crearusuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtpasswordnuevo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusuarionuevo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btncrearusuario As Button
    Friend WithEvents txtdninuevousuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblprivi As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
End Class
