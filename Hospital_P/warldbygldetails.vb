
Imports MySql.Data.MySqlClient


Public Class sisterwarldboy
    Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
    Public Property DataGrid_InventoryAllocation As Object
    Public Property GridRow1 As Object

    Private Sub sisterwarldboy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        UpdateTable()
        Try
            con.Open()
            Dim su As String 'filling dataAdapter for the Doctor's table
            Dim cmdu As New MySqlCommand
            Dim daptu As New MySqlDataAdapter
            Dim tu As New DataTable
            su = "SELECT * FROM `sister/warlbotdetailstbl`"
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
    Private Sub UpdateTable()
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        con.Open()
        Dim commd As New MySqlCommand                  'Object for mysqlcomand   
        Dim da As New MySqlDataAdapter                 'Object for mysqlDataAdapter  
        Dim ttb As New DataTable
        Dim dtr As MySqlDataReader
        commd.Connection = con
        commd.CommandText = "SELECT * FROM `sister/warlbotdetailstbl`"
        dtr = commd.ExecuteReader
        ttb.Load(dtr)
        dtr.Close()
        con.Close()



    End Sub

    Private Sub btnAddS_W_Click(sender As Object, e As EventArgs) Handles btnAddS_W.Click

        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Try
            con.Open()
            Dim sql As String
            Dim cmd As New MySqlCommand

            sql = " INSERT INTO `sister/warlbotdetailstbl`(`ID`, `Sister/warlbot_ID`, `Name`,`Address`, `Category`, `phone`, `Date`) 
                   VALUES ('" & Me.Text & "','" & txtID.Text & "','" & txtName.Text & "','" & RtxtAddress.Text & "','" & CB_Category.Text & "','" & txtPhone.Text & "','" & DTP_DOJ.Text & "')"
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

    Private Sub btnUpdateS_W_Click(sender As Object, e As EventArgs) Handles btnUpdateS_W.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Try
            Dim commd As New MySqlCommand                  'Object for mysqlcomand   
            Dim sql As String
            con.Open()
            Dim i As String
            commd.Connection = con
            sql = "UPDATE `sister/warlbotdetailstbl` SET `ID`='" & Me.Text & "',`Sister/warlbot_ID`='" & txtID.Text & "',`Name`='" & txtName.Text & "',`Address`='" & RtxtAddress.Text & "',`Category`='" & CB_Category.Text & "" & txtPhone.Text & "',`phone`='" & txtPhone.Text & "',`Date`='" & DTP_DOJ.Text & "'  WHERE `ID`=" & Me.Text & ""
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

    Private Sub btnDeleteS_W_Click(sender As Object, e As EventArgs) Handles btnDeleteS_W.Click
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            con.Open()
            sql = "DELETE FROM `sister/warlbotdetailstbl` WHERE `ID` =" & Me.Text & ""
            cmd.Connection = con
            cmd.CommandText = sql
            Dim i As String
            i = cmd.ExecuteNonQuery
            If i > 0 Then ' throwing an exeption for table
                MsgBox("Record has been DELETED successfully!")

            Else
                MsgBox(" Record has not  been DELETED successfully!")
            End If
            UpdateTable()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")

        Try
            con.Open()
            Dim sql As String
            Dim cm As New MySqlCommand
            Dim dap As New MySqlDataAdapter
            Dim ttb As New DataTable
            sql = "SELECT * FROM `sister/warlbotdetailstbl` "
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
        txtID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        RtxtAddress.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        CB_Category.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txtPhone.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString



        Try
            If Not e.RowIndex = -1 Then
                If e.ColumnIndex = 6 Then
                    DTP_DOJ = New DateTimePicker()
                    DataGrid_InventoryAllocation.Controls.Add(DTP_DOJ)
                    DTP_DOJ.Format = DateTimePickerFormat.Short
                    Dim oRectangle As Rectangle = DataGrid_InventoryAllocation.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                    DTP_DOJ.Size = New Size(oRectangle.Width, oRectangle.Height)
                    DTP_DOJ.Location = New Point(oRectangle.X, oRectangle.Y)

                End If
            End If
            If e.ColumnIndex = 6 And e.RowIndex <> -1 Then
                AddHandler DTP_DOJ.CloseUp, AddressOf DTP_DOJClose
                GridRow1.Cells.Item("ExpectedShipDate").Value = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DTP_DOJClose(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Dim sa As String
        Dim cm As New MySqlCommand
        Dim dap As New MySqlDataAdapter
        Dim ttb As New DataTable
        sa = "SELECT * FROM `sister/warlbotdetailstbl` WHERE `Sister/warlbot_ID` like '%" & txtsearch.Text & "%'"
        cm.Connection = con  'connection for patient table
        cm.CommandText = sa
        dap.SelectCommand = cm
        dap.Fill(ttb)
        DataGridView1.DataSource = ttb
        con.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As New About
        about = New About
        about.Show()
    End Sub
End Class