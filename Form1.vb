Public Class ScoreConversion

    Dim taskScore As Integer
    Dim uasScore As Integer
    Dim utsScore As Integer

    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        ' Check apakah inputan kosong
        ' String.IsNullOrEmpty untuk mengecek inputan yang masih string
        If String.IsNullOrEmpty(inputTaskScore.Text) OrElse String.IsNullOrEmpty(inputUASScore.Text) OrElse String.IsNullOrEmpty(inputUTSScore.Text) Then
            MsgBox("Tolong isi semua inputan dengan benar", vbOKOnly, "Input Error")
            Exit Sub
        End If

        ' Coba konversi input menjadi Integer
        If Integer.TryParse(inputTaskScore.Text, taskScore) AndAlso
           Integer.TryParse(inputUASScore.Text, uasScore) AndAlso
           Integer.TryParse(inputUTSScore.Text, utsScore) Then
            ' Lakukan perhitungan di sini jika diperlukan
        Else
            MsgBox("Tolong masukkan nilai numerik yang valid", vbOKOnly, "Input error")
            Exit Sub
        End If

        'Hitung nilai
        taskScore = Integer.Parse(inputTaskScore.Text)
        uasScore = Integer.Parse(inputUASScore.Text)
        utsScore = Integer.Parse(inputUTSScore.Text)

        inputTotalScore.Text = (0.4 * taskScore) + (uasScore * 0.3) + (utsScore * 0.3)

        Dim totalScore = Double.Parse(inputTotalScore.Text)

        If totalScore > 80 And totalScore <= 100 Then
            inputLetterScore.Text = "A"
        ElseIf totalScore > 70 And totalScore <= 80 Then
            inputTotalScore.Text = "B"
        ElseIf totalScore > 50 And totalScore <= 70 Then
            inputLetterScore.Text = "C"
        ElseIf totalScore > 40 And totalScore <= 50 Then
            inputLetterScore.Text = "D"
        Else
            inputLetterScore.Text = "E"
        End If

    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        inputLetterScore.Text = ""
        inputTaskScore.Text = ""
        inputTotalScore.Text = ""
        inputUASScore.Text = ""
        inputUTSScore.Text = ""
    End Sub

    Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click

        MsgBox("Nilai Tugas:" & taskScore & vbCrLf & "Nilai UTS: " & utsScore & vbCrLf & "Nilai UAS: " & uasScore & vbCrLf & "Total
Nilai: " & inputTotalScore.Text & vbCrLf & "Nilai Huruf: " & inputLetterScore.Text, vbOKOnly, "Perolehan Nilai")
    End Sub

    Private Sub quitBtn_Click(sender As Object, e As EventArgs) Handles quitBtn.Click
        Me.Close()
    End Sub
End Class
