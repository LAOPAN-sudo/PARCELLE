<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New PARCELLE.FormSkin()
        Me.FlatTabControl1 = New PARCELLE.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btqt = New PARCELLE.FlatButton()
        Me.RedemptionProgressBar1 = New PARCELLE.RedemptionProgressBar()
        Me.btvt = New PARCELLE.FlatButton()
        Me.txtpdv = New PARCELLE.FlatTextBox()
        Me.FlatLabel1 = New PARCELLE.FlatLabel()
        Me.FlatLabel2 = New PARCELLE.FlatLabel()
        Me.FlatLabel3 = New PARCELLE.FlatLabel()
        Me.FlatLabel4 = New PARCELLE.FlatLabel()
        Me.FlatLabel5 = New PARCELLE.FlatLabel()
        Me.txtvt = New PARCELLE.FlatTextBox()
        Me.txtnpc = New PARCELLE.FlatTextBox()
        Me.txtnppt = New PARCELLE.FlatTextBox()
        Me.txtddv = New PARCELLE.FlatTextBox()
        Me.VUE = New System.Windows.Forms.TabPage()
        Me.btactu = New PARCELLE.RedemptionButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusBar1 = New PARCELLE.FlatStatusBar()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.VUE.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Timer2
        '
        Me.Timer2.Interval = 5
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Controls.Add(Me.StatusBar1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.HeaderColor = System.Drawing.Color.Olive
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(600, 490)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "VENTE"
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.DarkGoldenrod
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.VUE)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 47)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(600, 413)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btqt)
        Me.TabPage1.Controls.Add(Me.RedemptionProgressBar1)
        Me.TabPage1.Controls.Add(Me.btvt)
        Me.TabPage1.Controls.Add(Me.txtpdv)
        Me.TabPage1.Controls.Add(Me.FlatLabel1)
        Me.TabPage1.Controls.Add(Me.FlatLabel2)
        Me.TabPage1.Controls.Add(Me.FlatLabel3)
        Me.TabPage1.Controls.Add(Me.FlatLabel4)
        Me.TabPage1.Controls.Add(Me.FlatLabel5)
        Me.TabPage1.Controls.Add(Me.txtvt)
        Me.TabPage1.Controls.Add(Me.txtnpc)
        Me.TabPage1.Controls.Add(Me.txtnppt)
        Me.TabPage1.Controls.Add(Me.txtddv)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(592, 365)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ENTRER"
        '
        'btqt
        '
        Me.btqt.BackColor = System.Drawing.Color.Transparent
        Me.btqt.BaseColor = System.Drawing.Color.Maroon
        Me.btqt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btqt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btqt.Location = New System.Drawing.Point(338, 261)
        Me.btqt.Name = "btqt"
        Me.btqt.Rounded = True
        Me.btqt.Size = New System.Drawing.Size(106, 32)
        Me.btqt.TabIndex = 13
        Me.btqt.Text = "Quitter"
        Me.btqt.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'RedemptionProgressBar1
        '
        Me.RedemptionProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionProgressBar1.Location = New System.Drawing.Point(79, 308)
        Me.RedemptionProgressBar1.Maximum = 100
        Me.RedemptionProgressBar1.Name = "RedemptionProgressBar1"
        Me.RedemptionProgressBar1.Size = New System.Drawing.Size(423, 40)
        Me.RedemptionProgressBar1.TabIndex = 12
        Me.RedemptionProgressBar1.Text = "RedemptionProgressBar1"
        Me.RedemptionProgressBar1.Value = 0
        '
        'btvt
        '
        Me.btvt.BackColor = System.Drawing.Color.Transparent
        Me.btvt.BaseColor = System.Drawing.Color.RoyalBlue
        Me.btvt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btvt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btvt.Location = New System.Drawing.Point(138, 261)
        Me.btvt.Name = "btvt"
        Me.btvt.Rounded = True
        Me.btvt.Size = New System.Drawing.Size(106, 32)
        Me.btvt.TabIndex = 11
        Me.btvt.Text = "Vendre"
        Me.btvt.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtpdv
        '
        Me.txtpdv.BackColor = System.Drawing.Color.Transparent
        Me.txtpdv.Location = New System.Drawing.Point(469, 91)
        Me.txtpdv.MaxLength = 10
        Me.txtpdv.Multiline = False
        Me.txtpdv.Name = "txtpdv"
        Me.txtpdv.ReadOnly = False
        Me.txtpdv.Size = New System.Drawing.Size(115, 29)
        Me.txtpdv.TabIndex = 10
        Me.txtpdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpdv.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtpdv.UseSystemPasswordChar = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel1.Location = New System.Drawing.Point(6, 43)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(98, 17)
        Me.FlatLabel1.TabIndex = 1
        Me.FlatLabel1.Text = "Numero Vente:"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel2.Location = New System.Drawing.Point(8, 103)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(111, 17)
        Me.FlatLabel2.TabIndex = 2
        Me.FlatLabel2.Text = "Numero Parcelle:"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel3.Location = New System.Drawing.Point(6, 160)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(140, 17)
        Me.FlatLabel3.TabIndex = 3
        Me.FlatLabel3.Text = "Nouveau Proprietaire:"
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel4.Location = New System.Drawing.Point(347, 43)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(97, 17)
        Me.FlatLabel4.TabIndex = 4
        Me.FlatLabel4.Text = "Date de Vente:"
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel5.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel5.Location = New System.Drawing.Point(347, 103)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(92, 17)
        Me.FlatLabel5.TabIndex = 5
        Me.FlatLabel5.Text = "Prix de Vente:"
        '
        'txtvt
        '
        Me.txtvt.BackColor = System.Drawing.Color.Transparent
        Me.txtvt.Location = New System.Drawing.Point(165, 31)
        Me.txtvt.MaxLength = 10
        Me.txtvt.Multiline = False
        Me.txtvt.Name = "txtvt"
        Me.txtvt.ReadOnly = False
        Me.txtvt.Size = New System.Drawing.Size(111, 29)
        Me.txtvt.TabIndex = 6
        Me.txtvt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtvt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtvt.UseSystemPasswordChar = False
        '
        'txtnpc
        '
        Me.txtnpc.BackColor = System.Drawing.Color.Transparent
        Me.txtnpc.Location = New System.Drawing.Point(165, 91)
        Me.txtnpc.MaxLength = 10
        Me.txtnpc.Multiline = False
        Me.txtnpc.Name = "txtnpc"
        Me.txtnpc.ReadOnly = False
        Me.txtnpc.Size = New System.Drawing.Size(111, 29)
        Me.txtnpc.TabIndex = 7
        Me.txtnpc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnpc.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnpc.UseSystemPasswordChar = False
        '
        'txtnppt
        '
        Me.txtnppt.BackColor = System.Drawing.Color.Transparent
        Me.txtnppt.Location = New System.Drawing.Point(165, 148)
        Me.txtnppt.MaxLength = 10
        Me.txtnppt.Multiline = False
        Me.txtnppt.Name = "txtnppt"
        Me.txtnppt.ReadOnly = False
        Me.txtnppt.Size = New System.Drawing.Size(111, 29)
        Me.txtnppt.TabIndex = 8
        Me.txtnppt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnppt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnppt.UseSystemPasswordChar = False
        '
        'txtddv
        '
        Me.txtddv.BackColor = System.Drawing.Color.Transparent
        Me.txtddv.Location = New System.Drawing.Point(471, 31)
        Me.txtddv.MaxLength = 10
        Me.txtddv.Multiline = False
        Me.txtddv.Name = "txtddv"
        Me.txtddv.ReadOnly = False
        Me.txtddv.Size = New System.Drawing.Size(115, 29)
        Me.txtddv.TabIndex = 9
        Me.txtddv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtddv.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtddv.UseSystemPasswordChar = False
        '
        'VUE
        '
        Me.VUE.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.VUE.Controls.Add(Me.btactu)
        Me.VUE.Controls.Add(Me.DataGridView1)
        Me.VUE.Location = New System.Drawing.Point(4, 44)
        Me.VUE.Name = "VUE"
        Me.VUE.Padding = New System.Windows.Forms.Padding(3)
        Me.VUE.Size = New System.Drawing.Size(592, 365)
        Me.VUE.TabIndex = 1
        Me.VUE.Text = "VUE"
        '
        'btactu
        '
        Me.btactu.BackColor = System.Drawing.Color.Transparent
        Me.btactu.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btactu.Location = New System.Drawing.Point(-4, 336)
        Me.btactu.Name = "btactu"
        Me.btactu.Size = New System.Drawing.Size(600, 29)
        Me.btactu.TabIndex = 1
        Me.btactu.Text = "Actualiser"
        Me.btactu.TextAlign = PARCELLE.RedemptionButton.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(592, 336)
        Me.DataGridView1.TabIndex = 0
        '
        'StatusBar1
        '
        Me.StatusBar1.BaseColor = System.Drawing.Color.Olive
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.ForeColor = System.Drawing.Color.White
        Me.StatusBar1.Location = New System.Drawing.Point(0, 459)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.StatusBar1.ShowTimeDate = False
        Me.StatusBar1.Size = New System.Drawing.Size(600, 31)
        Me.StatusBar1.TabIndex = 0
        Me.StatusBar1.Text = "Status:"
        Me.StatusBar1.TextColor = System.Drawing.Color.White
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 490)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.VUE.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As PARCELLE.FormSkin
    Friend WithEvents FlatTabControl1 As PARCELLE.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents VUE As System.Windows.Forms.TabPage
    Friend WithEvents btactu As PARCELLE.RedemptionButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StatusBar1 As PARCELLE.FlatStatusBar
    Friend WithEvents FlatLabel1 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel2 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel3 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel4 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel5 As PARCELLE.FlatLabel
    Friend WithEvents txtvt As PARCELLE.FlatTextBox
    Friend WithEvents txtnpc As PARCELLE.FlatTextBox
    Friend WithEvents txtnppt As PARCELLE.FlatTextBox
    Friend WithEvents txtddv As PARCELLE.FlatTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents txtpdv As PARCELLE.FlatTextBox
    Friend WithEvents RedemptionProgressBar1 As PARCELLE.RedemptionProgressBar
    Friend WithEvents btvt As PARCELLE.FlatButton
    Friend WithEvents btqt As PARCELLE.FlatButton
End Class
