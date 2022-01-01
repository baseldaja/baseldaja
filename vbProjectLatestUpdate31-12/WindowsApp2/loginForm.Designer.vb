<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.logingb = New System.Windows.Forms.GroupBox()
        Me.passwordtb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.idtb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.loginb = New Guna.UI2.WinForms.Guna2Button()
        Me.showpasschb = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logingb.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logingb
        '
        Me.logingb.BackgroundImage = CType(resources.GetObject("logingb.BackgroundImage"), System.Drawing.Image)
        Me.logingb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logingb.Controls.Add(Me.passwordtb)
        Me.logingb.Controls.Add(Me.idtb)
        Me.logingb.Controls.Add(Me.loginb)
        Me.logingb.Controls.Add(Me.showpasschb)
        Me.logingb.Controls.Add(Me.PictureBox1)
        Me.logingb.Controls.Add(Me.Label2)
        Me.logingb.Controls.Add(Me.Label1)
        Me.logingb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.logingb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.logingb.Location = New System.Drawing.Point(50, 50)
        Me.logingb.Name = "logingb"
        Me.logingb.Size = New System.Drawing.Size(771, 476)
        Me.logingb.TabIndex = 1
        Me.logingb.TabStop = False
        '
        'passwordtb
        '
        Me.passwordtb.BackColor = System.Drawing.Color.Transparent
        Me.passwordtb.BorderColor = System.Drawing.Color.Transparent
        Me.passwordtb.BorderRadius = 15
        Me.passwordtb.BorderThickness = 0
        Me.passwordtb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordtb.DefaultText = ""
        Me.passwordtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwordtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwordtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordtb.DisabledState.Parent = Me.passwordtb
        Me.passwordtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordtb.FocusedState.Parent = Me.passwordtb
        Me.passwordtb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.passwordtb.ForeColor = System.Drawing.Color.Black
        Me.passwordtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordtb.HoverState.Parent = Me.passwordtb
        Me.passwordtb.Location = New System.Drawing.Point(60, 251)
        Me.passwordtb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.passwordtb.Name = "passwordtb"
        Me.passwordtb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtb.PlaceholderText = "Please Enter Your Password"
        Me.passwordtb.SelectedText = ""
        Me.passwordtb.ShadowDecoration.Parent = Me.passwordtb
        Me.passwordtb.Size = New System.Drawing.Size(234, 29)
        Me.passwordtb.TabIndex = 9
        '
        'idtb
        '
        Me.idtb.BackColor = System.Drawing.Color.Transparent
        Me.idtb.BorderColor = System.Drawing.Color.Transparent
        Me.idtb.BorderRadius = 15
        Me.idtb.BorderThickness = 0
        Me.idtb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idtb.DefaultText = ""
        Me.idtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.idtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.idtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.idtb.DisabledState.Parent = Me.idtb
        Me.idtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.idtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.idtb.FocusedState.Parent = Me.idtb
        Me.idtb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.idtb.ForeColor = System.Drawing.Color.Black
        Me.idtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.idtb.HoverState.Parent = Me.idtb
        Me.idtb.Location = New System.Drawing.Point(60, 184)
        Me.idtb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.idtb.Name = "idtb"
        Me.idtb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.idtb.PlaceholderText = "Please Enter Your ID"
        Me.idtb.SelectedText = ""
        Me.idtb.ShadowDecoration.Parent = Me.idtb
        Me.idtb.Size = New System.Drawing.Size(234, 29)
        Me.idtb.TabIndex = 8
        '
        'loginb
        '
        Me.loginb.Animated = True
        Me.loginb.AutoRoundedCorners = True
        Me.loginb.BackColor = System.Drawing.Color.Transparent
        Me.loginb.BorderColor = System.Drawing.Color.Transparent
        Me.loginb.BorderRadius = 17
        Me.loginb.CheckedState.Parent = Me.loginb
        Me.loginb.CustomImages.Parent = Me.loginb
        Me.loginb.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.loginb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.loginb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.loginb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.loginb.DisabledState.Parent = Me.loginb
        Me.loginb.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.loginb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.loginb.ForeColor = System.Drawing.Color.White
        Me.loginb.HoverState.Parent = Me.loginb
        Me.loginb.Location = New System.Drawing.Point(57, 330)
        Me.loginb.Name = "loginb"
        Me.loginb.ShadowDecoration.Parent = Me.loginb
        Me.loginb.Size = New System.Drawing.Size(234, 36)
        Me.loginb.TabIndex = 7
        Me.loginb.Text = "Login"
        Me.loginb.UseTransparentBackground = True
        '
        'showpasschb
        '
        Me.showpasschb.AutoSize = True
        Me.showpasschb.BackColor = System.Drawing.Color.Transparent
        Me.showpasschb.Location = New System.Drawing.Point(69, 297)
        Me.showpasschb.Name = "showpasschb"
        Me.showpasschb.Size = New System.Drawing.Size(101, 17)
        Me.showpasschb.TabIndex = 6
        Me.showpasschb.Text = "Show password"
        Me.showpasschb.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(57, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(57, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(66, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID:"
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 576)
        Me.Controls.Add(Me.logingb)
        Me.Name = "loginForm"
        Me.Padding = New System.Windows.Forms.Padding(50)
        Me.Text = "Login to mutah health"
        Me.logingb.ResumeLayout(False)
        Me.logingb.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents logingb As GroupBox
    Friend WithEvents showpasschb As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents loginb As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents passwordtb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents idtb As Guna.UI2.WinForms.Guna2TextBox
End Class
