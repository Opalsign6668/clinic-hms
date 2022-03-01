
Imports MySql.Data.MySqlClient
Public Class OPDLoginForm1
    Dim cona As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb") 'connection for the database

    Dim cmd As New MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim dt As DataTable
    Dim sql As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub OPDLoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(560, 300)
        Me.CenterToScreen()
    End Sub

    Private Sub OK_Click_1(sender As Object, e As EventArgs) Handles OK.Click
        Try

            cona.Open()

            sql = "SELECT * FROM `doctorpasswordtbl` "
            cmd = New MySqlCommand
            cmd.Connection = cona
            cmd.CommandText = sql

            cmd.Parameters.AddWithValue("@user", txt_Username.Text)
            cmd.Parameters.AddWithValue("@hospital", txt_Password.Text)
            cmd.ExecuteNonQuery()

            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cona.Close()


        End Try
        Dim Username, Password As String
        If dt.Rows.Count > 0 Then
            Username = dt.Rows(0).Item("Username") 'Password set in the database
            Password = dt.Rows(0).Item("Password") '
            If txt_Username.Text = "user" And txt_Password.Text = "hospital" Then

                Dim Exist As String = DialogResult
                Exist = MessageBox.Show("Confirm if you want to login ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Exist = DialogResult.Yes Then

                    Dim opd As New OPD
                    opd = New OPD
                    opd.Show()


                    Dim Opdd As OPDLoginForm1
                    Opdd = New OPDLoginForm1
                    Opdd.Close()
                    Me.Close()
                Else
                    txt_Password.Text = ""
                    txt_Username.Text = ""
                End If

            Else
                MsgBox("Incorrect login details", MsgBoxStyle.Critical)

                txt_Password.Text = ""
                txt_Username.Text = ""
                Return

            End If

        End If
    End Sub
End Class
