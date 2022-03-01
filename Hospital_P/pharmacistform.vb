Imports MySql.Data.MySqlClient

Public Class pharmacistform
    Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
    Private Sub updateTable()
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        con.Open()
        Dim commd As New MySqlCommand                  'Object for mysqlcomand   
        Dim da As New MySqlDataAdapter                 'Object for mysqlDataAdapter  
        Dim ttb As New DataTable
        Dim dtr As MySqlDataReader
        commd.Connection = con
        commd.CommandText = "SELECT * FROM `doctorsformstbl`"
        dtr = commd.ExecuteReader
        ttb.Load(dtr)
        dtr.Close()
        con.Close()
        DataGridView1.DataSource = ttb
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        updateTable()
        Try
            con.Open()
            Dim su As String 'filling dataAdapter for the Doctor's table
            Dim cmdu As New MySqlCommand
            Dim daptu As New MySqlDataAdapter
            Dim tu As New DataTable
            su = "SELECT * FROM `doctorsformstbl`"
            cmdu.Connection = con
            cmdu.CommandText = su
            daptu.SelectCommand = cmdu
            daptu.Fill(tu)
        Catch ex As Exception ' an exeption thrown for the codes
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2, 0)
    End Sub

    Private Sub txtseacrh_TextChanged(sender As Object, e As EventArgs) Handles txtseacrh.TextChanged
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Dim sa As String
        Dim cm As New MySqlCommand
        Dim dap As New MySqlDataAdapter
        Dim ttb As New DataTable
        sa = "SELECT * FROM `doctorsformstbl` WHERE `PATIENT_ID` like '%" & txtseacrh.Text & "%'"
        cm.Connection = con  'connection for patient table
        cm.CommandText = sa
        dap.SelectCommand = cm
        dap.Fill(ttb)
        DataGridView1.DataSource = ttb
        con.Close()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            con.Open()
            sql = "DELETE FROM `doctorsformstbl` WHERE `ID` =" & Me.Text & ""
            cmd.Connection = con
            cmd.CommandText = sql
            Dim i As String
            i = cmd.ExecuteNonQuery
            If i > 0 Then ' throwing an exeption for table
                MsgBox("Record has been DELETED successfully!")

            Else
                MsgBox(" Record has not  been DELETED successfully!")
            End If
            updateTable()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Try
            con.Open()
            Dim sql As String
            Dim cmd As New MySqlCommand

            sql = "INSERT INTO `doctorsformstbl`(`ID`, `PATIENT_ID`, `FIRST_NAME`, `SURNAME`, `AGE`, `MEDICAL_HISTORY`, `DIAGNOSES`, `SYMPTOMS`, `TREATMENT`,`CONFIRMATION`, `LAB_TEST`, `DOCTOR`,`PHARMACIST`, `DATE`,`TIME`)
            VALUES ('" & Me.Text & "','" & txtid.Text & "','" & txtname.Text & "','" & txtsur.Text & "','" & txtage.Text & "','" & txthistory.Text & "','" & txtdiagnoses.Text & "','" & txtsympton.Text & "','" & txttreatment.Text & "','" & Cbconfirmation.Text & "','" & txtlab.Text & "','" & txtdoctor.Text & "','" & txtpharmaname.Text & "','" & dtp.Text & "','" & txttime.Text & "') "
            cmd.CommandText = sql
            cmd.Connection = con
            Dim i As String
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("New record inserted succefully!")
            Else
                MsgBox("!!! Fail to insert details")
            End If
            updateTable()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Dim cm As New MySqlCommand                  'Object for mysqlcomand   
        Dim sql As String
        Try
            con.Open()


            Dim dap As New MySqlDataAdapter
            Dim ttb As New DataTable
            sql = "SELECT * FROM `doctorsformstbl`"
            cm.Connection = con
            cm.CommandText = sql
            dap.SelectCommand = cm
            dap.Fill(ttb)
            DataGridView1.DataSource = ttb

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try






    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click

    End Sub

    Private Sub btndone_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Me.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtid.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtsur.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtage.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txthistory.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txtdiagnoses.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        txtsympton.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        txttreatment.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        Cbconfirmation.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        txtlab.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        txtdoctor.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        txtpharmaname.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
        txttime.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString
    End Sub

    Private Sub ExistToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure to want to exit Application", MsgBoxStyle.YesNo, "Notification") = MsgBoxResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub DoctorsDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoctorsDetailsToolStripMenuItem.Click
        Dim doctodetails As New Doctordetailsform
        doctodetails = New Doctordetailsform
        doctodetails.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As New About
        about = New About
        about.Show()
    End Sub

    Private Sub btndone_Click_1(sender As Object, e As EventArgs) Handles btndone.Click
        txtid.Clear()
        txtname.Clear()
        txtsur.Clear()
        txtage.Clear()
        txthistory.Clear()
        txtdiagnoses.Clear()
        txtsympton.Clear()
        txttreatment.Clear()
        txtlab.Clear()
        txtdoctor.Clear()

    End Sub
End Class