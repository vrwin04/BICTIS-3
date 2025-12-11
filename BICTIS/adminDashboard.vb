Imports SysChart = System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms
Imports System.Data
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports System.Drawing

Public Class adminDashboard

    Private Async Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPageTitle.Text = "Dashboard - " & Session.CurrentUserRole
        Try
            LoadFilterOptions()
            ' Defer chart initialization until after form has been laid out
            Me.BeginInvoke(New Action(AddressOf InitializeChart))
            Await LoadDashboardStats()
        Catch ex As Exception
            MessageBox.Show("Error loading dashboard: " & ex.Message)
        End Try
    End Sub

    Private Sub InitializeChart()
        Try
            If chartIncidents Is Nothing Then Return

            ' Ensure chart has a positive size before configuring
            If chartIncidents.Height <= 0 Or chartIncidents.Width <= 0 Then
                chartIncidents.Size = New Size(600, 300)
            End If

            chartIncidents.Series.Clear()
            chartIncidents.Titles.Clear()

            Dim chartArea As New SysChart.ChartArea("ChartArea1")
            chartIncidents.ChartAreas.Clear()
            chartIncidents.ChartAreas.Add(chartArea)

            Dim legend As New SysChart.Legend("Legend1")
            legend.IsTextAutoFit = False
            legend.Font = New Font("Segoe UI", 10.0!)
            chartIncidents.Legends.Clear()
            chartIncidents.Legends.Add(legend)

            Dim series As New SysChart.Series("Incidents")
            series.ChartArea = "ChartArea1"
            series.Legend = "Legend1"
            series.IsValueShownAsLabel = True
            series.ChartType = SysChart.SeriesChartType.Column

            chartIncidents.Series.Add(series)
            chartIncidents.Titles.Add("All Incidents Overview")
        Catch ex As Exception
            ' Swallow to avoid crash during load; log if needed
        End Try
    End Sub

    ' --- SIDEBAR NAVIGATION (DIRECT OPEN) ---

    Private Async Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ' Refresh the Dashboard Stats
        Await LoadDashboardStats()
        MessageBox.Show("Dashboard stats refreshed.", "Home", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnResidents_Click(sender As Object, e As EventArgs) Handles btnResidents.Click
        Dim frm As New frmManageResidents()
        frm.Show()
    End Sub

    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click
        Dim frm As New frmBlotter()
        frm.Show()
    End Sub

    Private Sub btnConcerns_Click(sender As Object, e As EventArgs) Handles btnConcerns.Click
        Dim frm As New frmConcerns()
        frm.Show()
    End Sub

    Private Sub btnClearance_Click(sender As Object, e As EventArgs) Handles btnClearance.Click
        Dim frm As New frmClearance()
        frm.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Sign out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Session.CurrentResidentID = 0
            Dim login As New frmLogin()
            login.Show()
            Me.Close()
        End If
    End Sub

    ' --- DATA & CHARTS ---

    Private Async Function LoadDashboardStats() As Task
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

        lblPendingCases.ForeColor = If(pending > 0, Color.Crimson, Color.SeaGreen)

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
        If chartIncidents Is Nothing Then Exit Function

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

        ' Ensure chart is initialized before updating
        If chartIncidents.Series.Count = 0 Then
            Me.BeginInvoke(New Action(AddressOf InitializeChart))
        End If

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
                p.Color = GetChartColor(xVal)
            Next
        Else
            series.Points.AddXY("No Data", 0)
        End If

        chartIncidents.Series.Add(series)
    End Function

    Private Function GetChartColor(category As String) As Color
        Select Case category
            ' Red/Danger
            Case "Physical Injury", "Pending", "Escalated" : Return Color.Crimson
            Case "Theft / Robbery" : Return Color.DarkRed
            Case "Harassment / Threats" : Return Color.OrangeRed
            ' Purple/Civil
            Case "Unjust Vexation" : Return Color.Purple
            Case "Malicious Mischief" : Return Color.DarkMagenta
            Case "Estafa / Swindling" : Return Color.Indigo
            Case "Libel / Slander" : Return Color.SlateBlue
            Case "Property / Land Dispute" : Return Color.SaddleBrown
            ' Green/Concerns
            Case "Noise Complaint" : Return Color.DarkOrange
            Case "Waste Disposal / Trash", "Resolved", "Acknowledged" : Return Color.SeaGreen
            Case "Broken Street Light / Infrastructure" : Return Color.Teal
            Case "Public Disturbance" : Return Color.Goldenrod
                ' Default
            Case Else : Return Color.SteelBlue
        End Select
    End Function
End Class