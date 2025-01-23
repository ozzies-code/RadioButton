Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim totalCompra As Double = Val(txtTotalCompra.Text)
        Dim totalCompraDescuento As Double = 0

        If rbDescuentoCinco.Checked = True Then
            totalCompraDescuento = totalCompra - (totalCompra * 0.05)
        End If

        If rbDescuentoDiez.Checked = True Then
            totalCompraDescuento = totalCompra - (totalCompra * 0.1)
        End If

        If rbDescuentoQuince.Checked = True Then
            totalCompraDescuento = totalCompra - (totalCompra * 0.15)
        End If

        txtTotalCompraDescuento.Text = totalCompraDescuento.ToString

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbDescuentoCinco.Enabled = False
        rbDescuentoDiez.Enabled = False
        rbDescuentoQuince.Enabled = False
    End Sub

    Private Sub txtTotalCompra_TextChanged(sender As Object, e As EventArgs) Handles txtTotalCompra.TextChanged
        rbDescuentoCinco.Enabled = True
        rbDescuentoDiez.Enabled = True
        rbDescuentoQuince.Enabled = True
    End Sub

End Class