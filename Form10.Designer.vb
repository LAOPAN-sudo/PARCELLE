<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.FormSkin1 = New PARCELLE.FormSkin()
        Me.FlatTabControl1 = New PARCELLE.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FlatButton4 = New PARCELLE.FlatButton()
        Me.RedemptionProgressBar1 = New PARCELLE.RedemptionProgressBar()
        Me.FlatButton3 = New PARCELLE.FlatButton()
        Me.FlatButton2 = New PARCELLE.FlatButton()
        Me.FlatTextBox6 = New PARCELLE.FlatTextBox()
        Me.FlatTextBox5 = New PARCELLE.FlatTextBox()
        Me.FlatTextBox4 = New PARCELLE.FlatTextBox()
        Me.FlatTextBox3 = New PARCELLE.FlatTextBox()
        Me.FlatTextBox2 = New PARCELLE.FlatTextBox()
        Me.FlatLabel6 = New PARCELLE.FlatLabel()
        Me.FlatLabel5 = New PARCELLE.FlatLabel()
        Me.FlatLabel4 = New PARCELLE.FlatLabel()
        Me.FlatLabel3 = New PARCELLE.FlatLabel()
        Me.FlatLabel2 = New PARCELLE.FlatLabel()
        Me.FlatTextBox1 = New PARCELLE.FlatTextBox()
        Me.FlatButton1 = New PARCELLE.FlatButton()
        Me.FlatLabel1 = New PARCELLE.FlatLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusBar1 = New PARCELLE.FlatStatusBar()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(600, 470)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "ACHETEUR"
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 51)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(600, 389)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.FlatButton4)
        Me.TabPage1.Controls.Add(Me.RedemptionProgressBar1)
        Me.TabPage1.Controls.Add(Me.FlatButton3)
        Me.TabPage1.Controls.Add(Me.FlatButton2)
        Me.TabPage1.Controls.Add(Me.FlatTextBox6)
        Me.TabPage1.Controls.Add(Me.FlatTextBox5)
        Me.TabPage1.Controls.Add(Me.FlatTextBox4)
        Me.TabPage1.Controls.Add(Me.FlatTextBox3)
        Me.TabPage1.Controls.Add(Me.FlatTextBox2)
        Me.TabPage1.Controls.Add(Me.FlatLabel6)
        Me.TabPage1.Controls.Add(Me.FlatLabel5)
        Me.TabPage1.Controls.Add(Me.FlatLabel4)
        Me.TabPage1.Controls.Add(Me.FlatLabel3)
        Me.TabPage1.Controls.Add(Me.FlatLabel2)
        Me.TabPage1.Controls.Add(Me.FlatTextBox1)
        Me.TabPage1.Controls.Add(Me.FlatButton1)
        Me.TabPage1.Controls.Add(Me.FlatLabel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(592, 341)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ENTRER"
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.Maroon
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(459, 239)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = True
        Me.FlatButton4.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton4.TabIndex = 33
        Me.FlatButton4.Text = "Quitter"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'RedemptionProgressBar1
        '
        Me.RedemptionProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionProgressBar1.Location = New System.Drawing.Point(80, 293)
        Me.RedemptionProgressBar1.Maximum = 100
        Me.RedemptionProgressBar1.Name = "RedemptionProgressBar1"
        Me.RedemptionProgressBar1.Size = New System.Drawing.Size(445, 43)
        Me.RedemptionProgressBar1.TabIndex = 32
        Me.RedemptionProgressBar1.Text = "RedemptionProgressBar1"
        Me.RedemptionProgressBar1.Value = 0
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(321, 239)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = True
        Me.FlatButton3.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton3.TabIndex = 31
        Me.FlatButton3.Text = "Supprimer"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(184, 239)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = True
        Me.FlatButton2.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton2.TabIndex = 30
        Me.FlatButton2.Text = "Modifier"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatTextBox6
        '
        Me.FlatTextBox6.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox6.Location = New System.Drawing.Point(471, 144)
        Me.FlatTextBox6.MaxLength = 50
        Me.FlatTextBox6.Multiline = False
        Me.FlatTextBox6.Name = "FlatTextBox6"
        Me.FlatTextBox6.ReadOnly = False
        Me.FlatTextBox6.Size = New System.Drawing.Size(106, 29)
        Me.FlatTextBox6.TabIndex = 29
        Me.FlatTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FlatTextBox6.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox6.UseSystemPasswordChar = False
        '
        'FlatTextBox5
        '
        Me.FlatTextBox5.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox5.Location = New System.Drawing.Point(471, 79)
        Me.FlatTextBox5.MaxLength = 1
        Me.FlatTextBox5.Multiline = False
        Me.FlatTextBox5.Name = "FlatTextBox5"
        Me.FlatTextBox5.ReadOnly = False
        Me.FlatTextBox5.Size = New System.Drawing.Size(106, 29)
        Me.FlatTextBox5.TabIndex = 28
        Me.FlatTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FlatTextBox5.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox5.UseSystemPasswordChar = False
        '
        'FlatTextBox4
        '
        Me.FlatTextBox4.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox4.Location = New System.Drawing.Point(471, 7)
        Me.FlatTextBox4.MaxLength = 10
        Me.FlatTextBox4.Multiline = False
        Me.FlatTextBox4.Name = "FlatTextBox4"
        Me.FlatTextBox4.ReadOnly = False
        Me.FlatTextBox4.Size = New System.Drawing.Size(106, 29)
        Me.FlatTextBox4.TabIndex = 27
        Me.FlatTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FlatTextBox4.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox4.UseSystemPasswordChar = False
        '
        'FlatTextBox3
        '
        Me.FlatTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox3.Location = New System.Drawing.Point(152, 140)
        Me.FlatTextBox3.MaxLength = 30
        Me.FlatTextBox3.Multiline = False
        Me.FlatTextBox3.Name = "FlatTextBox3"
        Me.FlatTextBox3.ReadOnly = False
        Me.FlatTextBox3.Size = New System.Drawing.Size(106, 29)
        Me.FlatTextBox3.TabIndex = 26
        Me.FlatTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FlatTextBox3.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox3.UseSystemPasswordChar = False
        '
        'FlatTextBox2
        '
        Me.FlatTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox2.Location = New System.Drawing.Point(152, 75)
        Me.FlatTextBox2.MaxLength = 20
        Me.FlatTextBox2.Multiline = False
        Me.FlatTextBox2.Name = "FlatTextBox2"
        Me.FlatTextBox2.ReadOnly = False
        Me.FlatTextBox2.Size = New System.Drawing.Size(106, 29)
        Me.FlatTextBox2.TabIndex = 25
        Me.FlatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FlatTextBox2.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox2.UseSystemPasswordChar = False
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel6.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel6.Location = New System.Drawing.Point(344, 156)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(56, 17)
        Me.FlatLabel6.TabIndex = 24
        Me.FlatLabel6.Text = "Adresse:"
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel5.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel5.Location = New System.Drawing.Point(344, 91)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(39, 17)
        Me.FlatLabel5.TabIndex = 23
        Me.FlatLabel5.Text = "Sexe:"
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel4.Location = New System.Drawing.Point(344, 19)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(121, 17)
        Me.FlatLabel4.TabIndex = 22
        Me.FlatLabel4.Text = "Date de Naissance:"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel3.Location = New System.Drawing.Point(15, 156)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(57, 17)
        Me.FlatLabel3.TabIndex = 21
        Me.FlatLabel3.Text = "Prenom:"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel2.Location = New System.Drawing.Point(15, 91)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(39, 17)
        Me.FlatLabel2.TabIndex = 20
        Me.FlatLabel2.Text = "Nom:"
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Location = New System.Drawing.Point(152, 7)
        Me.FlatTextBox1.MaxLength = 10
        Me.FlatTextBox1.Multiline = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = False
        Me.FlatTextBox1.Size = New System.Drawing.Size(106, 29)
        Me.FlatTextBox1.TabIndex = 19
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FlatTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox1.UseSystemPasswordChar = False
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.RoyalBlue
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(50, 239)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = True
        Me.FlatButton1.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton1.TabIndex = 18
        Me.FlatButton1.Text = "Ajouter"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel1.Location = New System.Drawing.Point(15, 19)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(118, 17)
        Me.FlatLabel1.TabIndex = 17
        Me.FlatLabel1.Text = "Numero Acheteur:"
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
        Me.StatusBar1.Location = New System.Drawing.Point(0, 438)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.StatusBar1.ShowTimeDate = False
        Me.StatusBar1.Size = New System.Drawing.Size(600, 32)
        Me.StatusBar1.TabIndex = 0
        Me.StatusBar1.Text = "Status:"
        Me.StatusBar1.TextColor = System.Drawing.Color.White
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 470)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form10"
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
    Friend WithEvents RedemptionProgressBar1 As PARCELLE.RedemptionProgressBar
    Friend WithEvents FlatButton3 As PARCELLE.FlatButton
    Friend WithEvents FlatButton2 As PARCELLE.FlatButton
    Friend WithEvents FlatTextBox6 As PARCELLE.FlatTextBox
    Friend WithEvents FlatTextBox5 As PARCELLE.FlatTextBox
    Friend WithEvents FlatTextBox4 As PARCELLE.FlatTextBox
    Friend WithEvents FlatTextBox3 As PARCELLE.FlatTextBox
    Friend WithEvents FlatTextBox2 As PARCELLE.FlatTextBox
    Friend WithEvents FlatLabel6 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel5 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel4 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel3 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel2 As PARCELLE.FlatLabel
    Friend WithEvents FlatTextBox1 As PARCELLE.FlatTextBox
    Friend WithEvents FlatButton1 As PARCELLE.FlatButton
    Friend WithEvents FlatLabel1 As PARCELLE.FlatLabel
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents StatusBar1 As PARCELLE.FlatStatusBar
    Friend WithEvents FlatButton4 As PARCELLE.FlatButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
