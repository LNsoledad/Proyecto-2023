<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditarEmpleado))
        Me.PnlBarraTitulo = New System.Windows.Forms.Panel()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.PBMinim2 = New System.Windows.Forms.PictureBox()
        Me.PBCerrar2 = New System.Windows.Forms.PictureBox()
        Me.PnlCentro = New System.Windows.Forms.Panel()
        Me.CBTurnoEmp = New System.Windows.Forms.ComboBox()
        Me.PnlBotones = New System.Windows.Forms.Panel()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TBfechaIngEmp = New System.Windows.Forms.TextBox()
        Me.LblDni = New System.Windows.Forms.Label()
        Me.TBDniEmp = New System.Windows.Forms.TextBox()
        Me.CBProvincia = New System.Windows.Forms.ComboBox()
        Me.Lblturno = New System.Windows.Forms.Label()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.LblFechaIng = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.TBDireccionEmp = New System.Windows.Forms.TextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.TBTelefonoEmp = New System.Windows.Forms.TextBox()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.TBApellidoE = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TBNombreE = New System.Windows.Forms.TextBox()
        Me.PnlBarraTitulo.SuspendLayout()
        CType(Me.PBMinim2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCerrar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCentro.SuspendLayout()
        Me.PnlBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBarraTitulo
        '
        Me.PnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PnlBarraTitulo.Controls.Add(Me.LblTitulo)
        Me.PnlBarraTitulo.Controls.Add(Me.PBMinim2)
        Me.PnlBarraTitulo.Controls.Add(Me.PBCerrar2)
        Me.PnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PnlBarraTitulo.Name = "PnlBarraTitulo"
        Me.PnlBarraTitulo.Size = New System.Drawing.Size(867, 38)
        Me.PnlBarraTitulo.TabIndex = 1
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(4, 4)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(150, 24)
        Me.LblTitulo.TabIndex = 20
        Me.LblTitulo.Text = "Editar Empleado"
        '
        'PBMinim2
        '
        Me.PBMinim2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBMinim2.Image = CType(resources.GetObject("PBMinim2.Image"), System.Drawing.Image)
        Me.PBMinim2.Location = New System.Drawing.Point(801, 8)
        Me.PBMinim2.Name = "PBMinim2"
        Me.PBMinim2.Size = New System.Drawing.Size(24, 24)
        Me.PBMinim2.TabIndex = 19
        Me.PBMinim2.TabStop = False
        '
        'PBCerrar2
        '
        Me.PBCerrar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBCerrar2.Image = CType(resources.GetObject("PBCerrar2.Image"), System.Drawing.Image)
        Me.PBCerrar2.Location = New System.Drawing.Point(831, 7)
        Me.PBCerrar2.Name = "PBCerrar2"
        Me.PBCerrar2.Size = New System.Drawing.Size(24, 24)
        Me.PBCerrar2.TabIndex = 18
        Me.PBCerrar2.TabStop = False
        '
        'PnlCentro
        '
        Me.PnlCentro.BackColor = System.Drawing.Color.Transparent
        Me.PnlCentro.BackgroundImage = CType(resources.GetObject("PnlCentro.BackgroundImage"), System.Drawing.Image)
        Me.PnlCentro.Controls.Add(Me.CBTurnoEmp)
        Me.PnlCentro.Controls.Add(Me.PnlBotones)
        Me.PnlCentro.Controls.Add(Me.TBfechaIngEmp)
        Me.PnlCentro.Controls.Add(Me.LblDni)
        Me.PnlCentro.Controls.Add(Me.TBDniEmp)
        Me.PnlCentro.Controls.Add(Me.CBProvincia)
        Me.PnlCentro.Controls.Add(Me.Lblturno)
        Me.PnlCentro.Controls.Add(Me.LblProvincia)
        Me.PnlCentro.Controls.Add(Me.LblFechaIng)
        Me.PnlCentro.Controls.Add(Me.Panel2)
        Me.PnlCentro.Controls.Add(Me.Panel1)
        Me.PnlCentro.Controls.Add(Me.LblDireccion)
        Me.PnlCentro.Controls.Add(Me.TBDireccionEmp)
        Me.PnlCentro.Controls.Add(Me.LblTelefono)
        Me.PnlCentro.Controls.Add(Me.TBTelefonoEmp)
        Me.PnlCentro.Controls.Add(Me.LblApellido)
        Me.PnlCentro.Controls.Add(Me.TBApellidoE)
        Me.PnlCentro.Controls.Add(Me.LblNombre)
        Me.PnlCentro.Controls.Add(Me.TBNombreE)
        Me.PnlCentro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlCentro.Location = New System.Drawing.Point(0, 38)
        Me.PnlCentro.Name = "PnlCentro"
        Me.PnlCentro.Size = New System.Drawing.Size(867, 501)
        Me.PnlCentro.TabIndex = 3
        '
        'CBTurnoEmp
        '
        Me.CBTurnoEmp.AutoCompleteCustomSource.AddRange(New String() {"Mañana"})
        Me.CBTurnoEmp.FormattingEnabled = True
        Me.CBTurnoEmp.Items.AddRange(New Object() {"Mañana", "Tarde"})
        Me.CBTurnoEmp.Location = New System.Drawing.Point(151, 345)
        Me.CBTurnoEmp.Name = "CBTurnoEmp"
        Me.CBTurnoEmp.Size = New System.Drawing.Size(248, 21)
        Me.CBTurnoEmp.TabIndex = 19
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PnlBotones.Controls.Add(Me.BtnEditar)
        Me.PnlBotones.Controls.Add(Me.BtnAceptar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBotones.Location = New System.Drawing.Point(5, 439)
        Me.PnlBotones.Name = "PnlBotones"
        Me.PnlBotones.Size = New System.Drawing.Size(852, 62)
        Me.PnlBotones.TabIndex = 18
        '
        'BtnEditar
        '
        Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(416, 10)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(115, 42)
        Me.BtnEditar.TabIndex = 19
        Me.BtnEditar.Text = "        Cancelar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.Image = CType(resources.GetObject("BtnAceptar.Image"), System.Drawing.Image)
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(92, 10)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(115, 42)
        Me.BtnAceptar.TabIndex = 18
        Me.BtnAceptar.Text = "       Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TBfechaIngEmp
        '
        Me.TBfechaIngEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBfechaIngEmp.Location = New System.Drawing.Point(151, 304)
        Me.TBfechaIngEmp.Name = "TBfechaIngEmp"
        Me.TBfechaIngEmp.Size = New System.Drawing.Size(248, 24)
        Me.TBfechaIngEmp.TabIndex = 17
        '
        'LblDni
        '
        Me.LblDni.AutoSize = True
        Me.LblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDni.ForeColor = System.Drawing.Color.White
        Me.LblDni.Location = New System.Drawing.Point(25, 33)
        Me.LblDni.Name = "LblDni"
        Me.LblDni.Size = New System.Drawing.Size(34, 18)
        Me.LblDni.TabIndex = 1
        Me.LblDni.Text = "Dni:"
        '
        'TBDniEmp
        '
        Me.TBDniEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDniEmp.Location = New System.Drawing.Point(151, 26)
        Me.TBDniEmp.Name = "TBDniEmp"
        Me.TBDniEmp.Size = New System.Drawing.Size(248, 24)
        Me.TBDniEmp.TabIndex = 2
        '
        'CBProvincia
        '
        Me.CBProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBProvincia.FormattingEnabled = True
        Me.CBProvincia.Items.AddRange(New Object() {"1. Buenos Aires", "", "2. Catamarca", "", "3. Chaco", "", "4. Chubut", "", "5. Córdoba", "", "6. Corrientes", "", "7. Entre Ríos", "", "8. Formosa", "", "9. Jujuy", "", "10. La Pampa", "", "11. La Rioja", "", "12. Mendoza", "", "13. Misiones", "", "14. Neuquén", "", "15. Río Negro", "", "16. Salta", "", "17. San Juan", "", "18. San Luis", "", "19. Santa Cruz", "", "20. Santa Fe", "", "21. Santiago del Estero", "", "22. Tierra del Fuego, Antártida e Isla del Atlántico Sur", "", "23.  Tucumán"})
        Me.CBProvincia.Location = New System.Drawing.Point(151, 254)
        Me.CBProvincia.Name = "CBProvincia"
        Me.CBProvincia.Size = New System.Drawing.Size(248, 26)
        Me.CBProvincia.TabIndex = 12
        '
        'Lblturno
        '
        Me.Lblturno.AutoSize = True
        Me.Lblturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblturno.ForeColor = System.Drawing.Color.White
        Me.Lblturno.Location = New System.Drawing.Point(25, 352)
        Me.Lblturno.Name = "Lblturno"
        Me.Lblturno.Size = New System.Drawing.Size(51, 18)
        Me.Lblturno.TabIndex = 15
        Me.Lblturno.Text = "Turno:"
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProvincia.ForeColor = System.Drawing.Color.White
        Me.LblProvincia.Location = New System.Drawing.Point(25, 262)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(73, 18)
        Me.LblProvincia.TabIndex = 11
        Me.LblProvincia.Text = "Provincia:"
        '
        'LblFechaIng
        '
        Me.LblFechaIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaIng.ForeColor = System.Drawing.Color.White
        Me.LblFechaIng.Location = New System.Drawing.Point(25, 307)
        Me.LblFechaIng.Name = "LblFechaIng"
        Me.LblFechaIng.Size = New System.Drawing.Size(129, 35)
        Me.LblFechaIng.TabIndex = 13
        Me.LblFechaIng.Text = "Fecha De" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Ingreso" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(857, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 501)
        Me.Panel2.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 501)
        Me.Panel1.TabIndex = 10
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccion.ForeColor = System.Drawing.Color.White
        Me.LblDireccion.Location = New System.Drawing.Point(25, 215)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(75, 18)
        Me.LblDireccion.TabIndex = 9
        Me.LblDireccion.Text = "Dirección:"
        '
        'TBDireccionEmp
        '
        Me.TBDireccionEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDireccionEmp.Location = New System.Drawing.Point(151, 208)
        Me.TBDireccionEmp.Name = "TBDireccionEmp"
        Me.TBDireccionEmp.Size = New System.Drawing.Size(248, 24)
        Me.TBDireccionEmp.TabIndex = 10
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono.ForeColor = System.Drawing.Color.White
        Me.LblTelefono.Location = New System.Drawing.Point(25, 169)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(70, 18)
        Me.LblTelefono.TabIndex = 7
        Me.LblTelefono.Text = "Teléfono:"
        '
        'TBTelefonoEmp
        '
        Me.TBTelefonoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTelefonoEmp.Location = New System.Drawing.Point(151, 162)
        Me.TBTelefonoEmp.Name = "TBTelefonoEmp"
        Me.TBTelefonoEmp.Size = New System.Drawing.Size(248, 24)
        Me.TBTelefonoEmp.TabIndex = 8
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellido.ForeColor = System.Drawing.Color.White
        Me.LblApellido.Location = New System.Drawing.Point(25, 121)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(63, 18)
        Me.LblApellido.TabIndex = 5
        Me.LblApellido.Text = "Apellido:"
        '
        'TBApellidoE
        '
        Me.TBApellidoE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBApellidoE.Location = New System.Drawing.Point(151, 114)
        Me.TBApellidoE.Name = "TBApellidoE"
        Me.TBApellidoE.Size = New System.Drawing.Size(248, 24)
        Me.TBApellidoE.TabIndex = 6
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.White
        Me.LblNombre.Location = New System.Drawing.Point(25, 76)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(66, 18)
        Me.LblNombre.TabIndex = 3
        Me.LblNombre.Text = "Nombre:"
        '
        'TBNombreE
        '
        Me.TBNombreE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNombreE.Location = New System.Drawing.Point(151, 69)
        Me.TBNombreE.Name = "TBNombreE"
        Me.TBNombreE.Size = New System.Drawing.Size(248, 24)
        Me.TBNombreE.TabIndex = 4
        '
        'FormEditarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 539)
        Me.Controls.Add(Me.PnlCentro)
        Me.Controls.Add(Me.PnlBarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEditarEmpleado"
        Me.Text = "FormEditarEmpleado"
        Me.PnlBarraTitulo.ResumeLayout(False)
        Me.PnlBarraTitulo.PerformLayout()
        CType(Me.PBMinim2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCerrar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCentro.ResumeLayout(False)
        Me.PnlCentro.PerformLayout()
        Me.PnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlBarraTitulo As Panel
    Friend WithEvents LblTitulo As Label
    Friend WithEvents PBMinim2 As PictureBox
    Friend WithEvents PBCerrar2 As PictureBox
    Friend WithEvents PnlCentro As Panel
    Friend WithEvents PnlBotones As Panel
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TBfechaIngEmp As TextBox
    Friend WithEvents LblDni As Label
    Friend WithEvents TBDniEmp As TextBox
    Friend WithEvents CBProvincia As ComboBox
    Friend WithEvents Lblturno As Label
    Friend WithEvents LblProvincia As Label
    Friend WithEvents LblFechaIng As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblDireccion As Label
    Friend WithEvents TBDireccionEmp As TextBox
    Friend WithEvents LblTelefono As Label
    Friend WithEvents TBTelefonoEmp As TextBox
    Friend WithEvents LblApellido As Label
    Friend WithEvents TBApellidoE As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents TBNombreE As TextBox
    Friend WithEvents CBTurnoEmp As ComboBox
End Class
