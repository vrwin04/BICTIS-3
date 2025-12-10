Imports System.Collections.Generic

Public Class frmBlotter
    Private Sub frmBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "BLOTTER CASES (Admin)"
        LoadDropdowns()
        LoadIncidents()
    End Sub

    Private Sub LoadDropdowns()
        ' 1. Status Options
        cbStatus.Items.Clear()
        cbStatus.Items.AddRange(New String() {"Resolved", "Dismissed", "Escalated"})
        cbStatus.SelectedIndex = 0

        ' 2. Complainant (Residents from Database)
        Dim dt As DataTable = Session.GetDataTable("SELECT ResidentID, FullName FROM tblResidents WHERE Role='User'")
        cbComplainant.DataSource = dt
        cbComplainant.DisplayMember = "FullName"
        cbComplainant.ValueMember = "ResidentID"
        cbComplainant.SelectedIndex = -1

        ' 3. Respondent (Barangay Bodies / LGU)
        cbRespondent.DataSource = Nothing
        cbRespondent.Items.Clear()
        cbRespondent.Items.AddRange(New String() {
            "Peace and Order Committee",
            "Lupon Tagapamayapa",
            "Barangay Health Office",
            "Resident (See Narrative)"
        })
        cbRespondent.SelectedIndex = 0

        ' 4. Incident Nature (Explicit List)
        cbIncidentType.Items.Clear()
        cbIncidentType.Items.AddRange(New String() {
            "Physical Injury",
            "Theft / Robbery",
            "Property / Land Dispute",
            "Harassment / Threats",
            "Unjust Vexation",
            "Malicious Mischief",
            "Estafa / Swindling",
            "Libel / Slander",
            "Other"
        })
        cbIncidentType.SelectedIndex = -1
    End Sub

    ' *** NEW: Auto-Categorize Respondent based on Incident Type ***
    Private Sub cbIncidentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIncidentType.SelectedIndexChanged
        If cbIncidentType.SelectedIndex = -1 Then Exit Sub

        Dim selectedType As String = cbIncidentType.Text

        Select Case selectedType
            ' DISPUTES & CIVIL MATTERS -> Lupon Tagapamayapa (Justice System)
            Case "Property / Land Dispute", "Estafa / Swindling", "Unjust Vexation", "Libel / Slander", "Malicious Mischief"
                cbRespondent.SelectedItem = "Lupon Tagapamayapa"

            ' CRIMES & ORDER -> Peace and Order Committee (Tanods/Police)
            Case "Physical Injury", "Theft / Robbery", "Harassment / Threats"
                cbRespondent.SelectedItem = "Peace and Order Committee"

                ' DEFAULT -> Specific Resident or Other
            Case Else
                cbRespondent.SelectedItem = "Resident (See Narrative)"
        End Select
    End Sub

    Private Sub LoadIncidents()
        Dim sql As String = "SELECT i.IncidentID, i.IncidentType, u.FullName AS Complainant, i.Status, i.IncidentDate, i.Narrative " &
                            "FROM tblIncidents i " &
                            "LEFT JOIN tblResidents u ON i.ComplainantID = u.ResidentID " &
                            "WHERE i.Category='Blotter' " &
                            "ORDER BY i.IncidentID DESC"
        dgvCases.DataSource = Session.GetDataTable(sql)
    End Sub

    ' View Details on Double Click
    Private Sub dgvCases_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCases.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim id As Integer = Convert.ToInt32(dgvCases.Rows(e.RowIndex).Cells("IncidentID").Value)
            Dim detailsForm As New frmCaseDetails()
            detailsForm.LoadData(id)
            detailsForm.ShowDialog()
        End If
    End Sub

    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        If cbStatus.Text <> "" Then
            btnResolve.Text = "SET STATUS TO " & cbStatus.Text.ToUpper()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cbComplainant.SelectedValue Is Nothing OrElse String.IsNullOrWhiteSpace(cbComplainant.Text) Then
            MessageBox.Show("Please select a Complainant.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(cbRespondent.Text) OrElse String.IsNullOrWhiteSpace(cbIncidentType.Text) OrElse String.IsNullOrWhiteSpace(txtNarrative.Text) Then
            MessageBox.Show("Please complete all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respondentName As String = cbRespondent.Text
        Dim finalNarrative As String = "[Respondent: " & respondentName & "] " & txtNarrative.Text

        Dim query As String = "INSERT INTO tblIncidents (ComplainantID, RespondentID, IncidentType, Narrative, Status, IncidentDate, Category) " &
                              "VALUES (@comp, 0, @type, @narr, 'Pending', @date, 'Blotter')"

        Dim params As New Dictionary(Of String, Object)
        params.Add("@comp", cbComplainant.SelectedValue)
        params.Add("@type", cbIncidentType.Text)
        params.Add("@narr", finalNarrative)
        params.Add("@date", DateTime.Now.ToString())

        If Session.ExecuteQuery(query, params) Then
            MessageBox.Show("Blotter case filed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNarrative.Clear()
            cbIncidentType.SelectedIndex = -1
            cbComplainant.SelectedIndex = -1
            LoadIncidents()
        End If
    End Sub

    Private Sub btnResolve_Click(sender As Object, e As EventArgs) Handles btnResolve.Click
        If dgvCases.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a case to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim id As Integer = Convert.ToInt32(dgvCases.SelectedRows(0).Cells("IncidentID").Value)
        Dim currentStatus As String = dgvCases.SelectedRows(0).Cells("Status").Value.ToString()
        Dim newStatus As String = cbStatus.Text

        If currentStatus <> "Pending" Then
            MessageBox.Show("This case is already closed (" & currentStatus & ") and cannot be modified.", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If MessageBox.Show("Mark case as " & newStatus & "? This cannot be undone.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Session.ExecuteQuery("UPDATE tblIncidents SET Status='" & newStatus & "' WHERE IncidentID=" & id)
            LoadIncidents()
            MessageBox.Show("Case updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class