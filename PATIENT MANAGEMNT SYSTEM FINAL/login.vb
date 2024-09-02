Imports System.Data.OleDb

Public Class login
    Dim con As New OleDbConnection
    Dim dbprovider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbsource As String = "Data Source=|DataDirectory|\patient.accdb"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show(" fill in the fields")
        Else
            Try
                con.Open()
                Using cmd As New OleDbCommand("SELECT * FROM login WHERE [USERNAME]= @Username AND [PASSWORD]=@Password", con)
                    cmd.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = TextBox1.Text.Trim
                    cmd.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = TextBox2.Text.Trim

                    Dim ds As New OleDbDataAdapter(cmd)
                    Dim mytable As New DataTable
                    ds.Fill(mytable)


                    If mytable.Rows(0)("Usertype") = "doctor" Then
                        Dim doctor As New DOCTORDASHBOARD
                        DOCTORDASHBOARD.doctor = TextBox3.Text
                        DOCTORDASHBOARD.Show()

                    ElseIf mytable.Rows(0)("Usertype") = "nurse" Then
                        Dim nurse As New Form1
                        Form1.nurse = TextBox3.Text
                        Form1.Show()

                    ElseIf mytable.Rows(0)("Usertype") = "reception" Then
                        Dim reception As New RegistrationDashboard
                        RegistrationDashboard.reception = TextBox3.Text
                        RegistrationDashboard.Show()

                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("wrong information")
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbprovider & dbsource
    End Sub
End Class