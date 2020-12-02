<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Facturación
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
        Me.btncobrar = New System.Windows.Forms.Button()
        Me.btneventos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btncobrar
        '
        Me.btncobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncobrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncobrar.Location = New System.Drawing.Point(420, 143)
        Me.btncobrar.Name = "btncobrar"
        Me.btncobrar.Size = New System.Drawing.Size(272, 96)
        Me.btncobrar.TabIndex = 12
        Me.btncobrar.Text = "Cobrar"
        Me.btncobrar.UseVisualStyleBackColor = True
        '
        'btneventos
        '
        Me.btneventos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneventos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btneventos.Location = New System.Drawing.Point(420, 311)
        Me.btneventos.Name = "btneventos"
        Me.btneventos.Size = New System.Drawing.Size(272, 96)
        Me.btneventos.TabIndex = 13
        Me.btneventos.Text = "Cobros efectuados"
        Me.btneventos.UseVisualStyleBackColor = True
        '
        'Facturación
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1099, 586)
        Me.Controls.Add(Me.btneventos)
        Me.Controls.Add(Me.btncobrar)
        Me.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.MaximumSize = New System.Drawing.Size(1115, 625)
        Me.MinimumSize = New System.Drawing.Size(1115, 625)
        Me.Name = "Facturación"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btncobrar As Button
    Friend WithEvents btneventos As Button
End Class
