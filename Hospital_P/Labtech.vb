Imports MySql.Data.MySqlClient

Public Class LabTech
    Public Property DataGrid_InventoryAllocation As Object
    Public Property GridRow1 As Object

    Private Sub updateTable()
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        con.Open()
        Dim commd As New MySqlCommand                  'Object for mysqlcomand   
        Dim da As New MySqlDataAdapter                 'Object for mysqlDataAdapter  
        Dim ttb As New DataTable
        Dim dtr As MySqlDataReader
        commd.Connection = con
        commd.CommandText = "SELECT * FROM `labtechtbl`"
        dtr = commd.ExecuteReader
        ttb.Load(dtr)
        dtr.Close()
        con.Close()
        DataGridView1.DataSource = ttb
    End Sub


    Private Sub DoctorsDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoctorsDetailsToolStripMenuItem.Click
        Dim mdi As Doctordetailsform
        mdi = New Doctordetailsform
        mdi = Doctordetailsform
        mdi.Show()
    End Sub

    Private Sub ConsultancyDoctotorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim doctorform As DoctorForm
        doctorform = New DoctorForm
        doctorform.Show()

    End Sub

    Private Sub ExistToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure to want to exit Application", MsgBoxStyle.YesNo, "Notification") = MsgBoxResult.Yes Then
            End
        ElseIf MsgBox("Are you sure to want to exit Application", MsgBoxStyle.YesNo, "Notification") = MsgBoxResult.No Then
            Exit Sub
        End If
        Exit Sub
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        updateTable()
        Try
            con.Open()
            Dim su As String 'filling dataAdapter for the Doctor's table
            Dim cmdu As New MySqlCommand
            Dim daptu As New MySqlDataAdapter
            Dim tu As New DataTable
            su = "SELECT * FROM `labtechtbl`"
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
        sa = "SELECT * FROM `labtechtbl` WHERE `PATIENT_ID` like '%" & txtseacrh.Text & "%'"
        cm.Connection = con  'connection for patient table
        cm.CommandText = sa
        dap.SelectCommand = cm
        dap.Fill(ttb)
        DataGridView1.DataSource = ttb
        con.Close()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")

        Try
            con.Open()
            Dim sql As String
            Dim cm As New MySqlCommand
            Dim dap As New MySqlDataAdapter
            Dim ttb As New DataTable
            sql = "SELECT * FROM `labtechtbl`"
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

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            con.Open()
            sql = " INSERT INTO `labtechtbl`(`ID`, `PATIENT_ID`, `FIRST_NAME`, `SURNAME`, `AGE`, `CONFIRMATION`, `TYPE_OF_TEST`, `OTHER_TEST`, `DIAGNOSE`, `REMARK`, `DOCTOR`, `DATE`)
            VALUES ('" & Me.Text & "','" & txtid.Text & "','" & txtname.Text & "','" & txtsur.Text & "','" & txtage.Text & "','" & cboconfirm.Text & "','" & ComboBox1.Text & "','" & txtothers.Text & "','" & txtdiagnosis.Text & "','" & txtremark.Text & "','" & txtdoctor.Text & "','" & dtp.Text & "') "
            cmd.Connection = con
            cmd.CommandText = sql
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

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Try
            Dim commd As New MySqlCommand                  'Object for mysqlcomand   
            Dim sql As String
            con.Open()
            Dim i As String
            commd.Connection = con
            sql = "  UPDATE `labtechtbl` SET `ID`='" & Me.Text & "',`PATIENT_ID`='" & txtid.Text & "',`FIRST_NAME`='" & txtname.Text & "',`SURNAME`='" & txtsur.Text & "',`AGE`='" & txtage.Text & "',`CONFIRMATION`='" & cboconfirm.Text & "',`TYPE_OF_TEST`='" & ComboBox1.Text & "',`OTHER_TEST`='" & txtothers.Text & "',`DIAGNOSE`='" & txtdiagnosis.Text & "',`REMARK`='" & txtremark.Text & "',`DOCTOR`='" & txtdoctor.Text & "',`DATE`='" & dtp.Text & "'  WHERE `ID`=" & Me.Text & ""
            commd.CommandText = sql
            i = commd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("data updated:" & i & "rows")
            Else
                MsgBox("data not updated:" & i & "rows")
            End If
            updateTable()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            con.Open()
            sql = "DELETE FROM `labtechtbl` WHERE `ID` =" & Me.Text & ""
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

    Private Sub btndone_Click(sender As Object, e As EventArgs) Handles btndone.Click
        txtid.Clear()
        txtname.Clear()
        txtsur.Clear()
        txtage.Clear()
        txtothers.Clear()
        txtdiagnosis.Clear()
        txtremark.Clear()
        txtdoctor.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Me.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtid.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtsur.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtage.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        cboconfirm.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        txtothers.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        txtdiagnosis.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        txtremark.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        txtdoctor.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        ' dtp.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString


        Try
            If Not e.RowIndex = -1 Then
                If e.ColumnIndex = 11 Then
                    dtp = New DateTimePicker()
                    DataGrid_InventoryAllocation.Controls.Add(dtp)
                    dtp.Format = DateTimePickerFormat.Short
                    Dim oRectangle As Rectangle = DataGrid_InventoryAllocation.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                    dtp.Size = New Size(oRectangle.Width, oRectangle.Height)
                    dtp.Location = New Point(oRectangle.X, oRectangle.Y)

                End If
            End If
            If e.ColumnIndex = 11 And e.RowIndex <> -1 Then
                AddHandler dtp.CloseUp, AddressOf txtTimePickerClose
                GridRow1.Cells.Item("ExpectedShipDate").Value = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtTimePickerClose(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub
End Class