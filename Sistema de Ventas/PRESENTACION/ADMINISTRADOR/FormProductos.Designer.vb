<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProductos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlTitulo = New System.Windows.Forms.Panel()
        Me.LblClientes = New System.Windows.Forms.Label()
        Me.GBBuscar = New System.Windows.Forms.GroupBox()
        Me.PBBuscar = New System.Windows.Forms.PictureBox()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.CBCriterio = New System.Windows.Forms.ComboBox()
        Me.LblCriterio = New System.Windows.Forms.Label()
        Me.DGVProductos = New System.Windows.Forms.DataGridView()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_min = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_barra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlBotones = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.PnlTitulo.SuspendLayout()
        Me.GBBuscar.SuspendLayout()
        CType(Me.PBBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PnlTitulo.Size = New System.Drawing.Size(816, 49)
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
        Me.LblClientes.Location = New System.Drawing.Point(266, -4)
        Me.LblClientes.Name = "LblClientes"
        Me.LblClientes.Size = New System.Drawing.Size(174, 39)
        Me.LblClientes.TabIndex = 0
        Me.LblClientes.Text = "Productos"
        '
        'GBBuscar
        '
        Me.GBBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBBuscar.BackColor = System.Drawing.Color.Transparent
        Me.GBBuscar.Controls.Add(Me.PBBuscar)
        Me.GBBuscar.Controls.Add(Me.TBBuscar)
        Me.GBBuscar.Controls.Add(Me.CBCriterio)
        Me.GBBuscar.Controls.Add(Me.LblCriterio)
        Me.GBBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBBuscar.ForeColor = System.Drawing.Color.White
        Me.GBBuscar.Location = New System.Drawing.Point(103, 77)
        Me.GBBuscar.Name = "GBBuscar"
        Me.GBBuscar.Size = New System.Drawing.Size(571, 118)
        Me.GBBuscar.TabIndex = 2
        Me.GBBuscar.TabStop = False
        Me.GBBuscar.Text = "Buscar Producto"
        '
        'PBBuscar
        '
        Me.PBBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBBuscar.Image = CType(resources.GetObject("PBBuscar.Image"), System.Drawing.Image)
        Me.PBBuscar.Location = New System.Drawing.Point(514, 52)
        Me.PBBuscar.Name = "PBBuscar"
        Me.PBBuscar.Size = New System.Drawing.Size(39, 32)
        Me.PBBuscar.TabIndex = 3
        Me.PBBuscar.TabStop = False
        '
        'TBBuscar
        '
        Me.TBBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBuscar.Location = New System.Drawing.Point(319, 50)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(187, 24)
        Me.TBBuscar.TabIndex = 3
        '
        'CBCriterio
        '
        Me.CBCriterio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBCriterio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCriterio.FormattingEnabled = True
        Me.CBCriterio.Items.AddRange(New Object() {"Descripción", "Categoría", "Precio de Costo", "Precio de Venta"})
        Me.CBCriterio.Location = New System.Drawing.Point(106, 50)
        Me.CBCriterio.Name = "CBCriterio"
        Me.CBCriterio.Size = New System.Drawing.Size(190, 26)
        Me.CBCriterio.TabIndex = 2
        '
        'LblCriterio
        '
        Me.LblCriterio.AutoSize = True
        Me.LblCriterio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCriterio.Location = New System.Drawing.Point(23, 54)
        Me.LblCriterio.Name = "LblCriterio"
        Me.LblCriterio.Size = New System.Drawing.Size(60, 18)
        Me.LblCriterio.TabIndex = 1
        Me.LblCriterio.Text = "Criterio:"
        '
        'DGVProductos
        '
        Me.DGVProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(184, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.descripcion, Me.categoria, Me.precio_costo, Me.precio_venta, Me.stock, Me.stock_min, Me.codigo_barra})
        Me.DGVProductos.EnableHeadersVisualStyles = False
        Me.DGVProductos.Location = New System.Drawing.Point(12, 210)
        Me.DGVProductos.Name = "DGVProductos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(184, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVProductos.RowHeadersWidth = 25
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(214, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DGVProductos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVProductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DGVProductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVProductos.Size = New System.Drawing.Size(780, 191)
        Me.DGVProductos.TabIndex = 5
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        '
        'categoria
        '
        Me.categoria.HeaderText = "Categoría"
        Me.categoria.Name = "categoria"
        '
        'precio_costo
        '
        Me.precio_costo.HeaderText = "Precio Costo"
        Me.precio_costo.Name = "precio_costo"
        '
        'precio_venta
        '
        Me.precio_venta.HeaderText = "Precio Venta"
        Me.precio_venta.Name = "precio_venta"
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        '
        'stock_min
        '
        Me.stock_min.HeaderText = "Stock Mínimo"
        Me.stock_min.Name = "stock_min"
        '
        'codigo_barra
        '
        Me.codigo_barra.HeaderText = "Código Barra"
        Me.codigo_barra.Name = "codigo_barra"
        '
        'PnlBotones
        '
        Me.PnlBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlBotones.Controls.Add(Me.BtnEliminar)
        Me.PnlBotones.Controls.Add(Me.BtnEditar)
        Me.PnlBotones.Controls.Add(Me.BtnAgregar)
        Me.PnlBotones.Location = New System.Drawing.Point(5, 407)
        Me.PnlBotones.Name = "PnlBotones"
        Me.PnlBotones.Size = New System.Drawing.Size(811, 72)
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
        Me.BtnEliminar.Location = New System.Drawing.Point(575, 11)
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
        Me.BtnEditar.Location = New System.Drawing.Point(329, 11)
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
        Me.BtnAgregar.Location = New System.Drawing.Point(96, 11)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(115, 42)
        Me.BtnAgregar.TabIndex = 6
        Me.BtnAgregar.Text = "       Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(816, 489)
        Me.Controls.Add(Me.PnlBotones)
        Me.Controls.Add(Me.DGVProductos)
        Me.Controls.Add(Me.GBBuscar)
        Me.Controls.Add(Me.PnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProductos"
        Me.PnlTitulo.ResumeLayout(False)
        Me.PnlTitulo.PerformLayout()
        Me.GBBuscar.ResumeLayout(False)
        Me.GBBuscar.PerformLayout()
        CType(Me.PBBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitulo As Panel
    Friend WithEvents LblClientes As Label
    Friend WithEvents GBBuscar As GroupBox
    Friend WithEvents PBBuscar As PictureBox
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents CBCriterio As ComboBox
    Friend WithEvents LblCriterio As Label
    Friend WithEvents DGVProductos As DataGridView
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
    Friend WithEvents precio_costo As DataGridViewTextBoxColumn
    Friend WithEvents precio_venta As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents stock_min As DataGridViewTextBoxColumn
    Friend WithEvents codigo_barra As DataGridViewTextBoxColumn
    Friend WithEvents PnlBotones As Panel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAgregar As Button
End Class
