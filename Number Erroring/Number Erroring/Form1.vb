Public Class Form1

    Private Sub btncal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncal.Click

        lblerrormsg.Visible = False
        Dim dblFirstNumber, dblSecondNumber, dblanswer As Double
    

        Try
            dblFirstNumber = txtfirstnumber.Text
            dblSecondNumber = txtsecondnumber.Text
            dblAnswer = dblFirstNumber / dblSecondNumber
            lblAnswer.Text = dblAnswer
        Catch ex As Exception
            lblAnswer.Text = "Error"
            lblerrormsg.Visible = True
            lblerrormsg.Text = "One of the entries is not a number! Try again!"
        End Try



    End Sub
End Class
