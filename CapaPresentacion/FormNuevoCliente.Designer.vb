<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevoCliente
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
        Me.lblNuevoCliente = New System.Windows.Forms.Label()
        Me.lblIdent = New System.Windows.Forms.Label()
        Me.txtIdentificador = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtPoblacion = New System.Windows.Forms.TextBox()
        Me.lblPoblacion = New System.Windows.Forms.Label()
        Me.txtCIF = New System.Windows.Forms.TextBox()
        Me.lblCIF = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.cbRecargo = New System.Windows.Forms.CheckBox()
        Me.cboFacturacion = New System.Windows.Forms.ComboBox()
        Me.lblFacturacion = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.panTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'panTitulo
        '
        Me.panTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panTitulo.Controls.Add(Me.lblNuevoCliente)
        Me.panTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panTitulo.Name = "panTitulo"
        Me.panTitulo.Size = New System.Drawing.Size(775, 52)
        Me.panTitulo.TabIndex = 0
        '
        'lblNuevoCliente
        '
        Me.lblNuevoCliente.AutoSize = True
        Me.lblNuevoCliente.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNuevoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNuevoCliente.Location = New System.Drawing.Point(62, 13)
        Me.lblNuevoCliente.Name = "lblNuevoCliente"
        Me.lblNuevoCliente.Size = New System.Drawing.Size(175, 24)
        Me.lblNuevoCliente.TabIndex = 1
        Me.lblNuevoCliente.Text = "NUEVO CLIENTE"
        '
        'lblIdent
        '
        Me.lblIdent.AutoSize = True
        Me.lblIdent.Location = New System.Drawing.Point(32, 79)
        Me.lblIdent.Name = "lblIdent"
        Me.lblIdent.Size = New System.Drawing.Size(68, 13)
        Me.lblIdent.TabIndex = 1
        Me.lblIdent.Text = "Identificador:"
        '
        'txtIdentificador
        '
        Me.txtIdentificador.Enabled = False
        Me.txtIdentificador.Location = New System.Drawing.Point(34, 95)
        Me.txtIdentificador.Name = "txtIdentificador"
        Me.txtIdentificador.ReadOnly = True
        Me.txtIdentificador.Size = New System.Drawing.Size(337, 20)
        Me.txtIdentificador.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(32, 135)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(35, 151)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(336, 20)
        Me.txtNombre.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(35, 268)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(336, 20)
        Me.txtDireccion.TabIndex = 6
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(32, 252)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lblDireccion.TabIndex = 5
        Me.lblDireccion.Text = "Dirección:"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.Location = New System.Drawing.Point(401, 268)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(336, 20)
        Me.txtPoblacion.TabIndex = 8
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Location = New System.Drawing.Point(398, 252)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(57, 13)
        Me.lblPoblacion.TabIndex = 7
        Me.lblPoblacion.Text = "Población:"
        '
        'txtCIF
        '
        Me.txtCIF.Location = New System.Drawing.Point(401, 151)
        Me.txtCIF.Name = "txtCIF"
        Me.txtCIF.Size = New System.Drawing.Size(336, 20)
        Me.txtCIF.TabIndex = 10
        '
        'lblCIF
        '
        Me.lblCIF.AutoSize = True
        Me.lblCIF.Location = New System.Drawing.Point(398, 135)
        Me.lblCIF.Name = "lblCIF"
        Me.lblCIF.Size = New System.Drawing.Size(48, 13)
        Me.lblCIF.TabIndex = 9
        Me.lblCIF.Text = "CIF/NIF:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(34, 207)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(336, 20)
        Me.txtEmail.TabIndex = 12
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(31, 191)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "Email:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(401, 207)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(336, 20)
        Me.txtTelefono.TabIndex = 14
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(398, 191)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 13
        Me.lblTelefono.Text = "Teléfono:"
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(35, 329)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(336, 20)
        Me.txtCuenta.TabIndex = 16
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(32, 313)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(99, 13)
        Me.lblCuenta.TabIndex = 15
        Me.lblCuenta.Text = "Número de Cuenta:"
        '
        'cbRecargo
        '
        Me.cbRecargo.AutoSize = True
        Me.cbRecargo.Location = New System.Drawing.Point(34, 375)
        Me.cbRecargo.Name = "cbRecargo"
        Me.cbRecargo.Size = New System.Drawing.Size(146, 17)
        Me.cbRecargo.TabIndex = 18
        Me.cbRecargo.Text = "Recargo de Equivalencia"
        Me.cbRecargo.UseVisualStyleBackColor = True
        '
        'cboFacturacion
        '
        Me.cboFacturacion.CausesValidation = False
        Me.cboFacturacion.FormattingEnabled = True
        Me.cboFacturacion.Location = New System.Drawing.Point(401, 329)
        Me.cboFacturacion.Name = "cboFacturacion"
        Me.cboFacturacion.Size = New System.Drawing.Size(336, 21)
        Me.cboFacturacion.TabIndex = 19
        '
        'lblFacturacion
        '
        Me.lblFacturacion.AutoSize = True
        Me.lblFacturacion.Location = New System.Drawing.Point(398, 313)
        Me.lblFacturacion.Name = "lblFacturacion"
        Me.lblFacturacion.Size = New System.Drawing.Size(102, 13)
        Me.lblFacturacion.TabIndex = 20
        Me.lblFacturacion.Text = "Tipo de Facturacion"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(348, 420)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 21
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'FormNuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 485)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblFacturacion)
        Me.Controls.Add(Me.cboFacturacion)
        Me.Controls.Add(Me.cbRecargo)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtCIF)
        Me.Controls.Add(Me.lblCIF)
        Me.Controls.Add(Me.txtPoblacion)
        Me.Controls.Add(Me.lblPoblacion)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtIdentificador)
        Me.Controls.Add(Me.lblIdent)
        Me.Controls.Add(Me.panTitulo)
        Me.Name = "FormNuevoCliente"
        Me.Text = "Nuevo Cliente"
        Me.panTitulo.ResumeLayout(False)
        Me.panTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panTitulo As Panel
    Friend WithEvents lblNuevoCliente As Label
    Friend WithEvents lblIdent As Label
    Friend WithEvents txtIdentificador As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtPoblacion As TextBox
    Friend WithEvents lblPoblacion As Label
    Friend WithEvents txtCIF As TextBox
    Friend WithEvents lblCIF As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents lblCuenta As Label
    Friend WithEvents cbRecargo As CheckBox
    Friend WithEvents cboFacturacion As ComboBox
    Friend WithEvents lblFacturacion As Label
    Friend WithEvents btnAceptar As Button
End Class
