<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgregarProducto))
        Me.PnlBarraTitulo = New System.Windows.Forms.Panel()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.PBMinim2 = New System.Windows.Forms.PictureBox()
        Me.PBCerrar2 = New System.Windows.Forms.PictureBox()
        Me.PnlCentro = New System.Windows.Forms.Panel()
        Me.PnlBotones = New System.Windows.Forms.Panel()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.CBCategoria = New System.Windows.Forms.ComboBox()
        Me.LblCodBarra = New System.Windows.Forms.Label()
        Me.TBCodigoBarra = New System.Windows.Forms.TextBox()
        Me.LblStockMinimo = New System.Windows.Forms.Label()
        Me.TBStockMinimo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.LblPrecioVenta = New System.Windows.Forms.Label()
        Me.TBPrecioVenta = New System.Windows.Forms.TextBox()
        Me.LblPrecioCosto = New System.Windows.Forms.Label()
        Me.TBPrecioCosto = New System.Windows.Forms.TextBox()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.LblDescripción = New System.Windows.Forms.Label()
        Me.TBDescripcion = New System.Windows.Forms.TextBox()
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
        Me.PnlBarraTitulo.Size = New System.Drawing.Size(788, 38)
        Me.PnlBarraTitulo.TabIndex = 1
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(4, 4)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(159, 24)
        Me.LblTitulo.TabIndex = 20
        Me.LblTitulo.Text = "Agregar Producto"
        '
        'PBMinim2
        '
        Me.PBMinim2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBMinim2.Image = CType(resources.GetObject("PBMinim2.Image"), System.Drawing.Image)
        Me.PBMinim2.Location = New System.Drawing.Point(722, 8)
        Me.PBMinim2.Name = "PBMinim2"
        Me.PBMinim2.Size = New System.Drawing.Size(24, 24)
        Me.PBMinim2.TabIndex = 19
        Me.PBMinim2.TabStop = False
        '
        'PBCerrar2
        '
        Me.PBCerrar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBCerrar2.Image = CType(resources.GetObject("PBCerrar2.Image"), System.Drawing.Image)
        Me.PBCerrar2.Location = New System.Drawing.Point(752, 7)
        Me.PBCerrar2.Name = "PBCerrar2"
        Me.PBCerrar2.Size = New System.Drawing.Size(24, 24)
        Me.PBCerrar2.TabIndex = 18
        Me.PBCerrar2.TabStop = False
        '
        'PnlCentro
        '
        Me.PnlCentro.BackColor = System.Drawing.Color.Transparent
        Me.PnlCentro.BackgroundImage = CType(resources.GetObject("PnlCentro.BackgroundImage"), System.Drawing.Image)
        Me.PnlCentro.Controls.Add(Me.PnlBotones)
        Me.PnlCentro.Controls.Add(Me.CBCategoria)
        Me.PnlCentro.Controls.Add(Me.LblCodBarra)
        Me.PnlCentro.Controls.Add(Me.TBCodigoBarra)
        Me.PnlCentro.Controls.Add(Me.LblStockMinimo)
        Me.PnlCentro.Controls.Add(Me.TBStockMinimo)
        Me.PnlCentro.Controls.Add(Me.Panel2)
        Me.PnlCentro.Controls.Add(Me.Panel1)
        Me.PnlCentro.Controls.Add(Me.LblStock)
        Me.PnlCentro.Controls.Add(Me.TBStock)
        Me.PnlCentro.Controls.Add(Me.LblPrecioVenta)
        Me.PnlCentro.Controls.Add(Me.TBPrecioVenta)
        Me.PnlCentro.Controls.Add(Me.LblPrecioCosto)
        Me.PnlCentro.Controls.Add(Me.TBPrecioCosto)
        Me.PnlCentro.Controls.Add(Me.LblCategoria)
        Me.PnlCentro.Controls.Add(Me.LblDescripción)
        Me.PnlCentro.Controls.Add(Me.TBDescripcion)
        Me.PnlCentro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlCentro.Location = New System.Drawing.Point(0, 38)
        Me.PnlCentro.Name = "PnlCentro"
        Me.PnlCentro.Size = New System.Drawing.Size(788, 477)
        Me.PnlCentro.TabIndex = 2
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PnlBotones.Controls.Add(Me.BtnBorrar)
        Me.PnlBotones.Controls.Add(Me.BtnCancelar)
        Me.PnlBotones.Controls.Add(Me.BtnAgregar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBotones.Location = New System.Drawing.Point(5, 415)
        Me.PnlBotones.Name = "PnlBotones"
        Me.PnlBotones.Size = New System.Drawing.Size(778, 62)
        Me.PnlBotones.TabIndex = 16
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
        Me.BtnBorrar.TabIndex = 16
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
        Me.BtnCancelar.Location = New System.Drawing.Point(524, 10)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(115, 42)
        Me.BtnCancelar.TabIndex = 18
        Me.BtnCancelar.Text = "        Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.Location = New System.Drawing.Point(273, 3)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(115, 42)
        Me.BtnAgregar.TabIndex = 17
        Me.BtnAgregar.Text = "       Aceptar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'CBCategoria
        '
        Me.CBCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCategoria.FormattingEnabled = True
        Me.CBCategoria.Items.AddRange(New Object() {"Almacenamiento", "Hardware", "Perifericos"})
        Me.CBCategoria.Location = New System.Drawing.Point(174, 78)
        Me.CBCategoria.Name = "CBCategoria"
        Me.CBCategoria.Size = New System.Drawing.Size(248, 26)
        Me.CBCategoria.TabIndex = 4
        '
        'LblCodBarra
        '
        Me.LblCodBarra.AutoSize = True
        Me.LblCodBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodBarra.ForeColor = System.Drawing.Color.White
        Me.LblCodBarra.Location = New System.Drawing.Point(24, 363)
        Me.LblCodBarra.Name = "LblCodBarra"
        Me.LblCodBarra.Size = New System.Drawing.Size(128, 18)
        Me.LblCodBarra.TabIndex = 13
        Me.LblCodBarra.Text = "Código de Barras:"
        '
        'TBCodigoBarra
        '
        Me.TBCodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCodigoBarra.Location = New System.Drawing.Point(174, 353)
        Me.TBCodigoBarra.Name = "TBCodigoBarra"
        Me.TBCodigoBarra.Size = New System.Drawing.Size(248, 24)
        Me.TBCodigoBarra.TabIndex = 14
        '
        'LblStockMinimo
        '
        Me.LblStockMinimo.AutoSize = True
        Me.LblStockMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStockMinimo.ForeColor = System.Drawing.Color.White
        Me.LblStockMinimo.Location = New System.Drawing.Point(24, 309)
        Me.LblStockMinimo.Name = "LblStockMinimo"
        Me.LblStockMinimo.Size = New System.Drawing.Size(104, 18)
        Me.LblStockMinimo.TabIndex = 11
        Me.LblStockMinimo.Text = "Stock Mínimo:"
        '
        'TBStockMinimo
        '
        Me.TBStockMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBStockMinimo.Location = New System.Drawing.Point(174, 299)
        Me.TBStockMinimo.Name = "TBStockMinimo"
        Me.TBStockMinimo.Size = New System.Drawing.Size(248, 24)
        Me.TBStockMinimo.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(783, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 477)
        Me.Panel2.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 477)
        Me.Panel1.TabIndex = 10
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStock.ForeColor = System.Drawing.Color.White
        Me.LblStock.Location = New System.Drawing.Point(24, 253)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(51, 18)
        Me.LblStock.TabIndex = 9
        Me.LblStock.Text = "Stock:"
        '
        'TBStock
        '
        Me.TBStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBStock.Location = New System.Drawing.Point(174, 243)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(248, 24)
        Me.TBStock.TabIndex = 10
        '
        'LblPrecioVenta
        '
        Me.LblPrecioVenta.AutoSize = True
        Me.LblPrecioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioVenta.ForeColor = System.Drawing.Color.White
        Me.LblPrecioVenta.Location = New System.Drawing.Point(24, 197)
        Me.LblPrecioVenta.Name = "LblPrecioVenta"
        Me.LblPrecioVenta.Size = New System.Drawing.Size(116, 18)
        Me.LblPrecioVenta.TabIndex = 7
        Me.LblPrecioVenta.Text = "Precio de Venta:"
        '
        'TBPrecioVenta
        '
        Me.TBPrecioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPrecioVenta.Location = New System.Drawing.Point(174, 187)
        Me.TBPrecioVenta.Name = "TBPrecioVenta"
        Me.TBPrecioVenta.Size = New System.Drawing.Size(248, 24)
        Me.TBPrecioVenta.TabIndex = 8
        '
        'LblPrecioCosto
        '
        Me.LblPrecioCosto.AutoSize = True
        Me.LblPrecioCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioCosto.ForeColor = System.Drawing.Color.White
        Me.LblPrecioCosto.Location = New System.Drawing.Point(24, 141)
        Me.LblPrecioCosto.Name = "LblPrecioCosto"
        Me.LblPrecioCosto.Size = New System.Drawing.Size(120, 18)
        Me.LblPrecioCosto.TabIndex = 5
        Me.LblPrecioCosto.Text = "Precio de Costo:"
        '
        'TBPrecioCosto
        '
        Me.TBPrecioCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPrecioCosto.Location = New System.Drawing.Point(174, 131)
        Me.TBPrecioCosto.Name = "TBPrecioCosto"
        Me.TBPrecioCosto.Size = New System.Drawing.Size(248, 24)
        Me.TBPrecioCosto.TabIndex = 6
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategoria.ForeColor = System.Drawing.Color.White
        Me.LblCategoria.Location = New System.Drawing.Point(24, 86)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(76, 18)
        Me.LblCategoria.TabIndex = 3
        Me.LblCategoria.Text = "Categoría:"
        '
        'LblDescripción
        '
        Me.LblDescripción.AutoSize = True
        Me.LblDescripción.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripción.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripción.ForeColor = System.Drawing.Color.White
        Me.LblDescripción.Location = New System.Drawing.Point(24, 34)
        Me.LblDescripción.Name = "LblDescripción"
        Me.LblDescripción.Size = New System.Drawing.Size(91, 18)
        Me.LblDescripción.TabIndex = 1
        Me.LblDescripción.Text = "Descripción:"
        '
        'TBDescripcion
        '
        Me.TBDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDescripcion.Location = New System.Drawing.Point(174, 24)
        Me.TBDescripcion.Name = "TBDescripcion"
        Me.TBDescripcion.Size = New System.Drawing.Size(248, 24)
        Me.TBDescripcion.TabIndex = 2
        '
        'FormAgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 515)
        Me.Controls.Add(Me.PnlCentro)
        Me.Controls.Add(Me.PnlBarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAgregarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAgregarProducto"
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
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents CBCategoria As ComboBox
    Friend WithEvents LblCodBarra As Label
    Friend WithEvents TBCodigoBarra As TextBox
    Friend WithEvents LblStockMinimo As Label
    Friend WithEvents TBStockMinimo As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblStock As Label
    Friend WithEvents TBStock As TextBox
    Friend WithEvents LblPrecioVenta As Label
    Friend WithEvents TBPrecioVenta As TextBox
    Friend WithEvents LblPrecioCosto As Label
    Friend WithEvents TBPrecioCosto As TextBox
    Friend WithEvents LblCategoria As Label
    Friend WithEvents LblDescripción As Label
    Friend WithEvents TBDescripcion As TextBox
End Class
