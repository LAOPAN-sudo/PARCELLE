Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class Form6

    Private Function formatstring(ByVal p1 As String) As String
        Return p1.ToString
    End Function

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub btvt_Click(sender As Object, e As EventArgs) Handles btvt.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")

        Dim rep As String
        'empeche d entrer des valeurs null
        If txtnppt.Text = "" Or txtddv.Text = "" Or txtnpc.Text = "" Or txtpdv.Text = "" Or txtvt.Text = "" Then
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
            Dim Mycommand1 As SqlCommand = MyConnexion.CreateCommand()
            Mycommand.CommandText = "SELECT ID_Prop FROM PROPRIETAIRE where ID_Prop='" & txtnppt.Text & "'"

            Dim myreader As SqlDataReader = Mycommand.ExecuteReader

            If myreader.HasRows = True And myreader.Read() Then
                rep = MsgBox("Voulez vous vendre cette parcelle a cet proprietaire?", vbYesNo)
                Select Case rep
                    Case vbYes
                        Timer2.Start()
                        RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 20
                        If (RedemptionProgressBar1.Value = 100) Then

                        End If
                        Mycommand1.CommandText = "INSERT INTO VENTE (ID_Vente,ID_Parcelle,ID_Prop,Date_Vente,Prix_Vente) VALUES ('" & formatstring(Me.txtvt.Text) & "','" & formatstring(Me.txtnpc.Text) & "','" & formatstring(Me.txtnppt.Text) & "','" & formatstring(Me.txtddv.Text) & "','" & formatstring(Me.txtpdv.Text) & "')"
                        Mycommand.CommandText = "update PARCELLE set ID_Prop='" & formatstring(Me.txtnppt.Text) & "' where ID_Parcelle='" & txtnpc.Text & "'"
                        MsgBox(" La parcelle a ete vendue a un nouveau proprietaire ", vbInformation)
                        RedemptionProgressBar1.Value = 0
                        myreader.Close()
                        Mycommand1.ExecuteNonQuery()
                        Mycommand.ExecuteNonQuery()
                        MyConnexion.Close()
                    Case vbNo

                        txtnppt.Text = ""
                        txtddv.Text = ""
                        txtnpc.Text = ""
                        txtvt.Text = ""
                        txtpdv.Text = ""


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

    Private Sub btqt_Click(sender As Object, e As EventArgs) Handles btqt.Click
        Me.Close()
        Form11.Show()
        Form3.Show()
    End Sub

    Private Sub btactu_Click(sender As Object, e As EventArgs) Handles btactu.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT * FROM VENTE"
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