Module Module1

    Public Subtot1 As Double
    Public Subtot2 As Double
    Public Subtot3 As Double
    Public Pasajeros As Integer
    Public Descuento As Double
    Public Subtotal As Double
    Public Total As Double
    Sub LIMPIAR_ENTRADAS()
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False
        Form1.CheckBox3.Checked = False
        Form1.TextBox1.Clear()
    End Sub
    Sub LIMPIAR_SALIDAS()
        Form2.TextBox1.Clear()
        Form2.TextBox2.Clear()
        Form2.TextBox3.Clear()
    End Sub
End Module
