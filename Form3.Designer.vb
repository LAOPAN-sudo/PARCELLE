<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btdeconn = New PARCELLE.FlatButton()
        Me.btuser = New PARCELLE.FlatButton()
        Me.btuser2 = New PARCELLE.FlatButton()
        Me.gbuser = New PARCELLE.FlatGroupBox()
        Me.btsup = New PARCELLE.FlatButton()
        Me.txtmtp = New PARCELLE.RedemptionTextBox()
        Me.txtuser = New PARCELLE.RedemptionTextBox()
        Me.btaj = New PARCELLE.FlatButton()
        Me.FlatLabel3 = New PARCELLE.FlatLabel()
        Me.FlatLabel2 = New PARCELLE.FlatLabel()
        Me.FlatLabel1 = New PARCELLE.FlatLabel()
        Me.RedemptionButton6 = New PARCELLE.RedemptionButton()
        Me.RedemptionButton5 = New PARCELLE.RedemptionButton()
        Me.RedemptionButton4 = New PARCELLE.RedemptionButton()
        Me.RedemptionButton3 = New PARCELLE.RedemptionButton()
        Me.RedemptionButton2 = New PARCELLE.RedemptionButton()
        Me.RedemptionButton1 = New PARCELLE.RedemptionButton()
        Me.StatusBar1 = New PARCELLE.FlatStatusBar()
        Me.FlatGroupBox6 = New PARCELLE.FlatGroupBox()
        Me.FlatGroupBox5 = New PARCELLE.FlatGroupBox()
        Me.FlatGroupBox4 = New PARCELLE.FlatGroupBox()
        Me.FlatGroupBox3 = New PARCELLE.FlatGroupBox()
        Me.FlatGroupBox2 = New PARCELLE.FlatGroupBox()
        Me.FlatGroupBox1 = New PARCELLE.FlatGroupBox()
        Me.FormSkin1.SuspendLayout()
        Me.gbuser.SuspendLayout()
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
        Me.FormSkin1.BaseColor = System.Drawing.Color.Silver
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.btdeconn)
        Me.FormSkin1.Controls.Add(Me.btuser)
        Me.FormSkin1.Controls.Add(Me.btuser2)
        Me.FormSkin1.Controls.Add(Me.gbuser)
        Me.FormSkin1.Controls.Add(Me.RedemptionButton6)
        Me.FormSkin1.Controls.Add(Me.RedemptionButton5)
        Me.FormSkin1.Controls.Add(Me.RedemptionButton4)
        Me.FormSkin1.Controls.Add(Me.RedemptionButton3)
        Me.FormSkin1.Controls.Add(Me.RedemptionButton2)
        Me.FormSkin1.Controls.Add(Me.RedemptionButton1)
        Me.FormSkin1.Controls.Add(Me.StatusBar1)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox6)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox5)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox4)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox3)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox2)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(900, 711)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "MENU DES OPTIONS"
        '
        'btdeconn
        '
        Me.btdeconn.BackColor = System.Drawing.Color.Transparent
        Me.btdeconn.BaseColor = System.Drawing.Color.IndianRed
        Me.btdeconn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdeconn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btdeconn.Location = New System.Drawing.Point(743, 618)
        Me.btdeconn.Name = "btdeconn"
        Me.btdeconn.Rounded = True
        Me.btdeconn.Size = New System.Drawing.Size(118, 47)
        Me.btdeconn.TabIndex = 1
        Me.btdeconn.Text = "Deconnexion"
        Me.btdeconn.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btuser
        '
        Me.btuser.BackColor = System.Drawing.Color.Transparent
        Me.btuser.BaseColor = System.Drawing.Color.Teal
        Me.btuser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btuser.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btuser.Location = New System.Drawing.Point(29, 618)
        Me.btuser.Name = "btuser"
        Me.btuser.Rounded = True
        Me.btuser.Size = New System.Drawing.Size(126, 47)
        Me.btuser.TabIndex = 9
        Me.btuser.Text = "User"
        Me.btuser.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btuser2
        '
        Me.btuser2.BackColor = System.Drawing.Color.Transparent
        Me.btuser2.BaseColor = System.Drawing.Color.Teal
        Me.btuser2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btuser2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btuser2.Location = New System.Drawing.Point(29, 618)
        Me.btuser2.Name = "btuser2"
        Me.btuser2.Rounded = True
        Me.btuser2.Size = New System.Drawing.Size(126, 47)
        Me.btuser2.TabIndex = 10
        Me.btuser2.Text = "User"
        Me.btuser2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'gbuser
        '
        Me.gbuser.BackColor = System.Drawing.Color.Silver
        Me.gbuser.BaseColor = System.Drawing.Color.DimGray
        Me.gbuser.Controls.Add(Me.btsup)
        Me.gbuser.Controls.Add(Me.txtmtp)
        Me.gbuser.Controls.Add(Me.txtuser)
        Me.gbuser.Controls.Add(Me.btaj)
        Me.gbuser.Controls.Add(Me.FlatLabel3)
        Me.gbuser.Controls.Add(Me.FlatLabel2)
        Me.gbuser.Controls.Add(Me.FlatLabel1)
        Me.gbuser.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.gbuser.Location = New System.Drawing.Point(226, 521)
        Me.gbuser.Name = "gbuser"
        Me.gbuser.ShowText = True
        Me.gbuser.Size = New System.Drawing.Size(438, 151)
        Me.gbuser.TabIndex = 2
        '
        'btsup
        '
        Me.btsup.BackColor = System.Drawing.Color.Transparent
        Me.btsup.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btsup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btsup.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsup.Location = New System.Drawing.Point(267, 116)
        Me.btsup.Name = "btsup"
        Me.btsup.Rounded = True
        Me.btsup.Size = New System.Drawing.Size(84, 22)
        Me.btsup.TabIndex = 6
        Me.btsup.Text = "Suppression"
        Me.btsup.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtmtp
        '
        Me.txtmtp.BackColor = System.Drawing.Color.Transparent
        Me.txtmtp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtmtp.ForeColor = System.Drawing.Color.White
        Me.txtmtp.Location = New System.Drawing.Point(243, 73)
        Me.txtmtp.MaxLength = 10
        Me.txtmtp.MultiLine = False
        Me.txtmtp.Name = "txtmtp"
        Me.txtmtp.Size = New System.Drawing.Size(135, 21)
        Me.txtmtp.TabIndex = 5
        Me.txtmtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtmtp.UseSystemPasswordChar = False
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.Transparent
        Me.txtuser.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtuser.ForeColor = System.Drawing.Color.White
        Me.txtuser.Location = New System.Drawing.Point(243, 41)
        Me.txtuser.MaxLength = 10
        Me.txtuser.MultiLine = False
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(135, 21)
        Me.txtuser.TabIndex = 4
        Me.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtuser.UseSystemPasswordChar = False
        '
        'btaj
        '
        Me.btaj.BackColor = System.Drawing.Color.Transparent
        Me.btaj.BaseColor = System.Drawing.Color.Olive
        Me.btaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btaj.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btaj.Location = New System.Drawing.Point(77, 116)
        Me.btaj.Name = "btaj"
        Me.btaj.Rounded = True
        Me.btaj.Size = New System.Drawing.Size(84, 22)
        Me.btaj.TabIndex = 3
        Me.btaj.Text = "Ajout"
        Me.btaj.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel3.Location = New System.Drawing.Point(29, 81)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(76, 13)
        Me.FlatLabel3.TabIndex = 2
        Me.FlatLabel3.Text = "Mot de passe"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel2.Location = New System.Drawing.Point(29, 49)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(59, 13)
        Me.FlatLabel2.TabIndex = 1
        Me.FlatLabel2.Text = "UserName"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel1.Location = New System.Drawing.Point(92, 12)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(244, 17)
        Me.FlatLabel1.TabIndex = 0
        Me.FlatLabel1.Text = "Ajouter ou supprimer  des Utilisateurs"
        Me.FlatLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RedemptionButton6
        '
        Me.RedemptionButton6.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionButton6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionButton6.Location = New System.Drawing.Point(351, 475)
        Me.RedemptionButton6.Name = "RedemptionButton6"
        Me.RedemptionButton6.Size = New System.Drawing.Size(211, 26)
        Me.RedemptionButton6.TabIndex = 8
        Me.RedemptionButton6.Text = "Infos sur parcelles"
        Me.RedemptionButton6.TextAlign = PARCELLE.RedemptionButton.HorizontalAlignment.Center
        '
        'RedemptionButton5
        '
        Me.RedemptionButton5.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionButton5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionButton5.Location = New System.Drawing.Point(630, 475)
        Me.RedemptionButton5.Name = "RedemptionButton5"
        Me.RedemptionButton5.Size = New System.Drawing.Size(211, 26)
        Me.RedemptionButton5.TabIndex = 7
        Me.RedemptionButton5.Text = "Gestion des statistiques"
        Me.RedemptionButton5.TextAlign = PARCELLE.RedemptionButton.HorizontalAlignment.Center
        '
        'RedemptionButton4
        '
        Me.RedemptionButton4.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionButton4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionButton4.Location = New System.Drawing.Point(63, 475)
        Me.RedemptionButton4.Name = "RedemptionButton4"
        Me.RedemptionButton4.Size = New System.Drawing.Size(211, 26)
        Me.RedemptionButton4.TabIndex = 6
        Me.RedemptionButton4.Text = "Gestion des affectations"
        Me.RedemptionButton4.TextAlign = PARCELLE.RedemptionButton.HorizontalAlignment.Center
        '
        'RedemptionButton3
        '
        Me.RedemptionButton3.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionButton3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionButton3.Location = New System.Drawing.Point(630, 267)
        Me.RedemptionButton3.Name = "RedemptionButton3"
        Me.RedemptionButton3.Size = New System.Drawing.Size(211, 26)
        Me.RedemptionButton3.TabIndex = 5
        Me.RedemptionButton3.Text = "Gestion des ventes"
        Me.RedemptionButton3.TextAlign = PARCELLE.RedemptionButton.HorizontalAlignment.Center
        '
        'RedemptionButton2
        '
        Me.RedemptionButton2.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionButton2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionButton2.Location = New System.Drawing.Point(351, 267)
        Me.RedemptionButton2.Name = "RedemptionButton2"
        Me.RedemptionButton2.Size = New System.Drawing.Size(211, 26)
        Me.RedemptionButton2.TabIndex = 4
        Me.RedemptionButton2.Text = "Gestion des proprietaires"
        Me.RedemptionButton2.TextAlign = PARCELLE.RedemptionButton.HorizontalAlignment.Center
        '
        'RedemptionButton1
        '
        Me.RedemptionButton1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionButton1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionButton1.Location = New System.Drawing.Point(63, 267)
        Me.RedemptionButton1.Name = "RedemptionButton1"
        Me.RedemptionButton1.Size = New System.Drawing.Size(211, 26)
        Me.RedemptionButton1.TabIndex = 1
        Me.RedemptionButton1.Text = "Gestion des parcelles"
        Me.RedemptionButton1.TextAlign = PARCELLE.RedemptionButton.HorizontalAlignment.Center
        '
        'StatusBar1
        '
        Me.StatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.ForeColor = System.Drawing.Color.White
        Me.StatusBar1.Location = New System.Drawing.Point(0, 672)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.StatusBar1.ShowTimeDate = False
        Me.StatusBar1.Size = New System.Drawing.Size(900, 39)
        Me.StatusBar1.TabIndex = 3
        Me.StatusBar1.Text = "Status:"
        Me.StatusBar1.TextColor = System.Drawing.Color.White
        '
        'FlatGroupBox6
        '
        Me.FlatGroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox6.BackgroundImage = Global.PARCELLE.My.Resources.Resources._091104101547_1_900x600
        Me.FlatGroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlatGroupBox6.BaseColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox6.Location = New System.Drawing.Point(612, 309)
        Me.FlatGroupBox6.Name = "FlatGroupBox6"
        Me.FlatGroupBox6.ShowText = True
        Me.FlatGroupBox6.Size = New System.Drawing.Size(240, 160)
        Me.FlatGroupBox6.TabIndex = 1
        '
        'FlatGroupBox5
        '
        Me.FlatGroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox5.BackgroundImage = Global.PARCELLE.My.Resources.Resources.info_logo_dans_un_cercle_318_947
        Me.FlatGroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlatGroupBox5.BaseColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox5.Location = New System.Drawing.Point(337, 309)
        Me.FlatGroupBox5.Name = "FlatGroupBox5"
        Me.FlatGroupBox5.ShowText = True
        Me.FlatGroupBox5.Size = New System.Drawing.Size(240, 160)
        Me.FlatGroupBox5.TabIndex = 1
        '
        'FlatGroupBox4
        '
        Me.FlatGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox4.BackgroundImage = Global.PARCELLE.My.Resources.Resources.vers_le_haut_vers_le_bas_du_vecteur_de_flèche_52071212
        Me.FlatGroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlatGroupBox4.BaseColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox4.Location = New System.Drawing.Point(46, 309)
        Me.FlatGroupBox4.Name = "FlatGroupBox4"
        Me.FlatGroupBox4.ShowText = True
        Me.FlatGroupBox4.Size = New System.Drawing.Size(240, 160)
        Me.FlatGroupBox4.TabIndex = 2
        '
        'FlatGroupBox3
        '
        Me.FlatGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox3.BackgroundImage = Global.PARCELLE.My.Resources.Resources.handshake_icon_vector_illustration_33796141
        Me.FlatGroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlatGroupBox3.BaseColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox3.Location = New System.Drawing.Point(612, 101)
        Me.FlatGroupBox3.Name = "FlatGroupBox3"
        Me.FlatGroupBox3.ShowText = True
        Me.FlatGroupBox3.Size = New System.Drawing.Size(240, 160)
        Me.FlatGroupBox3.TabIndex = 1
        '
        'FlatGroupBox2
        '
        Me.FlatGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox2.BackgroundImage = Global.PARCELLE.My.Resources.Resources.Utilisateur
        Me.FlatGroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlatGroupBox2.BaseColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox2.Location = New System.Drawing.Point(337, 101)
        Me.FlatGroupBox2.Name = "FlatGroupBox2"
        Me.FlatGroupBox2.ShowText = True
        Me.FlatGroupBox2.Size = New System.Drawing.Size(240, 160)
        Me.FlatGroupBox2.TabIndex = 1
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BackgroundImage = Global.PARCELLE.My.Resources.Resources._16153228_classic_house_design_progress_architectural_drawing_and_visualization
        Me.FlatGroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatGroupBox1.Location = New System.Drawing.Point(46, 101)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(240, 160)
        Me.FlatGroupBox1.TabIndex = 0
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 711)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.gbuser.ResumeLayout(False)
        Me.gbuser.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As PARCELLE.FormSkin
    Friend WithEvents StatusBar1 As PARCELLE.FlatStatusBar
    Friend WithEvents gbuser As PARCELLE.FlatGroupBox
    Friend WithEvents FlatGroupBox6 As PARCELLE.FlatGroupBox
    Friend WithEvents FlatGroupBox5 As PARCELLE.FlatGroupBox
    Friend WithEvents FlatGroupBox4 As PARCELLE.FlatGroupBox
    Friend WithEvents FlatGroupBox3 As PARCELLE.FlatGroupBox
    Friend WithEvents FlatGroupBox2 As PARCELLE.FlatGroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btdeconn As PARCELLE.FlatButton
    Friend WithEvents FlatGroupBox1 As PARCELLE.FlatGroupBox
    Friend WithEvents RedemptionButton1 As PARCELLE.RedemptionButton
    Friend WithEvents RedemptionButton2 As PARCELLE.RedemptionButton
    Friend WithEvents RedemptionButton3 As PARCELLE.RedemptionButton
    Friend WithEvents RedemptionButton6 As PARCELLE.RedemptionButton
    Friend WithEvents RedemptionButton5 As PARCELLE.RedemptionButton
    Friend WithEvents RedemptionButton4 As PARCELLE.RedemptionButton
    Friend WithEvents btsup As PARCELLE.FlatButton
    Friend WithEvents txtmtp As PARCELLE.RedemptionTextBox
    Friend WithEvents txtuser As PARCELLE.RedemptionTextBox
    Friend WithEvents btaj As PARCELLE.FlatButton
    Friend WithEvents FlatLabel3 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel2 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel1 As PARCELLE.FlatLabel
    Friend WithEvents btuser As PARCELLE.FlatButton
    Friend WithEvents btuser2 As PARCELLE.FlatButton
End Class
