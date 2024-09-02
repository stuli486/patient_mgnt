<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationDashboard
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Date_of_birthLabel As System.Windows.Forms.Label
        Dim National_idLabel As System.Windows.Forms.Label
        Dim Medical_aidLabel As System.Windows.Forms.Label
        Dim Medical_aid_numberLabel As System.Windows.Forms.Label
        Dim Phone_numberLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Next_of_kin_nameLabel As System.Windows.Forms.Label
        Dim Next_of_kin_surnameLabel As System.Windows.Forms.Label
        Dim Next_of_kin_phone_numberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationDashboard))
        Me.PatientDataSet = New PATIENT_MANAGEMNT_SYSTEM_FINAL.patientDataSet()
        Me.Patient_registrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Patient_registrationTableAdapter = New PATIENT_MANAGEMNT_SYSTEM_FINAL.patientDataSetTableAdapters.patient_registrationTableAdapter()
        Me.TableAdapterManager = New PATIENT_MANAGEMNT_SYSTEM_FINAL.patientDataSetTableAdapters.TableAdapterManager()
        Me.Patient_registrationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Patient_registrationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_birthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.National_idTextBox = New System.Windows.Forms.TextBox()
        Me.Medical_aidTextBox = New System.Windows.Forms.TextBox()
        Me.Medical_aid_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_numberTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Next_of_kin_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Next_of_kin_surnameTextBox = New System.Windows.Forms.TextBox()
        Me.Next_of_kin_phone_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        NameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Date_of_birthLabel = New System.Windows.Forms.Label()
        National_idLabel = New System.Windows.Forms.Label()
        Medical_aidLabel = New System.Windows.Forms.Label()
        Medical_aid_numberLabel = New System.Windows.Forms.Label()
        Phone_numberLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Next_of_kin_nameLabel = New System.Windows.Forms.Label()
        Next_of_kin_surnameLabel = New System.Windows.Forms.Label()
        Next_of_kin_phone_numberLabel = New System.Windows.Forms.Label()
        CType(Me.PatientDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_registrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_registrationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Patient_registrationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(57, 94)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(47, 16)
        NameLabel.TabIndex = 1
        NameLabel.Text = "Name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(57, 136)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(64, 16)
        SurnameLabel.TabIndex = 3
        SurnameLabel.Text = "Surname:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(58, 177)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(55, 16)
        GenderLabel.TabIndex = 5
        GenderLabel.Text = "Gender:"
        '
        'Date_of_birthLabel
        '
        Date_of_birthLabel.AutoSize = True
        Date_of_birthLabel.Location = New System.Drawing.Point(58, 217)
        Date_of_birthLabel.Name = "Date_of_birthLabel"
        Date_of_birthLabel.Size = New System.Drawing.Size(81, 16)
        Date_of_birthLabel.TabIndex = 7
        Date_of_birthLabel.Text = "Date of birth:"
        AddHandler Date_of_birthLabel.Click, AddressOf Me.Date_of_birthLabel_Click
        '
        'National_idLabel
        '
        National_idLabel.AutoSize = True
        National_idLabel.Location = New System.Drawing.Point(58, 262)
        National_idLabel.Name = "National_idLabel"
        National_idLabel.Size = New System.Drawing.Size(74, 16)
        National_idLabel.TabIndex = 9
        National_idLabel.Text = "National id:"
        '
        'Medical_aidLabel
        '
        Medical_aidLabel.AutoSize = True
        Medical_aidLabel.Location = New System.Drawing.Point(57, 300)
        Medical_aidLabel.Name = "Medical_aidLabel"
        Medical_aidLabel.Size = New System.Drawing.Size(80, 16)
        Medical_aidLabel.TabIndex = 11
        Medical_aidLabel.Text = "Medical aid:"
        '
        'Medical_aid_numberLabel
        '
        Medical_aid_numberLabel.AutoSize = True
        Medical_aid_numberLabel.Location = New System.Drawing.Point(57, 349)
        Medical_aid_numberLabel.Name = "Medical_aid_numberLabel"
        Medical_aid_numberLabel.Size = New System.Drawing.Size(128, 16)
        Medical_aid_numberLabel.TabIndex = 13
        Medical_aid_numberLabel.Text = "Medical aid number:"
        AddHandler Medical_aid_numberLabel.Click, AddressOf Me.Medical_aid_numberLabel_Click
        '
        'Phone_numberLabel
        '
        Phone_numberLabel.AutoSize = True
        Phone_numberLabel.Location = New System.Drawing.Point(58, 395)
        Phone_numberLabel.Name = "Phone_numberLabel"
        Phone_numberLabel.Size = New System.Drawing.Size(97, 16)
        Phone_numberLabel.TabIndex = 15
        Phone_numberLabel.Text = "Phone number:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(57, 437)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(61, 16)
        AddressLabel.TabIndex = 17
        AddressLabel.Text = "Address:"
        '
        'Next_of_kin_nameLabel
        '
        Next_of_kin_nameLabel.AutoSize = True
        Next_of_kin_nameLabel.Location = New System.Drawing.Point(57, 472)
        Next_of_kin_nameLabel.Name = "Next_of_kin_nameLabel"
        Next_of_kin_nameLabel.Size = New System.Drawing.Size(108, 16)
        Next_of_kin_nameLabel.TabIndex = 19
        Next_of_kin_nameLabel.Text = "Next of kin name:"
        '
        'Next_of_kin_surnameLabel
        '
        Next_of_kin_surnameLabel.AutoSize = True
        Next_of_kin_surnameLabel.Location = New System.Drawing.Point(57, 517)
        Next_of_kin_surnameLabel.Name = "Next_of_kin_surnameLabel"
        Next_of_kin_surnameLabel.Size = New System.Drawing.Size(126, 16)
        Next_of_kin_surnameLabel.TabIndex = 21
        Next_of_kin_surnameLabel.Text = "Next of kin surname:"
        '
        'Next_of_kin_phone_numberLabel
        '
        Next_of_kin_phone_numberLabel.AutoSize = True
        Next_of_kin_phone_numberLabel.Location = New System.Drawing.Point(48, 569)
        Next_of_kin_phone_numberLabel.Name = "Next_of_kin_phone_numberLabel"
        Next_of_kin_phone_numberLabel.Size = New System.Drawing.Size(160, 16)
        Next_of_kin_phone_numberLabel.TabIndex = 23
        Next_of_kin_phone_numberLabel.Text = "Next of kin phone number:"
        '
        'PatientDataSet
        '
        Me.PatientDataSet.DataSetName = "patientDataSet"
        Me.PatientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Patient_registrationBindingSource
        '
        Me.Patient_registrationBindingSource.DataMember = "patient_registration"
        Me.Patient_registrationBindingSource.DataSource = Me.PatientDataSet
        '
        'Patient_registrationTableAdapter
        '
        Me.Patient_registrationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.admissionsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.loginTableAdapter = Nothing
        Me.TableAdapterManager.nurse_and_doctorTableAdapter = Nothing
        Me.TableAdapterManager.patient_registrationTableAdapter = Me.Patient_registrationTableAdapter
        Me.TableAdapterManager.UpdateOrder = PATIENT_MANAGEMNT_SYSTEM_FINAL.patientDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Patient_registrationBindingNavigator
        '
        Me.Patient_registrationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Patient_registrationBindingNavigator.BindingSource = Me.Patient_registrationBindingSource
        Me.Patient_registrationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Patient_registrationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Patient_registrationBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Patient_registrationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Patient_registrationBindingNavigatorSaveItem})
        Me.Patient_registrationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Patient_registrationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Patient_registrationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Patient_registrationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Patient_registrationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Patient_registrationBindingNavigator.Name = "Patient_registrationBindingNavigator"
        Me.Patient_registrationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Patient_registrationBindingNavigator.Size = New System.Drawing.Size(1370, 31)
        Me.Patient_registrationBindingNavigator.TabIndex = 0
        Me.Patient_registrationBindingNavigator.Text = "BindingNavigator1"
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
        'Patient_registrationBindingNavigatorSaveItem
        '
        Me.Patient_registrationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Patient_registrationBindingNavigatorSaveItem.Image = CType(resources.GetObject("Patient_registrationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Patient_registrationBindingNavigatorSaveItem.Name = "Patient_registrationBindingNavigatorSaveItem"
        Me.Patient_registrationBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Patient_registrationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_registrationBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(203, 91)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NameTextBox.TabIndex = 2
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_registrationBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(203, 130)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SurnameTextBox.TabIndex = 4
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_registrationBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(203, 174)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(100, 22)
        Me.GenderTextBox.TabIndex = 6
        '
        'Date_of_birthDateTimePicker
        '
        Me.Date_of_birthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Patient_registrationBindingSource, "Date of birth", True))
        Me.Date_of_birthDateTimePicker.Location = New System.Drawing.Point(194, 212)
        Me.Date_of_birthDateTimePicker.Name = "Date_of_birthDateTimePicker"
        Me.Date_of_birthDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Date_of_birthDateTimePicker.TabIndex = 8
        '
        'National_idTextBox
        '
        Me.National_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_registrationBindingSource, "National id", True))
        Me.National_idTextBox.Location = New System.Drawing.Point(203, 256)
        Me.National_idTextBox.Name = "National_idTextBox"
        Me.National_idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.National_idTextBox.TabIndex = 10
        '
        'Medical_aidTextBox
        '
        Me.Medical_aidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_registrationBindingSource, "Medical aid", True))
        Me.Medical_aidTextBox.Location = New System.Drawing.Point(203, 294)
        Me.Medical_aidTextBox.Name = "Medical_aidTextBox"
        Me.Medical_aidTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Medical_aidTextBox.TabIndex = 12
        '
        'Medical_aid_numberTextBox
        '
        Me.Medical_aid_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_registrationBindingSource, "Medical aid number", True))
        Me.Medical_aid_numberTextBox.Location = New System.Drawing.Point(203, 343)
        Me.Medical_aid_numberTextBox.Name = "Medical_aid_numberTextBox"
        Me.Medical_aid_numberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Medical_aid_numberTextBox.TabIndex = 14
        '
        'Phone_numberTextBox
        '
        Me.Phone_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_registrationBindingSource, "Phone number", True))
        Me.Phone_numberTextBox.Location = New System.Drawing.Point(203, 389)
        Me.Phone_numberTextBox.Name = "Phone_numberTextBox"
        Me.Phone_numberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Phone_numberTextBox.TabIndex = 16
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_registrationBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(203, 431)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AddressTextBox.TabIndex = 18
        '
        'Next_of_kin_nameTextBox
        '
        Me.Next_of_kin_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_registrationBindingSource, "Next of kin name", True))
        Me.Next_of_kin_nameTextBox.Location = New System.Drawing.Point(203, 511)
        Me.Next_of_kin_nameTextBox.Name = "Next_of_kin_nameTextBox"
        Me.Next_of_kin_nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Next_of_kin_nameTextBox.TabIndex = 20
        '
        'Next_of_kin_surnameTextBox
        '
        Me.Next_of_kin_surnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_registrationBindingSource, "Next of kin surname", True))
        Me.Next_of_kin_surnameTextBox.Location = New System.Drawing.Point(203, 472)
        Me.Next_of_kin_surnameTextBox.Name = "Next_of_kin_surnameTextBox"
        Me.Next_of_kin_surnameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Next_of_kin_surnameTextBox.TabIndex = 22
        '
        'Next_of_kin_phone_numberTextBox
        '
        Me.Next_of_kin_phone_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_registrationBindingSource, "Next of kin phone number", True))
        Me.Next_of_kin_phone_numberTextBox.Location = New System.Drawing.Point(223, 563)
        Me.Next_of_kin_phone_numberTextBox.Name = "Next_of_kin_phone_numberTextBox"
        Me.Next_of_kin_phone_numberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Next_of_kin_phone_numberTextBox.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(51, 632)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "REGISTER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(203, 632)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 23)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(370, 632)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 23)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RegistrationDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1370, 715)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Next_of_kin_phone_numberLabel)
        Me.Controls.Add(Me.Next_of_kin_phone_numberTextBox)
        Me.Controls.Add(Next_of_kin_surnameLabel)
        Me.Controls.Add(Me.Next_of_kin_surnameTextBox)
        Me.Controls.Add(Next_of_kin_nameLabel)
        Me.Controls.Add(Me.Next_of_kin_nameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Phone_numberLabel)
        Me.Controls.Add(Me.Phone_numberTextBox)
        Me.Controls.Add(Medical_aid_numberLabel)
        Me.Controls.Add(Me.Medical_aid_numberTextBox)
        Me.Controls.Add(Medical_aidLabel)
        Me.Controls.Add(Me.Medical_aidTextBox)
        Me.Controls.Add(National_idLabel)
        Me.Controls.Add(Me.National_idTextBox)
        Me.Controls.Add(Date_of_birthLabel)
        Me.Controls.Add(Me.Date_of_birthDateTimePicker)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Patient_registrationBindingNavigator)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "RegistrationDashboard"
        Me.Text = "RegistrationDashboard"
        CType(Me.PatientDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_registrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_registrationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Patient_registrationBindingNavigator.ResumeLayout(False)
        Me.Patient_registrationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PatientDataSet As patientDataSet
    Friend WithEvents Patient_registrationBindingSource As BindingSource
    Friend WithEvents Patient_registrationTableAdapter As patientDataSetTableAdapters.patient_registrationTableAdapter
    Friend WithEvents TableAdapterManager As patientDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Patient_registrationBindingNavigator As BindingNavigator
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
    Friend WithEvents Patient_registrationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents Date_of_birthDateTimePicker As DateTimePicker
    Friend WithEvents National_idTextBox As TextBox
    Friend WithEvents Medical_aidTextBox As TextBox
    Friend WithEvents Medical_aid_numberTextBox As TextBox
    Friend WithEvents Phone_numberTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Next_of_kin_nameTextBox As TextBox
    Friend WithEvents Next_of_kin_surnameTextBox As TextBox
    Friend WithEvents Next_of_kin_phone_numberTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
