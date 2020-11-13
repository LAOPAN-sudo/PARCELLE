<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.FormSkin1 = New PARCELLE.FormSkin()
        Me.btqt = New PARCELLE.FlatButton()
        Me.FlatTabControl1 = New PARCELLE.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RedemptionTabControl1 = New PARCELLE.RedemptionTabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BT9 = New PARCELLE.RedemptionRoundButton()
        Me.BT8 = New PARCELLE.RedemptionRoundButton()
        Me.bt7 = New PARCELLE.RedemptionRoundButton()
        Me.bt6 = New PARCELLE.RedemptionRoundButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.bt5 = New PARCELLE.RedemptionRoundButton()
        Me.bt4 = New PARCELLE.RedemptionRoundButton()
        Me.bt3 = New PARCELLE.RedemptionRoundButton()
        Me.bt2 = New PARCELLE.RedemptionRoundButton()
        Me.bt1 = New PARCELLE.RedemptionRoundButton()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.BT12 = New PARCELLE.RedemptionRoundButton()
        Me.BT11 = New PARCELLE.RedemptionRoundButton()
        Me.BT10 = New PARCELLE.RedemptionRoundButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusBar1 = New PARCELLE.FlatStatusBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.RedemptionTabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.btqt)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Controls.Add(Me.StatusBar1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(600, 470)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "STATISTIQUES"
        '
        'btqt
        '
        Me.btqt.BackColor = System.Drawing.Color.Transparent
        Me.btqt.BaseColor = System.Drawing.Color.Maroon
        Me.btqt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btqt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btqt.Location = New System.Drawing.Point(557, 12)
        Me.btqt.Name = "btqt"
        Me.btqt.Rounded = False
        Me.btqt.Size = New System.Drawing.Size(31, 23)
        Me.btqt.TabIndex = 4
        Me.btqt.Text = "X"
        Me.btqt.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 50)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(600, 389)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.RedemptionTabControl1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(592, 341)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "STATS"
        '
        'RedemptionTabControl1
        '
        Me.RedemptionTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.RedemptionTabControl1.BackgroundNoise = False
        Me.RedemptionTabControl1.Controls.Add(Me.TabPage4)
        Me.RedemptionTabControl1.Controls.Add(Me.TabPage3)
        Me.RedemptionTabControl1.Controls.Add(Me.TabPage5)
        Me.RedemptionTabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionTabControl1.ItemSize = New System.Drawing.Size(35, 100)
        Me.RedemptionTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.RedemptionTabControl1.Multiline = True
        Me.RedemptionTabControl1.Name = "RedemptionTabControl1"
        Me.RedemptionTabControl1.SelectedIndex = 0
        Me.RedemptionTabControl1.Size = New System.Drawing.Size(592, 338)
        Me.RedemptionTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.RedemptionTabControl1.TabIndex = 0
        Me.RedemptionTabControl1.TextAlign = PARCELLE.RedemptionTabControl.HorizontalAlignments.Left
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.BT9)
        Me.TabPage4.Controls.Add(Me.BT8)
        Me.TabPage4.Controls.Add(Me.bt7)
        Me.TabPage4.Controls.Add(Me.bt6)
        Me.TabPage4.Location = New System.Drawing.Point(104, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(484, 330)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "PROPRIETAIRE"
        '
        'BT9
        '
        Me.BT9.BackColor = System.Drawing.Color.Transparent
        Me.BT9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT9.Location = New System.Drawing.Point(0, 264)
        Me.BT9.Name = "BT9"
        Me.BT9.Size = New System.Drawing.Size(484, 41)
        Me.BT9.TabIndex = 4
        Me.BT9.Text = "PROPRIETAIRE DE SEXE FEMININ"
        Me.BT9.TextAlign = PARCELLE.RedemptionRoundButton.HorizontalAlignment.Center
        '
        'BT8
        '
        Me.BT8.BackColor = System.Drawing.Color.Transparent
        Me.BT8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT8.Location = New System.Drawing.Point(0, 182)
        Me.BT8.Name = "BT8"
        Me.BT8.Size = New System.Drawing.Size(484, 41)
        Me.BT8.TabIndex = 3
        Me.BT8.Text = "DATE ACHAT PARCELLE EN 2010"
        Me.BT8.TextAlign = PARCELLE.RedemptionRoundButton.HorizontalAlignment.Center
        '
        'bt7
        '
        Me.bt7.BackColor = System.Drawing.Color.Transparent
        Me.bt7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt7.Location = New System.Drawing.Point(0, 94)
        Me.bt7.Name = "bt7"
        Me.bt7.Size = New System.Drawing.Size(484, 41)
        Me.bt7.TabIndex = 2
        Me.bt7.Text = "NOMBRE DE PROPRIETAIRE"
        Me.bt7.TextAlign = PARCELLE.RedemptionRoundButton.HorizontalAlignment.Center
        '
        'bt6
        '
        Me.bt6.BackColor = System.Drawing.Color.Transparent
        Me.bt6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt6.Location = New System.Drawing.Point(0, 6)
        Me.bt6.Name = "bt6"
        Me.bt6.Size = New System.Drawing.Size(484, 41)
        Me.bt6.TabIndex = 1
        Me.bt6.Text = "PROPRIETAIRE DE SEXE MASCULIN"
        Me.bt6.TextAlign = PARCELLE.RedemptionRoundButton.HorizontalAlignment.Center
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.bt5)
        Me.TabPage3.Controls.Add(Me.bt4)
        Me.TabPage3.Controls.Add(Me.bt3)
        Me.TabPage3.Controls.Add(Me.bt2)
        Me.TabPage3.Controls.Add(Me.bt1)
        Me.TabPage3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(104, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(484, 330)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "PARCELLE"
        '
        'bt5
        '
        Me.bt5.BackColor = System.Drawing.Color.Transparent
        Me.bt5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt5.Location = New System.Drawing.Point(-2, 283)
        Me.bt5.Name = "bt5"
        Me.bt5.Size = New System.Drawing.Size(484, 41)
        Me.bt5.TabIndex = 4
        Me.bt5.Text = "SUPERFICIE MAXIMUM"
        Me.bt5.TextAlign = PARCELLE.RedemptionRoundButton.HorizontalAlignment.Center
        '
        'bt4
        '
        Me.bt4.BackColor = System.Drawing.Color.Transparent
        Me.bt4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt4.Location = New System.Drawing.Point(0, 209)
        Me.bt4.Name = "bt4"
        Me.bt4.Size = New System.Drawing.Size(484, 41)
        Me.bt4.TabIndex = 3
        Me.bt4.Text = "SUPERFICIE MINIMUM"
        Me.bt4.TextAlign = PARCELLE.RedemptionRoundButton.HorizontalAlignment.Center
        '
        'bt3
        '
        Me.bt3.BackColor = System.Drawing.Color.Transparent
        Me.bt3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt3.Location = New System.Drawing.Point(1, 138)
        Me.bt3.Name = "bt3"
        Me.bt3.Size = New System.Drawing.Size(484, 41)
        Me.bt3.TabIndex = 2
        Me.bt3.Text = "NOMBRE DE PARCELLE"
        Me.bt3.TextAlign = PARCELLE.RedemptionRoundButton.HorizontalAlignment.Center
        '
        'bt2
        '
        Me.bt2.BackColor = System.Drawing.Color.Transparent
        Me.bt2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt2.Location = New System.Drawing.Point(1, 71)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(484, 41)
        Me.bt2.TabIndex = 1
        Me.bt2.Text = "PARCELLE SANS PROPRIETAIRE"
        Me.bt2.TextAlign = PARCELLE.RedemptionRoundButton.HorizontalAlignment.Center
        '
        'bt1
        '
        Me.bt1.BackColor = System.Drawing.Color.Transparent
        Me.bt1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt1.Location = New System.Drawing.Point(0, 0)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(484, 41)
        Me.bt1.TabIndex = 0
        Me.bt1.Text = "PARCELLE AVEC PROPRIETAIRE"
        Me.bt1.TextAlign = PARCELLE.RedemptionRoundButton.HorizontalAlignment.Center
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.BT12)
        Me.TabPage5.Controls.Add(Me.BT11)
        Me.TabPage5.Controls.Add(Me.BT10)
        Me.TabPage5.Location = New System.Drawing.Point(104, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(484, 330)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "VENTE"
        '
        'BT12
        '
        Me.BT12.BackColor = System.Drawing.Color.Transparent
        Me.BT12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT12.Location = New System.Drawing.Point(0, 289)
        Me.BT12.Name = "BT12"
        Me.BT12.Size = New System.Drawing.Size(484, 41)
        Me.BT12.TabIndex = 4
        Me.BT12.Text = "VENTE PARCELLE EN 2010"
        Me.BT12.TextAlign = PARCELLE.RedemptionRoundButton.HorizontalAlignment.Center
        '
        'BT11
        '
        Me.BT11.BackColor = System.Drawing.Color.Transparent
        Me.BT11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT11.Location = New System.Drawing.Point(0, 145)
        Me.BT11.Name = "BT11"
        Me.BT11.Size = New System.Drawing.Size(484, 41)
        Me.BT11.TabIndex = 3
        Me.BT11.Text = "PRIX DE VENTE SUPERIEUR A 3000000"
        Me.BT11.TextAlign = PARCELLE.RedemptionRoundButton.HorizontalAlignment.Center
        '
        'BT10
        '
        Me.BT10.BackColor = System.Drawing.Color.Transparent
        Me.BT10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT10.Location = New System.Drawing.Point(0, 2)
        Me.BT10.Name = "BT10"
        Me.BT10.Size = New System.Drawing.Size(484, 41)
        Me.BT10.TabIndex = 2
        Me.BT10.Text = "PROPRIETAIRE QUI ONT ACHETE DES PARCELLES"
        Me.BT10.TextAlign = PARCELLE.RedemptionRoundButton.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(592, 341)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "VUE"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(592, 341)
        Me.DataGridView1.TabIndex = 0
        '
        'StatusBar1
        '
        Me.StatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.ForeColor = System.Drawing.Color.White
        Me.StatusBar1.Location = New System.Drawing.Point(0, 437)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.StatusBar1.ShowTimeDate = False
        Me.StatusBar1.Size = New System.Drawing.Size(600, 33)
        Me.StatusBar1.TabIndex = 0
        Me.StatusBar1.Text = "Status:"
        Me.StatusBar1.TextColor = System.Drawing.Color.White
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 470)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form9"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.RedemptionTabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As PARCELLE.FormSkin
    Friend WithEvents FlatTabControl1 As PARCELLE.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents StatusBar1 As PARCELLE.FlatStatusBar
    Friend WithEvents RedemptionTabControl1 As PARCELLE.RedemptionTabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents bt5 As PARCELLE.RedemptionRoundButton
    Friend WithEvents bt4 As PARCELLE.RedemptionRoundButton
    Friend WithEvents bt3 As PARCELLE.RedemptionRoundButton
    Friend WithEvents bt2 As PARCELLE.RedemptionRoundButton
    Friend WithEvents bt1 As PARCELLE.RedemptionRoundButton
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btqt As PARCELLE.FlatButton
    Friend WithEvents bt6 As PARCELLE.RedemptionRoundButton
    Friend WithEvents bt7 As PARCELLE.RedemptionRoundButton
    Friend WithEvents BT9 As PARCELLE.RedemptionRoundButton
    Friend WithEvents BT8 As PARCELLE.RedemptionRoundButton
    Friend WithEvents BT12 As PARCELLE.RedemptionRoundButton
    Friend WithEvents BT11 As PARCELLE.RedemptionRoundButton
    Friend WithEvents BT10 As PARCELLE.RedemptionRoundButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
