<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSmashCharacters
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbResult = New System.Windows.Forms.Label()
        Me.colSeries = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEcho = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwCharacters = New System.Windows.Forms.ListView()
        Me.chkEchoFighter = New System.Windows.Forms.CheckBox()
        Me.lbSeries = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.tbSeries = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.ttpCharacterTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.lbYear = New System.Windows.Forms.Label()
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(13, 413)
        Me.lbResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(440, 74)
        Me.lbResult.TabIndex = 8
        Me.ttpCharacterTips.SetToolTip(Me.lbResult, "Success or Error message will appear here.")
        '
        'colSeries
        '
        Me.colSeries.Text = "Series"
        '
        'colName
        '
        Me.colName.Text = "Name"
        '
        'colTitle
        '
        Me.colTitle.Text = "Title"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colEcho
        '
        Me.colEcho.Text = "Echo Fighter?"
        Me.colEcho.Width = 98
        '
        'lvwCharacters
        '
        Me.lvwCharacters.CheckBoxes = True
        Me.lvwCharacters.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colEcho, Me.colID, Me.colName, Me.colSeries, Me.colYear})
        Me.lvwCharacters.FullRowSelect = True
        Me.lvwCharacters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCharacters.Location = New System.Drawing.Point(13, 156)
        Me.lvwCharacters.Margin = New System.Windows.Forms.Padding(4)
        Me.lvwCharacters.MultiSelect = False
        Me.lvwCharacters.Name = "lvwCharacters"
        Me.lvwCharacters.Size = New System.Drawing.Size(439, 253)
        Me.lvwCharacters.TabIndex = 7
        Me.ttpCharacterTips.SetToolTip(Me.lvwCharacters, "Select a character to modify.")
        Me.lvwCharacters.UseCompatibleStateImageBehavior = False
        Me.lvwCharacters.View = System.Windows.Forms.View.Details
        '
        'chkEchoFighter
        '
        Me.chkEchoFighter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEchoFighter.Location = New System.Drawing.Point(77, 112)
        Me.chkEchoFighter.Margin = New System.Windows.Forms.Padding(4)
        Me.chkEchoFighter.Name = "chkEchoFighter"
        Me.chkEchoFighter.Size = New System.Drawing.Size(123, 30)
        Me.chkEchoFighter.TabIndex = 6
        Me.chkEchoFighter.Text = "Echo &Fighter:"
        Me.chkEchoFighter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpCharacterTips.SetToolTip(Me.chkEchoFighter, "Check if the character is an echo fighter")
        Me.chkEchoFighter.UseVisualStyleBackColor = True
        '
        'lbSeries
        '
        Me.lbSeries.Location = New System.Drawing.Point(58, 51)
        Me.lbSeries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSeries.Name = "lbSeries"
        Me.lbSeries.Size = New System.Drawing.Size(120, 16)
        Me.lbSeries.TabIndex = 2
        Me.lbSeries.Text = "&Series:"
        Me.lbSeries.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbName
        '
        Me.lbName.Location = New System.Drawing.Point(58, 15)
        Me.lbName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(120, 16)
        Me.lbName.TabIndex = 0
        Me.lbName.Text = "&Name:"
        Me.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbName.UseWaitCursor = True
        '
        'tbSeries
        '
        Me.tbSeries.Location = New System.Drawing.Point(186, 48)
        Me.tbSeries.Margin = New System.Windows.Forms.Padding(4)
        Me.tbSeries.Name = "tbSeries"
        Me.tbSeries.Size = New System.Drawing.Size(160, 22)
        Me.tbSeries.TabIndex = 3
        Me.ttpCharacterTips.SetToolTip(Me.tbSeries, "Enter the character's series")
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(186, 16)
        Me.tbName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(160, 22)
        Me.tbName.TabIndex = 1
        Me.ttpCharacterTips.SetToolTip(Me.tbName, "Enter the character's name")
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(352, 494)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.ttpCharacterTips.SetToolTip(Me.btnExit, "Click to exit the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(239, 494)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 28)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "&Reset"
        Me.ttpCharacterTips.SetToolTip(Me.btnReset, "Click to reset the screen.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(13, 494)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 28)
        Me.btnEnter.TabIndex = 9
        Me.btnEnter.Text = "&Enter"
        Me.ttpCharacterTips.SetToolTip(Me.btnEnter, "Click to add a character")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(186, 83)
        Me.nudYear.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1970, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(160, 22)
        Me.nudYear.TabIndex = 5
        Me.ttpCharacterTips.SetToolTip(Me.nudYear, "Select the year this character came into existence")
        Me.nudYear.Value = New Decimal(New Integer() {1980, 0, 0, 0})
        '
        'lbYear
        '
        Me.lbYear.Location = New System.Drawing.Point(58, 84)
        Me.lbYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbYear.Name = "lbYear"
        Me.lbYear.Size = New System.Drawing.Size(120, 16)
        Me.lbYear.TabIndex = 4
        Me.lbYear.Text = "&Year of Origin:"
        Me.lbYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(126, 494)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save &List"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmSmashCharacters
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(468, 530)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lbYear)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lvwCharacters)
        Me.Controls.Add(Me.chkEchoFighter)
        Me.Controls.Add(Me.lbSeries)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.tbSeries)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSmashCharacters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smash Character List"
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbResult As Label
    Friend WithEvents ttpCharacterTips As ToolTip
    Friend WithEvents colSeries As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colTitle As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colEcho As ColumnHeader
    Friend WithEvents lvwCharacters As ListView
    Friend WithEvents chkEchoFighter As CheckBox
    Friend WithEvents lbSeries As Label
    Friend WithEvents lbName As Label
    Friend WithEvents tbSeries As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents nudYear As NumericUpDown
    Friend WithEvents lbYear As Label
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents btnSave As Button
End Class
