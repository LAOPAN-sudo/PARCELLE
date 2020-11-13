<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.RedemptionLabel2 = New PARCELLE.RedemptionLabel()
        Me.RedemptionLabel1 = New PARCELLE.RedemptionLabel()
        Me.StatusBar1 = New PARCELLE.FlatStatusBar()
        Me.FlatClose1 = New PARCELLE.FlatClose()
        Me.bteff = New PARCELLE.FlatButton()
        Me.btconn = New PARCELLE.FlatButton()
        Me.txtmtp = New PARCELLE.FlatTextBox()
        Me.txtuser = New PARCELLE.FlatTextBox()
        Me.FlatLabel2 = New PARCELLE.FlatLabel()
        Me.FlatLabel1 = New PARCELLE.FlatLabel()
        Me.FormSkin1.SuspendLayout()
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
        Me.FormSkin1.Controls.Add(Me.RedemptionLabel2)
        Me.FormSkin1.Controls.Add(Me.RedemptionLabel1)
        Me.FormSkin1.Controls.Add(Me.StatusBar1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.bteff)
        Me.FormSkin1.Controls.Add(Me.btconn)
        Me.FormSkin1.Controls.Add(Me.txtmtp)
        Me.FormSkin1.Controls.Add(Me.txtuser)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(571, 366)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "AUTHENTIFICATION"
        '
        'RedemptionLabel2
        '
        Me.RedemptionLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RedemptionLabel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionLabel2.ForeColor = System.Drawing.Color.White
        Me.RedemptionLabel2.Location = New System.Drawing.Point(225, 80)
        Me.RedemptionLabel2.Name = "RedemptionLabel2"
        Me.RedemptionLabel2.Size = New System.Drawing.Size(110, 20)
        Me.RedemptionLabel2.TabIndex = 9
        Me.RedemptionLabel2.Text = "Mot de passe=123"
        '
        'RedemptionLabel1
        '
        Me.RedemptionLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RedemptionLabel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionLabel1.ForeColor = System.Drawing.Color.White
        Me.RedemptionLabel1.Location = New System.Drawing.Point(225, 54)
        Me.RedemptionLabel1.Name = "RedemptionLabel1"
        Me.RedemptionLabel1.Size = New System.Drawing.Size(110, 20)
        Me.RedemptionLabel1.TabIndex = 8
        Me.RedemptionLabel1.Text = "UserName=Admin"
        '
        'StatusBar1
        '
        Me.StatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.ForeColor = System.Drawing.Color.White
        Me.StatusBar1.Location = New System.Drawing.Point(0, 335)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.StatusBar1.ShowTimeDate = False
        Me.StatusBar1.Size = New System.Drawing.Size(571, 31)
        Me.StatusBar1.TabIndex = 7
        Me.StatusBar1.Text = "Status:"
        Me.StatusBar1.TextColor = System.Drawing.Color.White
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(531, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 6
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'bteff
        '
        Me.bteff.BackColor = System.Drawing.Color.Transparent
        Me.bteff.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.bteff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bteff.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.bteff.Location = New System.Drawing.Point(391, 282)
        Me.bteff.Name = "bteff"
        Me.bteff.Rounded = True
        Me.bteff.Size = New System.Drawing.Size(106, 32)
        Me.bteff.TabIndex = 5
        Me.bteff.Text = "Effacer"
        Me.bteff.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btconn
        '
        Me.btconn.BackColor = System.Drawing.Color.Transparent
        Me.btconn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btconn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btconn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btconn.Location = New System.Drawing.Point(87, 282)
        Me.btconn.Name = "btconn"
        Me.btconn.Rounded = True
        Me.btconn.Size = New System.Drawing.Size(106, 32)
        Me.btconn.TabIndex = 4
        Me.btconn.Text = "Connexion"
        Me.btconn.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtmtp
        '
        Me.txtmtp.BackColor = System.Drawing.Color.Transparent
        Me.txtmtp.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmtp.Location = New System.Drawing.Point(370, 189)
        Me.txtmtp.MaxLength = 10
        Me.txtmtp.Multiline = False
        Me.txtmtp.Name = "txtmtp"
        Me.txtmtp.ReadOnly = False
        Me.txtmtp.Size = New System.Drawing.Size(148, 37)
        Me.txtmtp.TabIndex = 3
        Me.txtmtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtmtp.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtmtp.UseSystemPasswordChar = True
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.Transparent
        Me.txtuser.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(370, 117)
        Me.txtuser.MaxLength = 10
        Me.txtuser.Multiline = False
        Me.txtuser.Name = "txtuser"
        Me.txtuser.ReadOnly = False
        Me.txtuser.Size = New System.Drawing.Size(148, 37)
        Me.txtuser.TabIndex = 2
        Me.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtuser.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtuser.UseSystemPasswordChar = False
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(36, 201)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(124, 25)
        Me.FlatLabel2.TabIndex = 1
        Me.FlatLabel2.Text = "Mot de passe"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(36, 129)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(100, 25)
        Me.FlatLabel1.TabIndex = 0
        Me.FlatLabel1.Text = "UserName"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 366)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As PARCELLE.FormSkin
    Friend WithEvents txtmtp As PARCELLE.FlatTextBox
    Friend WithEvents txtuser As PARCELLE.FlatTextBox
    Friend WithEvents FlatLabel2 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel1 As PARCELLE.FlatLabel
    Friend WithEvents bteff As PARCELLE.FlatButton
    Friend WithEvents btconn As PARCELLE.FlatButton
    Friend WithEvents FlatClose1 As PARCELLE.FlatClose
    Friend WithEvents StatusBar1 As PARCELLE.FlatStatusBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RedemptionLabel2 As PARCELLE.RedemptionLabel
    Friend WithEvents RedemptionLabel1 As PARCELLE.RedemptionLabel
End Class
