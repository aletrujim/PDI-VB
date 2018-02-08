<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Visor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Visor))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnColores = New System.Windows.Forms.Button()
        Me.btnDeshacerPintar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblPropiedades = New System.Windows.Forms.Label()
        Me.Boton = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.LlbBrillo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CargarImagen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Basicos = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlancoYNegro = New System.Windows.Forms.ToolStripMenuItem()
        Me.EscalaGrises = New System.Windows.Forms.ToolStripMenuItem()
        Me.Colores = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvertRGB = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvertRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvertGreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvertBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Brillo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Contraste = New System.Windows.Forms.ToolStripMenuItem()
        Me.Histogramas = New System.Windows.Forms.ToolStripMenuItem()
        Me.RGBHist = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedHist = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GreenHist = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueHist = New System.Windows.Forms.ToolStripMenuItem()
        Me.Morfologicos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Dilatacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.Erosion = New System.Windows.Forms.ToolStripMenuItem()
        Me.Apertura = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cierre = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Laplaciano1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.Guardar = New System.Windows.Forms.ToolStripButton()
        Me.LabelX = New System.Windows.Forms.ToolStripLabel()
        Me.LabelY = New System.Windows.Forms.ToolStripLabel()
        Me.LabelColor = New System.Windows.Forms.ToolStripLabel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Chart1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer1.Size = New System.Drawing.Size(782, 563)
        Me.SplitContainer1.SplitterDistance = 187
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnColores)
        Me.Panel1.Controls.Add(Me.btnDeshacerPintar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LblPropiedades)
        Me.Panel1.Controls.Add(Me.Boton)
        Me.Panel1.Controls.Add(Me.HScrollBar1)
        Me.Panel1.Controls.Add(Me.LlbBrillo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 326)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(187, 237)
        Me.Panel1.TabIndex = 9
        '
        'btnColores
        '
        Me.btnColores.Location = New System.Drawing.Point(54, 44)
        Me.btnColores.Name = "btnColores"
        Me.btnColores.Size = New System.Drawing.Size(75, 23)
        Me.btnColores.TabIndex = 13
        Me.btnColores.Text = "Paleta"
        Me.btnColores.UseVisualStyleBackColor = True
        Me.btnColores.Visible = False
        '
        'btnDeshacerPintar
        '
        Me.btnDeshacerPintar.Location = New System.Drawing.Point(54, 82)
        Me.btnDeshacerPintar.Name = "btnDeshacerPintar"
        Me.btnDeshacerPintar.Size = New System.Drawing.Size(75, 23)
        Me.btnDeshacerPintar.TabIndex = 12
        Me.btnDeshacerPintar.Text = "Deshacer"
        Me.btnDeshacerPintar.UseVisualStyleBackColor = True
        Me.btnDeshacerPintar.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Matriz mascara"
        Me.Label4.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(22, 105)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(116, 124)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cuadrado3x3", "Cuadrado5x5", "Cuadrado7x7", "Cuadrado9x9", "DiagonalA3x3", "DiagonalA5x5", "DiagonalA7x7", "DiagonalA9x9", "DiagonalB3x3", "DiagonalB5x5", "DiagonalB7x7", "DiagonalB9x9"})
        Me.ComboBox1.Location = New System.Drawing.Point(14, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(132, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 5
        '
        'LblPropiedades
        '
        Me.LblPropiedades.AutoSize = True
        Me.LblPropiedades.Location = New System.Drawing.Point(5, 13)
        Me.LblPropiedades.Name = "LblPropiedades"
        Me.LblPropiedades.Size = New System.Drawing.Size(66, 13)
        Me.LblPropiedades.TabIndex = 4
        Me.LblPropiedades.Text = "Propiedades"
        Me.LblPropiedades.Visible = False
        '
        'Boton
        '
        Me.Boton.Location = New System.Drawing.Point(152, 43)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(30, 23)
        Me.Boton.TabIndex = 3
        Me.Boton.Text = "OK"
        Me.Boton.UseVisualStyleBackColor = True
        Me.Boton.Visible = False
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(8, 44)
        Me.HScrollBar1.Maximum = 264
        Me.HScrollBar1.Minimum = -255
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(141, 22)
        Me.HScrollBar1.TabIndex = 0
        Me.HScrollBar1.Visible = False
        '
        'LlbBrillo
        '
        Me.LlbBrillo.AutoSize = True
        Me.LlbBrillo.Location = New System.Drawing.Point(67, 66)
        Me.LlbBrillo.Name = "LlbBrillo"
        Me.LlbBrillo.Size = New System.Drawing.Size(39, 13)
        Me.LlbBrillo.TabIndex = 1
        Me.LlbBrillo.Text = "Label1"
        Me.LlbBrillo.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(21, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 221)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarImagen, Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(187, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CargarImagen
        '
        Me.CargarImagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CargarImagen.Image = CType(resources.GetObject("CargarImagen.Image"), System.Drawing.Image)
        Me.CargarImagen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CargarImagen.Name = "CargarImagen"
        Me.CargarImagen.Size = New System.Drawing.Size(23, 22)
        Me.CargarImagen.Text = "CargarImagen"
        Me.CargarImagen.ToolTipText = "CargarImagen"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Basicos, Me.Colores, Me.ToolStripMenuItem2, Me.Histogramas, Me.Morfologicos, Me.ToolStripMenuItem1, Me.ToolStripMenuItem6, Me.ToolStripMenuItem9})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'Basicos
        '
        Me.Basicos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlancoYNegro, Me.EscalaGrises})
        Me.Basicos.Name = "Basicos"
        Me.Basicos.Size = New System.Drawing.Size(174, 22)
        Me.Basicos.Text = "Basicos"
        '
        'BlancoYNegro
        '
        Me.BlancoYNegro.Name = "BlancoYNegro"
        Me.BlancoYNegro.Size = New System.Drawing.Size(155, 22)
        Me.BlancoYNegro.Text = "Blanco y negro"
        '
        'EscalaGrises
        '
        Me.EscalaGrises.Name = "EscalaGrises"
        Me.EscalaGrises.Size = New System.Drawing.Size(155, 22)
        Me.EscalaGrises.Text = "Escala de grises"
        '
        'Colores
        '
        Me.Colores.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvertRGB, Me.InvertRed, Me.InvertGreen, Me.InvertBlue})
        Me.Colores.Name = "Colores"
        Me.Colores.Size = New System.Drawing.Size(174, 22)
        Me.Colores.Text = "Colores"
        '
        'InvertRGB
        '
        Me.InvertRGB.Name = "InvertRGB"
        Me.InvertRGB.Size = New System.Drawing.Size(143, 22)
        Me.InvertRGB.Text = "Invertir RGB"
        '
        'InvertRed
        '
        Me.InvertRed.Name = "InvertRed"
        Me.InvertRed.Size = New System.Drawing.Size(143, 22)
        Me.InvertRed.Text = "Invertir rojo"
        '
        'InvertGreen
        '
        Me.InvertGreen.Name = "InvertGreen"
        Me.InvertGreen.Size = New System.Drawing.Size(143, 22)
        Me.InvertGreen.Text = "Invertir verde"
        '
        'InvertBlue
        '
        Me.InvertBlue.Name = "InvertBlue"
        Me.InvertBlue.Size = New System.Drawing.Size(143, 22)
        Me.InvertBlue.Text = "Invertir azul"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Brillo, Me.Contraste})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem2.Text = "Brillo y constraste"
        '
        'Brillo
        '
        Me.Brillo.Name = "Brillo"
        Me.Brillo.Size = New System.Drawing.Size(125, 22)
        Me.Brillo.Text = "Brillo"
        '
        'Contraste
        '
        Me.Contraste.Name = "Contraste"
        Me.Contraste.Size = New System.Drawing.Size(125, 22)
        Me.Contraste.Text = "Contraste"
        '
        'Histogramas
        '
        Me.Histogramas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RGBHist, Me.RedHist, Me.GreenHist, Me.BlueHist})
        Me.Histogramas.Name = "Histogramas"
        Me.Histogramas.Size = New System.Drawing.Size(174, 22)
        Me.Histogramas.Text = "Histogramas"
        '
        'RGBHist
        '
        Me.RGBHist.Name = "RGBHist"
        Me.RGBHist.Size = New System.Drawing.Size(184, 22)
        Me.RGBHist.Text = "Histograma RGB"
        '
        'RedHist
        '
        Me.RedHist.DropDown = Me.ContextMenuStrip2
        Me.RedHist.Name = "RedHist"
        Me.RedHist.Size = New System.Drawing.Size(184, 22)
        Me.RedHist.Text = "Histograma de rojo"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.OwnerItem = Me.RedHist
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'GreenHist
        '
        Me.GreenHist.Name = "GreenHist"
        Me.GreenHist.Size = New System.Drawing.Size(184, 22)
        Me.GreenHist.Text = "Histograma de verde"
        '
        'BlueHist
        '
        Me.BlueHist.Name = "BlueHist"
        Me.BlueHist.Size = New System.Drawing.Size(184, 22)
        Me.BlueHist.Text = "Histograma de azul"
        '
        'Morfologicos
        '
        Me.Morfologicos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Dilatacion, Me.Erosion, Me.Apertura, Me.Cierre})
        Me.Morfologicos.Name = "Morfologicos"
        Me.Morfologicos.Size = New System.Drawing.Size(174, 22)
        Me.Morfologicos.Text = "Morfologicos"
        '
        'Dilatacion
        '
        Me.Dilatacion.Name = "Dilatacion"
        Me.Dilatacion.Size = New System.Drawing.Size(127, 22)
        Me.Dilatacion.Text = "Dilatación"
        '
        'Erosion
        '
        Me.Erosion.Name = "Erosion"
        Me.Erosion.Size = New System.Drawing.Size(127, 22)
        Me.Erosion.Text = "Erosion"
        '
        'Apertura
        '
        Me.Apertura.Name = "Apertura"
        Me.Apertura.Size = New System.Drawing.Size(127, 22)
        Me.Apertura.Text = "Apertura"
        '
        'Cierre
        '
        Me.Cierre.Name = "Cierre"
        Me.Cierre.Size = New System.Drawing.Size(127, 22)
        Me.Cierre.Text = "Cierre"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.Laplaciano1, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem1.Text = "Detector de bordes"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(146, 22)
        Me.ToolStripMenuItem3.Text = "Realza Bordes"
        '
        'Laplaciano1
        '
        Me.Laplaciano1.Name = "Laplaciano1"
        Me.Laplaciano1.Size = New System.Drawing.Size(146, 22)
        Me.Laplaciano1.Text = "Laplaciano"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(146, 22)
        Me.ToolStripMenuItem4.Text = "Sobel"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(146, 22)
        Me.ToolStripMenuItem5.Text = "Contornos"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem8})
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem6.Text = "Filtros"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem7.Text = "Pasa altos"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem8.Text = "Pasa bajos"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem10, Me.ToolStripMenuItem11})
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem9.Text = "Otros"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripMenuItem10.Text = "Cuadricula"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripMenuItem11.Text = "Dibujar"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(14, 55)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Red
        Series1.Legend = "Legend1"
        Series1.Name = "Rojo"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.Green
        Series2.Legend = "Legend1"
        Series2.Name = "Verde"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Color = System.Drawing.Color.Blue
        Series3.Legend = "Legend1"
        Series3.Name = "Azul"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(552, 373)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        Me.Chart1.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Location = New System.Drawing.Point(14, 41)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(552, 510)
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Guardar, Me.LabelX, Me.LabelY, Me.LabelColor})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(591, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'Guardar
        '
        Me.Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(23, 22)
        Me.Guardar.Text = "Guardar"
        '
        'LabelX
        '
        Me.LabelX.Name = "LabelX"
        Me.LabelX.Size = New System.Drawing.Size(0, 22)
        '
        'LabelY
        '
        Me.LabelY.Name = "LabelY"
        Me.LabelY.Size = New System.Drawing.Size(0, 22)
        '
        'LabelColor
        '
        Me.LabelColor.Name = "LabelColor"
        Me.LabelColor.Size = New System.Drawing.Size(0, 22)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Visor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(782, 563)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Visor"
        Me.Text = "Visor: Procesamiento de Imagenes"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents CargarImagen As ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents Basicos As ToolStripMenuItem
    Friend WithEvents Colores As ToolStripMenuItem
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents Guardar As ToolStripButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BlancoYNegro As ToolStripMenuItem
    Friend WithEvents InvertRGB As ToolStripMenuItem
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents EscalaGrises As ToolStripMenuItem
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Histogramas As ToolStripMenuItem
    Friend WithEvents RedHist As ToolStripMenuItem
    Friend WithEvents GreenHist As ToolStripMenuItem
    Friend WithEvents BlueHist As ToolStripMenuItem
    Friend WithEvents RGBHist As ToolStripMenuItem
    Friend WithEvents InvertRed As ToolStripMenuItem
    Friend WithEvents InvertGreen As ToolStripMenuItem
    Friend WithEvents InvertBlue As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Brillo As ToolStripMenuItem
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents LlbBrillo As Label
    Friend WithEvents Contraste As ToolStripMenuItem
    Friend WithEvents Morfologicos As ToolStripMenuItem
    Friend WithEvents Dilatacion As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblPropiedades As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Erosion As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Laplaciano1 As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents Apertura As ToolStripMenuItem
    Friend WithEvents Cierre As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents Boton As Button
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents btnDeshacerPintar As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnColores As Button
    Friend WithEvents LabelX As ToolStripLabel
    Friend WithEvents LabelY As ToolStripLabel
    Friend WithEvents LabelColor As ToolStripLabel
End Class
