Public Class Form2
    Private Sub SALIRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem1.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub LIMPIAR_SALIDASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIAR_SALIDASToolStripMenuItem.Click
        LIMPIAR_SALIDAS()
    End Sub

    Private Sub MOSTRARRESULTADOSMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARRESULTADOSMenuItem.Click
        TextBox1.Text = Subtotal
        TextBox2.Text = Descuento

        Total = Subtotal - Descuento
        TextBox3.Text = Math.Round(Total, 2)
    End Sub
End Class