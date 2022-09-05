Imports System.Windows

Public Class Form1
    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub CALCULARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem1.Click

        If (TextBox1.Text = "") Then
            MsgBox("ERROR, NO INGRESÓ CANTIDAD DE PASAJEROS")
            TextBox1.Focus()
            Exit Sub
        End If
        Pasajeros = TextBox1.Text

        If (RadioButton1.Checked) And (CheckBox1.Checked) Then
            Subtot1 = 150 * Pasajeros
        ElseIf (RadioButton2.Checked) And (CheckBox1.Checked) Then
            Subtot1 = 250.99 * Pasajeros
        ElseIf (RadioButton3.Checked) And (CheckBox1.Checked) Then
            Subtot1 = 125.99 * Pasajeros
        End If

        If (RadioButton1.Checked) And (CheckBox2.Checked) Then
            Subtot2 = 175.99 * Pasajeros
        ElseIf (RadioButton2.Checked) And (CheckBox2.Checked) Then
            Subtot2 = 325.99 * Pasajeros
        ElseIf (RadioButton3.Checked) And (CheckBox2.Checked) Then
            Subtot2 = 175.99 * Pasajeros
        End If

        If (RadioButton1.Checked) And (CheckBox3.Checked) Then
            Subtot3 = 250.99 * Pasajeros
        ElseIf (RadioButton2.Checked) And (CheckBox3.Checked) Then
            Subtot3 = 450.99 * Pasajeros
        ElseIf (RadioButton3.Checked) And (CheckBox3.Checked) Then
            Subtot3 = 275.99 * Pasajeros
        End If

        Subtotal = Subtot1 + Subtot2 + Subtot3

        If (RadioButton2.Checked) And (CheckBox2.Checked) And (CheckBox3.Checked) Then
            Descuento = Subtotal * 0.002
        ElseIf (RadioButton1.Checked) And (CheckBox1.Checked) And (CheckBox2.Checked) And (CheckBox3.Checked) Then
            Descuento = Subtotal * 0.1
        Else Descuento = 0
        End If

        Me.Hide()
        Form2.Show()
    End Sub

End Class
