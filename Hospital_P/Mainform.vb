Public Class Mainform
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, PictureBox1.BackColorChanged
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2, 0)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim doctor As New doctorLoginForm1
        doctor = New doctorLoginForm1

        doctor.Show()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim pharma As New pharmacistLoginForm1
        pharma = New pharmacistLoginForm1

        pharma.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim labtec As New labtechniLoginForm1
        labtec = New labtechniLoginForm1

        labtec.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim opd As New OPDLoginForm1
        opd = New OPDLoginForm1
        opd.Show()


    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim addmitt As AdmitteLoginForm1
        addmitt = New AdmitteLoginForm1
        addmitt.Show()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim chil As childrenLoginForm1
        chil = New childrenLoginForm1
        chil.Show()
    End Sub
End Class