<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoIVA
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvIVA = New System.Windows.Forms.DataGridView()
        Me.lblTotalLineas = New System.Windows.Forms.Label()
        Me.lblNumeroLineas = New System.Windows.Forms.Label()
        CType(Me.dgvIVA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(363, 46)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(73, 13)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "LISTADO IVA"
        '
        'dgvIVA
        '
        Me.dgvIVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIVA.Location = New System.Drawing.Point(52, 92)
        Me.dgvIVA.Name = "dgvIVA"
        Me.dgvIVA.Size = New System.Drawing.Size(724, 243)
        Me.dgvIVA.TabIndex = 1
        '
        'lblTotalLineas
        '
        Me.lblTotalLineas.AutoSize = True
        Me.lblTotalLineas.Location = New System.Drawing.Point(524, 381)
        Me.lblTotalLineas.Name = "lblTotalLineas"
        Me.lblTotalLineas.Size = New System.Drawing.Size(83, 13)
        Me.lblTotalLineas.TabIndex = 2
        Me.lblTotalLineas.Text = "TOTAL LINEAS"
        '
        'lblNumeroLineas
        '
        Me.lblNumeroLineas.AutoSize = True
        Me.lblNumeroLineas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumeroLineas.Location = New System.Drawing.Point(663, 379)
        Me.lblNumeroLineas.Name = "lblNumeroLineas"
        Me.lblNumeroLineas.Size = New System.Drawing.Size(2, 15)
        Me.lblNumeroLineas.TabIndex = 3
        '
        'frmListadoIVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblNumeroLineas)
        Me.Controls.Add(Me.lblTotalLineas)
        Me.Controls.Add(Me.dgvIVA)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmListadoIVA"
        Me.Text = "Listado IVA"
        CType(Me.dgvIVA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents dgvIVA As DataGridView
    Friend WithEvents lblTotalLineas As Label
    Friend WithEvents lblNumeroLineas As Label
End Class
