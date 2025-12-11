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
        Me.pnlBorder = New System.Windows.Forms.Panel()
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.pnlChartSection = New System.Windows.Forms.Panel()
        Me.chartIncidents = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlFilterBar = New System.Windows.Forms.Panel()
        Me.cbIncidentType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblChartTitle = New System.Windows.Forms.Label()
        Me.pnlStatsRow = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlCard1 = New System.Windows.Forms.Panel()
        Me.lblTotalUsers = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlCard2 = New System.Windows.Forms.Panel()
        Me.lblPendingCases = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlCard3 = New System.Windows.Forms.Panel()
        Me.lblTotalBlotter = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlCard4 = New System.Windows.Forms.Panel()
        Me.lblTotalConcerns = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnClearance = New System.Windows.Forms.Button()
        Me.btnConcerns = New System.Windows.Forms.Button()
        Me.btnBlotter = New System.Windows.Forms.Button()
        Me.btnResidents = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.pnlBorder.SuspendLayout()
        Me.pnlMainContent.SuspendLayout()
        Me.pnlHome.SuspendLayout()
        Me.pnlChartSection.SuspendLayout()
        CType(Me.chartIncidents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilterBar.SuspendLayout()
        Me.pnlStatsRow.SuspendLayout()
        Me.pnlCard1.SuspendLayout()
        Me.pnlCard2.SuspendLayout()
        Me.pnlCard3.SuspendLayout()
        Me.pnlCard4.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBorder
        '
        Me.pnlBorder.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlBorder.Controls.Add(Me.pnlMainContent)
        Me.pnlBorder.Controls.Add(Me.pnlHeader)
        Me.pnlBorder.Controls.Add(Me.pnlSidebar)
        Me.pnlBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBorder.Location = New System.Drawing.Point(0, 0)
        Me.pnlBorder.Name = "pnlBorder"
        Me.pnlBorder.Size = New System.Drawing.Size(1366, 768)
        Me.pnlBorder.TabIndex = 0
        '
        'pnlMainContent
        '
        Me.pnlMainContent.Controls.Add(Me.pnlHome)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(347, 123)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(1019, 645)
        Me.pnlMainContent.TabIndex = 2
        '
        'pnlHome
        '
        Me.pnlHome.AutoScroll = True
        Me.pnlHome.Controls.Add(Me.pnlChartSection)
        Me.pnlHome.Controls.Add(Me.pnlStatsRow)
        Me.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlHome.Size = New System.Drawing.Size(1019, 645)
        Me.pnlHome.TabIndex = 0
        '
        'pnlChartSection
        '
        Me.pnlChartSection.BackColor = System.Drawing.Color.White
        Me.pnlChartSection.Controls.Add(Me.chartIncidents)
        Me.pnlChartSection.Controls.Add(Me.pnlFilterBar)
        Me.pnlChartSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChartSection.Location = New System.Drawing.Point(30, 281)
        Me.pnlChartSection.Name = "pnlChartSection"
        Me.pnlChartSection.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlChartSection.Size = New System.Drawing.Size(959, 334)
        Me.pnlChartSection.TabIndex = 1
        '
        'chartIncidents
        '
        Me.chartIncidents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartIncidents.Location = New System.Drawing.Point(20, 100)
        Me.chartIncidents.Name = "chartIncidents"
        Me.chartIncidents.Size = New System.Drawing.Size(919, 214)
        Me.chartIncidents.TabIndex = 1
        Me.chartIncidents.Text = "Incidents Chart"
        '
        'pnlFilterBar
        '
        Me.pnlFilterBar.Controls.Add(Me.cbIncidentType)
        Me.pnlFilterBar.Controls.Add(Me.Label2)
        Me.pnlFilterBar.Controls.Add(Me.lblChartTitle)
        Me.pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilterBar.Location = New System.Drawing.Point(20, 20)
        Me.pnlFilterBar.Name = "pnlFilterBar"
        Me.pnlFilterBar.Size = New System.Drawing.Size(919, 80)
        Me.pnlFilterBar.TabIndex = 0
        '
        'cbIncidentType
        '
        Me.cbIncidentType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbIncidentType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbIncidentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIncidentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbIncidentType.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbIncidentType.FormattingEnabled = True
        Me.cbIncidentType.Location = New System.Drawing.Point(599, 23)
        Me.cbIncidentType.Name = "cbIncidentType"
        Me.cbIncidentType.Size = New System.Drawing.Size(300, 29)
        Me.cbIncidentType.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(476, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Filter Graph:"
        '
        'lblChartTitle
        '
        Me.lblChartTitle.AutoSize = True
        Me.lblChartTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80)
        Me.lblChartTitle.Location = New System.Drawing.Point(13, 23)
        Me.lblChartTitle.Name = "lblChartTitle"
        Me.lblChartTitle.Size = New System.Drawing.Size(201, 30)
        Me.lblChartTitle.TabIndex = 0
        Me.lblChartTitle.Text = "Incident Analytics"
        '
        'pnlStatsRow
        '
        Me.pnlStatsRow.AutoSize = True
        Me.pnlStatsRow.Controls.Add(Me.pnlCard1)
        Me.pnlStatsRow.Controls.Add(Me.pnlCard2)
        Me.pnlStatsRow.Controls.Add(Me.pnlCard3)
        Me.pnlStatsRow.Controls.Add(Me.pnlCard4)
        Me.pnlStatsRow.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStatsRow.Location = New System.Drawing.Point(30, 30)
        Me.pnlStatsRow.Name = "pnlStatsRow"
        Me.pnlStatsRow.Size = New System.Drawing.Size(959, 251)
        Me.pnlStatsRow.TabIndex = 0
        '
        'pnlCard1
        '
        Me.pnlCard1.BackColor = System.Drawing.Color.White
        Me.pnlCard1.Controls.Add(Me.lblTotalUsers)
        Me.pnlCard1.Controls.Add(Me.Label1)
        Me.pnlCard1.Controls.Add(Me.Panel1)
        Me.pnlCard1.Location = New System.Drawing.Point(4, 5)
        Me.pnlCard1.Margin = New System.Windows.Forms.Padding(4, 5, 27, 31)
        Me.pnlCard1.Name = "pnlCard1"
        Me.pnlCard1.Size = New System.Drawing.Size(280, 215)
        Me.pnlCard1.TabIndex = 0
        '
        'lblTotalUsers
        '
        Me.lblTotalUsers.AutoSize = True
        Me.lblTotalUsers.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalUsers.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.lblTotalUsers.Location = New System.Drawing.Point(27, 62)
        Me.lblTotalUsers.Name = "lblTotalUsers"
        Me.lblTotalUsers.Size = New System.Drawing.Size(56, 65)
        Me.lblTotalUsers.TabIndex = 1
        Me.lblTotalUsers.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL RESIDENTS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(11, 215)
        Me.Panel1.TabIndex = 2
        '
        'pnlCard2
        '
        Me.pnlCard2.BackColor = System.Drawing.Color.White
        Me.pnlCard2.Controls.Add(Me.lblPendingCases)
        Me.pnlCard2.Controls.Add(Me.Label3)
        Me.pnlCard2.Controls.Add(Me.Panel2)
        Me.pnlCard2.Location = New System.Drawing.Point(315, 5)
        Me.pnlCard2.Margin = New System.Windows.Forms.Padding(4, 5, 27, 31)
        Me.pnlCard2.Name = "pnlCard2"
        Me.pnlCard2.Size = New System.Drawing.Size(280, 215)
        Me.pnlCard2.TabIndex = 1
        '
        'lblPendingCases
        '
        Me.lblPendingCases.AutoSize = True
        Me.lblPendingCases.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblPendingCases.ForeColor = System.Drawing.Color.Crimson
        Me.lblPendingCases.Location = New System.Drawing.Point(27, 62)
        Me.lblPendingCases.Name = "lblPendingCases"
        Me.lblPendingCases.Size = New System.Drawing.Size(56, 65)
        Me.lblPendingCases.TabIndex = 1
        Me.lblPendingCases.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(27, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "PENDING CASES"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Crimson
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(11, 215)
        Me.Panel2.TabIndex = 2
        '
        'pnlCard3
        '
        Me.pnlCard3.BackColor = System.Drawing.Color.White
        Me.pnlCard3.Controls.Add(Me.lblTotalBlotter)
        Me.pnlCard3.Controls.Add(Me.Label4)
        Me.pnlCard3.Controls.Add(Me.Panel3)
        Me.pnlCard3.Location = New System.Drawing.Point(626, 5)
        Me.pnlCard3.Margin = New System.Windows.Forms.Padding(4, 5, 27, 31)
        Me.pnlCard3.Name = "pnlCard3"
        Me.pnlCard3.Size = New System.Drawing.Size(280, 215)
        Me.pnlCard3.TabIndex = 2
        '
        'lblTotalBlotter
        '
        Me.lblTotalBlotter.AutoSize = True
        Me.lblTotalBlotter.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalBlotter.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.lblTotalBlotter.Location = New System.Drawing.Point(27, 62)
        Me.lblTotalBlotter.Name = "lblTotalBlotter"
        Me.lblTotalBlotter.Size = New System.Drawing.Size(56, 65)
        Me.lblTotalBlotter.TabIndex = 1
        Me.lblTotalBlotter.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(27, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "TOTAL BLOTTER CASES"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(11, 215)
        Me.Panel3.TabIndex = 2
        '
        'pnlCard4
        '
        Me.pnlCard4.BackColor = System.Drawing.Color.White
        Me.pnlCard4.Controls.Add(Me.lblTotalConcerns)
        Me.pnlCard4.Controls.Add(Me.Label5)
        Me.pnlCard4.Controls.Add(Me.Panel4)
        Me.pnlCard4.Location = New System.Drawing.Point(937, 5)
        Me.pnlCard4.Margin = New System.Windows.Forms.Padding(4, 5, 27, 31)
        Me.pnlCard4.Name = "pnlCard4"
        Me.pnlCard4.Size = New System.Drawing.Size(280, 215)
        Me.pnlCard4.TabIndex = 3
        '
        'lblTotalConcerns
        '
        Me.lblTotalConcerns.AutoSize = True
        Me.lblTotalConcerns.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalConcerns.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34)
        Me.lblTotalConcerns.Location = New System.Drawing.Point(27, 62)
        Me.lblTotalConcerns.Name = "lblTotalConcerns"
        Me.lblTotalConcerns.Size = New System.Drawing.Size(56, 65)
        Me.lblTotalConcerns.TabIndex = 1
        Me.lblTotalConcerns.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(27, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "TOTAL CONCERNS"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(230, 126, 34)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(11, 215)
        Me.Panel4.TabIndex = 2
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblPageTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(347, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1019, 123)
        Me.pnlHeader.TabIndex = 1
        '
        'lblPageTitle
        '
        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80)
        Me.lblPageTitle.Location = New System.Drawing.Point(40, 34)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(298, 45)
        Me.lblPageTitle.TabIndex = 0
        Me.lblPageTitle.Text = "Admin Dashboard"
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(44, 62, 80)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnClearance)
        Me.pnlSidebar.Controls.Add(Me.btnConcerns)
        Me.pnlSidebar.Controls.Add(Me.btnBlotter)
        Me.pnlSidebar.Controls.Add(Me.btnResidents)
        Me.pnlSidebar.Controls.Add(Me.btnHome)
        Me.pnlSidebar.Controls.Add(Me.pnlLogo)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(347, 768)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(192, 57, 43)
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 660)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(347, 108)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnClearance
        '
        Me.btnClearance.BackColor = System.Drawing.Color.FromArgb(44, 62, 80)
        Me.btnClearance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClearance.FlatAppearance.BorderSize = 0
        Me.btnClearance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 73, 94)
        Me.btnClearance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnClearance.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClearance.Location = New System.Drawing.Point(0, 483)
        Me.btnClearance.Name = "btnClearance"
        Me.btnClearance.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnClearance.Size = New System.Drawing.Size(347, 90)
        Me.btnClearance.TabIndex = 3
        Me.btnClearance.Text = "Manage Clearances"
        Me.btnClearance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClearance.UseVisualStyleBackColor = False
        '
        'btnConcerns
        '
        Me.btnConcerns.BackColor = System.Drawing.Color.FromArgb(44, 62, 80)
        Me.btnConcerns.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConcerns.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConcerns.FlatAppearance.BorderSize = 0
        Me.btnConcerns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 73, 94)
        Me.btnConcerns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConcerns.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnConcerns.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnConcerns.Location = New System.Drawing.Point(0, 393)
        Me.btnConcerns.Name = "btnConcerns"
        Me.btnConcerns.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnConcerns.Size = New System.Drawing.Size(347, 90)
        Me.btnConcerns.TabIndex = 4
        Me.btnConcerns.Text = "Barangay Concerns"
        Me.btnConcerns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConcerns.UseVisualStyleBackColor = False
        '
        'btnBlotter
        '
        Me.btnBlotter.BackColor = System.Drawing.Color.FromArgb(44, 62, 80)
        Me.btnBlotter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBlotter.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBlotter.FlatAppearance.BorderSize = 0
        Me.btnBlotter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 73, 94)
        Me.btnBlotter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlotter.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBlotter.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBlotter.Location = New System.Drawing.Point(0, 303)
        Me.btnBlotter.Name = "btnBlotter"
        Me.btnBlotter.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnBlotter.Size = New System.Drawing.Size(347, 90)
        Me.btnBlotter.TabIndex = 2
        Me.btnBlotter.Text = "Incident Blotter"
        Me.btnBlotter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBlotter.UseVisualStyleBackColor = False
        '
        'btnResidents
        '
        Me.btnResidents.BackColor = System.Drawing.Color.FromArgb(44, 62, 80)
        Me.btnResidents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResidents.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnResidents.FlatAppearance.BorderSize = 0
        Me.btnResidents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 73, 94)
        Me.btnResidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResidents.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnResidents.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnResidents.Location = New System.Drawing.Point(0, 213)
        Me.btnResidents.Name = "btnResidents"
        Me.btnResidents.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnResidents.Size = New System.Drawing.Size(347, 90)
        Me.btnResidents.TabIndex = 1
        Me.btnResidents.Text = "Manage Residents"
        Me.btnResidents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResidents.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(44, 62, 80)
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 73, 94)
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnHome.Location = New System.Drawing.Point(0, 123)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnHome.Size = New System.Drawing.Size(347, 90)
        Me.btnHome.TabIndex = 6
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'pnlLogo
        '
        Me.pnlLogo.BackColor = System.Drawing.Color.FromArgb(34, 49, 63)
        Me.pnlLogo.Controls.Add(Me.lblLogo)
        Me.pnlLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(347, 123)
        Me.pnlLogo.TabIndex = 0
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogo.ForeColor = System.Drawing.Color.White
        Me.lblLogo.Location = New System.Drawing.Point(80, 28)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(155, 51)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "ADMIN"
        '
        'adminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.pnlBorder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminDashboard"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Dashboard"
        Me.pnlBorder.ResumeLayout(False)
        Me.pnlMainContent.ResumeLayout(False)
        Me.pnlHome.ResumeLayout(False)
        Me.pnlChartSection.ResumeLayout(False)
        CType(Me.chartIncidents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilterBar.ResumeLayout(False)
        Me.pnlFilterBar.PerformLayout()
        Me.pnlStatsRow.ResumeLayout(False)
        Me.pnlCard1.ResumeLayout(False)
        Me.pnlCard1.PerformLayout()
        Me.pnlCard2.ResumeLayout(False)
        Me.pnlCard2.PerformLayout()
        Me.pnlCard3.ResumeLayout(False)
        Me.pnlCard3.PerformLayout()
        Me.pnlCard4.ResumeLayout(False)
        Me.pnlCard4.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        Me.pnlLogo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBorder As System.Windows.Forms.Panel
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlLogo As System.Windows.Forms.Panel
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents btnBlotter As System.Windows.Forms.Button
    Friend WithEvents btnConcerns As System.Windows.Forms.Button
    Friend WithEvents btnResidents As System.Windows.Forms.Button
    Friend WithEvents btnClearance As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Friend WithEvents pnlMainContent As System.Windows.Forms.Panel
    Friend WithEvents pnlHome As System.Windows.Forms.Panel
    Friend WithEvents pnlStatsRow As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlCard1 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalUsers As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlCard2 As System.Windows.Forms.Panel
    Friend WithEvents lblPendingCases As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlCard3 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalBlotter As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnlCard4 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalConcerns As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pnlChartSection As System.Windows.Forms.Panel
    Friend WithEvents pnlFilterBar As System.Windows.Forms.Panel
    Friend WithEvents cbIncidentType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblChartTitle As System.Windows.Forms.Label
    Friend WithEvents chartIncidents As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnHome As System.Windows.Forms.Button
End Class