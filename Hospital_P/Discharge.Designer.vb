<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Discharge
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Discharge))
        Me.btnCustomprint = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPatiname = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtDisease = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBedCharge = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.btnDeleteS_W = New System.Windows.Forms.Button()
        Me.btnUpdateS_W = New System.Windows.Forms.Button()
        Me.btnAddS_W = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Rtxt_Remark = New System.Windows.Forms.TextBox()
        Me.RtxtAddress = New System.Windows.Forms.TextBox()
        Me.txtbedno = New System.Windows.Forms.TextBox()
        Me.CB_Bloodgp = New System.Windows.Forms.TextBox()
        Me.cbDoctor = New System.Windows.Forms.TextBox()
        Me.DTP_DOD = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTP_date = New System.Windows.Forms.DateTimePicker()
        Me.txtbed = New System.Windows.Forms.ComboBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCustomprint
        '
        Me.btnCustomprint.BackColor = System.Drawing.Color.LightGray
        Me.btnCustomprint.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCustomprint.Location = New System.Drawing.Point(6, 19)
        Me.btnCustomprint.Name = "btnCustomprint"
        Me.btnCustomprint.Size = New System.Drawing.Size(72, 32)
        Me.btnCustomprint.TabIndex = 16
        Me.btnCustomprint.Text = "List"
        Me.btnCustomprint.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(570, 196)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(525, 356)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient List View"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(507, 293)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnCustomprint)
        Me.GroupBox5.Location = New System.Drawing.Point(570, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(136, 137)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Print"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(11, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 24)
        Me.Label12.TabIndex = 147
        Me.Label12.Text = "Bed No"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(11, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 125
        Me.Label11.Text = "Bed Type"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(131, 49)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(104, 20)
        Me.txtID.TabIndex = 1
        '
        'txtPatiname
        '
        Me.txtPatiname.Location = New System.Drawing.Point(131, 177)
        Me.txtPatiname.Name = "txtPatiname"
        Me.txtPatiname.Size = New System.Drawing.Size(104, 20)
        Me.txtPatiname.TabIndex = 5
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(131, 209)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(104, 20)
        Me.txtAge.TabIndex = 6
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(131, 289)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(104, 20)
        Me.txtphone.TabIndex = 8
        '
        'txtDisease
        '
        Me.txtDisease.Location = New System.Drawing.Point(131, 353)
        Me.txtDisease.Name = "txtDisease"
        Me.txtDisease.Size = New System.Drawing.Size(104, 20)
        Me.txtDisease.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "Registration No"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Patient Name"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Age"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(11, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Phone No"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(11, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "Date"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(11, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "Disease"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(11, 417)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 140
        Me.Label8.Text = "Doctor"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(11, 385)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 143
        Me.Label9.Text = "Blood Group"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(11, 457)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 144
        Me.Label10.Text = "Remarks"
        '
        'txtBedCharge
        '
        Me.txtBedCharge.Location = New System.Drawing.Point(131, 145)
        Me.txtBedCharge.Name = "txtBedCharge"
        Me.txtBedCharge.Size = New System.Drawing.Size(104, 20)
        Me.txtBedCharge.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(11, 145)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 23)
        Me.Label13.TabIndex = 150
        Me.Label13.Text = "Bed Charge/Day"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(11, 497)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 23)
        Me.Label14.TabIndex = 151
        Me.Label14.Text = "Discharge Date"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Refresh)
        Me.GroupBox3.Controls.Add(Me.btnDeleteS_W)
        Me.GroupBox3.Controls.Add(Me.btnUpdateS_W)
        Me.GroupBox3.Controls.Add(Me.btnAddS_W)
        Me.GroupBox3.Controls.Add(Me.txtsearch)
        Me.GroupBox3.Controls.Add(Me.btnSearch)
        Me.GroupBox3.Location = New System.Drawing.Point(263, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(220, 175)
        Me.GroupBox3.TabIndex = 153
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaction"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(57, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Reset"
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(120, 91)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(88, 23)
        Me.Refresh.TabIndex = 28
        Me.Refresh.Text = "Refresh"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'btnDeleteS_W
        '
        Me.btnDeleteS_W.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeleteS_W.Location = New System.Drawing.Point(13, 91)
        Me.btnDeleteS_W.Name = "btnDeleteS_W"
        Me.btnDeleteS_W.Size = New System.Drawing.Size(88, 23)
        Me.btnDeleteS_W.TabIndex = 27
        Me.btnDeleteS_W.Text = "Delete "
        '
        'btnUpdateS_W
        '
        Me.btnUpdateS_W.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdateS_W.Location = New System.Drawing.Point(13, 51)
        Me.btnUpdateS_W.Name = "btnUpdateS_W"
        Me.btnUpdateS_W.Size = New System.Drawing.Size(88, 23)
        Me.btnUpdateS_W.TabIndex = 26
        Me.btnUpdateS_W.Text = "Edit "
        '
        'btnAddS_W
        '
        Me.btnAddS_W.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddS_W.Location = New System.Drawing.Point(120, 53)
        Me.btnAddS_W.Name = "btnAddS_W"
        Me.btnAddS_W.Size = New System.Drawing.Size(88, 23)
        Me.btnAddS_W.TabIndex = 25
        Me.btnAddS_W.Text = "Add "
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(13, 16)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(88, 20)
        Me.txtsearch.TabIndex = 24
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSearch.Location = New System.Drawing.Point(158, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(50, 22)
        Me.btnSearch.TabIndex = 23
        Me.btnSearch.Text = "Search"
        '
        'Rtxt_Remark
        '
        Me.Rtxt_Remark.Location = New System.Drawing.Point(131, 449)
        Me.Rtxt_Remark.Multiline = True
        Me.Rtxt_Remark.Name = "Rtxt_Remark"
        Me.Rtxt_Remark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Rtxt_Remark.Size = New System.Drawing.Size(100, 40)
        Me.Rtxt_Remark.TabIndex = 13
        '
        'RtxtAddress
        '
        Me.RtxtAddress.Location = New System.Drawing.Point(131, 241)
        Me.RtxtAddress.Multiline = True
        Me.RtxtAddress.Name = "RtxtAddress"
        Me.RtxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.RtxtAddress.Size = New System.Drawing.Size(104, 40)
        Me.RtxtAddress.TabIndex = 7
        '
        'txtbedno
        '
        Me.txtbedno.Location = New System.Drawing.Point(131, 113)
        Me.txtbedno.Name = "txtbedno"
        Me.txtbedno.Size = New System.Drawing.Size(100, 20)
        Me.txtbedno.TabIndex = 155
        '
        'CB_Bloodgp
        '
        Me.CB_Bloodgp.Location = New System.Drawing.Point(131, 385)
        Me.CB_Bloodgp.Name = "CB_Bloodgp"
        Me.CB_Bloodgp.Size = New System.Drawing.Size(100, 20)
        Me.CB_Bloodgp.TabIndex = 157
        '
        'cbDoctor
        '
        Me.cbDoctor.Location = New System.Drawing.Point(131, 417)
        Me.cbDoctor.Name = "cbDoctor"
        Me.cbDoctor.Size = New System.Drawing.Size(100, 20)
        Me.cbDoctor.TabIndex = 158
        '
        'DTP_DOD
        '
        Me.DTP_DOD.Location = New System.Drawing.Point(131, 497)
        Me.DTP_DOD.Name = "DTP_DOD"
        Me.DTP_DOD.ReadOnly = True
        Me.DTP_DOD.Size = New System.Drawing.Size(100, 20)
        Me.DTP_DOD.TabIndex = 159
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(Me.DTP_date)
        Me.GroupBox1.Controls.Add(Me.txtbed)
        Me.GroupBox1.Controls.Add(Me.DTP_DOD)
        Me.GroupBox1.Controls.Add(Me.cbDoctor)
        Me.GroupBox1.Controls.Add(Me.CB_Bloodgp)
        Me.GroupBox1.Controls.Add(Me.txtbedno)
        Me.GroupBox1.Controls.Add(Me.RtxtAddress)
        Me.GroupBox1.Controls.Add(Me.Rtxt_Remark)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtBedCharge)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDisease)
        Me.GroupBox1.Controls.Add(Me.txtphone)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.txtPatiname)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 533)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Detail"
        '
        'DTP_date
        '
        Me.DTP_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_date.Location = New System.Drawing.Point(131, 321)
        Me.DTP_date.Name = "DTP_date"
        Me.DTP_date.Size = New System.Drawing.Size(104, 20)
        Me.DTP_date.TabIndex = 161
        '
        'txtbed
        '
        Me.txtbed.Items.AddRange(New Object() {"General", "Special"})
        Me.txtbed.Location = New System.Drawing.Point(131, 83)
        Me.txtbed.Name = "txtbed"
        Me.txtbed.Size = New System.Drawing.Size(104, 21)
        Me.txtbed.TabIndex = 160
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Discharge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 564)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Discharge"
        Me.Text = "Discharge"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCustomprint As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPatiname As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtDisease As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBedCharge As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Refresh As Button
    Friend WithEvents btnDeleteS_W As Button
    Friend WithEvents btnUpdateS_W As Button
    Friend WithEvents btnAddS_W As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Rtxt_Remark As TextBox
    Friend WithEvents RtxtAddress As TextBox
    Friend WithEvents txtbedno As TextBox
    Friend WithEvents CB_Bloodgp As TextBox
    Friend WithEvents cbDoctor As TextBox
    Friend WithEvents DTP_DOD As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbed As ComboBox
    Friend WithEvents DTP_date As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
