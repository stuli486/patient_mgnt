Imports System.Data.OleDb

Public Class Form1
    Public Shared nurse
    Dim connectionstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\patient.accdb"


    Private Sub Nurse_and_doctorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Nurse_and_doctorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Nurse_and_doctorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PatientDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatientDataSet.nurse_and_doctor' table. You can move, or remove it, as needed.
        Me.Nurse_and_doctorTableAdapter.Fill(Me.PatientDataSet.nurse_and_doctor)

        Dim sql As String = " SELECT Name FROM patient_registration "
        Dim conn As New OleDbConnection(connectionstring)
        Dim cmd As New OleDbCommand(sql, conn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable

        Try
            conn.Open()
            da.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "name"
            ComboBox1.ValueMember = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            conn.Close()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New OleDbConnection(connectionstring)
        conn.Open()
        Dim cmd As New OleDbCommand("select * from patient_registration Where Name = @Name", conn)
        cmd.Parameters.AddWithValue("Name", ComboBox1.SelectedValue)
        Dim myreader As OleDbDataReader = cmd.ExecuteReader
        If myreader.Read() Then
            Label1.Text = "PATIENT_ID" & myreader("PATIENT_ID").ToString & vbCrLf & vbCrLf &
                "Name" & myreader("Name").ToString & vbCrLf & vbCrLf &
                "Surname" & myreader("Surname").ToString & vbCrLf & vbCrLf &
                "Gender" & myreader("Gender").ToString & vbCrLf & vbCrLf &
                "Date of birth" & myreader("Date of birth").ToString & vbCrLf & vbCrLf &
                "National id" & myreader("National id").ToString & vbCrLf & vbCrLf &
                "Medical aid" & myreader("Medical aid ").ToString & vbCrLf & vbCrLf &
                "Medical aid number" & myreader("Medical aid number").ToString & vbCrLf & vbCrLf &
                "Phone number " & myreader(" Phone number").ToString & vbCrLf & vbCrLf &
                "Address" & myreader("Address").ToString & vbCrLf & vbCrLf &
                "Next of Kin name" & myreader("Next of kin name").ToString & vbCrLf & vbCrLf &
                "Next of Kin surname" & myreader("Next of kin surname").ToString & vbCrLf & vbCrLf &
                "Next of Kin address" & myreader("Next of kin address").ToString & vbCrLf & vbCrLf &
                "Next of Kin phone number" & myreader("Next of kin phone number").ToString & vbCrLf & vbCrLf
        Else
            Label1.Text = ""
            MessageBox.Show("no data")





        End If






    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Nurse_and_doctorBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PatientDataSet)
            MessageBox.Show("saved")

        Catch ex As Exception
            MessageBox.Show("error occured")

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Nurse_and_doctorBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
