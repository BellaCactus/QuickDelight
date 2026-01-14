<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        lblTime = New Label()
        Timer1 = New Timer(components)
        txtCustomerName = New TextBox()
        txtAddress = New TextBox()
        dtpOrderDate = New DateTimePicker()
        cmbMeal = New ComboBox()
        txtQuantity = New TextBox()
        txtPrice = New TextBox()
        btnAdd = New Button()
        btnDelete = New Button()
        dgvOrder = New DataGridView()
        colMeal = New DataGridViewTextBoxColumn()
        colQty = New DataGridViewTextBoxColumn()
        colPrice = New DataGridViewTextBoxColumn()
        colSubtotal = New DataGridViewTextBoxColumn()
        lblTotal = New Label()
        lblGST = New Label()
        lblToPay = New Label()
        btnExit = New Button()
        CType(dgvOrder, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label1.Location = New Point(205, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(289, 30)
        Label1.TabIndex = 0
        Label1.Text = "QuickDelight - Order Form"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Location = New Point(327, 83)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(49, 15)
        lblTime.TabIndex = 1
        lblTime.Text = "00:00:00"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(183, 128)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(100, 23)
        txtCustomerName.TabIndex = 2
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(183, 171)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(100, 23)
        txtAddress.TabIndex = 3
        ' 
        ' dtpOrderDate
        ' 
        dtpOrderDate.Location = New Point(136, 224)
        dtpOrderDate.Name = "dtpOrderDate"
        dtpOrderDate.Size = New Size(200, 23)
        dtpOrderDate.TabIndex = 4
        ' 
        ' cmbMeal
        ' 
        cmbMeal.FormattingEnabled = True
        cmbMeal.Items.AddRange(New Object() {"Pizza", "Burger", "Salad", "Sushi"})
        cmbMeal.Location = New Point(363, 128)
        cmbMeal.Name = "cmbMeal"
        cmbMeal.Size = New Size(121, 23)
        cmbMeal.TabIndex = 5
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(375, 157)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(100, 23)
        txtQuantity.TabIndex = 6
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(375, 186)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(100, 23)
        txtPrice.TabIndex = 7
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(387, 224)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(387, 253)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 9
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' dgvOrder
        ' 
        dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOrder.Columns.AddRange(New DataGridViewColumn() {colMeal, colQty, colPrice, colSubtotal})
        dgvOrder.Location = New Point(282, 282)
        dgvOrder.Name = "dgvOrder"
        dgvOrder.Size = New Size(440, 81)
        dgvOrder.TabIndex = 10
        ' 
        ' colMeal
        ' 
        colMeal.HeaderText = "Meal Description"
        colMeal.Name = "colMeal"
        ' 
        ' colQty
        ' 
        colQty.HeaderText = "Quantity"
        colQty.Name = "colQty"
        ' 
        ' colPrice
        ' 
        colPrice.HeaderText = "Unit Price"
        colPrice.Name = "colPrice"
        ' 
        ' colSubtotal
        ' 
        colSubtotal.HeaderText = "Subtotal"
        colSubtotal.Name = "colSubtotal"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(633, 383)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(34, 15)
        lblTotal.TabIndex = 11
        lblTotal.Text = "$0.00"
        ' 
        ' lblGST
        ' 
        lblGST.AutoSize = True
        lblGST.Location = New Point(633, 398)
        lblGST.Name = "lblGST"
        lblGST.Size = New Size(34, 15)
        lblGST.TabIndex = 12
        lblGST.Text = "$0.00"
        ' 
        ' lblToPay
        ' 
        lblToPay.AutoSize = True
        lblToPay.Location = New Point(633, 413)
        lblToPay.Name = "lblToPay"
        lblToPay.Size = New Size(34, 15)
        lblToPay.TabIndex = 13
        lblToPay.Text = "$0.00"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(577, 152)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 14
        btnExit.Text = "Exit Form"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(lblToPay)
        Controls.Add(lblGST)
        Controls.Add(lblTotal)
        Controls.Add(dgvOrder)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(txtPrice)
        Controls.Add(txtQuantity)
        Controls.Add(cmbMeal)
        Controls.Add(dtpOrderDate)
        Controls.Add(txtAddress)
        Controls.Add(txtCustomerName)
        Controls.Add(lblTime)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvOrder, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents dtpOrderDate As DateTimePicker
    Friend WithEvents cmbMeal As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvOrder As DataGridView
    Friend WithEvents colMeal As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblGST As Label
    Friend WithEvents lblToPay As Label
    Friend WithEvents btnExit As Button

End Class
