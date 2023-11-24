<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPassworddata
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResetPassworddata))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Txt_CardNumber = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Txt_holder = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.Btn_modify = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 96)
        Me.Panel1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Baskerville Old Face", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(112, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(246, 43)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Reset Password"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(86, 158)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(299, 1)
        Me.Panel4.TabIndex = 93
        '
        'Txt_CardNumber
        '
        Me.Txt_CardNumber.AcceptsReturn = False
        Me.Txt_CardNumber.AcceptsTab = False
        Me.Txt_CardNumber.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_CardNumber.AnimationSpeed = 200
        Me.Txt_CardNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Txt_CardNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Txt_CardNumber.BackColor = System.Drawing.Color.Transparent
        Me.Txt_CardNumber.BackgroundImage = CType(resources.GetObject("Txt_CardNumber.BackgroundImage"), System.Drawing.Image)
        Me.Txt_CardNumber.BorderColorActive = System.Drawing.Color.Black
        Me.Txt_CardNumber.BorderColorDisabled = System.Drawing.Color.Black
        Me.Txt_CardNumber.BorderColorHover = System.Drawing.Color.Black
        Me.Txt_CardNumber.BorderColorIdle = System.Drawing.Color.Black
        Me.Txt_CardNumber.BorderRadius = 30
        Me.Txt_CardNumber.BorderThickness = 1
        Me.Txt_CardNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Txt_CardNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_CardNumber.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Txt_CardNumber.DefaultText = ""
        Me.Txt_CardNumber.FillColor = System.Drawing.Color.Black
        Me.Txt_CardNumber.ForeColor = System.Drawing.Color.White
        Me.Txt_CardNumber.HideSelection = True
        Me.Txt_CardNumber.IconLeft = Global.Grocery_login_form.My.Resources.Resources.Card
        Me.Txt_CardNumber.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_CardNumber.IconPadding = -5
        Me.Txt_CardNumber.IconRight = Nothing
        Me.Txt_CardNumber.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_CardNumber.Lines = New String(-1) {}
        Me.Txt_CardNumber.Location = New System.Drawing.Point(80, 129)
        Me.Txt_CardNumber.MaxLength = 32767
        Me.Txt_CardNumber.MinimumSize = New System.Drawing.Size(1, 1)
        Me.Txt_CardNumber.Modified = False
        Me.Txt_CardNumber.Multiline = False
        Me.Txt_CardNumber.Name = "Txt_CardNumber"
        StateProperties1.BorderColor = System.Drawing.Color.Black
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_CardNumber.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.Black
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.Txt_CardNumber.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.Black
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_CardNumber.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Black
        StateProperties4.FillColor = System.Drawing.Color.Black
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_CardNumber.OnIdleState = StateProperties4
        Me.Txt_CardNumber.Padding = New System.Windows.Forms.Padding(3)
        Me.Txt_CardNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_CardNumber.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.Txt_CardNumber.PlaceholderText = "Enter Password                "
        Me.Txt_CardNumber.ReadOnly = False
        Me.Txt_CardNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Txt_CardNumber.SelectedText = ""
        Me.Txt_CardNumber.SelectionLength = 0
        Me.Txt_CardNumber.SelectionStart = 0
        Me.Txt_CardNumber.ShortcutsEnabled = True
        Me.Txt_CardNumber.Size = New System.Drawing.Size(318, 33)
        Me.Txt_CardNumber.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.Txt_CardNumber.TabIndex = 96
        Me.Txt_CardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Txt_CardNumber.TextMarginBottom = 0
        Me.Txt_CardNumber.TextMarginLeft = 3
        Me.Txt_CardNumber.TextMarginTop = 0
        Me.Txt_CardNumber.TextPlaceholder = "Enter Password                "
        Me.Txt_CardNumber.UseSystemPasswordChar = False
        Me.Txt_CardNumber.WordWrap = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(86, 234)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(299, 1)
        Me.Panel3.TabIndex = 95
        '
        'Txt_holder
        '
        Me.Txt_holder.AcceptsReturn = False
        Me.Txt_holder.AcceptsTab = False
        Me.Txt_holder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_holder.AnimationSpeed = 200
        Me.Txt_holder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Txt_holder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Txt_holder.BackColor = System.Drawing.Color.Transparent
        Me.Txt_holder.BackgroundImage = CType(resources.GetObject("Txt_holder.BackgroundImage"), System.Drawing.Image)
        Me.Txt_holder.BorderColorActive = System.Drawing.Color.Black
        Me.Txt_holder.BorderColorDisabled = System.Drawing.Color.Black
        Me.Txt_holder.BorderColorHover = System.Drawing.Color.Black
        Me.Txt_holder.BorderColorIdle = System.Drawing.Color.Black
        Me.Txt_holder.BorderRadius = 30
        Me.Txt_holder.BorderThickness = 1
        Me.Txt_holder.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Txt_holder.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_holder.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Txt_holder.DefaultText = ""
        Me.Txt_holder.FillColor = System.Drawing.Color.Black
        Me.Txt_holder.ForeColor = System.Drawing.Color.White
        Me.Txt_holder.HideSelection = True
        Me.Txt_holder.IconLeft = Global.Grocery_login_form.My.Resources.Resources.cardholder
        Me.Txt_holder.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_holder.IconPadding = 0
        Me.Txt_holder.IconRight = Nothing
        Me.Txt_holder.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_holder.Lines = New String(-1) {}
        Me.Txt_holder.Location = New System.Drawing.Point(76, 204)
        Me.Txt_holder.MaxLength = 32767
        Me.Txt_holder.MinimumSize = New System.Drawing.Size(1, 1)
        Me.Txt_holder.Modified = False
        Me.Txt_holder.Multiline = False
        Me.Txt_holder.Name = "Txt_holder"
        StateProperties5.BorderColor = System.Drawing.Color.Black
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_holder.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.Black
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.Txt_holder.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.Black
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_holder.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.Black
        StateProperties8.FillColor = System.Drawing.Color.Black
        StateProperties8.ForeColor = System.Drawing.Color.White
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_holder.OnIdleState = StateProperties8
        Me.Txt_holder.Padding = New System.Windows.Forms.Padding(3)
        Me.Txt_holder.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_holder.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.Txt_holder.PlaceholderText = "Confirm Password"
        Me.Txt_holder.ReadOnly = False
        Me.Txt_holder.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Txt_holder.SelectedText = ""
        Me.Txt_holder.SelectionLength = 0
        Me.Txt_holder.SelectionStart = 0
        Me.Txt_holder.ShortcutsEnabled = True
        Me.Txt_holder.Size = New System.Drawing.Size(318, 33)
        Me.Txt_holder.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.Txt_holder.TabIndex = 94
        Me.Txt_holder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Txt_holder.TextMarginBottom = 0
        Me.Txt_holder.TextMarginLeft = 3
        Me.Txt_holder.TextMarginTop = 0
        Me.Txt_holder.TextPlaceholder = "Confirm Password"
        Me.Txt_holder.UseSystemPasswordChar = False
        Me.Txt_holder.WordWrap = True
        '
        'Btn_modify
        '
        Me.Btn_modify.AllowAnimations = True
        Me.Btn_modify.AllowMouseEffects = True
        Me.Btn_modify.AllowToggling = False
        Me.Btn_modify.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_modify.AnimationSpeed = 200
        Me.Btn_modify.AutoGenerateColors = False
        Me.Btn_modify.AutoRoundBorders = False
        Me.Btn_modify.AutoSizeLeftIcon = True
        Me.Btn_modify.AutoSizeRightIcon = True
        Me.Btn_modify.BackColor = System.Drawing.Color.Transparent
        Me.Btn_modify.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_modify.BackgroundImage = CType(resources.GetObject("Btn_modify.BackgroundImage"), System.Drawing.Image)
        Me.Btn_modify.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_modify.ButtonText = "Reset"
        Me.Btn_modify.ButtonTextMarginLeft = 0
        Me.Btn_modify.ColorContrastOnClick = 45
        Me.Btn_modify.ColorContrastOnHover = 45
        Me.Btn_modify.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.Btn_modify.CustomizableEdges = BorderEdges1
        Me.Btn_modify.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_modify.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn_modify.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Btn_modify.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Btn_modify.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.Btn_modify.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_modify.ForeColor = System.Drawing.Color.White
        Me.Btn_modify.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_modify.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Btn_modify.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.Btn_modify.IconMarginLeft = 11
        Me.Btn_modify.IconPadding = 10
        Me.Btn_modify.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_modify.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Btn_modify.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.Btn_modify.IconSize = 25
        Me.Btn_modify.IdleBorderColor = System.Drawing.Color.Green
        Me.Btn_modify.IdleBorderRadius = 35
        Me.Btn_modify.IdleBorderThickness = 1
        Me.Btn_modify.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_modify.IdleIconLeftImage = Nothing
        Me.Btn_modify.IdleIconRightImage = Nothing
        Me.Btn_modify.IndicateFocus = False
        Me.Btn_modify.Location = New System.Drawing.Point(4, 6)
        Me.Btn_modify.Name = "Btn_modify"
        Me.Btn_modify.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn_modify.OnDisabledState.BorderRadius = 35
        Me.Btn_modify.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_modify.OnDisabledState.BorderThickness = 1
        Me.Btn_modify.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Btn_modify.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Btn_modify.OnDisabledState.IconLeftImage = Nothing
        Me.Btn_modify.OnDisabledState.IconRightImage = Nothing
        Me.Btn_modify.onHoverState.BorderColor = System.Drawing.Color.Green
        Me.Btn_modify.onHoverState.BorderRadius = 35
        Me.Btn_modify.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_modify.onHoverState.BorderThickness = 1
        Me.Btn_modify.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_modify.onHoverState.ForeColor = System.Drawing.Color.White
        Me.Btn_modify.onHoverState.IconLeftImage = Nothing
        Me.Btn_modify.onHoverState.IconRightImage = Nothing
        Me.Btn_modify.OnIdleState.BorderColor = System.Drawing.Color.Green
        Me.Btn_modify.OnIdleState.BorderRadius = 35
        Me.Btn_modify.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_modify.OnIdleState.BorderThickness = 1
        Me.Btn_modify.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_modify.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.Btn_modify.OnIdleState.IconLeftImage = Nothing
        Me.Btn_modify.OnIdleState.IconRightImage = Nothing
        Me.Btn_modify.OnPressedState.BorderColor = System.Drawing.Color.Green
        Me.Btn_modify.OnPressedState.BorderRadius = 35
        Me.Btn_modify.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_modify.OnPressedState.BorderThickness = 1
        Me.Btn_modify.OnPressedState.FillColor = System.Drawing.Color.Green
        Me.Btn_modify.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.Btn_modify.OnPressedState.IconLeftImage = Nothing
        Me.Btn_modify.OnPressedState.IconRightImage = Nothing
        Me.Btn_modify.Size = New System.Drawing.Size(155, 33)
        Me.Btn_modify.TabIndex = 97
        Me.Btn_modify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_modify.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Btn_modify.TextMarginLeft = 0
        Me.Btn_modify.TextPadding = New System.Windows.Forms.Padding(0)
        Me.Btn_modify.UseDefaultRadiusAndThickness = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(73, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 16)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Password and Confirm Password must match"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(73, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(380, 16)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Password must be atleast 8 characters with (0-9), (a-z), symbols"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Btn_modify)
        Me.Panel2.Location = New System.Drawing.Point(291, 265)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 42)
        Me.Panel2.TabIndex = 100
        '
        'ResetPassworddata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(471, 317)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Txt_CardNumber)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Txt_holder)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ResetPassworddata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Txt_CardNumber As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Txt_holder As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents Btn_modify As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
End Class
