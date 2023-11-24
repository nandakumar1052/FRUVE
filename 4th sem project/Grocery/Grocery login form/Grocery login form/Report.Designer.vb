<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Btn_Delete = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.com1 = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Txt_Search = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Bottom
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 201)
        Me.Chart1.Name = "Chart1"
        Series1.BorderColor = System.Drawing.Color.White
        Series1.BorderWidth = 5
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.Name = "Income"
        Series2.BorderWidth = 5
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.Red
        Series2.Legend = "Legend1"
        Series2.Name = "Expense"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(1316, 456)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Title1.Name = "Income / Expense Graph"
        Me.Chart1.Titles.Add(Title1)
        '
        'Btn_Delete
        '
        Me.Btn_Delete.AllowAnimations = True
        Me.Btn_Delete.AllowMouseEffects = True
        Me.Btn_Delete.AllowToggling = False
        Me.Btn_Delete.AnimationSpeed = 200
        Me.Btn_Delete.AutoGenerateColors = False
        Me.Btn_Delete.AutoRoundBorders = False
        Me.Btn_Delete.AutoSizeLeftIcon = True
        Me.Btn_Delete.AutoSizeRightIcon = True
        Me.Btn_Delete.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Delete.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Delete.BackgroundImage = CType(resources.GetObject("Btn_Delete.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Delete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_Delete.ButtonText = "Get Report"
        Me.Btn_Delete.ButtonTextMarginLeft = 0
        Me.Btn_Delete.ColorContrastOnClick = 45
        Me.Btn_Delete.ColorContrastOnHover = 45
        Me.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.Btn_Delete.CustomizableEdges = BorderEdges1
        Me.Btn_Delete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Delete.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn_Delete.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Btn_Delete.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Btn_Delete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.Btn_Delete.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Delete.ForeColor = System.Drawing.Color.White
        Me.Btn_Delete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Delete.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Delete.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.Btn_Delete.IconMarginLeft = 11
        Me.Btn_Delete.IconPadding = 10
        Me.Btn_Delete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Delete.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Delete.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.Btn_Delete.IconSize = 25
        Me.Btn_Delete.IdleBorderColor = System.Drawing.Color.Maroon
        Me.Btn_Delete.IdleBorderRadius = 35
        Me.Btn_Delete.IdleBorderThickness = 1
        Me.Btn_Delete.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Delete.IdleIconLeftImage = Nothing
        Me.Btn_Delete.IdleIconRightImage = Nothing
        Me.Btn_Delete.IndicateFocus = False
        Me.Btn_Delete.Location = New System.Drawing.Point(451, 32)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn_Delete.OnDisabledState.BorderRadius = 35
        Me.Btn_Delete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_Delete.OnDisabledState.BorderThickness = 1
        Me.Btn_Delete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Btn_Delete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Btn_Delete.OnDisabledState.IconLeftImage = Nothing
        Me.Btn_Delete.OnDisabledState.IconRightImage = Nothing
        Me.Btn_Delete.onHoverState.BorderColor = System.Drawing.Color.Maroon
        Me.Btn_Delete.onHoverState.BorderRadius = 35
        Me.Btn_Delete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_Delete.onHoverState.BorderThickness = 1
        Me.Btn_Delete.onHoverState.FillColor = System.Drawing.Color.Red
        Me.Btn_Delete.onHoverState.ForeColor = System.Drawing.Color.White
        Me.Btn_Delete.onHoverState.IconLeftImage = Nothing
        Me.Btn_Delete.onHoverState.IconRightImage = Nothing
        Me.Btn_Delete.OnIdleState.BorderColor = System.Drawing.Color.Maroon
        Me.Btn_Delete.OnIdleState.BorderRadius = 35
        Me.Btn_Delete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_Delete.OnIdleState.BorderThickness = 1
        Me.Btn_Delete.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Delete.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.Btn_Delete.OnIdleState.IconLeftImage = Nothing
        Me.Btn_Delete.OnIdleState.IconRightImage = Nothing
        Me.Btn_Delete.OnPressedState.BorderColor = System.Drawing.Color.Red
        Me.Btn_Delete.OnPressedState.BorderRadius = 35
        Me.Btn_Delete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Btn_Delete.OnPressedState.BorderThickness = 1
        Me.Btn_Delete.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Delete.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.Btn_Delete.OnPressedState.IconLeftImage = Nothing
        Me.Btn_Delete.OnPressedState.IconRightImage = Nothing
        Me.Btn_Delete.Size = New System.Drawing.Size(371, 57)
        Me.Btn_Delete.TabIndex = 114
        Me.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_Delete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Btn_Delete.TextMarginLeft = 0
        Me.Btn_Delete.TextPadding = New System.Windows.Forms.Padding(0)
        Me.Btn_Delete.UseDefaultRadiusAndThickness = True
        '
        'com1
        '
        Me.com1.BackColor = System.Drawing.Color.Transparent
        Me.com1.BackgroundColor = System.Drawing.Color.White
        Me.com1.BorderColor = System.Drawing.Color.Silver
        Me.com1.BorderRadius = 14
        Me.com1.Color = System.Drawing.Color.Silver
        Me.com1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.com1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.com1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.com1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.com1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.com1.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.com1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.com1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.com1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.com1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.com1.FillDropDown = True
        Me.com1.FillIndicator = False
        Me.com1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.com1.Font = New System.Drawing.Font("Baskerville Old Face", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.com1.ForeColor = System.Drawing.Color.Black
        Me.com1.FormattingEnabled = True
        Me.com1.Icon = Nothing
        Me.com1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.com1.IndicatorColor = System.Drawing.Color.Gray
        Me.com1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.com1.ItemBackColor = System.Drawing.Color.White
        Me.com1.ItemBorderColor = System.Drawing.Color.White
        Me.com1.ItemForeColor = System.Drawing.Color.Black
        Me.com1.ItemHeight = 24
        Me.com1.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.com1.ItemHighLightForeColor = System.Drawing.Color.White
        Me.com1.Items.AddRange(New Object() {"Line Graph", "Bar Graph", "Pie Graph"})
        Me.com1.ItemTopMargin = 3
        Me.com1.Location = New System.Drawing.Point(192, 125)
        Me.com1.Name = "com1"
        Me.com1.Size = New System.Drawing.Size(205, 30)
        Me.com1.TabIndex = 115
        Me.com1.Text = Nothing
        Me.com1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.com1.TextLeftMargin = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(44, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 22)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Graph Type :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Baskerville Old Face", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.Label14.Location = New System.Drawing.Point(12, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 31)
        Me.Label14.TabIndex = 117
        Me.Label14.Text = "Report"
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
        Me.Txt_Search.Location = New System.Drawing.Point(1039, 115)
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
        Me.Txt_Search.Size = New System.Drawing.Size(200, 32)
        Me.Txt_Search.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.Txt_Search.TabIndex = 119
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
        Me.Label15.Location = New System.Drawing.Point(878, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(144, 22)
        Me.Label15.TabIndex = 118
        Me.Label15.Text = "Rows to Display :"
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1316, 657)
        Me.ControlBox = False
        Me.Controls.Add(Me.Txt_Search)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.com1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Chart1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Btn_Delete As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents com1 As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Txt_Search As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents Label15 As Label
End Class
