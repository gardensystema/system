Public Class Form5

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
        Form2.Visible = True


    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GardenDataSet.docente' table. You can move, or remove it, as needed.
        'Me.DocenteTableAdapter.Fill(Me.GardenDataSet.docente)

    End Sub

    Private Sub DocenteBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.DocenteTableAdapter.Fill(Me.GardenDataSet.docente)
    End Sub
End Class