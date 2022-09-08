<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnCalculateSalary = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.rtxtWageDetails = New System.Windows.Forms.RichTextBox()
        Me.grpWorkingHours = New System.Windows.Forms.GroupBox()
        Me.txtDaysPerWeek = New System.Windows.Forms.TextBox()
        Me.txtHoursPerDay = New System.Windows.Forms.TextBox()
        Me.lblWorkingHours = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpContactDetails = New System.Windows.Forms.GroupBox()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblMobileNumber = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.grpPersonalDetails = New System.Windows.Forms.GroupBox()
        Me.txtIdNo = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpWorkingHours.SuspendLayout()
        Me.grpContactDetails.SuspendLayout()
        Me.grpPersonalDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Chocolate
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblTitle)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCalculateSalary)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnExit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnClear)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rtxtWageDetails)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpWorkingHours)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpContactDetails)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpPersonalDetails)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1020, 521)
        Me.SplitContainer1.SplitterDistance = 281
        Me.SplitContainer1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Employee_Management_System.My.Resources.Resources.brooke_cagle_g1Kr4Ozfoac_unsplash
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(290, 518)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Location = New System.Drawing.Point(179, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(437, 32)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "EMPLOYEE MANAGEMENT SYSTEM"
        '
        'btnCalculateSalary
        '
        Me.btnCalculateSalary.Location = New System.Drawing.Point(286, 467)
        Me.btnCalculateSalary.Name = "btnCalculateSalary"
        Me.btnCalculateSalary.Size = New System.Drawing.Size(164, 23)
        Me.btnCalculateSalary.TabIndex = 5
        Me.btnCalculateSalary.Text = "CALCULATE WAGE"
        Me.btnCalculateSalary.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(596, 467)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(43, 467)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'rtxtWageDetails
        '
        Me.rtxtWageDetails.Location = New System.Drawing.Point(377, 253)
        Me.rtxtWageDetails.Name = "rtxtWageDetails"
        Me.rtxtWageDetails.Size = New System.Drawing.Size(346, 167)
        Me.rtxtWageDetails.TabIndex = 2
        Me.rtxtWageDetails.Text = ""
        '
        'grpWorkingHours
        '
        Me.grpWorkingHours.Controls.Add(Me.txtDaysPerWeek)
        Me.grpWorkingHours.Controls.Add(Me.txtHoursPerDay)
        Me.grpWorkingHours.Controls.Add(Me.lblWorkingHours)
        Me.grpWorkingHours.Controls.Add(Me.Label6)
        Me.grpWorkingHours.Location = New System.Drawing.Point(14, 253)
        Me.grpWorkingHours.Name = "grpWorkingHours"
        Me.grpWorkingHours.Size = New System.Drawing.Size(346, 167)
        Me.grpWorkingHours.TabIndex = 1
        Me.grpWorkingHours.TabStop = False
        Me.grpWorkingHours.Text = "Working Details"
        '
        'txtDaysPerWeek
        '
        Me.txtDaysPerWeek.Location = New System.Drawing.Point(96, 116)
        Me.txtDaysPerWeek.Name = "txtDaysPerWeek"
        Me.txtDaysPerWeek.Size = New System.Drawing.Size(233, 20)
        Me.txtDaysPerWeek.TabIndex = 5
        '
        'txtHoursPerDay
        '
        Me.txtHoursPerDay.Location = New System.Drawing.Point(96, 46)
        Me.txtHoursPerDay.Name = "txtHoursPerDay"
        Me.txtHoursPerDay.Size = New System.Drawing.Size(233, 20)
        Me.txtHoursPerDay.TabIndex = 6
        '
        'lblWorkingHours
        '
        Me.lblWorkingHours.AutoSize = True
        Me.lblWorkingHours.Location = New System.Drawing.Point(14, 49)
        Me.lblWorkingHours.Name = "lblWorkingHours"
        Me.lblWorkingHours.Size = New System.Drawing.Size(76, 13)
        Me.lblWorkingHours.TabIndex = 4
        Me.lblWorkingHours.Text = "Hours Per Day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Days Per Week"
        '
        'grpContactDetails
        '
        Me.grpContactDetails.Controls.Add(Me.txtMobileNo)
        Me.grpContactDetails.Controls.Add(Me.txtEmail)
        Me.grpContactDetails.Controls.Add(Me.lblMobileNumber)
        Me.grpContactDetails.Controls.Add(Me.lblEmail)
        Me.grpContactDetails.Location = New System.Drawing.Point(377, 92)
        Me.grpContactDetails.Name = "grpContactDetails"
        Me.grpContactDetails.Size = New System.Drawing.Size(346, 124)
        Me.grpContactDetails.TabIndex = 1
        Me.grpContactDetails.TabStop = False
        Me.grpContactDetails.Text = "Contact Details"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(107, 43)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(233, 20)
        Me.txtMobileNo.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(107, 88)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(233, 20)
        Me.txtEmail.TabIndex = 5
        '
        'lblMobileNumber
        '
        Me.lblMobileNumber.AutoSize = True
        Me.lblMobileNumber.Location = New System.Drawing.Point(14, 46)
        Me.lblMobileNumber.Name = "lblMobileNumber"
        Me.lblMobileNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblMobileNumber.TabIndex = 2
        Me.lblMobileNumber.Text = "Mobile Number"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(14, 91)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email"
        '
        'grpPersonalDetails
        '
        Me.grpPersonalDetails.Controls.Add(Me.txtIdNo)
        Me.grpPersonalDetails.Controls.Add(Me.txtLastName)
        Me.grpPersonalDetails.Controls.Add(Me.Label1)
        Me.grpPersonalDetails.Controls.Add(Me.txtFirstName)
        Me.grpPersonalDetails.Controls.Add(Me.lblLastName)
        Me.grpPersonalDetails.Controls.Add(Me.lblFirstName)
        Me.grpPersonalDetails.Location = New System.Drawing.Point(14, 92)
        Me.grpPersonalDetails.Name = "grpPersonalDetails"
        Me.grpPersonalDetails.Size = New System.Drawing.Size(346, 124)
        Me.grpPersonalDetails.TabIndex = 0
        Me.grpPersonalDetails.TabStop = False
        Me.grpPersonalDetails.Text = "Personal Details"
        '
        'txtIdNo
        '
        Me.txtIdNo.Location = New System.Drawing.Point(96, 92)
        Me.txtIdNo.Name = "txtIdNo"
        Me.txtIdNo.Size = New System.Drawing.Size(233, 20)
        Me.txtIdNo.TabIndex = 5
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(96, 61)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(233, 20)
        Me.txtLastName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID No"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(96, 19)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(233, 20)
        Me.txtFirstName.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(19, 61)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(19, 26)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(735, 521)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -8
        Me.LineShape1.X2 = 756
        Me.LineShape1.Y1 = 45
        Me.LineShape1.Y2 = 43
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 521)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpWorkingHours.ResumeLayout(False)
        Me.grpWorkingHours.PerformLayout()
        Me.grpContactDetails.ResumeLayout(False)
        Me.grpContactDetails.PerformLayout()
        Me.grpPersonalDetails.ResumeLayout(False)
        Me.grpPersonalDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grpContactDetails As System.Windows.Forms.GroupBox
    Friend WithEvents grpPersonalDetails As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculateSalary As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents rtxtWageDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents grpWorkingHours As System.Windows.Forms.GroupBox
    Friend WithEvents txtDaysPerWeek As System.Windows.Forms.TextBox
    Friend WithEvents txtHoursPerDay As System.Windows.Forms.TextBox
    Friend WithEvents lblWorkingHours As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblMobileNumber As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtIdNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
