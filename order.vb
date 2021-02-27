Public Class order

    Dim cost(20) As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Main.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cost(0) = Val(NumericUpDown1.Text) * 60
        cost(1) = Val(NumericUpDown2.Text) * 70
        cost(2) = Val(NumericUpDown3.Text) * 90
        cost(3) = Val(NumericUpDown4.Text) * 120
        cost(4) = Val(NumericUpDown5.Text) * 100
        cost(5) = Val(NumericUpDown6.Text) * 110
        cost(6) = Val(NumericUpDown7.Text) * 180
        cost(7) = Val(NumericUpDown8.Text) * 150
        cost(8) = Val(NumericUpDown9.Text) * 120
        cost(9) = Val(NumericUpDown10.Text) * 100
        cost(10) = Val(NumericUpDown11.Text) * 90
        cost(11) = Val(NumericUpDown12.Text) * 90
        cost(12) = Val(NumericUpDown13.Text) * 90
        cost(13) = Val(NumericUpDown14.Text) * 90
        cost(14) = Val(NumericUpDown15.Text) * 90
        cost(15) = Val(NumericUpDown16.Text) * 100
        cost(16) = Val(NumericUpDown17.Text) * 90
        cost(17) = Val(NumericUpDown18.Text) * 180
        cost(18) = Val(NumericUpDown19.Text) * 120
        cost(19) = Val(NumericUpDown20.Text) * 150
        cost(20) = cost(0) + cost(1) + cost(2) + cost(3) + cost(4) + cost(5) + cost(6) + cost(7) + cost(8) + cost(9) + cost(10) + cost(11) + cost(12) + cost(13) + cost(14) + cost(15) + cost(16) + cost(17) + cost(18) + cost(19)
        TextBox2.Text = cost(20)

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        terms.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Main.Show()
    End Sub
End Class