<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New PARCELLE.FormSkin()
        Me.FlatTabControl1 = New PARCELLE.FlatTabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtnpc = New PARCELLE.FlatTextBox()
        Me.FlatLabel1 = New PARCELLE.FlatLabel()
        Me.btactu = New PARCELLE.RedemptionButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btqt = New PARCELLE.FlatButton()
        Me.StatusBar1 = New PARCELLE.FlatStatusBar()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Controls.Add(Me.btqt)
        Me.FormSkin1.Controls.Add(Me.StatusBar1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.HeaderColor = System.Drawing.Color.ForestGreen
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(600, 470)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "INFORMATION"
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.LightSlateGray
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 49)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(600, 393)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.txtnpc)
        Me.TabPage2.Controls.Add(Me.FlatLabel1)
        Me.TabPage2.Controls.Add(Me.btactu)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(592, 345)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "VUE"
        '
        'txtnpc
        '
        Me.txtnpc.BackColor = System.Drawing.Color.Transparent
        Me.txtnpc.Location = New System.Drawing.Point(348, 11)
        Me.txtnpc.MaxLength = 10
        Me.txtnpc.Multiline = False
        Me.txtnpc.Name = "txtnpc"
        Me.txtnpc.ReadOnly = False
        Me.txtnpc.Size = New System.Drawing.Size(128, 29)
        Me.txtnpc.TabIndex = 3
        Me.txtnpc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnpc.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnpc.UseSystemPasswordChar = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel1.Location = New System.Drawing.Point(122, 23)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(111, 17)
        Me.FlatLabel1.TabIndex = 2
        Me.FlatLabel1.Text = "Numero Parcelle:"
        '
        'btactu
        '
        Me.btactu.BackColor = System.Drawing.Color.Transparent
        Me.btactu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btactu.Location = New System.Drawing.Point(0, 316)
        Me.btactu.Name = "btactu"
        Me.btactu.Size = New System.Drawing.Size(592, 29)
        Me.btactu.TabIndex = 1
        Me.btactu.Text = "Actualiser"
        Me.btactu.TextAlign = PARCELLE.RedemptionButton.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(592, 258)
        Me.DataGridView1.TabIndex = 0
        '
        'btqt
        '
        Me.btqt.BackColor = System.Drawing.Color.Transparent
        Me.btqt.BaseColor = System.Drawing.Color.Maroon
        Me.btqt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btqt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btqt.Location = New System.Drawing.Point(566, 12)
        Me.btqt.Name = "btqt"
        Me.btqt.Rounded = False
        Me.btqt.Size = New System.Drawing.Size(31, 23)
        Me.btqt.TabIndex = 3
        Me.btqt.Text = "X"
        Me.btqt.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'StatusBar1
        '
        Me.StatusBar1.BaseColor = System.Drawing.Color.ForestGreen
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.ForeColor = System.Drawing.Color.White
        Me.StatusBar1.Location = New System.Drawing.Point(0, 438)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.StatusBar1.ShowTimeDate = False
        Me.StatusBar1.Size = New System.Drawing.Size(600, 32)
        Me.StatusBar1.TabIndex = 0
        Me.StatusBar1.Text = "Status:"
        Me.StatusBar1.TextColor = System.Drawing.Color.White
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 470)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As PARCELLE.FormSkin
    Friend WithEvents StatusBar1 As PARCELLE.FlatStatusBar
    Friend WithEvents btqt As PARCELLE.FlatButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents FlatTabControl1 As PARCELLE.FlatTabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btactu As PARCELLE.RedemptionButton
    Friend WithEvents txtnpc As PARCELLE.FlatTextBox
    Friend WithEvents FlatLabel1 As PARCELLE.FlatLabel
End Class
