
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        'Specify constant values
        Const preTax As Integer = 0.18
        Const afterTax As Integer = 0.22

        'Create variables to hold the values enterd by the user
        Dim rate As Decimal = rateTextBox.Text
        Dim hours As Decimal = hourTextBox.Text
        Dim pretaxD As Decimal = pretaxTextBox.Text
        Dim aftertaxD As Decimal = aftertaxTextBox.Text

        Dim pretaxWage As Decimal
        pretaxWage = rate * hours - pretaxD

        Dim Netpay As Decimal
        If pretaxWage < 500 Then
            Netpay = pretaxWage * (1 - preTax) - aftertaxD
        Else
            Netpay = pretaxWage * (1 - afterTax) - aftertaxD
        End If

        result.Text = "Your net salary payment is $" & Netpay.ToString("#,####.##")
    End Sub

    Protected Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click

        rateTextBox.Text = String.Empty
        hourTextBox.Text = String.Empty
        pretaxTextBox.Text = String.Empty
        aftertaxTextBox.Text = String.Empty
        result.Text = String.Empty


    End Sub
End Class
