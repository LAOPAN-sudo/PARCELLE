Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class Form2
    Dim rep As String
    Private Function formatstring(ByVal p1 As String) As String
        Return p1.ToString
    End Function

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles bteff.Click
        txtuser.Text = ""
        txtmtp.Text = ""

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles btconn.Click
        'demarre le timer de la form2 , empeche d entrer des valeurs null , affiche la form3 et desactive (txtuser, txtmtp, bteff, btconn)
        Timer1.Start()
        If txtuser.Text = "" Or txtmtp.Text = "" Then
            MsgBox(" Entrer des identifiants valides ", vbCritical)
        Else

            Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
            MyConnexion.Open()
            Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
            Mycommand.CommandText = "SELECT Login,Password FROM UTILISATEUR where Login='" & txtuser.Text & "' and  Password='" & txtmtp.Text & "'"
            Dim myreader As SqlDataReader = Mycommand.ExecuteReader

            If myreader.HasRows = True And myreader.Read() Then
                Form3.Show()
                txtuser.Enabled = False
                txtmtp.Enabled = False
                bteff.Enabled = False
                btconn.Enabled = False
                Me.Hide()
                
            Else
                MsgBox("Identifiants invalides,veuillez verifier vos identifiants", vbCritical)
            End If
        End If

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'verifie si rep est vrai et affiche l utilisateur connecté sur la form2
        If rep = vbInformation Then
            StatusBar1.Text = "Status: " & formatstring(Me.txtuser.Text) & "  connecté                                                            " & Date.Now
        Else
            StatusBar1.Text = "Status: Utilisateur non connecté                                                 " & Date.Now
        End If
        
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'affiche utilisateur non connecté sur la form2
        StatusBar1.Text = "Status: Utilisateur non connecté                                                 " & Date.Now

    End Sub

End Class