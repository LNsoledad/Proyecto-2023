<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditarProducto))
        Me.PnlBarraTitulo = New System.Windows.Forms.Panel()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.PBMinim2 = New System.Windows.Forms.PictureBox()
        Me.PBCerrar2 = New System.Windows.Forms.PictureBox()
        Me.PnlCentro = New System.Windows.Forms.Panel()
        Me.PnlBotones = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.CBCategoria = New System.Windows.Forms.ComboBox()
        Me.LblCBarra = New System.Windows.Forms.Label()
        Me.TBCBarra = New System.Windows.Forms.TextBox()
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
        Me.LblDescripcion = New System.Windows.Forms.Label()
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
        Me.PnlBarraTitulo.Size = New System.Drawing.Size(791, 38)
        Me.PnlBarraTitulo.TabIndex = 1
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(4, 4)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(139, 24)
        Me.LblTitulo.TabIndex = 20
        Me.LblTitulo.Text = "Editar Producto"
        '
        'PBMinim2
        '
        Me.PBMinim2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBMinim2.Image = CType(resources.GetObject("PBMinim2.Image"), System.Drawing.Image)
        Me.PBMinim2.Location = New System.Drawing.Point(725, 8)
        Me.PBMinim2.Name = "PBMinim2"
        Me.PBMinim2.Size = New System.Drawing.Size(24, 24)
        Me.PBMinim2.TabIndex = 19
        Me.PBMinim2.TabStop = False
        '
        'PBCerrar2
        '
        Me.PBCerrar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBCerrar2.Image = CType(resources.GetObject("PBCerrar2.Image"), System.Drawing.Image)
        Me.PBCerrar2.Location = New System.Drawing.Point(755, 7)
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
        Me.PnlCentro.Controls.Add(Me.LblCBarra)
        Me.PnlCentro.Controls.Add(Me.TBCBarra)
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
        Me.PnlCentro.Controls.Add(Me.LblDescripcion)
        Me.PnlCentro.Controls.Add(Me.TBDescripcion)
        Me.PnlCentro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlCentro.Location = New System.Drawing.Point(0, 38)
        Me.PnlCentro.Name = "PnlCentro"
        Me.PnlCentro.Size = New System.Drawing.Size(791, 482)
        Me.PnlCentro.TabIndex = 2
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PnlBotones.Controls.Add(Me.BtnCancelar)
        Me.PnlBotones.Controls.Add(Me.BtnAceptar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBotones.Location = New System.Drawing.Point(5, 420)
        Me.PnlBotones.Name = "PnlBotones"
        Me.PnlBotones.Size = New System.Drawing.Size(781, 62)
        Me.PnlBotones.TabIndex = 16
        '
        'BtnCancelar
        '
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(460, 10)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(115, 42)
        Me.BtnCancelar.TabIndex = 17
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
        Me.BtnAceptar.Location = New System.Drawing.Point(92, 10)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(115, 42)
        Me.BtnAceptar.TabIndex = 16
        Me.BtnAceptar.Text = "       Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'CBCategoria
        '
        Me.CBCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCategoria.FormattingEnabled = True
        Me.CBCategoria.Items.AddRange(New Object() {"Almacenamiento", "Hardware", "Perifericos"})
        Me.CBCategoria.Location = New System.Drawing.Point(175, 71)
        Me.CBCategoria.Name = "CBCategoria"
        Me.CBCategoria.Size = New System.Drawing.Size(248, 26)
        Me.CBCategoria.TabIndex = 4
        '
        'LblCBarra
        '
        Me.LblCBarra.AutoSize = True
        Me.LblCBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCBarra.ForeColor = System.Drawing.Color.White
        Me.LblCBarra.Location = New System.Drawing.Point(24, 379)
        Me.LblCBarra.Name = "LblCBarra"
        Me.LblCBarra.Size = New System.Drawing.Size(120, 18)
        Me.LblCBarra.TabIndex = 13
        Me.LblCBarra.Text = "Código de Barra:"
        '
        'TBCBarra
        '
        Me.TBCBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCBarra.Location = New System.Drawing.Point(175, 371)
        Me.TBCBarra.Name = "TBCBarra"
        Me.TBCBarra.Size = New System.Drawing.Size(248, 24)
        Me.TBCBarra.TabIndex = 14
        '
        'LblStockMinimo
        '
        Me.LblStockMinimo.AutoSize = True
        Me.LblStockMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStockMinimo.ForeColor = System.Drawing.Color.White
        Me.LblStockMinimo.Location = New System.Drawing.Point(24, 319)
        Me.LblStockMinimo.Name = "LblStockMinimo"
        Me.LblStockMinimo.Size = New System.Drawing.Size(104, 18)
        Me.LblStockMinimo.TabIndex = 11
        Me.LblStockMinimo.Text = "Stock Mínimo:"
        '
        'TBStockMinimo
        '
        Me.TBStockMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBStockMinimo.Location = New System.Drawing.Point(175, 311)
        Me.TBStockMinimo.Name = "TBStockMinimo"
        Me.TBStockMinimo.Size = New System.Drawing.Size(248, 24)
        Me.TBStockMinimo.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(786, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 482)
        Me.Panel2.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 482)
        Me.Panel1.TabIndex = 10
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStock.ForeColor = System.Drawing.Color.White
        Me.LblStock.Location = New System.Drawing.Point(24, 259)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(51, 18)
        Me.LblStock.TabIndex = 9
        Me.LblStock.Text = "Stock:"
        '
        'TBStock
        '
        Me.TBStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBStock.Location = New System.Drawing.Point(175, 251)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(248, 24)
        Me.TBStock.TabIndex = 10
        '
        'LblPrecioVenta
        '
        Me.LblPrecioVenta.AutoSize = True
        Me.LblPrecioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioVenta.ForeColor = System.Drawing.Color.White
        Me.LblPrecioVenta.Location = New System.Drawing.Point(24, 199)
        Me.LblPrecioVenta.Name = "LblPrecioVenta"
        Me.LblPrecioVenta.Size = New System.Drawing.Size(116, 18)
        Me.LblPrecioVenta.TabIndex = 7
        Me.LblPrecioVenta.Text = "Precio de Venta:"
        '
        'TBPrecioVenta
        '
        Me.TBPrecioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPrecioVenta.Location = New System.Drawing.Point(175, 191)
        Me.TBPrecioVenta.Name = "TBPrecioVenta"
        Me.TBPrecioVenta.Size = New System.Drawing.Size(248, 24)
        Me.TBPrecioVenta.TabIndex = 8
        '
        'LblPrecioCosto
        '
        Me.LblPrecioCosto.AutoSize = True
        Me.LblPrecioCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioCosto.ForeColor = System.Drawing.Color.White
        Me.LblPrecioCosto.Location = New System.Drawing.Point(24, 139)
        Me.LblPrecioCosto.Name = "LblPrecioCosto"
        Me.LblPrecioCosto.Size = New System.Drawing.Size(120, 18)
        Me.LblPrecioCosto.TabIndex = 5
        Me.LblPrecioCosto.Text = "Precio de Costo:"
        '
        'TBPrecioCosto
        '
        Me.TBPrecioCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPrecioCosto.Location = New System.Drawing.Point(175, 131)
        Me.TBPrecioCosto.Name = "TBPrecioCosto"
        Me.TBPrecioCosto.Size = New System.Drawing.Size(248, 24)
        Me.TBPrecioCosto.TabIndex = 6
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategoria.ForeColor = System.Drawing.Color.White
        Me.LblCategoria.Location = New System.Drawing.Point(24, 79)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(76, 18)
        Me.LblCategoria.TabIndex = 3
        Me.LblCategoria.Text = "Categoría:"
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.ForeColor = System.Drawing.Color.White
        Me.LblDescripcion.Location = New System.Drawing.Point(24, 19)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(91, 18)
        Me.LblDescripcion.TabIndex = 1
        Me.LblDescripcion.Text = "Descripción:"
        '
        'TBDescripcion
        '
        Me.TBDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDescripcion.Location = New System.Drawing.Point(175, 11)
        Me.TBDescripcion.Name = "TBDescripcion"
        Me.TBDescripcion.Size = New System.Drawing.Size(248, 24)
        Me.TBDescripcion.TabIndex = 2
        '
        'FormEditarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 520)
        Me.Controls.Add(Me.PnlCentro)
        Me.Controls.Add(Me.PnlBarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEditarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEditarProducto"
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
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents CBCategoria As ComboBox
    Friend WithEvents LblCBarra As Label
    Friend WithEvents TBCBarra As TextBox
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
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents TBDescripcion As TextBox
End Class
