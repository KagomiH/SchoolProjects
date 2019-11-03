Public Class Form1

    Dim MsgCounter As Integer = 0
    Dim Msg1 As String = "Have a Good Day"
    Dim Msg2 As String = "I Love You"
    Dim SecondsConvert As Integer = (60 * 60)
    Dim HourInput As Decimal = 0
    Dim Finalstep As Integer = 0
    Dim MsgTime As Integer = 10

    Private Sub BTNCalculate_Click(sender As Object, e As EventArgs) Handles BTNCalculate.Click

        LBLOutput.Text = ""

        If IsNumeric(TXTHourInput.Text) Then
            HourInput = TXTHourInput.Text
            Finalstep = HourInput * SecondsConvert / MsgTime

        Else
            MsgBox("Invalid Time Value...", MsgBoxStyle.Critical)
        End If

        For MsgCounter = 1 To Finalstep Step 1
            If MsgCounter Mod 7 = 0 Then

                LBLOutput.Text += MsgCounter.ToString & " " & Msg1 & vbCrLf

            Else

                LBLOutput.Text += MsgCounter.ToString & " " & Msg2 & " "

            End If

        Next
        LBLOutputTotalMessages.Text = "Total Number of Messages = " & Finalstep.ToString

    End Sub

End Class
