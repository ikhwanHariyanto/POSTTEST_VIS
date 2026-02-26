<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        lblPredikat = New Label()
        txtIPSemester = New TextBox()
        txtIPKumulatif = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        lstHistory = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(154, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 0
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(151, 193)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 1
        Label2.Text = "IP Kumulatif"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(151, 257)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(53, 20)
        lblPredikat.TabIndex = 2
        lblPredikat.Text = "Label3"
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.Location = New Point(151, 163)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(200, 27)
        txtIPSemester.TabIndex = 3
        ' 
        ' txtIPKumulatif
        ' 
        txtIPKumulatif.Location = New Point(151, 216)
        txtIPKumulatif.Name = "txtIPKumulatif"
        txtIPKumulatif.Size = New Size(200, 27)
        txtIPKumulatif.TabIndex = 4
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(146, 288)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(257, 288)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 6
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lstHistory
        ' 
        lstHistory.FormattingEnabled = True
        lstHistory.Location = New Point(372, 139)
        lstHistory.Name = "lstHistory"
        lstHistory.Size = New Size(252, 164)
        lstHistory.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstHistory)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPKumulatif)
        Controls.Add(txtIPSemester)
        Controls.Add(lblPredikat)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPredikat As Label

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents txtIPKumulatif As TextBox

    Private Sub txtIPSemester_TextChanged(sender As Object, e As EventArgs) Handles txtIPSemester.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lstHistory As ListBox
End Class
