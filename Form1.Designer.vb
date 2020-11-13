<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RedemptionProgressBar1 = New PARCELLE.RedemptionProgressBar()
        Me.FlatLabel4 = New PARCELLE.FlatLabel()
        Me.FlatLabel2 = New PARCELLE.FlatLabel()
        Me.FlatLabel1 = New PARCELLE.FlatLabel()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'RedemptionProgressBar1
        '
        Me.RedemptionProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionProgressBar1.Location = New System.Drawing.Point(12, 270)
        Me.RedemptionProgressBar1.Maximum = 100
        Me.RedemptionProgressBar1.Name = "RedemptionProgressBar1"
        Me.RedemptionProgressBar1.Size = New System.Drawing.Size(550, 47)
        Me.RedemptionProgressBar1.TabIndex = 5
        Me.RedemptionProgressBar1.Text = "RedemptionProgressBar1"
        Me.RedemptionProgressBar1.Value = 0
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FlatLabel4.Location = New System.Drawing.Point(230, 219)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(15, 17)
        Me.FlatLabel4.TabIndex = 4
        Me.FlatLabel4.Text = "0"
        Me.FlatLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(428, 31)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(73, 13)
        Me.FlatLabel2.TabIndex = 2
        Me.FlatLabel2.Text = "Version 1.0.0"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(120, 14)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(302, 30)
        Me.FlatLabel1.TabIndex = 1
        Me.FlatLabel1.Text = "PARCEL MANAGEMENT 2018"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PARCELLE.My.Resources.Resources.custom_agp_2_prod_splash1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(574, 348)
        Me.ControlBox = False
        Me.Controls.Add(Me.RedemptionProgressBar1)
        Me.Controls.Add(Me.FlatLabel4)
        Me.Controls.Add(Me.FlatLabel2)
        Me.Controls.Add(Me.FlatLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(300, 70)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlatLabel1 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel2 As PARCELLE.FlatLabel
    Friend WithEvents FlatLabel4 As PARCELLE.FlatLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RedemptionProgressBar1 As PARCELLE.RedemptionProgressBar

End Class
