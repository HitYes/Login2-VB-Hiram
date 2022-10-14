Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Correo.Text = "Peru" Or Correo.Text = "Peru" And Contraseña.Text = "2020" Then
            Me.Hide()

            MsgBox("Correo y contraseña correcta")
            Form2.Show()

        Else

            MsgBox("¡ Clave incorrecta !  Intente De  nuevo por favor")
            Correo.Text = ""
            Contraseña.Text = ""
            Correo.Focus()

        End If
        End Sub

        Private Sub Correo_TextChanged(sender As Object, e As EventArgs) Handles Correo.TextChanged
            Correo.ForeColor = Color.Black
        End Sub

        Private Sub Contraseña_TextChanged(sender As Object, e As EventArgs) Handles Contraseña.TextChanged
            Contraseña.ForeColor = Color.Black
        End Sub

        Private Sub Mostrar_CheckedChanged(sender As Object, e As EventArgs) Handles Mostrar.CheckedChanged
            If Mostrar.Checked = True Then
                Contraseña.UseSystemPasswordChar = False

            Else
                Contraseña.UseSystemPasswordChar = True
            End If
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Contraseña.UseSystemPasswordChar = True
        End Sub
    End Class
