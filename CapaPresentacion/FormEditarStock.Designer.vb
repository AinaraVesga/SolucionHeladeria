<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarStock
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblEditarStock = New System.Windows.Forms.Label()
        Me.lblIdProd = New System.Windows.Forms.Label()
        Me.txtIdProd = New System.Windows.Forms.TextBox()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.txtEnvase = New System.Windows.Forms.TextBox()
        Me.lblEnvase = New System.Windows.Forms.Label()
        Me.txtIdEnvase = New System.Windows.Forms.TextBox()
        Me.lblIdEnvase = New System.Windows.Forms.Label()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.lblUnidades = New System.Windows.Forms.Label()
        Me.numUnidades = New System.Windows.Forms.NumericUpDown()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.numUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.lblEditarStock)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(445, 71)
        Me.Panel1.TabIndex = 0
        '
        'lblEditarStock
        '
        Me.lblEditarStock.AutoSize = True
        Me.lblEditarStock.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEditarStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditarStock.ForeColor = System.Drawing.SystemColors.Control
        Me.lblEditarStock.Location = New System.Drawing.Point(54, 25)
        Me.lblEditarStock.Name = "lblEditarStock"
        Me.lblEditarStock.Size = New System.Drawing.Size(204, 24)
        Me.lblEditarStock.TabIndex = 3
        Me.lblEditarStock.Text = "EDITAR PRODUCTO"
        '
        'lblIdProd
        '
        Me.lblIdProd.AutoSize = True
        Me.lblIdProd.Location = New System.Drawing.Point(55, 110)
        Me.lblIdProd.Name = "lblIdProd"
        Me.lblIdProd.Size = New System.Drawing.Size(67, 13)
        Me.lblIdProd.TabIndex = 1
        Me.lblIdProd.Text = "ID Producto:"
        '
        'txtIdProd
        '
        Me.txtIdProd.Enabled = False
        Me.txtIdProd.Location = New System.Drawing.Point(58, 126)
        Me.txtIdProd.Name = "txtIdProd"
        Me.txtIdProd.Size = New System.Drawing.Size(118, 20)
        Me.txtIdProd.TabIndex = 2
        '
        'lblProd
        '
        Me.lblProd.AutoSize = True
        Me.lblProd.Location = New System.Drawing.Point(207, 110)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(53, 13)
        Me.lblProd.TabIndex = 3
        Me.lblProd.Text = "Producto:"
        '
        'txtProd
        '
        Me.txtProd.Enabled = False
        Me.txtProd.Location = New System.Drawing.Point(210, 126)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Size = New System.Drawing.Size(176, 20)
        Me.txtProd.TabIndex = 4
        '
        'txtEnvase
        '
        Me.txtEnvase.Enabled = False
        Me.txtEnvase.Location = New System.Drawing.Point(210, 186)
        Me.txtEnvase.Name = "txtEnvase"
        Me.txtEnvase.Size = New System.Drawing.Size(176, 20)
        Me.txtEnvase.TabIndex = 8
        '
        'lblEnvase
        '
        Me.lblEnvase.AutoSize = True
        Me.lblEnvase.Location = New System.Drawing.Point(207, 170)
        Me.lblEnvase.Name = "lblEnvase"
        Me.lblEnvase.Size = New System.Drawing.Size(61, 13)
        Me.lblEnvase.TabIndex = 7
        Me.lblEnvase.Text = "Envase (L):"
        '
        'txtIdEnvase
        '
        Me.txtIdEnvase.Enabled = False
        Me.txtIdEnvase.Location = New System.Drawing.Point(58, 186)
        Me.txtIdEnvase.Name = "txtIdEnvase"
        Me.txtIdEnvase.Size = New System.Drawing.Size(118, 20)
        Me.txtIdEnvase.TabIndex = 6
        '
        'lblIdEnvase
        '
        Me.lblIdEnvase.AutoSize = True
        Me.lblIdEnvase.Location = New System.Drawing.Point(55, 170)
        Me.lblIdEnvase.Name = "lblIdEnvase"
        Me.lblIdEnvase.Size = New System.Drawing.Size(60, 13)
        Me.lblIdEnvase.TabIndex = 5
        Me.lblIdEnvase.Text = "ID Envase:"
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.Location = New System.Drawing.Point(55, 230)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(61, 13)
        Me.lblLote.TabIndex = 9
        Me.lblLote.Text = "Nº de Lote:"
        '
        'txtLote
        '
        Me.txtLote.Enabled = False
        Me.txtLote.Location = New System.Drawing.Point(58, 246)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(328, 20)
        Me.txtLote.TabIndex = 10
        '
        'lblUnidades
        '
        Me.lblUnidades.AutoSize = True
        Me.lblUnidades.Location = New System.Drawing.Point(55, 286)
        Me.lblUnidades.Name = "lblUnidades"
        Me.lblUnidades.Size = New System.Drawing.Size(55, 13)
        Me.lblUnidades.TabIndex = 11
        Me.lblUnidades.Text = "Unidades:"
        '
        'numUnidades
        '
        Me.numUnidades.Location = New System.Drawing.Point(58, 302)
        Me.numUnidades.Name = "numUnidades"
        Me.numUnidades.Size = New System.Drawing.Size(118, 20)
        Me.numUnidades.TabIndex = 12
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(210, 302)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(176, 20)
        Me.txtPrecio.TabIndex = 14
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(207, 286)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(55, 13)
        Me.lblPrecio.TabIndex = 13
        Me.lblPrecio.Text = "Precio (€):"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(180, 363)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'FormEditarStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 404)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.numUnidades)
        Me.Controls.Add(Me.lblUnidades)
        Me.Controls.Add(Me.txtLote)
        Me.Controls.Add(Me.lblLote)
        Me.Controls.Add(Me.txtEnvase)
        Me.Controls.Add(Me.lblEnvase)
        Me.Controls.Add(Me.txtIdEnvase)
        Me.Controls.Add(Me.lblIdEnvase)
        Me.Controls.Add(Me.txtProd)
        Me.Controls.Add(Me.lblProd)
        Me.Controls.Add(Me.txtIdProd)
        Me.Controls.Add(Me.lblIdProd)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormEditarStock"
        Me.Text = "FormEditarStock"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.numUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblEditarStock As Label
    Friend WithEvents lblIdProd As Label
    Friend WithEvents txtIdProd As TextBox
    Friend WithEvents lblProd As Label
    Friend WithEvents txtProd As TextBox
    Friend WithEvents txtEnvase As TextBox
    Friend WithEvents lblEnvase As Label
    Friend WithEvents txtIdEnvase As TextBox
    Friend WithEvents lblIdEnvase As Label
    Friend WithEvents lblLote As Label
    Friend WithEvents txtLote As TextBox
    Friend WithEvents lblUnidades As Label
    Friend WithEvents numUnidades As NumericUpDown
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents btnAceptar As Button
End Class
