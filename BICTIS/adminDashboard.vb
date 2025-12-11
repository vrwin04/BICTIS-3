' ALIAS TO FIX CHART ERRORS
Imports SysChart = System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms
Imports System.Data
Imports System.Collections.Generic
Imports System.Threading.Tasks ' Required for Async
Imports System.Drawing ' Required for Color

Public Class adminDashboard
    ' Variable to keep track of the current child form loaded
    Private currentChildForm As Form

    Private Async Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPageTitle.Text = "Dashboard - " & Session.CurrentUserRole

        Try
            ' Load Filters first (Fast, no DB)
            LoadFilterOptions()

            ' Load Home Data
            Await LoadDashboardStats()

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard: " & ex.Message)
        End Try
    End Sub

    ' --- HELPER TO SWITCH PANELS ---
    Private Sub OpenChildForm(childForm As Form)
        ' 1. Close previous form if exists
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm

        ' 2. Configure Child Form
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        childForm.AutoScroll = True ' <--- ADDED THIS: Enables scrolling if form is too large

        ' 3. Optional: Hide the Header/Close button of the child form 
        ' so it looks integrated (Searching for 'pnlHeader' or 'btnClose' control)
        Dim header = childForm.Controls.Find("pnlHeader", True).FirstOrDefault()
        If header IsNot Nothing Then header.Visible = False

        ' 4. Add to Panel
        pnlMainContent.Controls.Add(childForm)
        pnlMainContent.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

        ' 5. Hide the Dashboard Home Panel
        pnlHome.Visible = False

        ' 6. Update Title
        lblPageTitle.Text = childForm.Text
    End Sub

    Private Async Sub GoToHome()
        ' Close any active child form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
            currentChildForm = Nothing
        End If

        pnlHome.Visible = True
        pnlHome.BringToFront()
        lblPageTitle.Text = "Admin Dashboard"

        ' Refresh Stats
        Await LoadDashboardStats()
    End Sub

    ' --- NAVIGATION BUTTONS ---

    Private Sub btnResidents_Click(sender As Object, e As EventArgs) Handles btnResidents.Click
        OpenChildForm(New frmManageResidents())
    End Sub

    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click
        OpenChildForm(New frmBlotter())
    End Sub

    Private Sub btnConcerns_Click(sender As Object, e As EventArgs) Handles btnConcerns.Click
        OpenChildForm(New frmConcerns())
    End Sub

    Private Sub btnClearance_Click(sender As Object, e As EventArgs) Handles btnClearance.Click
        OpenChildForm(New frmClearance())
    End Sub

    ' Click Logo to go back to Dashboard Home
    Private Sub pnlLogo_Click(sender As Object, e As EventArgs) Handles pnlLogo.Click, lblLogo.Click
        GoToHome()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Sign out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Session.CurrentResidentID = 0
            Dim login As New frmLogin()
            login.Show()
            Me.Close()
        End If
    End Sub

    ' --- DATA LOADING & CHARTS (Reused from previous code) ---

    Private Async Function LoadDashboardStats() As Task
        ' Only load if Home is visible
        If Not pnlHome.Visible Then Exit Function

        Dim taskUserCount = Session.GetCountAsync("SELECT COUNT(*) FROM tblResidents WHERE Role='User'")
        Dim taskPending = Session.GetCountAsync("SELECT COUNT(*) FROM tblIncidents WHERE Status='Pending'")
        Dim taskBlotter = Session.GetCountAsync("SELECT COUNT(*) FROM tblIncidents WHERE Category='Blotter'")
        Dim taskConcerns = Session.GetCountAsync("SELECT COUNT(*) FROM tblIncidents WHERE Category='Concern'")

        Dim userCount As Integer = Await taskUserCount
        Dim pending As Integer = Await taskPending
        Dim blotter As Integer = Await taskBlotter
        Dim concerns As Integer = Await taskConcerns

        lblTotalUsers.Text = userCount.ToString()
        lblPendingCases.Text = pending.ToString()
        lblTotalBlotter.Text = blotter.ToString()
        lblTotalConcerns.Text = concerns.ToString()

        If pending > 0 Then
            lblPendingCases.ForeColor = Color.Red
        Else
            lblPendingCases.ForeColor = Color.Green
        End If

        Await LoadChartAsync()
    End Function

    Private Sub LoadFilterOptions()
        cbIncidentType.Items.Clear()
        cbIncidentType.Items.Add("All Incidents")
        cbIncidentType.Items.AddRange(New String() {
            "Physical Injury", "Theft / Robbery", "Property / Land Dispute",
            "Harassment / Threats", "Unjust Vexation", "Malicious Mischief",
            "Estafa / Swindling", "Libel / Slander",
            "Noise Complaint", "Waste Disposal / Trash", "Suspicious Activity",
            "Public Disturbance", "Broken Street Light / Infrastructure",
            "Animal Control / Stray Pets", "Curfew Violation", "Other"
        })
        cbIncidentType.SelectedIndex = 0
    End Sub

    Private Async Sub cbIncidentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIncidentType.SelectedIndexChanged
        Await LoadChartAsync()
    End Sub

    Private Async Function LoadChartAsync() As Task
        If chartIncidents Is Nothing OrElse Not pnlHome.Visible Then Exit Function

        Dim selection As String = cbIncidentType.Text
        Dim query As String
        Dim params As New Dictionary(Of String, Object)
        Dim isAllIncidents As Boolean = (selection = "All Incidents")

        If isAllIncidents Then
            query = "SELECT IncidentType, COUNT(*) as [Count] FROM tblIncidents GROUP BY IncidentType"
        Else
            query = "SELECT Status, COUNT(*) as [Count] FROM tblIncidents WHERE IncidentType=@type GROUP BY Status"
            params.Add("@type", selection)
        End If

        Dim dt As DataTable = Await Session.GetDataTableAsync(query, params)

        chartIncidents.Series.Clear()
        chartIncidents.Titles.Clear()

        Dim seriesName As String = If(isAllIncidents, "Incidents", "Status")
        Dim series As New SysChart.Series(seriesName)

        If isAllIncidents Then
            series.ChartType = SysChart.SeriesChartType.Column
            chartIncidents.Titles.Add("All Incidents Overview")
        Else
            series.ChartType = SysChart.SeriesChartType.Pie
            chartIncidents.Palette = SysChart.ChartColorPalette.SeaGreen
            chartIncidents.Titles.Add("Status Breakdown: " & selection)
        End If

        series.IsValueShownAsLabel = True

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Dim xVal As String = If(isAllIncidents, row("IncidentType").ToString(), row("Status").ToString())
                If String.IsNullOrEmpty(xVal) Then xVal = "Unknown"
                Dim yVal As Integer = Convert.ToInt32(row("Count"))

                Dim pIndex As Integer = series.Points.AddXY(xVal, yVal)
                Dim p As SysChart.DataPoint = series.Points(pIndex)

                ' --- COLOR CODING LOGIC ---
                If isAllIncidents Then
                    ' CATEGORY COLORS (Column Chart)
                    Select Case xVal
                        Case "Physical Injury" : p.Color = Color.Crimson
                        Case "Theft / Robbery" : p.Color = Color.DarkRed
                        Case "Harassment / Threats" : p.Color = Color.OrangeRed
                        Case "Unjust Vexation" : p.Color = Color.Purple
                        Case "Malicious Mischief" : p.Color = Color.DarkMagenta
                        Case "Estafa / Swindling" : p.Color = Color.Indigo
                        Case "Libel / Slander" : p.Color = Color.SlateBlue
                        Case "Property / Land Dispute" : p.Color = Color.SaddleBrown

                        Case "Noise Complaint" : p.Color = Color.DarkOrange
                        Case "Waste Disposal / Trash" : p.Color = Color.ForestGreen
                        Case "Suspicious Activity" : p.Color = Color.DimGray
                        Case "Public Disturbance" : p.Color = Color.Goldenrod
                        Case "Broken Street Light / Infrastructure" : p.Color = Color.Teal
                        Case "Animal Control / Stray Pets" : p.Color = Color.OliveDrab
                        Case "Curfew Violation" : p.Color = Color.MidnightBlue

                        Case "Other" : p.Color = Color.Gray
                        Case Else : p.Color = Color.SteelBlue
                    End Select
                Else
                    ' STATUS COLORS (Pie Chart)
                    Select Case xVal
                        Case "Pending", "Escalated" : p.Color = Color.Crimson
                        Case "Resolved", "Acknowledged" : p.Color = Color.SeaGreen
                        Case "Dismissed", "Invalid" : p.Color = Color.Gray
                        Case Else : p.Color = Color.SteelBlue
                    End Select
                End If
            Next
        Else
            series.Points.AddXY("No Data", 0)
        End If
        chartIncidents.Series.Add(series)
    End Function
End Class