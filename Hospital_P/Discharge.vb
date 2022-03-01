Imports MySql.Data.MySqlClient



Public Class Discharge
    Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
    Public Property DataGrid_InventoryAllocation As Object
    Public Property GridRow1 As Object
    Private bitmap As Bitmap

    Private Sub updateTable()
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        con.Open()
        Dim commd As New MySqlCommand                  'Object for mysqlcomand   
        Dim da As New MySqlDataAdapter                 'Object for mysqlDataAdapter  
        Dim ttb As New DataTable
        Dim dtr As MySqlDataReader
        commd.Connection = con
        commd.CommandText = "SELECT * FROM `dischargetbl`"
        dtr = commd.ExecuteReader
        ttb.Load(dtr)
        dtr.Close()
        con.Close()
        DataGridView1.DataSource = ttb
    End Sub
    Private Sub Discharge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        updateTable()
        Try
            con.Open()
            Dim su As String 'filling dataAdapter for the Doctor's table
            Dim cmdu As New MySqlCommand
            Dim daptu As New MySqlDataAdapter
            Dim tu As New DataTable
            su = "SELECT * FROM `dischargetbl`"
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Dim sa As String
        Dim cm As New MySqlCommand
        Dim dap As New MySqlDataAdapter
        Dim ttb As New DataTable
        sa = "SELECT * FROM `dischargetbl`  WHERE `PATIENT_ID` like '%" & txtsearch.Text & "%'"
        cm.Connection = con  'connection for patient table
        cm.CommandText = sa
        dap.SelectCommand = cm
        dap.Fill(ttb)
        DataGridView1.DataSource = ttb
        con.Close()
    End Sub

    Private Sub btnAddS_W_Click(sender As Object, e As EventArgs) Handles btnAddS_W.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            con.Open()
            sql = "INSERT INTO `dischargetbl`(`ID`, `Patient_ID`, `Bed_Type`, `Bed_numb`, `Bed/charge/day`, `Patient_name`, `Age`, `Address`, `Phone`, `Date`, `Disease`, `Blood_Group`, `Doctor`, `Remarks`)
            VALUES ('" & Me.Text & "','" & txtID.Text & "','" & txtbed.Text & "','" & txtbedno.Text & "','" & txtBedCharge.Text & "','" & txtPatiname.Text & "','" & txtAge.Text & "','" & RtxtAddress.Text & "','" & txtphone.Text & "','" & DTP_date.Text & "','" & txtDisease.Text & "','" & CB_Bloodgp.Text & "','" & cbDoctor.Text & "','" & Rtxt_Remark.Text & "')"
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

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Try
            con.Open()
            Dim sql As String
            Dim cm As New MySqlCommand
            Dim dap As New MySqlDataAdapter
            Dim ttb As New DataTable
            sql = "SELECT * FROM `dischargetbl`"
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

    Private Sub btnDeleteS_W_Click(sender As Object, e As EventArgs) Handles btnDeleteS_W.Click
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            con.Open()
            sql = "DELETE FROM `dischargetbl` WHERE `ID` =" & Me.Text & ""
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

    Private Sub btnUpdateS_W_Click(sender As Object, e As EventArgs) Handles btnUpdateS_W.Click
        Dim con As New MySqlConnection("server=localhost; user=root; password=; database=hospitalmanagementdb")
        Try
            Dim commd As New MySqlCommand                  'Object for mysqlcomand   
            Dim sql As String
            con.Open()
            Dim i As String
            commd.Connection = con
            sql = "UPDATE `dischargetbl` SET `ID`='" & Me.Text & "',`Patient_ID`='" & txtID.Text & "',`Bed_Type`='" & txtbed.Text & "',`Bed_numb`='" & txtbedno.Text & "',`Bed/charge/day`='" & txtBedCharge.Text & "',`Patient_name`='" & txtPatiname.Text & "',`Age`='" & txtAge.Text & "',`Address`='" & RtxtAddress.Text & "',`Phone`='" & txtphone.Text & "',`Date`='" & DTP_date.Text & "',`Disease`='" & txtDisease.Text & "',`Blood_Group`='" & CB_Bloodgp.Text & "',`Doctor`='" & cbDoctor.Text & "',`Remarks`='" & RtxtAddress.Text & "' WHERE `ID`=" & Me.Text & ""
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
        txtID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtbed.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtbedno.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtBedCharge.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txtPatiname.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txtAge.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        RtxtAddress.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        txtphone.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString

        txtDisease.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        CB_Bloodgp.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        cbDoctor.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString

        RtxtAddress.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString

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
            If e.ColumnIndex = 16 And e.RowIndex <> -1 Then
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtID.Clear()

        txtbedno.Clear()
        txtBedCharge.Clear()
        txtPatiname.Clear()
        txtAge.Clear()
        RtxtAddress.Clear()
        txtphone.Clear()

        txtDisease.Clear()
        CB_Bloodgp.Clear()
        cbDoctor.Clear()
    End Sub

    Private Sub btnCustomprint_Click(sender As Object, e As EventArgs) Handles btnCustomprint.Click
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 2
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = Width

    End Sub


    Private mRow As Integer = 0
    Private newpage As Boolean = True
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow

        If newpage Then
            row = DataGridView1.Rows(mRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case DataGridView1.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                             DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                            DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Center

                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)


                    End Select
                    e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText,
                                          DataGridView1.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
                newpage = False

                Dim thisNDX As Int32
                For thisNDX = mRow To DataGridView1.RowCount - 1
                    If DataGridView1.Rows(thisNDX).IsNewRow Then Exit For
                    row = DataGridView1.Rows(thisNDX)
                    x = e.MarginBounds.Left
                    h = 0
                    x = e.MarginBounds.Left

                    For Each DataGridViewCell In row.Cells
                        If cell.Visible Then
                            rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                            e.Graphics.DrawRectangle(Pens.Black, rc)

                            Select Case DataGridView1.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                                Case DataGridViewContentAlignment.BottomRight,
                             DataGridViewContentAlignment.MiddleRight
                                    fmt.Alignment = StringAlignment.Far
                                    rc.Offset(-1, 0)

                                Case DataGridViewContentAlignment.BottomCenter,
                             DataGridViewContentAlignment.MiddleRight
                                    fmt.Alignment = StringAlignment.Center

                                Case Else
                                    fmt.Alignment = StringAlignment.Near
                                    rc.Offset(2, 0)

                            End Select
                            e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                     DataGridView1.Font, Brushes.Black, rc, fmt)

                            x += rc.Width
                            h = Math.Max(h, rc.Height)

                        End If
                    Next

                    y += h
                    mRow = thisNDX + 1
                    If y + h > e.MarginBounds.Bottom Then
                        e.HasMorePages = True
                        newpage = True
                        Return
                    End If
                Next

            Next


        End If







        'e.Graphics.DrawImage(bitmap, 0, 0)
        'Dim recp As RectangleF = e.PageSettings.PrintableArea
        'If Me.DataGridView1.Height - recp.Height > 0 Then e.HasMorePages = True
    End Sub
End Class