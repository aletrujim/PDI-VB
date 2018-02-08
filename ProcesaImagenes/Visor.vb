Imports System.IO
Imports System.Drawing
Imports System.Drawing.Color

Public Class Visor

    Public NombreArchivo As String
    Public img As System.Drawing.Image
    Public bmap As Bitmap

    Public newImg As Bitmap
    Public bmapNew As Bitmap
    Public tipo As String

    'CargarImagen
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles CargarImagen.Click
        Try
            Invisible("")
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.Filter = "Imagenes()|*.jpg;*.jpeg;*.gif;*.bmp;*.png;*.tif"
            openFileDialog1.Title = "Seleccionar imagen"
            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                NombreArchivo = openFileDialog1.FileName
                img = System.Drawing.Image.FromFile(NombreArchivo)
                bmap = New Bitmap(img)
                PintarImagen(img)
                PictureBox4.Image = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            bmap = New Bitmap(img)
            PintarNuevaImagen(bmap)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Guardar
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Try
            If tipo = "Dibujar" Then newImg = PictureBox4.Image
            If tipo = "Histograma" Then
                'newImg = Chart1 ERROR
                Dim Gr As Graphics = Me.CreateGraphics
                Dim ScreenSize As Size = Screen.PrimaryScreen.Bounds.Size
                Dim ScreenBmap As New Bitmap(ScreenSize.Width, ScreenSize.Height, Gr)
                Dim Gr2 As Graphics = Graphics.FromImage(ScreenBmap)
                Gr2.CopyFromScreen(0, 0, 0, 0, ScreenSize)
                newImg = ScreenBmap
            End If

            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "JPeg|*.jpg|Bitmap|*.bmp|Gif|*.gif"
            saveFileDialog1.Title = "Guardar imagen"
            saveFileDialog1.ShowDialog()
            If saveFileDialog1.FileName <> "" Then
                Dim NuevoNombre As System.IO.FileStream = CType(saveFileDialog1.OpenFile(), System.IO.FileStream)
                Select Case saveFileDialog1.FilterIndex
                    Case 1
                        newImg.Save(NuevoNombre, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Case 2
                        newImg.Save(NuevoNombre, System.Drawing.Imaging.ImageFormat.Bmp)
                    Case 3
                        newImg.Save(NuevoNombre, System.Drawing.Imaging.ImageFormat.Gif)
                End Select
                NuevoNombre.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Pintar
    Public Function PintarImagen(ByVal pImg As Bitmap)
        Try
            PictureBox1.Image = pImg
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            bmap = New Bitmap(img)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function PintarNuevaImagen(ByVal pImg As Bitmap)
        Try
            PictureBox4.Image = pImg
            PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
            bmap = New Bitmap(img)
            Return MessageBox.Show(":)")
        Catch ex As Exception
            Return MessageBox.Show(ex.Message)
        End Try
    End Function

    'Cambio tamaño panel
    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved
        Try
            With PictureBox1
                .Width = SplitContainer1.Panel1.Width - 30
                .SizeMode = PictureBoxSizeMode.Zoom
                .Width = SplitContainer1.Panel2.Width - 30
                .SizeMode = PictureBoxSizeMode.Zoom
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Objetos Invisible 
    Public Function Invisible(ByRef filter As String)
        Try
            LlbBrillo.Text = ""
            RichTextBox1.Text = ""
            PictureBox4.BorderStyle = BorderStyle.None
            If filter = "Histograma" Then
                PictureBox4.Visible = False
                Chart1.Visible = True
                LlbBrillo.Visible = False
                HScrollBar1.Visible = False
                Boton.Visible = False
                HScrollBar1.Value = 0
                Label3.Visible = False
                ComboBox1.Visible = False
                RichTextBox1.Visible = False
                LblPropiedades.Visible = False
                Label4.Visible = False
                btnDeshacerPintar.Visible = False
                btnColores.Visible = False
            End If
            If filter = "Brillo" Then
                Chart1.Visible = False
                LlbBrillo.Visible = True
                HScrollBar1.Visible = True
                HScrollBar1.Maximum = 264
                HScrollBar1.Minimum = -255
                Boton.Visible = True
                Label3.Text = "Ajustar Brillo"
                ComboBox1.Visible = False
                RichTextBox1.Visible = False
                LblPropiedades.Visible = True
                Label4.Visible = False
                btnDeshacerPintar.Visible = False
                btnColores.Visible = False
            End If
            If filter = "Contraste" Then
                Chart1.Visible = False
                LlbBrillo.Visible = True
                HScrollBar1.Visible = True
                HScrollBar1.Maximum = 264
                HScrollBar1.Minimum = -255
                Boton.Visible = True
                Label3.Text = "Ajustar Contraste"
                ComboBox1.Visible = False
                RichTextBox1.Visible = False
                LblPropiedades.Visible = True
                Label4.Visible = False
                btnDeshacerPintar.Visible = False
                btnColores.Visible = False
            End If
            If filter = "morfo" Then
                Chart1.Visible = False
                LlbBrillo.Visible = False
                HScrollBar1.Visible = False
                Boton.Visible = True
                HScrollBar1.Value = 0
                Label3.Text = "Escoger matriz"
                ComboBox1.Visible = True
                RichTextBox1.Visible = True
                LblPropiedades.Visible = True
                Label4.Visible = True
                btnDeshacerPintar.Visible = False
                btnColores.Visible = False
            End If
            If filter = "bordes" Then
                Chart1.Visible = False
                LlbBrillo.Visible = False
                HScrollBar1.Visible = False
                Boton.Visible = True
                HScrollBar1.Value = 0
                Label3.Text = "Escoger matriz"
                ComboBox1.Visible = True
                RichTextBox1.Visible = True
                LblPropiedades.Visible = True
                Label4.Visible = True
                btnDeshacerPintar.Visible = False
                btnColores.Visible = False
            End If
            If filter = "Contornos" Then
                Chart1.Visible = False
                LlbBrillo.Visible = True
                HScrollBar1.Visible = True
                HScrollBar1.Maximum = 109
                HScrollBar1.Minimum = 0
                Boton.Visible = True
                Label3.Text = "Máximo de contorno"
                ComboBox1.Visible = False
                RichTextBox1.Visible = True
                LblPropiedades.Visible = True
                Label4.Visible = True
                btnDeshacerPintar.Visible = False
                btnColores.Visible = False
            End If
            If filter = "Dibujar" Then
                Chart1.Visible = False
                LlbBrillo.Visible = False
                HScrollBar1.Visible = False
                Boton.Visible = False
                HScrollBar1.Value = 0
                Label3.Visible = False
                ComboBox1.Visible = False
                ComboBox1.Text = "Colores"
                RichTextBox1.Visible = False
                LblPropiedades.Visible = False
                Label4.Visible = False
                btnDeshacerPintar.Visible = True
                btnColores.Visible = True
            End If
            If filter = "" Then
                Chart1.Visible = False
                LlbBrillo.Visible = False
                HScrollBar1.Visible = False
                Boton.Visible = False
                HScrollBar1.Value = 0
                Label3.Visible = False
                ComboBox1.Visible = False
                RichTextBox1.Visible = False
                LblPropiedades.Visible = False
                Label4.Visible = False
                btnDeshacerPintar.Visible = False
                btnColores.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Nothing
    End Function

    'Niveles digitales de la imagen - color por GetPixel
    Private Function Nivel(ByVal bmp As Bitmap)
        Dim Niveles(,) As System.Drawing.Color
        Dim i, j As Long
        Try
            ReDim Niveles(bmp.Width - 1, bmp.Height - 1)
            For i = 0 To bmp.Width - 1
                For j = 0 To bmp.Height - 1
                    Niveles(i, j) = bmp.GetPixel(i, j)
                Next
            Next
            Return Niveles
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub PictureBox4_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseClick
        Try
            If PictureBox4.Image IsNot Nothing Then
                LabelX.Text = "X [" + e.X.ToString + "]"
                LabelY.Text = "Y [ " + e.Y.ToString + "]"
                Dim pbox As Bitmap = PictureBox4.Image
                LabelColor.Text = pbox.GetPixel(e.X, e.Y).ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


#Region "Basicos"

    'BlancoYNegro
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles BlancoYNegro.Click
        Try
            Invisible("")
            bmap = New Bitmap(img)
            newImg = ColorToBN(bmap)
            PintarNuevaImagen(newImg)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function ColorToBN(ByVal bmp As Bitmap) As Bitmap
        Try
            Dim fnBN As Integer
            Dim x As Integer
            Dim y As Integer
            Dim c As Color
            For y = 0 To bmp.Height - 1
                For x = 0 To bmp.Width - 1
                    c = bmp.GetPixel(x, y)
                    fnBN = CInt(c.R * 0.3 + c.G * 0.59 + c.B * 0.11)
                    bmp.SetPixel(x, y, Color.FromArgb(fnBN, fnBN, fnBN))
                Next
            Next
            Return bmp
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    'Grises
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles EscalaGrises.Click
        Try
            Invisible("")
            bmap = New Bitmap(img)
            newImg = ColorToGrises(bmap)
            PintarNuevaImagen(newImg)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function ColorToGrises(ByVal bmp As Bitmap) As Bitmap
        Try
            Dim c As Color
            For i As Integer = 0 To bmp.Width - 1
                For j As Integer = 0 To bmp.Height - 1
                    c = bmp.GetPixel(i, j)
                    Dim r As Integer = 0
                    r = Convert.ToInt16(c.R)
                    Dim g As Integer = 0
                    g = Convert.ToInt16(c.G)
                    Dim b As Integer = 0
                    b = Convert.ToInt16(c.B)
                    Dim max1 As Integer = System.Math.Max(r, g)
                    Dim final As Integer = System.Math.Max(max1, b)
                    r = final
                    g = final
                    b = final
                    c = Color.FromArgb(r, g, b)
                    bmp.SetPixel(i, j, c)
                Next
            Next
            Return bmp
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Colores"

    'InvertirRGB
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles InvertRGB.Click
        Try
            Invisible("")
            bmap = New Bitmap(img)
            newImg = InvertirColors(bmap, "RGB")
            PintarNuevaImagen(newImg)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'InvertRojo
    Private Sub InvertRojo_Click(sender As Object, e As EventArgs) Handles InvertRed.Click
        Try
            Invisible("")
            bmap = New Bitmap(img)
            newImg = InvertirColors(bmap, "R")
            PintarNuevaImagen(newImg)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'InvertVerde
    Private Sub InvertVerde_Click(sender As Object, e As EventArgs) Handles InvertGreen.Click
        Try
            Invisible("")
            bmap = New Bitmap(img)
            newImg = InvertirColors(bmap, "G")
            PintarNuevaImagen(newImg)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'InvertAzul
    Private Sub InvertAzul_Click(sender As Object, e As EventArgs) Handles InvertBlue.Click
        Try
            Invisible("")
            bmap = New Bitmap(img)
            newImg = InvertirColors(bmap, "B")
            PintarNuevaImagen(newImg)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'InvertColors
    Public Function InvertirColors(ByVal bmp As Bitmap, ByVal color As String) As Bitmap
        Try
            Dim Niveles(,) As System.Drawing.Color
            Niveles = Nivel(bmp)
            Dim Rojo, Verde, Azul, Alfa As Byte
            For i = 0 To Niveles.GetUpperBound(0)  'Recorre la matriz
                For j = 0 To Niveles.GetUpperBound(1)
                    If color = "R" Then
                        Rojo = 255 - (Niveles(i, j).R)
                    Else
                        Rojo = Niveles(i, j).R
                    End If
                    If color = "G" Then
                        Verde = 255 - (Niveles(i, j).G)
                    Else
                        Verde = Niveles(i, j).G
                    End If
                    If color = "B" Then
                        Azul = 255 - (Niveles(i, j).B)
                    Else
                        Azul = Niveles(i, j).B
                    End If
                    If color = "RGB" Then
                        Rojo = 255 - (Niveles(i, j).R)
                        Verde = 255 - (Niveles(i, j).G)
                        Azul = 255 - (Niveles(i, j).B)
                    End If
                    Alfa = Niveles(i, j).A
                    bmp.SetPixel(i, j, System.Drawing.Color.FromArgb(Alfa, Rojo, Verde, Azul))
                Next
            Next
            Return bmp
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Brillo y Contraste"

    'Brillo
    Private Sub Brillo_Click(sender As Object, e As EventArgs) Handles Brillo.Click
        Try
            Invisible("Brillo")
            bmap = New Bitmap(img)
            PintarNuevaImagen(bmap)
            tipo = "Brillo"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function CambiarBrillo(ByVal bmp As Bitmap, ByRef Value As Integer) As Bitmap
        Try
            Dim bmp2 = bmp
            Dim Niveles(,) As System.Drawing.Color
            Niveles = Nivel(bmp2)
            Dim bmp3 As New Bitmap(bmp2.Width, bmp2.Height)
            Dim Rojo, Verde, Azul, Alfa As Byte
            Dim AuxiliarR, AuxiliarG, AuxiliarB As Integer
            Dim AuxiliarR2, AuxiliarG2, AuxiliarB2 As Integer
            For i = 0 To Niveles.GetUpperBound(0)
                For j = 0 To Niveles.GetUpperBound(1)
                    AuxiliarR2 = Niveles(i, j).R
                    AuxiliarG2 = Niveles(i, j).G
                    AuxiliarB2 = Niveles(i, j).B
                    AuxiliarR = AuxiliarR2 + Value
                    AuxiliarG = AuxiliarG2 + Value
                    AuxiliarB = AuxiliarB2 + Value
                    If AuxiliarR > 255 Then AuxiliarR = 255
                    If AuxiliarG > 255 Then AuxiliarG = 255
                    If AuxiliarB > 255 Then AuxiliarB = 255
                    If AuxiliarR < 0 Then AuxiliarR = 0
                    If AuxiliarG < 0 Then AuxiliarG = 0
                    If AuxiliarB < 0 Then AuxiliarB = 0
                    Rojo = AuxiliarR
                    Verde = AuxiliarG
                    Azul = AuxiliarB
                    Alfa = Niveles(i, j).A
                    bmp3.SetPixel(i, j, Color.FromArgb(Alfa, Rojo, Verde, Azul))
                Next
            Next
            Return bmp3
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    'Contraste
    Private Sub Contraste_Click(sender As Object, e As EventArgs) Handles Contraste.Click
        Try
            Invisible("Contraste")
            bmap = New Bitmap(img)
            PintarNuevaImagen(bmap)
            tipo = "Contraste"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function CambiarContraste(ByVal bmp As Bitmap, ByRef Value As Integer) As Bitmap
        Try
            Dim bmp2 = bmp
            Dim Niveles(,) As System.Drawing.Color
            Niveles = Nivel(bmp2)
            Dim bmp3 As New Bitmap(bmp2.Width, bmp2.Height)
            Dim Rojo, Verde, Azul, Alfa As Byte
            Dim auxRojo, auxVerde, auxAzul As Double

            Dim calculo, calculoAux As Double
            calculoAux = (1 / ((Math.PI) / 4))
            calculo = (Value + 1) * (Math.PI / 4) 'Pi/4
            calculo *= calculoAux
            For i = 0 To Niveles.GetUpperBound(0)
                For j = 0 To Niveles.GetUpperBound(1)
                    auxRojo = ((Niveles(i, j).R - 128) * calculo) + 128
                    auxVerde = ((Niveles(i, j).G - 128) * calculo) + 128
                    auxAzul = ((Niveles(i, j).B - 128) * calculo) + 128
                    If auxRojo > 255 Then auxRojo = 255
                    If auxVerde > 255 Then auxVerde = 255
                    If auxAzul > 255 Then auxAzul = 255
                    If auxRojo < 0 Then auxRojo = 0
                    If auxVerde < 0 Then auxVerde = 0
                    If auxAzul < 0 Then auxAzul = 0
                    Rojo = auxRojo
                    Verde = auxVerde
                    Azul = auxAzul
                    Alfa = Niveles(i, j).A
                    bmp3.SetPixel(i, j, Color.FromArgb(Alfa, Rojo, Verde, Azul))
                Next
            Next
            Return bmp3
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Histogramas"

    Public eX As Integer
    Public eY As Integer
    Dim histoAcumulado As Integer(,)

    Public Function histogramAcumulador(ByVal bmp As Bitmap) As Integer(,)
        Try
            Dim Rojo, Verde, Azul As Byte
            Dim matrizAcumulador(2, 255) As Integer
            For i = 0 To bmp.Width - 1
                For j = 0 To bmp.Height - 1
                    Rojo = bmp.GetPixel(i, j).R
                    Verde = bmp.GetPixel(i, j).G
                    Azul = bmp.GetPixel(i, j).B
                    matrizAcumulador(0, Rojo) += 1
                    matrizAcumulador(1, Verde) += 1
                    matrizAcumulador(2, Azul) += 1
                Next
            Next
            Return matrizAcumulador
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    'Histo Rojo
    Private Sub ToolStripMenuItem6_Click_1(sender As Object, e As EventArgs) Handles RedHist.Click
        Try
            tipo = "Histograma"
            Invisible(tipo)
            bmap = New Bitmap(img)
            histoAcumulado = histogramAcumulador(bmap)
            Chart1.Series("Rojo").Points.Clear()
            Chart1.Series("Verde").Points.Clear()
            Chart1.Series("Azul").Points.Clear()
            Chart1.Series("Rojo").Color = Color.Red
            For i = 0 To 255
                Chart1.Series("Rojo").Points.AddXY(i + 1, histoAcumulado(0, i))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Histo Verde
    Private Sub VerdeHist_Click(sender As Object, e As EventArgs) Handles GreenHist.Click
        Try
            tipo = "Histograma"
            Invisible(tipo)
            bmap = New Bitmap(img)
            histoAcumulado = histogramAcumulador(bmap)
            Chart1.Visible = True
            Chart1.Series("Rojo").Points.Clear()
            Chart1.Series("Verde").Points.Clear()
            Chart1.Series("Azul").Points.Clear()
            Chart1.Series("Verde").Color = Color.Green
            For i = 0 To 255
                Chart1.Series("Verde").Points.AddXY(i + 1, histoAcumulado(1, i))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Histo Azul
    Private Sub AzulHist_Click(sender As Object, e As EventArgs) Handles BlueHist.Click
        Try
            tipo = "Histograma"
            Invisible(tipo)
            bmap = New Bitmap(img)
            histoAcumulado = histogramAcumulador(bmap)
            Chart1.Series("Rojo").Points.Clear()
            Chart1.Series("Verde").Points.Clear()
            Chart1.Series("Azul").Points.Clear()
            Chart1.Series("Azul").Color = Color.Blue
            For i = 0 To 255
                Chart1.Series("Azul").Points.AddXY(i + 1, histoAcumulado(2, i))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Histog RGB
    Private Sub RGBHist_Click(sender As Object, e As EventArgs) Handles RGBHist.Click
        Try
            tipo = "Histograma"
            Invisible(tipo)
            bmap = New Bitmap(img)
            histoAcumulado = histogramAcumulador(bmap)
            Chart1.Series("Rojo").Points.Clear()
            Chart1.Series("Verde").Points.Clear()
            Chart1.Series("Azul").Points.Clear()
            Chart1.Series("Rojo").Color = Color.Red
            Chart1.Series("Verde").Color = Color.Green
            Chart1.Series("Azul").Color = Color.Blue
            For i = 0 To 255
                Chart1.Series("Rojo").Points.AddXY(i + 1, histoAcumulado(0, i))
                Chart1.Series("Verde").Points.AddXY(i + 1, histoAcumulado(1, i))
                Chart1.Series("Azul").Points.AddXY(i + 1, histoAcumulado(2, i))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

    'Barra
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Try
            LlbBrillo.Visible = True
            LlbBrillo.Text = HScrollBar1.Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'ITEMS
    Public Function CargarItems(tipo As String)
        Try
            ComboBox1.Text = "Mascaras"
            With ComboBox1.Items
                .Clear()
                Select Case tipo
                    Case "DEAP"
                        .Add("Cuadrado3x3")
                        .Add("Cuadrado5x5")
                        .Add("Cuadrado7x7")
                        .Add("Cuadrado9x9")
                        .Add("DiagonalA3x3")
                        .Add("DiagonalA5x5")
                        .Add("DiagonalA7x7")
                        .Add("DiagonalA9x9")
                        .Add("DiagonalB3x3")
                        .Add("DiagonalB5x5")
                        .Add("DiagonalB7x7")
                        .Add("DiagonalB9x9")
                    Case "RealceBordes"
                        .Add("RealceBordes")
                    Case "Laplaciano"
                        .Add("Laplaciano 1")
                        .Add("Laplaciano 2")
                        .Add("Laplaciano 3")
                        .Add("Laplaciano 4")
                        .Add("Laplaciano Horizontal")
                        .Add("Laplaciano Vertical")
                        .Add("Laplaciano Diagonal")
                    Case "Sobel"
                        .Add("Sobel Horizontal")
                        .Add("Sobel Vertical")
                        .Add("Sobel DiagonalA")
                        .Add("Sobel DiagonalB")
                    Case "Pasa altos"
                        .Add("Pasa Altos 1")
                        .Add("Pasa Altos 2")
                        .Add("Pasa Altos 3")
                    Case "Pasa bajos"
                        .Add("Pasa Bajos 1")
                        .Add("Pasa Bajos 2")
                        .Add("Pasa Bajos 3")

                    Case "Dibujar"
                        .Add("Rojo")
                        .Add("Negro")
                        .Add("Blanco")
                End Select
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Nothing
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Select Case ComboBox1.Text
            'Morfologicos
                Case "Cuadrado3x3"
                    Mascara = Cuadrado3x3()
                    RichTextBox1.Text = "1  1  1" & vbNewLine & "1  1  1" & vbNewLine & "1  1  1"
                Case "Cuadrado5x5"
                    Mascara = Cuadrado5x5()
                    RichTextBox1.Text = "1  1  1  1  1" & vbNewLine & "1  1  1  1  1" & vbNewLine & "1  1  1  1  1" & vbNewLine & "1  1  1  1  1" & vbNewLine & "1  1  1  1  1"
                Case "Cuadrado7x7"
                    Mascara = Cuadrado7x7()
                    RichTextBox1.Text = "1  1  1  1  1  1  1" & vbNewLine & "1  1  1  1  1  1  1" & vbNewLine & "1  1  1  1  1  1  1" & vbNewLine & "1  1  1  1  1  1  1" & vbNewLine & "1  1  1  1  1  1  1" & vbNewLine & "1  1  1  1  1  1  1" & vbNewLine & "1  1  1  1  1  1  1"
                Case "Cuadrado9x9"
                    Mascara = Cuadrado9x9()
                    RichTextBox1.Text = "1  1  1  1  1  1  1  1  1" & vbNewLine & "1  1  1  1  1  1  1  1  1" & vbNewLine & "1  1  1  1  1  1  1  1  1" & vbNewLine & "1  1  1  1  1  1  1  1  1" & vbNewLine & "1  1  1  1  1  1  1  1  1" & vbNewLine & "1  1  1  1  1  1  1  1  1" & vbNewLine & "1  1  1  1  1  1  1  1  1" & vbNewLine & "1  1  1  1  1  1  1  1  1" & vbNewLine & "1  1  1  1  1  1  1  1  1"
                Case "DiagonalA3x3"
                    Mascara = DiagonalA3x3()
                    RichTextBox1.Text = "1  0  0" & vbNewLine & "0  1  0" & vbNewLine & "0  0  1"
                Case "DiagonalA5x5"
                    Mascara = DiagonalA5x5()
                    RichTextBox1.Text = "1  0  0  0  0" & vbNewLine & "0  1  0  0  0" & vbNewLine & "0  0  1  0  0" & vbNewLine & "0  0  0  1  0" & vbNewLine & "0  0  0  0  1"
                Case "DiagonalA7x7"
                    Mascara = DiagonalA7x7()
                    RichTextBox1.Text = "1  0  0  0  0  0  0" & vbNewLine & "0  1  0  0  0  0  0" & vbNewLine & "0  0  1  0  0  0  0" & vbNewLine & "0  0  0  1  0  0  0" & vbNewLine & "0  0  0  0  1  0  0" & vbNewLine & "0  0  0  0  0  1  0" & vbNewLine & "0  0  0  0  0  0  1"
                Case "DiagonalA9x9"
                    Mascara = DiagonalA9x9()
                    RichTextBox1.Text = "1  0  0  0  0  0  0  0  0" & vbNewLine & "0  1  0  0  0  0  0  0  0" & vbNewLine & "0  0  1  0  0  0  0  0  0" & vbNewLine & "0  0  0  1  0  0  0  0  0" & vbNewLine & "0  0  0  0  1  0  0  0  0" & vbNewLine & "0  0  0  0  0  1  0  0  0" & vbNewLine & "0  0  0  0  0  0  1  0  0" & vbNewLine & "0  0  0  0  0  0  0  1  0" & vbNewLine & "0  0  0  0  0  0  0  0  1"
                Case "DiagonalB3x3"
                    Mascara = DiagonalB3x3()
                    RichTextBox1.Text = "0  0  1" & vbNewLine & "0  1  0" & vbNewLine & "1  0  0"
                Case "DiagonalB5x5"
                    Mascara = DiagonalB5x5()
                    RichTextBox1.Text = "0  0  0  0  1" & vbNewLine & "0  0  0  1  0" & vbNewLine & "0  0  1  0  0" & vbNewLine & "0  1  0  0  0" & vbNewLine & "1  0  0  0  0"
                Case "DiagonalB7x7"
                    Mascara = DiagonalB7x7()
                    RichTextBox1.Text = "0  0  0  0  0  0  1" & vbNewLine & "0  0  0  0  0  1  0" & vbNewLine & "0  0  0  0  1  0  0" & vbNewLine & "0  0  0  1  0  0  0" & vbNewLine & "0  0  1  0  0  0  0" & vbNewLine & "0  1  0  0  0  0  0" & vbNewLine & "1  0  0  0  0  0  0"
                Case "DiagonalB9x9"
                    Mascara = DiagonalB9x9()
                    RichTextBox1.Text = "0  0  0  0  0  0  0  0  1" & vbNewLine & "0  0  0  0  0  0  0  1  0" & vbNewLine & "0  0  0  0  0  0  1  0  0" & vbNewLine & "0  0  0  0  0  1  0  0  0" & vbNewLine & "0  0  0  0  1  0  0  0  0" & vbNewLine & "0  0  0  1  0  0  0  0  0" & vbNewLine & "0  0  1  0  0  0  0  0  0" & vbNewLine & "0  1  0  0  0  0  0  0  0" & vbNewLine & "1  0  0  0  0  0  0  0  0"

            'Bordes
                Case "RealceBordes"
                    Mascara = RealzaBordes()
                    RichTextBox1.Text = "0   0  0" & vbNewLine & "-1  1  0" & vbNewLine & "0   0  0"
                Case "Laplaciano 1"
                    Mascara = Laplaciana1()
                    RichTextBox1.Text = "0   1   0" & vbNewLine & "1  -4   1" & vbNewLine & "0   1   0"
                Case "Laplaciano 2"
                    Mascara = Laplaciana2()
                    RichTextBox1.Text = " 0  -1   0" & vbNewLine & "-1   4  -1" & vbNewLine & " 0  -1   0"
                Case "Laplaciano 3"
                    Mascara = Laplaciana3()
                    RichTextBox1.Text = "-1  -1  -1" & vbNewLine & "-1   8  -1" & vbNewLine & "-1  -1  -1"
                Case "Laplaciano 4"
                    Mascara = Laplaciana4()
                    RichTextBox1.Text = " 1  -2   1" & vbNewLine & "-2   4  -2" & vbNewLine & " 1  -2   1"
                Case "Laplaciano Horizontal"
                    Mascara = LaplacianaHorizont()
                    RichTextBox1.Text = " 0   0   0" & vbNewLine & "-1   2  -1" & vbNewLine & " 0   0   0"
                Case "Laplaciano Vertical"
                    Mascara = LaplacianaVertical()
                    RichTextBox1.Text = "0  -1   0" & vbNewLine & "0   2   0" & vbNewLine & "0  -1   0"
                Case "Laplaciano Diagonal"
                    Mascara = LaplacianaDiagonal()
                    RichTextBox1.Text = "-1  0  -1" & vbNewLine & " 0  4  0" & vbNewLine & "-1  0  -1"

            'Sobel
                Case "Sobel Horizontal"
                    Mascara = SobelHorizontal()
                    RichTextBox1.Text = "1  0  -1" & vbNewLine & "2  0  -2" & vbNewLine & "1  0  -1"
                Case "Sobel Vertical"
                    Mascara = SobelVertical()
                    RichTextBox1.Text = " 1  2  1" & vbNewLine & " 0  0  0" & vbNewLine & "-1  -2  -1"
                Case "Sobel DiagonalA"
                    Mascara = SobelDiagonalA()
                    RichTextBox1.Text = "-2  -1  0" & vbNewLine & "-1   0  1" & vbNewLine & " 0   1  2"
                Case "Sobel DiagonalB"
                    Mascara = SobelDiagonalB()
                    RichTextBox1.Text = "0  1  2" & vbNewLine & "-1   0  1" & vbNewLine & "-2  -1  0"

            'Pasa altos
                Case "Pasa Altos 1"
                    Mascara = PasaAlto1()
                    RichTextBox1.Text = "-1  -1  -1" & vbNewLine & "-1   9  -1" & vbNewLine & "-1  -1  -1"
                Case "Pasa Altos 2"
                    Mascara = PasaAlto2()
                    RichTextBox1.Text = "0   -1   0" & vbNewLine & "-1   5  -1" & vbNewLine & "0   -1   0"
                Case "Pasa Altos 3"
                    Mascara = PasaAlto3()
                    RichTextBox1.Text = "0    -1    0" & vbNewLine & "-1   20  -1" & vbNewLine & "0    -1    0"
            'Pasa bajos
                Case "Pasa Bajos 1"
                    Mascara = PasaBajos1()
                    RichTextBox1.Text = "1  1  1" & vbNewLine & "1  1  1" & vbNewLine & "1  1  1"
                Case "Pasa Bajos 2"
                    Mascara = PasaBajos2()
                    RichTextBox1.Text = "1  1  1" & vbNewLine & "1  2  1" & vbNewLine & "1  1  1"
                Case "Pasa Bajos 3"
                    Mascara = PasaBajos3()
                    RichTextBox1.Text = "1  1  1" & vbNewLine & "1  4  1" & vbNewLine & "1  1  1"
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'BOTON
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Boton.Click
        Try
            bmap = New Bitmap(img)
            Select Case tipo
            'Brillo y contraste
                Case "Brillo"
                    newImg = CambiarBrillo(bmap, HScrollBar1.Value)
                Case "Contraste"
                    newImg = CambiarContraste(bmap, HScrollBar1.Value)

            'Morfologicos
                Case "Dilatacion"
                    newImg = MorfoDilatacion(bmap, Mascara)
                Case "Erosion"
                    newImg = MorfoErosion(bmap, Mascara)
                Case "Apertura"
                    newImg = MorfoApertura(bmap, Mascara)
                Case "Cierre"
                    newImg = MorfoCierre(bmap, Mascara)

            'Bordes
                Case "RealceBordes"
                    newImg = AplicarMascara(bmap, Mascara)
                Case "Laplaciano"
                    newImg = AplicarMascara(bmap, Mascara)
            'Sobel 'desviacion 0 factor 4
                Case "Sobel"
                    newImg = AplicarMascara(bmap, Mascara)
                Case "Contornos"
                    newImg = contornos(bmap, HScrollBar1.Value, 70, 150, 29)
                    RichTextBox1.Text = "Contorno = " & HScrollBar1.Value & vbNewLine & "Valor rojo = 70" & vbNewLine & "Valor verde = 150" & vbNewLine & "Valor azul = 29"
            'filtros
                Case "Pasa altos"
                    newImg = AplicarMascara(bmap, Mascara)
                Case "Pasa bajos"
                    newImg = AplicarMascara(bmap, Mascara)

            End Select
            PintarNuevaImagen(newImg)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'APLICAR MASCARA
    Public Function AplicarMascara(ByVal bmp As Bitmap, ByVal matrizMascara(,) As Integer, Optional ByVal desviacion As Double = 0, Optional ByVal factor As Double = 1)
        Try
            Dim bmp2 = bmp
            'Dim Niveles(,) As System.Drawing.Color 'color
            Dim Niveles(,) As System.Drawing.Color = Nivel(bmp2) 'grises
            Niveles = Nivel(bmp2)
            Dim bmp3 As New Bitmap(bmp2.Width, bmp2.Height)
            Dim SumaRojo, SumaVerde, SumaAzul, SumaMascara As Long
            Dim Rojo, verde, azul, alfa As Integer

            For mi = -1 To 1
                For mj = -1 To 1
                    SumaMascara = SumaMascara + matrizMascara(mi + 1, mj + 1)
                Next
            Next

            If SumaMascara = 0 Then
                SumaMascara = 1
            End If

            For i = 1 To Niveles.GetUpperBound(0) - 1
                For j = 1 To Niveles.GetUpperBound(1) - 1
                    SumaRojo = 0
                    For mi = -1 To 1
                        For mj = -1 To 1
                            SumaRojo = SumaRojo + Niveles(i + mi, j + mj).R * matrizMascara(mi + 1, mj + 1)
                        Next
                    Next
                    SumaVerde = 0
                    For mi = -1 To 1
                        For mj = -1 To 1
                            SumaVerde = SumaVerde + Niveles(i + mi, j + mj).G * matrizMascara(mi + 1, mj + 1)

                        Next
                    Next
                    SumaAzul = 0
                    For mi = -1 To 1
                        For mj = -1 To 1
                            SumaAzul = SumaAzul + Niveles(i + mi, j + mj).B * matrizMascara(mi + 1, mj + 1)
                        Next
                    Next
                    If factor + desviacion = 0 Then factor = 1 : desviacion = 0
                    Rojo = Math.Abs((SumaRojo / SumaMascara) / (factor + desviacion))
                    verde = Math.Abs((SumaVerde / SumaMascara) / (factor + desviacion))
                    azul = Math.Abs((SumaAzul / SumaMascara) / (factor + desviacion))
                    If Rojo > 255 Then Rojo = 255
                    If verde > 255 Then verde = 255
                    If azul > 255 Then azul = 255
                    alfa = Niveles(i, j).A
                    bmp3.SetPixel(i, j, Color.FromArgb(alfa, Rojo, verde, azul))
                Next
            Next
            Return bmp3
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function


#Region "Matrices"

    Private Matriz(,) As Integer

    'Morfologicos
    Public Function Cuadrado3x3()
        ReDim Matriz(2, 2)
        For i = 0 To Matriz.GetUpperBound(0)
            For j = 0 To Matriz.GetUpperBound(0)
                Matriz(i, j) = 1
            Next
        Next
        Return Matriz
    End Function

    Public Function Cuadrado5x5()
        ReDim Matriz(4, 4)
        For i = 0 To Matriz.GetUpperBound(0)
            For j = 0 To Matriz.GetUpperBound(0)
                Matriz(i, j) = 1
            Next
        Next
        Return Matriz
    End Function

    Public Function Cuadrado7x7()
        ReDim Matriz(6, 6)
        For i = 0 To Matriz.GetUpperBound(0)
            For j = 0 To Matriz.GetUpperBound(0)
                Matriz(i, j) = 1
            Next
        Next
        Return Matriz
    End Function

    Public Function Cuadrado9x9()
        ReDim Matriz(8, 8)
        For i = 0 To Matriz.GetUpperBound(0)
            For j = 0 To Matriz.GetUpperBound(0)
                Matriz(i, j) = 1
            Next
        Next
        Return Matriz
    End Function

    Public Function DiagonalA3x3()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 1 : Matriz(0, 1) = 0 : Matriz(0, 2) = 0
        Matriz(1, 0) = 0 : Matriz(1, 1) = 1 : Matriz(1, 2) = 0
        Matriz(2, 0) = 0 : Matriz(2, 1) = 0 : Matriz(2, 2) = 1
        Return Matriz
    End Function

    Public Function DiagonalA5x5()
        ReDim Matriz(4, 4)
        Matriz(0, 0) = 1 : Matriz(0, 1) = 0 : Matriz(0, 2) = 0 : Matriz(0, 3) = 0 : Matriz(0, 4) = 0
        Matriz(1, 0) = 0 : Matriz(1, 1) = 1 : Matriz(1, 2) = 0 : Matriz(1, 3) = 0 : Matriz(1, 4) = 0
        Matriz(2, 0) = 0 : Matriz(2, 1) = 0 : Matriz(2, 2) = 1 : Matriz(2, 3) = 0 : Matriz(2, 4) = 0
        Matriz(3, 0) = 0 : Matriz(3, 1) = 0 : Matriz(3, 2) = 0 : Matriz(3, 3) = 1 : Matriz(3, 4) = 0
        Matriz(4, 0) = 0 : Matriz(4, 1) = 0 : Matriz(4, 2) = 0 : Matriz(4, 3) = 0 : Matriz(4, 4) = 1
        Return Matriz
    End Function

    Public Function DiagonalA7x7()
        ReDim Matriz(6, 6)
        Matriz(0, 0) = 1 : Matriz(0, 1) = 0 : Matriz(0, 2) = 0 : Matriz(0, 3) = 0 : Matriz(0, 4) = 0 : Matriz(0, 5) = 0 : Matriz(0, 6) = 0
        Matriz(1, 0) = 0 : Matriz(1, 1) = 1 : Matriz(1, 2) = 0 : Matriz(1, 3) = 0 : Matriz(1, 4) = 0 : Matriz(1, 5) = 0 : Matriz(1, 6) = 0
        Matriz(2, 0) = 0 : Matriz(2, 1) = 0 : Matriz(2, 2) = 1 : Matriz(2, 3) = 0 : Matriz(2, 4) = 0 : Matriz(2, 5) = 0 : Matriz(2, 6) = 0
        Matriz(3, 0) = 0 : Matriz(3, 1) = 0 : Matriz(3, 2) = 0 : Matriz(3, 3) = 1 : Matriz(3, 4) = 0 : Matriz(3, 5) = 0 : Matriz(3, 6) = 0
        Matriz(4, 0) = 0 : Matriz(4, 1) = 0 : Matriz(4, 2) = 0 : Matriz(4, 3) = 0 : Matriz(4, 4) = 1 : Matriz(4, 5) = 0 : Matriz(4, 6) = 0
        Matriz(5, 0) = 0 : Matriz(5, 1) = 0 : Matriz(5, 2) = 0 : Matriz(5, 3) = 0 : Matriz(5, 4) = 0 : Matriz(5, 5) = 1 : Matriz(5, 6) = 0
        Matriz(6, 0) = 0 : Matriz(6, 1) = 0 : Matriz(6, 2) = 0 : Matriz(6, 3) = 0 : Matriz(6, 4) = 0 : Matriz(6, 5) = 0 : Matriz(6, 6) = 1
        Return Matriz

    End Function

    Public Function DiagonalA9x9()
        ReDim Matriz(8, 8)
        Matriz(0, 0) = 1 : Matriz(0, 1) = 0 : Matriz(0, 2) = 0 : Matriz(0, 3) = 0 : Matriz(0, 4) = 0 : Matriz(0, 5) = 0 : Matriz(0, 6) = 0 : Matriz(0, 7) = 0 : Matriz(0, 8) = 0
        Matriz(1, 0) = 0 : Matriz(1, 1) = 1 : Matriz(1, 2) = 0 : Matriz(1, 3) = 0 : Matriz(1, 4) = 0 : Matriz(1, 5) = 0 : Matriz(1, 6) = 0 : Matriz(1, 7) = 0 : Matriz(1, 8) = 0
        Matriz(2, 0) = 0 : Matriz(2, 1) = 0 : Matriz(2, 2) = 1 : Matriz(2, 3) = 0 : Matriz(2, 4) = 0 : Matriz(2, 5) = 0 : Matriz(2, 6) = 0 : Matriz(2, 7) = 0 : Matriz(2, 8) = 0
        Matriz(3, 0) = 0 : Matriz(3, 1) = 0 : Matriz(3, 2) = 0 : Matriz(3, 3) = 1 : Matriz(3, 4) = 0 : Matriz(3, 5) = 0 : Matriz(3, 6) = 0 : Matriz(3, 7) = 0 : Matriz(3, 8) = 0
        Matriz(4, 0) = 0 : Matriz(4, 1) = 0 : Matriz(4, 2) = 0 : Matriz(4, 3) = 0 : Matriz(4, 4) = 1 : Matriz(4, 5) = 0 : Matriz(4, 6) = 0 : Matriz(4, 7) = 0 : Matriz(4, 8) = 0
        Matriz(5, 0) = 0 : Matriz(5, 1) = 0 : Matriz(5, 2) = 0 : Matriz(5, 3) = 0 : Matriz(5, 4) = 0 : Matriz(5, 5) = 1 : Matriz(5, 6) = 0 : Matriz(5, 7) = 0 : Matriz(5, 8) = 0
        Matriz(6, 0) = 0 : Matriz(6, 1) = 0 : Matriz(6, 2) = 0 : Matriz(6, 3) = 0 : Matriz(6, 4) = 0 : Matriz(6, 5) = 0 : Matriz(6, 6) = 1 : Matriz(6, 7) = 0 : Matriz(6, 8) = 0
        Matriz(7, 0) = 0 : Matriz(7, 1) = 0 : Matriz(7, 2) = 0 : Matriz(7, 3) = 0 : Matriz(7, 4) = 0 : Matriz(7, 5) = 0 : Matriz(7, 6) = 0 : Matriz(7, 7) = 1 : Matriz(7, 8) = 0
        Matriz(8, 0) = 0 : Matriz(8, 1) = 0 : Matriz(8, 2) = 0 : Matriz(8, 3) = 0 : Matriz(8, 4) = 0 : Matriz(8, 5) = 0 : Matriz(8, 6) = 0 : Matriz(8, 7) = 0 : Matriz(8, 8) = 1
        Return Matriz

    End Function

    Public Function DiagonalB3x3()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 0 : Matriz(0, 1) = 0 : Matriz(0, 2) = 1
        Matriz(1, 0) = 0 : Matriz(1, 1) = 1 : Matriz(1, 2) = 0
        Matriz(2, 0) = 1 : Matriz(2, 1) = 0 : Matriz(2, 2) = 0
        Return Matriz
    End Function

    Public Function DiagonalB5x5()
        ReDim Matriz(4, 4)
        Matriz(0, 0) = 0 : Matriz(0, 1) = 0 : Matriz(0, 2) = 0 : Matriz(0, 3) = 0 : Matriz(0, 4) = 1
        Matriz(1, 0) = 0 : Matriz(1, 1) = 0 : Matriz(1, 2) = 0 : Matriz(1, 3) = 1 : Matriz(1, 4) = 0
        Matriz(2, 0) = 0 : Matriz(2, 1) = 0 : Matriz(2, 2) = 1 : Matriz(2, 3) = 0 : Matriz(2, 4) = 0
        Matriz(3, 0) = 0 : Matriz(3, 1) = 1 : Matriz(3, 2) = 0 : Matriz(3, 3) = 0 : Matriz(3, 4) = 0
        Matriz(4, 0) = 1 : Matriz(4, 1) = 0 : Matriz(4, 2) = 0 : Matriz(4, 3) = 0 : Matriz(4, 4) = 0
        Return Matriz
    End Function

    Public Function DiagonalB7x7()
        ReDim Matriz(6, 6)
        Matriz(0, 0) = 0 : Matriz(0, 1) = 0 : Matriz(0, 2) = 0 : Matriz(0, 3) = 0 : Matriz(0, 4) = 0 : Matriz(0, 5) = 0 : Matriz(0, 6) = 1
        Matriz(1, 0) = 0 : Matriz(1, 1) = 0 : Matriz(1, 2) = 0 : Matriz(1, 3) = 0 : Matriz(1, 4) = 0 : Matriz(1, 5) = 1 : Matriz(1, 6) = 0
        Matriz(2, 0) = 0 : Matriz(2, 1) = 0 : Matriz(2, 2) = 0 : Matriz(2, 3) = 0 : Matriz(2, 4) = 1 : Matriz(2, 5) = 0 : Matriz(2, 6) = 0
        Matriz(3, 0) = 0 : Matriz(3, 1) = 0 : Matriz(3, 2) = 0 : Matriz(3, 3) = 1 : Matriz(3, 4) = 0 : Matriz(3, 5) = 0 : Matriz(3, 6) = 0
        Matriz(4, 0) = 0 : Matriz(4, 1) = 0 : Matriz(4, 2) = 1 : Matriz(4, 3) = 0 : Matriz(4, 4) = 0 : Matriz(4, 5) = 0 : Matriz(4, 6) = 0
        Matriz(5, 0) = 0 : Matriz(5, 1) = 1 : Matriz(5, 2) = 0 : Matriz(5, 3) = 0 : Matriz(5, 4) = 0 : Matriz(5, 5) = 0 : Matriz(5, 6) = 0
        Matriz(6, 0) = 1 : Matriz(6, 1) = 0 : Matriz(6, 2) = 0 : Matriz(6, 3) = 0 : Matriz(6, 4) = 0 : Matriz(6, 5) = 0 : Matriz(6, 6) = 0
        Return Matriz
    End Function

    Public Function DiagonalB9x9()
        ReDim Matriz(8, 8)
        Matriz(0, 0) = 0 : Matriz(0, 1) = 0 : Matriz(0, 2) = 0 : Matriz(0, 3) = 0 : Matriz(0, 4) = 0 : Matriz(0, 5) = 0 : Matriz(0, 6) = 0 : Matriz(0, 7) = 0 : Matriz(0, 8) = 1
        Matriz(1, 0) = 0 : Matriz(1, 1) = 0 : Matriz(1, 2) = 0 : Matriz(1, 3) = 0 : Matriz(1, 4) = 0 : Matriz(1, 5) = 0 : Matriz(1, 6) = 0 : Matriz(1, 7) = 1 : Matriz(1, 8) = 0
        Matriz(2, 0) = 0 : Matriz(2, 1) = 0 : Matriz(2, 2) = 0 : Matriz(2, 3) = 0 : Matriz(2, 4) = 0 : Matriz(2, 5) = 0 : Matriz(2, 6) = 1 : Matriz(2, 7) = 0 : Matriz(2, 8) = 0
        Matriz(3, 0) = 0 : Matriz(3, 1) = 0 : Matriz(3, 2) = 0 : Matriz(3, 3) = 0 : Matriz(3, 4) = 0 : Matriz(3, 5) = 1 : Matriz(3, 6) = 0 : Matriz(3, 7) = 0 : Matriz(3, 8) = 0
        Matriz(4, 0) = 0 : Matriz(4, 1) = 0 : Matriz(4, 2) = 0 : Matriz(4, 3) = 0 : Matriz(4, 4) = 1 : Matriz(4, 5) = 0 : Matriz(4, 6) = 0 : Matriz(4, 7) = 0 : Matriz(4, 8) = 0
        Matriz(5, 0) = 0 : Matriz(5, 1) = 0 : Matriz(5, 2) = 0 : Matriz(5, 3) = 1 : Matriz(5, 4) = 0 : Matriz(5, 5) = 0 : Matriz(5, 6) = 0 : Matriz(5, 7) = 0 : Matriz(5, 8) = 0
        Matriz(6, 0) = 0 : Matriz(6, 1) = 0 : Matriz(6, 2) = 1 : Matriz(6, 3) = 0 : Matriz(6, 4) = 0 : Matriz(6, 5) = 0 : Matriz(6, 6) = 0 : Matriz(6, 7) = 0 : Matriz(6, 8) = 0
        Matriz(7, 0) = 0 : Matriz(7, 1) = 1 : Matriz(7, 2) = 0 : Matriz(7, 3) = 0 : Matriz(7, 4) = 0 : Matriz(7, 5) = 0 : Matriz(7, 6) = 0 : Matriz(7, 7) = 0 : Matriz(7, 8) = 0
        Matriz(8, 0) = 1 : Matriz(8, 1) = 0 : Matriz(8, 2) = 0 : Matriz(8, 3) = 0 : Matriz(8, 4) = 0 : Matriz(8, 5) = 0 : Matriz(8, 6) = 0 : Matriz(8, 7) = 0 : Matriz(8, 8) = 0
        Return Matriz
    End Function

    'Bordes
    Public Function RealzaBordes()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 0 : Matriz(0, 1) = 0 : Matriz(0, 2) = 0
        Matriz(1, 0) = -1 : Matriz(1, 1) = 1 : Matriz(1, 2) = 0
        Matriz(2, 0) = 0 : Matriz(2, 1) = 0 : Matriz(2, 2) = 0
        Return Matriz
    End Function

    'Laplaciana
    Public Function Laplaciana1()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 0 : Matriz(0, 1) = 1 : Matriz(0, 2) = 0
        Matriz(1, 0) = 1 : Matriz(1, 1) = -4 : Matriz(1, 2) = 1
        Matriz(2, 0) = 0 : Matriz(2, 1) = 1 : Matriz(2, 2) = 0
        Return Matriz
    End Function

    Public Function Laplaciana2()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 0 : Matriz(0, 1) = -1 : Matriz(0, 2) = 0
        Matriz(1, 0) = -1 : Matriz(1, 1) = 4 : Matriz(1, 2) = -1
        Matriz(2, 0) = 0 : Matriz(2, 1) = -1 : Matriz(2, 2) = 0
        Return Matriz
    End Function

    Public Function Laplaciana3()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = -1 : Matriz(0, 1) = -1 : Matriz(0, 2) = -1
        Matriz(1, 0) = -1 : Matriz(1, 1) = 8 : Matriz(1, 2) = -1
        Matriz(2, 0) = -1 : Matriz(2, 1) = -1 : Matriz(2, 2) = -1
        Return Matriz
    End Function

    Public Function Laplaciana4()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 1 : Matriz(0, 1) = -2 : Matriz(0, 2) = 1
        Matriz(1, 0) = -2 : Matriz(1, 1) = 4 : Matriz(1, 2) = -2
        Matriz(2, 0) = 1 : Matriz(2, 1) = -2 : Matriz(2, 2) = 1
        Return Matriz
    End Function

    Public Function LaplacianaHorizont()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 0 : Matriz(0, 1) = 0 : Matriz(0, 2) = 0
        Matriz(1, 0) = -1 : Matriz(1, 1) = 2 : Matriz(1, 2) = -1
        Matriz(2, 0) = 0 : Matriz(2, 1) = 0 : Matriz(2, 2) = 0
        Return Matriz
    End Function

    Public Function LaplacianaVertical()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 0 : Matriz(0, 1) = -1 : Matriz(0, 2) = 0
        Matriz(1, 0) = 0 : Matriz(1, 1) = 2 : Matriz(1, 2) = 0
        Matriz(2, 0) = 0 : Matriz(2, 1) = -1 : Matriz(2, 2) = 0
        Return Matriz
    End Function

    Public Function LaplacianaDiagonal()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = -1 : Matriz(0, 1) = 0 : Matriz(0, 2) = -1
        Matriz(1, 0) = 0 : Matriz(1, 1) = 4 : Matriz(1, 2) = 0
        Matriz(2, 0) = -1 : Matriz(2, 1) = 0 : Matriz(2, 2) = -1
        Return Matriz
    End Function

    'Sobel
    Public Function SobelVertical()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 1 : Matriz(0, 1) = 2 : Matriz(0, 2) = 1
        Matriz(1, 0) = 0 : Matriz(1, 1) = 0 : Matriz(1, 2) = 0
        Matriz(2, 0) = -1 : Matriz(2, 1) = -2 : Matriz(2, 2) = -1
        Return Matriz
    End Function

    Public Function SobelHorizontal()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 1 : Matriz(0, 1) = 0 : Matriz(0, 2) = -1
        Matriz(1, 0) = 2 : Matriz(1, 1) = 0 : Matriz(1, 2) = -2
        Matriz(2, 0) = 1 : Matriz(2, 1) = 0 : Matriz(2, 2) = -1
        Return Matriz
    End Function

    Public Function SobelDiagonalA()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = -2 : Matriz(0, 1) = -1 : Matriz(0, 2) = 0
        Matriz(1, 0) = -1 : Matriz(1, 1) = 0 : Matriz(1, 2) = 1
        Matriz(2, 0) = 0 : Matriz(2, 1) = 1 : Matriz(2, 2) = 2
        Return Matriz
    End Function

    Public Function SobelDiagonalB()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 0 : Matriz(0, 1) = 1 : Matriz(0, 2) = 2
        Matriz(1, 0) = -1 : Matriz(1, 1) = 0 : Matriz(1, 2) = 1
        Matriz(2, 0) = -2 : Matriz(2, 1) = -1 : Matriz(2, 2) = 0
        Return Matriz
    End Function

    'Pasa altos
    Public Function PasaAlto1()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = -1 : Matriz(0, 1) = -1 : Matriz(0, 2) = -1
        Matriz(1, 0) = -1 : Matriz(1, 1) = 9 : Matriz(1, 2) = -1
        Matriz(2, 0) = -1 : Matriz(2, 1) = -1 : Matriz(2, 2) = -1
        Return Matriz
    End Function

    Public Function PasaAlto2()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 0 : Matriz(0, 1) = -1 : Matriz(0, 2) = 0
        Matriz(1, 0) = -1 : Matriz(1, 1) = 5 : Matriz(1, 2) = -1
        Matriz(2, 0) = 0 : Matriz(2, 1) = -1 : Matriz(2, 2) = 0
        Return Matriz
    End Function

    Public Function PasaAlto3()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 0 : Matriz(0, 1) = -1 : Matriz(0, 2) = 0
        Matriz(1, 0) = -1 : Matriz(1, 1) = 20 : Matriz(1, 2) = -1
        Matriz(2, 0) = 0 : Matriz(2, 1) = -1 : Matriz(2, 2) = 0
        Return Matriz
    End Function

    'Pasa bajos
    Public Function PasaBajos1()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 1 : Matriz(0, 1) = 1 : Matriz(0, 2) = 1
        Matriz(1, 0) = 1 : Matriz(1, 1) = 1 : Matriz(1, 2) = 1
        Matriz(2, 0) = 1 : Matriz(2, 1) = 1 : Matriz(2, 2) = 1
        Return Matriz
    End Function

    Public Function PasaBajos2()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 1 : Matriz(0, 1) = 1 : Matriz(0, 2) = 1
        Matriz(1, 0) = 1 : Matriz(1, 1) = 2 : Matriz(1, 2) = 1
        Matriz(2, 0) = 1 : Matriz(2, 1) = 1 : Matriz(2, 2) = 1
        Return Matriz
    End Function

    Public Function PasaBajos3()
        ReDim Matriz(2, 2)
        Matriz(0, 0) = 1 : Matriz(0, 1) = 1 : Matriz(0, 2) = 1
        Matriz(1, 0) = 1 : Matriz(1, 1) = 4 : Matriz(1, 2) = 1
        Matriz(2, 0) = 1 : Matriz(2, 1) = 1 : Matriz(2, 2) = 1
        Return Matriz
    End Function

#End Region

#Region "Morfologicos"

    Public Mascara(,) As Integer

    'Dilatacion
    Private Sub Dilatation_Click(sender As Object, e As EventArgs) Handles Dilatacion.Click
        Try
            Invisible("morfo")
            bmap = New Bitmap(img)
            PictureBox4.Image = Nothing
            tipo = "Dilatacion"
            CargarItems("DEAP")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function MorfoDilatacion(ByVal bmp As Bitmap, ByVal Mascara(,) As Integer)
        Try
            Dim bmp2 = ColorToGrises(bmp)
            Dim Niveles(,) As System.Drawing.Color
            Niveles = Nivel(bmp2)
            Dim tamMascara = Mascara.GetUpperBound(0) \ 2
            Dim bmp3 As New Bitmap(bmp2.Width, bmp2.Height)
            Dim Rojo, Verde, Azul, alfa As Byte
            For i = tamMascara To Niveles.GetUpperBound(0) - tamMascara
                For j = tamMascara To Niveles.GetUpperBound(1) - tamMascara
                    Rojo = 0
                    For mi = -tamMascara To tamMascara
                        For mj = -tamMascara To tamMascara
                            If Rojo < Mascara(mi + tamMascara, mj + tamMascara) * Niveles(i + mi, j + mj).R Then
                                Rojo = Niveles(i + mi, j + mj).R
                            End If
                        Next
                    Next
                    Verde = 0
                    For mi = -tamMascara To tamMascara
                        For mj = -tamMascara To tamMascara
                            If Verde < Mascara(mi + tamMascara, mj + tamMascara) * Niveles(i + mi, j + mj).G Then
                                Verde = Niveles(i + mi, j + mj).G
                            End If
                        Next
                    Next
                    Azul = 0
                    For mi = -tamMascara To tamMascara
                        For mj = -tamMascara To tamMascara
                            If Azul < Mascara(mi + tamMascara, mj + tamMascara) * Niveles(i + mi, j + mj).B Then
                                Azul = Niveles(i + mi, j + mj).B
                            End If
                        Next
                    Next
                    alfa = Niveles(i, j).A
                    bmp3.SetPixel(i, j, Color.FromArgb(alfa, Rojo, Verde, Azul))
                Next
            Next
            Return bmp3
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    'Erosion
    Private Sub Erosion_Click(sender As Object, e As EventArgs) Handles Erosion.Click
        Try
            Invisible("morfo")
            bmap = New Bitmap(img)
            PictureBox4.Image = Nothing
            tipo = "Erosion"
            CargarItems("DEAP")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function MorfoErosion(ByVal bmp As Bitmap, ByVal Mascara(,) As Integer)
        Try
            Dim bmp2 = ColorToGrises(bmp)
            Dim Niveles(,) As System.Drawing.Color
            Niveles = Nivel(bmp2)
            Dim tamMascara = Mascara.GetUpperBound(0) \ 2
            Dim bmp3 As New Bitmap(bmp2.Width, bmp2.Height)
            Dim Rojo, Verde, Azul, alfa As Byte
            For i = tamMascara To Niveles.GetUpperBound(0) - tamMascara
                For j = tamMascara To Niveles.GetUpperBound(1) - tamMascara
                    Rojo = 255
                    For mi = -tamMascara To tamMascara
                        For mj = -tamMascara To tamMascara
                            'Busca el valor mas alto dentro de la máscara
                            If Rojo > Mascara(mi + tamMascara, mj + tamMascara) * Niveles(i + mi, j + mj).R Then
                                Rojo = Niveles(i + mi, j + mj).R
                            End If
                        Next
                    Next
                    Verde = 255
                    For mi = -tamMascara To tamMascara
                        For mj = -tamMascara To tamMascara
                            If Verde > Mascara(mi + tamMascara, mj + tamMascara) * Niveles(i + mi, j + mj).G Then
                                Verde = Niveles(i + mi, j + mj).G
                            End If
                        Next
                    Next
                    Azul = 255
                    For mi = -tamMascara To tamMascara
                        For mj = -tamMascara To tamMascara
                            If Azul > Mascara(mi + tamMascara, mj + tamMascara) * Niveles(i + mi, j + mj).B Then
                                Azul = Niveles(i + mi, j + mj).B
                            End If
                        Next
                    Next
                    alfa = Niveles(i, j).A
                    bmp3.SetPixel(i, j, Color.FromArgb(alfa, Rojo, Verde, Azul))
                Next
            Next
            Return bmp3
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    'Apertura
    Private Sub Apertura_Click(sender As Object, e As EventArgs) Handles Apertura.Click
        Try
            Invisible("morfo")
            bmap = New Bitmap(img)
            PictureBox4.Image = Nothing
            tipo = "Apertura"
            CargarItems("DEAP")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function MorfoApertura(ByVal bmp As Bitmap, ByVal Mascara(,) As Integer)
        Try
            Dim bmp2 = bmp.Clone(New Rectangle(0, 0, bmp.Width, bmp.Height), Imaging.PixelFormat.DontCare)
            Dim bmp3 = MorfoErosion(bmp2, Mascara)
            Dim bmp4 = MorfoDilatacion(bmp3, Mascara)
            Return bmp4
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    'Cierre
    Private Sub Cierre_Click(sender As Object, e As EventArgs) Handles Cierre.Click
        Try
            Invisible("morfo")
            bmap = New Bitmap(img)
            PictureBox4.Image = Nothing
            tipo = "Cierre"
            CargarItems("DEAP")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function MorfoCierre(ByVal bmp As Bitmap, ByVal Mascara(,) As Integer)
        Try
            Dim bmp2 = bmp.Clone(New Rectangle(0, 0, bmp.Width, bmp.Height), Imaging.PixelFormat.DontCare)
            Dim bmp3 = MorfoDilatacion(bmp2, Mascara)
            Dim bmp4 = MorfoErosion(bmp3, Mascara)
            Return bmp4
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

#End Region

#Region "Bordes"

    'RealzaBordes
    Private Sub ToolStripMenuItem3_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Try
            Invisible("bordes")
            bmap = New Bitmap(img)
            PictureBox4.Image = Nothing
            tipo = "RealceBordes"
            CargarItems(tipo)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Laplaciano
    Private Sub Laplaciano_Click(sender As Object, e As EventArgs) Handles Laplaciano1.Click
        Try
            Invisible("bordes")
            bmap = New Bitmap(img)
            PictureBox4.Image = Nothing
            tipo = "Laplaciano"
            CargarItems(tipo)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'sobel
    Private Sub ToolStripMenuItem4_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Try
            Invisible("bordes")
            bmap = New Bitmap(img)
            PictureBox4.Image = Nothing
            tipo = "Sobel"
            CargarItems(tipo)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'UNIR SIN USO
    Private Function Unir(ByVal bmp As ArrayList)
        Try
            Dim bmp2 As New ArrayList(bmp)
            Dim Niveles1(,) As System.Drawing.Color
            Dim Niveles2(,) As System.Drawing.Color
            Dim Niveles3(,) As System.Drawing.Color
            Dim Niveles4(,) As System.Drawing.Color
            Niveles1 = Nivel((bmp2(0)))
            Niveles2 = Nivel((bmp2(1)))
            Niveles3 = Nivel((bmp2(2)))
            Niveles4 = Nivel((bmp2(3)))
            Dim bmp3 As Bitmap
            bmp3 = bmp(0)

            Dim media1, media2, media3, media4 As Double
            Dim rojoaux1, verdeaux1, azulaux1, rojoaux2, verdeaux2, azulaux2, rojoaux3, verdeaux3, azulaux3, rojoaux4, verdeaux4, azulaux4 As Double
            For i = 0 To Niveles1.GetUpperBound(0)
                For j = 0 To Niveles1.GetUpperBound(1)
                    'Calculamos la media
                    rojoaux1 = Niveles1(i, j).R
                    verdeaux1 = Niveles1(i, j).G
                    azulaux1 = Niveles1(i, j).B
                    media1 = CInt((rojoaux1 + verdeaux1 + azulaux1) / 3) 'Hacemos la media

                    rojoaux2 = Niveles2(i, j).R
                    verdeaux2 = Niveles2(i, j).G
                    azulaux2 = Niveles2(i, j).B
                    media2 = CInt((rojoaux2 + verdeaux2 + azulaux2) / 3)

                    rojoaux3 = Niveles3(i, j).R
                    verdeaux3 = Niveles3(i, j).G
                    azulaux3 = Niveles3(i, j).B
                    media3 = CInt((rojoaux3 + verdeaux3 + azulaux3) / 3)

                    rojoaux4 = Niveles4(i, j).R
                    verdeaux4 = Niveles4(i, j).G
                    azulaux4 = Niveles4(i, j).B
                    media4 = CInt((rojoaux4 + verdeaux4 + azulaux4) / 3)

                    Dim mediaTotal = CInt((media1 + media2 + media3 + media4) / 4)
                    bmp3.SetPixel(i, j, Color.FromArgb(255, mediaTotal, mediaTotal, mediaTotal))

                Next
            Next
            Return bmp3
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    'contornos
    Private Sub ToolStripMenuItem5_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Try
            Invisible("Contornos")
            bmap = New Bitmap(img)
            PictureBox4.Image = Nothing
            tipo = "Contornos"
            CargarItems(tipo)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function contornos(ByVal bmp As Bitmap, ByVal contorno As Integer, ByVal valorrojo As Integer, ByVal valorverde As Integer, ByVal valorazul As Integer)
        Try
            Dim bmp2 = bmp
            Dim color1 As Color
            Dim almacena(,) As Integer
            ReDim almacena(bmp2.Width, bmp2.Height)
            'para que no se desborde
            For i = 0 To bmp2.Width - 1 'Recorremos la matriz
                For j = 0 To bmp2.Height - 1
                    color1 = bmp2.GetPixel(i, j)
                    almacena(i, j) = (color1.R * valorrojo + color1.G * valorverde + color1.B * valorazul) / 256
                Next
            Next
            Dim bmp3 As New Bitmap(bmp2.Width, bmp2.Height)
            For i = 1 To bmp3.Width - 1
                For j = 1 To bmp3.Height - 1
                    If Math.Abs(almacena(i, j) - almacena(i, j - 1)) > contorno Or Math.Abs(almacena(i, j) - almacena(i - 1, j)) > contorno Then
                        bmp3.SetPixel(i, j, Color.Black)
                    Else
                        bmp3.SetPixel(i, j, Color.White)
                    End If
                Next
            Next
            Return bmp3
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Filtros"

    'Pasa altos
    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Try
            Invisible("bordes")
            bmap = New Bitmap(img)
            PictureBox4.Image = Nothing
            tipo = "Pasa altos"
            CargarItems(tipo)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Pasa bajos
    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        Try
            Invisible("bordes")
            bmap = New Bitmap(img)
            PictureBox4.Image = Nothing
            tipo = "Pasa bajos"
            CargarItems(tipo)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "Otros"

    'Cuadricula
    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        Try
            Invisible("")
            bmap = New Bitmap(img)
            PictureBox4.Image = Nothing
            newImg = cuadricula(bmap, Color.White, Color.White, 20, 20)
            PintarNuevaImagen(newImg)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function cuadricula(ByVal bmp As Bitmap, ByVal colorHorizontal As Color, ByVal colorVertical As Color, ByVal horizontal As Integer, Optional ByVal vertical As Integer = 20)
        Try
            Dim bmp2 = bmp
            Dim Niveles(,) As System.Drawing.Color
            Niveles = Nivel(bmp2)
            Dim bmp3 As New Bitmap(bmp2.Width, bmp2.Height)

            Dim Rojo, Verde, Azul, alfa As Byte
            For i = 0 To Niveles.GetUpperBound(0)  'Recorremos la matriz
                For j = 0 To Niveles.GetUpperBound(1)
                    Rojo = Niveles(i, j).R
                    Verde = Niveles(i, j).G
                    Azul = Niveles(i, j).B
                    alfa = Niveles(i, j).A
                    bmp3.SetPixel(i, j, Color.FromArgb(alfa, Rojo, Verde, Azul))
                Next
            Next

            For i = 0 To Niveles.GetUpperBound(0) Step horizontal   'Recorremos la matriz
                For j = 0 To Niveles.GetUpperBound(1)
                    bmp3.SetPixel(i, j, colorHorizontal)
                Next
            Next

            For i = 0 To Niveles.GetUpperBound(0)  'Recorremos la matriz
                For j = 0 To Niveles.GetUpperBound(1) Step vertical
                    bmp3.SetPixel(i, j, colorVertical)
                Next
            Next
            Return bmp3
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    'Dibujar
    Dim PuedoPintar As Boolean = False
    Dim Lapiz As New Pen(Brushes.Red, 5)
    Dim Brocha As System.Drawing.SolidBrush
    Dim LColor As System.Windows.Forms.DialogResult
    Dim Grafico As Graphics
    Dim GraPath As New Drawing2D.GraphicsPath(Drawing2D.FillMode.Alternate)
    Dim Cambiar As Boolean = False
    Dim x1, y1, x2, y2

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        Try
            bmap = New Bitmap(img)
            tipo = "Dibujar"
            Invisible(tipo)
            CargarItems(tipo)

            Brocha = New System.Drawing.SolidBrush(Color.Black)
            LColor = New System.Windows.Forms.DialogResult
            LColor = ColorDialog1.ShowDialog
            If LColor = Windows.Forms.DialogResult.OK Then
                Brocha.Color = ColorDialog1.Color
            End If

            PictureBox4.Image = bmap
            PictureBox4.BorderStyle = BorderStyle.FixedSingle
            PictureBox4.Size = bmap.Size
            Grafico = Graphics.FromImage(bmap)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PaletaColores_Click(sender As Object, e As EventArgs) Handles btnColores.Click
        Try
            Brocha = New System.Drawing.SolidBrush(Color.Black)
            LColor = New System.Windows.Forms.DialogResult
            LColor = ColorDialog1.ShowDialog
            If LColor = Windows.Forms.DialogResult.OK Then
                Brocha.Color = ColorDialog1.Color
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDeshacerPintar_Click(sender As Object, e As EventArgs) Handles btnDeshacerPintar.Click
        Try
            bmap = New Bitmap(img)
            PictureBox4.Image = bmap
            Grafico = Graphics.FromImage(PictureBox4.Image)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox4_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseDown
        If tipo = "Dibujar" Then PuedoPintar = True
    End Sub

    Private Sub PictureBox4_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseUp
        Try
            If tipo = "Dibujar" Then
                PuedoPintar = False
                Cambiar = False
                GraPath.Reset()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseMove
        Try
            If tipo = "Dibujar" Then
                If PuedoPintar = True Then
                    Lapiz.Brush = Brocha
                    If Cambiar = False Then
                        x1 = e.X
                        y1 = e.Y
                        Cambiar = True
                    Else
                        x2 = e.X
                        y2 = e.Y
                        GraPath.AddLine(x1, y1, x2, y2)
                        Grafico.DrawPath(Lapiz, GraPath)
                        Cambiar = False
                    End If
                End If
                Grafico.Flush()
                PictureBox4.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

End Class