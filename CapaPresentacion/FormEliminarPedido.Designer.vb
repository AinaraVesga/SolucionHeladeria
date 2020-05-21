<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEliminarPedido
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
        Me.lblEliminarPedido = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblIDPedido = New System.Windows.Forms.Label()
        Me.txtIDPedido = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.lblBI = New System.Windows.Forms.Label()
        Me.txtBI = New System.Windows.Forms.TextBox()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.lblRE = New System.Windows.Forms.Label()
        Me.txtRE = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.dgvLineas = New System.Windows.Forms.DataGridView()
        Me.lblLineas = New System.Windows.Forms.Label()
        Me.btnSi = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.lblEliminarPedido)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 60)
        Me.Panel1.TabIndex = 0
        '
        'lblEliminarPedido
        '
        Me.lblEliminarPedido.AutoSize = True
        Me.lblEliminarPedido.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEliminarPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEliminarPedido.ForeColor = System.Drawing.SystemColors.Control
        Me.lblEliminarPedido.Location = New System.Drawing.Point(57, 18)
        Me.lblEliminarPedido.Name = "lblEliminarPedido"
        Me.lblEliminarPedido.Size = New System.Drawing.Size(187, 24)
        Me.lblEliminarPedido.TabIndex = 3
        Me.lblEliminarPedido.Text = "ELIMINAR PEDIDO"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(58, 88)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(230, 18)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "¿Desea eliminar este pedido?"
        '
        'lblIDPedido
        '
        Me.lblIDPedido.AutoSize = True
        Me.lblIDPedido.Location = New System.Drawing.Point(58, 126)
        Me.lblIDPedido.Name = "lblIDPedido"
        Me.lblIDPedido.Size = New System.Drawing.Size(57, 13)
        Me.lblIDPedido.TabIndex = 5
        Me.lblIDPedido.Text = "ID Pedido:"
        '
        'txtIDPedido
        '
        Me.txtIDPedido.Location = New System.Drawing.Point(61, 142)
        Me.txtIDPedido.Name = "txtIDPedido"
        Me.txtIDPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtIDPedido.TabIndex = 6
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(58, 174)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 13)
        Me.lblCliente.TabIndex = 7
        Me.lblCliente.Text = "Cliente:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(61, 190)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(227, 20)
        Me.txtCliente.TabIndex = 8
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(173, 126)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "Fecha:"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(176, 142)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(112, 20)
        Me.txtFecha.TabIndex = 10
        '
        'lblBI
        '
        Me.lblBI.AutoSize = True
        Me.lblBI.Location = New System.Drawing.Point(58, 222)
        Me.lblBI.Name = "lblBI"
        Me.lblBI.Size = New System.Drawing.Size(82, 13)
        Me.lblBI.TabIndex = 11
        Me.lblBI.Text = "Base Imponible:"
        '
        'txtBI
        '
        Me.txtBI.Location = New System.Drawing.Point(61, 238)
        Me.txtBI.Name = "txtBI"
        Me.txtBI.Size = New System.Drawing.Size(227, 20)
        Me.txtBI.TabIndex = 12
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Location = New System.Drawing.Point(58, 271)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(27, 13)
        Me.lblIVA.TabIndex = 13
        Me.lblIVA.Text = "IVA:"
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(61, 287)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(227, 20)
        Me.txtIVA.TabIndex = 14
        '
        'lblRE
        '
        Me.lblRE.AutoSize = True
        Me.lblRE.Location = New System.Drawing.Point(58, 324)
        Me.lblRE.Name = "lblRE"
        Me.lblRE.Size = New System.Drawing.Size(130, 13)
        Me.lblRE.TabIndex = 15
        Me.lblRE.Text = "Recargo de Equivalencia:"
        '
        'txtRE
        '
        Me.txtRE.Location = New System.Drawing.Point(61, 340)
        Me.txtRE.Name = "txtRE"
        Me.txtRE.Size = New System.Drawing.Size(227, 20)
        Me.txtRE.TabIndex = 16
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(58, 373)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(61, 389)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(227, 20)
        Me.txtTotal.TabIndex = 18
        '
        'dgvLineas
        '
        Me.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLineas.Location = New System.Drawing.Point(336, 142)
        Me.dgvLineas.Name = "dgvLineas"
        Me.dgvLineas.Size = New System.Drawing.Size(442, 267)
        Me.dgvLineas.TabIndex = 19
        '
        'lblLineas
        '
        Me.lblLineas.AutoSize = True
        Me.lblLineas.Location = New System.Drawing.Point(333, 126)
        Me.lblLineas.Name = "lblLineas"
        Me.lblLineas.Size = New System.Drawing.Size(43, 13)
        Me.lblLineas.TabIndex = 20
        Me.lblLineas.Text = "Líneas:"
        '
        'btnSi
        '
        Me.btnSi.Location = New System.Drawing.Point(312, 463)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(75, 23)
        Me.btnSi.TabIndex = 21
        Me.btnSi.Text = "Si"
        Me.btnSi.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(393, 463)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 23)
        Me.btnNo.TabIndex = 22
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'FormEliminarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 517)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnSi)
        Me.Controls.Add(Me.lblLineas)
        Me.Controls.Add(Me.dgvLineas)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtRE)
        Me.Controls.Add(Me.lblRE)
        Me.Controls.Add(Me.txtIVA)
        Me.Controls.Add(Me.lblIVA)
        Me.Controls.Add(Me.txtBI)
        Me.Controls.Add(Me.lblBI)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtIDPedido)
        Me.Controls.Add(Me.lblIDPedido)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormEliminarPedido"
        Me.Text = "FormEliminarPedido"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblEliminarPedido As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblIDPedido As Label
    Friend WithEvents txtIDPedido As TextBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents lblBI As Label
    Friend WithEvents txtBI As TextBox
    Friend WithEvents lblIVA As Label
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents lblRE As Label
    Friend WithEvents txtRE As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents dgvLineas As DataGridView
    Friend WithEvents lblLineas As Label
    Friend WithEvents btnSi As Button
    Friend WithEvents btnNo As Button
End Class
