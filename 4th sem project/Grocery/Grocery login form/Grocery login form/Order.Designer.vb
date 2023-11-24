<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties9 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties10 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties11 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties12 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties13 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties14 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties15 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties16 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Txt_Search = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_modify = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Txt_Stocks = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.Txt_Pcode = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.Txt_Product = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.Label_Pcode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DealerDataGrid = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DealerDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Search
        '
        Me.Txt_Search.AcceptsReturn = False
        Me.Txt_Search.AcceptsTab = False
        Me.Txt_Search.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Search.AnimationSpeed = 200
        Me.Txt_Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Txt_Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Txt_Search.BackColor = System.Drawing.Color.Transparent
        Me.Txt_Search.BackgroundImage = CType(resources.GetObject("Txt_Search.BackgroundImage"), System.Drawing.Image)
        Me.Txt_Search.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.Txt_Search.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Txt_Search.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Search.BorderColorIdle = System.Drawing.Color.Silver
        Me.Txt_Search.BorderRadius = 30
        Me.Txt_Search.BorderThickness = 1
        Me.Txt_Search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Search.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Txt_Search.DefaultText = ""
        Me.Txt_Search.FillColor = System.Drawing.Color.White
        Me.Txt_Search.HideSelection = True
        Me.Txt_Search.IconLeft = Nothing
        Me.Txt_Search.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Search.IconPadding = 10
        Me.Txt_Search.IconRight = Nothing
        Me.Txt_Search.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Search.Lines = New String(-1) {}
        Me.Txt_Search.Location = New System.Drawing.Point(148, 64)
        Me.Txt_Search.MaxLength = 32767
        Me.Txt_Search.MinimumSize = New System.Drawing.Size(1, 1)
        Me.Txt_Search.Modified = False
        Me.Txt_Search.Multiline = False
        Me.Txt_Search.Name = "Txt_Search"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_Search.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.Txt_Search.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_Search.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_Search.OnIdleState = StateProperties4
        Me.Txt_Search.Padding = New System.Windows.Forms.Padding(3)
        Me.Txt_Search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Search.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.Txt_Search.PlaceholderText = ""
        Me.Txt_Search.ReadOnly = False
        Me.Txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Txt_Search.SelectedText = ""
        Me.Txt_Search.SelectionLength = 0
        Me.Txt_Search.SelectionStart = 0
        Me.Txt_Search.ShortcutsEnabled = True
        Me.Txt_Search.Size = New System.Drawing.Size(332, 32)
        Me.Txt_Search.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.Txt_Search.TabIndex = 82
        Me.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Txt_Search.TextMarginBottom = 0
        Me.Txt_Search.TextMarginLeft = 3
        Me.Txt_Search.TextMarginTop = 0
        Me.Txt_Search.TextPlaceholder = ""
        Me.Txt_Search.UseSystemPasswordChar = False
        Me.Txt_Search.WordWrap = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(70, 71)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 22)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "Search :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Btn_modify)
        Me.GroupBox1.Controls.Add(Me.Txt_Stocks)
        Me.GroupBox1.Controls.Add(Me.Txt_Pcode)
        Me.GroupBox1.Controls.Add(Me.Txt_Product)
        Me.GroupBox1.Controls.Add(Me.Label_Pcode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(74, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 336)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(186, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
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
        Me.Btn_modify.ButtonText = "Deliver"
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
        Me.Btn_modify.IdleBorderColor = System.Drawing.Color.Maroon
        Me.Btn_modify.IdleBorderRadius = 35
        Me.Btn_modify.IdleBorderThickness = 1
        Me.Btn_modify.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_modify.IdleIconLeftImage = Nothing
        Me.Btn_modify.IdleIconRightImage = Nothing
        Me.Btn_modify.IndicateFocus = False
        Me.Btn_modify.Location = New System.Drawing.Point(269, 294)
        Me.Btn_modify.Name = "Btn_modify"
        Me.Btn_modify.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn_modify.OnDisabledState.BorderRadius = 35
        Me.Btn_modify.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_modify.OnDisabledState.BorderThickness = 1
        Me.Btn_modify.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Btn_modify.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Btn_modify.OnDisabledState.IconLeftImage = Nothing
        Me.Btn_modify.OnDisabledState.IconRightImage = Nothing
        Me.Btn_modify.onHoverState.BorderColor = System.Drawing.Color.Maroon
        Me.Btn_modify.onHoverState.BorderRadius = 35
        Me.Btn_modify.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_modify.onHoverState.BorderThickness = 1
        Me.Btn_modify.onHoverState.FillColor = System.Drawing.Color.Red
        Me.Btn_modify.onHoverState.ForeColor = System.Drawing.Color.White
        Me.Btn_modify.onHoverState.IconLeftImage = Nothing
        Me.Btn_modify.onHoverState.IconRightImage = Nothing
        Me.Btn_modify.OnIdleState.BorderColor = System.Drawing.Color.Maroon
        Me.Btn_modify.OnIdleState.BorderRadius = 35
        Me.Btn_modify.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_modify.OnIdleState.BorderThickness = 1
        Me.Btn_modify.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_modify.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.Btn_modify.OnIdleState.IconLeftImage = Nothing
        Me.Btn_modify.OnIdleState.IconRightImage = Nothing
        Me.Btn_modify.OnPressedState.BorderColor = System.Drawing.Color.Red
        Me.Btn_modify.OnPressedState.BorderRadius = 35
        Me.Btn_modify.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_modify.OnPressedState.BorderThickness = 1
        Me.Btn_modify.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_modify.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.Btn_modify.OnPressedState.IconLeftImage = Nothing
        Me.Btn_modify.OnPressedState.IconRightImage = Nothing
        Me.Btn_modify.Size = New System.Drawing.Size(127, 33)
        Me.Btn_modify.TabIndex = 77
        Me.Btn_modify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_modify.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Btn_modify.TextMarginLeft = 0
        Me.Btn_modify.TextPadding = New System.Windows.Forms.Padding(0)
        Me.Btn_modify.UseDefaultRadiusAndThickness = True
        '
        'Txt_Stocks
        '
        Me.Txt_Stocks.AcceptsReturn = False
        Me.Txt_Stocks.AcceptsTab = False
        Me.Txt_Stocks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Stocks.AnimationSpeed = 200
        Me.Txt_Stocks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Txt_Stocks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Txt_Stocks.BackColor = System.Drawing.Color.Transparent
        Me.Txt_Stocks.BackgroundImage = CType(resources.GetObject("Txt_Stocks.BackgroundImage"), System.Drawing.Image)
        Me.Txt_Stocks.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.Txt_Stocks.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Txt_Stocks.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Stocks.BorderColorIdle = System.Drawing.Color.Silver
        Me.Txt_Stocks.BorderRadius = 30
        Me.Txt_Stocks.BorderThickness = 1
        Me.Txt_Stocks.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Txt_Stocks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Stocks.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Txt_Stocks.DefaultText = ""
        Me.Txt_Stocks.FillColor = System.Drawing.Color.White
        Me.Txt_Stocks.HideSelection = True
        Me.Txt_Stocks.IconLeft = Nothing
        Me.Txt_Stocks.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Stocks.IconPadding = 10
        Me.Txt_Stocks.IconRight = Nothing
        Me.Txt_Stocks.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Stocks.Lines = New String(-1) {}
        Me.Txt_Stocks.Location = New System.Drawing.Point(148, 135)
        Me.Txt_Stocks.MaxLength = 32767
        Me.Txt_Stocks.MinimumSize = New System.Drawing.Size(1, 1)
        Me.Txt_Stocks.Modified = False
        Me.Txt_Stocks.Multiline = False
        Me.Txt_Stocks.Name = "Txt_Stocks"
        StateProperties5.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_Stocks.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.Txt_Stocks.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_Stocks.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.Silver
        StateProperties8.FillColor = System.Drawing.Color.White
        StateProperties8.ForeColor = System.Drawing.Color.Empty
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_Stocks.OnIdleState = StateProperties8
        Me.Txt_Stocks.Padding = New System.Windows.Forms.Padding(3)
        Me.Txt_Stocks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Stocks.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.Txt_Stocks.PlaceholderText = ""
        Me.Txt_Stocks.ReadOnly = True
        Me.Txt_Stocks.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Txt_Stocks.SelectedText = ""
        Me.Txt_Stocks.SelectionLength = 0
        Me.Txt_Stocks.SelectionStart = 0
        Me.Txt_Stocks.ShortcutsEnabled = True
        Me.Txt_Stocks.Size = New System.Drawing.Size(205, 33)
        Me.Txt_Stocks.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.Txt_Stocks.TabIndex = 79
        Me.Txt_Stocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Txt_Stocks.TextMarginBottom = 0
        Me.Txt_Stocks.TextMarginLeft = 3
        Me.Txt_Stocks.TextMarginTop = 0
        Me.Txt_Stocks.TextPlaceholder = ""
        Me.Txt_Stocks.UseSystemPasswordChar = False
        Me.Txt_Stocks.WordWrap = True
        '
        'Txt_Pcode
        '
        Me.Txt_Pcode.AcceptsReturn = False
        Me.Txt_Pcode.AcceptsTab = False
        Me.Txt_Pcode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Pcode.AnimationSpeed = 200
        Me.Txt_Pcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Txt_Pcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Txt_Pcode.BackColor = System.Drawing.Color.Transparent
        Me.Txt_Pcode.BackgroundImage = CType(resources.GetObject("Txt_Pcode.BackgroundImage"), System.Drawing.Image)
        Me.Txt_Pcode.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.Txt_Pcode.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Txt_Pcode.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Pcode.BorderColorIdle = System.Drawing.Color.Silver
        Me.Txt_Pcode.BorderRadius = 30
        Me.Txt_Pcode.BorderThickness = 1
        Me.Txt_Pcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Txt_Pcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Pcode.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Txt_Pcode.DefaultText = ""
        Me.Txt_Pcode.FillColor = System.Drawing.Color.White
        Me.Txt_Pcode.HideSelection = True
        Me.Txt_Pcode.IconLeft = Nothing
        Me.Txt_Pcode.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Pcode.IconPadding = 10
        Me.Txt_Pcode.IconRight = Nothing
        Me.Txt_Pcode.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Pcode.Lines = New String(-1) {}
        Me.Txt_Pcode.Location = New System.Drawing.Point(148, 212)
        Me.Txt_Pcode.MaxLength = 32767
        Me.Txt_Pcode.MinimumSize = New System.Drawing.Size(1, 1)
        Me.Txt_Pcode.Modified = False
        Me.Txt_Pcode.Multiline = False
        Me.Txt_Pcode.Name = "Txt_Pcode"
        StateProperties9.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties9.FillColor = System.Drawing.Color.Empty
        StateProperties9.ForeColor = System.Drawing.Color.Empty
        StateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_Pcode.OnActiveState = StateProperties9
        StateProperties10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties10.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.Txt_Pcode.OnDisabledState = StateProperties10
        StateProperties11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties11.FillColor = System.Drawing.Color.Empty
        StateProperties11.ForeColor = System.Drawing.Color.Empty
        StateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_Pcode.OnHoverState = StateProperties11
        StateProperties12.BorderColor = System.Drawing.Color.Silver
        StateProperties12.FillColor = System.Drawing.Color.White
        StateProperties12.ForeColor = System.Drawing.Color.Empty
        StateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_Pcode.OnIdleState = StateProperties12
        Me.Txt_Pcode.Padding = New System.Windows.Forms.Padding(3)
        Me.Txt_Pcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Pcode.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.Txt_Pcode.PlaceholderText = ""
        Me.Txt_Pcode.ReadOnly = False
        Me.Txt_Pcode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Txt_Pcode.SelectedText = ""
        Me.Txt_Pcode.SelectionLength = 0
        Me.Txt_Pcode.SelectionStart = 0
        Me.Txt_Pcode.ShortcutsEnabled = True
        Me.Txt_Pcode.Size = New System.Drawing.Size(205, 33)
        Me.Txt_Pcode.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.Txt_Pcode.TabIndex = 80
        Me.Txt_Pcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Txt_Pcode.TextMarginBottom = 0
        Me.Txt_Pcode.TextMarginLeft = 3
        Me.Txt_Pcode.TextMarginTop = 0
        Me.Txt_Pcode.TextPlaceholder = ""
        Me.Txt_Pcode.UseSystemPasswordChar = False
        Me.Txt_Pcode.WordWrap = True
        '
        'Txt_Product
        '
        Me.Txt_Product.AcceptsReturn = False
        Me.Txt_Product.AcceptsTab = False
        Me.Txt_Product.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Product.AnimationSpeed = 200
        Me.Txt_Product.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Txt_Product.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Txt_Product.BackColor = System.Drawing.Color.Transparent
        Me.Txt_Product.BackgroundImage = CType(resources.GetObject("Txt_Product.BackgroundImage"), System.Drawing.Image)
        Me.Txt_Product.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.Txt_Product.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Txt_Product.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Product.BorderColorIdle = System.Drawing.Color.Silver
        Me.Txt_Product.BorderRadius = 30
        Me.Txt_Product.BorderThickness = 1
        Me.Txt_Product.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Txt_Product.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Product.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Txt_Product.DefaultText = ""
        Me.Txt_Product.FillColor = System.Drawing.Color.White
        Me.Txt_Product.HideSelection = True
        Me.Txt_Product.IconLeft = Nothing
        Me.Txt_Product.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Product.IconPadding = 10
        Me.Txt_Product.IconRight = Nothing
        Me.Txt_Product.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Product.Lines = New String(-1) {}
        Me.Txt_Product.Location = New System.Drawing.Point(148, 60)
        Me.Txt_Product.MaxLength = 32767
        Me.Txt_Product.MinimumSize = New System.Drawing.Size(1, 1)
        Me.Txt_Product.Modified = False
        Me.Txt_Product.Multiline = False
        Me.Txt_Product.Name = "Txt_Product"
        StateProperties13.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties13.FillColor = System.Drawing.Color.Empty
        StateProperties13.ForeColor = System.Drawing.Color.Empty
        StateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_Product.OnActiveState = StateProperties13
        StateProperties14.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties14.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.Txt_Product.OnDisabledState = StateProperties14
        StateProperties15.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties15.FillColor = System.Drawing.Color.Empty
        StateProperties15.ForeColor = System.Drawing.Color.Empty
        StateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_Product.OnHoverState = StateProperties15
        StateProperties16.BorderColor = System.Drawing.Color.Silver
        StateProperties16.FillColor = System.Drawing.Color.White
        StateProperties16.ForeColor = System.Drawing.Color.Empty
        StateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Txt_Product.OnIdleState = StateProperties16
        Me.Txt_Product.Padding = New System.Windows.Forms.Padding(3)
        Me.Txt_Product.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Product.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.Txt_Product.PlaceholderText = ""
        Me.Txt_Product.ReadOnly = True
        Me.Txt_Product.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Txt_Product.SelectedText = ""
        Me.Txt_Product.SelectionLength = 0
        Me.Txt_Product.SelectionStart = 0
        Me.Txt_Product.ShortcutsEnabled = True
        Me.Txt_Product.Size = New System.Drawing.Size(205, 33)
        Me.Txt_Product.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.Txt_Product.TabIndex = 77
        Me.Txt_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Txt_Product.TextMarginBottom = 0
        Me.Txt_Product.TextMarginLeft = 3
        Me.Txt_Product.TextMarginTop = 0
        Me.Txt_Product.TextPlaceholder = ""
        Me.Txt_Product.UseSystemPasswordChar = False
        Me.Txt_Product.WordWrap = True
        '
        'Label_Pcode
        '
        Me.Label_Pcode.AutoSize = True
        Me.Label_Pcode.BackColor = System.Drawing.Color.Transparent
        Me.Label_Pcode.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Pcode.ForeColor = System.Drawing.Color.White
        Me.Label_Pcode.Location = New System.Drawing.Point(15, 218)
        Me.Label_Pcode.Name = "Label_Pcode"
        Me.Label_Pcode.Size = New System.Drawing.Size(60, 22)
        Me.Label_Pcode.TabIndex = 8
        Me.Label_Pcode.Text = "Price :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Product :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Stocks :"
        '
        'DealerDataGrid
        '
        Me.DealerDataGrid.AllowCustomTheming = False
        Me.DealerDataGrid.AllowUserToAddRows = False
        Me.DealerDataGrid.AllowUserToDeleteRows = False
        Me.DealerDataGrid.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DealerDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DealerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DealerDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DealerDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DealerDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DealerDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DealerDataGrid.ColumnHeadersHeight = 40
        Me.DealerDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DealerDataGrid.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DealerDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DealerDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DealerDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DealerDataGrid.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.DealerDataGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DealerDataGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.DealerDataGrid.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DealerDataGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DealerDataGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DealerDataGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DealerDataGrid.CurrentTheme.Name = Nothing
        Me.DealerDataGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DealerDataGrid.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DealerDataGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DealerDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DealerDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DealerDataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.DealerDataGrid.EnableHeadersVisualStyles = False
        Me.DealerDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DealerDataGrid.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.DealerDataGrid.HeaderBgColor = System.Drawing.Color.Empty
        Me.DealerDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.DealerDataGrid.Location = New System.Drawing.Point(660, 85)
        Me.DealerDataGrid.MultiSelect = False
        Me.DealerDataGrid.Name = "DealerDataGrid"
        Me.DealerDataGrid.ReadOnly = True
        Me.DealerDataGrid.RowHeadersVisible = False
        Me.DealerDataGrid.RowHeadersWidth = 50
        Me.DealerDataGrid.RowTemplate.Height = 40
        Me.DealerDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DealerDataGrid.Size = New System.Drawing.Size(642, 475)
        Me.DealerDataGrid.TabIndex = 83
        Me.DealerDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Grocery_login_form.My.Resources.Resources.refresh
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1291, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 27)
        Me.Button1.TabIndex = 84
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Baskerville Old Face", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.Label14.Location = New System.Drawing.Point(8, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 31)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "Order"
        '
        'Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Grocery_login_form.My.Resources.Resources.photo_151
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1330, 694)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DealerDataGrid)
        Me.Controls.Add(Me.Txt_Search)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DealerDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Search As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_modify As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Txt_Stocks As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents Txt_Pcode As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents Txt_Product As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents Label_Pcode As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DealerDataGrid As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label14 As Label
End Class
