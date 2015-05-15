Imports System.Data.SqlClient

Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_login.Click
        Using cnn As New SqlConnection("Data Source=(local);Initial Catalog=Garden;Integrated Security=True")
            cnn.Open()

            Dim consulta As String = "Select password From usuario where nombre=@Nombre"
            Dim cmd As New SqlCommand(consulta, cnn)
            Dim nombre As String = "admin"
            Dim clave As String = "admin"
            cmd.Parameters.AddWithValue("@Nombre", usuario.Text)

            If usuario.Text = nombre And pass.Text = clave Then
                Me.Visible = False
                Form4.Visible = True
            Else
                Dim Password As String = cmd.ExecuteScalar()
                If Password = pass.Text Then
                    Me.Visible = False
                    Form2.Visible = True
                Else
                    MsgBox("Error de credenciales", MsgBoxStyle.Critical, "Error Login")
                End If
            End If

            
        End Using
        'comentarios 
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        Form4.Visible = True

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass.TextChanged

    End Sub
End Class
