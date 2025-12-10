<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUser
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlBorder = New System.Windows.Forms.Panel()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnFileBlotter = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlBorder.SuspendLayout()
        Me.pnlContainer.SuspendLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBorder
        '
        Me.pnlBorder.BackColor = System.Drawing.Color.White
        Me.pnlBorder.Controls.Add(Me.pnlContainer)
        Me.pnlBorder.Controls.Add(Me.pnlHeader)
        Me.pnlBorder.Controls.Add(Me.pnlSidebar)
        Me.pnlBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBorder.Location = New System.Drawing.Point(2, 2)
        Me.pnlBorder.Name = "pnlBorder"
        Me.pnlBorder.Size = New System.Drawing.Size(996, 596)
        Me.pnlBorder.TabIndex = 0
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlContainer.Controls.Add(Me.dgvHistory)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(220, 80)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlContainer.Size = New System.Drawing.Size(776, 516)
        Me.pnlContainer.TabIndex = 2
        '
        'dgvHistory
        '
        Me.dgvHistory.AllowUserToAddRows = False
        Me.dgvHistory.AllowUserToDeleteRows = False
        Me.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(0, 150, 136)
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHistory.ColumnHeadersHeight = 40
        Me.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHistory.EnableHeadersVisualStyles = False
        Me.dgvHistory.Location = New System.Drawing.Point(20, 20)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.ReadOnly = True
        Me.dgvHistory.RowHeadersVisible = False
        Me.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistory.Size = New System.Drawing.Size(736, 476)
        Me.dgvHistory.TabIndex = 0
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(224, 242, 241)
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvHistory.RowsDefaultCellStyle = DataGridViewCellStyle2
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblWelcome)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(220, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(776, 80)
        Me.pnlHeader.TabIndex = 1
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.lblWelcome.Location = New System.Drawing.Point(25, 25)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(206, 30)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome Resident"
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(0, 150, 136)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnRefresh)
        Me.pnlSidebar.Controls.Add(Me.btnFileBlotter)
        Me.pnlSidebar.Controls.Add(Me.btnReport)
        Me.pnlSidebar.Controls.Add(Me.pnlLogo)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 596)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(255, 205, 210)
        Me.btnLogout.Location = New System.Drawing.Point(0, 546)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(220, 50)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Sign Out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(0, 180)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnRefresh.Size = New System.Drawing.Size(220, 50)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh History"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnFileBlotter
        '
        Me.btnFileBlotter.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFileBlotter.FlatAppearance.BorderSize = 0
        Me.btnFileBlotter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFileBlotter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnFileBlotter.ForeColor = System.Drawing.Color.White
        Me.btnFileBlotter.Location = New System.Drawing.Point(0, 130)
        Me.btnFileBlotter.Name = "btnFileBlotter"
        Me.btnFileBlotter.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnFileBlotter.Size = New System.Drawing.Size(220, 50)
        Me.btnFileBlotter.TabIndex = 2
        Me.btnFileBlotter.Text = "File Blotter Case"
        Me.btnFileBlotter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFileBlotter.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(0, 80)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnReport.Size = New System.Drawing.Size(220, 50)
        Me.btnReport.TabIndex = 1
        Me.btnReport.Text = "Report a Concern"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'pnlLogo
        '
        Me.pnlLogo.BackColor = System.Drawing.Color.FromArgb(0, 121, 107)
        Me.pnlLogo.Controls.Add(Me.Label1)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(220, 80)
        Me.pnlLogo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Text = "RESIDENT"
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.pnlBorder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUser"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Dashboard"
        Me.pnlBorder.ResumeLayout(False)
        Me.pnlContainer.ResumeLayout(False)
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        Me.pnlLogo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBorder As Panel
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReport As Button
    Friend WithEvents btnFileBlotter As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents dgvHistory As DataGridView
End Class