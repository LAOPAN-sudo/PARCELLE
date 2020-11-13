<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.RedemptionProgressBar1 = New PARCELLE.RedemptionProgressBar()
        Me.btquit = New PARCELLE.FlatButton()
        Me.btsup = New PARCELLE.FlatButton()
        Me.btmaj = New PARCELLE.FlatButton()
        Me.txtad = New PARCELLE.FlatTextBox()
        Me.txtsex = New PARCELLE.FlatTextBox()
        Me.txtddn = New PARCELLE.FlatTextBox()
        Me.txtpnm = New PARCELLE.FlatTextBox()
        Me.txtnm = New PARCELLE.FlatTextBox()
        Me.FlatLabel6 = New PARCELLE.FlatLabel()
        Me.FlatLabel5 = New PARCELLE.FlatLabel()
        Me.FlatLabel4 = New PARCELLE.FlatLabel()
        Me.FlatLabel3 = New PARCELLE.FlatLabel()
        Me.FlatLabel2 = New PARCELLE.FlatLabel()
        Me.btaj = New PARCELLE.FlatButton()
        Me.txtnppt = New PARCELLE.FlatTextBox()
        Me.FlatLabel1 = New PARCELLE.FlatLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btactu = New PARCELLE.RedemptionButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusBar1 = New PARCELLE.FlatStatusBar()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(584, 431)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "PROPRIETAIRE"
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.Gray
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 50)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(581, 350)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.RedemptionProgressBar1)
        Me.TabPage1.Controls.Add(Me.btquit)
        Me.TabPage1.Controls.Add(Me.btsup)
        Me.TabPage1.Controls.Add(Me.btmaj)
        Me.TabPage1.Controls.Add(Me.txtad)
        Me.TabPage1.Controls.Add(Me.txtsex)
        Me.TabPage1.Controls.Add(Me.txtddn)
        Me.TabPage1.Controls.Add(Me.txtpnm)
        Me.TabPage1.Controls.Add(Me.txtnm)
        Me.TabPage1.Controls.Add(Me.FlatLabel6)
        Me.TabPage1.Controls.Add(Me.FlatLabel5)
        Me.TabPage1.Controls.Add(Me.FlatLabel4)
        Me.TabPage1.Controls.Add(Me.FlatLabel3)
        Me.TabPage1.Controls.Add(Me.FlatLabel2)
        Me.TabPage1.Controls.Add(Me.btaj)
        Me.TabPage1.Controls.Add(Me.txtnppt)
        Me.TabPage1.Controls.Add(Me.FlatLabel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(573, 302)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ENTRER"
        '
        'RedemptionProgressBar1
        '
        Me.RedemptionProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionProgressBar1.Location = New System.Drawing.Point(93, 257)
        Me.RedemptionProgressBar1.Maximum = 100
        Me.RedemptionProgressBar1.Name = "RedemptionProgressBar1"
        Me.RedemptionProgressBar1.Size = New System.Drawing.Size(389, 39)
        Me.RedemptionProgressBar1.TabIndex = 16
        Me.RedemptionProgressBar1.Text = "RedemptionProgressBar1"
        Me.RedemptionProgressBar1.Value = 0
        '
        'btquit
        '
        Me.btquit.BackColor = System.Drawing.Color.Transparent
        Me.btquit.BaseColor = System.Drawing.Color.Maroon
        Me.btquit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btquit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btquit.Location = New System.Drawing.Point(427, 213)
        Me.btquit.Name = "btquit"
        Me.btquit.Rounded = True
        Me.btquit.Size = New System.Drawing.Size(95, 30)
        Me.btquit.TabIndex = 15
        Me.btquit.Text = "Quitter"
        Me.btquit.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btsup
        '
        Me.btsup.BackColor = System.Drawing.Color.Transparent
        Me.btsup.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btsup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btsup.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btsup.Location = New System.Drawing.Point(304, 213)
        Me.btsup.Name = "btsup"
        Me.btsup.Rounded = True
        Me.btsup.Size = New System.Drawing.Size(95, 30)
        Me.btsup.TabIndex = 14
        Me.btsup.Text = "Supprimer"
        Me.btsup.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btmaj
        '
        Me.btmaj.BackColor = System.Drawing.Color.Transparent
        Me.btmaj.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btmaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btmaj.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btmaj.Location = New System.Drawing.Point(172, 213)
        Me.btmaj.Name = "btmaj"
        Me.btmaj.Rounded = True
        Me.btmaj.Size = New System.Drawing.Size(95, 30)
        Me.btmaj.TabIndex = 13
        Me.btmaj.Text = "Modifier"
        Me.btmaj.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtad
        '
        Me.txtad.BackColor = System.Drawing.Color.Transparent
        Me.txtad.Location = New System.Drawing.Point(451, 145)
        Me.txtad.MaxLength = 50
        Me.txtad.Multiline = False
        Me.txtad.Name = "txtad"
        Me.txtad.ReadOnly = False
        Me.txtad.Size = New System.Drawing.Size(106, 29)
        Me.txtad.TabIndex = 12
        Me.txtad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtad.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtad.UseSystemPasswordChar = False
        '
        'txtsex
        '
        Me.txtsex.BackColor = System.Drawing.Color.Transparent
        Me.txtsex.Location = New System.Drawing.Point(451, 94)
        Me.txtsex.MaxLength = 1
        Me.txtsex.Multiline = False
        Me.txtsex.Name = "txtsex"
        Me.txtsex.ReadOnly = False
        Me.txtsex.Size = New System.Drawing.Size(106, 29)
        Me.txtsex.TabIndex = 11
        Me.txtsex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtsex.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsex.UseSystemPasswordChar = False
        '
        'txtddn
        '
        Me.txtddn.BackColor = System.Drawing.Color.Transparent
        Me.txtddn.Location = New System.Drawing.Point(451, 37)
        Me.txtddn.MaxLength = 10
        Me.txtddn.Multiline = False
        Me.txtddn.Name = "txtddn"
        Me.txtddn.ReadOnly = False
        Me.txtddn.Size = New System.Drawing.Size(106, 29)
        Me.txtddn.TabIndex = 10
        Me.txtddn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtddn.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtddn.UseSystemPasswordChar = False
        '
        'txtpnm
        '
        Me.txtpnm.BackColor = System.Drawing.Color.Transparent
        Me.txtpnm.Location = New System.Drawing.Point(145, 145)
        Me.txtpnm.MaxLength = 30
        Me.txtpnm.Multiline = False
        Me.txtpnm.Name = "txtpnm"
        Me.txtpnm.ReadOnly = False
        Me.txtpnm.Size = New System.Drawing.Size(106, 29)
        Me.txtpnm.TabIndex = 9
        Me.txtpnm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpnm.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtpnm.UseSystemPasswordChar = False
        '
        'txtnm
        '
        Me.txtnm.BackColor = System.Drawing.Color.Transparent
        Me.txtnm.Location = New System.Drawing.Point(145, 94)
        Me.txtnm.MaxLength = 20
        Me.txtnm.Multiline = False
        Me.txtnm.Name = "txtnm"
        Me.txtnm.ReadOnly = False
        Me.txtnm.Size = New System.Drawing.Size(106, 29)
        Me.txtnm.TabIndex = 8
        Me.txtnm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnm.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnm.UseSystemPasswordChar = False
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel6.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel6.Location = New System.Drawing.Point(310, 157)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(56, 17)
        Me.FlatLabel6.TabIndex = 7
        Me.FlatLabel6.Text = "Adresse:"
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel5.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel5.Location = New System.Drawing.Point(310, 106)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(39, 17)
        Me.FlatLabel5.TabIndex = 6
        Me.FlatLabel5.Text = "Sexe:"
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel4.Location = New System.Drawing.Point(310, 49)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(119, 17)
        Me.FlatLabel4.TabIndex = 5
        Me.FlatLabel4.Text = "Date de naissance:"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel3.Location = New System.Drawing.Point(8, 161)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(57, 17)
        Me.FlatLabel3.TabIndex = 4
        Me.FlatLabel3.Text = "Prenom:"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel2.Location = New System.Drawing.Point(8, 110)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(39, 17)
        Me.FlatLabel2.TabIndex = 3
        Me.FlatLabel2.Text = "Nom:"
        '
        'btaj
        '
        Me.btaj.BackColor = System.Drawing.Color.Transparent
        Me.btaj.BaseColor = System.Drawing.Color.RoyalBlue
        Me.btaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btaj.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btaj.Location = New System.Drawing.Point(43, 213)
        Me.btaj.Name = "btaj"
        Me.btaj.Rounded = True
        Me.btaj.Size = New System.Drawing.Size(95, 30)
        Me.btaj.TabIndex = 2
        Me.btaj.Text = "Ajouter"
        Me.btaj.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtnppt
        '
        Me.txtnppt.BackColor = System.Drawing.Color.Transparent
        Me.txtnppt.Location = New System.Drawing.Point(145, 37)
        Me.txtnppt.MaxLength = 10
        Me.txtnppt.Multiline = False
        Me.txtnppt.Name = "txtnppt"
        Me.txtnppt.ReadOnly = False
        Me.txtnppt.Size = New System.Drawing.Size(106, 29)
        Me.txtnppt.TabIndex = 1
        Me.txtnppt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnppt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnppt.UseSystemPasswordChar = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel1.Location = New System.Drawing.Point(8, 49)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(134, 17)
        Me.FlatLabel1.TabIndex = 0
        Me.FlatLabel1.Text = "Numero Proprietaire:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btactu)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(573, 302)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "VUE"
        '
        'btactu
        '
        Me.btactu.BackColor = System.Drawing.Color.Transparent
        Me.btactu.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btactu.Location = New System.Drawing.Point(0, 273)
        Me.btactu.Name = "btactu"
        Me.btactu.Size = New System.Drawing.Size(573, 29)
        Me.btactu.TabIndex = 1
        Me.btactu.Text = "Actualiser"
        Me.btactu.TextAlign = PARCELLE.RedemptionButton.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(573, 273)
        Me.DataGridView1.TabIndex = 0
        '
        'StatusBar1
        '
        Me.StatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.ForeColor = System.Drawing.Color.White
        Me.StatusBar1.Location = New System.Drawing.Point(0, 402)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.StatusBar1.ShowTimeDate = False
        Me.StatusBar1.Size = New System.Drawing.Size(584, 29)
        Me.StatusBar1.TabIndex = 0
        Me.StatusBar1.Text = "Status:"
        Me.StatusBar1.TextColor = System.Drawing.Color.White
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 431)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As PARCELLE.FormSkin
    Friend WithEvents StatusBar1 As PARCELLE.FlatStatusBar
    Friend WithEvents FlatTabControl1 As PARCELLE.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents FlatLabel1 As PARCELLE.FlatLabel
    Friend WithEvents btaj As PARCELLE.FlatButton
    Friend WithEvents txtnppt As PARCELLE.FlatTextBox
    Friend WithEvents FlatLabel6 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel5 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel4 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel3 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel2 As PARCELLE.FlatLabel
    Friend WithEvents RedemptionProgressBar1 As PARCELLE.RedemptionProgressBar
    Friend WithEvents btquit As PARCELLE.FlatButton
    Friend WithEvents btsup As PARCELLE.FlatButton
    Friend WithEvents btmaj As PARCELLE.FlatButton
    Friend WithEvents txtad As PARCELLE.FlatTextBox
    Friend WithEvents txtsex As PARCELLE.FlatTextBox
    Friend WithEvents txtddn As PARCELLE.FlatTextBox
    Friend WithEvents txtpnm As PARCELLE.FlatTextBox
    Friend WithEvents txtnm As PARCELLE.FlatTextBox
    Friend WithEvents btactu As PARCELLE.RedemptionButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
End Class
