<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonCALCULAR = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonSALIR = New System.Windows.Forms.Button()
        Me.NOMBRE = New System.Windows.Forms.ListBox()
        Me.NIT = New System.Windows.Forms.ListBox()
        Me.CANTIDAD = New System.Windows.Forms.ListBox()
        Me.TIPO = New System.Windows.Forms.ListBox()
        Me.EXTRA = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TOTAL = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE DEL CLIENTE"
        '
        'TB1
        '
        Me.TB1.Location = New System.Drawing.Point(25, 38)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(115, 20)
        Me.TB1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(22, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NIT DEL CLIENTE"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(25, 93)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(115, 20)
        Me.MaskedTextBox2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(24, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CANTIDAD DE PERSONAS "
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(25, 165)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(115, 20)
        Me.MaskedTextBox3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.Location = New System.Drawing.Point(22, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TIPO DE HABITACION"
        '
        'ButtonCALCULAR
        '
        Me.ButtonCALCULAR.Location = New System.Drawing.Point(253, 55)
        Me.ButtonCALCULAR.Name = "ButtonCALCULAR"
        Me.ButtonCALCULAR.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCALCULAR.TabIndex = 18
        Me.ButtonCALCULAR.Text = "CALCULAR"
        Me.ButtonCALCULAR.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(253, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "LIMPIAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonSALIR
        '
        Me.ButtonSALIR.Location = New System.Drawing.Point(253, 125)
        Me.ButtonSALIR.Name = "ButtonSALIR"
        Me.ButtonSALIR.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSALIR.TabIndex = 20
        Me.ButtonSALIR.Text = "SALIR"
        Me.ButtonSALIR.UseVisualStyleBackColor = True
        '
        'NOMBRE
        '
        Me.NOMBRE.FormattingEnabled = True
        Me.NOMBRE.Location = New System.Drawing.Point(334, 19)
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Size = New System.Drawing.Size(120, 69)
        Me.NOMBRE.TabIndex = 21
        '
        'NIT
        '
        Me.NIT.FormattingEnabled = True
        Me.NIT.Location = New System.Drawing.Point(460, 21)
        Me.NIT.Name = "NIT"
        Me.NIT.Size = New System.Drawing.Size(120, 69)
        Me.NIT.TabIndex = 22
        '
        'CANTIDAD
        '
        Me.CANTIDAD.FormattingEnabled = True
        Me.CANTIDAD.Location = New System.Drawing.Point(586, 19)
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.Size = New System.Drawing.Size(120, 69)
        Me.CANTIDAD.TabIndex = 23
        '
        'TIPO
        '
        Me.TIPO.FormattingEnabled = True
        Me.TIPO.Location = New System.Drawing.Point(334, 94)
        Me.TIPO.Name = "TIPO"
        Me.TIPO.Size = New System.Drawing.Size(120, 69)
        Me.TIPO.TabIndex = 24
        '
        'EXTRA
        '
        Me.EXTRA.FormattingEnabled = True
        Me.EXTRA.Location = New System.Drawing.Point(460, 96)
        Me.EXTRA.Name = "EXTRA"
        Me.EXTRA.Size = New System.Drawing.Size(120, 69)
        Me.EXTRA.TabIndex = 25
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ESTANDAR", "A/C", "JACUZZI"})
        Me.ComboBox1.Location = New System.Drawing.Point(19, 227)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label5.Location = New System.Drawing.Point(16, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "EXTRAS"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(19, 280)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(115, 20)
        Me.MaskedTextBox1.TabIndex = 28
        '
        'TOTAL
        '
        Me.TOTAL.FormattingEnabled = True
        Me.TOTAL.Location = New System.Drawing.Point(586, 96)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Size = New System.Drawing.Size(120, 69)
        Me.TOTAL.TabIndex = 29
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TOTAL)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.EXTRA)
        Me.Controls.Add(Me.TIPO)
        Me.Controls.Add(Me.CANTIDAD)
        Me.Controls.Add(Me.NIT)
        Me.Controls.Add(Me.NOMBRE)
        Me.Controls.Add(Me.ButtonSALIR)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonCALCULAR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TB1 As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonCALCULAR As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonSALIR As Button
    Friend WithEvents NOMBRE As ListBox
    Friend WithEvents NIT As ListBox
    Friend WithEvents CANTIDAD As ListBox
    Friend WithEvents TIPO As ListBox
    Friend WithEvents EXTRA As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents TOTAL As ListBox
End Class
