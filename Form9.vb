

Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class Form9

    Private Function formatstring(ByVal p1 As String) As String
        Return p1.ToString
    End Function

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        StatusBar1.Text = "Status: " & formatstring(Form2.txtuser.Text) & "  connecté                                           " & Date.Now

    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT ID_Parcelle Parcelle_avec_proprietaire  FROM PARCELLE WHERE ID_Prop is not null"
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

    Private Sub btqt_Click(sender As Object, e As EventArgs) Handles btqt.Click

        Me.Close()
        Form11.Show()
        Form3.Show()

    End Sub

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT ID_Parcelle Parcelle_sans_proprietaire  FROM PARCELLE WHERE ID_Prop is null"
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

    Private Sub bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT count(ID_Parcelle) Nombre_de_parcelle  FROM PARCELLE"
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

    Private Sub RedemptionRoundButton4_Click(sender As Object, e As EventArgs) Handles bt4.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT min(Superficie) Superficie_minimum  FROM PARCELLE"
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

    Private Sub RedemptionRoundButton5_Click(sender As Object, e As EventArgs) Handles bt5.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT max(Superficie) Superficie_maximum  FROM PARCELLE"
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

    Private Sub RedemptionRoundButton1_Click(sender As Object, e As EventArgs) Handles bt6.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT Nom  FROM PROPRIETAIRE WHERE Sexe in ('m') "
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

    Private Sub bt7_Click(sender As Object, e As EventArgs) Handles bt7.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT count(ID_Prop) Nombre_de_proprietaire  FROM PROPRIETAIRE"
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

    Private Sub BT8_Click(sender As Object, e As EventArgs) Handles BT8.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT Nom  FROM PROPRIETAIRE WHERE Datenais in ('10/10/2010')"
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

    Private Sub BT9_Click(sender As Object, e As EventArgs) Handles BT9.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT Nom  FROM PROPRIETAIRE WHERE Sexe= 'f'"
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

    
    Private Sub RedemptionRoundButton1_Click_1(sender As Object, e As EventArgs) Handles BT10.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT ID_Prop  FROM VENTE"
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

    Private Sub BT11_Click(sender As Object, e As EventArgs) Handles BT11.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT ID_Parcelle  FROM VENTE WHERE Prix_Vente>3000000"
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

    Private Sub BT12_Click(sender As Object, e As EventArgs) Handles BT12.Click

        Dim MyConnexion As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PARE\Documents\Projet PARCELLE\PARCELLE\PARCELLE\BD_GESTION_PARCELLE.mdf;Integrated Security=True;Connect Timeout=30")
        MyConnexion.Open()
        Dim Mycommand As SqlCommand = MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT ID_Parcelle  FROM VENTE WHERE Date_Vente =('10/10/10')"
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        StatusBar1.Text = "Status: " & formatstring(Form2.txtuser.Text) & "  connecté                                           " & Date.Now


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class