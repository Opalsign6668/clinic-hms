Imports MySql.Data.MySqlClient



Public Class AdmitteLoginForm1
    Dim cona As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb") 'connection for the database
    Dim cmd As New MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim dt As DataTable
    Dim sql As String
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AdmitteLoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(560, 300)
        Me.CenterToScreen()
    End Sub

    Private Sub OK_Click_1(sender As Object, e As EventArgs) Handles OK.Click
        Try

            cona.Open()

            sql = "SELECT * FROM  `addmittpatienlogintbl` ;"
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

                    Dim bedre As bedregistration
                    bedre = New bedregistration
                    bedre.Show()


                    Dim addmitt As AdmitteLoginForm1
                    addmitt = New AdmitteLoginForm1
                    addmitt.Close()
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

    Private Sub Cancel_Click_1(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
