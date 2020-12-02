<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class eventos
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
        Me.labeleventos = New System.Windows.Forms.Label()
        Me.EventosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Eventostabla = New sistemadeseguros.eventostabla()
        Me.EventosTableAdapter = New sistemadeseguros.eventostablaTableAdapters.eventosTableAdapter()
        Me.TableAdapterManager = New sistemadeseguros.eventostablaTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.EventosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Eventostabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labeleventos
        '
        Me.labeleventos.AutoSize = True
        Me.labeleventos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeleventos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labeleventos.Location = New System.Drawing.Point(681, 34)
        Me.labeleventos.Name = "labeleventos"
        Me.labeleventos.Size = New System.Drawing.Size(151, 31)
        Me.labeleventos.TabIndex = 10
        Me.labeleventos.Text = "EVENTOS"
        '
        'EventosBindingSource
        '
        Me.EventosBindingSource.DataMember = "eventos"
        Me.EventosBindingSource.DataSource = Me.Eventostabla
        '
        'Eventostabla
        '
        Me.Eventostabla.DataSetName = "eventostabla"
        Me.Eventostabla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EventosTableAdapter
        '
        Me.EventosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.eventosTableAdapter = Me.EventosTableAdapter
        Me.TableAdapterManager.UpdateOrder = sistemadeseguros.eventostablaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1760, 851)
        Me.DataGridView1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(141, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 35)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1144, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(201, 35)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Exportar Excel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'eventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1784, 961)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.labeleventos)
        Me.MaximumSize = New System.Drawing.Size(1800, 1000)
        Me.MinimumSize = New System.Drawing.Size(1800, 1000)
        Me.Name = "eventos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eventos"
        CType(Me.EventosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Eventostabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labeleventos As Label
    Friend WithEvents Eventostabla As eventostabla
    Friend WithEvents EventosBindingSource As BindingSource
    Friend WithEvents EventosTableAdapter As eventostablaTableAdapters.eventosTableAdapter
    Friend WithEvents TableAdapterManager As eventostablaTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
