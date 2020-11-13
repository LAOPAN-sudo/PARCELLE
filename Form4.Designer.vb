<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.StatusBar1 = New PARCELLE.FlatStatusBar()
        Me.FlatTabControl1 = New PARCELLE.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btqt2 = New PARCELLE.FlatButton()
        Me.btaj2 = New PARCELLE.FlatButton()
        Me.txtnppt = New PARCELLE.FlatTextBox()
        Me.Label7 = New PARCELLE.FlatLabel()
        Me.RedemptionProgressBar1 = New PARCELLE.RedemptionProgressBar()
        Me.btqt = New PARCELLE.FlatButton()
        Me.txtspf = New PARCELLE.FlatTextBox()
        Me.Label5 = New PARCELLE.FlatLabel()
        Me.btsup = New PARCELLE.FlatButton()
        Me.btmaj = New PARCELLE.FlatButton()
        Me.txtsctr = New PARCELLE.FlatTextBox()
        Me.txtsctn = New PARCELLE.FlatTextBox()
        Me.txtlo = New PARCELLE.FlatTextBox()
        Me.txtnpuh = New PARCELLE.FlatTextBox()
        Me.Label6 = New PARCELLE.FlatLabel()
        Me.Label4 = New PARCELLE.FlatLabel()
        Me.Label3 = New PARCELLE.FlatLabel()
        Me.Label2 = New PARCELLE.FlatLabel()
        Me.txtnpc = New PARCELLE.FlatTextBox()
        Me.Label1 = New PARCELLE.FlatLabel()
        Me.btaj = New PARCELLE.FlatButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btactu = New PARCELLE.RedemptionButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.FormSkin1.Controls.Add(Me.StatusBar1)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.HeaderColor = System.Drawing.Color.DarkSlateBlue
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(600, 470)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "PARCELLE"
        '
        'StatusBar1
        '
        Me.StatusBar1.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.ForeColor = System.Drawing.Color.White
        Me.StatusBar1.Location = New System.Drawing.Point(0, 437)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.StatusBar1.ShowTimeDate = False
        Me.StatusBar1.Size = New System.Drawing.Size(600, 33)
        Me.StatusBar1.TabIndex = 4
        Me.StatusBar1.Text = "Status:"
        Me.StatusBar1.TextColor = System.Drawing.Color.White
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.DarkSlateGray
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 50)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(597, 391)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btqt2)
        Me.TabPage1.Controls.Add(Me.btaj2)
        Me.TabPage1.Controls.Add(Me.txtnppt)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.RedemptionProgressBar1)
        Me.TabPage1.Controls.Add(Me.btqt)
        Me.TabPage1.Controls.Add(Me.txtspf)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.btsup)
        Me.TabPage1.Controls.Add(Me.btmaj)
        Me.TabPage1.Controls.Add(Me.txtsctr)
        Me.TabPage1.Controls.Add(Me.txtsctn)
        Me.TabPage1.Controls.Add(Me.txtlo)
        Me.TabPage1.Controls.Add(Me.txtnpuh)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtnpc)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btaj)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(589, 343)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ENTRER"
        '
        'btqt2
        '
        Me.btqt2.BackColor = System.Drawing.Color.Transparent
        Me.btqt2.BaseColor = System.Drawing.Color.Maroon
        Me.btqt2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btqt2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btqt2.Location = New System.Drawing.Point(329, 201)
        Me.btqt2.Name = "btqt2"
        Me.btqt2.Rounded = True
        Me.btqt2.Size = New System.Drawing.Size(106, 30)
        Me.btqt2.TabIndex = 55
        Me.btqt2.Text = "Quitter"
        Me.btqt2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btaj2
        '
        Me.btaj2.BackColor = System.Drawing.Color.Transparent
        Me.btaj2.BaseColor = System.Drawing.Color.RoyalBlue
        Me.btaj2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btaj2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btaj2.Location = New System.Drawing.Point(162, 201)
        Me.btaj2.Name = "btaj2"
        Me.btaj2.Rounded = True
        Me.btaj2.Size = New System.Drawing.Size(106, 30)
        Me.btaj2.TabIndex = 54
        Me.btaj2.Text = "Ajouter"
        Me.btaj2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtnppt
        '
        Me.txtnppt.BackColor = System.Drawing.Color.Transparent
        Me.txtnppt.Location = New System.Drawing.Point(470, 106)
        Me.txtnppt.MaxLength = 10
        Me.txtnppt.Multiline = False
        Me.txtnppt.Name = "txtnppt"
        Me.txtnppt.ReadOnly = False
        Me.txtnppt.Size = New System.Drawing.Size(106, 29)
        Me.txtnppt.TabIndex = 53
        Me.txtnppt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnppt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnppt.UseSystemPasswordChar = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 17)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Numero proprietaire:"
        '
        'RedemptionProgressBar1
        '
        Me.RedemptionProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionProgressBar1.Location = New System.Drawing.Point(93, 297)
        Me.RedemptionProgressBar1.Maximum = 100
        Me.RedemptionProgressBar1.Name = "RedemptionProgressBar1"
        Me.RedemptionProgressBar1.Size = New System.Drawing.Size(404, 40)
        Me.RedemptionProgressBar1.TabIndex = 51
        Me.RedemptionProgressBar1.Text = "RedemptionProgressBar1"
        Me.RedemptionProgressBar1.Value = 0
        '
        'btqt
        '
        Me.btqt.BackColor = System.Drawing.Color.Transparent
        Me.btqt.BaseColor = System.Drawing.Color.Maroon
        Me.btqt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btqt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btqt.Location = New System.Drawing.Point(470, 252)
        Me.btqt.Name = "btqt"
        Me.btqt.Rounded = True
        Me.btqt.Size = New System.Drawing.Size(106, 30)
        Me.btqt.TabIndex = 50
        Me.btqt.Text = "Quitter"
        Me.btqt.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtspf
        '
        Me.txtspf.BackColor = System.Drawing.Color.Transparent
        Me.txtspf.Location = New System.Drawing.Point(470, 166)
        Me.txtspf.MaxLength = 5
        Me.txtspf.Multiline = False
        Me.txtspf.Name = "txtspf"
        Me.txtspf.ReadOnly = False
        Me.txtspf.Size = New System.Drawing.Size(106, 29)
        Me.txtspf.TabIndex = 49
        Me.txtspf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtspf.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtspf.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(327, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 17)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Superficie(m²):"
        '
        'btsup
        '
        Me.btsup.BackColor = System.Drawing.Color.Transparent
        Me.btsup.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btsup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btsup.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btsup.Location = New System.Drawing.Point(329, 252)
        Me.btsup.Name = "btsup"
        Me.btsup.Rounded = True
        Me.btsup.Size = New System.Drawing.Size(106, 30)
        Me.btsup.TabIndex = 47
        Me.btsup.Text = "Supprimer"
        Me.btsup.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btmaj
        '
        Me.btmaj.BackColor = System.Drawing.Color.Transparent
        Me.btmaj.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btmaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btmaj.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btmaj.Location = New System.Drawing.Point(174, 252)
        Me.btmaj.Name = "btmaj"
        Me.btmaj.Rounded = True
        Me.btmaj.Size = New System.Drawing.Size(106, 30)
        Me.btmaj.TabIndex = 46
        Me.btmaj.Text = "Modifier"
        Me.btmaj.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtsctr
        '
        Me.txtsctr.BackColor = System.Drawing.Color.Transparent
        Me.txtsctr.Location = New System.Drawing.Point(470, 106)
        Me.txtsctr.MaxLength = 3
        Me.txtsctr.Multiline = False
        Me.txtsctr.Name = "txtsctr"
        Me.txtsctr.ReadOnly = False
        Me.txtsctr.Size = New System.Drawing.Size(106, 29)
        Me.txtsctr.TabIndex = 45
        Me.txtsctr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtsctr.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsctr.UseSystemPasswordChar = False
        '
        'txtsctn
        '
        Me.txtsctn.BackColor = System.Drawing.Color.Transparent
        Me.txtsctn.Location = New System.Drawing.Point(470, 43)
        Me.txtsctn.MaxLength = 10
        Me.txtsctn.Multiline = False
        Me.txtsctn.Name = "txtsctn"
        Me.txtsctn.ReadOnly = False
        Me.txtsctn.Size = New System.Drawing.Size(106, 29)
        Me.txtsctn.TabIndex = 44
        Me.txtsctn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtsctn.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsctn.UseSystemPasswordChar = False
        '
        'txtlo
        '
        Me.txtlo.BackColor = System.Drawing.Color.Transparent
        Me.txtlo.Location = New System.Drawing.Point(162, 166)
        Me.txtlo.MaxLength = 10
        Me.txtlo.Multiline = False
        Me.txtlo.Name = "txtlo"
        Me.txtlo.ReadOnly = False
        Me.txtlo.Size = New System.Drawing.Size(106, 29)
        Me.txtlo.TabIndex = 43
        Me.txtlo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtlo.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtlo.UseSystemPasswordChar = False
        '
        'txtnpuh
        '
        Me.txtnpuh.BackColor = System.Drawing.Color.Transparent
        Me.txtnpuh.Location = New System.Drawing.Point(162, 106)
        Me.txtnpuh.MaxLength = 10
        Me.txtnpuh.Multiline = False
        Me.txtnpuh.Name = "txtnpuh"
        Me.txtnpuh.ReadOnly = False
        Me.txtnpuh.Size = New System.Drawing.Size(106, 29)
        Me.txtnpuh.TabIndex = 42
        Me.txtnpuh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnpuh.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnpuh.UseSystemPasswordChar = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(326, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Secteur:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(327, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Section:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Lot:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Numero PUH:"
        '
        'txtnpc
        '
        Me.txtnpc.BackColor = System.Drawing.Color.Transparent
        Me.txtnpc.Location = New System.Drawing.Point(162, 47)
        Me.txtnpc.MaxLength = 10
        Me.txtnpc.Multiline = False
        Me.txtnpc.Name = "txtnpc"
        Me.txtnpc.ReadOnly = False
        Me.txtnpc.Size = New System.Drawing.Size(106, 29)
        Me.txtnpc.TabIndex = 37
        Me.txtnpc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnpc.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnpc.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Numero Parcelle:"
        '
        'btaj
        '
        Me.btaj.BackColor = System.Drawing.Color.Transparent
        Me.btaj.BaseColor = System.Drawing.Color.RoyalBlue
        Me.btaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btaj.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btaj.Location = New System.Drawing.Point(26, 252)
        Me.btaj.Name = "btaj"
        Me.btaj.Rounded = True
        Me.btaj.Size = New System.Drawing.Size(106, 30)
        Me.btaj.TabIndex = 35
        Me.btaj.Text = "Ajouter"
        Me.btaj.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btactu)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(589, 343)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "VUE"
        '
        'btactu
        '
        Me.btactu.BackColor = System.Drawing.Color.Transparent
        Me.btactu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btactu.Location = New System.Drawing.Point(0, 305)
        Me.btactu.Name = "btactu"
        Me.btactu.Size = New System.Drawing.Size(593, 35)
        Me.btactu.TabIndex = 2
        Me.btactu.Text = "Actualiser"
        Me.btactu.TextAlign = PARCELLE.RedemptionButton.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(593, 307)
        Me.DataGridView1.TabIndex = 1
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 470)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
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
    Friend WithEvents FlatTabControl1 As PARCELLE.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents RedemptionProgressBar1 As PARCELLE.RedemptionProgressBar
    Friend WithEvents btqt As PARCELLE.FlatButton
    Friend WithEvents txtspf As PARCELLE.FlatTextBox
    Friend WithEvents Label5 As PARCELLE.FlatLabel
    Friend WithEvents btsup As PARCELLE.FlatButton
    Friend WithEvents btmaj As PARCELLE.FlatButton
    Friend WithEvents txtsctr As PARCELLE.FlatTextBox
    Friend WithEvents txtsctn As PARCELLE.FlatTextBox
    Friend WithEvents txtlo As PARCELLE.FlatTextBox
    Friend WithEvents txtnpuh As PARCELLE.FlatTextBox
    Friend WithEvents Label6 As PARCELLE.FlatLabel
    Friend WithEvents Label4 As PARCELLE.FlatLabel
    Friend WithEvents Label3 As PARCELLE.FlatLabel
    Friend WithEvents Label2 As PARCELLE.FlatLabel
    Friend WithEvents txtnpc As PARCELLE.FlatTextBox
    Friend WithEvents Label1 As PARCELLE.FlatLabel
    Friend WithEvents btaj As PARCELLE.FlatButton
    Friend WithEvents StatusBar1 As PARCELLE.FlatStatusBar
    Friend WithEvents btactu As PARCELLE.RedemptionButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents btqt2 As PARCELLE.FlatButton
    Friend WithEvents btaj2 As PARCELLE.FlatButton
    Friend WithEvents txtnppt As PARCELLE.FlatTextBox
    Friend WithEvents Label7 As PARCELLE.FlatLabel
End Class
