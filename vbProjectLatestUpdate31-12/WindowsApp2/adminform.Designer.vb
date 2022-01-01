<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminform))
        Me.tc1 = New System.Windows.Forms.TabControl()
        Me.secretarytp = New System.Windows.Forms.TabPage()
        Me.Appointment_managmentgb = New System.Windows.Forms.GroupBox()
        Me.apdocnamecb = New System.Windows.Forms.ComboBox()
        Me.aptime = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.apdate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.appidtb = New System.Windows.Forms.TextBox()
        Me.appatnametb = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.avtimetb = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.patconcb = New System.Windows.Forms.ComboBox()
        Me.showapb = New System.Windows.Forms.Button()
        Me.removeapb = New System.Windows.Forms.Button()
        Me.addapb = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mngcb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.back = New System.Windows.Forms.Button()
        Me.Closeb = New System.Windows.Forms.Button()
        Me.doctors_managmentgb = New System.Windows.Forms.GroupBox()
        Me.endtime = New System.Windows.Forms.DateTimePicker()
        Me.starttime = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.removedb = New System.Windows.Forms.Button()
        Me.adddb = New System.Windows.Forms.Button()
        Me.showdb = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.docsptb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.docnametb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.docidtb = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.infogb = New System.Windows.Forms.GroupBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.patients_managmentgb = New System.Windows.Forms.GroupBox()
        Me.patnametb = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.patphonetb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.showpb = New System.Windows.Forms.Button()
        Me.removepb = New System.Windows.Forms.Button()
        Me.addpb = New System.Windows.Forms.Button()
        Me.patidtb = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.shownewpass = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.showoldpass = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.cahangepassb = New Guna.UI2.WinForms.Guna2Button()
        Me.doneb1 = New Guna.UI2.WinForms.Guna2Button()
        Me.editb1 = New Guna.UI2.WinForms.Guna2Button()
        Me.newpasstb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.oldpasstb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mynametb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tc1.SuspendLayout()
        Me.secretarytp.SuspendLayout()
        Me.Appointment_managmentgb.SuspendLayout()
        Me.doctors_managmentgb.SuspendLayout()
        Me.infogb.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.patients_managmentgb.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc1
        '
        Me.tc1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tc1.Controls.Add(Me.secretarytp)
        Me.tc1.Controls.Add(Me.TabPage1)
        Me.tc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc1.Location = New System.Drawing.Point(0, 0)
        Me.tc1.Multiline = True
        Me.tc1.Name = "tc1"
        Me.tc1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tc1.RightToLeftLayout = True
        Me.tc1.SelectedIndex = 0
        Me.tc1.Size = New System.Drawing.Size(933, 576)
        Me.tc1.TabIndex = 1
        '
        'secretarytp
        '
        Me.secretarytp.BackColor = System.Drawing.Color.Transparent
        Me.secretarytp.Controls.Add(Me.mngcb)
        Me.secretarytp.Controls.Add(Me.back)
        Me.secretarytp.Controls.Add(Me.Closeb)
        Me.secretarytp.Controls.Add(Me.doctors_managmentgb)
        Me.secretarytp.Controls.Add(Me.Label12)
        Me.secretarytp.Controls.Add(Me.infogb)
        Me.secretarytp.Controls.Add(Me.Appointment_managmentgb)
        Me.secretarytp.Controls.Add(Me.patients_managmentgb)
        Me.secretarytp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.secretarytp.Location = New System.Drawing.Point(4, 32)
        Me.secretarytp.Name = "secretarytp"
        Me.secretarytp.Padding = New System.Windows.Forms.Padding(3)
        Me.secretarytp.Size = New System.Drawing.Size(925, 540)
        Me.secretarytp.TabIndex = 4
        Me.secretarytp.Text = "الصفحة الرئيسية"
        '
        'Appointment_managmentgb
        '
        Me.Appointment_managmentgb.BackgroundImage = CType(resources.GetObject("Appointment_managmentgb.BackgroundImage"), System.Drawing.Image)
        Me.Appointment_managmentgb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Appointment_managmentgb.Controls.Add(Me.apdocnamecb)
        Me.Appointment_managmentgb.Controls.Add(Me.aptime)
        Me.Appointment_managmentgb.Controls.Add(Me.Label2)
        Me.Appointment_managmentgb.Controls.Add(Me.apdate)
        Me.Appointment_managmentgb.Controls.Add(Me.Label1)
        Me.Appointment_managmentgb.Controls.Add(Me.appidtb)
        Me.Appointment_managmentgb.Controls.Add(Me.appatnametb)
        Me.Appointment_managmentgb.Controls.Add(Me.Label17)
        Me.Appointment_managmentgb.Controls.Add(Me.avtimetb)
        Me.Appointment_managmentgb.Controls.Add(Me.Label18)
        Me.Appointment_managmentgb.Controls.Add(Me.Label16)
        Me.Appointment_managmentgb.Controls.Add(Me.patconcb)
        Me.Appointment_managmentgb.Controls.Add(Me.showapb)
        Me.Appointment_managmentgb.Controls.Add(Me.removeapb)
        Me.Appointment_managmentgb.Controls.Add(Me.addapb)
        Me.Appointment_managmentgb.Controls.Add(Me.Label14)
        Me.Appointment_managmentgb.Controls.Add(Me.Label15)
        Me.Appointment_managmentgb.Location = New System.Drawing.Point(3, 6)
        Me.Appointment_managmentgb.Name = "Appointment_managmentgb"
        Me.Appointment_managmentgb.Size = New System.Drawing.Size(511, 323)
        Me.Appointment_managmentgb.TabIndex = 27
        Me.Appointment_managmentgb.TabStop = False
        Me.Appointment_managmentgb.Text = "تنظيم المواعيد"
        Me.Appointment_managmentgb.Visible = False
        '
        'apdocnamecb
        '
        Me.apdocnamecb.FormattingEnabled = True
        Me.apdocnamecb.Location = New System.Drawing.Point(339, 149)
        Me.apdocnamecb.Name = "apdocnamecb"
        Me.apdocnamecb.Size = New System.Drawing.Size(292, 21)
        Me.apdocnamecb.TabIndex = 41
        '
        'aptime
        '
        Me.aptime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.aptime.Location = New System.Drawing.Point(338, 98)
        Me.aptime.Name = "aptime"
        Me.aptime.Size = New System.Drawing.Size(293, 20)
        Me.aptime.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(596, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "الوقت"
        '
        'apdate
        '
        Me.apdate.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.apdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.apdate.Location = New System.Drawing.Point(16, 98)
        Me.apdate.Name = "apdate"
        Me.apdate.Size = New System.Drawing.Size(303, 20)
        Me.apdate.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "رقم الموعد"
        '
        'appidtb
        '
        Me.appidtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.appidtb.Location = New System.Drawing.Point(14, 42)
        Me.appidtb.Multiline = True
        Me.appidtb.Name = "appidtb"
        Me.appidtb.Size = New System.Drawing.Size(305, 31)
        Me.appidtb.TabIndex = 36
        '
        'appatnametb
        '
        Me.appatnametb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.appatnametb.Location = New System.Drawing.Point(338, 42)
        Me.appatnametb.Multiline = True
        Me.appatnametb.Name = "appatnametb"
        Me.appatnametb.Size = New System.Drawing.Size(293, 31)
        Me.appatnametb.TabIndex = 34
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(566, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "اسم المريض"
        '
        'avtimetb
        '
        Me.avtimetb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.avtimetb.Location = New System.Drawing.Point(19, 203)
        Me.avtimetb.Multiline = True
        Me.avtimetb.Name = "avtimetb"
        Me.avtimetb.ReadOnly = True
        Me.avtimetb.Size = New System.Drawing.Size(300, 31)
        Me.avtimetb.TabIndex = 33
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(219, 187)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 13)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "وقت تواجد الطبيب"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(207, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "الحالة الطبية للمريض"
        '
        'patconcb
        '
        Me.patconcb.FormattingEnabled = True
        Me.patconcb.Location = New System.Drawing.Point(19, 149)
        Me.patconcb.Name = "patconcb"
        Me.patconcb.Size = New System.Drawing.Size(305, 21)
        Me.patconcb.TabIndex = 29
        '
        'showapb
        '
        Me.showapb.Location = New System.Drawing.Point(325, 252)
        Me.showapb.Name = "showapb"
        Me.showapb.Size = New System.Drawing.Size(160, 29)
        Me.showapb.TabIndex = 1
        Me.showapb.Text = "اظهار المواعيد"
        Me.showapb.UseVisualStyleBackColor = True
        '
        'removeapb
        '
        Me.removeapb.Location = New System.Drawing.Point(160, 252)
        Me.removeapb.Name = "removeapb"
        Me.removeapb.Size = New System.Drawing.Size(159, 29)
        Me.removeapb.TabIndex = 26
        Me.removeapb.Text = "ازالة الموعد"
        Me.removeapb.UseVisualStyleBackColor = True
        '
        'addapb
        '
        Me.addapb.Location = New System.Drawing.Point(19, 252)
        Me.addapb.Name = "addapb"
        Me.addapb.Size = New System.Drawing.Size(135, 29)
        Me.addapb.TabIndex = 25
        Me.addapb.Text = "اضافة الموعد"
        Me.addapb.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(274, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "التاريخ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(568, 133)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "اسم الطبيب"
        '
        'mngcb
        '
        Me.mngcb.AutoRoundedCorners = True
        Me.mngcb.BackColor = System.Drawing.Color.Transparent
        Me.mngcb.BorderRadius = 17
        Me.mngcb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.mngcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mngcb.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.mngcb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mngcb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mngcb.FocusedState.Parent = Me.mngcb
        Me.mngcb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mngcb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.mngcb.HoverState.Parent = Me.mngcb
        Me.mngcb.ItemHeight = 30
        Me.mngcb.Items.AddRange(New Object() {"نظام الاطباء", "نظام المرضى", "نظام المواعيد"})
        Me.mngcb.ItemsAppearance.Parent = Me.mngcb
        Me.mngcb.Location = New System.Drawing.Point(738, 28)
        Me.mngcb.Name = "mngcb"
        Me.mngcb.ShadowDecoration.Parent = Me.mngcb
        Me.mngcb.Size = New System.Drawing.Size(184, 36)
        Me.mngcb.TabIndex = 31
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(732, 243)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(184, 37)
        Me.back.TabIndex = 30
        Me.back.Text = "تسجيل الخروج"
        Me.back.UseVisualStyleBackColor = True
        '
        'Closeb
        '
        Me.Closeb.Location = New System.Drawing.Point(732, 286)
        Me.Closeb.Name = "Closeb"
        Me.Closeb.Size = New System.Drawing.Size(184, 37)
        Me.Closeb.TabIndex = 29
        Me.Closeb.Text = "اغلاق"
        Me.Closeb.UseVisualStyleBackColor = True
        '
        'doctors_managmentgb
        '
        Me.doctors_managmentgb.BackgroundImage = CType(resources.GetObject("doctors_managmentgb.BackgroundImage"), System.Drawing.Image)
        Me.doctors_managmentgb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.doctors_managmentgb.Controls.Add(Me.endtime)
        Me.doctors_managmentgb.Controls.Add(Me.starttime)
        Me.doctors_managmentgb.Controls.Add(Me.Label10)
        Me.doctors_managmentgb.Controls.Add(Me.Label19)
        Me.doctors_managmentgb.Controls.Add(Me.removedb)
        Me.doctors_managmentgb.Controls.Add(Me.adddb)
        Me.doctors_managmentgb.Controls.Add(Me.showdb)
        Me.doctors_managmentgb.Controls.Add(Me.Label9)
        Me.doctors_managmentgb.Controls.Add(Me.docsptb)
        Me.doctors_managmentgb.Controls.Add(Me.Label7)
        Me.doctors_managmentgb.Controls.Add(Me.docnametb)
        Me.doctors_managmentgb.Controls.Add(Me.Label5)
        Me.doctors_managmentgb.Controls.Add(Me.docidtb)
        Me.doctors_managmentgb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.doctors_managmentgb.Location = New System.Drawing.Point(3, 3)
        Me.doctors_managmentgb.Name = "doctors_managmentgb"
        Me.doctors_managmentgb.Size = New System.Drawing.Size(346, 326)
        Me.doctors_managmentgb.TabIndex = 3
        Me.doctors_managmentgb.TabStop = False
        Me.doctors_managmentgb.Text = "ادارة الاطباء"
        Me.doctors_managmentgb.Visible = False
        '
        'endtime
        '
        Me.endtime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.endtime.Location = New System.Drawing.Point(445, 229)
        Me.endtime.Name = "endtime"
        Me.endtime.Size = New System.Drawing.Size(250, 20)
        Me.endtime.TabIndex = 23
        '
        'starttime
        '
        Me.starttime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.starttime.Location = New System.Drawing.Point(445, 274)
        Me.starttime.Name = "starttime"
        Me.starttime.Size = New System.Drawing.Size(250, 20)
        Me.starttime.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(633, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "وقت الدوام"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(619, 213)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 13)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "وقت المغادرة"
        '
        'removedb
        '
        Me.removedb.Location = New System.Drawing.Point(219, 112)
        Me.removedb.Name = "removedb"
        Me.removedb.Size = New System.Drawing.Size(126, 31)
        Me.removedb.TabIndex = 15
        Me.removedb.Text = "ازالة الطبيب"
        Me.removedb.UseVisualStyleBackColor = True
        '
        'adddb
        '
        Me.adddb.Location = New System.Drawing.Point(219, 57)
        Me.adddb.Name = "adddb"
        Me.adddb.Size = New System.Drawing.Size(126, 31)
        Me.adddb.TabIndex = 14
        Me.adddb.Text = "اضافة طبيب"
        Me.adddb.UseVisualStyleBackColor = True
        '
        'showdb
        '
        Me.showdb.Location = New System.Drawing.Point(219, 172)
        Me.showdb.Name = "showdb"
        Me.showdb.Size = New System.Drawing.Size(126, 31)
        Me.showdb.TabIndex = 0
        Me.showdb.Text = "عرض الاطباء"
        Me.showdb.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(651, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "التخصص"
        '
        'docsptb
        '
        Me.docsptb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.docsptb.Location = New System.Drawing.Point(377, 172)
        Me.docsptb.Multiline = True
        Me.docsptb.Name = "docsptb"
        Me.docsptb.Size = New System.Drawing.Size(321, 31)
        Me.docsptb.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(633, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "اسم الطبيب"
        '
        'docnametb
        '
        Me.docnametb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.docnametb.Location = New System.Drawing.Point(377, 111)
        Me.docnametb.Multiline = True
        Me.docnametb.Name = "docnametb"
        Me.docnametb.Size = New System.Drawing.Size(321, 31)
        Me.docnametb.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(633, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "رقم الطبيب"
        '
        'docidtb
        '
        Me.docidtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.docidtb.Location = New System.Drawing.Point(377, 54)
        Me.docidtb.Multiline = True
        Me.docidtb.Name = "docidtb"
        Me.docidtb.Size = New System.Drawing.Size(321, 31)
        Me.docidtb.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(796, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "اختر النظام"
        '
        'infogb
        '
        Me.infogb.BackColor = System.Drawing.Color.Transparent
        Me.infogb.Controls.Add(Me.dgv1)
        Me.infogb.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.infogb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infogb.Location = New System.Drawing.Point(3, 332)
        Me.infogb.Name = "infogb"
        Me.infogb.Size = New System.Drawing.Size(919, 205)
        Me.infogb.TabIndex = 2
        Me.infogb.TabStop = False
        Me.infogb.Text = "Information"
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(3, 16)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(913, 186)
        Me.dgv1.TabIndex = 0
        '
        'patients_managmentgb
        '
        Me.patients_managmentgb.BackgroundImage = CType(resources.GetObject("patients_managmentgb.BackgroundImage"), System.Drawing.Image)
        Me.patients_managmentgb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.patients_managmentgb.Controls.Add(Me.patnametb)
        Me.patients_managmentgb.Controls.Add(Me.Label11)
        Me.patients_managmentgb.Controls.Add(Me.patphonetb)
        Me.patients_managmentgb.Controls.Add(Me.Label8)
        Me.patients_managmentgb.Controls.Add(Me.showpb)
        Me.patients_managmentgb.Controls.Add(Me.removepb)
        Me.patients_managmentgb.Controls.Add(Me.addpb)
        Me.patients_managmentgb.Controls.Add(Me.patidtb)
        Me.patients_managmentgb.Controls.Add(Me.Label13)
        Me.patients_managmentgb.Location = New System.Drawing.Point(0, 6)
        Me.patients_managmentgb.Name = "patients_managmentgb"
        Me.patients_managmentgb.Size = New System.Drawing.Size(726, 323)
        Me.patients_managmentgb.TabIndex = 4
        Me.patients_managmentgb.TabStop = False
        Me.patients_managmentgb.Text = "ادارة المرضى"
        Me.patients_managmentgb.Visible = False
        '
        'patnametb
        '
        Me.patnametb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.patnametb.Location = New System.Drawing.Point(355, 109)
        Me.patnametb.Multiline = True
        Me.patnametb.Name = "patnametb"
        Me.patnametb.Size = New System.Drawing.Size(346, 31)
        Me.patnametb.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(636, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "اسم المريض"
        '
        'patphonetb
        '
        Me.patphonetb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.patphonetb.Location = New System.Drawing.Point(355, 169)
        Me.patphonetb.Multiline = True
        Me.patphonetb.Name = "patphonetb"
        Me.patphonetb.Size = New System.Drawing.Size(346, 31)
        Me.patphonetb.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(583, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "رقم الهاتف (اختياري)"
        '
        'showpb
        '
        Me.showpb.Location = New System.Drawing.Point(355, 223)
        Me.showpb.Name = "showpb"
        Me.showpb.Size = New System.Drawing.Size(133, 31)
        Me.showpb.TabIndex = 1
        Me.showpb.Text = "اظهار جميع المرضى"
        Me.showpb.UseVisualStyleBackColor = True
        '
        'removepb
        '
        Me.removepb.Location = New System.Drawing.Point(494, 223)
        Me.removepb.Name = "removepb"
        Me.removepb.Size = New System.Drawing.Size(99, 31)
        Me.removepb.TabIndex = 26
        Me.removepb.Text = "ازالة مريض"
        Me.removepb.UseVisualStyleBackColor = True
        '
        'addpb
        '
        Me.addpb.Location = New System.Drawing.Point(596, 223)
        Me.addpb.Name = "addpb"
        Me.addpb.Size = New System.Drawing.Size(105, 31)
        Me.addpb.TabIndex = 25
        Me.addpb.Text = "اضافة مريض"
        Me.addpb.UseVisualStyleBackColor = True
        '
        'patidtb
        '
        Me.patidtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.patidtb.Location = New System.Drawing.Point(355, 54)
        Me.patidtb.Multiline = True
        Me.patidtb.Name = "patidtb"
        Me.patidtb.Size = New System.Drawing.Size(346, 31)
        Me.patidtb.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(637, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "رقم المريض"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DimGray
        Me.TabPage1.Controls.Add(Me.Guna2GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(925, 540)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "حسابي"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Controls.Add(Me.shownewpass)
        Me.Guna2GroupBox1.Controls.Add(Me.showoldpass)
        Me.Guna2GroupBox1.Controls.Add(Me.cahangepassb)
        Me.Guna2GroupBox1.Controls.Add(Me.doneb1)
        Me.Guna2GroupBox1.Controls.Add(Me.editb1)
        Me.Guna2GroupBox1.Controls.Add(Me.newpasstb)
        Me.Guna2GroupBox1.Controls.Add(Me.oldpasstb)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.mynametb)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(224, 87)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(421, 340)
        Me.Guna2GroupBox1.TabIndex = 5
        Me.Guna2GroupBox1.Text = "معلومات الدخول"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'shownewpass
        '
        Me.shownewpass.AutoSize = True
        Me.shownewpass.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.shownewpass.CheckedState.BorderRadius = 0
        Me.shownewpass.CheckedState.BorderThickness = 0
        Me.shownewpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.shownewpass.CheckMarkColor = System.Drawing.Color.Green
        Me.shownewpass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.shownewpass.Location = New System.Drawing.Point(46, 200)
        Me.shownewpass.Name = "shownewpass"
        Me.shownewpass.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.shownewpass.Size = New System.Drawing.Size(56, 21)
        Me.shownewpass.TabIndex = 19
        Me.shownewpass.Text = "اظهار"
        Me.shownewpass.UncheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.shownewpass.UncheckedState.BorderRadius = 0
        Me.shownewpass.UncheckedState.BorderThickness = 0
        Me.shownewpass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'showoldpass
        '
        Me.showoldpass.AutoSize = True
        Me.showoldpass.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.showoldpass.CheckedState.BorderRadius = 0
        Me.showoldpass.CheckedState.BorderThickness = 0
        Me.showoldpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.showoldpass.CheckMarkColor = System.Drawing.Color.Green
        Me.showoldpass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.showoldpass.Location = New System.Drawing.Point(46, 141)
        Me.showoldpass.Name = "showoldpass"
        Me.showoldpass.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.showoldpass.Size = New System.Drawing.Size(56, 21)
        Me.showoldpass.TabIndex = 18
        Me.showoldpass.Text = "اظهار"
        Me.showoldpass.UncheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.showoldpass.UncheckedState.BorderRadius = 0
        Me.showoldpass.UncheckedState.BorderThickness = 0
        Me.showoldpass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'cahangepassb
        '
        Me.cahangepassb.CheckedState.Parent = Me.cahangepassb
        Me.cahangepassb.CustomImages.Parent = Me.cahangepassb
        Me.cahangepassb.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cahangepassb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cahangepassb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cahangepassb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cahangepassb.DisabledState.Parent = Me.cahangepassb
        Me.cahangepassb.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cahangepassb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cahangepassb.ForeColor = System.Drawing.Color.White
        Me.cahangepassb.HoverState.Parent = Me.cahangepassb
        Me.cahangepassb.Location = New System.Drawing.Point(147, 262)
        Me.cahangepassb.Name = "cahangepassb"
        Me.cahangepassb.ShadowDecoration.Parent = Me.cahangepassb
        Me.cahangepassb.Size = New System.Drawing.Size(120, 33)
        Me.cahangepassb.TabIndex = 16
        Me.cahangepassb.Text = "تغيير كلمة السر"
        '
        'doneb1
        '
        Me.doneb1.BorderThickness = 1
        Me.doneb1.CheckedState.Parent = Me.doneb1
        Me.doneb1.CustomImages.Parent = Me.doneb1
        Me.doneb1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.doneb1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.doneb1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.doneb1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.doneb1.DisabledState.Parent = Me.doneb1
        Me.doneb1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.doneb1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.doneb1.ForeColor = System.Drawing.Color.Transparent
        Me.doneb1.HoverState.Parent = Me.doneb1
        Me.doneb1.Image = CType(resources.GetObject("doneb1.Image"), System.Drawing.Image)
        Me.doneb1.Location = New System.Drawing.Point(36, 82)
        Me.doneb1.Name = "doneb1"
        Me.doneb1.ShadowDecoration.Parent = Me.doneb1
        Me.doneb1.Size = New System.Drawing.Size(30, 25)
        Me.doneb1.TabIndex = 15
        Me.doneb1.Visible = False
        '
        'editb1
        '
        Me.editb1.BorderThickness = 1
        Me.editb1.CheckedState.Parent = Me.editb1
        Me.editb1.CustomImages.Parent = Me.editb1
        Me.editb1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.editb1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.editb1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.editb1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.editb1.DisabledState.Parent = Me.editb1
        Me.editb1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.editb1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.editb1.ForeColor = System.Drawing.Color.Transparent
        Me.editb1.HoverState.Parent = Me.editb1
        Me.editb1.Image = CType(resources.GetObject("editb1.Image"), System.Drawing.Image)
        Me.editb1.Location = New System.Drawing.Point(72, 82)
        Me.editb1.Name = "editb1"
        Me.editb1.ShadowDecoration.Parent = Me.editb1
        Me.editb1.Size = New System.Drawing.Size(30, 25)
        Me.editb1.TabIndex = 12
        '
        'newpasstb
        '
        Me.newpasstb.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.newpasstb.BorderThickness = 2
        Me.newpasstb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.newpasstb.DefaultText = ""
        Me.newpasstb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.newpasstb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.newpasstb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newpasstb.DisabledState.Parent = Me.newpasstb
        Me.newpasstb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newpasstb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newpasstb.FocusedState.Parent = Me.newpasstb
        Me.newpasstb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.newpasstb.ForeColor = System.Drawing.Color.Black
        Me.newpasstb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newpasstb.HoverState.Parent = Me.newpasstb
        Me.newpasstb.Location = New System.Drawing.Point(108, 198)
        Me.newpasstb.Name = "newpasstb"
        Me.newpasstb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newpasstb.PlaceholderText = ""
        Me.newpasstb.SelectedText = ""
        Me.newpasstb.ShadowDecoration.Parent = Me.newpasstb
        Me.newpasstb.Size = New System.Drawing.Size(284, 25)
        Me.newpasstb.TabIndex = 9
        '
        'oldpasstb
        '
        Me.oldpasstb.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.oldpasstb.BorderThickness = 2
        Me.oldpasstb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.oldpasstb.DefaultText = ""
        Me.oldpasstb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.oldpasstb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.oldpasstb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.oldpasstb.DisabledState.Parent = Me.oldpasstb
        Me.oldpasstb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.oldpasstb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.oldpasstb.FocusedState.Parent = Me.oldpasstb
        Me.oldpasstb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.oldpasstb.ForeColor = System.Drawing.Color.Black
        Me.oldpasstb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.oldpasstb.HoverState.Parent = Me.oldpasstb
        Me.oldpasstb.Location = New System.Drawing.Point(108, 138)
        Me.oldpasstb.Name = "oldpasstb"
        Me.oldpasstb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.oldpasstb.PlaceholderText = ""
        Me.oldpasstb.SelectedText = ""
        Me.oldpasstb.ShadowDecoration.Parent = Me.oldpasstb
        Me.oldpasstb.Size = New System.Drawing.Size(284, 25)
        Me.oldpasstb.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(299, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "كلمة السر الجديدة"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(358, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "الاسم"
        '
        'mynametb
        '
        Me.mynametb.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mynametb.BorderThickness = 2
        Me.mynametb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mynametb.DefaultText = ""
        Me.mynametb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.mynametb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.mynametb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mynametb.DisabledState.Parent = Me.mynametb
        Me.mynametb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mynametb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mynametb.FocusedState.Parent = Me.mynametb
        Me.mynametb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mynametb.ForeColor = System.Drawing.Color.Black
        Me.mynametb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mynametb.HoverState.Parent = Me.mynametb
        Me.mynametb.Location = New System.Drawing.Point(108, 82)
        Me.mynametb.Name = "mynametb"
        Me.mynametb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mynametb.PlaceholderText = ""
        Me.mynametb.ReadOnly = True
        Me.mynametb.SelectedText = ""
        Me.mynametb.ShadowDecoration.Parent = Me.mynametb
        Me.mynametb.Size = New System.Drawing.Size(284, 25)
        Me.mynametb.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(299, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "كلمة السر القديمة"
        '
        'adminform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 576)
        Me.Controls.Add(Me.tc1)
        Me.Name = "adminform"
        Me.Text = "Secretary Form"
        Me.tc1.ResumeLayout(False)
        Me.secretarytp.ResumeLayout(False)
        Me.secretarytp.PerformLayout()
        Me.Appointment_managmentgb.ResumeLayout(False)
        Me.Appointment_managmentgb.PerformLayout()
        Me.doctors_managmentgb.ResumeLayout(False)
        Me.doctors_managmentgb.PerformLayout()
        Me.infogb.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.patients_managmentgb.ResumeLayout(False)
        Me.patients_managmentgb.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tc1 As TabControl
    Friend WithEvents secretarytp As TabPage
    Friend WithEvents back As Button
    Friend WithEvents Closeb As Button
    Friend WithEvents doctors_managmentgb As GroupBox
    Friend WithEvents endtime As DateTimePicker
    Friend WithEvents starttime As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents removedb As Button
    Friend WithEvents adddb As Button
    Friend WithEvents showdb As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents docsptb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents docnametb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents docidtb As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents infogb As GroupBox
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Appointment_managmentgb As GroupBox
    Friend WithEvents appatnametb As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents avtimetb As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents showapb As Button
    Friend WithEvents removeapb As Button
    Friend WithEvents addapb As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents patients_managmentgb As GroupBox
    Friend WithEvents patnametb As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents patphonetb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents showpb As Button
    Friend WithEvents removepb As Button
    Friend WithEvents addpb As Button
    Friend WithEvents patidtb As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents appidtb As TextBox
    Friend WithEvents apdate As DateTimePicker
    Friend WithEvents apdocnamecb As ComboBox
    Friend WithEvents aptime As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents patconcb As ComboBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents mngcb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents newpasstb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents oldpasstb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mynametb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents editb1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents doneb1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents showoldpass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents cahangepassb As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents shownewpass As Guna.UI2.WinForms.Guna2CheckBox
End Class
