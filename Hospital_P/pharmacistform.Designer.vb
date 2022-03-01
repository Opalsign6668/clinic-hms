<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pharmacistform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pharmacistform))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdiagnoses = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Cbconfirmation = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtseacrh = New System.Windows.Forms.TextBox()
        Me.grpbtn = New System.Windows.Forms.GroupBox()
        Me.btndone = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txthistory = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtsur = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtlab = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txttime = New System.Windows.Forms.DateTimePicker()
        Me.txtpharmaname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.txtdoctor = New System.Windows.Forms.TextBox()
        Me.txttreatment = New System.Windows.Forms.TextBox()
        Me.txtsympton = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DoctorsDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.grpbtn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1133, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 88
        Me.Button1.Text = "&Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(463, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 42)
        Me.Panel1.TabIndex = 86
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(52, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 27)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Pharmacist"
        '
        'txtdiagnoses
        '
        Me.txtdiagnoses.Location = New System.Drawing.Point(115, 75)
        Me.txtdiagnoses.Multiline = True
        Me.txtdiagnoses.Name = "txtdiagnoses"
        Me.txtdiagnoses.Size = New System.Drawing.Size(310, 39)
        Me.txtdiagnoses.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(543, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = "Confirmation"
        '
        'Cbconfirmation
        '
        Me.Cbconfirmation.FormattingEnabled = True
        Me.Cbconfirmation.Items.AddRange(New Object() {"Drug Administered"})
        Me.Cbconfirmation.Location = New System.Drawing.Point(630, 86)
        Me.Cbconfirmation.Name = "Cbconfirmation"
        Me.Cbconfirmation.Size = New System.Drawing.Size(121, 21)
        Me.Cbconfirmation.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Treatment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sympton"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Diagnoses"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Medical history"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(429, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Age"
        '
        'txtseacrh
        '
        Me.txtseacrh.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.txtseacrh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtseacrh.Location = New System.Drawing.Point(991, 83)
        Me.txtseacrh.Multiline = True
        Me.txtseacrh.Name = "txtseacrh"
        Me.txtseacrh.Size = New System.Drawing.Size(126, 21)
        Me.txtseacrh.TabIndex = 5
        '
        'grpbtn
        '
        Me.grpbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpbtn.Controls.Add(Me.btndone)
        Me.grpbtn.Controls.Add(Me.btndelete)
        Me.grpbtn.Controls.Add(Me.btnclear)
        Me.grpbtn.Controls.Add(Me.btnsave)
        Me.grpbtn.Controls.Add(Me.btnedit)
        Me.grpbtn.Location = New System.Drawing.Point(321, 440)
        Me.grpbtn.Name = "grpbtn"
        Me.grpbtn.Size = New System.Drawing.Size(548, 102)
        Me.grpbtn.TabIndex = 80
        Me.grpbtn.TabStop = False
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
        Me.btndone.Location = New System.Drawing.Point(442, 19)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(65, 67)
        Me.btndone.TabIndex = 1
        Me.btndone.Text = "&Reset"
        Me.btndone.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndone.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.Control
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.Location = New System.Drawing.Point(353, 19)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(61, 68)
        Me.btndelete.TabIndex = 3
        Me.btndelete.Text = "&Delete"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.SystemColors.Control
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.Location = New System.Drawing.Point(260, 18)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(72, 68)
        Me.btnclear.TabIndex = 2
        Me.btnclear.Text = "&Refresh"
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Gray
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(86, 18)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(64, 68)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Gray
        Me.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnedit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnedit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.Location = New System.Drawing.Point(177, 19)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(57, 67)
        Me.btnedit.TabIndex = 0
        Me.btnedit.Text = "&Edit"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(108, 97)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(81, 20)
        Me.txtid.TabIndex = 0
        '
        'txthistory
        '
        Me.txthistory.Location = New System.Drawing.Point(115, 30)
        Me.txthistory.Multiline = True
        Me.txthistory.Name = "txthistory"
        Me.txthistory.Size = New System.Drawing.Size(310, 39)
        Me.txthistory.TabIndex = 0
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(416, 96)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(63, 20)
        Me.txtage.TabIndex = 82
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(309, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Surname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(210, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "First name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(114, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Patient ID"
        '
        'txtsur
        '
        Me.txtsur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsur.Location = New System.Drawing.Point(298, 97)
        Me.txtsur.Name = "txtsur"
        Me.txtsur.Size = New System.Drawing.Size(97, 20)
        Me.txtsur.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(195, 97)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(96, 20)
        Me.txtname.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(515, 141)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(680, 277)
        Me.DataGridView1.TabIndex = 72
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtlab)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Cbconfirmation)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtage)
        Me.Panel3.Controls.Add(Me.txtseacrh)
        Me.Panel3.Controls.Add(Me.grpbtn)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtsur)
        Me.Panel3.Controls.Add(Me.txtname)
        Me.Panel3.Controls.Add(Me.txtid)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.MenuStrip1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(23, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1217, 557)
        Me.Panel3.TabIndex = 0
        '
        'txtlab
        '
        Me.txtlab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlab.Location = New System.Drawing.Point(833, 76)
        Me.txtlab.Multiline = True
        Me.txtlab.Name = "txtlab"
        Me.txtlab.Size = New System.Drawing.Size(124, 38)
        Me.txtlab.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(770, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "Lab-Test"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txttime)
        Me.GroupBox1.Controls.Add(Me.txtpharmaname)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.dtp)
        Me.GroupBox1.Controls.Add(Me.txtdoctor)
        Me.GroupBox1.Controls.Add(Me.txttreatment)
        Me.GroupBox1.Controls.Add(Me.txtsympton)
        Me.GroupBox1.Controls.Add(Me.txtdiagnoses)
        Me.GroupBox1.Controls.Add(Me.txthistory)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 306)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(253, 253)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "Time"
        '
        'txttime
        '
        Me.txttime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txttime.Location = New System.Drawing.Point(293, 249)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(132, 20)
        Me.txttime.TabIndex = 65
        '
        'txtpharmaname
        '
        Me.txtpharmaname.Location = New System.Drawing.Point(126, 253)
        Me.txtpharmaname.Name = "txtpharmaname"
        Me.txtpharmaname.Size = New System.Drawing.Size(95, 20)
        Me.txtpharmaname.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 256)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Pharmacist Name"
        '
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(293, 210)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(132, 20)
        Me.dtp.TabIndex = 12
        '
        'txtdoctor
        '
        Me.txtdoctor.Location = New System.Drawing.Point(126, 210)
        Me.txtdoctor.Name = "txtdoctor"
        Me.txtdoctor.Size = New System.Drawing.Size(95, 20)
        Me.txtdoctor.TabIndex = 4
        '
        'txttreatment
        '
        Me.txttreatment.Location = New System.Drawing.Point(115, 165)
        Me.txttreatment.Multiline = True
        Me.txttreatment.Name = "txttreatment"
        Me.txttreatment.Size = New System.Drawing.Size(310, 39)
        Me.txttreatment.TabIndex = 3
        '
        'txtsympton
        '
        Me.txtsympton.Location = New System.Drawing.Point(115, 120)
        Me.txtsympton.Multiline = True
        Me.txtsympton.Name = "txtsympton"
        Me.txtsympton.Size = New System.Drawing.Size(310, 39)
        Me.txtsympton.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(257, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Doctor Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoctorsDetailsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1213, 25)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DoctorsDetailsToolStripMenuItem
        '
        Me.DoctorsDetailsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoctorsDetailsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DoctorsDetailsToolStripMenuItem.Name = "DoctorsDetailsToolStripMenuItem"
        Me.DoctorsDetailsToolStripMenuItem.Size = New System.Drawing.Size(118, 21)
        Me.DoctorsDetailsToolStripMenuItem.Text = "Doctor's Details"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(58, 21)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(497, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(713, 306)
        Me.Panel2.TabIndex = 87
        '
        'pharmacistform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 600)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "pharmacistform"
        Me.Text = "pharmacistform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpbtn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtdiagnoses As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Cbconfirmation As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtseacrh As TextBox
    Friend WithEvents grpbtn As GroupBox
    Friend WithEvents btndone As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents txthistory As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtsur As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtpharmaname As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txttreatment As TextBox
    Friend WithEvents txtsympton As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DoctorsDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents txttime As DateTimePicker
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents txtdoctor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtlab As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
