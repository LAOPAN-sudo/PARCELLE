Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class Form7

    Private Function formatstring(ByVal p1 As String) As String
        Return p1.ToString
    End Function

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles btaff.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")

        Dim rep As String
        'Dim err As String
        'empeche d entrer des valeurs null
        If txtnaff.Text = "" Or txtnpc.Text = "" Or txtdaff.Text = "" Or ComboBox1.Text = "" Then
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
            Dim Mycommand1 As SqlCommand = MyConnexion.CreateCommand()
            Mycommand.CommandText = "SELECT ID_Parcelle FROM PARCELLE where ID_Parcelle='" & txtnpc.Text & "'"
            Dim myreader As SqlDataReader = Mycommand.ExecuteReader

            If myreader.HasRows = True And myreader.Read() Then
                rep = MsgBox("Voulez vous attribuer cette parcelle?", vbYesNo)
                Select Case rep
                    Case vbYes
                        Timer2.Start()
                        RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 20
                        If (RedemptionProgressBar1.Value = 100) Then

                        End If
                        Mycommand.CommandText = "INSERT INTO AFFECTATION (ID_Affectation,ID_Parcelle,Date_Aff,Motif) VALUES ('" & formatstring(Me.txtnaff.Text) & "','" & formatstring(Me.txtnpc.Text) & "','" & formatstring(Me.txtdaff.Text) & "','" & formatstring(Me.ComboBox1.Text) & "')"
                        Mycommand1.CommandText = "update PARCELLE set ID_Prop='" & formatstring(Me.txtattr.Text) & "' where ID_Parcelle='" & txtnpc.Text & "'"
                        MsgBox(" Parcelle attribuer ", vbInformation)
                        RedemptionProgressBar1.Value = 0
                        myreader.Close()
                        Mycommand.ExecuteNonQuery()
                        Mycommand1.ExecuteNonQuery()
                        MyConnexion.Close()
                    Case vbNo
                        txtnaff.Text = ""
                        txtnpc.Text = ""
                        txtdaff.Text = ""
                        ComboBox1.Text = ""

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

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles btqt.Click
        Me.Close()
        Form11.Show()
        Form3.Show()
    End Sub

    Private Sub btactu_Click(sender As Object, e As EventArgs) Handles btactu.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT * FROM AFFECTATION"
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

    Private Sub btactu2_Click(sender As Object, e As EventArgs) Handles btactu2.Click

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
        Me.DataGridView2.DataSource = dt
        Me.Show()

        Dim myReader As SqlDataReader = Mycommand.ExecuteReader()
        ' Dim da_1 As New SqlDataAdapter(Mycommand.CommandText)
        Dim ds_1 As New DataSet
        myReader.Close()
        MyConnexion.Close()

    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles btmaj.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")

        Dim rep As String
        'empeche d entrer des valeurs null
        If txtnaff.Text = "" Or txtnpc.Text = "" Or txtdaff.Text = "" Or ComboBox1.Text = "" Then
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
            Mycommand.CommandText = "SELECT ID_Affectation,ID_Parcelle FROM AFFECTATION where ID_Parcelle='" & txtnpc.Text & "' and ID_Affectation='" & txtnaff.Text & "'"

            Dim myreader As SqlDataReader = Mycommand.ExecuteReader

            If myreader.HasRows = True And myreader.Read() Then
                rep = MsgBox("Voulez vous mettre a jour cet proprietaire?", vbYesNo)
                Select Case rep
                    Case vbYes
                        Timer2.Start()
                        RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 20
                        If (RedemptionProgressBar1.Value = 100) Then

                        End If
                        Mycommand.CommandText = "update AFFECTATION set ID_Parcelle='" & formatstring(Me.txtnpc.Text) & "', Date_Aff='" & formatstring(Me.txtdaff.Text) & "', Motif='" & formatstring(Me.ComboBox1.Text) & "' where ID_Affectation='" & txtnaff.Text & "'"
                        MsgBox(" Parcelle mise a jour ", vbInformation)
                        RedemptionProgressBar1.Value = 0
                        myreader.Close()
                        Mycommand.ExecuteNonQuery()
                        MyConnexion.Close()
                    Case vbNo

                        txtnaff.Text = ""
                        txtnpc.Text = ""
                        txtdaff.Text = ""
                        ComboBox1.Text = ""


                End Select
            Else
                RedemptionProgressBar1.Value = 0
                Timer1.Start()
                RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 10

                If RedemptionProgressBar1.Value = 50 Then
                    RedemptionProgressBar1.Value = 0
                End If

                MsgBox("L'Affectation n'existe pas", vbCritical)
                RedemptionProgressBar1.Value = 0

            End If
        End If

    End Sub

End Class