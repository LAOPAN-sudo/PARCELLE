
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class Form8

    Private Function formatstring(ByVal p1 As String) As String
        Return p1.ToString
    End Function

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        StatusBar1.Text = "Status: " & formatstring(Form2.txtuser.Text) & "  connecté                                           " & Date.Now

    End Sub

    Private Sub btqt_Click(sender As Object, e As EventArgs) Handles btqt.Click
        Me.Close()
        Form11.Show()
        Form3.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        StatusBar1.Text = "Status: " & formatstring(Form2.txtuser.Text) & "  connecté                                           " & Date.Now


    End Sub

    Private Sub RedemptionButton1_Click(sender As Object, e As EventArgs) Handles btactu.Click
        If txtnpc.Text = "" Then
            MsgBox("veuillez remplir le champ", vbCritical)
        Else
            Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
            MyConnexion.Open()
            Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
            Mycommand.CommandText = "SELECT * FROM PARCELLE WHERE ID_Parcelle='" & txtnpc.Text & "'"
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
        End If
    End Sub

End Class