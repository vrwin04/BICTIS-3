<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminDashboard
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        pnlBorder = New Panel()
        pnlMainContent = New Panel()
        pnlHome = New Panel()
        pnlChartSection = New Panel()
        chartIncidents = New System.Windows.Forms.DataVisualization.Charting.Chart()
        pnlFilterBar = New Panel()
        cbIncidentType = New ComboBox()
        Label2 = New Label()
        lblChartTitle = New Label()
        pnlStatsRow = New FlowLayoutPanel()
        pnlCard1 = New Panel()
        lblTotalUsers = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        pnlCard2 = New Panel()
        lblPendingCases = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        pnlCard3 = New Panel()
        lblTotalBlotter = New Label()
        Label4 = New Label()
        Panel3 = New Panel()
        pnlCard4 = New Panel()
        lblTotalConcerns = New Label()
        Label5 = New Label()
        Panel4 = New Panel()
        pnlHeader = New Panel()
        lblPageTitle = New Label()
        pnlSidebar = New Panel()
        btnLogout = New Button()
        btnClearance = New Button()
        btnConcerns = New Button()
        btnBlotter = New Button()
        btnResidents = New Button()
        pnlLogo = New Panel()
        lblLogo = New Label()
        pnlBorder.SuspendLayout()
        pnlMainContent.SuspendLayout()
        pnlHome.SuspendLayout()
        pnlChartSection.SuspendLayout()
        CType(chartIncidents, ComponentModel.ISupportInitialize).BeginInit()
        pnlFilterBar.SuspendLayout()
        pnlStatsRow.SuspendLayout()
        pnlCard1.SuspendLayout()
        pnlCard2.SuspendLayout()
        pnlCard3.SuspendLayout()
        pnlCard4.SuspendLayout()
        pnlHeader.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlLogo.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBorder
        ' 
        pnlBorder.BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        pnlBorder.Controls.Add(pnlMainContent)
        pnlBorder.Controls.Add(pnlHeader)
        pnlBorder.Controls.Add(pnlSidebar)
        pnlBorder.Dock = DockStyle.Fill
        pnlBorder.Location = New Point(3, 3)
        pnlBorder.Margin = New Padding(4, 5, 4, 5)
        pnlBorder.Name = "pnlBorder"
        pnlBorder.Size = New Size(1274, 714)
        pnlBorder.TabIndex = 0
        ' 
        ' pnlMainContent
        ' 
        pnlMainContent.Controls.Add(pnlHome)
        pnlMainContent.Dock = DockStyle.Fill
        pnlMainContent.Location = New Point(347, 123)
        pnlMainContent.Margin = New Padding(4, 5, 4, 5)
        pnlMainContent.Name = "pnlMainContent"
        pnlMainContent.Size = New Size(927, 591)
        pnlMainContent.TabIndex = 2
        ' 
        ' pnlHome
        ' 
        pnlHome.AutoScroll = True
        pnlHome.Controls.Add(pnlChartSection)
        pnlHome.Controls.Add(pnlStatsRow)
        pnlHome.Dock = DockStyle.Fill
        pnlHome.Location = New Point(0, 0)
        pnlHome.Name = "pnlHome"
        pnlHome.Padding = New Padding(40, 46, 40, 46)
        pnlHome.Size = New Size(927, 591)
        pnlHome.TabIndex = 0
        ' 
        ' pnlChartSection
        ' 
        pnlChartSection.BackColor = Color.White
        pnlChartSection.Controls.Add(chartIncidents)
        pnlChartSection.Controls.Add(pnlFilterBar)
        pnlChartSection.Dock = DockStyle.Top
        pnlChartSection.Location = New Point(40, 297)
        pnlChartSection.Margin = New Padding(4, 5, 4, 5)
        pnlChartSection.Name = "pnlChartSection"
        pnlChartSection.Padding = New Padding(27, 31, 27, 31)
        pnlChartSection.Size = New Size(847, 514)
        pnlChartSection.TabIndex = 1
        ' 
        ' chartIncidents
        ' 
        ChartArea1.Name = "ChartArea1"
        chartIncidents.ChartAreas.Add(ChartArea1)
        chartIncidents.Dock = DockStyle.Fill
        Legend1.Name = "Legend1"
        chartIncidents.Legends.Add(Legend1)
        chartIncidents.Location = New Point(27, 123)
        chartIncidents.Name = "chartIncidents"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        chartIncidents.Series.Add(Series1)
        chartIncidents.Size = New Size(793, 360)
        chartIncidents.TabIndex = 1
        chartIncidents.Text = "Incidents Chart"
        ' 
        ' pnlFilterBar
        ' 
        pnlFilterBar.Controls.Add(cbIncidentType)
        pnlFilterBar.Controls.Add(Label2)
        pnlFilterBar.Controls.Add(lblChartTitle)
        pnlFilterBar.Dock = DockStyle.Top
        pnlFilterBar.Location = New Point(27, 31)
        pnlFilterBar.Margin = New Padding(4, 5, 4, 5)
        pnlFilterBar.Name = "pnlFilterBar"
        pnlFilterBar.Size = New Size(793, 92)
        pnlFilterBar.TabIndex = 0
        ' 
        ' cbIncidentType
        ' 
        cbIncidentType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cbIncidentType.BackColor = Color.WhiteSmoke
        cbIncidentType.DropDownStyle = ComboBoxStyle.DropDownList
        cbIncidentType.FlatStyle = FlatStyle.Flat
        cbIncidentType.Font = New Font("Segoe UI", 11.0F)
        cbIncidentType.FormattingEnabled = True
        cbIncidentType.Location = New Point(473, 23)
        cbIncidentType.Margin = New Padding(4, 5, 4, 5)
        cbIncidentType.Name = "cbIncidentType"
        cbIncidentType.Size = New Size(292, 33)
        cbIncidentType.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(340, 29)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 23)
        Label2.TabIndex = 1
        Label2.Text = "Filter Graph:"
        ' 
        ' lblChartTitle
        ' 
        lblChartTitle.AutoSize = True
        lblChartTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblChartTitle.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblChartTitle.Location = New Point(13, 23)
        lblChartTitle.Margin = New Padding(4, 0, 4, 0)
        lblChartTitle.Name = "lblChartTitle"
        lblChartTitle.Size = New Size(219, 32)
        lblChartTitle.TabIndex = 0
        lblChartTitle.Text = "Incident Analytics"
        ' 
        ' pnlStatsRow
        ' 
        pnlStatsRow.AutoSize = True
        pnlStatsRow.Controls.Add(pnlCard1)
        pnlStatsRow.Controls.Add(pnlCard2)
        pnlStatsRow.Controls.Add(pnlCard3)
        pnlStatsRow.Controls.Add(pnlCard4)
        pnlStatsRow.Dock = DockStyle.Top
        pnlStatsRow.Location = New Point(40, 46)
        pnlStatsRow.Margin = New Padding(4, 5, 4, 5)
        pnlStatsRow.Name = "pnlStatsRow"
        pnlStatsRow.Size = New Size(847, 251)
        pnlStatsRow.TabIndex = 0
        ' 
        ' pnlCard1
        ' 
        pnlCard1.BackColor = Color.White
        pnlCard1.Controls.Add(lblTotalUsers)
        pnlCard1.Controls.Add(Label1)
        pnlCard1.Controls.Add(Panel1)
        pnlCard1.Location = New Point(4, 5)
        pnlCard1.Margin = New Padding(4, 5, 27, 31)
        pnlCard1.Name = "pnlCard1"
        pnlCard1.Size = New Size(280, 215)
        pnlCard1.TabIndex = 0
        ' 
        ' lblTotalUsers
        ' 
        lblTotalUsers.AutoSize = True
        lblTotalUsers.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold)
        lblTotalUsers.ForeColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        lblTotalUsers.Location = New Point(27, 62)
        lblTotalUsers.Margin = New Padding(4, 0, 4, 0)
        lblTotalUsers.Name = "lblTotalUsers"
        lblTotalUsers.Size = New Size(70, 81)
        lblTotalUsers.TabIndex = 1
        lblTotalUsers.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(27, 23)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 23)
        Label1.TabIndex = 0
        Label1.Text = "TOTAL RESIDENTS"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(11, 215)
        Panel1.TabIndex = 2
        ' 
        ' pnlCard2
        ' 
        pnlCard2.BackColor = Color.White
        pnlCard2.Controls.Add(lblPendingCases)
        pnlCard2.Controls.Add(Label3)
        pnlCard2.Controls.Add(Panel2)
        pnlCard2.Location = New Point(315, 5)
        pnlCard2.Margin = New Padding(4, 5, 27, 31)
        pnlCard2.Name = "pnlCard2"
        pnlCard2.Size = New Size(280, 215)
        pnlCard2.TabIndex = 1
        ' 
        ' lblPendingCases
        ' 
        lblPendingCases.AutoSize = True
        lblPendingCases.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold)
        lblPendingCases.ForeColor = Color.Crimson
        lblPendingCases.Location = New Point(27, 62)
        lblPendingCases.Margin = New Padding(4, 0, 4, 0)
        lblPendingCases.Name = "lblPendingCases"
        lblPendingCases.Size = New Size(70, 81)
        lblPendingCases.TabIndex = 1
        lblPendingCases.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(27, 23)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 23)
        Label3.TabIndex = 0
        Label3.Text = "PENDING CASES"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Crimson
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(11, 215)
        Panel2.TabIndex = 2
        ' 
        ' pnlCard3
        ' 
        pnlCard3.BackColor = Color.White
        pnlCard3.Controls.Add(lblTotalBlotter)
        pnlCard3.Controls.Add(Label4)
        pnlCard3.Controls.Add(Panel3)
        pnlCard3.Location = New Point(626, 5)
        pnlCard3.Margin = New Padding(4, 5, 27, 31)
        pnlCard3.Name = "pnlCard3"
        pnlCard3.Size = New Size(280, 215)
        pnlCard3.TabIndex = 2
        ' 
        ' lblTotalBlotter
        ' 
        lblTotalBlotter.AutoSize = True
        lblTotalBlotter.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold)
        lblTotalBlotter.ForeColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        lblTotalBlotter.Location = New Point(27, 62)
        lblTotalBlotter.Margin = New Padding(4, 0, 4, 0)
        lblTotalBlotter.Name = "lblTotalBlotter"
        lblTotalBlotter.Size = New Size(70, 81)
        lblTotalBlotter.TabIndex = 1
        lblTotalBlotter.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label4.ForeColor = Color.Gray
        Label4.Location = New Point(27, 23)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(195, 23)
        Label4.TabIndex = 0
        Label4.Text = "TOTAL BLOTTER CASES"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Margin = New Padding(4, 5, 4, 5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(11, 215)
        Panel3.TabIndex = 2
        ' 
        ' pnlCard4
        ' 
        pnlCard4.BackColor = Color.White
        pnlCard4.Controls.Add(lblTotalConcerns)
        pnlCard4.Controls.Add(Label5)
        pnlCard4.Controls.Add(Panel4)
        pnlCard4.Location = New Point(937, 5)
        pnlCard4.Margin = New Padding(4, 5, 27, 31)
        pnlCard4.Name = "pnlCard4"
        pnlCard4.Size = New Size(280, 215)
        pnlCard4.TabIndex = 3
        ' 
        ' lblTotalConcerns
        ' 
        lblTotalConcerns.AutoSize = True
        lblTotalConcerns.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold)
        lblTotalConcerns.ForeColor = Color.FromArgb(CByte(230), CByte(126), CByte(34))
        lblTotalConcerns.Location = New Point(27, 62)
        lblTotalConcerns.Margin = New Padding(4, 0, 4, 0)
        lblTotalConcerns.Name = "lblTotalConcerns"
        lblTotalConcerns.Size = New Size(70, 81)
        lblTotalConcerns.TabIndex = 1
        lblTotalConcerns.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label5.ForeColor = Color.Gray
        Label5.Location = New Point(27, 23)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(157, 23)
        Label5.TabIndex = 0
        Label5.Text = "TOTAL CONCERNS"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(34))
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 0)
        Panel4.Margin = New Padding(4, 5, 4, 5)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(11, 215)
        Panel4.TabIndex = 2
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(347, 0)
        pnlHeader.Margin = New Padding(4, 5, 4, 5)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(927, 123)
        pnlHeader.TabIndex = 1
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.AutoSize = True
        lblPageTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblPageTitle.Location = New Point(40, 34)
        lblPageTitle.Margin = New Padding(4, 0, 4, 0)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(309, 46)
        lblPageTitle.TabIndex = 0
        lblPageTitle.Text = "Admin Dashboard"
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnClearance)
        pnlSidebar.Controls.Add(btnConcerns)
        pnlSidebar.Controls.Add(btnBlotter)
        pnlSidebar.Controls.Add(btnResidents)
        pnlSidebar.Controls.Add(pnlLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Margin = New Padding(4, 5, 4, 5)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(347, 714)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(192), CByte(57), CByte(43))
        btnLogout.Cursor = Cursors.Hand
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(0, 606)
        btnLogout.Margin = New Padding(4, 5, 4, 5)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(347, 108)
        btnLogout.TabIndex = 5
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnClearance
        ' 
        btnClearance.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnClearance.Cursor = Cursors.Hand
        btnClearance.Dock = DockStyle.Top
        btnClearance.FlatAppearance.BorderSize = 0
        btnClearance.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        btnClearance.FlatStyle = FlatStyle.Flat
        btnClearance.Font = New Font("Segoe UI", 11.0F)
        btnClearance.ForeColor = Color.WhiteSmoke
        btnClearance.Location = New Point(0, 447)
        btnClearance.Margin = New Padding(4, 5, 4, 5)
        btnClearance.Name = "btnClearance"
        btnClearance.Padding = New Padding(40, 0, 0, 0)
        btnClearance.Size = New Size(347, 108)
        btnClearance.TabIndex = 3
        btnClearance.Text = "Manage Clearances"
        btnClearance.TextAlign = ContentAlignment.MiddleLeft
        btnClearance.UseVisualStyleBackColor = False
        ' 
        ' btnConcerns
        ' 
        btnConcerns.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnConcerns.Cursor = Cursors.Hand
        btnConcerns.Dock = DockStyle.Top
        btnConcerns.FlatAppearance.BorderSize = 0
        btnConcerns.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        btnConcerns.FlatStyle = FlatStyle.Flat
        btnConcerns.Font = New Font("Segoe UI", 11.0F)
        btnConcerns.ForeColor = Color.WhiteSmoke
        btnConcerns.Location = New Point(0, 339)
        btnConcerns.Margin = New Padding(4, 5, 4, 5)
        btnConcerns.Name = "btnConcerns"
        btnConcerns.Padding = New Padding(40, 0, 0, 0)
        btnConcerns.Size = New Size(347, 108)
        btnConcerns.TabIndex = 4
        btnConcerns.Text = "Barangay Concerns"
        btnConcerns.TextAlign = ContentAlignment.MiddleLeft
        btnConcerns.UseVisualStyleBackColor = False
        ' 
        ' btnBlotter
        ' 
        btnBlotter.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnBlotter.Cursor = Cursors.Hand
        btnBlotter.Dock = DockStyle.Top
        btnBlotter.FlatAppearance.BorderSize = 0
        btnBlotter.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        btnBlotter.FlatStyle = FlatStyle.Flat
        btnBlotter.Font = New Font("Segoe UI", 11.0F)
        btnBlotter.ForeColor = Color.WhiteSmoke
        btnBlotter.Location = New Point(0, 231)
        btnBlotter.Margin = New Padding(4, 5, 4, 5)
        btnBlotter.Name = "btnBlotter"
        btnBlotter.Padding = New Padding(40, 0, 0, 0)
        btnBlotter.Size = New Size(347, 108)
        btnBlotter.TabIndex = 2
        btnBlotter.Text = "Incident Blotter"
        btnBlotter.TextAlign = ContentAlignment.MiddleLeft
        btnBlotter.UseVisualStyleBackColor = False
        ' 
        ' btnResidents
        ' 
        btnResidents.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnResidents.Cursor = Cursors.Hand
        btnResidents.Dock = DockStyle.Top
        btnResidents.FlatAppearance.BorderSize = 0
        btnResidents.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        btnResidents.FlatStyle = FlatStyle.Flat
        btnResidents.Font = New Font("Segoe UI", 11.0F)
        btnResidents.ForeColor = Color.WhiteSmoke
        btnResidents.Location = New Point(0, 123)
        btnResidents.Margin = New Padding(4, 5, 4, 5)
        btnResidents.Name = "btnResidents"
        btnResidents.Padding = New Padding(40, 0, 0, 0)
        btnResidents.Size = New Size(347, 108)
        btnResidents.TabIndex = 1
        btnResidents.Text = "Manage Residents"
        btnResidents.TextAlign = ContentAlignment.MiddleLeft
        btnResidents.UseVisualStyleBackColor = False
        ' 
        ' pnlLogo
        ' 
        pnlLogo.BackColor = Color.FromArgb(CByte(34), CByte(49), CByte(63))
        pnlLogo.Controls.Add(lblLogo)
        pnlLogo.Cursor = Cursors.Hand
        pnlLogo.Dock = DockStyle.Top
        pnlLogo.Location = New Point(0, 0)
        pnlLogo.Margin = New Padding(4, 5, 4, 5)
        pnlLogo.Name = "pnlLogo"
        pnlLogo.Size = New Size(347, 123)
        pnlLogo.TabIndex = 0
        ' 
        ' lblLogo
        ' 
        lblLogo.AutoSize = True
        lblLogo.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        lblLogo.ForeColor = Color.White
        lblLogo.Location = New Point(80, 28)
        lblLogo.Margin = New Padding(4, 0, 4, 0)
        lblLogo.Name = "lblLogo"
        lblLogo.Size = New Size(164, 54)
        lblLogo.TabIndex = 0
        lblLogo.Text = "ADMIN"
        ' 
        ' adminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(1280, 720)
        Controls.Add(pnlBorder)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "adminDashboard"
        Padding = New Padding(3)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Dashboard"
        pnlBorder.ResumeLayout(False)
        pnlMainContent.ResumeLayout(False)
        pnlHome.ResumeLayout(False)
        pnlHome.PerformLayout()
        pnlChartSection.ResumeLayout(False)
        CType(chartIncidents, ComponentModel.ISupportInitialize).EndInit()
        pnlFilterBar.ResumeLayout(False)
        pnlFilterBar.PerformLayout()
        pnlStatsRow.ResumeLayout(False)
        pnlCard1.ResumeLayout(False)
        pnlCard1.PerformLayout()
        pnlCard2.ResumeLayout(False)
        pnlCard2.PerformLayout()
        pnlCard3.ResumeLayout(False)
        pnlCard3.PerformLayout()
        pnlCard4.ResumeLayout(False)
        pnlCard4.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlLogo.ResumeLayout(False)
        pnlLogo.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBorder As Panel
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents lblLogo As Label
    Friend WithEvents btnBlotter As Button
    Friend WithEvents btnConcerns As Button
    Friend WithEvents btnResidents As Button
    Friend WithEvents btnClearance As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents pnlHome As Panel
    Friend WithEvents pnlStatsRow As FlowLayoutPanel
    Friend WithEvents pnlCard1 As Panel
    Friend WithEvents lblTotalUsers As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlCard2 As Panel
    Friend WithEvents lblPendingCases As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlCard3 As Panel
    Friend WithEvents lblTotalBlotter As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlCard4 As Panel
    Friend WithEvents lblTotalConcerns As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnlChartSection As Panel
    Friend WithEvents pnlFilterBar As Panel
    Friend WithEvents cbIncidentType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblChartTitle As Label
    Friend WithEvents chartIncidents As System.Windows.Forms.DataVisualization.Charting.Chart
End Class