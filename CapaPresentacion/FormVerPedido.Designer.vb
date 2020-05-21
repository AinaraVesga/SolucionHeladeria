<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVerPedido
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
        Me.lblLineas = New System.Windows.Forms.Label()
        Me.dgvLineas = New System.Windows.Forms.DataGridView()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtRE = New System.Windows.Forms.TextBox()
        Me.lblRE = New System.Windows.Forms.Label()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.txtBI = New System.Windows.Forms.TextBox()
        Me.lblBI = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtIDPedido = New System.Windows.Forms.TextBox()
        Me.lblIDPedido = New System.Windows.Forms.Label()
        Me.lblVerPedido = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAceptar = New System.Windows.Forms.Button()
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLineas
        '
        Me.lblLineas.AutoSize = True
        Me.lblLineas.Location = New System.Drawing.Point(333, 100)
        Me.lblLineas.Name = "lblLineas"
        Me.lblLineas.Size = New System.Drawing.Size(43, 13)
        Me.lblLineas.TabIndex = 38
        Me.lblLineas.Text = "Líneas:"
        '
        'dgvLineas
        '
        Me.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLineas.Location = New System.Drawing.Point(336, 116)
        Me.dgvLineas.Name = "dgvLineas"
        Me.dgvLineas.Size = New System.Drawing.Size(442, 267)
        Me.dgvLineas.TabIndex = 37
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(61, 363)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(227, 20)
        Me.txtTotal.TabIndex = 36
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(58, 347)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 35
        Me.lblTotal.Text = "Total:"
        '
        'txtRE
        '
        Me.txtRE.Location = New System.Drawing.Point(61, 314)
        Me.txtRE.Name = "txtRE"
        Me.txtRE.Size = New System.Drawing.Size(227, 20)
        Me.txtRE.TabIndex = 34
        '
        'lblRE
        '
        Me.lblRE.AutoSize = True
        Me.lblRE.Location = New System.Drawing.Point(58, 298)
        Me.lblRE.Name = "lblRE"
        Me.lblRE.Size = New System.Drawing.Size(130, 13)
        Me.lblRE.TabIndex = 33
        Me.lblRE.Text = "Recargo de Equivalencia:"
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(61, 261)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(227, 20)
        Me.txtIVA.TabIndex = 32
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Location = New System.Drawing.Point(58, 245)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(27, 13)
        Me.lblIVA.TabIndex = 31
        Me.lblIVA.Text = "IVA:"
        '
        'txtBI
        '
        Me.txtBI.Location = New System.Drawing.Point(61, 212)
        Me.txtBI.Name = "txtBI"
        Me.txtBI.Size = New System.Drawing.Size(227, 20)
        Me.txtBI.TabIndex = 30
        '
        'lblBI
        '
        Me.lblBI.AutoSize = True
        Me.lblBI.Location = New System.Drawing.Point(58, 196)
        Me.lblBI.Name = "lblBI"
        Me.lblBI.Size = New System.Drawing.Size(82, 13)
        Me.lblBI.TabIndex = 29
        Me.lblBI.Text = "Base Imponible:"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(176, 116)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(112, 20)
        Me.txtFecha.TabIndex = 28
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(173, 100)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 27
        Me.lblFecha.Text = "Fecha:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(58, 148)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 13)
        Me.lblCliente.TabIndex = 25
        Me.lblCliente.Text = "Cliente:"
        '
        'txtIDPedido
        '
        Me.txtIDPedido.Location = New System.Drawing.Point(61, 116)
        Me.txtIDPedido.Name = "txtIDPedido"
        Me.txtIDPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtIDPedido.TabIndex = 24
        '
        'lblIDPedido
        '
        Me.lblIDPedido.AutoSize = True
        Me.lblIDPedido.Location = New System.Drawing.Point(58, 100)
        Me.lblIDPedido.Name = "lblIDPedido"
        Me.lblIDPedido.Size = New System.Drawing.Size(57, 13)
        Me.lblIDPedido.TabIndex = 23
        Me.lblIDPedido.Text = "ID Pedido:"
        '
        'lblVerPedido
        '
        Me.lblVerPedido.AutoSize = True
        Me.lblVerPedido.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblVerPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerPedido.ForeColor = System.Drawing.SystemColors.Control
        Me.lblVerPedido.Location = New System.Drawing.Point(57, 18)
        Me.lblVerPedido.Name = "lblVerPedido"
        Me.lblVerPedido.Size = New System.Drawing.Size(134, 24)
        Me.lblVerPedido.TabIndex = 3
        Me.lblVerPedido.Text = "VER PEDIDO"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(61, 164)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(227, 20)
        Me.txtCliente.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.lblVerPedido)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 60)
        Me.Panel1.TabIndex = 21
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(363, 440)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 39
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'FormVerPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 517)
        Me.Controls.Add(Me.btnAceptar)
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
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtIDPedido)
        Me.Controls.Add(Me.lblIDPedido)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormVerPedido"
        Me.Text = "FormVerPedido"
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLineas As Label
    Friend WithEvents dgvLineas As DataGridView
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtRE As TextBox
    Friend WithEvents lblRE As Label
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents lblIVA As Label
    Friend WithEvents txtBI As TextBox
    Friend WithEvents lblBI As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtIDPedido As TextBox
    Friend WithEvents lblIDPedido As Label
    Friend WithEvents lblVerPedido As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAceptar As Button
End Class
