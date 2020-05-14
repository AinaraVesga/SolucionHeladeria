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
        Me.panTitulo.SuspendLayout()
        Me.panBody1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panTitulo
        '
        Me.panTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panTitulo.Controls.Add(Me.lblAnadirStock)
        Me.panTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panTitulo.Name = "panTitulo"
        Me.panTitulo.Size = New System.Drawing.Size(366, 56)
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
        'FormAñadirStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 278)
        Me.Controls.Add(Me.panBody1)
        Me.Controls.Add(Me.panTitulo)
        Me.Name = "FormAñadirStock"
        Me.Text = "AñadirStock"
        Me.panTitulo.ResumeLayout(False)
        Me.panTitulo.PerformLayout()
        Me.panBody1.ResumeLayout(False)
        Me.panBody1.PerformLayout()
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
End Class
