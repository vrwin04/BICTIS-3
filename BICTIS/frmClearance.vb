Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports System.Drawing

Public Class frmClearance
    ' Declare Print Objects
    Private WithEvents docToPrint As New PrintDocument
    Private printPreview As New PrintPreviewDialog

    ' Variables to hold data for printing
    Private printName As String = ""
    Private printPurpose As String = ""
    Private printDate As String = ""

    Private Sub frmClearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRequests()
    End Sub

    Private Sub LoadRequests()
        ' Join on ResidentID to get the Name
        Dim sql As String = "SELECT c.ClearanceID, u.FullName, c.Purpose, c.DateIssued, c.Status FROM tblClearances c INNER JOIN tblResidents u ON c.ResidentID = u.ResidentID ORDER BY c.DateIssued DESC"
        dgvRequests.DataSource = Session.GetDataTable(sql)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dgvRequests.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a request first.", "Select Request", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim row As DataGridViewRow = dgvRequests.SelectedRows(0)
        Dim currentStatus As String = row.Cells("Status").Value.ToString()

        ' CHECK: Prevent changes if already processed
        If currentStatus = "Approved" Or currentStatus = "Rejected" Then
            MessageBox.Show("This request has already been processed (" & currentStatus & ").", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Dim cid As Integer = Convert.ToInt32(row.Cells("ClearanceID").Value)

        ' 1. Capture Data for Printing
        printName = row.Cells("FullName").Value.ToString()
        printPurpose = row.Cells("Purpose").Value.ToString()

        ' Handle date parsing safely
        If IsDate(row.Cells("DateIssued").Value) Then
            printDate = Convert.ToDateTime(row.Cells("DateIssued").Value).ToString("MMMM dd, yyyy")
        Else
            printDate = DateTime.Now.ToString("MMMM dd, yyyy")
        End If

        ' 2. Update Status to Approved (SECURE FIX)
        Dim query As String = "UPDATE tblClearances SET Status='Approved' WHERE ClearanceID=@id"
        Dim params As New Dictionary(Of String, Object)
        params.Add("@id", cid)

        If Session.ExecuteQuery(query, params) Then

            ' 3. Setup Print Preview
            printPreview.Document = docToPrint
            printPreview.WindowState = FormWindowState.Maximized
            printPreview.ShowDialog()

            LoadRequests() ' Refresh Grid to show Approved status
        End If
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If dgvRequests.SelectedRows.Count = 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvRequests.SelectedRows(0)
        Dim currentStatus As String = row.Cells("Status").Value.ToString()

        ' CHECK: Prevent changes if already processed
        If currentStatus = "Approved" Or currentStatus = "Rejected" Then
            MessageBox.Show("This request has already been processed (" & currentStatus & ").", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Dim cid As Integer = Convert.ToInt32(row.Cells("ClearanceID").Value)

        If MessageBox.Show("Reject this request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' SECURE FIX
            Dim query As String = "UPDATE tblClearances SET Status='Rejected' WHERE ClearanceID=@id"
            Dim params As New Dictionary(Of String, Object)
            params.Add("@id", cid)

            Session.ExecuteQuery(query, params)
            LoadRequests()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' --- PRINTING DESIGN (REFACTORED FOR READABILITY) ---
    Private Sub docToPrint_PrintPage(sender As Object, e As PrintPageEventArgs) Handles docToPrint.PrintPage
        ' 1. DEFINITIONS
        Dim fontTitle As New Font("Arial", 24, FontStyle.Bold)
        Dim fontHeader As New Font("Arial", 12, FontStyle.Regular)
        Dim fontBody As New Font("Arial", 14, FontStyle.Regular)
        Dim fontBold As New Font("Arial", 14, FontStyle.Bold)

        Dim centerX As Single = e.PageBounds.Width / 2
        Dim startY As Single = 100
        Dim lineHeight As Integer = 25
        Dim centerAlign As New StringFormat() With {.Alignment = StringAlignment.Center}

        ' 2. DRAW HEADER
        Dim headers() As String = {"Republic of the Philippines", "Province of Cavite", "Municipality of Silang", "BARANGAY TARTARIA"}

        For Each line As String In headers
            e.Graphics.DrawString(line, fontHeader, Brushes.Black, centerX, startY, centerAlign)
            startY += lineHeight
        Next

        ' 3. DRAW TITLE
        startY += 60 ' Spacer
        e.Graphics.DrawString("BARANGAY CLEARANCE", fontTitle, Brushes.Black, centerX, startY, centerAlign)

        ' 4. DRAW BODY
        startY += 80
        Dim leftMargin As Integer = 100
        e.Graphics.DrawString("TO WHOM IT MAY CONCERN:", fontBody, Brushes.Black, leftMargin, startY)

        startY += 50
        ' Use interpolated string logic for clean reading
        Dim bodyText As String = "This is to certify that " & printName.ToUpper() & ", of legal age, is a bona fide resident of this Barangay." & vbCrLf & vbCrLf &
                                 "This certification is issued upon the request of the interested party for the purpose of: " & vbCrLf & vbCrLf &
                                 "     " & printPurpose.ToUpper() & "." & vbCrLf & vbCrLf &
                                 "Issued this " & printDate & " at Barangay Tartaria, Silang, Cavite."

        Dim rect As New RectangleF(leftMargin, startY, e.PageBounds.Width - (leftMargin * 2), 400)
        e.Graphics.DrawString(bodyText, fontBody, Brushes.Black, rect)

        ' 5. DRAW SIGNATURE
        Dim sigY As Single = startY + 300
        e.Graphics.DrawString("HON. JUAN DELA CRUZ", fontBold, Brushes.Black, e.PageBounds.Width - 300, sigY)
        e.Graphics.DrawString("Punong Barangay", fontHeader, Brushes.Black, e.PageBounds.Width - 280, sigY + lineHeight)

        ' 6. OFFICIAL SEAL (Optional)
        e.Graphics.DrawEllipse(Pens.Black, 100, sigY - 50, 100, 100)
        e.Graphics.DrawString("SEAL", fontHeader, Brushes.Black, 125, sigY - 10)
    End Sub
End Class