﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.panVentas = New System.Windows.Forms.Panel()
        Me.btnVerV = New System.Windows.Forms.Button()
        Me.btnEliminarV = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.btnNuevaV = New System.Windows.Forms.Button()
        Me.txtBuscarV = New System.Windows.Forms.TextBox()
        Me.panStock = New System.Windows.Forms.Panel()
        Me.btnEditarS = New System.Windows.Forms.Button()
        Me.btnEliminarS = New System.Windows.Forms.Button()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.btnNuevoS = New System.Windows.Forms.Button()
        Me.txtBuscarS = New System.Windows.Forms.TextBox()
        Me.panMenu.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panClientes.SuspendLayout()
        Me.panProductos.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panContenedor.SuspendLayout()
        Me.panVentas.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panStock.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panContenedor.Controls.Add(Me.panVentas)
        Me.panContenedor.Controls.Add(Me.panStock)
        Me.panContenedor.Controls.Add(Me.panProductos)
        Me.panContenedor.Controls.Add(Me.panClientes)
        Me.panContenedor.Location = New System.Drawing.Point(158, 0)
        Me.panContenedor.Name = "panContenedor"
        Me.panContenedor.Size = New System.Drawing.Size(607, 449)
        Me.panContenedor.TabIndex = 7
        '
        'panVentas
        '
        Me.panVentas.Controls.Add(Me.btnVerV)
        Me.panVentas.Controls.Add(Me.btnEliminarV)
        Me.panVentas.Controls.Add(Me.dgvVentas)
        Me.panVentas.Controls.Add(Me.btnNuevaV)
        Me.panVentas.Controls.Add(Me.txtBuscarV)
        Me.panVentas.Location = New System.Drawing.Point(1, 1)
        Me.panVentas.Name = "panVentas"
        Me.panVentas.Size = New System.Drawing.Size(605, 447)
        Me.panVentas.TabIndex = 8
        '
        'btnVerV
        '
        Me.btnVerV.Location = New System.Drawing.Point(478, 51)
        Me.btnVerV.Name = "btnVerV"
        Me.btnVerV.Size = New System.Drawing.Size(97, 23)
        Me.btnVerV.TabIndex = 5
        Me.btnVerV.Text = "Ver"
        Me.btnVerV.UseVisualStyleBackColor = True
        '
        'btnEliminarV
        '
        Me.btnEliminarV.Location = New System.Drawing.Point(375, 51)
        Me.btnEliminarV.Name = "btnEliminarV"
        Me.btnEliminarV.Size = New System.Drawing.Size(97, 23)
        Me.btnEliminarV.TabIndex = 4
        Me.btnEliminarV.Text = "Eliminar"
        Me.btnEliminarV.UseVisualStyleBackColor = True
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.AllowUserToResizeColumns = False
        Me.dgvVentas.AllowUserToResizeRows = False
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvVentas.Location = New System.Drawing.Point(37, 80)
        Me.dgvVentas.MultiSelect = False
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(538, 358)
        Me.dgvVentas.TabIndex = 3
        '
        'btnNuevaV
        '
        Me.btnNuevaV.Location = New System.Drawing.Point(478, 17)
        Me.btnNuevaV.Name = "btnNuevaV"
        Me.btnNuevaV.Size = New System.Drawing.Size(97, 23)
        Me.btnNuevaV.TabIndex = 2
        Me.btnNuevaV.Text = "Nueva Venta"
        Me.btnNuevaV.UseVisualStyleBackColor = True
        '
        'txtBuscarV
        '
        Me.txtBuscarV.Location = New System.Drawing.Point(37, 53)
        Me.txtBuscarV.Name = "txtBuscarV"
        Me.txtBuscarV.Size = New System.Drawing.Size(225, 20)
        Me.txtBuscarV.TabIndex = 1
        '
        'panStock
        '
        Me.panStock.Controls.Add(Me.btnEditarS)
        Me.panStock.Controls.Add(Me.btnEliminarS)
        Me.panStock.Controls.Add(Me.dgvStock)
        Me.panStock.Controls.Add(Me.btnNuevoS)
        Me.panStock.Controls.Add(Me.txtBuscarS)
        Me.panStock.Location = New System.Drawing.Point(0, 3)
        Me.panStock.Name = "panStock"
        Me.panStock.Size = New System.Drawing.Size(605, 447)
        Me.panStock.TabIndex = 7
        '
        'btnEditarS
        '
        Me.btnEditarS.Location = New System.Drawing.Point(478, 51)
        Me.btnEditarS.Name = "btnEditarS"
        Me.btnEditarS.Size = New System.Drawing.Size(97, 23)
        Me.btnEditarS.TabIndex = 5
        Me.btnEditarS.Text = "Editar"
        Me.btnEditarS.UseVisualStyleBackColor = True
        '
        'btnEliminarS
        '
        Me.btnEliminarS.Location = New System.Drawing.Point(375, 51)
        Me.btnEliminarS.Name = "btnEliminarS"
        Me.btnEliminarS.Size = New System.Drawing.Size(97, 23)
        Me.btnEliminarS.TabIndex = 4
        Me.btnEliminarS.Text = "Eliminar"
        Me.btnEliminarS.UseVisualStyleBackColor = True
        '
        'dgvStock
        '
        Me.dgvStock.AllowUserToAddRows = False
        Me.dgvStock.AllowUserToDeleteRows = False
        Me.dgvStock.AllowUserToResizeColumns = False
        Me.dgvStock.AllowUserToResizeRows = False
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvStock.Location = New System.Drawing.Point(37, 80)
        Me.dgvStock.MultiSelect = False
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.Size = New System.Drawing.Size(538, 358)
        Me.dgvStock.TabIndex = 3
        '
        'btnNuevoS
        '
        Me.btnNuevoS.Location = New System.Drawing.Point(478, 17)
        Me.btnNuevoS.Name = "btnNuevoS"
        Me.btnNuevoS.Size = New System.Drawing.Size(97, 23)
        Me.btnNuevoS.TabIndex = 2
        Me.btnNuevoS.Text = "Añadir a Stock"
        Me.btnNuevoS.UseVisualStyleBackColor = True
        '
        'txtBuscarS
        '
        Me.txtBuscarS.Location = New System.Drawing.Point(37, 53)
        Me.txtBuscarS.Name = "txtBuscarS"
        Me.txtBuscarS.Size = New System.Drawing.Size(225, 20)
        Me.txtBuscarS.TabIndex = 1
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 450)
        Me.Controls.Add(Me.panMenu)
        Me.Controls.Add(Me.panContenedor)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
        Me.panVentas.ResumeLayout(False)
        Me.panVentas.PerformLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panStock.ResumeLayout(False)
        Me.panStock.PerformLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents panStock As Panel
    Friend WithEvents btnEditarS As Button
    Friend WithEvents btnEliminarS As Button
    Public WithEvents dgvStock As DataGridView
    Friend WithEvents btnNuevoS As Button
    Friend WithEvents txtBuscarS As TextBox
    Friend WithEvents panVentas As Panel
    Friend WithEvents btnVerV As Button
    Friend WithEvents btnEliminarV As Button
    Public WithEvents dgvVentas As DataGridView
    Friend WithEvents btnNuevaV As Button
    Friend WithEvents txtBuscarV As TextBox
End Class
