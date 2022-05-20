Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub ButtonSALIR_Click(sender As Object, e As EventArgs) Handles ButtonSALIR.Click
        If MsgBox("¿DESEA SALIR?", vbYesNo) = vbYes Then
            End
        End If
    End Sub

    Private Sub ButtonCALCULAR_Click(sender As Object, e As EventArgs) Handles ButtonCALCULAR.Click

        If ComboBox1.SelectedIndex = -1 Then
            MsgBox(" Seleccione todos los campos por favor")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar()
    End Sub




End Class
