<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class consultas
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtadjuntardni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtcomboreporte = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 86)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(1066, 474)
        Me.DataGridView2.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(44, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "VENCIDOS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(736, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 30)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "EXPORTAR A EXCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtadjuntardni
        '
        Me.txtadjuntardni.Location = New System.Drawing.Point(416, 36)
        Me.txtadjuntardni.Name = "txtadjuntardni"
        Me.txtadjuntardni.Size = New System.Drawing.Size(118, 20)
        Me.txtadjuntardni.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(449, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "D.N.I"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(902, 29)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 30)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "REINICIAR CONSULTA"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(580, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PROMOTOR"
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.Green
        Me.Button4.Location = New System.Drawing.Point(212, 26)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(151, 30)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "ACTIVOS"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtcomboreporte
        '
        Me.txtcomboreporte.FormattingEnabled = True
        Me.txtcomboreporte.Location = New System.Drawing.Point(574, 35)
        Me.txtcomboreporte.Name = "txtcomboreporte"
        Me.txtcomboreporte.Size = New System.Drawing.Size(121, 21)
        Me.txtcomboreporte.TabIndex = 9
        '
        'consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1099, 586)
        Me.Controls.Add(Me.txtcomboreporte)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtadjuntardni)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView2)
        Me.MaximumSize = New System.Drawing.Size(1115, 625)
        Me.MinimumSize = New System.Drawing.Size(1115, 625)
        Me.Name = "consultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listadepolizas"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtadjuntardni As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents txtcomboreporte As ComboBox
End Class
