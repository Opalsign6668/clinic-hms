Imports MySql.Data.MySqlClient

Public Class OPD
    Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
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
        commd.CommandText = "SELECT * FROM `opdmysqltbl`"
        dtr = commd.ExecuteReader
        ttb.Load(dtr)
        dtr.Close()
        con.Close()
        DataGridView1.DataSource = ttb
    End Sub

    Private Sub OPD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        updateTable()
        Try
            con.Open()
            Dim su As String 'filling dataAdapter for the Doctor's table
            Dim cmdu As New MySqlCommand
            Dim daptu As New MySqlDataAdapter
            Dim tu As New DataTable
            su = "SELECT * FROM `opdmysqltbl`"
            cmdu.Connection = con
            cmdu.CommandText = su
            daptu.SelectCommand = cmdu
            daptu.Fill(tu)
        Catch ex As Exception ' an exeption thrown for the codes
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2, 0)  'Positioning window form to center
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Dim sa As String
        Dim cm As New MySqlCommand
        Dim dap As New MySqlDataAdapter
        Dim ttb As New DataTable
        sa = "SELECT * FROM `opdmysqltbl` WHERE `PATIENT_ID` like '%" & txtsearch.Text & "%'"

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
            sql = "SELECT * FROM `opdmysqltbl`"
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
            sql = "INSERT INTO `opdmysqltbl`(`ID`, `PATIENT_ID`, `FIRST_NAME`, `SURNAME`, `AGE`, `GENDER`, `MARITAL_STATUS`, `TEMPERATURE`, `WEIGHT`, `BLOOD_GROUP`, `CONTACT`, `HOME_ADDRESS`, `WORK_ADDRESS`, `NEXT_OF_KING_NAME`,`BLOOD_PRESSURE`, `NEXT_OF_KING_CONTACT`, `DATE`, `TIME`) 
            VALUES ('" & Me.Text & "','" & txtid.Text & "','" & txtfname.Text & "','" & txtsname.Text & "','" & txtage.Text & "','" & cbosex.Text & "','" & cbomaritaltatus.Text & "','" & txttemp.Text & "','" & txtweight.Text & "','" & cboblood.Text & "','" & txtcontact.Text & "','" & txthadd.Text & "','" & txtwork.Text & "','" & txtkinname.Text & "','" & txtkinadd.Text & "','" & txtnexphone.Text & "','" & txtTimePicker.Text & "','" & txttime.Text & "')"
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

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            con.Open()
            sql = "DELETE FROM `opdmysqltbl` WHERE `ID` =" & Me.Text & ""
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

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Try
            Dim commd As New MySqlCommand                  'Object for mysqlcomand   
            Dim sql As String
            con.Open()
            Dim i As String
            commd.Connection = con
            sql = " UPDATE `opdmysqltbl` SET `ID`='" & Me.Text & "',`PATIENT_ID`='" & txtid.Text & "',`FIRST_NAME`='" & txtfname.Text & "',`SURNAME`='" & txtsname.Text & "',`AGE`='" & txtage.Text & "',`GENDER`='" & cbosex.Text & "',`MARITAL_STATUS`='" & cbomaritaltatus.Text & "',`TEMPERATURE`='" & txttemp.Text & "',`WEIGHT`='" & txtweight.Text & "',`BLOOD_GROUP`='" & cboblood.Text & "',`CONTACT`='" & txtcontact.Text & "',`HOME_ADDRESS`='" & txthadd.Text & "',`WORK_ADDRESS`='" & txtwork.Text & "',`NEXT_OF_KING_NAME`='" & txtkinname.Text & "', `BLOOD_PRESSURE`='" & txtkinadd.Text & "',`NEXT_OF_KING_CONTACT`='" & txtnexphone.Text & "',`DATE`=' " & txtTimePicker.Text & "',`TIME`=' " & txttime.Text & "'  WHERE `ID`=" & Me.Text & ""
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Me.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtid.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtfname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtsname.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtage.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        cbosex.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        cbomaritaltatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        txttemp.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        txtweight.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        cboblood.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        txtcontact.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        txthadd.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        txtwork.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString

        txtkinname.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString
        txtkinadd.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString
        txtnexphone.Text = DataGridView1.CurrentRow.Cells(15).Value.ToString
        '  txtTimePicker.Text = DataGridView1.CurrentRow.Cells(16).Value.ToString
        txttime.Text = DataGridView1.CurrentRow.Cells(17).Value.ToString
        Try
            If Not e.RowIndex = -1 Then
                If e.ColumnIndex = 16 Then
                    txtTimePicker = New DateTimePicker()
                    DataGrid_InventoryAllocation.Controls.Add(txtTimePicker)
                    txtTimePicker.Format = DateTimePickerFormat.Short
                    Dim oRectangle As Rectangle = DataGrid_InventoryAllocation.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                    txtTimePicker.Size = New Size(oRectangle.Width, oRectangle.Height)
                    txtTimePicker.Location = New Point(oRectangle.X, oRectangle.Y)

                End If
            End If
            If e.ColumnIndex = 16 And e.RowIndex <> -1 Then
                AddHandler txtTimePicker.CloseUp, AddressOf txtTimePickerClose
                GridRow1.Cells.Item("ExpectedShipDate").Value = ""
            End If

            'If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then

            '    txtDateTimePicker1.Value = Convert.ToDateTime(DataGridView1.Rows(e.RowIndex).Cells(16).Value)
            '    txtDateTimePicker1.Format = DateTimePickerFormat.Custom
            '    txtDateTimePicker1.CustomFormat = "dddd . MMMM dd, yyy"

            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtTimePickerClose(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub btndone_Click(sender As Object, e As EventArgs) Handles btndone.Click
        txtid.Clear()
        txtfname.Clear()
        txtsname.Clear()
        txtage.Clear()
        txttemp.Clear()
        txtweight.Clear()
        txtcontact.Clear()
        txthadd.Clear()
        txtwork.Clear()
        txtkinname.Clear()
        txtkinadd.Clear()
        txtnexphone.Clear()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As New About
        about = New About
        about.Show()
    End Sub

    Private Sub txtttsearchsur_TextChanged(sender As Object, e As EventArgs) Handles txtttsearchsur.TextChanged
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Dim sa As String
        Dim cm As New MySqlCommand
        Dim dap As New MySqlDataAdapter
        Dim ttb As New DataTable
        sa = "SELECT * FROM `opdmysqltbl` WHERE `SURNAME` like '%" & txtttsearchsur.Text & "%'"
        cm.Connection = con  'connection for patient table
        cm.CommandText = sa
        dap.SelectCommand = cm
        dap.Fill(ttb)
        DataGridView1.DataSource = ttb
    End Sub
End Class