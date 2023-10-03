<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportes))
        Me.PnlBarraTitulo = New System.Windows.Forms.Panel()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.PBMinim2 = New System.Windows.Forms.PictureBox()
        Me.PBCerrar2 = New System.Windows.Forms.PictureBox()
        Me.BtnMejorVendTurno = New System.Windows.Forms.Button()
        Me.BtnVentaDiaria = New System.Windows.Forms.Button()
        Me.btnMOV_ANUAL_ART = New System.Windows.Forms.Button()
        Me.btnClientesMonto = New System.Windows.Forms.Button()
        Me.btnClientesCantidad = New System.Windows.Forms.Button()
        Me.btnProdMasVendFecha = New System.Windows.Forms.Button()
        Me.btnProdMasVendMarca = New System.Windows.Forms.Button()
        Me.btnProdMasVendCat = New System.Windows.Forms.Button()
        Me.BtnProductoNoVendido = New System.Windows.Forms.Button()
        Me.BtnMejorVendFecha = New System.Windows.Forms.Button()
        Me.btnIFactura = New System.Windows.Forms.Button()
        Me.PnlBarraTitulo.SuspendLayout()
        CType(Me.PBMinim2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCerrar2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PnlBarraTitulo.Size = New System.Drawing.Size(800, 38)
        Me.PnlBarraTitulo.TabIndex = 1
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(12, 8)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(86, 24)
        Me.LblTitulo.TabIndex = 20
        Me.LblTitulo.Text = "Reportes"
        '
        'PBMinim2
        '
        Me.PBMinim2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBMinim2.Image = CType(resources.GetObject("PBMinim2.Image"), System.Drawing.Image)
        Me.PBMinim2.Location = New System.Drawing.Point(734, 8)
        Me.PBMinim2.Name = "PBMinim2"
        Me.PBMinim2.Size = New System.Drawing.Size(24, 24)
        Me.PBMinim2.TabIndex = 19
        Me.PBMinim2.TabStop = False
        '
        'PBCerrar2
        '
        Me.PBCerrar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBCerrar2.Image = CType(resources.GetObject("PBCerrar2.Image"), System.Drawing.Image)
        Me.PBCerrar2.Location = New System.Drawing.Point(764, 7)
        Me.PBCerrar2.Name = "PBCerrar2"
        Me.PBCerrar2.Size = New System.Drawing.Size(24, 24)
        Me.PBCerrar2.TabIndex = 18
        Me.PBCerrar2.TabStop = False
        '
        'BtnMejorVendTurno
        '
        Me.BtnMejorVendTurno.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnMejorVendTurno.FlatAppearance.BorderSize = 0
        Me.BtnMejorVendTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMejorVendTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMejorVendTurno.Location = New System.Drawing.Point(544, 299)
        Me.BtnMejorVendTurno.Name = "BtnMejorVendTurno"
        Me.BtnMejorVendTurno.Size = New System.Drawing.Size(223, 41)
        Me.BtnMejorVendTurno.TabIndex = 111
        Me.BtnMejorVendTurno.Text = "Ranking de Vendedores por turno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnMejorVendTurno.UseVisualStyleBackColor = False
        '
        'BtnVentaDiaria
        '
        Me.BtnVentaDiaria.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnVentaDiaria.FlatAppearance.BorderSize = 0
        Me.BtnVentaDiaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentaDiaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentaDiaria.Location = New System.Drawing.Point(287, 299)
        Me.BtnVentaDiaria.Name = "BtnVentaDiaria"
        Me.BtnVentaDiaria.Size = New System.Drawing.Size(223, 40)
        Me.BtnVentaDiaria.TabIndex = 110
        Me.BtnVentaDiaria.Text = "Resumen de Venta Diaria"
        Me.BtnVentaDiaria.UseVisualStyleBackColor = False
        '
        'btnMOV_ANUAL_ART
        '
        Me.btnMOV_ANUAL_ART.BackColor = System.Drawing.Color.PaleGreen
        Me.btnMOV_ANUAL_ART.FlatAppearance.BorderSize = 0
        Me.btnMOV_ANUAL_ART.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMOV_ANUAL_ART.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMOV_ANUAL_ART.Location = New System.Drawing.Point(33, 110)
        Me.btnMOV_ANUAL_ART.Name = "btnMOV_ANUAL_ART"
        Me.btnMOV_ANUAL_ART.Size = New System.Drawing.Size(219, 40)
        Me.btnMOV_ANUAL_ART.TabIndex = 109
        Me.btnMOV_ANUAL_ART.Text = "Comportamiento Anual de Artic."
        Me.btnMOV_ANUAL_ART.UseVisualStyleBackColor = False
        '
        'btnClientesMonto
        '
        Me.btnClientesMonto.BackColor = System.Drawing.Color.PaleGreen
        Me.btnClientesMonto.FlatAppearance.BorderSize = 0
        Me.btnClientesMonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientesMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientesMonto.Location = New System.Drawing.Point(544, 110)
        Me.btnClientesMonto.Name = "btnClientesMonto"
        Me.btnClientesMonto.Size = New System.Drawing.Size(223, 40)
        Me.btnClientesMonto.TabIndex = 108
        Me.btnClientesMonto.Text = "Ranking Clientes por Monto Acumulado"
        Me.btnClientesMonto.UseVisualStyleBackColor = False
        '
        'btnClientesCantidad
        '
        Me.btnClientesCantidad.BackColor = System.Drawing.Color.PaleGreen
        Me.btnClientesCantidad.FlatAppearance.BorderSize = 0
        Me.btnClientesCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientesCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientesCantidad.Location = New System.Drawing.Point(544, 175)
        Me.btnClientesCantidad.Name = "btnClientesCantidad"
        Me.btnClientesCantidad.Size = New System.Drawing.Size(223, 40)
        Me.btnClientesCantidad.TabIndex = 107
        Me.btnClientesCantidad.Text = "Ranking Clientes por Cantidad Compras"
        Me.btnClientesCantidad.UseVisualStyleBackColor = False
        '
        'btnProdMasVendFecha
        '
        Me.btnProdMasVendFecha.BackColor = System.Drawing.Color.PaleGreen
        Me.btnProdMasVendFecha.FlatAppearance.BorderSize = 0
        Me.btnProdMasVendFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdMasVendFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdMasVendFecha.Location = New System.Drawing.Point(293, 110)
        Me.btnProdMasVendFecha.Name = "btnProdMasVendFecha"
        Me.btnProdMasVendFecha.Size = New System.Drawing.Size(217, 40)
        Me.btnProdMasVendFecha.TabIndex = 106
        Me.btnProdMasVendFecha.Text = "Ranking de productos mas vendidos por fecha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnProdMasVendFecha.UseVisualStyleBackColor = False
        '
        'btnProdMasVendMarca
        '
        Me.btnProdMasVendMarca.BackColor = System.Drawing.Color.PaleGreen
        Me.btnProdMasVendMarca.FlatAppearance.BorderSize = 0
        Me.btnProdMasVendMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdMasVendMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdMasVendMarca.Location = New System.Drawing.Point(293, 237)
        Me.btnProdMasVendMarca.Name = "btnProdMasVendMarca"
        Me.btnProdMasVendMarca.Size = New System.Drawing.Size(217, 40)
        Me.btnProdMasVendMarca.TabIndex = 105
        Me.btnProdMasVendMarca.Text = "Ranking de productos mas vendidos por Marca"
        Me.btnProdMasVendMarca.UseVisualStyleBackColor = False
        '
        'btnProdMasVendCat
        '
        Me.btnProdMasVendCat.BackColor = System.Drawing.Color.PaleGreen
        Me.btnProdMasVendCat.FlatAppearance.BorderSize = 0
        Me.btnProdMasVendCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdMasVendCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdMasVendCat.Location = New System.Drawing.Point(293, 175)
        Me.btnProdMasVendCat.Name = "btnProdMasVendCat"
        Me.btnProdMasVendCat.Size = New System.Drawing.Size(217, 41)
        Me.btnProdMasVendCat.TabIndex = 104
        Me.btnProdMasVendCat.Text = "Ranking de productos mas vendidos por Categoria"
        Me.btnProdMasVendCat.UseVisualStyleBackColor = False
        '
        'BtnProductoNoVendido
        '
        Me.BtnProductoNoVendido.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnProductoNoVendido.FlatAppearance.BorderSize = 0
        Me.BtnProductoNoVendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductoNoVendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductoNoVendido.Location = New System.Drawing.Point(33, 237)
        Me.BtnProductoNoVendido.Name = "BtnProductoNoVendido"
        Me.BtnProductoNoVendido.Size = New System.Drawing.Size(219, 41)
        Me.BtnProductoNoVendido.TabIndex = 103
        Me.BtnProductoNoVendido.Text = "Productos No Vendidos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnProductoNoVendido.UseVisualStyleBackColor = False
        '
        'BtnMejorVendFecha
        '
        Me.BtnMejorVendFecha.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnMejorVendFecha.FlatAppearance.BorderSize = 0
        Me.BtnMejorVendFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMejorVendFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMejorVendFecha.Location = New System.Drawing.Point(544, 236)
        Me.BtnMejorVendFecha.Name = "BtnMejorVendFecha"
        Me.BtnMejorVendFecha.Size = New System.Drawing.Size(223, 41)
        Me.BtnMejorVendFecha.TabIndex = 102
        Me.BtnMejorVendFecha.Text = "Ranking de Vendedores por fecha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnMejorVendFecha.UseVisualStyleBackColor = False
        '
        'btnIFactura
        '
        Me.btnIFactura.BackColor = System.Drawing.Color.PaleGreen
        Me.btnIFactura.FlatAppearance.BorderSize = 0
        Me.btnIFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIFactura.Location = New System.Drawing.Point(33, 175)
        Me.btnIFactura.Name = "btnIFactura"
        Me.btnIFactura.Size = New System.Drawing.Size(219, 40)
        Me.btnIFactura.TabIndex = 101
        Me.btnIFactura.Text = "Facturas de Ventas"
        Me.btnIFactura.UseVisualStyleBackColor = False
        '
        'FormReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnMejorVendTurno)
        Me.Controls.Add(Me.BtnVentaDiaria)
        Me.Controls.Add(Me.btnMOV_ANUAL_ART)
        Me.Controls.Add(Me.btnClientesMonto)
        Me.Controls.Add(Me.btnClientesCantidad)
        Me.Controls.Add(Me.btnProdMasVendFecha)
        Me.Controls.Add(Me.btnProdMasVendMarca)
        Me.Controls.Add(Me.btnProdMasVendCat)
        Me.Controls.Add(Me.BtnProductoNoVendido)
        Me.Controls.Add(Me.BtnMejorVendFecha)
        Me.Controls.Add(Me.btnIFactura)
        Me.Controls.Add(Me.PnlBarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReportes"
        Me.PnlBarraTitulo.ResumeLayout(False)
        Me.PnlBarraTitulo.PerformLayout()
        CType(Me.PBMinim2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCerrar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlBarraTitulo As Panel
    Friend WithEvents LblTitulo As Label
    Friend WithEvents PBMinim2 As PictureBox
    Friend WithEvents PBCerrar2 As PictureBox
    Friend WithEvents BtnMejorVendTurno As Button
    Friend WithEvents BtnVentaDiaria As Button
    Friend WithEvents btnMOV_ANUAL_ART As Button
    Friend WithEvents btnClientesMonto As Button
    Friend WithEvents btnClientesCantidad As Button
    Friend WithEvents btnProdMasVendFecha As Button
    Friend WithEvents btnProdMasVendMarca As Button
    Friend WithEvents btnProdMasVendCat As Button
    Friend WithEvents BtnProductoNoVendido As Button
    Friend WithEvents BtnMejorVendFecha As Button
    Friend WithEvents btnIFactura As Button
End Class
