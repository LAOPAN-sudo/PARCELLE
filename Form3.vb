
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class Form3

    Private Function formatstring(ByVal p1 As String) As String
        Return p1.ToString
    End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cache le bouton user2 et cache l interface user
        gbuser.Visible = False
        btuser2.Visible = False
        'affiche l utilisateur connecté sur la form3
        StatusBar1.Text = "Status: " & formatstring(Form2.txtuser.Text) & "  connecté                                                                                   " & Date.Now

    End Sub


    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        'affiche l utilisateur connecté sur la form2 , arrete le timer de la form2 ,affiche l utilisateur connecté sur la form3
        Form2.StatusBar1.Text = "Status: " & formatstring(Form2.txtuser.Text) & "  connecté                                                            " & Date.Now
        StatusBar1.Text = "Status: " & formatstring(Form2.txtuser.Text) & "  connecté                                                                                   " & Date.Now
        Form2.Timer1.Stop()

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles btdeconn.Click
        'demarre le timer de la form2, active le txtuser et txtmtp de le form2
        Dim rep As String
        rep = MsgBox("Voulez allez etre deconnecter?", vbYesNo)
        Select Case rep
            Case vbYes
                Me.Close()
                Form2.Timer1.Start()
                Form2.txtuser.Enabled = True
                Form2.txtmtp.Enabled = True
                Form2.bteff.Enabled = True
                Form2.btconn.Enabled = True
                Form2.txtuser.Text = ""
                Form2.txtmtp.Text = ""
                Form2.Show()
            Case vbNo
                MsgBox(formatstring(Form2.txtuser.Text) & "  est connecté", vbInformation)
        End Select

    End Sub

    Private Sub RedemptionButton1_Click(sender As Object, e As EventArgs) Handles RedemptionButton1.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub RedemptionButton2_Click(sender As Object, e As EventArgs) Handles RedemptionButton2.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub RedemptionButton3_Click(sender As Object, e As EventArgs) Handles RedemptionButton3.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub RedemptionButton4_Click(sender As Object, e As EventArgs) Handles RedemptionButton4.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub RedemptionButton6_Click(sender As Object, e As EventArgs) Handles RedemptionButton6.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub RedemptionButton5_Click(sender As Object, e As EventArgs) Handles RedemptionButton5.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles btaj.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")

        Dim rep As String
        'empeche d entrer des valeurs null
        If txtuser.Text = "" Or txtmtp.Text = "" Then
            MsgBox(" Entrer des identifiants valides ", vbCritical)
        Else
            MyConnexion.Open()
            Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
            Mycommand.CommandText = "SELECT Login,Password FROM UTILISATEUR where Login='" & txtuser.Text & "'"
            Dim myreader As SqlDataReader = Mycommand.ExecuteReader

            If myreader.HasRows = True And myreader.Read() Then
                MsgBox("L'utilisateur est deja ajouter", vbCritical)
            Else
                rep = MsgBox("Voulez vous enregistrer cet utilisateur?", vbYesNo)
                Select Case rep
                    Case vbYes


                        Mycommand.CommandText = "INSERT INTO UTILISATEUR (Login,Password) VALUES ('" & formatstring(Me.txtuser.Text) & "','" & formatstring(Me.txtmtp.Text) & "')"
                        MsgBox(" Utilisateur ajouter ")
                        myreader.Close()
                        Mycommand.ExecuteNonQuery()
                        MyConnexion.Close()
                    Case vbNo
                        txtuser.Text = ""
                        txtmtp.Text = ""
                End Select
            End If
        End If

    End Sub

    Private Sub btsup_Click(sender As Object, e As EventArgs) Handles btsup.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")

        Dim rep As String
        'empeche d entrer des valeurs null
        If txtuser.Text = "" Then
            MsgBox(" Entrer un username valide ", vbCritical)
        Else
            'verifie si l utilisateur existe
            MyConnexion.Open()
            Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
            Mycommand.CommandText = "SELECT Login,Password FROM UTILISATEUR where Login='" & txtuser.Text & "'"
            Dim myreader As SqlDataReader = Mycommand.ExecuteReader

            If myreader.HasRows = True And myreader.Read() Then
                rep = MsgBox("Voulez vous supprimer cet utilisateur?", vbYesNo)
                Select Case rep
                    Case vbYes
                        Mycommand.CommandText = "delete from UTILISATEUR where Login='" & formatstring(Me.txtuser.Text) & "'"
                        MsgBox(" Utilisateur supprimer ")
                        myreader.Close()
                        Mycommand.ExecuteNonQuery()
                        MyConnexion.Close()
                    Case vbNo
                        txtuser.Text = ""
                        txtmtp.Text = ""
                End Select
            Else
                MsgBox(" Utilisateur inexistant ", vbCritical)
            End If
        End If


    End Sub

    Private Sub btuser_Click(sender As Object, e As EventArgs) Handles btuser.Click
        'cache le boutton user et affiche l interface user et affiche le boutton user2
        gbuser.Visible = True
        btuser.Visible = False
        btuser2.Visible = True

    End Sub

    Private Sub btuser2_Click(sender As Object, e As EventArgs) Handles btuser2.Click
        'cache l interface user , cache le boutton user2 et affiche le boutton user
        gbuser.Visible = False
        btuser2.Visible = False
        btuser.Visible = True

    End Sub

End Class