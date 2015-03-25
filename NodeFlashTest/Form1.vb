Imports System.IO.Ports
Imports System.Threading



Public Class Form1
    Private WithEvents ComPortARD As IO.Ports.SerialPort
    Private WithEvents ComPortMSP As IO.Ports.SerialPort


    Dim cmdFlash1 As String = "/ti/MSP430Flasher_1.3.1/MSP430Flasher.exe -n CC430F6137 -w " & Chr(34) & "/ti/MSP430Flasher_1.3.1/Firmware.txt" & Chr(34) & " -v -z [VCC] -m SBW2 (-i "
    Dim cmdFlash2 As String = ") (-e ERASE_ALL)"

    Private EndOfCommand As String = Constants.vbCr.ToString


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label1.Visible = False
        Label1.BackColor = Color.LightGreen

        ComboBoxARD.Items.AddRange(IO.Ports.SerialPort.GetPortNames)
        ComboBoxMSP.Items.AddRange(IO.Ports.SerialPort.GetPortNames)


        If ComboBoxARD.Items.Count > 0 Then
            ComboBoxARD.SelectedIndex = 0
            ComboBoxMSP.SelectedIndex = 0
        End If
        If ComboBoxARD.Items.Count > 1 Then
            ComboBoxARD.SelectedIndex = 0
            ComboBoxMSP.SelectedIndex = 1
        End If


    End Sub

    Private Sub btnMSP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMSP.Click
        Try
            ComPortMSP.Close()
        Catch ex As Exception
        End Try
        Static Dim MSPop = 0

        ComPortMSP = New IO.Ports.SerialPort(ComboBoxMSP.SelectedItem.ToString)
        ComPortMSP.BaudRate = 9600
        ComPortMSP.DataBits = 8
        ComPortMSP.StopBits = IO.Ports.StopBits.One
        ComPortMSP.Parity = IO.Ports.Parity.None
        ComPortMSP.ReceivedBytesThreshold = 1


        If MSPop = 0 Then
            ComPortMSP.Open()

            If ComPortMSP.IsOpen Then
                MSPop = 1
            Else
                MSPop = 0
            End If
        Else
            ComPortMSP.Close()
            If Not ComPortMSP.IsOpen Then
                MSPop = 0
            Else
                MSPop = 1
            End If
        End If

        If MSPop Then
            btnMSP.BackColor = Color.LightGreen
            checkSERIAL.Checked = True
            checkSERIAL.ForeColor = Color.Green
        Else
            btnMSP.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btnARD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnARD.Click
        Try
            ComPortARD.Close()
            Thread.Sleep(500)
        Catch ex As Exception
        End Try

        Static Dim ARDop = 0

        ComPortARD = New IO.Ports.SerialPort(ComboBoxARD.SelectedItem.ToString)
        ComPortARD.BaudRate = 9600
        ComPortARD.DataBits = 8
        ComPortARD.StopBits = IO.Ports.StopBits.One
        ComPortARD.Parity = IO.Ports.Parity.None
        ComPortARD.ReceivedBytesThreshold = 1


        If ARDop = 0 Then
            ComPortARD.Open()

            If ComPortARD.IsOpen Then
                ARDop = 1
            Else
                ARDop = 0
            End If
        Else
            ComPortARD.Close()
            Thread.Sleep(500)
            If Not ComPortARD.IsOpen Then
                ARDop = 0
            Else
                ARDop = 1
            End If
        End If

        If ARDop Then
            btnARD.BackColor = Color.LightGreen
            checkARD.ForeColor = Color.Green
            checkARD.Checked = True
        Else
            btnARD.BackColor = Color.LightGray
        End If


    End Sub

    Private Sub serialARD_event(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComPortARD.DataReceived
        'Try
        '    ARD_addText(ComPortARD.ReadLine)
        'Catch ex As Exception

        'End Try


    End Sub

    Private Delegate Sub ARD_Delegate(ByVal message As String, ByVal addDateTime As Boolean)
    Private Sub ARD_addText(ByVal message As String, Optional ByVal addDateTime As Boolean = False)

        With TextBox1
            If .InvokeRequired Then
                .Invoke(New LogDelegate(AddressOf ARD_addText), message, addDateTime)
            Else
                .AppendText(message & vbNewLine)
            End If
        End With

    End Sub

    Private Sub serialMSP_event(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComPortMSP.DataReceived
        MSP_addText(ComPortMSP.ReadLine)
    End Sub

    Private Delegate Sub MSP_Delegate(ByVal message As String, ByVal addDateTime As Boolean)
    Private Sub MSP_addText(ByVal message As String, Optional ByVal addDateTime As Boolean = False)

        With TextBox1
            If .InvokeRequired Then
                .Invoke(New LogDelegate(AddressOf MSP_addText), message, addDateTime)
            Else
                .AppendText(message & vbNewLine)
            End If
        End With
        If message Is Nothing Then
        ElseIf message.Contains("Open File  INI.txt             rc= 0") Then
            checkSD.Checked = True
            checkSD.ForeColor = Color.Green
        ElseIf message.Contains("Open File  nwk.txt             rc= 3") Then
            checkRF.Checked = True
            checkRF.ForeColor = Color.Green
        End If
    End Sub


    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click

        ProgressBar1.Value = 0
        Label1.Visible = False
        Label1.Text = ""
        Label1.Update()
        TextBox1.Text = ""

        checkARD.ForeColor = Color.Gray
        checkARD.Checked = False
        checkSD.ForeColor = Color.Gray
        checkSD.Checked = False
        checkSERIAL.ForeColor = Color.Gray
        checkSERIAL.Checked = False
        checkRF.ForeColor = Color.Gray
        checkRF.Checked = False
        checkFLASH.ForeColor = Color.Gray
        checkFLASH.Checked = False
        checkVBAT.ForeColor = Color.Gray
        checkVBAT.Checked = False
        checkVCC.ForeColor = Color.Gray
        checkVCC.Checked = False

        'Connect Arduino
        Try
            If ComPortARD.IsOpen Then
                checkARD.ForeColor = Color.Green
                checkARD.Checked = True
            End If
        Catch ex As Exception
            btnARD_Click(Nothing, Nothing)
            Thread.Sleep(1000)
        End Try


        sendArduino("2")         'Turn VBat ON
        sendArduino("0")          'Turn Vin ON
        Dim vbat = receiveArduino("5")
        If vbat >= 0 And vbat < 999 Then       'Read Vbat
            checkVBAT.Checked = True
            checkVBAT.ForeColor = Color.Green
        End If

        sendArduino("2")         'Turn VBat ON
        sendArduino("1")         'Turn Vin OFF
        Dim vcc = receiveArduino("4")
        If vcc >= 0 And vcc < 999 Then       'Read Vcc
            checkVCC.Checked = True
            checkVCC.ForeColor = Color.Green
        End If

        'Connect MSP430

        Try
            If ComPortMSP.IsOpen Then
                btnMSP_Click(Nothing, Nothing)
                Thread.Sleep(500)
            End If
        Catch ex As Exception
        End Try


        Using p As New Process
            AddHandler p.OutputDataReceived, AddressOf Me.Process_OutputDataReceived
            ' Process definieren
            With p.StartInfo
                .FileName = "cmd"
                .CreateNoWindow = True
                .UseShellExecute = False
                .RedirectStandardInput = True
                .RedirectStandardOutput = True
            End With
            ' Process starten
            p.Start()
            ' Auszuführende Befehle
            Using sw As IO.StreamWriter = p.StandardInput
                sw.AutoFlush = True
                sw.WriteLine("cd /")
                sw.WriteLine("ping www.vb-paradise.de")
                'sw.WriteLine(cmdFlash1 & ComboBoxMSP.SelectedItem.ToString & cmdFlash2)

            End Using
            ' Ausgabe
            p.BeginOutputReadLine()

        End Using

    End Sub

    Private Delegate Sub LogDelegate(ByVal message As String, ByVal addDateTime As Boolean)
    Private Sub AppendLogLine(ByVal message As String, Optional ByVal addDateTime As Boolean = False)
        With TextBox1
            If .InvokeRequired Then
                .Invoke(New LogDelegate(AddressOf Me.AppendLogLine), message, addDateTime)
            Else
                .AppendText(message & vbNewLine)
            End If
        End With
        If message Is Nothing Then
        Else
            If message.Contains("* Driver      : closed (No error)") Then
                checkFLASH.ForeColor = Color.Green
                checkFLASH.Checked = True
            End If
        End If
    End Sub

    Private Sub Process_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs)
        Me.AppendLogLine(e.Data, False)
    End Sub


    Private Sub checkFLASH_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFLASH.CheckedChanged
        'next step
        checkFLASH.Update()
        If checkFLASH.Checked = True Then
            ProgressBar1.Value += 10
            ProgressBar1.Update()
            Thread.Sleep(2000)
            btnMSP_Click(Nothing, Nothing)
        End If
    End Sub



    Private Sub checkARD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkARD.CheckedChanged
        If checkARD.Checked = True Then
            ProgressBar1.Value += 10
            ProgressBar1.Update()
        End If
    End Sub

    Private Sub checkVBAT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkVBAT.CheckedChanged
        If checkVBAT.Checked = True Then
            ProgressBar1.Value += 10
            ProgressBar1.Update()
        End If
    End Sub

    Private Sub checkVCC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkVCC.CheckedChanged
        If checkVCC.Checked = True Then
            ProgressBar1.Value += 10
            ProgressBar1.Update()
        End If
    End Sub

    Private Sub checkSERIAL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkSERIAL.CheckedChanged
        If checkSERIAL.Checked = True Then
            ProgressBar1.Value += 10
            ProgressBar1.Update()
        End If
    End Sub

    Private Sub checkSD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkSD.CheckedChanged
        If checkSD.Checked = True Then
            ProgressBar1.Value += 10
            ProgressBar1.Update()
        End If
    End Sub

    Private Sub checkRF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkRF.CheckedChanged
        If checkRF.Checked = True Then
            ProgressBar1.Value += 10
            ProgressBar1.Update()

            If ProgressBar1.Value = 70 Then
                Label1.BackColor = Color.LightGreen
                Label1.Text = "pass"
            Else
                Label1.BackColor = Color.Red
                Label1.Text = " fail!"
            End If
            Label1.Visible = True
        End If
    End Sub

    Private Sub sendArduino(ByVal command As String)
        ComPortARD.Write(command & vbCr)
        Thread.Sleep(100)
    End Sub

    Private Function receiveArduino(ByVal command As String)
        ComPortARD.Write(command & vbCr)
        While ComPortARD.BytesToRead = 0
        End While
        Dim inByte As Byte = ComPortARD.ReadByte
        Return inByte
    End Function

End Class
