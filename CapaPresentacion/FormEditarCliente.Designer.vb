<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarCliente
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblFacturacion = New System.Windows.Forms.Label()
        Me.cboFacturacion = New System.Windows.Forms.ComboBox()
        Me.cbRecargo = New System.Windows.Forms.CheckBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCIF = New System.Windows.Forms.TextBox()
        Me.lblCIF = New System.Windows.Forms.Label()
        Me.txtPoblacion = New System.Windows.Forms.TextBox()
        Me.lblPoblacion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblIdent = New System.Windows.Forms.Label()
        Me.lblEditarCliente = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.panTitulo = New System.Windows.Forms.Panel()
        Me.panTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(34, 99)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(336, 20)
        Me.txtID.TabIndex = 45
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(665, 331)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(72, 23)
        Me.btnAñadir.TabIndex = 44
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(348, 424)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 43
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblFacturacion
        '
        Me.lblFacturacion.AutoSize = True
        Me.lblFacturacion.Location = New System.Drawing.Point(398, 317)
        Me.lblFacturacion.Name = "lblFacturacion"
        Me.lblFacturacion.Size = New System.Drawing.Size(102, 13)
        Me.lblFacturacion.TabIndex = 42
        Me.lblFacturacion.Text = "Tipo de Facturacion"
        '
        'cboFacturacion
        '
        Me.cboFacturacion.CausesValidation = False
        Me.cboFacturacion.FormattingEnabled = True
        Me.cboFacturacion.Location = New System.Drawing.Point(401, 333)
        Me.cboFacturacion.Name = "cboFacturacion"
        Me.cboFacturacion.Size = New System.Drawing.Size(258, 21)
        Me.cboFacturacion.TabIndex = 41
        '
        'cbRecargo
        '
        Me.cbRecargo.AutoSize = True
        Me.cbRecargo.Location = New System.Drawing.Point(34, 379)
        Me.cbRecargo.Name = "cbRecargo"
        Me.cbRecargo.Size = New System.Drawing.Size(146, 17)
        Me.cbRecargo.TabIndex = 40
        Me.cbRecargo.Text = "Recargo de Equivalencia"
        Me.cbRecargo.UseVisualStyleBackColor = True
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(35, 333)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(336, 20)
        Me.txtCuenta.TabIndex = 39
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(32, 317)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(99, 13)
        Me.lblCuenta.TabIndex = 38
        Me.lblCuenta.Text = "Número de Cuenta:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(401, 211)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(336, 20)
        Me.txtTelefono.TabIndex = 37
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(398, 195)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 36
        Me.lblTelefono.Text = "Teléfono:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(34, 211)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(336, 20)
        Me.txtEmail.TabIndex = 35
        '
        'txtCIF
        '
        Me.txtCIF.Location = New System.Drawing.Point(401, 155)
        Me.txtCIF.Name = "txtCIF"
        Me.txtCIF.Size = New System.Drawing.Size(336, 20)
        Me.txtCIF.TabIndex = 33
        '
        'lblCIF
        '
        Me.lblCIF.AutoSize = True
        Me.lblCIF.Location = New System.Drawing.Point(398, 139)
        Me.lblCIF.Name = "lblCIF"
        Me.lblCIF.Size = New System.Drawing.Size(48, 13)
        Me.lblCIF.TabIndex = 32
        Me.lblCIF.Text = "CIF/NIF:"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.Location = New System.Drawing.Point(401, 272)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(336, 20)
        Me.txtPoblacion.TabIndex = 31
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Location = New System.Drawing.Point(398, 256)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(57, 13)
        Me.lblPoblacion.TabIndex = 30
        Me.lblPoblacion.Text = "Población:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(35, 272)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(336, 20)
        Me.txtDireccion.TabIndex = 29
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(32, 256)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lblDireccion.TabIndex = 28
        Me.lblDireccion.Text = "Dirección:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(35, 155)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(336, 20)
        Me.txtNombre.TabIndex = 27
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(32, 139)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 26
        Me.lblNombre.Text = "Nombre:"
        '
        'lblIdent
        '
        Me.lblIdent.AutoSize = True
        Me.lblIdent.Location = New System.Drawing.Point(32, 83)
        Me.lblIdent.Name = "lblIdent"
        Me.lblIdent.Size = New System.Drawing.Size(68, 13)
        Me.lblIdent.TabIndex = 25
        Me.lblIdent.Text = "Identificador:"
        '
        'lblEditarCliente
        '
        Me.lblEditarCliente.AutoSize = True
        Me.lblEditarCliente.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEditarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditarCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.lblEditarCliente.Location = New System.Drawing.Point(62, 13)
        Me.lblEditarCliente.Name = "lblEditarCliente"
        Me.lblEditarCliente.Size = New System.Drawing.Size(176, 24)
        Me.lblEditarCliente.TabIndex = 1
        Me.lblEditarCliente.Text = "EDITAR CLIENTE"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(31, 195)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 34
        Me.lblEmail.Text = "Email:"
        '
        'panTitulo
        '
        Me.panTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panTitulo.Controls.Add(Me.lblEditarCliente)
        Me.panTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panTitulo.Name = "panTitulo"
        Me.panTitulo.Size = New System.Drawing.Size(776, 52)
        Me.panTitulo.TabIndex = 24
        '
        'FormEditarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 470)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblFacturacion)
        Me.Controls.Add(Me.cboFacturacion)
        Me.Controls.Add(Me.cbRecargo)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCIF)
        Me.Controls.Add(Me.lblCIF)
        Me.Controls.Add(Me.txtPoblacion)
        Me.Controls.Add(Me.lblPoblacion)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblIdent)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.panTitulo)
        Me.Name = "FormEditarCliente"
        Me.Text = "FormEditarCliente"
        Me.panTitulo.ResumeLayout(False)
        Me.panTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblFacturacion As Label
    Friend WithEvents cboFacturacion As ComboBox
    Friend WithEvents cbRecargo As CheckBox
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents lblCuenta As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCIF As TextBox
    Friend WithEvents lblCIF As Label
    Friend WithEvents txtPoblacion As TextBox
    Friend WithEvents lblPoblacion As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblIdent As Label
    Friend WithEvents lblEditarCliente As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents panTitulo As Panel
End Class
