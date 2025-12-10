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

        ' 2. Update Status to Approved
        If Session.ExecuteQuery("UPDATE tblClearances SET Status='Approved' WHERE ClearanceID=" & cid) Then

            ' 3. Setup Print Preview
            printPreview.Document = docToPrint
            printPreview.WindowState = FormWindowState.Maximized
            printPreview.ShowDialog()

            LoadRequests() ' Refresh Grid to show Approved status
        End If
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If dgvRequests.SelectedRows.Count = 0 Then Exit Sub
        Dim cid As Integer = Convert.ToInt32(dgvRequests.SelectedRows(0).Cells("ClearanceID").Value)

        If MessageBox.Show("Reject this request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Session.ExecuteQuery("UPDATE tblClearances SET Status='Rejected' WHERE ClearanceID=" & cid)
            LoadRequests()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' --- PRINTING DESIGN ---
    Private Sub docToPrint_PrintPage(sender As Object, e As PrintPageEventArgs) Handles docToPrint.PrintPage
        ' SET FONT TO ARIAL
        Dim titleFont As New Font("Arial", 24, FontStyle.Bold)
        Dim headerFont As New Font("Arial", 12, FontStyle.Regular)
        Dim bodyFont As New Font("Arial", 14, FontStyle.Regular)
        Dim boldBodyFont As New Font("Arial", 14, FontStyle.Bold)

        ' Margins
        Dim startX As Integer = 100
        Dim startY As Integer = 100

        ' 1. HEADER (Centered)
        Dim centerFormat As New StringFormat()
        centerFormat.Alignment = StringAlignment.Center

        ' Using CSng() to fix the Double -> Single error
        e.Graphics.DrawString("Republic of the Philippines", headerFont, Brushes.Black, CSng(e.PageBounds.Width / 2), startY, centerFormat)
        startY += 25
        e.Graphics.DrawString("Province of Cavite", headerFont, Brushes.Black, CSng(e.PageBounds.Width / 2), startY, centerFormat)
        startY += 25
        e.Graphics.DrawString("Municipality of Silang", headerFont, Brushes.Black, CSng(e.PageBounds.Width / 2), startY, centerFormat)
        startY += 25
        e.Graphics.DrawString("BARANGAY POBLACION I", headerFont, Brushes.Black, CSng(e.PageBounds.Width / 2), startY, centerFormat)

        startY += 80

        ' 2. TITLE
        e.Graphics.DrawString("BARANGAY CLEARANCE", titleFont, Brushes.Black, CSng(e.PageBounds.Width / 2), startY, centerFormat)
        startY += 100

        ' 3. BODY
        e.Graphics.DrawString("TO WHOM IT MAY CONCERN:", bodyFont, Brushes.Black, startX, startY)
        startY += 60

        Dim text As String = "This is to certify that " & printName.ToUpper() & ", of legal age, is a bona fide resident of this Barangay." & vbCrLf & vbCrLf &
                             "This certification is issued upon the request of the interested party for the purpose of: " & vbCrLf & vbCrLf &
                             "     " & printPurpose.ToUpper() & "." & vbCrLf & vbCrLf &
                             "Issued this " & printDate & " at Barangay Tartaria, Silang, Cavite."

        Dim rect As New RectangleF(startX, startY, e.PageBounds.Width - 200, 400)
        e.Graphics.DrawString(text, bodyFont, Brushes.Black, rect)

        ' 4. SIGNATURE
        startY += 400
        e.Graphics.DrawString("HON. JUAN DELA CRUZ", boldBodyFont, Brushes.Black, CSng(e.PageBounds.Width - 300), startY)
        startY += 25
        e.Graphics.DrawString("Punong Barangay", headerFont, Brushes.Black, CSng(e.PageBounds.Width - 280), startY)

        ' 5. OFFICIAL SEAL (Optional - draws a circle placeholder)
        e.Graphics.DrawEllipse(Pens.Black, 100, startY - 50, 100, 100)
        e.Graphics.DrawString("SEAL", headerFont, Brushes.Black, 125, startY - 10)
    End Sub
End Class