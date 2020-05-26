<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevoUsuario
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
        Me.lblNuevoUsuario = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblIDUsuario = New System.Windows.Forms.Label()
        Me.lblRelleno = New System.Windows.Forms.Label()
        Me.txtIDUsuario = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.txtPW2 = New System.Windows.Forms.TextBox()
        Me.lblPW2 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNuevoUsuario
        '
        Me.lblNuevoUsuario.AutoSize = True
        Me.lblNuevoUsuario.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoUsuario.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNuevoUsuario.Location = New System.Drawing.Point(38, 16)
        Me.lblNuevoUsuario.Name = "lblNuevoUsuario"
        Me.lblNuevoUsuario.Size = New System.Drawing.Size(179, 24)
        Me.lblNuevoUsuario.TabIndex = 2
        Me.lblNuevoUsuario.Text = "NUEVO USUARIO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.lblNuevoUsuario)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 57)
        Me.Panel1.TabIndex = 1
        '
        'lblIDUsuario
        '
        Me.lblIDUsuario.AutoSize = True
        Me.lblIDUsuario.Location = New System.Drawing.Point(39, 143)
        Me.lblIDUsuario.Name = "lblIDUsuario"
        Me.lblIDUsuario.Size = New System.Drawing.Size(68, 13)
        Me.lblIDUsuario.TabIndex = 2
        Me.lblIDUsuario.Text = "Identificador:"
        '
        'lblRelleno
        '
        Me.lblRelleno.AutoSize = True
        Me.lblRelleno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRelleno.Location = New System.Drawing.Point(38, 95)
        Me.lblRelleno.Name = "lblRelleno"
        Me.lblRelleno.Size = New System.Drawing.Size(257, 24)
        Me.lblRelleno.TabIndex = 5
        Me.lblRelleno.Text = "Rellene todos los campos:"
        '
        'txtIDUsuario
        '
        Me.txtIDUsuario.Enabled = False
        Me.txtIDUsuario.Location = New System.Drawing.Point(42, 159)
        Me.txtIDUsuario.Name = "txtIDUsuario"
        Me.txtIDUsuario.Size = New System.Drawing.Size(296, 20)
        Me.txtIDUsuario.TabIndex = 6
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(42, 209)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(296, 20)
        Me.txtUsuario.TabIndex = 8
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(39, 193)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 7
        Me.lblUsuario.Text = "Usuario:"
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(42, 258)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(296, 20)
        Me.txtPW.TabIndex = 10
        '
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.Location = New System.Drawing.Point(39, 242)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(64, 13)
        Me.lblPW.TabIndex = 9
        Me.lblPW.Text = "Contraseña:"
        '
        'txtPW2
        '
        Me.txtPW2.Location = New System.Drawing.Point(42, 310)
        Me.txtPW2.Name = "txtPW2"
        Me.txtPW2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW2.Size = New System.Drawing.Size(296, 20)
        Me.txtPW2.TabIndex = 12
        '
        'lblPW2
        '
        Me.lblPW2.AutoSize = True
        Me.lblPW2.Location = New System.Drawing.Point(39, 294)
        Me.lblPW2.Name = "lblPW2"
        Me.lblPW2.Size = New System.Drawing.Size(108, 13)
        Me.lblPW2.TabIndex = 11
        Me.lblPW2.Text = "Repita la contraseña:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(142, 371)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'FormNuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 421)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtPW2)
        Me.Controls.Add(Me.lblPW2)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtIDUsuario)
        Me.Controls.Add(Me.lblRelleno)
        Me.Controls.Add(Me.lblIDUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormNuevoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormNuevoUsuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNuevoUsuario As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblIDUsuario As Label
    Friend WithEvents lblRelleno As Label
    Friend WithEvents txtIDUsuario As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtPW As TextBox
    Friend WithEvents lblPW As Label
    Friend WithEvents txtPW2 As TextBox
    Friend WithEvents lblPW2 As Label
    Friend WithEvents btnAceptar As Button
End Class
