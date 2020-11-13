<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.txtattr = New PARCELLE.FlatTextBox()
        Me.FlatLabel5 = New PARCELLE.FlatLabel()
        Me.btmaj = New PARCELLE.FlatButton()
        Me.btqt = New PARCELLE.FlatButton()
        Me.RedemptionProgressBar1 = New PARCELLE.RedemptionProgressBar()
        Me.btaff = New PARCELLE.FlatButton()
        Me.ComboBox1 = New PARCELLE.FlatComboBox()
        Me.txtdaff = New PARCELLE.FlatTextBox()
        Me.txtnpc = New PARCELLE.FlatTextBox()
        Me.txtnaff = New PARCELLE.FlatTextBox()
        Me.FlatLabel4 = New PARCELLE.FlatLabel()
        Me.FlatLabel3 = New PARCELLE.FlatLabel()
        Me.FlatLabel2 = New PARCELLE.FlatLabel()
        Me.FlatLabel1 = New PARCELLE.FlatLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btactu = New PARCELLE.RedemptionButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btactu2 = New PARCELLE.RedemptionButton()
        Me.StatusBar1 = New PARCELLE.FlatStatusBar()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FormSkin1.HeaderColor = System.Drawing.Color.SteelBlue
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(600, 470)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "AFFECTATION"
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.SlateGray
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Controls.Add(Me.TabPage3)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 51)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(600, 392)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.txtattr)
        Me.TabPage1.Controls.Add(Me.FlatLabel5)
        Me.TabPage1.Controls.Add(Me.btmaj)
        Me.TabPage1.Controls.Add(Me.btqt)
        Me.TabPage1.Controls.Add(Me.RedemptionProgressBar1)
        Me.TabPage1.Controls.Add(Me.btaff)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.txtdaff)
        Me.TabPage1.Controls.Add(Me.txtnpc)
        Me.TabPage1.Controls.Add(Me.txtnaff)
        Me.TabPage1.Controls.Add(Me.FlatLabel4)
        Me.TabPage1.Controls.Add(Me.FlatLabel3)
        Me.TabPage1.Controls.Add(Me.FlatLabel2)
        Me.TabPage1.Controls.Add(Me.FlatLabel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(592, 344)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ENTRER"
        '
        'txtattr
        '
        Me.txtattr.BackColor = System.Drawing.Color.Transparent
        Me.txtattr.Location = New System.Drawing.Point(155, 177)
        Me.txtattr.MaxLength = 10
        Me.txtattr.Multiline = False
        Me.txtattr.Name = "txtattr"
        Me.txtattr.ReadOnly = False
        Me.txtattr.Size = New System.Drawing.Size(121, 29)
        Me.txtattr.TabIndex = 25
        Me.txtattr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtattr.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtattr.UseSystemPasswordChar = False
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel5.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel5.Location = New System.Drawing.Point(15, 189)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(134, 17)
        Me.FlatLabel5.TabIndex = 24
        Me.FlatLabel5.Text = "Numero Attributaire:"
        '
        'btmaj
        '
        Me.btmaj.BackColor = System.Drawing.Color.Transparent
        Me.btmaj.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btmaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btmaj.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btmaj.Location = New System.Drawing.Point(246, 260)
        Me.btmaj.Name = "btmaj"
        Me.btmaj.Rounded = True
        Me.btmaj.Size = New System.Drawing.Size(106, 32)
        Me.btmaj.TabIndex = 23
        Me.btmaj.Text = "Modifier"
        Me.btmaj.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btqt
        '
        Me.btqt.BackColor = System.Drawing.Color.Transparent
        Me.btqt.BaseColor = System.Drawing.Color.Maroon
        Me.btqt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btqt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btqt.Location = New System.Drawing.Point(400, 260)
        Me.btqt.Name = "btqt"
        Me.btqt.Rounded = True
        Me.btqt.Size = New System.Drawing.Size(106, 32)
        Me.btqt.TabIndex = 22
        Me.btqt.Text = "Quitter"
        Me.btqt.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'RedemptionProgressBar1
        '
        Me.RedemptionProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionProgressBar1.Location = New System.Drawing.Point(95, 298)
        Me.RedemptionProgressBar1.Maximum = 100
        Me.RedemptionProgressBar1.Name = "RedemptionProgressBar1"
        Me.RedemptionProgressBar1.Size = New System.Drawing.Size(411, 43)
        Me.RedemptionProgressBar1.TabIndex = 21
        Me.RedemptionProgressBar1.Text = "RedemptionProgressBar1"
        Me.RedemptionProgressBar1.Value = 0
        '
        'btaff
        '
        Me.btaff.BackColor = System.Drawing.Color.Transparent
        Me.btaff.BaseColor = System.Drawing.Color.RoyalBlue
        Me.btaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btaff.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btaff.Location = New System.Drawing.Point(95, 260)
        Me.btaff.Name = "btaff"
        Me.btaff.Rounded = True
        Me.btaff.Size = New System.Drawing.Size(106, 32)
        Me.btaff.TabIndex = 20
        Me.btaff.Text = "Attribuer"
        Me.btaff.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ComboBox1.ItemHeight = 18
        Me.ComboBox1.Items.AddRange(New Object() {"HERITAGE", "DON", "LOTERIE"})
        Me.ComboBox1.Location = New System.Drawing.Point(458, 105)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 19
        '
        'txtdaff
        '
        Me.txtdaff.BackColor = System.Drawing.Color.Transparent
        Me.txtdaff.Location = New System.Drawing.Point(458, 15)
        Me.txtdaff.MaxLength = 10
        Me.txtdaff.Multiline = False
        Me.txtdaff.Name = "txtdaff"
        Me.txtdaff.ReadOnly = False
        Me.txtdaff.Size = New System.Drawing.Size(121, 29)
        Me.txtdaff.TabIndex = 18
        Me.txtdaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtdaff.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdaff.UseSystemPasswordChar = False
        '
        'txtnpc
        '
        Me.txtnpc.BackColor = System.Drawing.Color.Transparent
        Me.txtnpc.Location = New System.Drawing.Point(155, 105)
        Me.txtnpc.MaxLength = 10
        Me.txtnpc.Multiline = False
        Me.txtnpc.Name = "txtnpc"
        Me.txtnpc.ReadOnly = False
        Me.txtnpc.Size = New System.Drawing.Size(121, 29)
        Me.txtnpc.TabIndex = 17
        Me.txtnpc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnpc.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnpc.UseSystemPasswordChar = False
        '
        'txtnaff
        '
        Me.txtnaff.BackColor = System.Drawing.Color.Transparent
        Me.txtnaff.Location = New System.Drawing.Point(155, 15)
        Me.txtnaff.MaxLength = 10
        Me.txtnaff.Multiline = False
        Me.txtnaff.Name = "txtnaff"
        Me.txtnaff.ReadOnly = False
        Me.txtnaff.Size = New System.Drawing.Size(121, 29)
        Me.txtnaff.TabIndex = 16
        Me.txtnaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnaff.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnaff.UseSystemPasswordChar = False
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel4.Location = New System.Drawing.Point(333, 117)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(112, 17)
        Me.FlatLabel4.TabIndex = 15
        Me.FlatLabel4.Text = "Motif Affectation:"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel3.Location = New System.Drawing.Point(333, 27)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(110, 17)
        Me.FlatLabel3.TabIndex = 14
        Me.FlatLabel3.Text = "Date Affectation:"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel2.Location = New System.Drawing.Point(15, 117)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(111, 17)
        Me.FlatLabel2.TabIndex = 13
        Me.FlatLabel2.Text = "Numero Parcelle:"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel1.Location = New System.Drawing.Point(15, 27)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(129, 17)
        Me.FlatLabel1.TabIndex = 12
        Me.FlatLabel1.Text = "Numero Affectation:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btactu)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(592, 344)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "VUE1"
        '
        'btactu
        '
        Me.btactu.BackColor = System.Drawing.Color.Transparent
        Me.btactu.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btactu.Location = New System.Drawing.Point(0, 313)
        Me.btactu.Name = "btactu"
        Me.btactu.Size = New System.Drawing.Size(592, 31)
        Me.btactu.TabIndex = 1
        Me.btactu.Text = "Actualiser"
        Me.btactu.TextAlign = PARCELLE.RedemptionButton.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(592, 314)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Controls.Add(Me.btactu2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(592, 344)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "VUE2"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(592, 316)
        Me.DataGridView2.TabIndex = 1
        '
        'btactu2
        '
        Me.btactu2.BackColor = System.Drawing.Color.Transparent
        Me.btactu2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btactu2.Location = New System.Drawing.Point(-1, 315)
        Me.btactu2.Name = "btactu2"
        Me.btactu2.Size = New System.Drawing.Size(593, 29)
        Me.btactu2.TabIndex = 0
        Me.btactu2.Text = "Actualiser"
        Me.btactu2.TextAlign = PARCELLE.RedemptionButton.HorizontalAlignment.Center
        '
        'StatusBar1
        '
        Me.StatusBar1.BaseColor = System.Drawing.Color.SteelBlue
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.ForeColor = System.Drawing.Color.White
        Me.StatusBar1.Location = New System.Drawing.Point(0, 440)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.StatusBar1.ShowTimeDate = False
        Me.StatusBar1.Size = New System.Drawing.Size(600, 30)
        Me.StatusBar1.TabIndex = 0
        Me.StatusBar1.Text = "Status:"
        Me.StatusBar1.TextColor = System.Drawing.Color.White
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 470)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As PARCELLE.FormSkin
    Friend WithEvents StatusBar1 As PARCELLE.FlatStatusBar
    Friend WithEvents FlatTabControl1 As PARCELLE.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btqt As PARCELLE.FlatButton
    Friend WithEvents RedemptionProgressBar1 As PARCELLE.RedemptionProgressBar
    Friend WithEvents btaff As PARCELLE.FlatButton
    Friend WithEvents ComboBox1 As PARCELLE.FlatComboBox
    Friend WithEvents txtdaff As PARCELLE.FlatTextBox
    Friend WithEvents txtnpc As PARCELLE.FlatTextBox
    Friend WithEvents txtnaff As PARCELLE.FlatTextBox
    Friend WithEvents FlatLabel4 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel3 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel2 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel1 As PARCELLE.FlatLabel
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btactu As PARCELLE.RedemptionButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btactu2 As PARCELLE.RedemptionButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents btmaj As PARCELLE.FlatButton
    Friend WithEvents txtattr As PARCELLE.FlatTextBox
    Friend WithEvents FlatLabel5 As PARCELLE.FlatLabel
End Class
