<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEliminarStock
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
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnSi = New System.Windows.Forms.Button()
        Me.txtEnvase = New System.Windows.Forms.TextBox()
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.lblEnvase = New System.Windows.Forms.Label()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblEliminarProducto = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(188, 282)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 23)
        Me.btnNo.TabIndex = 19
        Me.btnNo.Text = "NO"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnSi
        '
        Me.btnSi.Location = New System.Drawing.Point(107, 282)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(75, 23)
        Me.btnSi.TabIndex = 18
        Me.btnSi.Text = "SI"
        Me.btnSi.UseVisualStyleBackColor = True
        '
        'txtEnvase
        '
        Me.txtEnvase.Enabled = False
        Me.txtEnvase.Location = New System.Drawing.Point(138, 177)
        Me.txtEnvase.Name = "txtEnvase"
        Me.txtEnvase.Size = New System.Drawing.Size(213, 20)
        Me.txtEnvase.TabIndex = 17
        '
        'txtProd
        '
        Me.txtProd.Enabled = False
        Me.txtProd.Location = New System.Drawing.Point(138, 138)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Size = New System.Drawing.Size(213, 20)
        Me.txtProd.TabIndex = 16
        '
        'lblEnvase
        '
        Me.lblEnvase.AutoSize = True
        Me.lblEnvase.Location = New System.Drawing.Point(39, 180)
        Me.lblEnvase.Name = "lblEnvase"
        Me.lblEnvase.Size = New System.Drawing.Size(50, 13)
        Me.lblEnvase.TabIndex = 15
        Me.lblEnvase.Text = "ENVASE"
        '
        'lblProd
        '
        Me.lblProd.AutoSize = True
        Me.lblProd.Location = New System.Drawing.Point(39, 141)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(68, 13)
        Me.lblProd.TabIndex = 14
        Me.lblProd.Text = "PRODUCTO"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(39, 94)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(321, 18)
        Me.lblTitulo.TabIndex = 13
        Me.lblTitulo.Text = "¿Desea eliminar este producto del stock?"
        '
        'lblEliminarProducto
        '
        Me.lblEliminarProducto.AutoSize = True
        Me.lblEliminarProducto.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEliminarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEliminarProducto.ForeColor = System.Drawing.SystemColors.Control
        Me.lblEliminarProducto.Location = New System.Drawing.Point(38, 19)
        Me.lblEliminarProducto.Name = "lblEliminarProducto"
        Me.lblEliminarProducto.Size = New System.Drawing.Size(225, 24)
        Me.lblEliminarProducto.TabIndex = 2
        Me.lblEliminarProducto.Text = "ELIMINAR PRODUCTO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.lblEliminarProducto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 58)
        Me.Panel1.TabIndex = 12
        '
        'txtLote
        '
        Me.txtLote.Enabled = False
        Me.txtLote.Location = New System.Drawing.Point(138, 216)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(213, 20)
        Me.txtLote.TabIndex = 21
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.Location = New System.Drawing.Point(39, 219)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(50, 13)
        Me.lblLote.TabIndex = 20
        Me.lblLote.Text = "Nº LOTE"
        '
        'FormEliminarStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 337)
        Me.Controls.Add(Me.txtLote)
        Me.Controls.Add(Me.lblLote)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnSi)
        Me.Controls.Add(Me.txtEnvase)
        Me.Controls.Add(Me.txtProd)
        Me.Controls.Add(Me.lblEnvase)
        Me.Controls.Add(Me.lblProd)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormEliminarStock"
        Me.Text = "FormEliminarStock"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNo As Button
    Friend WithEvents btnSi As Button
    Friend WithEvents txtEnvase As TextBox
    Friend WithEvents txtProd As TextBox
    Friend WithEvents lblEnvase As Label
    Friend WithEvents lblProd As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblEliminarProducto As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtLote As TextBox
    Friend WithEvents lblLote As Label
End Class
