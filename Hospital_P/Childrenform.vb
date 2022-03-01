Imports MySql.Data.MySqlClient

Public Class Childrenform
    Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
    Public Property DataGrid_InventoryAllocation As Object
    Public Property GridRow1 As Object

    Private Sub Childrenform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        updateTable()
        Try
            con.Open()
            Dim su As String 'filling dataAdapter for the Doctor's table
            Dim cmdu As New MySqlCommand
            Dim daptu As New MySqlDataAdapter
            Dim tu As New DataTable
            su = "SELECT * FROM `childrentbl` "
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
    Private Sub updateTable()
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        con.Open()
        Dim commd As New MySqlCommand                  'Object for mysqlcomand   
        Dim da As New MySqlDataAdapter                 'Object for mysqlDataAdapter  
        Dim ttb As New DataTable
        Dim dtr As MySqlDataReader
        commd.Connection = con
        commd.CommandText = "SELECT * FROM `childrentbl`"
        dtr = commd.ExecuteReader
        ttb.Load(dtr)
        dtr.Close()
        con.Close()
        DataGridView1.DataSource = ttb
    End Sub

    Private Sub btnRegisterPatient_Click(sender As Object, e As EventArgs) Handles btnRegisterPatient.Click
        Dim admitt As bedregistration
        admitt = New bedregistration
        admitt.Show()
    End Sub

    Private Sub btnDischarge_Click(sender As Object, e As EventArgs) Handles btnDischarge.Click
        Dim disch As New Discharge
        disch = New Discharge
        disch.Show()
    End Sub

    Private Sub txtDisease_TextChanged(sender As Object, e As EventArgs) Handles txtDisease.TextChanged
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Dim sa As String
        Dim cm As New MySqlCommand
        Dim dap As New MySqlDataAdapter
        Dim ttb As New DataTable
        sa = "SELECT * FROM `childrentbl` WHERE `PATIENT_ID` like '%" & txtsearch.Text & "%'"
        cm.Connection = con  'connection for patient table
        cm.CommandText = sa
        dap.SelectCommand = cm
        dap.Fill(ttb)
        DataGridView1.DataSource = ttb
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Try
            con.Open()
            Dim sql As String
            Dim cm As New MySqlCommand
            Dim dap As New MySqlDataAdapter
            Dim ttb As New DataTable
            sql = "SELECT * FROM `childrentbl`"
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

    Private Sub btnCancelRegistration_Click(sender As Object, e As EventArgs) Handles btnCancelRegistration.Click
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            con.Open()
            sql = "DELETE FROM childrentbl` WHERE `ID` =" & Me.Text & ""
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

    Private Sub btnSaveRegistration_Click(sender As Object, e As EventArgs) Handles btnSaveRegistration.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            con.Open()
            sql = "INSERT INTO `childrentbl`(`ID`, `Parent_ID`, `Bed_Type`, `Bed_No`, `Parent_Name`, `Age`, `Address`, `Phone`, `Gender`, `Doctor`, `Date`, `Time`) 
                 VALUES  ('" & Me.Text & "','" & txtRegno.Text & "','" & CB_BedCategory.Text & "','" & txtbedno.Text & "','" & txtPatiname.Text & "','" & txtAge.Text & "','" & RtxtAddress.Text & "','" & txtphone.Text & "','" & CB_Gendergp.Text & "','" & txtdoctor.Text & "','" & DTP_date.Text & "','" & txttime.Text & "' )"
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

    Private Sub btnEditRegistration_Click(sender As Object, e As EventArgs) Handles btnEditRegistration.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Try
            Dim commd As New MySqlCommand                  'Object for mysqlcomand   
            Dim sql As String
            con.Open()
            Dim i As String
            commd.Connection = con
            sql = " UPDATE `childrentbl` SET `ID`='" & Me.Text & "',`Parent_ID`='" & txtRegno.Text & "',`Bed_Type`='" & CB_BedCategory.Text & "',`Bed_No`='" & txtbedno.Text & "',`Parent_Name`='" & txtPatiname.Text & "',`Age`='" & txtAge.Text & "',`Address`='" & RtxtAddress.Text & "',`Phone`='" & txtphone.Text & "',`Gender`='" & CB_Gendergp.Text & "',`Doctor`='" & txtdoctor.Text & "',`Date`='" & DTP_date.Text & "',`Time`='" & txttime.Text & " '  WHERE `ID`=" & Me.Text & ""
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
        txtRegno.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        CB_BedCategory.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtbedno.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtPatiname.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txtAge.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        RtxtAddress.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        txtphone.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        CB_Gendergp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        txtdoctor.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString

        txttime.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString

        '  txtTimePicker.Text = DataGridView1.CurrentRow.Cells(16).Value.ToString

        Try
            If Not e.RowIndex = -1 Then
                If e.ColumnIndex = 10 Then
                    DTP_date = New DateTimePicker()
                    DataGrid_InventoryAllocation.Controls.Add(DTP_date)
                    DTP_date.Format = DateTimePickerFormat.Short
                    Dim oRectangle As Rectangle = DataGrid_InventoryAllocation.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                    DTP_date.Size = New Size(oRectangle.Width, oRectangle.Height)
                    DTP_date.Location = New Point(oRectangle.X, oRectangle.Y)

                End If
            End If
            If e.ColumnIndex = 10 And e.RowIndex <> -1 Then
                AddHandler DTP_date.CloseUp, AddressOf DTP_dateClose
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

    Private Sub DTP_dateClose(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub Resetbutton_Click(sender As Object, e As EventArgs) Handles Resetbutton.Click


        txtRegno.Clear()

        txtbedno.Clear()
        txtPatiname.Clear()
        txtAge.Clear()
        RtxtAddress.Clear()
        txtphone.Clear()

        txtdoctor.Clear()


    End Sub
End Class