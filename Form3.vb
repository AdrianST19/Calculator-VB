Public Class Form3
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = TextBox1.Text + TextBox2.Text
        Label3.Text = "+"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsNumeric(Me.TextBox1.Text) = True And IsNumeric(Me.TextBox2.Text) = True Then
            Me.TextBox3.Text = Str(Val(Me.TextBox1.Text) + Val(Me.TextBox2.Text))
        Else
            Me.TextBox3.Text = "Introduceti numere!"
        End If
        Me.Label3.Text = "+"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If IsNumeric(Me.TextBox1.Text) = True And IsNumeric(Me.TextBox2.Text) = True Then
            Me.TextBox3.Text = Str(Val(Me.TextBox1.Text) - Val(Me.TextBox2.Text))
        Else
            Me.TextBox3.Text = "Introduceti numere!"
        End If
        Me.Label3.Text = "-"
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If IsNumeric(Me.TextBox1.Text) = True And IsNumeric(Me.TextBox2.Text) = True Then
            Me.TextBox3.Text = Str(Val(Me.TextBox1.Text) * Val(Me.TextBox2.Text))
        Else
            Me.TextBox3.Text = "Introduceti numere!"
        End If
        Me.Label3.Text = "*"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Me.TextBox2.Text = "0" Then
            Me.TextBox3.Text = "Impartire la zero!"
        Else
            If IsNumeric(Me.TextBox1.Text) = True And IsNumeric(Me.TextBox2.Text) = True Then
                Me.TextBox3.Text = Str(Val(Me.TextBox1.Text) / Val(Me.TextBox2.Text))
            Else
                Me.TextBox3.Text = "Introduceti numere!"
            End If
        End If
        Me.Label3.Text = "/"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.TextBox3.Text = String.Empty
        Me.TextBox1.Text = String.Empty
        Me.TextBox2.Text = String.Empty
        Me.Label3.Text = String.Empty
        Me.RadioButton1.Checked = False
        Me.RadioButton2.Checked = False
        Me.RadioButton3.Checked = False
        Me.RadioButton4.Checked = False
        Me.RadioButton5.Checked = False
        Me.RadioButton6.Checked = False
        Me.RadioButton7.Checked = False
        Me.CheckBox1.Checked = False
        Me.CheckBox2.Checked = False
        Me.CheckBox3.Checked = False
        Me.CheckBox4.Checked = False
        Me.CheckBox5.Checked = False
        Me.RadioButton1.Show()
        Me.RadioButton2.Show()
        Me.RadioButton3.Show()
        Me.RadioButton4.Show()
        Me.RadioButton5.Show()
        Me.CheckBox1.Show()
        Me.CheckBox2.Show()
        Me.CheckBox3.Show()
        Me.CheckBox4.Show()
        Me.CheckBox5.Show()


    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.TextBox3.Text = Me.TextBox1.Text + Me.TextBox2.Text
        Me.Label3.Text = "+"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If IsNumeric(Me.TextBox1.Text) = True And IsNumeric(Me.TextBox2.Text) = True Then
            Me.TextBox3.Text = Str(Val(Me.TextBox1.Text) + Val(Me.TextBox2.Text))
        Else
            Me.TextBox3.Text = "Introduceti numere!"
        End If
        Me.Label3.Text = "+"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If IsNumeric(Me.TextBox1.Text) = True And IsNumeric(Me.TextBox2.Text) = True Then
            Me.TextBox3.Text = Str(Val(Me.TextBox1.Text) - Val(Me.TextBox2.Text))
        Else
            Me.TextBox3.Text = "Introduceti numere!"
        End If
        Me.Label3.Text = "-"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If IsNumeric(Me.TextBox1.Text) = True And IsNumeric(Me.TextBox2.Text) = True Then
            Me.TextBox3.Text = Str(Val(Me.TextBox1.Text) * Val(Me.TextBox2.Text))
        Else
            Me.TextBox3.Text = "Introduceti numere!"
        End If
        Me.Label3.Text = "*"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If Me.TextBox2.Text = "0" Then
            Me.TextBox3.Text = "Impartire la zero!"
        Else
            If IsNumeric(Me.TextBox1.Text) = True And IsNumeric(Me.TextBox2.Text) = True Then
                Me.TextBox3.Text = Str(Val(Me.TextBox1.Text) / Val(Me.TextBox2.Text))
            Else
                Me.TextBox3.Text = "Introduceti numere!"
            End If
        End If
        Me.Label3.Text = "/"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.Button1.Visible = False
            Me.RadioButton1.Visible = False
        Else
            Me.Button1.Visible = True
            Me.RadioButton1.Visible = True

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If Me.CheckBox2.Checked = True Then
            Me.Button2.Visible = False
            Me.RadioButton2.Visible = False
        Else
            Me.Button2.Visible = True
            Me.RadioButton2.Visible = True

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If Me.CheckBox3.Checked = True Then
            Me.Button4.Visible = False
            Me.RadioButton3.Visible = False
        Else
            Me.Button4.Visible = True
            Me.RadioButton3.Visible = True

        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If Me.CheckBox4.Checked = True Then
            Me.Button5.Visible = False
            Me.RadioButton4.Visible = False
        Else
            Me.Button5.Visible = True
            Me.RadioButton4.Visible = True

        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If Me.CheckBox5.Checked = True Then
            Me.Button6.Visible = False
            Me.RadioButton5.Visible = False
        Else
            Me.Button6.Visible = True
            Me.RadioButton5.Visible = True

        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If Me.RadioButton6.Checked = True Then
            Me.RadioButton1.Visible = True
            Me.RadioButton2.Visible = True
            Me.RadioButton3.Visible = True
            Me.RadioButton4.Visible = True
            Me.RadioButton5.Visible = True
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False

        Else
            Me.RadioButton1.Visible = False
            Me.RadioButton2.Visible = False
            Me.RadioButton3.Visible = False
            Me.RadioButton4.Visible = False
            Me.RadioButton5.Visible = False
            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button4.Visible = True
            Me.Button5.Visible = True
            Me.Button6.Visible = True
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        End
    End Sub
End Class
