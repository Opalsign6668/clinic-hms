<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sisterwarldboy
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCustomprint = New System.Windows.Forms.Button()
        Me.RtxtAddress = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.btnDeleteS_W = New System.Windows.Forms.Button()
        Me.btnUpdateS_W = New System.Windows.Forms.Button()
        Me.btnAddS_W = New System.Windows.Forms.Button()
        Me.CB_Category = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SiterWarldboy = New System.Windows.Forms.GroupBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.DTP_DOJ = New System.Windows.Forms.DateTimePicker()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GB_DoctorView = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3.SuspendLayout()
        Me.SiterWarldboy.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSearch.Location = New System.Drawing.Point(99, 32)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(50, 23)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search"
        '
        'btnCustomprint
        '
        Me.btnCustomprint.BackColor = System.Drawing.Color.LightGray
        Me.btnCustomprint.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCustomprint.Location = New System.Drawing.Point(24, 48)
        Me.btnCustomprint.Name = "btnCustomprint"
        Me.btnCustomprint.Size = New System.Drawing.Size(72, 24)
        Me.btnCustomprint.TabIndex = 11
        Me.btnCustomprint.Text = "List"
        Me.btnCustomprint.UseVisualStyleBackColor = False
        '
        'RtxtAddress
        '
        Me.RtxtAddress.Location = New System.Drawing.Point(168, 120)
        Me.RtxtAddress.Multiline = True
        Me.RtxtAddress.Name = "RtxtAddress"
        Me.RtxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.RtxtAddress.Size = New System.Drawing.Size(100, 64)
        Me.RtxtAddress.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Refresh)
        Me.GroupBox3.Controls.Add(Me.btnDeleteS_W)
        Me.GroupBox3.Controls.Add(Me.btnUpdateS_W)
        Me.GroupBox3.Controls.Add(Me.btnAddS_W)
        Me.GroupBox3.Location = New System.Drawing.Point(320, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 203)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaction"
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(32, 147)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(88, 23)
        Me.Refresh.TabIndex = 11
        Me.Refresh.Text = "Refresh"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'btnDeleteS_W
        '
        Me.btnDeleteS_W.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeleteS_W.Location = New System.Drawing.Point(32, 112)
        Me.btnDeleteS_W.Name = "btnDeleteS_W"
        Me.btnDeleteS_W.Size = New System.Drawing.Size(88, 23)
        Me.btnDeleteS_W.TabIndex = 8
        Me.btnDeleteS_W.Text = "Delete S/W"
        '
        'btnUpdateS_W
        '
        Me.btnUpdateS_W.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdateS_W.Location = New System.Drawing.Point(32, 72)
        Me.btnUpdateS_W.Name = "btnUpdateS_W"
        Me.btnUpdateS_W.Size = New System.Drawing.Size(88, 23)
        Me.btnUpdateS_W.TabIndex = 7
        Me.btnUpdateS_W.Text = "Edit S/W"
        '
        'btnAddS_W
        '
        Me.btnAddS_W.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddS_W.Location = New System.Drawing.Point(32, 32)
        Me.btnAddS_W.Name = "btnAddS_W"
        Me.btnAddS_W.Size = New System.Drawing.Size(88, 23)
        Me.btnAddS_W.TabIndex = 6
        Me.btnAddS_W.Text = "Add S/W"
        '
        'CB_Category
        '
        Me.CB_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Category.Items.AddRange(New Object() {"Sister", "Wardboy"})
        Me.CB_Category.Location = New System.Drawing.Point(168, 200)
        Me.CB_Category.Name = "CB_Category"
        Me.CB_Category.Size = New System.Drawing.Size(104, 21)
        Me.CB_Category.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(48, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Category"
        '
        'SiterWarldboy
        '
        Me.SiterWarldboy.Controls.Add(Me.txtID)
        Me.SiterWarldboy.Controls.Add(Me.RtxtAddress)
        Me.SiterWarldboy.Controls.Add(Me.GroupBox3)
        Me.SiterWarldboy.Controls.Add(Me.CB_Category)
        Me.SiterWarldboy.Controls.Add(Me.Label6)
        Me.SiterWarldboy.Controls.Add(Me.DTP_DOJ)
        Me.SiterWarldboy.Controls.Add(Me.txtPhone)
        Me.SiterWarldboy.Controls.Add(Me.txtName)
        Me.SiterWarldboy.Controls.Add(Me.Label5)
        Me.SiterWarldboy.Controls.Add(Me.Label4)
        Me.SiterWarldboy.Controls.Add(Me.Label3)
        Me.SiterWarldboy.Controls.Add(Me.Label2)
        Me.SiterWarldboy.Controls.Add(Me.Label1)
        Me.SiterWarldboy.Location = New System.Drawing.Point(24, 26)
        Me.SiterWarldboy.Name = "SiterWarldboy"
        Me.SiterWarldboy.Size = New System.Drawing.Size(496, 328)
        Me.SiterWarldboy.TabIndex = 4
        Me.SiterWarldboy.TabStop = False
        Me.SiterWarldboy.Text = "Sister/Wardboy Detail"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(168, 48)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 34
        '
        'DTP_DOJ
        '
        Me.DTP_DOJ.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_DOJ.Location = New System.Drawing.Point(168, 280)
        Me.DTP_DOJ.Name = "DTP_DOJ"
        Me.DTP_DOJ.Size = New System.Drawing.Size(104, 20)
        Me.DTP_DOJ.TabIndex = 5
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(168, 240)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(168, 88)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(48, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Date of joining"
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(48, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Phone"
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(48, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(48, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(48, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCustomprint)
        Me.GroupBox1.Location = New System.Drawing.Point(546, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 120)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Print"
        '
        'GB_DoctorView
        '
        Me.GB_DoctorView.Location = New System.Drawing.Point(28, 369)
        Me.GB_DoctorView.Name = "GB_DoctorView"
        Me.GB_DoctorView.Size = New System.Drawing.Size(656, 248)
        Me.GB_DoctorView.TabIndex = 5
        Me.GB_DoctorView.TabStop = False
        Me.GB_DoctorView.Text = "Sister/Wardboy View"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(52, 400)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(632, 207)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtsearch)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(526, 196)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(158, 120)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search/Export"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(6, 35)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(87, 20)
        Me.txtsearch.TabIndex = 14
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(696, 25)
        Me.MenuStrip1.TabIndex = 68
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(58, 21)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'sisterwarldboy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 619)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.SiterWarldboy)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GB_DoctorView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "sisterwarldboy"
        Me.Text = "Form1"
        Me.GroupBox3.ResumeLayout(False)
        Me.SiterWarldboy.ResumeLayout(False)
        Me.SiterWarldboy.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnCustomprint As Button
    Friend WithEvents RtxtAddress As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnDeleteS_W As Button
    Friend WithEvents btnUpdateS_W As Button
    Friend WithEvents btnAddS_W As Button
    Friend WithEvents CB_Category As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SiterWarldboy As GroupBox
    Friend WithEvents DTP_DOJ As DateTimePicker
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GB_DoctorView As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Refresh As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
