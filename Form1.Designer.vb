<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rbDescuentoCinco = New System.Windows.Forms.RadioButton()
        Me.rbDescuentoDiez = New System.Windows.Forms.RadioButton()
        Me.rbDescuentoQuince = New System.Windows.Forms.RadioButton()
        Me.txtTotalCompraDescuento = New System.Windows.Forms.TextBox()
        Me.txtTotalCompra = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rbDescuentoCinco
        '
        Me.rbDescuentoCinco.AutoSize = True
        Me.rbDescuentoCinco.Font = New System.Drawing.Font("Gabriola", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDescuentoCinco.ForeColor = System.Drawing.Color.DarkOrange
        Me.rbDescuentoCinco.Location = New System.Drawing.Point(348, 12)
        Me.rbDescuentoCinco.Name = "rbDescuentoCinco"
        Me.rbDescuentoCinco.Size = New System.Drawing.Size(138, 33)
        Me.rbDescuentoCinco.TabIndex = 0
        Me.rbDescuentoCinco.TabStop = True
        Me.rbDescuentoCinco.Text = "Descuento del 5%"
        Me.rbDescuentoCinco.UseVisualStyleBackColor = True
        '
        'rbDescuentoDiez
        '
        Me.rbDescuentoDiez.AutoSize = True
        Me.rbDescuentoDiez.Font = New System.Drawing.Font("Gabriola", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDescuentoDiez.ForeColor = System.Drawing.Color.DarkOrange
        Me.rbDescuentoDiez.Location = New System.Drawing.Point(348, 49)
        Me.rbDescuentoDiez.Name = "rbDescuentoDiez"
        Me.rbDescuentoDiez.Size = New System.Drawing.Size(144, 33)
        Me.rbDescuentoDiez.TabIndex = 1
        Me.rbDescuentoDiez.TabStop = True
        Me.rbDescuentoDiez.Text = "Descuento del 10%"
        Me.rbDescuentoDiez.UseVisualStyleBackColor = True
        '
        'rbDescuentoQuince
        '
        Me.rbDescuentoQuince.AutoSize = True
        Me.rbDescuentoQuince.Font = New System.Drawing.Font("Gabriola", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDescuentoQuince.ForeColor = System.Drawing.Color.DarkOrange
        Me.rbDescuentoQuince.Location = New System.Drawing.Point(348, 89)
        Me.rbDescuentoQuince.Name = "rbDescuentoQuince"
        Me.rbDescuentoQuince.Size = New System.Drawing.Size(143, 33)
        Me.rbDescuentoQuince.TabIndex = 2
        Me.rbDescuentoQuince.TabStop = True
        Me.rbDescuentoQuince.Text = "Descuento del 15%"
        Me.rbDescuentoQuince.UseVisualStyleBackColor = True
        '
        'txtTotalCompraDescuento
        '
        Me.txtTotalCompraDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalCompraDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalCompraDescuento.Font = New System.Drawing.Font("Gabriola", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCompraDescuento.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTotalCompraDescuento.Location = New System.Drawing.Point(12, 140)
        Me.txtTotalCompraDescuento.Name = "txtTotalCompraDescuento"
        Me.txtTotalCompraDescuento.Size = New System.Drawing.Size(295, 35)
        Me.txtTotalCompraDescuento.TabIndex = 3
        '
        'txtTotalCompra
        '
        Me.txtTotalCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalCompra.Font = New System.Drawing.Font("Gabriola", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCompra.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTotalCompra.Location = New System.Drawing.Point(12, 48)
        Me.txtTotalCompra.Name = "txtTotalCompra"
        Me.txtTotalCompra.Size = New System.Drawing.Size(295, 35)
        Me.txtTotalCompra.TabIndex = 4
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalcular.Font = New System.Drawing.Font("Gabriola", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalcular.ForeColor = System.Drawing.Color.Yellow
        Me.btnCalcular.Location = New System.Drawing.Point(152, 194)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(155, 56)
        Me.btnCalcular.TabIndex = 5
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gabriola", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(97, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total de la Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gabriola", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(60, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total de la Compra con Descuento"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(495, 264)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtTotalCompra)
        Me.Controls.Add(Me.txtTotalCompraDescuento)
        Me.Controls.Add(Me.rbDescuentoQuince)
        Me.Controls.Add(Me.rbDescuentoDiez)
        Me.Controls.Add(Me.rbDescuentoCinco)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = "Radiobutton"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbDescuentoCinco As Windows.Forms.RadioButton
    Friend WithEvents rbDescuentoDiez As Windows.Forms.RadioButton
    Friend WithEvents rbDescuentoQuince As Windows.Forms.RadioButton
    Friend WithEvents txtTotalCompraDescuento As TextBox
    Friend WithEvents txtTotalCompra As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
