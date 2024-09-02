Public Class RegistrationDashboard
    Public Shared reception
    Private Sub Patient_registrationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Patient_registrationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Patient_registrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PatientDataSet)

    End Sub

    Private Sub RegistrationDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatientDataSet.patient_registration' table. You can move, or remove it, as needed.
        Me.Patient_registrationTableAdapter.Fill(Me.PatientDataSet.patient_registration)

    End Sub

    Private Sub Date_of_birthLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Date_of_birthDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Date_of_birthDateTimePicker.ValueChanged

    End Sub

    Private Sub Medical_aid_numberLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Patient_registrationBindingSource.AddNew()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Patient_registrationBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PatientDataSet)
            MessageBox.Show("saved")

        Catch ex As Exception
            MessageBox.Show("error occured")

        End Try

    End Sub

    Private Sub Next_of_kin_phone_numberTextBox_TextChanged(sender As Object, e As EventArgs) Handles Next_of_kin_phone_numberTextBox.TextChanged

    End Sub
End Class