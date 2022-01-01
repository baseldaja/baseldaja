<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class doctorForm
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
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.d_myappointmentsgb = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gotoreceiptb = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.aptimetb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.apdatetb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.patcondtb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.patnametb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.showapb = New Guna.UI2.WinForms.Guna2Button()
        Me.welcdoclabel = New System.Windows.Forms.Label()
        Me.removeapb = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.d_myappointmentsgb.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(3, 16)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(830, 181)
        Me.dgv1.TabIndex = 0
        '
        'd_myappointmentsgb
        '
        Me.d_myappointmentsgb.BackColor = System.Drawing.Color.Transparent
        Me.d_myappointmentsgb.Controls.Add(Me.dgv1)
        Me.d_myappointmentsgb.Location = New System.Drawing.Point(12, 365)
        Me.d_myappointmentsgb.Name = "d_myappointmentsgb"
        Me.d_myappointmentsgb.Size = New System.Drawing.Size(836, 200)
        Me.d_myappointmentsgb.TabIndex = 1
        Me.d_myappointmentsgb.TabStop = False
        Me.d_myappointmentsgb.Text = "مواعيدي"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.gotoreceiptb)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.removeapb)
        Me.GroupBox2.Controls.Add(Me.aptimetb)
        Me.GroupBox2.Controls.Add(Me.showapb)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.apdatetb)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.patcondtb)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.patnametb)
        Me.GroupBox2.Location = New System.Drawing.Point(130, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 302)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "تفاصيل الموعد"
        '
        'gotoreceiptb
        '
        Me.gotoreceiptb.CheckedState.Parent = Me.gotoreceiptb
        Me.gotoreceiptb.CustomImages.Parent = Me.gotoreceiptb
        Me.gotoreceiptb.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.gotoreceiptb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.gotoreceiptb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gotoreceiptb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.gotoreceiptb.DisabledState.Parent = Me.gotoreceiptb
        Me.gotoreceiptb.FillColor = System.Drawing.Color.DimGray
        Me.gotoreceiptb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gotoreceiptb.ForeColor = System.Drawing.Color.White
        Me.gotoreceiptb.HoverState.Parent = Me.gotoreceiptb
        Me.gotoreceiptb.Location = New System.Drawing.Point(364, 207)
        Me.gotoreceiptb.Name = "gotoreceiptb"
        Me.gotoreceiptb.ShadowDecoration.Parent = Me.gotoreceiptb
        Me.gotoreceiptb.Size = New System.Drawing.Size(144, 37)
        Me.gotoreceiptb.TabIndex = 4
        Me.gotoreceiptb.Text = "الانتقال للوصفة الطبية"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(194, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "وقت الموعد"
        '
        'aptimetb
        '
        Me.aptimetb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.aptimetb.DefaultText = ""
        Me.aptimetb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.aptimetb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.aptimetb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.aptimetb.DisabledState.Parent = Me.aptimetb
        Me.aptimetb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.aptimetb.FillColor = System.Drawing.Color.DimGray
        Me.aptimetb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.aptimetb.FocusedState.Parent = Me.aptimetb
        Me.aptimetb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.aptimetb.ForeColor = System.Drawing.Color.White
        Me.aptimetb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.aptimetb.HoverState.Parent = Me.aptimetb
        Me.aptimetb.Location = New System.Drawing.Point(41, 122)
        Me.aptimetb.Name = "aptimetb"
        Me.aptimetb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.aptimetb.PlaceholderText = ""
        Me.aptimetb.ReadOnly = True
        Me.aptimetb.SelectedText = ""
        Me.aptimetb.ShadowDecoration.Parent = Me.aptimetb
        Me.aptimetb.Size = New System.Drawing.Size(217, 30)
        Me.aptimetb.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(526, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "تاريخ الموعد"
        '
        'apdatetb
        '
        Me.apdatetb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.apdatetb.DefaultText = ""
        Me.apdatetb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.apdatetb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.apdatetb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.apdatetb.DisabledState.Parent = Me.apdatetb
        Me.apdatetb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.apdatetb.FillColor = System.Drawing.Color.DimGray
        Me.apdatetb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.apdatetb.FocusedState.Parent = Me.apdatetb
        Me.apdatetb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.apdatetb.ForeColor = System.Drawing.Color.White
        Me.apdatetb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.apdatetb.HoverState.Parent = Me.apdatetb
        Me.apdatetb.Location = New System.Drawing.Point(373, 122)
        Me.apdatetb.Name = "apdatetb"
        Me.apdatetb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.apdatetb.PlaceholderText = ""
        Me.apdatetb.ReadOnly = True
        Me.apdatetb.SelectedText = ""
        Me.apdatetb.ShadowDecoration.Parent = Me.apdatetb
        Me.apdatetb.Size = New System.Drawing.Size(217, 30)
        Me.apdatetb.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "الحالة الطبية "
        '
        'patcondtb
        '
        Me.patcondtb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.patcondtb.DefaultText = ""
        Me.patcondtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.patcondtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.patcondtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.patcondtb.DisabledState.Parent = Me.patcondtb
        Me.patcondtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.patcondtb.FillColor = System.Drawing.Color.DimGray
        Me.patcondtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.patcondtb.FocusedState.Parent = Me.patcondtb
        Me.patcondtb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.patcondtb.ForeColor = System.Drawing.Color.White
        Me.patcondtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.patcondtb.HoverState.Parent = Me.patcondtb
        Me.patcondtb.Location = New System.Drawing.Point(41, 51)
        Me.patcondtb.Name = "patcondtb"
        Me.patcondtb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.patcondtb.PlaceholderText = ""
        Me.patcondtb.ReadOnly = True
        Me.patcondtb.SelectedText = ""
        Me.patcondtb.ShadowDecoration.Parent = Me.patcondtb
        Me.patcondtb.Size = New System.Drawing.Size(217, 30)
        Me.patcondtb.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(532, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "اسم المريض"
        '
        'patnametb
        '
        Me.patnametb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.patnametb.DefaultText = ""
        Me.patnametb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.patnametb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.patnametb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.patnametb.DisabledState.Parent = Me.patnametb
        Me.patnametb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.patnametb.FillColor = System.Drawing.Color.DimGray
        Me.patnametb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.patnametb.FocusedState.Parent = Me.patnametb
        Me.patnametb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.patnametb.ForeColor = System.Drawing.Color.White
        Me.patnametb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.patnametb.HoverState.Parent = Me.patnametb
        Me.patnametb.Location = New System.Drawing.Point(373, 51)
        Me.patnametb.Name = "patnametb"
        Me.patnametb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.patnametb.PlaceholderText = ""
        Me.patnametb.ReadOnly = True
        Me.patnametb.SelectedText = ""
        Me.patnametb.ShadowDecoration.Parent = Me.patnametb
        Me.patnametb.Size = New System.Drawing.Size(217, 30)
        Me.patnametb.TabIndex = 2
        '
        'showapb
        '
        Me.showapb.CheckedState.Parent = Me.showapb
        Me.showapb.CustomImages.Parent = Me.showapb
        Me.showapb.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.showapb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.showapb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.showapb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.showapb.DisabledState.Parent = Me.showapb
        Me.showapb.FillColor = System.Drawing.Color.DimGray
        Me.showapb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.showapb.ForeColor = System.Drawing.Color.White
        Me.showapb.HoverState.Parent = Me.showapb
        Me.showapb.Location = New System.Drawing.Point(105, 207)
        Me.showapb.Name = "showapb"
        Me.showapb.ShadowDecoration.Parent = Me.showapb
        Me.showapb.Size = New System.Drawing.Size(123, 37)
        Me.showapb.TabIndex = 0
        Me.showapb.Text = "اظهار مواعيدي"
        '
        'welcdoclabel
        '
        Me.welcdoclabel.AutoSize = True
        Me.welcdoclabel.BackColor = System.Drawing.Color.Transparent
        Me.welcdoclabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcdoclabel.ForeColor = System.Drawing.Color.Black
        Me.welcdoclabel.Location = New System.Drawing.Point(126, 23)
        Me.welcdoclabel.Name = "welcdoclabel"
        Me.welcdoclabel.Size = New System.Drawing.Size(86, 20)
        Me.welcdoclabel.TabIndex = 3
        Me.welcdoclabel.Text = "ليبل الترحيب"
        Me.welcdoclabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'removeapb
        '
        Me.removeapb.CheckedState.Parent = Me.removeapb
        Me.removeapb.CustomImages.Parent = Me.removeapb
        Me.removeapb.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.removeapb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.removeapb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.removeapb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.removeapb.DisabledState.Parent = Me.removeapb
        Me.removeapb.FillColor = System.Drawing.Color.DimGray
        Me.removeapb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.removeapb.ForeColor = System.Drawing.Color.White
        Me.removeapb.HoverState.Parent = Me.removeapb
        Me.removeapb.Location = New System.Drawing.Point(234, 207)
        Me.removeapb.Name = "removeapb"
        Me.removeapb.ShadowDecoration.Parent = Me.removeapb
        Me.removeapb.Size = New System.Drawing.Size(124, 37)
        Me.removeapb.TabIndex = 1
        Me.removeapb.Text = "ازالة الموعد"
        '
        'doctorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(860, 577)
        Me.Controls.Add(Me.welcdoclabel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.d_myappointmentsgb)
        Me.Name = "doctorForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "doctorForm"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.d_myappointmentsgb.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents d_myappointmentsgb As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents welcdoclabel As Label
    Friend WithEvents showapb As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents patcondtb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents patnametb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents removeapb As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents apdatetb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gotoreceiptb As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents aptimetb As Guna.UI2.WinForms.Guna2TextBox
End Class
