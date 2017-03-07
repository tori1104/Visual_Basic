
Partial Class palindrome
    Inherits System.Web.UI.Page

    Protected Function reverse(ByVal baseNum As String) As String
        Dim newStr As String = ""

        For ndx As Integer = Len(baseNum) To 1 Step -1
            newStr = newStr + Mid(baseNum, ndx, 1)
        Next

        Return (newStr)

    End Function

    Protected Function isPalindrome(ByVal baseNum As String) As Boolean
        Dim newStr As String = ""
        Dim chrCnt As Integer = 1

        For ndx As Integer = Len(baseNum) To 1 Step -1

            If Mid(baseNum, ndx, 1) <> Mid(baseNum, chrCnt, 1) Then
                Return False
            End If
            chrCnt = chrCnt + 1
        Next

        Return True

    End Function

    Protected Sub bCalculate_Click(sender As Object, e As EventArgs) Handles bCalculate.Click
        Dim num As String
        Dim reverseNum As String
        Dim steps As Integer = 0
        Dim results As String

        Dim mp As New Site()
        mp.msgLog("Palindrome", "Range" + tbStart.Text + " to " + tbEnd.Text)

        lbResults.Items.Clear()


        For ndx As Integer = CInt(tbStart.Text) To CInt(tbEnd.Text)

            num = CStr(ndx)
            results = CStr(ndx)
            steps = 0

            Do While isPalindrome(num) = False And steps < 20
                reverseNum = reverse(num)
                num = CStr(CInt(num) + CLng(reverseNum))
                steps = steps + 1

            Loop
            results = results + " Number of Steps: " + CStr(steps) + " " + CStr(num)
            If isPalindrome(num) = True Then
                results = results + " Palindrome"
            Else
                results = results + "None"
            End If


            lbResults.Items.Add(results)


        Next

    End Sub
End Class
