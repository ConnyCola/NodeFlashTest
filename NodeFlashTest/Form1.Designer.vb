<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnARD = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBoxARD = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMSP = New System.Windows.Forms.ComboBox()
        Me.btnMSP = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.checkARD = New System.Windows.Forms.CheckBox()
        Me.checkFLASH = New System.Windows.Forms.CheckBox()
        Me.checkSERIAL = New System.Windows.Forms.CheckBox()
        Me.checkVBAT = New System.Windows.Forms.CheckBox()
        Me.checkVCC = New System.Windows.Forms.CheckBox()
        Me.checkSD = New System.Windows.Forms.CheckBox()
        Me.checkRF = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnARD
        '
        Me.btnARD.Location = New System.Drawing.Point(215, 101)
        Me.btnARD.Name = "btnARD"
        Me.btnARD.Size = New System.Drawing.Size(167, 73)
        Me.btnARD.TabIndex = 0
        Me.btnARD.Text = "Arduino connect"
        Me.btnARD.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 9.047121!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox1.Location = New System.Drawing.Point(33, 333)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(1196, 517)
        Me.TextBox1.TabIndex = 1
        '
        'ComboBoxARD
        '
        Me.ComboBoxARD.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.916231!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxARD.FormattingEnabled = True
        Me.ComboBoxARD.Location = New System.Drawing.Point(215, 45)
        Me.ComboBoxARD.Name = "ComboBoxARD"
        Me.ComboBoxARD.Size = New System.Drawing.Size(167, 33)
        Me.ComboBoxARD.TabIndex = 2
        '
        'ComboBoxMSP
        '
        Me.ComboBoxMSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.916231!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMSP.FormattingEnabled = True
        Me.ComboBoxMSP.Location = New System.Drawing.Point(26, 45)
        Me.ComboBoxMSP.Name = "ComboBoxMSP"
        Me.ComboBoxMSP.Size = New System.Drawing.Size(167, 33)
        Me.ComboBoxMSP.TabIndex = 3
        '
        'btnMSP
        '
        Me.btnMSP.Location = New System.Drawing.Point(26, 101)
        Me.btnMSP.Name = "btnMSP"
        Me.btnMSP.Size = New System.Drawing.Size(166, 73)
        Me.btnMSP.TabIndex = 4
        Me.btnMSP.Text = "MSP connect"
        Me.btnMSP.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.94764!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(214, 30)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(196, 84)
        Me.btnTest.TabIndex = 5
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'checkARD
        '
        Me.checkARD.AutoSize = True
        Me.checkARD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkARD.ForeColor = System.Drawing.Color.Gray
        Me.checkARD.Location = New System.Drawing.Point(15, 30)
        Me.checkARD.Name = "checkARD"
        Me.checkARD.Size = New System.Drawing.Size(170, 30)
        Me.checkARD.TabIndex = 6
        Me.checkARD.Text = "Arduino COM"
        Me.checkARD.UseVisualStyleBackColor = True
        '
        'checkFLASH
        '
        Me.checkFLASH.AutoSize = True
        Me.checkFLASH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkFLASH.ForeColor = System.Drawing.Color.Gray
        Me.checkFLASH.Location = New System.Drawing.Point(15, 137)
        Me.checkFLASH.Name = "checkFLASH"
        Me.checkFLASH.Size = New System.Drawing.Size(160, 30)
        Me.checkFLASH.TabIndex = 6
        Me.checkFLASH.Text = "HEX flashed"
        Me.checkFLASH.UseVisualStyleBackColor = True
        '
        'checkSERIAL
        '
        Me.checkSERIAL.AutoSize = True
        Me.checkSERIAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkSERIAL.ForeColor = System.Drawing.Color.Gray
        Me.checkSERIAL.Location = New System.Drawing.Point(15, 173)
        Me.checkSERIAL.Name = "checkSERIAL"
        Me.checkSERIAL.Size = New System.Drawing.Size(143, 30)
        Me.checkSERIAL.TabIndex = 6
        Me.checkSERIAL.Text = "MSP COM"
        Me.checkSERIAL.UseVisualStyleBackColor = True
        '
        'checkVBAT
        '
        Me.checkVBAT.AutoSize = True
        Me.checkVBAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkVBAT.ForeColor = System.Drawing.Color.Gray
        Me.checkVBAT.Location = New System.Drawing.Point(15, 101)
        Me.checkVBAT.Name = "checkVBAT"
        Me.checkVBAT.Size = New System.Drawing.Size(145, 30)
        Me.checkVBAT.TabIndex = 6
        Me.checkVBAT.Text = "V_BAT OK"
        Me.checkVBAT.UseVisualStyleBackColor = True
        '
        'checkVCC
        '
        Me.checkVCC.AutoSize = True
        Me.checkVCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkVCC.ForeColor = System.Drawing.Color.Gray
        Me.checkVCC.Location = New System.Drawing.Point(15, 66)
        Me.checkVCC.Name = "checkVCC"
        Me.checkVCC.Size = New System.Drawing.Size(123, 30)
        Me.checkVCC.TabIndex = 6
        Me.checkVCC.Text = "VCC OK"
        Me.checkVCC.UseVisualStyleBackColor = True
        '
        'checkSD
        '
        Me.checkSD.AutoSize = True
        Me.checkSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkSD.ForeColor = System.Drawing.Color.Gray
        Me.checkSD.Location = New System.Drawing.Point(15, 210)
        Me.checkSD.Name = "checkSD"
        Me.checkSD.Size = New System.Drawing.Size(160, 30)
        Me.checkSD.TabIndex = 6
        Me.checkSD.Text = "SD mounted"
        Me.checkSD.UseVisualStyleBackColor = True
        '
        'checkRF
        '
        Me.checkRF.AutoSize = True
        Me.checkRF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkRF.ForeColor = System.Drawing.Color.Gray
        Me.checkRF.Location = New System.Drawing.Point(15, 246)
        Me.checkRF.Name = "checkRF"
        Me.checkRF.Size = New System.Drawing.Size(115, 30)
        Me.checkRF.TabIndex = 6
        Me.checkRF.Text = "RF com"
        Me.checkRF.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(36, 304)
        Me.ProgressBar1.MarqueeAnimationSpeed = 40
        Me.ProgressBar1.Maximum = 70
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1195, 23)
        Me.ProgressBar1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkARD)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.checkFLASH)
        Me.GroupBox1.Controls.Add(Me.checkRF)
        Me.GroupBox1.Controls.Add(Me.checkSERIAL)
        Me.GroupBox1.Controls.Add(Me.btnTest)
        Me.GroupBox1.Controls.Add(Me.checkSD)
        Me.GroupBox1.Controls.Add(Me.checkVBAT)
        Me.GroupBox1.Controls.Add(Me.checkVCC)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 286)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Node test"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.12566!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 149)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "pass"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBoxMSP)
        Me.GroupBox2.Controls.Add(Me.btnARD)
        Me.GroupBox2.Controls.Add(Me.btnMSP)
        Me.GroupBox2.Controls.Add(Me.ComboBoxARD)
        Me.GroupBox2.Location = New System.Drawing.Point(825, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 286)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Serial connection"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(517, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 102)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 868)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "NodeFlashTest"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnARD As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxARD As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMSP As System.Windows.Forms.ComboBox
    Friend WithEvents btnMSP As System.Windows.Forms.Button
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents checkARD As System.Windows.Forms.CheckBox
    Friend WithEvents checkFLASH As System.Windows.Forms.CheckBox
    Friend WithEvents checkSERIAL As System.Windows.Forms.CheckBox
    Friend WithEvents checkVBAT As System.Windows.Forms.CheckBox
    Friend WithEvents checkVCC As System.Windows.Forms.CheckBox
    Friend WithEvents checkSD As System.Windows.Forms.CheckBox
    Friend WithEvents checkRF As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
