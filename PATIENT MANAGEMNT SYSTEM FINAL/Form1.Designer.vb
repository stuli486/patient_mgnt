<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim WeightLabel As System.Windows.Forms.Label
        Dim HeightLabel As System.Windows.Forms.Label
        Dim Blood_pressureLabel As System.Windows.Forms.Label
        Dim TemperatureLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.Blood_pressureTextBox = New System.Windows.Forms.TextBox()
        Me.TemperatureTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        PATIENT_IDLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        HeightLabel = New System.Windows.Forms.Label()
        Blood_pressureLabel = New System.Windows.Forms.Label()
        TemperatureLabel = New System.Windows.Forms.Label()
        CType(Me.PatientDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nurse_and_doctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nurse_and_doctorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Nurse_and_doctorBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PATIENT_IDLabel
        '
        PATIENT_IDLabel.AutoSize = True
        PATIENT_IDLabel.Location = New System.Drawing.Point(12, 103)
        PATIENT_IDLabel.Name = "PATIENT_IDLabel"
        PATIENT_IDLabel.Size = New System.Drawing.Size(107, 16)
        PATIENT_IDLabel.TabIndex = 1
        PATIENT_IDLabel.Text = "PATIENT NAME"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(48, 141)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(52, 16)
        WeightLabel.TabIndex = 3
        WeightLabel.Text = "Weight:"
        '
        'HeightLabel
        '
        HeightLabel.AutoSize = True
        HeightLabel.Location = New System.Drawing.Point(48, 180)
        HeightLabel.Name = "HeightLabel"
        HeightLabel.Size = New System.Drawing.Size(49, 16)
        HeightLabel.TabIndex = 5
        HeightLabel.Text = "Height:"
        '
        'Blood_pressureLabel
        '
        Blood_pressureLabel.AutoSize = True
        Blood_pressureLabel.Location = New System.Drawing.Point(30, 222)
        Blood_pressureLabel.Name = "Blood_pressureLabel"
        Blood_pressureLabel.Size = New System.Drawing.Size(102, 16)
        Blood_pressureLabel.TabIndex = 7
        Blood_pressureLabel.Text = "Blood pressure:"
        '
        'TemperatureLabel
        '
        TemperatureLabel.AutoSize = True
        TemperatureLabel.Location = New System.Drawing.Point(44, 262)
        TemperatureLabel.Name = "TemperatureLabel"
        TemperatureLabel.Size = New System.Drawing.Size(88, 16)
        TemperatureLabel.TabIndex = 9
        TemperatureLabel.Text = "Temperature:"
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
        Me.Nurse_and_doctorBindingNavigator.Size = New System.Drawing.Size(1534, 31)
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Nurse_and_doctorBindingNavigatorSaveItem
        '
        Me.Nurse_and_doctorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nurse_and_doctorBindingNavigatorSaveItem.Image = CType(resources.GetObject("Nurse_and_doctorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Nurse_and_doctorBindingNavigatorSaveItem.Name = "Nurse_and_doctorBindingNavigatorSaveItem"
        Me.Nurse_and_doctorBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Nurse_and_doctorBindingNavigatorSaveItem.Text = "Save Data"
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nurse_and_doctorBindingSource, "Weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(138, 138)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(100, 22)
        Me.WeightTextBox.TabIndex = 4
        '
        'HeightTextBox
        '
        Me.HeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nurse_and_doctorBindingSource, "Height", True))
        Me.HeightTextBox.Location = New System.Drawing.Point(138, 174)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(100, 22)
        Me.HeightTextBox.TabIndex = 6
        '
        'Blood_pressureTextBox
        '
        Me.Blood_pressureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nurse_and_doctorBindingSource, "Blood pressure", True))
        Me.Blood_pressureTextBox.Location = New System.Drawing.Point(138, 222)
        Me.Blood_pressureTextBox.Name = "Blood_pressureTextBox"
        Me.Blood_pressureTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Blood_pressureTextBox.TabIndex = 8
        '
        'TemperatureTextBox
        '
        Me.TemperatureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nurse_and_doctorBindingSource, "Temperature", True))
        Me.TemperatureTextBox.Location = New System.Drawing.Point(138, 259)
        Me.TemperatureTextBox.Name = "TemperatureTextBox"
        Me.TemperatureTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TemperatureTextBox.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(138, 97)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(313, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(687, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 19
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(331, 349)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 23)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(164, 349)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 23)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(12, 349)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 23)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1534, 705)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(TemperatureLabel)
        Me.Controls.Add(Me.TemperatureTextBox)
        Me.Controls.Add(Blood_pressureLabel)
        Me.Controls.Add(Me.Blood_pressureTextBox)
        Me.Controls.Add(HeightLabel)
        Me.Controls.Add(Me.HeightTextBox)
        Me.Controls.Add(WeightLabel)
        Me.Controls.Add(Me.WeightTextBox)
        Me.Controls.Add(PATIENT_IDLabel)
        Me.Controls.Add(Me.Nurse_and_doctorBindingNavigator)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "NURSEDASHBOARD"
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
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents HeightTextBox As TextBox
    Friend WithEvents Blood_pressureTextBox As TextBox
    Friend WithEvents TemperatureTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
End Class
