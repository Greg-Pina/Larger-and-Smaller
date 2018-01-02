'*****************************************
' Greg Pina
' .Net Programming 1 (101-401)
'10/5/17
'*****************************************

Option Strict On
Public Class Form1
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Setting up variables
        Dim dblA As Double
        Dim dblB As Double

        boxA.BackColor = Color.White
        boxB.BackColor = Color.White


        Try
            'Check if A is entered properly
            If Not Double.TryParse(boxA.Text, dblA) Then
                MessageBox.Show("Please make sure to enter valid numbers to check")
                boxA.Focus()
                boxA.BackColor = Color.Yellow
                Exit Sub
            End If

            'Check if B is entered properly
            If Not Double.TryParse(boxB.Text, dblB) Then
                MessageBox.Show("Please make sure to enter valid numbers to check")
                boxB.Focus()
                boxB.BackColor = Color.Yellow
                Exit Sub
            End If


            'Compares A and B

            'A is greater than B
            If dblA > dblB Then
                lblCompare.Text = ("Value A is greater.")
                Exit Sub
            End If

            'B is greater than A
            If dblB > dblA Then
                lblCompare.Text = ("Value B is greater.")
                Exit Sub
            End If

            'A and B are equal
            If dblA = dblB Then
                lblCompare.Text = ("Value A and Value B are equal.")
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the program of its data
        boxA.Clear()
        boxB.Clear()
        lblCompare.ResetText()
        boxA.Focus()
        Exit Sub
    End Sub
End Class
