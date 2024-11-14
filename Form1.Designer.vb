<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScoreConversion
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
        Label1 = New Label()
        inputTaskScore = New TextBox()
        inputUTSScore = New TextBox()
        Label2 = New Label()
        inputTotalScore = New TextBox()
        labelTotalScore = New Label()
        inputUASScore = New TextBox()
        Label3 = New Label()
        calculate = New Button()
        clearBtn = New Button()
        printBtn = New Button()
        quitBtn = New Button()
        inputLetterScore = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F)
        Label1.Location = New Point(55, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 36)
        Label1.TabIndex = 0
        Label1.Text = "Nilai Tugas: "
        ' 
        ' inputTaskScore
        ' 
        inputTaskScore.Font = New Font("Times New Roman", 12F)
        inputTaskScore.Location = New Point(260, 76)
        inputTaskScore.Name = "inputTaskScore"
        inputTaskScore.Size = New Size(252, 44)
        inputTaskScore.TabIndex = 1
        ' 
        ' inputUTSScore
        ' 
        inputUTSScore.Font = New Font("Times New Roman", 12F)
        inputUTSScore.Location = New Point(260, 168)
        inputUTSScore.Name = "inputUTSScore"
        inputUTSScore.Size = New Size(252, 44)
        inputUTSScore.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F)
        Label2.Location = New Point(55, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 36)
        Label2.TabIndex = 2
        Label2.Text = "Nilai UTS:"
        ' 
        ' inputTotalScore
        ' 
        inputTotalScore.Font = New Font("Times New Roman", 12F)
        inputTotalScore.ImeMode = ImeMode.NoControl
        inputTotalScore.Location = New Point(260, 360)
        inputTotalScore.Name = "inputTotalScore"
        inputTotalScore.ReadOnly = True
        inputTotalScore.Size = New Size(252, 44)
        inputTotalScore.TabIndex = 7
        ' 
        ' labelTotalScore
        ' 
        labelTotalScore.AutoSize = True
        labelTotalScore.Font = New Font("Times New Roman", 12F)
        labelTotalScore.Location = New Point(55, 368)
        labelTotalScore.Name = "labelTotalScore"
        labelTotalScore.Size = New Size(168, 36)
        labelTotalScore.TabIndex = 6
        labelTotalScore.Text = "Nilai Total: "
        ' 
        ' inputUASScore
        ' 
        inputUASScore.Font = New Font("Times New Roman", 12F)
        inputUASScore.Location = New Point(260, 264)
        inputUASScore.Name = "inputUASScore"
        inputUASScore.Size = New Size(252, 44)
        inputUASScore.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F)
        Label3.Location = New Point(55, 272)
        Label3.Name = "Label3"
        Label3.Size = New Size(166, 36)
        Label3.TabIndex = 4
        Label3.Text = "Nilai UAS: "
        ' 
        ' calculate
        ' 
        calculate.Location = New Point(55, 531)
        calculate.Name = "calculate"
        calculate.Size = New Size(150, 46)
        calculate.TabIndex = 8
        calculate.Text = "OK"
        calculate.UseVisualStyleBackColor = True
        ' 
        ' clearBtn
        ' 
        clearBtn.Location = New Point(330, 531)
        clearBtn.Name = "clearBtn"
        clearBtn.Size = New Size(150, 46)
        clearBtn.TabIndex = 9
        clearBtn.Text = "Bersihkan"
        clearBtn.UseVisualStyleBackColor = True
        ' 
        ' printBtn
        ' 
        printBtn.Location = New Point(55, 626)
        printBtn.Name = "printBtn"
        printBtn.Size = New Size(150, 46)
        printBtn.TabIndex = 10
        printBtn.Text = "Cetak"
        printBtn.UseVisualStyleBackColor = True
        ' 
        ' quitBtn
        ' 
        quitBtn.Location = New Point(330, 626)
        quitBtn.Name = "quitBtn"
        quitBtn.Size = New Size(150, 46)
        quitBtn.TabIndex = 11
        quitBtn.Text = "Keluar"
        quitBtn.UseVisualStyleBackColor = True
        ' 
        ' inputLetterScore
        ' 
        inputLetterScore.Font = New Font("Times New Roman", 12F)
        inputLetterScore.ImeMode = ImeMode.NoControl
        inputLetterScore.Location = New Point(260, 455)
        inputLetterScore.Name = "inputLetterScore"
        inputLetterScore.ReadOnly = True
        inputLetterScore.Size = New Size(252, 44)
        inputLetterScore.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F)
        Label4.Location = New Point(55, 463)
        Label4.Name = "Label4"
        Label4.Size = New Size(170, 36)
        Label4.TabIndex = 12
        Label4.Text = "Nilai Huruf:"
        ' 
        ' ScoreConversion
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(577, 699)
        Controls.Add(inputLetterScore)
        Controls.Add(Label4)
        Controls.Add(quitBtn)
        Controls.Add(printBtn)
        Controls.Add(clearBtn)
        Controls.Add(calculate)
        Controls.Add(inputTotalScore)
        Controls.Add(labelTotalScore)
        Controls.Add(inputUASScore)
        Controls.Add(Label3)
        Controls.Add(inputUTSScore)
        Controls.Add(Label2)
        Controls.Add(inputTaskScore)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "ScoreConversion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Konversi Nilai"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inputTaskScore As TextBox
    Friend WithEvents inputUTSScore As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents inputTotalScore As TextBox
    Friend WithEvents labelTotalScore As Label
    Friend WithEvents inputUASScore As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents calculate As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents printBtn As Button
    Friend WithEvents quitBtn As Button
    Friend WithEvents inputLetterScore As TextBox
    Friend WithEvents Label4 As Label

End Class
