<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsuario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlTitulo = New System.Windows.Forms.Panel()
        Me.LblClientes = New System.Windows.Forms.Label()
        Me.GBBuscar = New System.Windows.Forms.GroupBox()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.LblCriterio = New System.Windows.Forms.Label()
        Me.CBCriterio = New System.Windows.Forms.ComboBox()
        Me.PBBuscar = New System.Windows.Forms.PictureBox()
        Me.DGVUsuarios = New System.Windows.Forms.DataGridView()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_postal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlBotones = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.PnlTitulo.SuspendLayout()
        Me.GBBuscar.SuspendLayout()
        CType(Me.PBBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlTitulo
        '
        Me.PnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlTitulo.Controls.Add(Me.LblClientes)
        Me.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitulo.Name = "PnlTitulo"
        Me.PnlTitulo.Size = New System.Drawing.Size(935, 49)
        Me.PnlTitulo.TabIndex = 1
        '
        'LblClientes
        '
        Me.LblClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblClientes.AutoSize = True
        Me.LblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClientes.ForeColor = System.Drawing.Color.White
        Me.LblClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblClientes.Location = New System.Drawing.Point(417, 0)
        Me.LblClientes.Name = "LblClientes"
        Me.LblClientes.Size = New System.Drawing.Size(155, 39)
        Me.LblClientes.TabIndex = 0
        Me.LblClientes.Text = "Usuarios"
        '
        'GBBuscar
        '
        Me.GBBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBBuscar.BackColor = System.Drawing.Color.Transparent
        Me.GBBuscar.BackgroundImage = CType(resources.GetObject("GBBuscar.BackgroundImage"), System.Drawing.Image)
        Me.GBBuscar.Controls.Add(Me.TBBuscar)
        Me.GBBuscar.Controls.Add(Me.LblCriterio)
        Me.GBBuscar.Controls.Add(Me.CBCriterio)
        Me.GBBuscar.Controls.Add(Me.PBBuscar)
        Me.GBBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBBuscar.ForeColor = System.Drawing.Color.White
        Me.GBBuscar.Location = New System.Drawing.Point(0, 55)
        Me.GBBuscar.Name = "GBBuscar"
        Me.GBBuscar.Size = New System.Drawing.Size(911, 118)
        Me.GBBuscar.TabIndex = 2
        Me.GBBuscar.TabStop = False
        Me.GBBuscar.Text = "Buscar Usuario:"
        '
        'TBBuscar
        '
        Me.TBBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBuscar.Location = New System.Drawing.Point(633, 50)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(190, 24)
        Me.TBBuscar.TabIndex = 3
        '
        'LblCriterio
        '
        Me.LblCriterio.AutoSize = True
        Me.LblCriterio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCriterio.Location = New System.Drawing.Point(30, 58)
        Me.LblCriterio.Name = "LblCriterio"
        Me.LblCriterio.Size = New System.Drawing.Size(60, 18)
        Me.LblCriterio.TabIndex = 1
        Me.LblCriterio.Text = "Criterio:"
        '
        'CBCriterio
        '
        Me.CBCriterio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBCriterio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCriterio.FormattingEnabled = True
        Me.CBCriterio.Items.AddRange(New Object() {"Usuario (Dni)", "Cargo", "Nombre", "Apellido"})
        Me.CBCriterio.Location = New System.Drawing.Point(118, 50)
        Me.CBCriterio.Name = "CBCriterio"
        Me.CBCriterio.Size = New System.Drawing.Size(497, 26)
        Me.CBCriterio.TabIndex = 2
        '
        'PBBuscar
        '
        Me.PBBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBBuscar.Image = CType(resources.GetObject("PBBuscar.Image"), System.Drawing.Image)
        Me.PBBuscar.Location = New System.Drawing.Point(841, 50)
        Me.PBBuscar.Name = "PBBuscar"
        Me.PBBuscar.Size = New System.Drawing.Size(39, 32)
        Me.PBBuscar.TabIndex = 3
        Me.PBBuscar.TabStop = False
        '
        'DGVUsuarios
        '
        Me.DGVUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(184, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dni, Me.codigo_postal, Me.cargo, Me.nombre, Me.apellido, Me.fecha_nac, Me.telefono, Me.direccion, Me.provincia, Me.ciudad})
        Me.DGVUsuarios.EnableHeadersVisualStyles = False
        Me.DGVUsuarios.Location = New System.Drawing.Point(0, 198)
        Me.DGVUsuarios.Name = "DGVUsuarios"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(184, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVUsuarios.RowHeadersWidth = 25
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(214, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DGVUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVUsuarios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DGVUsuarios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVUsuarios.Size = New System.Drawing.Size(999, 200)
        Me.DGVUsuarios.TabIndex = 5
        '
        'dni
        '
        Me.dni.HeaderText = "Usuario (Dni)"
        Me.dni.Name = "dni"
        '
        'codigo_postal
        '
        Me.codigo_postal.HeaderText = "Contraseña"
        Me.codigo_postal.Name = "codigo_postal"
        '
        'cargo
        '
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.Name = "cargo"
        '
        'nombre
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        '
        'fecha_nac
        '
        Me.fecha_nac.HeaderText = "Fecha Nac."
        Me.fecha_nac.Name = "fecha_nac"
        '
        'telefono
        '
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.Name = "telefono"
        '
        'direccion
        '
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        '
        'provincia
        '
        Me.provincia.HeaderText = "Provincia"
        Me.provincia.Name = "provincia"
        '
        'ciudad
        '
        Me.ciudad.HeaderText = "Ciudad"
        Me.ciudad.Name = "ciudad"
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlBotones.Controls.Add(Me.BtnEliminar)
        Me.PnlBotones.Controls.Add(Me.BtnEditar)
        Me.PnlBotones.Controls.Add(Me.BtnAgregar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBotones.Location = New System.Drawing.Point(0, 389)
        Me.PnlBotones.Name = "PnlBotones"
        Me.PnlBotones.Size = New System.Drawing.Size(935, 61)
        Me.PnlBotones.TabIndex = 6
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(727, 5)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(115, 42)
        Me.BtnEliminar.TabIndex = 8
        Me.BtnEliminar.Text = "       Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(424, 5)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(115, 42)
        Me.BtnEditar.TabIndex = 7
        Me.BtnEditar.Text = "       Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.Location = New System.Drawing.Point(116, 5)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(115, 42)
        Me.BtnAgregar.TabIndex = 6
        Me.BtnAgregar.Text = "       Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'FormUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(935, 450)
        Me.Controls.Add(Me.PnlBotones)
        Me.Controls.Add(Me.DGVUsuarios)
        Me.Controls.Add(Me.GBBuscar)
        Me.Controls.Add(Me.PnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUsuarios"
        Me.PnlTitulo.ResumeLayout(False)
        Me.PnlTitulo.PerformLayout()
        Me.GBBuscar.ResumeLayout(False)
        Me.GBBuscar.PerformLayout()
        CType(Me.PBBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitulo As Panel
    Friend WithEvents LblClientes As Label
    Friend WithEvents GBBuscar As GroupBox
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents LblCriterio As Label
    Friend WithEvents CBCriterio As ComboBox
    Friend WithEvents PBBuscar As PictureBox
    Friend WithEvents DGVUsuarios As DataGridView
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents codigo_postal As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents fecha_nac As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents provincia As DataGridViewTextBoxColumn
    Friend WithEvents ciudad As DataGridViewTextBoxColumn
    Friend WithEvents PnlBotones As Panel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAgregar As Button
End Class
