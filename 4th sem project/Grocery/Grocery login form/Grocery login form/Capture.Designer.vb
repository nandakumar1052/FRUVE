<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Captures
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Captures))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_Save = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(193, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 24)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Double click on the image to capture"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(361, 263)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'Btn_Save
        '
        Me.Btn_Save.AllowAnimations = True
        Me.Btn_Save.AllowMouseEffects = True
        Me.Btn_Save.AllowToggling = False
        Me.Btn_Save.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Save.AnimationSpeed = 200
        Me.Btn_Save.AutoGenerateColors = False
        Me.Btn_Save.AutoRoundBorders = False
        Me.Btn_Save.AutoSizeLeftIcon = True
        Me.Btn_Save.AutoSizeRightIcon = True
        Me.Btn_Save.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Save.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Save.BackgroundImage = CType(resources.GetObject("Btn_Save.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Save.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_Save.ButtonText = "Save"
        Me.Btn_Save.ButtonTextMarginLeft = 0
        Me.Btn_Save.ColorContrastOnClick = 45
        Me.Btn_Save.ColorContrastOnHover = 45
        Me.Btn_Save.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.Btn_Save.CustomizableEdges = BorderEdges1
        Me.Btn_Save.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Save.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn_Save.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Btn_Save.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Btn_Save.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.Btn_Save.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save.ForeColor = System.Drawing.Color.White
        Me.Btn_Save.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Save.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Save.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.Btn_Save.IconMarginLeft = 11
        Me.Btn_Save.IconPadding = 10
        Me.Btn_Save.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Save.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Save.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.Btn_Save.IconSize = 25
        Me.Btn_Save.IdleBorderColor = System.Drawing.Color.Maroon
        Me.Btn_Save.IdleBorderRadius = 35
        Me.Btn_Save.IdleBorderThickness = 1
        Me.Btn_Save.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Save.IdleIconLeftImage = Nothing
        Me.Btn_Save.IdleIconRightImage = Nothing
        Me.Btn_Save.IndicateFocus = False
        Me.Btn_Save.Location = New System.Drawing.Point(633, 321)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn_Save.OnDisabledState.BorderRadius = 35
        Me.Btn_Save.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_Save.OnDisabledState.BorderThickness = 1
        Me.Btn_Save.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Btn_Save.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Btn_Save.OnDisabledState.IconLeftImage = Nothing
        Me.Btn_Save.OnDisabledState.IconRightImage = Nothing
        Me.Btn_Save.onHoverState.BorderColor = System.Drawing.Color.Maroon
        Me.Btn_Save.onHoverState.BorderRadius = 35
        Me.Btn_Save.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_Save.onHoverState.BorderThickness = 1
        Me.Btn_Save.onHoverState.FillColor = System.Drawing.Color.Red
        Me.Btn_Save.onHoverState.ForeColor = System.Drawing.Color.White
        Me.Btn_Save.onHoverState.IconLeftImage = Nothing
        Me.Btn_Save.onHoverState.IconRightImage = Nothing
        Me.Btn_Save.OnIdleState.BorderColor = System.Drawing.Color.Maroon
        Me.Btn_Save.OnIdleState.BorderRadius = 35
        Me.Btn_Save.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_Save.OnIdleState.BorderThickness = 1
        Me.Btn_Save.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Save.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.Btn_Save.OnIdleState.IconLeftImage = Nothing
        Me.Btn_Save.OnIdleState.IconRightImage = Nothing
        Me.Btn_Save.OnPressedState.BorderColor = System.Drawing.Color.Red
        Me.Btn_Save.OnPressedState.BorderRadius = 35
        Me.Btn_Save.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_Save.OnPressedState.BorderThickness = 1
        Me.Btn_Save.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Save.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.Btn_Save.OnPressedState.IconLeftImage = Nothing
        Me.Btn_Save.OnPressedState.IconRightImage = Nothing
        Me.Btn_Save.Size = New System.Drawing.Size(107, 32)
        Me.Btn_Save.TabIndex = 76
        Me.Btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_Save.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Btn_Save.TextMarginLeft = 0
        Me.Btn_Save.TextPadding = New System.Windows.Forms.Padding(0)
        Me.Btn_Save.UseDefaultRadiusAndThickness = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(726, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(380, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(361, 263)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 78
        Me.PictureBox2.TabStop = False
        '
        'Captures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(752, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Captures"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Save As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
