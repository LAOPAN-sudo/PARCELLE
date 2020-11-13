
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class Form5

    Private Function formatstring(ByVal p1 As String) As String
        Return p1.ToString
    End Function

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        StatusBar1.Text = "Status: " & formatstring(Form2.txtuser.Text) & "  connecté                                           " & Date.Now

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 5

        If (RedemptionProgressBar1.Value = 50) Then
            Timer1.Stop()
            RedemptionProgressBar1.Value = 50
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 10
        If (RedemptionProgressBar1.Value = 100) Then
            Timer2.Stop()
            RedemptionProgressBar1.Value = 100
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        StatusBar1.Text = "Status: " & formatstring(Form2.txtuser.Text) & "  connecté                                           " & Date.Now


    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles btaj.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")

        Dim rep As String
        'Dim err As String
        'empeche d entrer des valeurs null
        If txtnppt.Text = "" Or txtnm.Text = "" Or txtpnm.Text = "" Or txtddn.Text = "" Or txtsex.Text = "" Or txtad.Text = "" Then
            RedemptionProgressBar1.Value = 0
            Timer1.Start()
            RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 10

            If RedemptionProgressBar1.Value = 50 Then
                RedemptionProgressBar1.Value = 0


            End If

            MsgBox(" Renseigner tous les champs ", vbCritical)
            RedemptionProgressBar1.Value = 0
        Else
            MyConnexion.Open()
            Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
            Mycommand.CommandText = "SELECT ID_Prop FROM PROPRIETAIRE where ID_Prop='" & txtnppt.Text & "'"
            Dim myreader As SqlDataReader = Mycommand.ExecuteReader

            If myreader.HasRows = True And myreader.Read() Then
                RedemptionProgressBar1.Value = 0
                Timer1.Start()
                RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 10

                If RedemptionProgressBar1.Value = 50 Then
                    RedemptionProgressBar1.Value = 0
                End If

                MsgBox("Le proprietaire est deja ajouter", vbCritical)
                RedemptionProgressBar1.Value = 0
            Else

                rep = MsgBox("Voulez vous enregistrer cet proprietaire?", vbYesNo)
                Select Case rep
                    Case vbYes
                        Timer2.Start()
                        RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 20
                        If (RedemptionProgressBar1.Value = 100) Then

                        End If
                        Mycommand.CommandText = "INSERT INTO PROPRIETAIRE (ID_Prop,Nom,Prenom,Datenais,Sexe,Adresse) VALUES ('" & formatstring(Me.txtnppt.Text) & "','" & formatstring(Me.txtnm.Text) & "','" & formatstring(Me.txtpnm.Text) & "','" & formatstring(Me.txtddn.Text) & "','" & formatstring(Me.txtsex.Text) & "','" & formatstring(Me.txtad.Text) & "')"
                        MsgBox(" Proprietaire ajouter ", vbInformation)
                        RedemptionProgressBar1.Value = 0
                        myreader.Close()
                        Mycommand.ExecuteNonQuery()
                        MyConnexion.Close()
                    Case vbNo
                        txtnppt.Text = ""
                        txtnm.Text = ""
                        txtpnm.Text = ""
                        txtddn.Text = ""
                        txtsex.Text = ""
                        txtad.Text = ""
                End Select
            End If
        End If

    End Sub

    Private Sub btmaj_Click(sender As Object, e As EventArgs) Handles btmaj.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")

        Dim rep As String
        'empeche d entrer des valeurs null
        If txtnppt.Text = "" Or txtnm.Text = "" Or txtpnm.Text = "" Or txtddn.Text = "" Or txtsex.Text = "" Or txtad.Text = "" Then
            RedemptionProgressBar1.Value = 0
            Timer1.Start()
            RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 10

            If RedemptionProgressBar1.Value = 50 Then
                RedemptionProgressBar1.Value = 0


            End If

            MsgBox(" Renseigner tous les champs ", vbCritical)
            RedemptionProgressBar1.Value = 0
        Else
            'verifie si l utilisateur existe
            MyConnexion.Open()
            Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
            Mycommand.CommandText = "SELECT ID_Prop FROM PROPRIETAIRE where ID_Prop='" & txtnppt.Text & "'"

            Dim myreader As SqlDataReader = Mycommand.ExecuteReader

            If myreader.HasRows = True And myreader.Read() Then
                rep = MsgBox("Voulez vous mettre a jour cet proprietaire?", vbYesNo)
                Select Case rep
                    Case vbYes
                        Timer2.Start()
                        RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 20
                        If (RedemptionProgressBar1.Value = 100) Then

                        End If
                        Mycommand.CommandText = "update PROPRIETAIRE set Nom='" & formatstring(Me.txtnm.Text) & "', Prenom='" & formatstring(Me.txtpnm.Text) & "', Datenais='" & formatstring(Me.txtddn.Text) & "', Sexe='" & formatstring(Me.txtsex.Text) & "', Adresse='" & formatstring(Me.txtad.Text) & "' where ID_Prop='" & txtnppt.Text & "'"
                        MsgBox(" Proprietaire mis a jour ", vbInformation)
                        RedemptionProgressBar1.Value = 0
                        myreader.Close()
                        Mycommand.ExecuteNonQuery()
                        MyConnexion.Close()
                    Case vbNo

                        txtnppt.Text = ""
                        txtnm.Text = ""
                        txtpnm.Text = ""
                        txtddn.Text = ""
                        txtsex.Text = ""
                        txtad.Text = ""

                End Select
            Else
                RedemptionProgressBar1.Value = 0
                Timer1.Start()
                RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 10

                If RedemptionProgressBar1.Value = 50 Then
                    RedemptionProgressBar1.Value = 0
                End If

                MsgBox("Le proprietaire n'existe pas", vbCritical)
                RedemptionProgressBar1.Value = 0

            End If
        End If

    End Sub

    Private Sub btsup_Click(sender As Object, e As EventArgs) Handles btsup.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")

        Dim rep As String
        'empeche d entrer des valeurs null
        If txtnppt.Text = "" Then
            RedemptionProgressBar1.Value = 0
            Timer1.Start()
            RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 10

            If RedemptionProgressBar1.Value = 50 Then
                RedemptionProgressBar1.Value = 0


            End If

            MsgBox(" Renseigner le numero proprietaire ", vbCritical)
            RedemptionProgressBar1.Value = 0
        Else
            'verifie si l utilisateur existe
            MyConnexion.Open()
            Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()

           
            Mycommand.CommandText = "SELECT ID_Prop FROM PROPRIETAIRE where ID_Prop='" & txtnppt.Text & "'"


            Dim myreader As SqlDataReader = Mycommand.ExecuteReader


            If myreader.HasRows = True And myreader.Read() Then
                rep = MsgBox("Voulez vous supprimer cet proprietaire?", vbYesNo)
                Select Case rep
                    Case vbYes
                        Timer2.Start()
                        RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 20
                        If (RedemptionProgressBar1.Value = 100) Then

                        End If
                        Mycommand.CommandText = "delete from PROPRIETAIRE where ID_Prop='" & formatstring(Me.txtnppt.Text) & "'"
                        MsgBox(" Proprietaire supprimer ", vbInformation)
                        RedemptionProgressBar1.Value = 0

                        myreader.Close()

                        Mycommand.ExecuteNonQuery()

                        MyConnexion.Close()
                    Case vbNo

                        txtnppt.Text = ""
                        txtnm.Text = ""
                        txtpnm.Text = ""
                        txtddn.Text = ""
                        txtsex.Text = ""
                        txtad.Text = ""

                End Select
            Else
                RedemptionProgressBar1.Value = 0
                Timer1.Start()
                RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 10

                If RedemptionProgressBar1.Value = 50 Then
                    RedemptionProgressBar1.Value = 0
                End If

                MsgBox("Le proprietaire n'existe pas", vbCritical)
                RedemptionProgressBar1.Value = 0
            End If
            End If
        'End If
    End Sub

    Private Sub btquit_Click(sender As Object, e As EventArgs) Handles btquit.Click
        Me.Close()
        Form11.Show()
        Form3.Show()

    End Sub

    Private Sub btactu_Click(sender As Object, e As EventArgs) Handles btactu.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT * FROM PROPRIETAIRE"
        Dim da As SqlDataAdapter
        Dim dt As New DataTable

        'Mycommand.CommandText = "UPDATE ETUDIANT SET Classe = 'SIR2' WHERE Mtle ='E003'"
        ' Mycommand.CommandText = "DELETE FROM ETUDIANT WHERE MTLE = 'E004'"
        da = New SqlDataAdapter(Mycommand)
        dt.Clear()
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        Me.Show()

        Dim myReader As SqlDataReader = Mycommand.ExecuteReader()
        ' Dim da_1 As New SqlDataAdapter(Mycommand.CommandText)
        Dim ds_1 As New DataSet
        myReader.Close()
        MyConnexion.Close()

    End Sub
End Class