<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRealizarBackUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRealizarBackUp))
        Me.PnlBarraTitulo = New System.Windows.Forms.Panel()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.PBMinim2 = New System.Windows.Forms.PictureBox()
        Me.PBCerrar2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxNOMBRE = New System.Windows.Forms.TextBox()
        Me.btnBACKUP = New System.Windows.Forms.Button()
        Me.tbxRUTA = New System.Windows.Forms.TextBox()
        Me.tbxBASE = New System.Windows.Forms.TextBox()
        Me.tbxSERVIDOR = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEXAMINAR = New System.Windows.Forms.Button()
        Me.PnlBarraTitulo.SuspendLayout()
        CType(Me.PBMinim2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCerrar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LblTitulo.Location = New System.Drawing.Point(4, 4)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(80, 24)
        Me.LblTitulo.TabIndex = 20
        Me.LblTitulo.Text = "Back Up"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Goudy Stout", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(175, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 26)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "COPIAS DE SEGURIDAD"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbxNOMBRE)
        Me.GroupBox1.Controls.Add(Me.btnBACKUP)
        Me.GroupBox1.Controls.Add(Me.tbxRUTA)
        Me.GroupBox1.Controls.Add(Me.tbxBASE)
        Me.GroupBox1.Controls.Add(Me.tbxSERVIDOR)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnEXAMINAR)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(-13, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(813, 269)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos para realizar Back Up"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(598, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 203)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(62, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nombre para el Archivo"
        '
        'tbxNOMBRE
        '
        Me.tbxNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNOMBRE.Location = New System.Drawing.Point(263, 168)
        Me.tbxNOMBRE.Name = "tbxNOMBRE"
        Me.tbxNOMBRE.Size = New System.Drawing.Size(220, 22)
        Me.tbxNOMBRE.TabIndex = 18
        '
        'btnBACKUP
        '
        Me.btnBACKUP.BackColor = System.Drawing.Color.LightGreen
        Me.btnBACKUP.FlatAppearance.BorderSize = 0
        Me.btnBACKUP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBACKUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBACKUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBACKUP.Location = New System.Drawing.Point(293, 205)
        Me.btnBACKUP.Name = "btnBACKUP"
        Me.btnBACKUP.Size = New System.Drawing.Size(158, 49)
        Me.btnBACKUP.TabIndex = 17
        Me.btnBACKUP.Text = " Generar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copia de Seguridad"
        Me.btnBACKUP.UseVisualStyleBackColor = False
        '
        'tbxRUTA
        '
        Me.tbxRUTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxRUTA.Location = New System.Drawing.Point(262, 126)
        Me.tbxRUTA.Name = "tbxRUTA"
        Me.tbxRUTA.Size = New System.Drawing.Size(220, 22)
        Me.tbxRUTA.TabIndex = 16
        '
        'tbxBASE
        '
        Me.tbxBASE.Enabled = False
        Me.tbxBASE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBASE.Location = New System.Drawing.Point(264, 87)
        Me.tbxBASE.Name = "tbxBASE"
        Me.tbxBASE.Size = New System.Drawing.Size(218, 22)
        Me.tbxBASE.TabIndex = 15
        '
        'tbxSERVIDOR
        '
        Me.tbxSERVIDOR.Enabled = False
        Me.tbxSERVIDOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSERVIDOR.Location = New System.Drawing.Point(263, 44)
        Me.tbxSERVIDOR.Name = "tbxSERVIDOR"
        Me.tbxSERVIDOR.Size = New System.Drawing.Size(220, 22)
        Me.tbxSERVIDOR.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(208, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Ruta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(19, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre de la Base de Datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(181, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Servidor"
        '
        'btnEXAMINAR
        '
        Me.btnEXAMINAR.BackColor = System.Drawing.Color.LightGreen
        Me.btnEXAMINAR.FlatAppearance.BorderSize = 0
        Me.btnEXAMINAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEXAMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEXAMINAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEXAMINAR.Location = New System.Drawing.Point(497, 126)
        Me.btnEXAMINAR.Name = "btnEXAMINAR"
        Me.btnEXAMINAR.Size = New System.Drawing.Size(85, 22)
        Me.btnEXAMINAR.TabIndex = 10
        Me.btnEXAMINAR.Text = "Examinar"
        Me.btnEXAMINAR.UseVisualStyleBackColor = False
        '
        'FormRealizarBackUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PnlBarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRealizarBackUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRealizarBackUp"
        Me.PnlBarraTitulo.ResumeLayout(False)
        Me.PnlBarraTitulo.PerformLayout()
        CType(Me.PBMinim2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCerrar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlBarraTitulo As Panel
    Friend WithEvents LblTitulo As Label
    Friend WithEvents PBMinim2 As PictureBox
    Friend WithEvents PBCerrar2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxNOMBRE As TextBox
    Friend WithEvents btnBACKUP As Button
    Friend WithEvents tbxRUTA As TextBox
    Friend WithEvents tbxBASE As TextBox
    Friend WithEvents tbxSERVIDOR As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEXAMINAR As Button
End Class
