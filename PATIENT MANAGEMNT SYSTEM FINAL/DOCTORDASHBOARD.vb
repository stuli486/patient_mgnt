Imports System.Data.OleDb
Public Class DOCTORDASHBOARD
    Public Shared doctor
    Dim connectionstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\patient.accdb"

    Private Sub Nurse_and_doctorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Nurse_and_doctorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Nurse_and_doctorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PatientDataSet)

    End Sub

    Private Sub DOCTORDASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Nurse_and_doctorBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PatientDataSet)
            MessageBox.Show("saved")

        Catch ex As Exception
            MessageBox.Show("error occured")

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Nurse_and_doctorBindingSource.AddNew()
    End Sub
End Class