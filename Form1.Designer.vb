Imports System

Namespace NoxiusDefenderDisabler
    Partial Class Form1
        Private components As ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub



        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
            Me.enable = New Guna.UI2.WinForms.Guna2GradientButton()
            Me.disable = New Guna.UI2.WinForms.Guna2GradientButton()
            Me.label1 = New System.Windows.Forms.Label()
            Me.guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
            Me.guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
            Me.guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
            Me.guna2ImageButton2 = New Guna.UI2.WinForms.Guna2ImageButton()
            Me.guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
            CType(Me.guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'guna2BorderlessForm1
            '
            Me.guna2BorderlessForm1.BorderRadius = 15
            Me.guna2BorderlessForm1.ContainerControl = Me
            Me.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
            Me.guna2BorderlessForm1.DragEndTransparencyValue = 0.9R
            Me.guna2BorderlessForm1.DragStartTransparencyValue = 0.8R
            Me.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Indigo
            Me.guna2BorderlessForm1.TransparentWhileDrag = True
            '
            'enable
            '
            Me.enable.Animated = True
            Me.enable.BackColor = System.Drawing.Color.Transparent
            Me.enable.BorderRadius = 12
            Me.enable.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.enable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.enable.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.enable.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.enable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.enable.FillColor = System.Drawing.Color.Indigo
            Me.enable.FillColor2 = System.Drawing.Color.Purple
            Me.enable.Font = New System.Drawing.Font("Arial Black", 10.0!)
            Me.enable.ForeColor = System.Drawing.Color.White
            Me.enable.Location = New System.Drawing.Point(13, 221)
            Me.enable.Name = "enable"
            Me.enable.Size = New System.Drawing.Size(161, 44)
            Me.enable.TabIndex = 0
            Me.enable.Text = "Enable"
            Me.enable.UseTransparentBackground = True
            '
            'disable
            '
            Me.disable.Animated = True
            Me.disable.BackColor = System.Drawing.Color.Transparent
            Me.disable.BorderRadius = 12
            Me.disable.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.disable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.disable.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.disable.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.disable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.disable.FillColor = System.Drawing.Color.Indigo
            Me.disable.FillColor2 = System.Drawing.Color.Purple
            Me.disable.Font = New System.Drawing.Font("Arial Black", 10.0!)
            Me.disable.ForeColor = System.Drawing.Color.White
            Me.disable.Location = New System.Drawing.Point(197, 221)
            Me.disable.Name = "disable"
            Me.disable.Size = New System.Drawing.Size(161, 44)
            Me.disable.TabIndex = 1
            Me.disable.Text = "Disable"
            Me.disable.UseTransparentBackground = True
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Arial Black", 12.0!)
            Me.label1.ForeColor = System.Drawing.Color.Indigo
            Me.label1.Location = New System.Drawing.Point(9, 6)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(222, 23)
            Me.label1.TabIndex = 2
            Me.label1.Text = "NoxiusDefenderDisabler"
            '
            'guna2ControlBox1
            '
            Me.guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.guna2ControlBox1.IconColor = System.Drawing.Color.White
            Me.guna2ControlBox1.Location = New System.Drawing.Point(325, 0)
            Me.guna2ControlBox1.Name = "guna2ControlBox1"
            Me.guna2ControlBox1.Size = New System.Drawing.Size(45, 31)
            Me.guna2ControlBox1.TabIndex = 4
            '
            'guna2ControlBox2
            '
            Me.guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
            Me.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.guna2ControlBox2.IconColor = System.Drawing.Color.White
            Me.guna2ControlBox2.Location = New System.Drawing.Point(279, 0)
            Me.guna2ControlBox2.Name = "guna2ControlBox2"
            Me.guna2ControlBox2.Size = New System.Drawing.Size(45, 31)
            Me.guna2ControlBox2.TabIndex = 5
            '
            'guna2ImageButton1
            '
            Me.guna2ImageButton1.AnimatedGIF = True
            Me.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent
            Me.guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
            Me.guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(40, 40)
            Me.guna2ImageButton1.Image = CType(resources.GetObject("guna2ImageButton1.Image"), System.Drawing.Image)
            Me.guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
            Me.guna2ImageButton1.ImageRotate = 0!
            Me.guna2ImageButton1.ImageSize = New System.Drawing.Size(40, 40)
            Me.guna2ImageButton1.Location = New System.Drawing.Point(299, 338)
            Me.guna2ImageButton1.Name = "guna2ImageButton1"
            Me.guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(40, 40)
            Me.guna2ImageButton1.Size = New System.Drawing.Size(59, 53)
            Me.guna2ImageButton1.TabIndex = 7
            Me.guna2ImageButton1.UseTransparentBackground = True
            '
            'guna2ImageButton2
            '
            Me.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent
            Me.guna2ImageButton2.CheckedState.ImageSize = New System.Drawing.Size(40, 40)
            Me.guna2ImageButton2.HoverState.ImageSize = New System.Drawing.Size(40, 40)
            Me.guna2ImageButton2.Image = CType(resources.GetObject("guna2ImageButton2.Image"), System.Drawing.Image)
            Me.guna2ImageButton2.ImageOffset = New System.Drawing.Point(0, 0)
            Me.guna2ImageButton2.ImageRotate = 0!
            Me.guna2ImageButton2.ImageSize = New System.Drawing.Size(40, 40)
            Me.guna2ImageButton2.Location = New System.Drawing.Point(230, 338)
            Me.guna2ImageButton2.Name = "guna2ImageButton2"
            Me.guna2ImageButton2.PressedState.ImageSize = New System.Drawing.Size(40, 40)
            Me.guna2ImageButton2.Size = New System.Drawing.Size(59, 53)
            Me.guna2ImageButton2.TabIndex = 8
            Me.guna2ImageButton2.UseTransparentBackground = True
            '
            'guna2PictureBox2
            '
            Me.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
            Me.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent
            Me.guna2PictureBox2.ImageRotate = 0!
            Me.guna2PictureBox2.Location = New System.Drawing.Point(132, 72)
            Me.guna2PictureBox2.Name = "guna2PictureBox2"
            Me.guna2PictureBox2.Size = New System.Drawing.Size(108, 116)
            Me.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.guna2PictureBox2.TabIndex = 6
            Me.guna2PictureBox2.TabStop = False
            Me.guna2PictureBox2.UseTransparentBackground = True
            '
            'guna2PictureBox1
            '
            Me.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
            Me.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
            Me.guna2PictureBox1.ImageRotate = 0!
            Me.guna2PictureBox1.Location = New System.Drawing.Point(12, 328)
            Me.guna2PictureBox1.Name = "guna2PictureBox1"
            Me.guna2PictureBox1.Size = New System.Drawing.Size(71, 70)
            Me.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.guna2PictureBox1.TabIndex = 3
            Me.guna2PictureBox1.TabStop = False
            Me.guna2PictureBox1.UseTransparentBackground = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(370, 403)
            Me.Controls.Add(Me.guna2ImageButton2)
            Me.Controls.Add(Me.guna2ImageButton1)
            Me.Controls.Add(Me.guna2PictureBox2)
            Me.Controls.Add(Me.guna2ControlBox2)
            Me.Controls.Add(Me.guna2ControlBox1)
            Me.Controls.Add(Me.guna2PictureBox1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.disable)
            Me.Controls.Add(Me.enable)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.Opacity = 0.9R
            CType(Me.guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
        Private disable As Guna.UI2.WinForms.Guna2GradientButton
        Private enable As Guna.UI2.WinForms.Guna2GradientButton
        Private guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
        Private guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
        Private guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
        Private label1 As Windows.Forms.Label
        Private guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
        Private guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
        Private guna2ImageButton2 As Guna.UI2.WinForms.Guna2ImageButton
    End Class
End Namespace
