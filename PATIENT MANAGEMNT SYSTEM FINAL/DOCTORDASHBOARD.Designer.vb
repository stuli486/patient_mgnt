<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOCTORDASHBOARD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PATIENT_IDLabel As System.Windows.Forms.Label
        Dim DiagnosisLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim PrescriptionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DOCTORDASHBOARD))
        Me.PatientDataSet = New PATIENT_MANAGEMNT_SYSTEM_FINAL.patientDataSet()
        Me.Nurse_and_doctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Nurse_and_doctorTableAdapter = New PATIENT_MANAGEMNT_SYSTEM_FINAL.patientDataSetTableAdapters.nurse_and_doctorTableAdapter()
        Me.TableAdapterManager = New PATIENT_MANAGEMNT_SYSTEM_FINAL.patientDataSetTableAdapters.TableAdapterManager()
        Me.Nurse_and_doctorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Nurse_and_doctorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DiagnosisTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.PrescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        PATIENT_IDLabel = New System.Windows.Forms.Label()
        DiagnosisLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        PrescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.PatientDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nurse_and_doctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nurse_and_doctorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Nurse_and_doctorBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PATIENT_IDLabel
        '
        PATIENT_IDLabel.AutoSize = True
        PATIENT_IDLabel.Location = New System.Drawing.Point(12, 71)
        PATIENT_IDLabel.Name = "PATIENT_IDLabel"
        PATIENT_IDLabel.Size = New System.Drawing.Size(107, 16)
        PATIENT_IDLabel.TabIndex = 1
        PATIENT_IDLabel.Text = "PATIENT NAME"
        '
        'DiagnosisLabel
        '
        DiagnosisLabel.AutoSize = True
        DiagnosisLabel.Location = New System.Drawing.Point(12, 126)
        DiagnosisLabel.Name = "DiagnosisLabel"
        DiagnosisLabel.Size = New System.Drawing.Size(71, 16)
        DiagnosisLabel.TabIndex = 3
        DiagnosisLabel.Text = "Diagnosis:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(12, 178)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(46, 16)
        NotesLabel.TabIndex = 5
        NotesLabel.Text = "Notes:"
        '
        'PrescriptionLabel
        '
        PrescriptionLabel.AutoSize = True
        PrescriptionLabel.Location = New System.Drawing.Point(12, 231)
        PrescriptionLabel.Name = "PrescriptionLabel"
        PrescriptionLabel.Size = New System.Drawing.Size(81, 16)
        PrescriptionLabel.TabIndex = 7
        PrescriptionLabel.Text = "Prescription:"
        '
        'PatientDataSet
        '
        Me.PatientDataSet.DataSetName = "patientDataSet"
        Me.PatientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nurse_and_doctorBindingSource
        '
        Me.Nurse_and_doctorBindingSource.DataMember = "nurse_and_doctor"
        Me.Nurse_and_doctorBindingSource.DataSource = Me.PatientDataSet
        '
        'Nurse_and_doctorTableAdapter
        '
        Me.Nurse_and_doctorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.admissionsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.loginTableAdapter = Nothing
        Me.TableAdapterManager.nurse_and_doctorTableAdapter = Me.Nurse_and_doctorTableAdapter
        Me.TableAdapterManager.patient_registrationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PATIENT_MANAGEMNT_SYSTEM_FINAL.patientDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Nurse_and_doctorBindingNavigator
        '
        Me.Nurse_and_doctorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Nurse_and_doctorBindingNavigator.BindingSource = Me.Nurse_and_doctorBindingSource
        Me.Nurse_and_doctorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Nurse_and_doctorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Nurse_and_doctorBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Nurse_and_doctorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Nurse_and_doctorBindingNavigatorSaveItem})
        Me.Nurse_and_doctorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Nurse_and_doctorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Nurse_and_doctorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Nurse_and_doctorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Nurse_and_doctorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Nurse_and_doctorBindingNavigator.Name = "Nurse_and_doctorBindingNavigator"
        Me.Nurse_and_doctorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Nurse_and_doctorBindingNavigator.Size = New System.Drawing.Size(1175, 31)
        Me.Nurse_and_doctorBindingNavigator.TabIndex = 0
        Me.Nurse_and_doctorBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'Nurse_and_doctorBindingNavigatorSaveItem
        '
        Me.Nurse_and_doctorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nurse_and_doctorBindingNavigatorSaveItem.Image = CType(resources.GetObject("Nurse_and_doctorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Nurse_and_doctorBindingNavigatorSaveItem.Name = "Nurse_and_doctorBindingNavigatorSaveItem"
        Me.Nurse_and_doctorBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.Nurse_and_doctorBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DiagnosisTextBox
        '
        Me.DiagnosisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nurse_and_doctorBindingSource, "Diagnosis", True))
        Me.DiagnosisTextBox.Location = New System.Drawing.Point(146, 126)
        Me.DiagnosisTextBox.Name = "DiagnosisTextBox"
        Me.DiagnosisTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DiagnosisTextBox.TabIndex = 4
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nurse_and_doctorBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(146, 178)
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NotesTextBox.TabIndex = 6
        '
        'PrescriptionTextBox
        '
        Me.PrescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nurse_and_doctorBindingSource, "Prescription", True))
        Me.PrescriptionTextBox.Location = New System.Drawing.Point(146, 231)
        Me.PrescriptionTextBox.Name = "PrescriptionTextBox"
        Me.PrescriptionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PrescriptionTextBox.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(325, 298)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 23)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(158, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 23)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(6, 298)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 23)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(135, 71)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 34
        '
        'DOCTORDASHBOARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1175, 674)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(PrescriptionLabel)
        Me.Controls.Add(Me.PrescriptionTextBox)
        Me.Controls.Add(NotesLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(DiagnosisLabel)
        Me.Controls.Add(Me.DiagnosisTextBox)
        Me.Controls.Add(PATIENT_IDLabel)
        Me.Controls.Add(Me.Nurse_and_doctorBindingNavigator)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "DOCTORDASHBOARD"
        Me.Text = " "
        CType(Me.PatientDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nurse_and_doctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nurse_and_doctorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Nurse_and_doctorBindingNavigator.ResumeLayout(False)
        Me.Nurse_and_doctorBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PatientDataSet As patientDataSet
    Friend WithEvents Nurse_and_doctorBindingSource As BindingSource
    Friend WithEvents Nurse_and_doctorTableAdapter As patientDataSetTableAdapters.nurse_and_doctorTableAdapter
    Friend WithEvents TableAdapterManager As patientDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Nurse_and_doctorBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Nurse_and_doctorBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DiagnosisTextBox As TextBox
    Friend WithEvents NotesTextBox As TextBox
    Friend WithEvents PrescriptionTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
