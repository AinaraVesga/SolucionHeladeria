<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNuevoPedido
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNuevoPedido = New System.Windows.Forms.Label()
        Me.lblIdPedido = New System.Windows.Forms.Label()
        Me.txtIdPedido = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.cbxCliente = New System.Windows.Forms.ComboBox()
        Me.lblIdCliente = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.cbxProducto = New System.Windows.Forms.ComboBox()
        Me.lblIdProducto = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.lblEnvase = New System.Windows.Forms.Label()
        Me.cbxEnvase = New System.Windows.Forms.ComboBox()
        Me.lblIdEnvase = New System.Windows.Forms.Label()
        Me.txtIdEnvase = New System.Windows.Forms.TextBox()
        Me.lblUniMax = New System.Windows.Forms.Label()
        Me.txtUniMax = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblUnidades = New System.Windows.Forms.Label()
        Me.numUnidades = New System.Windows.Forms.NumericUpDown()
        Me.lblBI = New System.Windows.Forms.Label()
        Me.txtBI = New System.Windows.Forms.TextBox()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.dgvLineas = New System.Windows.Forms.DataGridView()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.numUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.lblNuevoPedido)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1104, 68)
        Me.Panel1.TabIndex = 0
        '
        'lblNuevoPedido
        '
        Me.lblNuevoPedido.AutoSize = True
        Me.lblNuevoPedido.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNuevoPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoPedido.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNuevoPedido.Location = New System.Drawing.Point(70, 26)
        Me.lblNuevoPedido.Name = "lblNuevoPedido"
        Me.lblNuevoPedido.Size = New System.Drawing.Size(165, 24)
        Me.lblNuevoPedido.TabIndex = 3
        Me.lblNuevoPedido.Text = "NUEVO PEDIDO"
        '
        'lblIdPedido
        '
        Me.lblIdPedido.AutoSize = True
        Me.lblIdPedido.Location = New System.Drawing.Point(71, 95)
        Me.lblIdPedido.Name = "lblIdPedido"
        Me.lblIdPedido.Size = New System.Drawing.Size(70, 13)
        Me.lblIdPedido.TabIndex = 1
        Me.lblIdPedido.Text = "Nº de Pedido"
        '
        'txtIdPedido
        '
        Me.txtIdPedido.Enabled = False
        Me.txtIdPedido.Location = New System.Drawing.Point(74, 111)
        Me.txtIdPedido.Name = "txtIdPedido"
        Me.txtIdPedido.Size = New System.Drawing.Size(89, 20)
        Me.txtIdPedido.TabIndex = 2
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(71, 148)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Cliente"
        '
        'cbxCliente
        '
        Me.cbxCliente.FormattingEnabled = True
        Me.cbxCliente.Location = New System.Drawing.Point(74, 164)
        Me.cbxCliente.Name = "cbxCliente"
        Me.cbxCliente.Size = New System.Drawing.Size(161, 21)
        Me.cbxCliente.TabIndex = 4
        '
        'lblIdCliente
        '
        Me.lblIdCliente.AutoSize = True
        Me.lblIdCliente.Location = New System.Drawing.Point(241, 148)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.Size = New System.Drawing.Size(53, 13)
        Me.lblIdCliente.TabIndex = 5
        Me.lblIdCliente.Text = "ID Cliente"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Location = New System.Drawing.Point(244, 165)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCliente.TabIndex = 6
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(71, 204)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 7
        Me.lblProducto.Text = "Producto"
        '
        'cbxProducto
        '
        Me.cbxProducto.FormattingEnabled = True
        Me.cbxProducto.Location = New System.Drawing.Point(74, 220)
        Me.cbxProducto.Name = "cbxProducto"
        Me.cbxProducto.Size = New System.Drawing.Size(161, 21)
        Me.cbxProducto.TabIndex = 8
        '
        'lblIdProducto
        '
        Me.lblIdProducto.AutoSize = True
        Me.lblIdProducto.Location = New System.Drawing.Point(241, 204)
        Me.lblIdProducto.Name = "lblIdProducto"
        Me.lblIdProducto.Size = New System.Drawing.Size(64, 13)
        Me.lblIdProducto.TabIndex = 9
        Me.lblIdProducto.Text = "ID Producto"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Enabled = False
        Me.txtIdProducto.Location = New System.Drawing.Point(244, 221)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtIdProducto.TabIndex = 10
        '
        'lblEnvase
        '
        Me.lblEnvase.AutoSize = True
        Me.lblEnvase.Location = New System.Drawing.Point(71, 258)
        Me.lblEnvase.Name = "lblEnvase"
        Me.lblEnvase.Size = New System.Drawing.Size(58, 13)
        Me.lblEnvase.TabIndex = 11
        Me.lblEnvase.Text = "Envase (L)"
        '
        'cbxEnvase
        '
        Me.cbxEnvase.FormattingEnabled = True
        Me.cbxEnvase.Location = New System.Drawing.Point(74, 274)
        Me.cbxEnvase.Name = "cbxEnvase"
        Me.cbxEnvase.Size = New System.Drawing.Size(161, 21)
        Me.cbxEnvase.TabIndex = 12
        '
        'lblIdEnvase
        '
        Me.lblIdEnvase.AutoSize = True
        Me.lblIdEnvase.Location = New System.Drawing.Point(241, 258)
        Me.lblIdEnvase.Name = "lblIdEnvase"
        Me.lblIdEnvase.Size = New System.Drawing.Size(57, 13)
        Me.lblIdEnvase.TabIndex = 13
        Me.lblIdEnvase.Text = "ID Envase"
        '
        'txtIdEnvase
        '
        Me.txtIdEnvase.Enabled = False
        Me.txtIdEnvase.Location = New System.Drawing.Point(244, 275)
        Me.txtIdEnvase.Name = "txtIdEnvase"
        Me.txtIdEnvase.Size = New System.Drawing.Size(100, 20)
        Me.txtIdEnvase.TabIndex = 14
        '
        'lblUniMax
        '
        Me.lblUniMax.AutoSize = True
        Me.lblUniMax.Location = New System.Drawing.Point(71, 311)
        Me.lblUniMax.Name = "lblUniMax"
        Me.lblUniMax.Size = New System.Drawing.Size(107, 13)
        Me.lblUniMax.TabIndex = 15
        Me.lblUniMax.Text = "Unidades disponibles"
        '
        'txtUniMax
        '
        Me.txtUniMax.Enabled = False
        Me.txtUniMax.Location = New System.Drawing.Point(74, 327)
        Me.txtUniMax.Name = "txtUniMax"
        Me.txtUniMax.Size = New System.Drawing.Size(161, 20)
        Me.txtUniMax.TabIndex = 16
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(71, 365)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(107, 13)
        Me.lblPrecio.TabIndex = 19
        Me.lblPrecio.Text = "Precio por Unidad (€)"
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(74, 381)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(270, 20)
        Me.txtPrecio.TabIndex = 20
        '
        'lblUnidades
        '
        Me.lblUnidades.AutoSize = True
        Me.lblUnidades.Location = New System.Drawing.Point(241, 311)
        Me.lblUnidades.Name = "lblUnidades"
        Me.lblUnidades.Size = New System.Drawing.Size(52, 13)
        Me.lblUnidades.TabIndex = 21
        Me.lblUnidades.Text = "Unidades"
        '
        'numUnidades
        '
        Me.numUnidades.Location = New System.Drawing.Point(244, 327)
        Me.numUnidades.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numUnidades.Name = "numUnidades"
        Me.numUnidades.Size = New System.Drawing.Size(100, 20)
        Me.numUnidades.TabIndex = 22
        Me.numUnidades.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblBI
        '
        Me.lblBI.AutoSize = True
        Me.lblBI.Location = New System.Drawing.Point(71, 414)
        Me.lblBI.Name = "lblBI"
        Me.lblBI.Size = New System.Drawing.Size(94, 13)
        Me.lblBI.TabIndex = 23
        Me.lblBI.Text = "Base Imponible (€)"
        '
        'txtBI
        '
        Me.txtBI.Enabled = False
        Me.txtBI.Location = New System.Drawing.Point(74, 430)
        Me.txtBI.Name = "txtBI"
        Me.txtBI.Size = New System.Drawing.Size(270, 20)
        Me.txtBI.TabIndex = 24
        '
        'btnAnadir
        '
        Me.btnAnadir.Location = New System.Drawing.Point(172, 477)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(75, 23)
        Me.btnAnadir.TabIndex = 25
        Me.btnAnadir.Text = "Añadir"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'dgvLineas
        '
        Me.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLineas.Location = New System.Drawing.Point(393, 164)
        Me.dgvLineas.Name = "dgvLineas"
        Me.dgvLineas.Size = New System.Drawing.Size(675, 335)
        Me.dgvLineas.TabIndex = 26
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(545, 540)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 27
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(993, 135)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 28
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.Location = New System.Drawing.Point(393, 108)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(123, 23)
        Me.btnNuevoCliente.TabIndex = 29
        Me.btnNuevoCliente.Text = "NUEVO CLIENTE"
        Me.btnNuevoCliente.UseVisualStyleBackColor = True
        '
        'FormNuevoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 575)
        Me.Controls.Add(Me.btnNuevoCliente)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvLineas)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.txtBI)
        Me.Controls.Add(Me.lblBI)
        Me.Controls.Add(Me.numUnidades)
        Me.Controls.Add(Me.lblUnidades)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtUniMax)
        Me.Controls.Add(Me.lblUniMax)
        Me.Controls.Add(Me.txtIdEnvase)
        Me.Controls.Add(Me.lblIdEnvase)
        Me.Controls.Add(Me.cbxEnvase)
        Me.Controls.Add(Me.lblEnvase)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.lblIdProducto)
        Me.Controls.Add(Me.cbxProducto)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.lblIdCliente)
        Me.Controls.Add(Me.cbxCliente)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtIdPedido)
        Me.Controls.Add(Me.lblIdPedido)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormNuevoPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.numUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNuevoPedido As Label
    Friend WithEvents lblIdPedido As Label
    Friend WithEvents txtIdPedido As TextBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents cbxCliente As ComboBox
    Friend WithEvents lblIdCliente As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents lblProducto As Label
    Friend WithEvents cbxProducto As ComboBox
    Friend WithEvents lblIdProducto As Label
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents lblEnvase As Label
    Friend WithEvents cbxEnvase As ComboBox
    Friend WithEvents lblIdEnvase As Label
    Friend WithEvents txtIdEnvase As TextBox
    Friend WithEvents lblUniMax As Label
    Friend WithEvents txtUniMax As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblUnidades As Label
    Friend WithEvents numUnidades As NumericUpDown
    Friend WithEvents lblBI As Label
    Friend WithEvents txtBI As TextBox
    Friend WithEvents btnAnadir As Button
    Friend WithEvents dgvLineas As DataGridView
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnNuevoCliente As Button
End Class
