<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelHeader = New Panel()
        LblTitle = New Label()
        LblSubtitle = New Label()
        PanelSearch = New Panel()
        LblSearch = New Label()
        CmbSearchBy = New ComboBox()
        TxtSearch = New TextBox()
        BtnSearch = New Button()
        BtnReset = New Button()
        PanelGrid = New Panel()
        DgvData = New DataGridView()
        PanelButton = New Panel()
        BtnTambah = New Button()
        BtnEdit = New Button()
        BtnHapus = New Button()
        BtnDetail = New Button()
        LblTotal = New Label()
        PanelHeader.SuspendLayout()
        PanelSearch.SuspendLayout()
        PanelGrid.SuspendLayout()
        CType(DgvData, ComponentModel.ISupportInitialize).BeginInit()
        PanelButton.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(35))
        PanelHeader.Controls.Add(LblTitle)
        PanelHeader.Controls.Add(LblSubtitle)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(900, 90)
        PanelHeader.TabIndex = 3
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        LblTitle.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        LblTitle.Location = New Point(20, 12)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(657, 41)
        LblTitle.TabIndex = 0
        LblTitle.Text = "⚡ DX KAMEN RIDER COLLECTOR MANAGER"
        ' 
        ' LblSubtitle
        ' 
        LblSubtitle.AutoSize = True
        LblSubtitle.Font = New Font("Segoe UI", 10.0F)
        LblSubtitle.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(210))
        LblSubtitle.Location = New Point(24, 52)
        LblSubtitle.Name = "LblSubtitle"
        LblSubtitle.Size = New Size(326, 23)
        LblSubtitle.TabIndex = 1
        LblSubtitle.Text = "Kelola koleksi DX Belt & Rider Item milikmu"
        ' 
        ' PanelSearch
        ' 
        PanelSearch.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(50))
        PanelSearch.Controls.Add(LblSearch)
        PanelSearch.Controls.Add(CmbSearchBy)
        PanelSearch.Controls.Add(TxtSearch)
        PanelSearch.Controls.Add(BtnSearch)
        PanelSearch.Controls.Add(BtnReset)
        PanelSearch.Dock = DockStyle.Top
        PanelSearch.Location = New Point(0, 90)
        PanelSearch.Name = "PanelSearch"
        PanelSearch.Padding = New Padding(10, 8, 10, 8)
        PanelSearch.Size = New Size(900, 55)
        PanelSearch.TabIndex = 2
        ' 
        ' LblSearch
        ' 
        LblSearch.AutoSize = True
        LblSearch.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LblSearch.ForeColor = Color.White
        LblSearch.Location = New Point(10, 16)
        LblSearch.Name = "LblSearch"
        LblSearch.Size = New Size(52, 23)
        LblSearch.TabIndex = 0
        LblSearch.Text = "Cari :"
        ' 
        ' CmbSearchBy
        ' 
        CmbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList
        CmbSearchBy.Font = New Font("Segoe UI", 10.0F)
        CmbSearchBy.Items.AddRange(New Object() {"Nama Item", "Seri", "Kondisi", "Status"})
        CmbSearchBy.Location = New Point(60, 12)
        CmbSearchBy.Name = "CmbSearchBy"
        CmbSearchBy.Size = New Size(120, 31)
        CmbSearchBy.TabIndex = 1
        ' 
        ' TxtSearch
        ' 
        TxtSearch.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(75))
        TxtSearch.BorderStyle = BorderStyle.FixedSingle
        TxtSearch.Font = New Font("Segoe UI", 10.0F)
        TxtSearch.ForeColor = Color.White
        TxtSearch.Location = New Point(190, 12)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.Size = New Size(280, 30)
        TxtSearch.TabIndex = 2
        ' 
        ' BtnSearch
        ' 
        BtnSearch.BackColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        BtnSearch.FlatAppearance.BorderSize = 0
        BtnSearch.FlatStyle = FlatStyle.Flat
        BtnSearch.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnSearch.ForeColor = Color.Black
        BtnSearch.Location = New Point(480, 10)
        BtnSearch.Name = "BtnSearch"
        BtnSearch.Size = New Size(90, 32)
        BtnSearch.TabIndex = 3
        BtnSearch.Text = "🔍 Cari"
        BtnSearch.UseVisualStyleBackColor = False
        ' 
        ' BtnReset
        ' 
        BtnReset.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(110))
        BtnReset.FlatAppearance.BorderSize = 0
        BtnReset.FlatStyle = FlatStyle.Flat
        BtnReset.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnReset.ForeColor = Color.White
        BtnReset.Location = New Point(580, 10)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(90, 32)
        BtnReset.TabIndex = 4
        BtnReset.Text = "↺ Reset"
        BtnReset.UseVisualStyleBackColor = False
        ' 
        ' PanelGrid
        ' 
        PanelGrid.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(42))
        PanelGrid.Controls.Add(DgvData)
        PanelGrid.Dock = DockStyle.Fill
        PanelGrid.Location = New Point(0, 145)
        PanelGrid.Name = "PanelGrid"
        PanelGrid.Padding = New Padding(10)
        PanelGrid.Size = New Size(900, 395)
        PanelGrid.TabIndex = 0
        ' 
        ' DgvData
        ' 
        DgvData.AllowUserToAddRows = False
        DgvData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(60))
        DgvData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgvData.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(50))
        DgvData.BorderStyle = BorderStyle.None
        DgvData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(35))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(50))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DgvData.DefaultCellStyle = DataGridViewCellStyle3
        DgvData.Dock = DockStyle.Fill
        DgvData.EnableHeadersVisualStyles = False
        DgvData.Font = New Font("Segoe UI", 10.0F)
        DgvData.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(80))
        DgvData.Location = New Point(10, 10)
        DgvData.MultiSelect = False
        DgvData.Name = "DgvData"
        DgvData.ReadOnly = True
        DgvData.RowHeadersVisible = False
        DgvData.RowHeadersWidth = 51
        DgvData.RowTemplate.Height = 35
        DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvData.Size = New Size(880, 375)
        DgvData.TabIndex = 0
        ' 
        ' PanelButton
        ' 
        PanelButton.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(35))
        PanelButton.Controls.Add(BtnTambah)
        PanelButton.Controls.Add(BtnEdit)
        PanelButton.Controls.Add(BtnHapus)
        PanelButton.Controls.Add(BtnDetail)
        PanelButton.Controls.Add(LblTotal)
        PanelButton.Dock = DockStyle.Bottom
        PanelButton.Location = New Point(0, 540)
        PanelButton.Name = "PanelButton"
        PanelButton.Size = New Size(900, 60)
        PanelButton.TabIndex = 1
        ' 
        ' BtnTambah
        ' 
        BtnTambah.BackColor = Color.FromArgb(CByte(0), CByte(180), CByte(80))
        BtnTambah.FlatAppearance.BorderSize = 0
        BtnTambah.FlatStyle = FlatStyle.Flat
        BtnTambah.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        BtnTambah.ForeColor = Color.White
        BtnTambah.Location = New Point(10, 12)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(130, 38)
        BtnTambah.TabIndex = 0
        BtnTambah.Text = "➕ Tambah"
        BtnTambah.UseVisualStyleBackColor = False
        ' 
        ' BtnEdit
        ' 
        BtnEdit.BackColor = Color.FromArgb(CByte(30), CByte(120), CByte(220))
        BtnEdit.FlatAppearance.BorderSize = 0
        BtnEdit.FlatStyle = FlatStyle.Flat
        BtnEdit.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        BtnEdit.ForeColor = Color.White
        BtnEdit.Location = New Point(150, 12)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(130, 38)
        BtnEdit.TabIndex = 1
        BtnEdit.Text = "✏️ Edit"
        BtnEdit.UseVisualStyleBackColor = False
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = Color.FromArgb(CByte(200), CByte(40), CByte(40))
        BtnHapus.FlatAppearance.BorderSize = 0
        BtnHapus.FlatStyle = FlatStyle.Flat
        BtnHapus.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        BtnHapus.ForeColor = Color.White
        BtnHapus.Location = New Point(290, 12)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(130, 38)
        BtnHapus.TabIndex = 2
        BtnHapus.Text = "🗑️ Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' BtnDetail
        ' 
        BtnDetail.BackColor = Color.FromArgb(CByte(140), CByte(60), CByte(200))
        BtnDetail.FlatAppearance.BorderSize = 0
        BtnDetail.FlatStyle = FlatStyle.Flat
        BtnDetail.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        BtnDetail.ForeColor = Color.White
        BtnDetail.Location = New Point(430, 12)
        BtnDetail.Name = "BtnDetail"
        BtnDetail.Size = New Size(130, 38)
        BtnDetail.TabIndex = 3
        BtnDetail.Text = "📋 Detail"
        BtnDetail.UseVisualStyleBackColor = False
        ' 
        ' LblTotal
        ' 
        LblTotal.AutoSize = True
        LblTotal.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LblTotal.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        LblTotal.Location = New Point(600, 22)
        LblTotal.Name = "LblTotal"
        LblTotal.Size = New Size(131, 23)
        LblTotal.TabIndex = 4
        LblTotal.Text = "Total Koleksi: 0"
        ' 
        ' Form1
        ' 
        BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(42))
        ClientSize = New Size(900, 600)
        Controls.Add(PanelGrid)
        Controls.Add(PanelButton)
        Controls.Add(PanelSearch)
        Controls.Add(PanelHeader)
        MinimumSize = New Size(900, 600)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DX Kamen Rider Collector Manager"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelSearch.ResumeLayout(False)
        PanelSearch.PerformLayout()
        PanelGrid.ResumeLayout(False)
        CType(DgvData, ComponentModel.ISupportInitialize).EndInit()
        PanelButton.ResumeLayout(False)
        PanelButton.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblSubtitle As System.Windows.Forms.Label
    Friend WithEvents PanelSearch As System.Windows.Forms.Panel
    Friend WithEvents LblSearch As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents CmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents PanelGrid As System.Windows.Forms.Panel
    Friend WithEvents DgvData As System.Windows.Forms.DataGridView
    Friend WithEvents PanelButton As System.Windows.Forms.Panel
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnDetail As System.Windows.Forms.Button
    Friend WithEvents LblTotal As System.Windows.Forms.Label
End Class