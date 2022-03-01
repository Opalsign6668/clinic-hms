<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Childrenform
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
        Me.CB_BedCategory = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRegno = New System.Windows.Forms.TextBox()
        Me.txtPatiname = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Resetbutton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDischarge = New System.Windows.Forms.Button()
        Me.btnSaveRegistration = New System.Windows.Forms.Button()
        Me.btnCancelRegistration = New System.Windows.Forms.Button()
        Me.btnEditRegistration = New System.Windows.Forms.Button()
        Me.btnRegisterPatient = New System.Windows.Forms.Button()
        Me.DTP_date = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RtxtAddress = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CB_Gendergp = New System.Windows.Forms.ComboBox()
        Me.txtDisease = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdoctor = New System.Windows.Forms.TextBox()
        Me.txtsearch = New System.Windows.Forms.GroupBox()
        Me.txtbedno = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txttime = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txtsearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'CB_BedCategory
        '
        Me.CB_BedCategory.Items.AddRange(New Object() {"General", "Special"})
        Me.CB_BedCategory.Location = New System.Drawing.Point(144, 64)
        Me.CB_BedCategory.Name = "CB_BedCategory"
        Me.CB_BedCategory.Size = New System.Drawing.Size(104, 21)
        Me.CB_BedCategory.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(24, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 24)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Bed No"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(24, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Bed Type"
        '
        'txtRegno
        '
        Me.txtRegno.Location = New System.Drawing.Point(144, 32)
        Me.txtRegno.Name = "txtRegno"
        Me.txtRegno.Size = New System.Drawing.Size(104, 20)
        Me.txtRegno.TabIndex = 7
        '
        'txtPatiname
        '
        Me.txtPatiname.Location = New System.Drawing.Point(415, 29)
        Me.txtPatiname.Name = "txtPatiname"
        Me.txtPatiname.Size = New System.Drawing.Size(104, 20)
        Me.txtPatiname.TabIndex = 4
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(415, 61)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(104, 20)
        Me.txtAge.TabIndex = 5
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(415, 138)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(104, 20)
        Me.txtphone.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Registration No"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(295, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Parent Name"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(295, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Age"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(295, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(295, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Phone No"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(772, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Date of Birth"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Resetbutton)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btnDischarge)
        Me.GroupBox3.Controls.Add(Me.btnSaveRegistration)
        Me.GroupBox3.Controls.Add(Me.btnCancelRegistration)
        Me.GroupBox3.Controls.Add(Me.btnEditRegistration)
        Me.GroupBox3.Controls.Add(Me.btnRegisterPatient)
        Me.GroupBox3.Location = New System.Drawing.Point(577, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(176, 332)
        Me.GroupBox3.TabIndex = 69
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaction"
        '
        'Resetbutton
        '
        Me.Resetbutton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Resetbutton.Location = New System.Drawing.Point(90, 214)
        Me.Resetbutton.Name = "Resetbutton"
        Me.Resetbutton.Size = New System.Drawing.Size(80, 32)
        Me.Resetbutton.TabIndex = 20
        Me.Resetbutton.Text = "Reset"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(6, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Refresh"
        '
        'btnDischarge
        '
        Me.btnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDischarge.Location = New System.Drawing.Point(32, 260)
        Me.btnDischarge.Name = "btnDischarge"
        Me.btnDischarge.Size = New System.Drawing.Size(112, 32)
        Me.btnDischarge.TabIndex = 18
        Me.btnDischarge.Text = "Discharge Patient"
        '
        'btnSaveRegistration
        '
        Me.btnSaveRegistration.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSaveRegistration.Location = New System.Drawing.Point(32, 128)
        Me.btnSaveRegistration.Name = "btnSaveRegistration"
        Me.btnSaveRegistration.Size = New System.Drawing.Size(112, 32)
        Me.btnSaveRegistration.TabIndex = 16
        Me.btnSaveRegistration.Text = "Save  Registration"
        '
        'btnCancelRegistration
        '
        Me.btnCancelRegistration.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelRegistration.Location = New System.Drawing.Point(32, 176)
        Me.btnCancelRegistration.Name = "btnCancelRegistration"
        Me.btnCancelRegistration.Size = New System.Drawing.Size(112, 32)
        Me.btnCancelRegistration.TabIndex = 17
        Me.btnCancelRegistration.Text = "Cancel  Registration"
        '
        'btnEditRegistration
        '
        Me.btnEditRegistration.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEditRegistration.Location = New System.Drawing.Point(32, 80)
        Me.btnEditRegistration.Name = "btnEditRegistration"
        Me.btnEditRegistration.Size = New System.Drawing.Size(112, 32)
        Me.btnEditRegistration.TabIndex = 14
        Me.btnEditRegistration.Text = "Edit Registration"
        '
        'btnRegisterPatient
        '
        Me.btnRegisterPatient.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRegisterPatient.Location = New System.Drawing.Point(32, 32)
        Me.btnRegisterPatient.Name = "btnRegisterPatient"
        Me.btnRegisterPatient.Size = New System.Drawing.Size(112, 32)
        Me.btnRegisterPatient.TabIndex = 13
        Me.btnRegisterPatient.Text = "Register Patient"
        '
        'DTP_date
        '
        Me.DTP_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_date.Location = New System.Drawing.Point(892, 165)
        Me.DTP_date.Name = "DTP_date"
        Me.DTP_date.Size = New System.Drawing.Size(104, 20)
        Me.DTP_date.TabIndex = 8
        Me.DTP_date.Value = New Date(2008, 1, 1, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(148, 309)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 23)
        Me.Label13.TabIndex = 68
        '
        'RtxtAddress
        '
        Me.RtxtAddress.Location = New System.Drawing.Point(415, 88)
        Me.RtxtAddress.Multiline = True
        Me.RtxtAddress.Name = "RtxtAddress"
        Me.RtxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.RtxtAddress.Size = New System.Drawing.Size(104, 40)
        Me.RtxtAddress.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 177)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(555, 203)
        Me.DataGridView1.TabIndex = 70
        '
        'CB_Gendergp
        '
        Me.CB_Gendergp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Gendergp.Items.AddRange(New Object() {"Male", "Female"})
        Me.CB_Gendergp.Location = New System.Drawing.Point(892, 93)
        Me.CB_Gendergp.Name = "CB_Gendergp"
        Me.CB_Gendergp.Size = New System.Drawing.Size(104, 21)
        Me.CB_Gendergp.TabIndex = 72
        '
        'txtDisease
        '
        Me.txtDisease.Location = New System.Drawing.Point(892, 61)
        Me.txtDisease.Name = "txtDisease"
        Me.txtDisease.Size = New System.Drawing.Size(104, 20)
        Me.txtDisease.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(772, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 20)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Search"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(772, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Doctor"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(772, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Gender"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(772, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 23)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Time of Birth"
        '
        'txtdoctor
        '
        Me.txtdoctor.Location = New System.Drawing.Point(892, 125)
        Me.txtdoctor.Name = "txtdoctor"
        Me.txtdoctor.Size = New System.Drawing.Size(104, 20)
        Me.txtdoctor.TabIndex = 78
        '
        'txtsearch
        '
        Me.txtsearch.Controls.Add(Me.txtbedno)
        Me.txtsearch.Controls.Add(Me.Label14)
        Me.txtsearch.Controls.Add(Me.txttime)
        Me.txtsearch.Controls.Add(Me.txtdoctor)
        Me.txtsearch.Controls.Add(Me.Label10)
        Me.txtsearch.Controls.Add(Me.Label9)
        Me.txtsearch.Controls.Add(Me.Label8)
        Me.txtsearch.Controls.Add(Me.Label7)
        Me.txtsearch.Controls.Add(Me.txtDisease)
        Me.txtsearch.Controls.Add(Me.CB_Gendergp)
        Me.txtsearch.Controls.Add(Me.DataGridView1)
        Me.txtsearch.Controls.Add(Me.RtxtAddress)
        Me.txtsearch.Controls.Add(Me.Label13)
        Me.txtsearch.Controls.Add(Me.DTP_date)
        Me.txtsearch.Controls.Add(Me.GroupBox3)
        Me.txtsearch.Controls.Add(Me.Label6)
        Me.txtsearch.Controls.Add(Me.Label5)
        Me.txtsearch.Controls.Add(Me.Label4)
        Me.txtsearch.Controls.Add(Me.Label3)
        Me.txtsearch.Controls.Add(Me.Label2)
        Me.txtsearch.Controls.Add(Me.Label1)
        Me.txtsearch.Controls.Add(Me.txtphone)
        Me.txtsearch.Controls.Add(Me.txtAge)
        Me.txtsearch.Controls.Add(Me.txtPatiname)
        Me.txtsearch.Controls.Add(Me.txtRegno)
        Me.txtsearch.Controls.Add(Me.Label11)
        Me.txtsearch.Controls.Add(Me.Label12)
        Me.txtsearch.Controls.Add(Me.CB_BedCategory)
        Me.txtsearch.Location = New System.Drawing.Point(25, 72)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(1037, 406)
        Me.txtsearch.TabIndex = 9
        Me.txtsearch.TabStop = False
        Me.txtsearch.Text = "Patient Detail"
        '
        'txtbedno
        '
        Me.txtbedno.Location = New System.Drawing.Point(144, 100)
        Me.txtbedno.Name = "txtbedno"
        Me.txtbedno.Size = New System.Drawing.Size(104, 20)
        Me.txtbedno.TabIndex = 83
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(852, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 23)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "Baby's Details"
        '
        'txttime
        '
        Me.txttime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txttime.Location = New System.Drawing.Point(892, 200)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(104, 20)
        Me.txttime.TabIndex = 79
        '
        'Childrenform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 485)
        Me.Controls.Add(Me.txtsearch)
        Me.Name = "Childrenform"
        Me.Text = "Childrenform"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txtsearch.ResumeLayout(False)
        Me.txtsearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CB_BedCategory As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRegno As TextBox
    Friend WithEvents txtPatiname As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnDischarge As Button
    Friend WithEvents btnSaveRegistration As Button
    Friend WithEvents btnCancelRegistration As Button
    Friend WithEvents btnEditRegistration As Button
    Friend WithEvents btnRegisterPatient As Button
    Friend WithEvents DTP_date As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents RtxtAddress As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CB_Gendergp As ComboBox
    Friend WithEvents txtDisease As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtdoctor As TextBox
    Friend WithEvents txtsearch As GroupBox
    Friend WithEvents txttime As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents txtbedno As TextBox
    Friend WithEvents Resetbutton As Button
    Friend WithEvents Button1 As Button
End Class
