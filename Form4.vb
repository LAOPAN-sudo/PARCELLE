
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class Form4

    Private Function formatstring(ByVal p1 As String) As String
        Return p1.ToString
    End Function

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        StatusBar1.Text = "Status: " & formatstring(Form2.txtuser.Text) & "  connecté                                                         " & Date.Now
        Label7.Visible = False
        btaj2.Visible = False
        btqt2.Visible = False
        txtnppt.Visible = False

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles btaj.Click
        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")

        Dim rep As String
        Dim rep1 As String
        'empeche d entrer des valeurs null
        If txtnpc.Text = "" Or txtlo.Text = "" Or txtsctn.Text = "" Or txtsctr.Text = "" Or txtspf.Text = "" Then
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
            Mycommand.CommandText = "SELECT ID_Parcelle FROM PARCELLE where ID_Parcelle='" & txtnpc.Text & "'"
            Dim myreader As SqlDataReader = Mycommand.ExecuteReader

            If myreader.HasRows = True And myreader.Read() Then
                RedemptionProgressBar1.Value = 0
                Timer1.Start()
                RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 10

                If RedemptionProgressBar1.Value = 50 Then
                    RedemptionProgressBar1.Value = 0
                End If

                MsgBox("La parcelle est deja ajouter", vbCritical)
                RedemptionProgressBar1.Value = 0
            Else

                rep = MsgBox("Voulez vous enregistrer cette parcelle?", vbYesNo)
                Select Case rep
                    Case vbYes
                        Timer2.Start()
                        RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 20
                        If (RedemptionProgressBar1.Value = 100) Then

                        End If
                        Mycommand.CommandText = "INSERT INTO PARCELLE (ID_Parcelle,Superficie,PUH,Lot,Section,Secteur) VALUES ('" & formatstring(Me.txtnpc.Text) & "','" & formatstring(Me.txtspf.Text) & "','" & formatstring(Me.txtnpuh.Text) & "','" & formatstring(Me.txtlo.Text) & "','" & formatstring(Me.txtsctn.Text) & "','" & formatstring(Me.txtsctr.Text) & "')"
                        MsgBox(" Pacelle ajouter ", vbInformation)
                        'Form8.FlatTextBox1.Text = "Parcelle" & formatstring(Me.txtnpc.Text) & "ajouter;"
                        'Form8.txtlog.Text =

                        RedemptionProgressBar1.Value = 0

                        rep1 = MsgBox(" Voulez vous ajouter un proprietaire a cette parcelle? ", vbYesNo)
                        Select Case rep1
                            Case vbYes
                                Label1.Visible = False
                                Label2.Visible = False
                                Label3.Visible = False
                                Label4.Visible = False
                                Label5.Visible = False
                                Label6.Visible = False

                                btaj.Visible = False
                                btmaj.Visible = False
                                btsup.Visible = False
                                btqt.Visible = False

                                txtlo.Visible = False
                                txtnpc.Visible = False
                                txtnpuh.Visible = False
                                txtsctn.Visible = False
                                txtsctr.Visible = False
                                txtspf.Visible = False

                                Label7.Visible = True
                                btaj2.Visible = True
                                btqt2.Visible = True
                                txtnppt.Visible = True

                            Case vbNo

                                txtnpc.Text = ""
                                txtspf.Text = ""
                                txtnpuh.Text = ""
                                txtsctn.Text = ""
                                txtsctr.Text = ""
                                txtlo.Text = ""

                        End Select
                        myreader.Close()
                        Mycommand.ExecuteNonQuery()
                        MyConnexion.Close()
                    Case vbNo
                        txtnpc.Text = ""
                        txtspf.Text = ""
                        txtnpuh.Text = ""
                        txtsctn.Text = ""
                        txtsctr.Text = ""
                        txtlo.Text = ""
                End Select
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 5

        If (RedemptionProgressBar1.Value = 50) Then
            Timer1.Stop()
            RedemptionProgressBar1.Value = 50
        End If

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles btqt.Click
        Me.Close()
        Form11.Show()
        Form3.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 10
        If (RedemptionProgressBar1.Value = 100) Then
            Timer2.Stop()
            RedemptionProgressBar1.Value = 100
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        StatusBar1.Text = "Status: " & formatstring(Form2.txtuser.Text) & "  connecté                                                         " & Date.Now


    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles btsup.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")

        Dim rep As String

        'empeche d entrer des valeurs null
        If txtnpc.Text = "" Then
            RedemptionProgressBar1.Value = 0
            Timer1.Start()
            RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 10

            If RedemptionProgressBar1.Value = 50 Then
                RedemptionProgressBar1.Value = 0


            End If

            MsgBox(" Renseigner le numero parcelle ", vbCritical)
            RedemptionProgressBar1.Value = 0
        Else
            'verifie si l utilisateur existe
            MyConnexion.Open()
            Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
            Mycommand.CommandText = "SELECT ID_Parcelle FROM PARCELLE where ID_Parcelle='" & txtnpc.Text & "'"

            Dim myreader As SqlDataReader = Mycommand.ExecuteReader

            If myreader.HasRows = True And myreader.Read() Then
                rep = MsgBox("Voulez vous supprimer cette parcelle?", vbYesNo)
                Select Case rep
                    Case vbYes
                        Timer2.Start()
                        RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 20
                        If (RedemptionProgressBar1.Value = 100) Then

                        End If
                        Mycommand.CommandText = "delete from PARCELLE where ID_Parcelle='" & formatstring(Me.txtnpc.Text) & "'"
                        MsgBox(" Parcelle supprimer ", vbInformation)
                        RedemptionProgressBar1.Value = 0
                        myreader.Close()
                        Mycommand.ExecuteNonQuery()
                        MyConnexion.Close()
                    Case vbNo

                        txtnpc.Text = ""
                        txtspf.Text = ""
                        txtnpuh.Text = ""
                        txtsctn.Text = ""
                        txtsctr.Text = ""
                        txtlo.Text = ""

                End Select
            Else
                RedemptionProgressBar1.Value = 0
                Timer1.Start()
                RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 10

                If RedemptionProgressBar1.Value = 50 Then
                    RedemptionProgressBar1.Value = 0
                End If

                MsgBox("La parcelle n'existe pas", vbCritical)
                RedemptionProgressBar1.Value = 0

            End If
        End If

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles btmaj.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")

        Dim rep As String
        Dim rep1 As String
        'empeche d entrer des valeurs null
        If txtnpc.Text = "" Or txtlo.Text = "" Or txtsctn.Text = "" Or txtsctr.Text = "" Or txtspf.Text = "" Then
            RedemptionProgressBar1.Value = 0
            Timer1.Start()
            RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 10

            If RedemptionProgressBar1.Value = 50 Then
                RedemptionProgressBar1.Value = 0


            End If

            MsgBox(" Renseigner les champs ", vbCritical)
            RedemptionProgressBar1.Value = 0
        Else
            'verifie si l utilisateur existe
            MyConnexion.Open()
            Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
            Mycommand.CommandText = "SELECT ID_Parcelle FROM PARCELLE where ID_Parcelle='" & txtnpc.Text & "'"

            Dim myreader As SqlDataReader = Mycommand.ExecuteReader

            If myreader.HasRows = True And myreader.Read() Then
                rep = MsgBox("Voulez vous mettre a jour cette parcelle?", vbYesNo)
                Select Case rep
                    Case vbYes
                        Timer2.Start()
                        RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 20
                        If (RedemptionProgressBar1.Value = 100) Then

                        End If
                        Mycommand.CommandText = "update PARCELLE set Superficie='" & formatstring(Me.txtspf.Text) & "', Lot='" & formatstring(Me.txtlo.Text) & "', Section='" & formatstring(Me.txtsctn.Text) & "', Secteur='" & formatstring(Me.txtsctr.Text) & "', PUH='" & formatstring(Me.txtnpuh.Text) & "' where ID_Parcelle='" & txtnpc.Text & "'"
                        MsgBox(" Parcelle mis a jour ", vbInformation)
                        RedemptionProgressBar1.Value = 0
                        rep1 = MsgBox(" Voulez vous ajouter un proprietaire a cette parcelle? ", vbYesNo)
                        Select Case rep1
                            Case vbYes
                                Label1.Visible = False
                                Label2.Visible = False
                                Label3.Visible = False
                                Label4.Visible = False
                                Label5.Visible = False
                                Label6.Visible = False

                                btaj.Visible = False
                                btmaj.Visible = False
                                btsup.Visible = False
                                btqt.Visible = False

                                txtlo.Visible = False
                                txtnpc.Visible = False
                                txtnpuh.Visible = False
                                txtsctn.Visible = False
                                txtsctr.Visible = False
                                txtspf.Visible = False

                                Label7.Visible = True
                                btaj2.Visible = True
                                btqt2.Visible = True
                                txtnppt.Visible = True

                            Case vbNo

                                txtnpc.Text = ""
                                txtspf.Text = ""
                                txtnpuh.Text = ""
                                txtsctn.Text = ""
                                txtsctr.Text = ""
                                txtlo.Text = ""

                        End Select
                        myreader.Close()
                        Mycommand.ExecuteNonQuery()
                        MyConnexion.Close()
                    Case vbNo

                        txtnpc.Text = ""
                        txtspf.Text = ""
                        txtnpuh.Text = ""
                        txtsctn.Text = ""
                        txtsctr.Text = ""
                        txtlo.Text = ""

                End Select
            Else
                RedemptionProgressBar1.Value = 0
                Timer1.Start()
                RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 10

                If RedemptionProgressBar1.Value = 50 Then
                    RedemptionProgressBar1.Value = 0
                End If

                MsgBox("La parcelle n'existe pas", vbCritical)
                RedemptionProgressBar1.Value = 0

            End If
        End If

    End Sub

    Private Sub btactu_Click(sender As Object, e As EventArgs) Handles btactu.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT * FROM PARCELLE"
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

    Private Sub btaj2_Click(sender As Object, e As EventArgs) Handles btaj2.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()

        Mycommand.CommandText = "SELECT ID_Prop FROM PROPRIETAIRE where ID_Prop='" & txtnppt.Text & "'"
        Dim myreader As SqlDataReader = Mycommand.ExecuteReader

        If myreader.HasRows = True And myreader.Read() Then

            Timer2.Start()
            RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 20
            If (RedemptionProgressBar1.Value = 100) Then

            End If
            Mycommand.CommandText = "update PARCELLE set ID_Prop = '" & formatstring(Me.txtnppt.Text) & "' where ID_Parcelle= '" & formatstring(Me.txtnpc.Text) & "'"
            MsgBox(" Proprietaire ajouter ", vbInformation)
            RedemptionProgressBar1.Value = 0
        Else
            Timer1.Start()
            RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 10

            If RedemptionProgressBar1.Value = 50 Then
                RedemptionProgressBar1.Value = 0
            End If
            MsgBox(" Proprietaire n'existe pas ", vbInformation)
            RedemptionProgressBar1.Value = 0


        End If

        myreader.Close()
        Mycommand.ExecuteNonQuery()
        MyConnexion.Close()

    End Sub

    Private Sub btqt2_Click(sender As Object, e As EventArgs) Handles btqt2.Click

        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True

        btaj.Visible = True
        btmaj.Visible = True
        btsup.Visible = True
        btqt.Visible = True

        txtlo.Visible = True
        txtnpc.Visible = True
        txtnpuh.Visible = True
        txtsctn.Visible = True
        txtsctr.Visible = True
        txtspf.Visible = True

        Label7.Visible = False
        btaj2.Visible = False
        btqt2.Visible = False
        txtnppt.Visible = False

    End Sub

End Class