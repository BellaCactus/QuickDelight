Imports System.Windows.Forms

Public Class Form1

    ' ==========================================
    ' SR 4.8 & 4.9: MAKING IT ACTUALLY WORK
    ' ==========================================

    ' 1. THE CLOCK
    ' This just makes the time update every second (1000ms) so it's not stuck on 00:00:00 forever.
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    ' 2. THE ADD BUTTON (The big logic part)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        ' VALIDATION (SR 4.9)
        ' First, we gotta check if the user actually typed anything.
        ' If they leave stuff blank and hit Add, the app crashes and that is NOT the vibe.
        If cmbMeal.Text = "" Or txtQuantity.Text = "" Or txtPrice.Text = "" Then
            MessageBox.Show("Please fill in all order fields!", "Error")
            Return ' Stop right here, don't try to do math on empty air.
        End If

        Try
            ' Grabbing the info from the boxes
            Dim meal As String = cmbMeal.Text
            ' Converting the text numbers into actual math numbers (Integer for qty, Decimal for money)
            Dim qty As Integer = Integer.Parse(txtQuantity.Text)
            Dim price As Decimal = Decimal.Parse(txtPrice.Text)

            ' The Math: Quantity x Price = Subtotal
            Dim subtotal As Decimal = qty * price

            ' Shoving it all into the grid so we can see the order
            dgvOrder.Rows.Add(meal, qty, price, subtotal)

            ' Cleaning up the boxes so they are ready for the next order
            txtQuantity.Clear()
            txtPrice.Clear()

            ' Update the total money at the bottom
            CalculateTotals()

        Catch ex As Exception
            ' If they type "ABC" into the price box, this catches the error so the app doesn't explode.
            MessageBox.Show("Please enter valid numbers for Quantity and Price.")
        End Try
    End Sub

    ' 3. THE DELETE BUTTON
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if they actually clicked a row before trying to delete
        If dgvOrder.SelectedRows.Count > 0 Then
            ' Loop through selected rows and yeet them
            For Each row As DataGridViewRow In dgvOrder.SelectedRows
                If Not row.IsNewRow Then
                    dgvOrder.Rows.Remove(row)
                End If
            Next

            ' Recalculate the money since we removed stuff
            CalculateTotals()
        End If
    End Sub

    ' 4. THE MATH HELPER
    ' I made this a separate thing so I can use it for both Adding and Deleting without rewriting code.
    Private Sub CalculateTotals()
        Dim total As Decimal = 0

        ' Go through every single row in the grid and add up the Subtotal column
        For Each row As DataGridViewRow In dgvOrder.Rows
            If row.Cells("colSubtotal").Value IsNot Nothing Then
                total += Convert.ToDecimal(row.Cells("colSubtotal").Value)
            End If
        Next

        ' Calculate the tax (15%)
        Dim gst As Decimal = total * 0.15D
        Dim toPay As Decimal = total + gst

        ' Update the labels on the screen
        ' The "C" thing formats it as Currency (puts the $ sign there automatically)
        lblTotal.Text = $"Total: {total:C}"
        lblGST.Text = $"GST (15%): {gst:C}"
        lblToPay.Text = $"To Pay: {toPay:C}"
    End Sub

    ' 5. EXIT BUTTON
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Literally just closes the window.
        Me.Close()
    End Sub

    ' ON STARTUP
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make sure the clock starts ticking as soon as the app opens
        Timer1.Start()
    End Sub

    ' --- GHOST CODE (Safety Nets) ---
    ' These act like placeholders because I accidentally double-clicked some labels earlier.
    ' If I delete these, the Designer gets confused and throws a tantrum.
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblTime.Click
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
    End Sub
    Private Sub dtpOrderDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpOrderDate.ValueChanged
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Redirects to the real button if needed
        btnAdd_Click(sender, e)
    End Sub

End Class