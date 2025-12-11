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
        pnlBorder = New Panel()
        pnlMainContent = New Panel()
        pnlHome = New Panel()
        pnlChartSection = New Panel()
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
        btnHome = New Button()
        pnlLogo = New Panel()
        lblLogo = New Label()
        pnlBorder.SuspendLayout()
        pnlMainContent.SuspendLayout()
        pnlHome.SuspendLayout()
        pnlChartSection.SuspendLayout()
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
        pnlBorder.Name = "pnlBorder"
        pnlBorder.Size = New Size(1693, 759)
        pnlBorder.TabIndex = 0
        ' 
        ' pnlMainContent
        ' 
        pnlMainContent.Controls.Add(pnlHome)
        pnlMainContent.Dock = DockStyle.Fill
        pnlMainContent.Location = New Point(347, 123)
        pnlMainContent.Name = "pnlMainContent"
        pnlMainContent.Size = New Size(1346, 636)
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
        pnlHome.Padding = New Padding(40)
        pnlHome.Size = New Size(1346, 636)
        pnlHome.TabIndex = 0
        ' 
        ' pnlChartSection
        ' 
        pnlChartSection.BackColor = Color.White
        pnlChartSection.Controls.Add(pnlFilterBar)
        pnlChartSection.Dock = DockStyle.Top
        pnlChartSection.Location = New Point(40, 291)
        pnlChartSection.Name = "pnlChartSection"
        pnlChartSection.Padding = New Padding(20)
        pnlChartSection.Size = New Size(1245, 500)
        pnlChartSection.TabIndex = 1
        ' 
        ' pnlFilterBar
        ' 
        pnlFilterBar.Controls.Add(cbIncidentType)
        pnlFilterBar.Controls.Add(Label2)
        pnlFilterBar.Controls.Add(lblChartTitle)
        pnlFilterBar.Dock = DockStyle.Top
        pnlFilterBar.Location = New Point(20, 20)
        pnlFilterBar.Name = "pnlFilterBar"
        pnlFilterBar.Size = New Size(1205, 80)
        pnlFilterBar.TabIndex = 0
        ' 
        ' cbIncidentType
        ' 
        cbIncidentType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cbIncidentType.BackColor = Color.WhiteSmoke
        cbIncidentType.DropDownStyle = ComboBoxStyle.DropDownList
        cbIncidentType.FlatStyle = FlatStyle.Flat
        cbIncidentType.Font = New Font("Segoe UI", 12.0F)
        cbIncidentType.FormattingEnabled = True
        cbIncidentType.Location = New Point(885, 23)
        cbIncidentType.Name = "cbIncidentType"
        cbIncidentType.Size = New Size(300, 36)
        cbIncidentType.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(762, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 28)
        Label2.TabIndex = 1
        Label2.Text = "Filter Graph:"
        ' 
        ' lblChartTitle
        ' 
        lblChartTitle.AutoSize = True
        lblChartTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblChartTitle.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblChartTitle.Location = New Point(13, 23)
        lblChartTitle.Name = "lblChartTitle"
        lblChartTitle.Size = New Size(246, 37)
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
        pnlStatsRow.Location = New Point(40, 40)
        pnlStatsRow.Name = "pnlStatsRow"
        pnlStatsRow.Size = New Size(1245, 251)
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
        lblTotalUsers.Name = "lblTotalUsers"
        lblTotalUsers.Size = New Size(70, 81)
        lblTotalUsers.TabIndex = 1
        lblTotalUsers.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(27, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 25)
        Label1.TabIndex = 0
        Label1.Text = "TOTAL RESIDENTS"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
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
        lblPendingCases.Name = "lblPendingCases"
        lblPendingCases.Size = New Size(70, 81)
        lblPendingCases.TabIndex = 1
        lblPendingCases.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(27, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 25)
        Label3.TabIndex = 0
        Label3.Text = "PENDING CASES"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Crimson
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
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
        lblTotalBlotter.Name = "lblTotalBlotter"
        lblTotalBlotter.Size = New Size(70, 81)
        lblTotalBlotter.TabIndex = 1
        lblTotalBlotter.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label4.ForeColor = Color.Gray
        Label4.Location = New Point(27, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(214, 25)
        Label4.TabIndex = 0
        Label4.Text = "TOTAL BLOTTER CASES"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
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
        lblTotalConcerns.Name = "lblTotalConcerns"
        lblTotalConcerns.Size = New Size(70, 81)
        lblTotalConcerns.TabIndex = 1
        lblTotalConcerns.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label5.ForeColor = Color.Gray
        Label5.Location = New Point(27, 23)
        Label5.Name = "Label5"
        Label5.Size = New Size(174, 25)
        Label5.TabIndex = 0
        Label5.Text = "TOTAL CONCERNS"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(34))
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 0)
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
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1346, 123)
        pnlHeader.TabIndex = 1
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.AutoSize = True
        lblPageTitle.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblPageTitle.Location = New Point(40, 34)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(365, 54)
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
        pnlSidebar.Controls.Add(btnHome)
        pnlSidebar.Controls.Add(pnlLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(347, 759)
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
        btnLogout.Location = New Point(0, 651)
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
        btnClearance.Font = New Font("Segoe UI", 12.0F)
        btnClearance.ForeColor = Color.WhiteSmoke
        btnClearance.Location = New Point(0, 483)
        btnClearance.Name = "btnClearance"
        btnClearance.Padding = New Padding(40, 0, 0, 0)
        btnClearance.Size = New Size(347, 90)
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
        btnConcerns.Font = New Font("Segoe UI", 12.0F)
        btnConcerns.ForeColor = Color.WhiteSmoke
        btnConcerns.Location = New Point(0, 393)
        btnConcerns.Name = "btnConcerns"
        btnConcerns.Padding = New Padding(40, 0, 0, 0)
        btnConcerns.Size = New Size(347, 90)
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
        btnBlotter.Font = New Font("Segoe UI", 12.0F)
        btnBlotter.ForeColor = Color.WhiteSmoke
        btnBlotter.Location = New Point(0, 303)
        btnBlotter.Name = "btnBlotter"
        btnBlotter.Padding = New Padding(40, 0, 0, 0)
        btnBlotter.Size = New Size(347, 90)
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
        btnResidents.Font = New Font("Segoe UI", 12.0F)
        btnResidents.ForeColor = Color.WhiteSmoke
        btnResidents.Location = New Point(0, 213)
        btnResidents.Name = "btnResidents"
        btnResidents.Padding = New Padding(40, 0, 0, 0)
        btnResidents.Size = New Size(347, 90)
        btnResidents.TabIndex = 1
        btnResidents.Text = "Manage Residents"
        btnResidents.TextAlign = ContentAlignment.MiddleLeft
        btnResidents.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnHome.Cursor = Cursors.Hand
        btnHome.Dock = DockStyle.Top
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Segoe UI", 12.0F)
        btnHome.ForeColor = Color.WhiteSmoke
        btnHome.Location = New Point(0, 123)
        btnHome.Name = "btnHome"
        btnHome.Padding = New Padding(40, 0, 0, 0)
        btnHome.Size = New Size(347, 90)
        btnHome.TabIndex = 6
        btnHome.Text = "Home"
        btnHome.TextAlign = ContentAlignment.MiddleLeft
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' pnlLogo
        ' 
        pnlLogo.BackColor = Color.FromArgb(CByte(34), CByte(49), CByte(63))
        pnlLogo.Controls.Add(lblLogo)
        pnlLogo.Cursor = Cursors.Hand
        pnlLogo.Dock = DockStyle.Top
        pnlLogo.Location = New Point(0, 0)
        pnlLogo.Name = "pnlLogo"
        pnlLogo.Size = New Size(347, 123)
        pnlLogo.TabIndex = 0
        ' 
        ' lblLogo
        ' 
        lblLogo.AutoSize = True
        lblLogo.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        lblLogo.ForeColor = Color.White
        lblLogo.Location = New Point(80, 28)
        lblLogo.Name = "lblLogo"
        lblLogo.Size = New Size(192, 62)
        lblLogo.TabIndex = 0
        lblLogo.Text = "ADMIN"
        ' 
        ' adminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(1699, 765)
        Controls.Add(pnlBorder)
        FormBorderStyle = FormBorderStyle.None
        Name = "adminDashboard"
        Padding = New Padding(3)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Dashboard"
        pnlBorder.ResumeLayout(False)
        pnlMainContent.ResumeLayout(False)
        pnlHome.ResumeLayout(False)
        pnlHome.PerformLayout()
        pnlChartSection.ResumeLayout(False)
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