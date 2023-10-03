<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgregarUsuario))
        Me.PnlCentro = New System.Windows.Forms.Panel()
        Me.GBCargo = New System.Windows.Forms.GroupBox()
        Me.CBCargo = New System.Windows.Forms.ComboBox()
        Me.LblCargo = New System.Windows.Forms.Label()
        Me.LblUsuarioDni = New System.Windows.Forms.Label()
        Me.TBUsuarioDni = New System.Windows.Forms.TextBox()
        Me.LblContrasenia = New System.Windows.Forms.Label()
        Me.TBContrasenia = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTPFNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaNacimiento = New System.Windows.Forms.Label()
        Me.CBCiudad = New System.Windows.Forms.ComboBox()
        Me.CBProvincia = New System.Windows.Forms.ComboBox()
        Me.LblCiudad = New System.Windows.Forms.Label()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.TBDireccion = New System.Windows.Forms.TextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.TBTelefono = New System.Windows.Forms.TextBox()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnlBarraTitulo = New System.Windows.Forms.Panel()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.PBMinim2 = New System.Windows.Forms.PictureBox()
        Me.PBCerrar2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CBCargoU = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBDniU = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBContraseñaU = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PnlBotones = New System.Windows.Forms.Panel()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.PnlCentro.SuspendLayout()
        Me.GBCargo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PnlBarraTitulo.SuspendLayout()
        CType(Me.PBMinim2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCerrar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.PnlBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlCentro
        '
        Me.PnlCentro.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.PnlCentro.Controls.Add(Me.GBCargo)
        Me.PnlCentro.Controls.Add(Me.GroupBox1)
        Me.PnlCentro.Controls.Add(Me.Panel2)
        Me.PnlCentro.Controls.Add(Me.Panel1)
        Me.PnlCentro.Location = New System.Drawing.Point(-14, -66)
        Me.PnlCentro.Name = "PnlCentro"
        Me.PnlCentro.Size = New System.Drawing.Size(0, 0)
        Me.PnlCentro.TabIndex = 1
        '
        'GBCargo
        '
        Me.GBCargo.Controls.Add(Me.CBCargo)
        Me.GBCargo.Controls.Add(Me.LblCargo)
        Me.GBCargo.Controls.Add(Me.LblUsuarioDni)
        Me.GBCargo.Controls.Add(Me.TBUsuarioDni)
        Me.GBCargo.Controls.Add(Me.LblContrasenia)
        Me.GBCargo.Controls.Add(Me.TBContrasenia)
        Me.GBCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBCargo.ForeColor = System.Drawing.Color.White
        Me.GBCargo.Location = New System.Drawing.Point(12, 18)
        Me.GBCargo.Name = "GBCargo"
        Me.GBCargo.Size = New System.Drawing.Size(422, 175)
        Me.GBCargo.TabIndex = 1
        Me.GBCargo.TabStop = False
        Me.GBCargo.Text = "Datos del Cargo"
        '
        'CBCargo
        '
        Me.CBCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCargo.FormattingEnabled = True
        Me.CBCargo.Items.AddRange(New Object() {"Administrador/a", "Vendedor/a", "Usuario/a"})
        Me.CBCargo.Location = New System.Drawing.Point(149, 119)
        Me.CBCargo.Name = "CBCargo"
        Me.CBCargo.Size = New System.Drawing.Size(248, 26)
        Me.CBCargo.TabIndex = 7
        '
        'LblCargo
        '
        Me.LblCargo.AutoSize = True
        Me.LblCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCargo.Location = New System.Drawing.Point(25, 126)
        Me.LblCargo.Name = "LblCargo"
        Me.LblCargo.Size = New System.Drawing.Size(53, 18)
        Me.LblCargo.TabIndex = 6
        Me.LblCargo.Text = "Cargo:"
        '
        'LblUsuarioDni
        '
        Me.LblUsuarioDni.AutoSize = True
        Me.LblUsuarioDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuarioDni.Location = New System.Drawing.Point(25, 33)
        Me.LblUsuarioDni.Name = "LblUsuarioDni"
        Me.LblUsuarioDni.Size = New System.Drawing.Size(100, 18)
        Me.LblUsuarioDni.TabIndex = 2
        Me.LblUsuarioDni.Text = "Usuario (Dni):"
        '
        'TBUsuarioDni
        '
        Me.TBUsuarioDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUsuarioDni.Location = New System.Drawing.Point(149, 26)
        Me.TBUsuarioDni.Name = "TBUsuarioDni"
        Me.TBUsuarioDni.Size = New System.Drawing.Size(248, 24)
        Me.TBUsuarioDni.TabIndex = 3
        '
        'LblContrasenia
        '
        Me.LblContrasenia.AutoSize = True
        Me.LblContrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContrasenia.Location = New System.Drawing.Point(25, 79)
        Me.LblContrasenia.Name = "LblContrasenia"
        Me.LblContrasenia.Size = New System.Drawing.Size(89, 18)
        Me.LblContrasenia.TabIndex = 4
        Me.LblContrasenia.Text = "Contraseña:"
        '
        'TBContrasenia
        '
        Me.TBContrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBContrasenia.Location = New System.Drawing.Point(149, 72)
        Me.TBContrasenia.Name = "TBContrasenia"
        Me.TBContrasenia.Size = New System.Drawing.Size(248, 24)
        Me.TBContrasenia.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTPFNacimiento)
        Me.GroupBox1.Controls.Add(Me.LblFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.CBCiudad)
        Me.GroupBox1.Controls.Add(Me.CBProvincia)
        Me.GroupBox1.Controls.Add(Me.LblCiudad)
        Me.GroupBox1.Controls.Add(Me.LblProvincia)
        Me.GroupBox1.Controls.Add(Me.LblDireccion)
        Me.GroupBox1.Controls.Add(Me.TBDireccion)
        Me.GroupBox1.Controls.Add(Me.LblTelefono)
        Me.GroupBox1.Controls.Add(Me.TBTelefono)
        Me.GroupBox1.Controls.Add(Me.LblApellido)
        Me.GroupBox1.Controls.Add(Me.TBApellido)
        Me.GroupBox1.Controls.Add(Me.LblNombre)
        Me.GroupBox1.Controls.Add(Me.TBNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(11, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 353)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Usuario"
        '
        'DTPFNacimiento
        '
        Me.DTPFNacimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTPFNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFNacimiento.Location = New System.Drawing.Point(149, 121)
        Me.DTPFNacimiento.MinDate = New Date(1960, 1, 1, 0, 0, 0, 0)
        Me.DTPFNacimiento.Name = "DTPFNacimiento"
        Me.DTPFNacimiento.Size = New System.Drawing.Size(248, 24)
        Me.DTPFNacimiento.TabIndex = 14
        Me.DTPFNacimiento.Value = New Date(2020, 10, 2, 23, 19, 43, 0)
        '
        'LblFechaNacimiento
        '
        Me.LblFechaNacimiento.AutoSize = True
        Me.LblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaNacimiento.Location = New System.Drawing.Point(25, 129)
        Me.LblFechaNacimiento.Name = "LblFechaNacimiento"
        Me.LblFechaNacimiento.Size = New System.Drawing.Size(104, 18)
        Me.LblFechaNacimiento.TabIndex = 13
        Me.LblFechaNacimiento.Text = "F. Nacimiento:"
        '
        'CBCiudad
        '
        Me.CBCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCiudad.FormattingEnabled = True
        Me.CBCiudad.Location = New System.Drawing.Point(149, 301)
        Me.CBCiudad.Name = "CBCiudad"
        Me.CBCiudad.Size = New System.Drawing.Size(248, 26)
        Me.CBCiudad.TabIndex = 22
        '
        'CBProvincia
        '
        Me.CBProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBProvincia.FormattingEnabled = True
        Me.CBProvincia.Items.AddRange(New Object() {"1. Buenos Aires", "", "2. Catamarca", "", "3. Chaco", "", "4. Chubut", "", "5. Córdoba", "", "6. Corrientes", "", "7. Entre Ríos", "", "8. Formosa", "", "9. Jujuy", "", "10. La Pampa", "", "11. La Rioja", "", "12. Mendoza", "", "13. Misiones", "", "14. Neuquén", "", "15. Río Negro", "", "16. Salta", "", "17. San Juan", "", "18. San Luis", "", "19. Santa Cruz", "", "20. Santa Fe", "", "21. Santiago del Estero", "", "22. Tierra del Fuego, Antártida e Isla del Atlántico Sur", "", "23.  Tucumán"})
        Me.CBProvincia.Location = New System.Drawing.Point(149, 256)
        Me.CBProvincia.Name = "CBProvincia"
        Me.CBProvincia.Size = New System.Drawing.Size(248, 26)
        Me.CBProvincia.TabIndex = 20
        '
        'LblCiudad
        '
        Me.LblCiudad.AutoSize = True
        Me.LblCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCiudad.Location = New System.Drawing.Point(25, 308)
        Me.LblCiudad.Name = "LblCiudad"
        Me.LblCiudad.Size = New System.Drawing.Size(58, 18)
        Me.LblCiudad.TabIndex = 21
        Me.LblCiudad.Text = "Ciudad:"
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProvincia.Location = New System.Drawing.Point(25, 264)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(73, 18)
        Me.LblProvincia.TabIndex = 19
        Me.LblProvincia.Text = "Provincia:"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccion.Location = New System.Drawing.Point(25, 218)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(75, 18)
        Me.LblDireccion.TabIndex = 17
        Me.LblDireccion.Text = "Dirección:"
        '
        'TBDireccion
        '
        Me.TBDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDireccion.Location = New System.Drawing.Point(149, 211)
        Me.TBDireccion.Name = "TBDireccion"
        Me.TBDireccion.Size = New System.Drawing.Size(248, 24)
        Me.TBDireccion.TabIndex = 18
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono.Location = New System.Drawing.Point(25, 173)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(70, 18)
        Me.LblTelefono.TabIndex = 15
        Me.LblTelefono.Text = "Teléfono:"
        '
        'TBTelefono
        '
        Me.TBTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTelefono.Location = New System.Drawing.Point(149, 166)
        Me.TBTelefono.Name = "TBTelefono"
        Me.TBTelefono.Size = New System.Drawing.Size(248, 24)
        Me.TBTelefono.TabIndex = 16
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellido.Location = New System.Drawing.Point(25, 82)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(63, 18)
        Me.LblApellido.TabIndex = 11
        Me.LblApellido.Text = "Apellido:"
        '
        'TBApellido
        '
        Me.TBApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBApellido.Location = New System.Drawing.Point(149, 75)
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(248, 24)
        Me.TBApellido.TabIndex = 12
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(25, 39)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(66, 18)
        Me.LblNombre.TabIndex = 9
        Me.LblNombre.Text = "Nombre:"
        '
        'TBNombre
        '
        Me.TBNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNombre.Location = New System.Drawing.Point(149, 32)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(248, 24)
        Me.TBNombre.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(-5, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 0)
        Me.Panel2.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 0)
        Me.Panel1.TabIndex = 10
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
        Me.PnlBarraTitulo.Size = New System.Drawing.Size(747, 38)
        Me.PnlBarraTitulo.TabIndex = 2
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(4, 4)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(147, 24)
        Me.LblTitulo.TabIndex = 20
        Me.LblTitulo.Text = "Agregar Usuario"
        '
        'PBMinim2
        '
        Me.PBMinim2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBMinim2.Image = CType(resources.GetObject("PBMinim2.Image"), System.Drawing.Image)
        Me.PBMinim2.Location = New System.Drawing.Point(681, 8)
        Me.PBMinim2.Name = "PBMinim2"
        Me.PBMinim2.Size = New System.Drawing.Size(24, 24)
        Me.PBMinim2.TabIndex = 19
        Me.PBMinim2.TabStop = False
        '
        'PBCerrar2
        '
        Me.PBCerrar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBCerrar2.Image = CType(resources.GetObject("PBCerrar2.Image"), System.Drawing.Image)
        Me.PBCerrar2.Location = New System.Drawing.Point(711, 7)
        Me.PBCerrar2.Name = "PBCerrar2"
        Me.PBCerrar2.Size = New System.Drawing.Size(24, 24)
        Me.PBCerrar2.TabIndex = 18
        Me.PBCerrar2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Location = New System.Drawing.Point(-3, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(750, 568)
        Me.Panel3.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CBCargoU)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TBDniU)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TBContraseñaU)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 175)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cargo"
        '
        'CBCargoU
        '
        Me.CBCargoU.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCargoU.FormattingEnabled = True
        Me.CBCargoU.Items.AddRange(New Object() {"Administrador/a", "Vendedor/a", "Usuario/a"})
        Me.CBCargoU.Location = New System.Drawing.Point(149, 119)
        Me.CBCargoU.Name = "CBCargoU"
        Me.CBCargoU.Size = New System.Drawing.Size(248, 26)
        Me.CBCargoU.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cargo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario (Dni):"
        '
        'TBDniU
        '
        Me.TBDniU.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDniU.Location = New System.Drawing.Point(149, 26)
        Me.TBDniU.Name = "TBDniU"
        Me.TBDniU.Size = New System.Drawing.Size(248, 24)
        Me.TBDniU.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña:"
        '
        'TBContraseñaU
        '
        Me.TBContraseñaU.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBContraseñaU.Location = New System.Drawing.Point(149, 72)
        Me.TBContraseñaU.Name = "TBContraseñaU"
        Me.TBContraseñaU.Size = New System.Drawing.Size(248, 24)
        Me.TBContraseñaU.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(11, 210)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(423, 338)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Usuario"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(149, 121)
        Me.DateTimePicker1.MinDate = New Date(1960, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(248, 24)
        Me.DateTimePicker1.TabIndex = 14
        Me.DateTimePicker1.Value = New Date(2023, 10, 2, 23, 19, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "F. Nacimiento:"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(149, 301)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(248, 26)
        Me.ComboBox2.TabIndex = 22
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"1. Buenos Aires", "", "2. Catamarca", "", "3. Chaco", "", "4. Chubut", "", "5. Córdoba", "", "6. Corrientes", "", "7. Entre Ríos", "", "8. Formosa", "", "9. Jujuy", "", "10. La Pampa", "", "11. La Rioja", "", "12. Mendoza", "", "13. Misiones", "", "14. Neuquén", "", "15. Río Negro", "", "16. Salta", "", "17. San Juan", "", "18. San Luis", "", "19. Santa Cruz", "", "20. Santa Fe", "", "21. Santiago del Estero", "", "22. Tierra del Fuego, Antártida e Isla del Atlántico Sur", "", "23.  Tucumán"})
        Me.ComboBox3.Location = New System.Drawing.Point(149, 256)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(248, 26)
        Me.ComboBox3.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Ciudad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 18)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Provincia:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Dirección:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(149, 211)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(248, 24)
        Me.TextBox3.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Teléfono:"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(149, 166)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(248, 24)
        Me.TextBox4.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 18)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Apellido:"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(149, 75)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(248, 24)
        Me.TextBox5.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Nombre:"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(149, 32)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(248, 24)
        Me.TextBox6.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(745, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 568)
        Me.Panel4.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 568)
        Me.Panel5.TabIndex = 10
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PnlBotones.Controls.Add(Me.BtnBorrar)
        Me.PnlBotones.Controls.Add(Me.BtnCancelar)
        Me.PnlBotones.Controls.Add(Me.BtnAceptar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBotones.Location = New System.Drawing.Point(0, 588)
        Me.PnlBotones.Name = "PnlBotones"
        Me.PnlBotones.Size = New System.Drawing.Size(747, 62)
        Me.PnlBotones.TabIndex = 24
        '
        'BtnBorrar
        '
        Me.BtnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.ForeColor = System.Drawing.Color.White
        Me.BtnBorrar.Image = CType(resources.GetObject("BtnBorrar.Image"), System.Drawing.Image)
        Me.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrar.Location = New System.Drawing.Point(35, 10)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(115, 42)
        Me.BtnBorrar.TabIndex = 24
        Me.BtnBorrar.Text = "       Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(297, 10)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(115, 42)
        Me.BtnCancelar.TabIndex = 26
        Me.BtnCancelar.Text = "        Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.Image = CType(resources.GetObject("BtnAceptar.Image"), System.Drawing.Image)
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(165, 10)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(115, 42)
        Me.BtnAceptar.TabIndex = 25
        Me.BtnAceptar.Text = "       Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'FormAgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 650)
        Me.Controls.Add(Me.PnlBotones)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PnlBarraTitulo)
        Me.Controls.Add(Me.PnlCentro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAgregarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAgregarUsuario"
        Me.PnlCentro.ResumeLayout(False)
        Me.GBCargo.ResumeLayout(False)
        Me.GBCargo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PnlBarraTitulo.ResumeLayout(False)
        Me.PnlBarraTitulo.PerformLayout()
        CType(Me.PBMinim2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCerrar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.PnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlCentro As Panel
    Friend WithEvents GBCargo As GroupBox
    Friend WithEvents CBCargo As ComboBox
    Friend WithEvents LblCargo As Label
    Friend WithEvents LblUsuarioDni As Label
    Friend WithEvents TBUsuarioDni As TextBox
    Friend WithEvents LblContrasenia As Label
    Friend WithEvents TBContrasenia As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTPFNacimiento As DateTimePicker
    Friend WithEvents LblFechaNacimiento As Label
    Friend WithEvents CBCiudad As ComboBox
    Friend WithEvents CBProvincia As ComboBox
    Friend WithEvents LblCiudad As Label
    Friend WithEvents LblProvincia As Label
    Friend WithEvents LblDireccion As Label
    Friend WithEvents TBDireccion As TextBox
    Friend WithEvents LblTelefono As Label
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents LblApellido As Label
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PnlBarraTitulo As Panel
    Friend WithEvents LblTitulo As Label
    Friend WithEvents PBMinim2 As PictureBox
    Friend WithEvents PBCerrar2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CBCargoU As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBDniU As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBContraseñaU As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PnlBotones As Panel
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
End Class
