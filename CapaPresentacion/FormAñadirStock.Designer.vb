<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAñadirStock
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
        Me.lblAnadirStock = New System.Windows.Forms.Label()
        Me.panBody1 = New System.Windows.Forms.Panel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.cbxProducto = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.panBody2 = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lblUnidades = New System.Windows.Forms.Label()
        Me.cbxEnvase = New System.Windows.Forms.ComboBox()
        Me.lblEnvase = New System.Windows.Forms.Label()
        Me.txtLote2 = New System.Windows.Forms.TextBox()
        Me.lblLote2 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.lblProducto2 = New System.Windows.Forms.Label()
        Me.btnAñadir2 = New System.Windows.Forms.Button()
        Me.dgvNuevoStock = New System.Windows.Forms.DataGridView()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblID2 = New System.Windows.Forms.Label()
        Me.txtID2 = New System.Windows.Forms.TextBox()
        Me.panTitulo.SuspendLayout()
        Me.panBody1.SuspendLayout()
        Me.panBody2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNuevoStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panTitulo
        '
        Me.panTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panTitulo.Controls.Add(Me.lblAnadirStock)
        Me.panTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panTitulo.Name = "panTitulo"
        Me.panTitulo.Size = New System.Drawing.Size(360, 56)
        Me.panTitulo.TabIndex = 0
        '
        'lblAnadirStock
        '
        Me.lblAnadirStock.AutoSize = True
        Me.lblAnadirStock.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblAnadirStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnadirStock.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAnadirStock.Location = New System.Drawing.Point(48, 16)
        Me.lblAnadirStock.Name = "lblAnadirStock"
        Me.lblAnadirStock.Size = New System.Drawing.Size(161, 24)
        Me.lblAnadirStock.TabIndex = 2
        Me.lblAnadirStock.Text = "AÑADIR STOCK"
        '
        'panBody1
        '
        Me.panBody1.Controls.Add(Me.lblID)
        Me.panBody1.Controls.Add(Me.txtID)
        Me.panBody1.Controls.Add(Me.btnAñadir)
        Me.panBody1.Controls.Add(Me.txtLote)
        Me.panBody1.Controls.Add(Me.lblLote)
        Me.panBody1.Controls.Add(Me.cbxProducto)
        Me.panBody1.Controls.Add(Me.lblProducto)
        Me.panBody1.Location = New System.Drawing.Point(0, 63)
        Me.panBody1.Name = "panBody1"
        Me.panBody1.Size = New System.Drawing.Size(365, 208)
        Me.panBody1.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(242, 29)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 6
        Me.lblID.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(244, 45)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(72, 20)
        Me.txtID.TabIndex = 2
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(145, 164)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(75, 23)
        Me.btnAñadir.TabIndex = 4
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'txtLote
        '
        Me.txtLote.Enabled = False
        Me.txtLote.Location = New System.Drawing.Point(52, 103)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(264, 20)
        Me.txtLote.TabIndex = 3
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.Location = New System.Drawing.Point(49, 87)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(61, 13)
        Me.lblLote.TabIndex = 2
        Me.lblLote.Text = "Nº de Lote:"
        '
        'cbxProducto
        '
        Me.cbxProducto.FormattingEnabled = True
        Me.cbxProducto.Location = New System.Drawing.Point(52, 45)
        Me.cbxProducto.Name = "cbxProducto"
        Me.cbxProducto.Size = New System.Drawing.Size(186, 21)
        Me.cbxProducto.TabIndex = 1
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(49, 29)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(53, 13)
        Me.lblProducto.TabIndex = 0
        Me.lblProducto.Text = "Producto:"
        '
        'panBody2
        '
        Me.panBody2.Controls.Add(Me.txtID2)
        Me.panBody2.Controls.Add(Me.lblID2)
        Me.panBody2.Controls.Add(Me.btnAceptar)
        Me.panBody2.Controls.Add(Me.dgvNuevoStock)
        Me.panBody2.Controls.Add(Me.btnAñadir2)
        Me.panBody2.Controls.Add(Me.NumericUpDown1)
        Me.panBody2.Controls.Add(Me.lblUnidades)
        Me.panBody2.Controls.Add(Me.cbxEnvase)
        Me.panBody2.Controls.Add(Me.lblEnvase)
        Me.panBody2.Controls.Add(Me.txtLote2)
        Me.panBody2.Controls.Add(Me.lblLote2)
        Me.panBody2.Controls.Add(Me.txtProducto)
        Me.panBody2.Controls.Add(Me.lblProducto2)
        Me.panBody2.Location = New System.Drawing.Point(0, 63)
        Me.panBody2.Name = "panBody2"
        Me.panBody2.Size = New System.Drawing.Size(792, 385)
        Me.panBody2.TabIndex = 2
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(196, 209)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 7
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblUnidades
        '
        Me.lblUnidades.AutoSize = True
        Me.lblUnidades.Location = New System.Drawing.Point(49, 211)
        Me.lblUnidades.Name = "lblUnidades"
        Me.lblUnidades.Size = New System.Drawing.Size(55, 13)
        Me.lblUnidades.TabIndex = 6
        Me.lblUnidades.Text = "Unidades:"
        '
        'cbxEnvase
        '
        Me.cbxEnvase.FormattingEnabled = True
        Me.cbxEnvase.Location = New System.Drawing.Point(52, 164)
        Me.cbxEnvase.Name = "cbxEnvase"
        Me.cbxEnvase.Size = New System.Drawing.Size(264, 21)
        Me.cbxEnvase.TabIndex = 5
        '
        'lblEnvase
        '
        Me.lblEnvase.AutoSize = True
        Me.lblEnvase.Location = New System.Drawing.Point(49, 148)
        Me.lblEnvase.Name = "lblEnvase"
        Me.lblEnvase.Size = New System.Drawing.Size(46, 13)
        Me.lblEnvase.TabIndex = 4
        Me.lblEnvase.Text = "Envase:"
        '
        'txtLote2
        '
        Me.txtLote2.Enabled = False
        Me.txtLote2.Location = New System.Drawing.Point(52, 103)
        Me.txtLote2.Name = "txtLote2"
        Me.txtLote2.Size = New System.Drawing.Size(264, 20)
        Me.txtLote2.TabIndex = 3
        '
        'lblLote2
        '
        Me.lblLote2.AutoSize = True
        Me.lblLote2.Location = New System.Drawing.Point(49, 87)
        Me.lblLote2.Name = "lblLote2"
        Me.lblLote2.Size = New System.Drawing.Size(61, 13)
        Me.lblLote2.TabIndex = 2
        Me.lblLote2.Text = "Nº de Lote:"
        '
        'txtProducto
        '
        Me.txtProducto.Enabled = False
        Me.txtProducto.Location = New System.Drawing.Point(52, 45)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(186, 20)
        Me.txtProducto.TabIndex = 1
        '
        'lblProducto2
        '
        Me.lblProducto2.AutoSize = True
        Me.lblProducto2.Location = New System.Drawing.Point(49, 29)
        Me.lblProducto2.Name = "lblProducto2"
        Me.lblProducto2.Size = New System.Drawing.Size(53, 13)
        Me.lblProducto2.TabIndex = 0
        Me.lblProducto2.Text = "Producto:"
        '
        'btnAñadir2
        '
        Me.btnAñadir2.Location = New System.Drawing.Point(134, 258)
        Me.btnAñadir2.Name = "btnAñadir2"
        Me.btnAñadir2.Size = New System.Drawing.Size(75, 23)
        Me.btnAñadir2.TabIndex = 8
        Me.btnAñadir2.Text = "Añadir"
        Me.btnAñadir2.UseVisualStyleBackColor = True
        '
        'dgvNuevoStock
        '
        Me.dgvNuevoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNuevoStock.Location = New System.Drawing.Point(379, 19)
        Me.dgvNuevoStock.Name = "dgvNuevoStock"
        Me.dgvNuevoStock.Size = New System.Drawing.Size(383, 261)
        Me.dgvNuevoStock.TabIndex = 9
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(355, 345)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblID2
        '
        Me.lblID2.AutoSize = True
        Me.lblID2.Location = New System.Drawing.Point(251, 29)
        Me.lblID2.Name = "lblID2"
        Me.lblID2.Size = New System.Drawing.Size(21, 13)
        Me.lblID2.TabIndex = 11
        Me.lblID2.Text = "ID:"
        '
        'txtID2
        '
        Me.txtID2.Enabled = False
        Me.txtID2.Location = New System.Drawing.Point(254, 45)
        Me.txtID2.Name = "txtID2"
        Me.txtID2.Size = New System.Drawing.Size(62, 20)
        Me.txtID2.TabIndex = 12
        '
        'FormAñadirStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 268)
        Me.Controls.Add(Me.panBody2)
        Me.Controls.Add(Me.panBody1)
        Me.Controls.Add(Me.panTitulo)
        Me.Name = "FormAñadirStock"
        Me.Text = "AñadirStock"
        Me.panTitulo.ResumeLayout(False)
        Me.panTitulo.PerformLayout()
        Me.panBody1.ResumeLayout(False)
        Me.panBody1.PerformLayout()
        Me.panBody2.ResumeLayout(False)
        Me.panBody2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNuevoStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panTitulo As Panel
    Friend WithEvents lblAnadirStock As Label
    Friend WithEvents panBody1 As Panel
    Friend WithEvents btnAñadir As Button
    Friend WithEvents txtLote As TextBox
    Friend WithEvents lblLote As Label
    Friend WithEvents cbxProducto As ComboBox
    Friend WithEvents lblProducto As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents panBody2 As Panel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lblUnidades As Label
    Friend WithEvents cbxEnvase As ComboBox
    Friend WithEvents lblEnvase As Label
    Friend WithEvents txtLote2 As TextBox
    Friend WithEvents lblLote2 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents lblProducto2 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents dgvNuevoStock As DataGridView
    Friend WithEvents btnAñadir2 As Button
    Friend WithEvents txtID2 As TextBox
    Friend WithEvents lblID2 As Label
End Class
