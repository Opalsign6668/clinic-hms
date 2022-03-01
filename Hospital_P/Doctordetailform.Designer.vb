<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctordetailsform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doctordetailsform))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btndone = New System.Windows.Forms.Button()
        Me.GB_DoctorView = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GB_Doctor = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSaveDoctor = New System.Windows.Forms.Button()
        Me.btnDeleteDoctor = New System.Windows.Forms.Button()
        Me.btnUpdateDoctor = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.timpicker = New System.Windows.Forms.DateTimePicker()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RtxtAddress = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GB_DoctorView.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Doctor.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Location = New System.Drawing.Point(529, 207)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 59)
        Me.Panel1.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(114, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Search"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(9, 20)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(100, 20)
        Me.txtsearch.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btndone)
        Me.GroupBox1.Location = New System.Drawing.Point(555, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 107)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Print"
        '
        'btndone
        '
        Me.btndone.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btndone.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btndone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btndone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btndone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndone.ForeColor = System.Drawing.SystemColors.Control
        Me.btndone.Image = CType(resources.GetObject("btndone.Image"), System.Drawing.Image)
        Me.btndone.Location = New System.Drawing.Point(15, 19)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(105, 79)
        Me.btndone.TabIndex = 6
        Me.btndone.Text = "&Print List"
        Me.btndone.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndone.UseVisualStyleBackColor = False
        '
        'GB_DoctorView
        '
        Me.GB_DoctorView.BackColor = System.Drawing.Color.White
        Me.GB_DoctorView.Controls.Add(Me.DataGridView1)
        Me.GB_DoctorView.Location = New System.Drawing.Point(26, 342)
        Me.GB_DoctorView.Name = "GB_DoctorView"
        Me.GB_DoctorView.Size = New System.Drawing.Size(648, 257)
        Me.GB_DoctorView.TabIndex = 15
        Me.GB_DoctorView.TabStop = False
        Me.GB_DoctorView.Text = "Doctor View"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(589, 203)
        Me.DataGridView1.TabIndex = 0
        '
        'GB_Doctor
        '
        Me.GB_Doctor.Controls.Add(Me.Panel2)
        Me.GB_Doctor.Controls.Add(Me.txtID)
        Me.GB_Doctor.Controls.Add(Me.timpicker)
        Me.GB_Doctor.Controls.Add(Me.txtPhone)
        Me.GB_Doctor.Controls.Add(Me.txtName)
        Me.GB_Doctor.Controls.Add(Me.Label5)
        Me.GB_Doctor.Controls.Add(Me.Label4)
        Me.GB_Doctor.Controls.Add(Me.Label3)
        Me.GB_Doctor.Controls.Add(Me.Label2)
        Me.GB_Doctor.Controls.Add(Me.Label1)
        Me.GB_Doctor.Controls.Add(Me.RtxtAddress)
        Me.GB_Doctor.Location = New System.Drawing.Point(18, 51)
        Me.GB_Doctor.Name = "GB_Doctor"
        Me.GB_Doctor.Size = New System.Drawing.Size(491, 280)
        Me.GB_Doctor.TabIndex = 14
        Me.GB_Doctor.TabStop = False
        Me.GB_Doctor.Text = "Doctor Detail"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnSaveDoctor)
        Me.Panel2.Controls.Add(Me.btnDeleteDoctor)
        Me.Panel2.Controls.Add(Me.btnUpdateDoctor)
        Me.Panel2.Location = New System.Drawing.Point(311, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 156)
        Me.Panel2.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(37, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSaveDoctor
        '
        Me.btnSaveDoctor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSaveDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveDoctor.Location = New System.Drawing.Point(37, 77)
        Me.btnSaveDoctor.Name = "btnSaveDoctor"
        Me.btnSaveDoctor.Size = New System.Drawing.Size(88, 23)
        Me.btnSaveDoctor.TabIndex = 13
        Me.btnSaveDoctor.Text = "Save Doctor"
        '
        'btnDeleteDoctor
        '
        Me.btnDeleteDoctor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeleteDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteDoctor.Location = New System.Drawing.Point(37, 45)
        Me.btnDeleteDoctor.Name = "btnDeleteDoctor"
        Me.btnDeleteDoctor.Size = New System.Drawing.Size(88, 23)
        Me.btnDeleteDoctor.TabIndex = 12
        Me.btnDeleteDoctor.Text = "Delete Doctor"
        '
        'btnUpdateDoctor
        '
        Me.btnUpdateDoctor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdateDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateDoctor.Location = New System.Drawing.Point(37, 13)
        Me.btnUpdateDoctor.Name = "btnUpdateDoctor"
        Me.btnUpdateDoctor.Size = New System.Drawing.Size(88, 23)
        Me.btnUpdateDoctor.TabIndex = 11
        Me.btnUpdateDoctor.Text = "Edit Doctor"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(168, 39)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 32
        '
        'timpicker
        '
        Me.timpicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.timpicker.Location = New System.Drawing.Point(168, 228)
        Me.timpicker.Name = "timpicker"
        Me.timpicker.Size = New System.Drawing.Size(104, 20)
        Me.timpicker.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(168, 188)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(168, 76)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Date of joining"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Phone"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Doctor's ID"
        '
        'RtxtAddress
        '
        Me.RtxtAddress.Location = New System.Drawing.Point(168, 114)
        Me.RtxtAddress.Multiline = True
        Me.RtxtAddress.Name = "RtxtAddress"
        Me.RtxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.RtxtAddress.Size = New System.Drawing.Size(100, 31)
        Me.RtxtAddress.TabIndex = 2
        '
        'Doctordetailsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 596)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GB_DoctorView)
        Me.Controls.Add(Me.GB_Doctor)
        Me.Name = "Doctordetailsform"
        Me.Text = "Doctor's Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GB_DoctorView.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Doctor.ResumeLayout(False)
        Me.GB_Doctor.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GB_DoctorView As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GB_Doctor As GroupBox
    Friend WithEvents timpicker As DateTimePicker
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RtxtAddress As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSaveDoctor As Button
    Friend WithEvents btnDeleteDoctor As Button
    Friend WithEvents btnUpdateDoctor As Button
    Friend WithEvents btndone As Button
End Class
