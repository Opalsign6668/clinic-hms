
Imports MySql.Data.MySqlClient


Public Class bedregistration
    Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
    Public Property DataGrid_InventoryAllocation As Object
    Public Property GridRow1 As Object

    Private Sub UpdateTable()
        '   Dim con As New MySqlConnection("localhost; user=root; password=; database=hospitalmanagementdb")
        con.Open()
        Dim commd As New MySqlCommand                  'Object for mysqlcomand   
        Dim da As New MySqlDataAdapter                 'Object for mysqlDataAdapter  
        Dim ttb As New DataTable
        Dim dtr As MySqlDataReader
        commd.Connection = con
        commd.CommandText = "SELECT * FROM `admittpatienttbl`"
        dtr = commd.ExecuteReader
        ttb.Load(dtr)
        dtr.Close()
        con.Close()



    End Sub

    Private Sub bedregistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        UpdateTable()
        Try
            con.Open()
            Dim su As String 'filling dataAdapter for the Doctor's table
            Dim cmdu As New MySqlCommand
            Dim daptu As New MySqlDataAdapter
            Dim tu As New DataTable
            su = "SELECT * FROM `admittpatienttbl`"
            cmdu.Connection = con
            cmdu.CommandText = su
            daptu.SelectCommand = cmdu
            daptu.Fill(tu)
            DataGridView1.DataSource = tu

        Catch ex As Exception ' an exeption thrown for the codes
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2, 0)
    End Sub




    Private Sub btnSaveRegistration_Click(sender As Object, e As EventArgs) Handles btnSaveRegistration.Click

        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Try
            con.Open()
            Dim sql As String
            Dim cmd As New MySqlCommand

            sql = "INSERT INTO `admittpatienttbl`(`ID`, `PATIENT_ID`, `Bed_Type`, `Bed_No`, `Bed_Charge/Day`, `Patient_Name`, `Age`, `Address`, `Phone_No`, `Date`, `Time`, `Disease`, `Blood_Group`, `Doctor_name`, `Remark`)
                    VALUES ('" & Me.Text & "','" & txtid.Text & "','" & CB_BedCategory.Text & "','" & CB_Bedno.Text & "','" & txtBedCharge.Text & "','" & txtPatiname.Text & "','" & txtAge.Text & "','" & RtxtAddress.Text & "','" & txtphone.Text & "','" & DTP_date.Text & "','" & txttime.Text & "','" & txtDisease.Text & "','" & CB_Bloodgp.Text & "','" & txtDoctor.Text & "','" & txt_Remark.Text & "') "
            cmd.CommandText = sql
            cmd.Connection = con
            Dim i As String
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("New record inserted succefully!")
            Else
                MsgBox("!!! Fail to insert details")
            End If
            UpdateTable()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Dim con As New MySqlConnection("serverlocalhost; user=root; password=; database=hospitalmanagementdb")
        Try
            Dim commd As New MySqlCommand                  'Object for mysqlcomand   
            Dim sql As String
            con.Open()
            Dim i As String
            commd.Connection = con
            sql = "UPDATE `admittpatienttbl` SET `ID`='" & Me.Text & "',`PATIENT_ID`='" & txtid.Text & "',`Bed_Type`='" & CB_BedCategory.Text & "',`Bed_No`='" & CB_Bedno.Text & "',`Bed_Charge/Day`='" & txtBedCharge.Text & "',`Patient_Name`='" & txtPatiname.Text & "',`Age`='" & txtAge.Text & "',`Address`='" & RtxtAddress.Text & "',`Phone_No`='" & txtphone.Text & "',`Date`='" & DTP_date.Text & "',`Time`='" & txttime.Text & "',`Disease`='" & txtDisease.Text & "',`Blood_Group`='" & CB_Bloodgp.Text & "',`Doctor_name`='" & txtDoctor.Text & "',`Remark`='" & txt_Remark.Text & "' WHERE `ID`=" & Me.Text & ""
            commd.CommandText = sql
            i = commd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("data updated:" & i & "rows")
            Else
                MsgBox("data not updated:" & i & "rows")
            End If
            UpdateTable()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        txtid.Clear()
        txtPatiname.Clear()
        txtBedCharge.Clear()
        txtAge.Clear()
        txtPatiname.Clear()
        RtxtAddress.Clear()
        txtphone.Clear()
        txtDisease.Clear()
        txtDoctor.Clear()
        txt_Remark.Clear()


    End Sub

    Private Sub btnCancelRegistration_Click(sender As Object, e As EventArgs) Handles btnCancelRegistration.Click
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            con.Open()
            sql = "DELETE FROM `admittpatienttbl` WHERE `ID` =" & Me.Text & ""
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
    Private Sub WarldManwomanDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WarldManwomanDetailsToolStripMenuItem.Click
        Dim warld As New sisterwarldboy
        warld = New sisterwarldboy
        warld.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As About
        about = New About
        about.Show()
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")

        Try
            con.Open()
            Dim sql As String
            Dim cm As New MySqlCommand
            Dim dap As New MySqlDataAdapter
            Dim ttb As New DataTable
            sql = "SELECT * FROM `admittpatienttbl`"
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Me.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtid.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        CB_BedCategory.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        CB_Bedno.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtBedCharge.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txtPatiname.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txtAge.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        RtxtAddress.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        txtphone.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString

        txttime.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        txtDisease.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        CB_Bloodgp.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
        txtDoctor.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString
        txt_Remark.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString

        Try
            If Not e.RowIndex = -1 Then
                If e.ColumnIndex = 9 Then
                    DTP_date = New DateTimePicker()
                    DataGrid_InventoryAllocation.Controls.Add(DTP_date)
                    DTP_date.Format = DateTimePickerFormat.Short
                    Dim oRectangle As Rectangle = DataGrid_InventoryAllocation.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                    DTP_date.Size = New Size(oRectangle.Width, oRectangle.Height)
                    DTP_date.Location = New Point(oRectangle.X, oRectangle.Y)

                End If
            End If
            If e.ColumnIndex = 9 And e.RowIndex <> -1 Then
                AddHandler DTP_date.CloseUp, AddressOf DTP_dateClose
                GridRow1.Cells.Item("ExpectedShipDate").Value = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DTP_dateClose(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtseacrh.TextChanged
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Dim sa As String
        Dim cm As New MySqlCommand
        Dim dap As New MySqlDataAdapter
        Dim ttb As New DataTable
        sa = "SELECT * FROM `admittpatienttbl` WHERE `PATIENT_ID` like '%" & txtseacrh.Text & "%'"
        cm.Connection = con  'connection for patient table
        cm.CommandText = sa
        dap.SelectCommand = cm
        dap.Fill(ttb)
        DataGridView1.DataSource = ttb
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dischar As New Discharge
        dischar = New Discharge
        dischar.Show()
    End Sub
End Class