<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClientes
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
        Me.panMenu = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnEditarE = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.panClientes = New System.Windows.Forms.Panel()
        Me.panProductos = New System.Windows.Forms.Panel()
        Me.btnEditarP = New System.Windows.Forms.Button()
        Me.btnEliminarP = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnAñadirP = New System.Windows.Forms.Button()
        Me.txtBuscarP = New System.Windows.Forms.TextBox()
        Me.panContenedor = New System.Windows.Forms.Panel()
        Me.panMenu.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panClientes.SuspendLayout()
        Me.panProductos.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'panMenu
        '
        Me.panMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panMenu.Controls.Add(Me.lblTitulo)
        Me.panMenu.Controls.Add(Me.btnProductos)
        Me.panMenu.Controls.Add(Me.btnStock)
        Me.panMenu.Controls.Add(Me.btnVentas)
        Me.panMenu.Controls.Add(Me.btnClientes)
        Me.panMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panMenu.Location = New System.Drawing.Point(0, 0)
        Me.panMenu.Name = "panMenu"
        Me.panMenu.Size = New System.Drawing.Size(158, 450)
        Me.panMenu.TabIndex = 3
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitulo.Location = New System.Drawing.Point(30, 28)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(100, 24)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Heladería"
        '
        'btnProductos
        '
        Me.btnProductos.Location = New System.Drawing.Point(0, 256)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(158, 31)
        Me.btnProductos.TabIndex = 4
        Me.btnProductos.Text = "PRODUCTOS"
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnStock
        '
        Me.btnStock.Location = New System.Drawing.Point(0, 219)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(158, 31)
        Me.btnStock.TabIndex = 3
        Me.btnStock.Text = "STOCK"
        Me.btnStock.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.Location = New System.Drawing.Point(0, 182)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(158, 31)
        Me.btnVentas.TabIndex = 2
        Me.btnVentas.Text = "VENTAS"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(0, 145)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(158, 31)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "CLIENTES"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnEditarE
        '
        Me.btnEditarE.Location = New System.Drawing.Point(478, 51)
        Me.btnEditarE.Name = "btnEditarE"
        Me.btnEditarE.Size = New System.Drawing.Size(97, 23)
        Me.btnEditarE.TabIndex = 5
        Me.btnEditarE.Text = "Editar"
        Me.btnEditarE.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(375, 51)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 23)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvClientes.Location = New System.Drawing.Point(37, 80)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(538, 358)
        Me.dgvClientes.TabIndex = 3
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.Location = New System.Drawing.Point(478, 17)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(97, 23)
        Me.btnNuevoCliente.TabIndex = 2
        Me.btnNuevoCliente.Text = "Nuevo Cliente"
        Me.btnNuevoCliente.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(37, 53)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(225, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'panClientes
        '
        Me.panClientes.Controls.Add(Me.btnEditarE)
        Me.panClientes.Controls.Add(Me.btnEliminar)
        Me.panClientes.Controls.Add(Me.dgvClientes)
        Me.panClientes.Controls.Add(Me.btnNuevoCliente)
        Me.panClientes.Controls.Add(Me.txtBuscar)
        Me.panClientes.Location = New System.Drawing.Point(0, 3)
        Me.panClientes.Name = "panClientes"
        Me.panClientes.Size = New System.Drawing.Size(605, 447)
        Me.panClientes.TabIndex = 4
        '
        'panProductos
        '
        Me.panProductos.Controls.Add(Me.btnEditarP)
        Me.panProductos.Controls.Add(Me.btnEliminarP)
        Me.panProductos.Controls.Add(Me.dgvProductos)
        Me.panProductos.Controls.Add(Me.btnAñadirP)
        Me.panProductos.Controls.Add(Me.txtBuscarP)
        Me.panProductos.Location = New System.Drawing.Point(0, 3)
        Me.panProductos.Name = "panProductos"
        Me.panProductos.Size = New System.Drawing.Size(605, 447)
        Me.panProductos.TabIndex = 6
        '
        'btnEditarP
        '
        Me.btnEditarP.Location = New System.Drawing.Point(478, 51)
        Me.btnEditarP.Name = "btnEditarP"
        Me.btnEditarP.Size = New System.Drawing.Size(97, 23)
        Me.btnEditarP.TabIndex = 5
        Me.btnEditarP.Text = "Editar"
        Me.btnEditarP.UseVisualStyleBackColor = True
        '
        'btnEliminarP
        '
        Me.btnEliminarP.Location = New System.Drawing.Point(375, 51)
        Me.btnEliminarP.Name = "btnEliminarP"
        Me.btnEliminarP.Size = New System.Drawing.Size(97, 23)
        Me.btnEliminarP.TabIndex = 4
        Me.btnEliminarP.Text = "Eliminar"
        Me.btnEliminarP.UseVisualStyleBackColor = True
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToResizeColumns = False
        Me.dgvProductos.AllowUserToResizeRows = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvProductos.Location = New System.Drawing.Point(37, 80)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(538, 355)
        Me.dgvProductos.TabIndex = 3
        '
        'btnAñadirP
        '
        Me.btnAñadirP.Location = New System.Drawing.Point(478, 17)
        Me.btnAñadirP.Name = "btnAñadirP"
        Me.btnAñadirP.Size = New System.Drawing.Size(97, 23)
        Me.btnAñadirP.TabIndex = 2
        Me.btnAñadirP.Text = "Nuevo Producto"
        Me.btnAñadirP.UseVisualStyleBackColor = True
        '
        'txtBuscarP
        '
        Me.txtBuscarP.Location = New System.Drawing.Point(37, 53)
        Me.txtBuscarP.Name = "txtBuscarP"
        Me.txtBuscarP.Size = New System.Drawing.Size(225, 20)
        Me.txtBuscarP.TabIndex = 1
        '
        'panContenedor
        '
        Me.panContenedor.Controls.Add(Me.panProductos)
        Me.panContenedor.Controls.Add(Me.panClientes)
        Me.panContenedor.Location = New System.Drawing.Point(158, 0)
        Me.panContenedor.Name = "panContenedor"
        Me.panContenedor.Size = New System.Drawing.Size(607, 449)
        Me.panContenedor.TabIndex = 7
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 450)
        Me.Controls.Add(Me.panContenedor)
        Me.Controls.Add(Me.panMenu)
        Me.Name = "FormClientes"
        Me.Text = "FormClientes"
        Me.panMenu.ResumeLayout(False)
        Me.panMenu.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panClientes.ResumeLayout(False)
        Me.panClientes.PerformLayout()
        Me.panProductos.ResumeLayout(False)
        Me.panProductos.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panMenu As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnStock As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnEditarE As Button
    Friend WithEvents btnEliminar As Button
    Public WithEvents dgvClientes As DataGridView
    Friend WithEvents btnNuevoCliente As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents panClientes As Panel
    Friend WithEvents panProductos As Panel
    Friend WithEvents btnEditarP As Button
    Friend WithEvents btnEliminarP As Button
    Public WithEvents dgvProductos As DataGridView
    Friend WithEvents btnAñadirP As Button
    Friend WithEvents txtBuscarP As TextBox
    Friend WithEvents panContenedor As Panel
End Class
