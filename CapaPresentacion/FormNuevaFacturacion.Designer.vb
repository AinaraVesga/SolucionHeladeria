<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevaFacturacion
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
        Me.panTitulo = New System.Windows.Forms.Panel()
        Me.lblNuevaFacturacion = New System.Windows.Forms.Label()
        Me.txtIdent = New System.Windows.Forms.TextBox()
        Me.lblIdent = New System.Windows.Forms.Label()
        Me.txtFrecuencia = New System.Windows.Forms.TextBox()
        Me.lblFrecuencia = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.panTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'panTitulo
        '
        Me.panTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panTitulo.Controls.Add(Me.lblNuevaFacturacion)
        Me.panTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panTitulo.Name = "panTitulo"
        Me.panTitulo.Size = New System.Drawing.Size(389, 59)
        Me.panTitulo.TabIndex = 0
        '
        'lblNuevaFacturacion
        '
        Me.lblNuevaFacturacion.AutoSize = True
        Me.lblNuevaFacturacion.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNuevaFacturacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevaFacturacion.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNuevaFacturacion.Location = New System.Drawing.Point(39, 18)
        Me.lblNuevaFacturacion.Name = "lblNuevaFacturacion"
        Me.lblNuevaFacturacion.Size = New System.Drawing.Size(233, 24)
        Me.lblNuevaFacturacion.TabIndex = 2
        Me.lblNuevaFacturacion.Text = "NUEVA FACTURACION"
        '
        'txtIdent
        '
        Me.txtIdent.Enabled = False
        Me.txtIdent.Location = New System.Drawing.Point(28, 112)
        Me.txtIdent.Name = "txtIdent"
        Me.txtIdent.Size = New System.Drawing.Size(336, 20)
        Me.txtIdent.TabIndex = 6
        '
        'lblIdent
        '
        Me.lblIdent.AutoSize = True
        Me.lblIdent.Location = New System.Drawing.Point(25, 96)
        Me.lblIdent.Name = "lblIdent"
        Me.lblIdent.Size = New System.Drawing.Size(68, 13)
        Me.lblIdent.TabIndex = 5
        Me.lblIdent.Text = "Identificador:"
        '
        'txtFrecuencia
        '
        Me.txtFrecuencia.Location = New System.Drawing.Point(28, 165)
        Me.txtFrecuencia.Name = "txtFrecuencia"
        Me.txtFrecuencia.Size = New System.Drawing.Size(336, 20)
        Me.txtFrecuencia.TabIndex = 8
        '
        'lblFrecuencia
        '
        Me.lblFrecuencia.AutoSize = True
        Me.lblFrecuencia.Location = New System.Drawing.Point(25, 149)
        Me.lblFrecuencia.Name = "lblFrecuencia"
        Me.lblFrecuencia.Size = New System.Drawing.Size(63, 13)
        Me.lblFrecuencia.TabIndex = 7
        Me.lblFrecuencia.Text = "Frecuencia:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(149, 226)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'FormNuevaFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 283)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtFrecuencia)
        Me.Controls.Add(Me.lblFrecuencia)
        Me.Controls.Add(Me.txtIdent)
        Me.Controls.Add(Me.lblIdent)
        Me.Controls.Add(Me.panTitulo)
        Me.Name = "FormNuevaFacturacion"
        Me.Text = "FormNuevaFacturacion"
        Me.panTitulo.ResumeLayout(False)
        Me.panTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panTitulo As Panel
    Friend WithEvents lblNuevaFacturacion As Label
    Friend WithEvents txtIdent As TextBox
    Friend WithEvents lblIdent As Label
    Friend WithEvents txtFrecuencia As TextBox
    Friend WithEvents lblFrecuencia As Label
    Friend WithEvents btnAceptar As Button
End Class
