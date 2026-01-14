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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        GroupBox1 = New GroupBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        CType(dgvOrder, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label1.Location = New Point(132, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(289, 30)
        Label1.TabIndex = 0
        Label1.Text = "QuickDelight - Order Form"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Location = New Point(427, 21)
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
        txtCustomerName.Location = New Point(124, 63)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(200, 23)
        txtCustomerName.TabIndex = 2
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(124, 92)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(200, 23)
        txtAddress.TabIndex = 3
        ' 
        ' dtpOrderDate
        ' 
        dtpOrderDate.Location = New Point(124, 124)
        dtpOrderDate.Name = "dtpOrderDate"
        dtpOrderDate.Size = New Size(200, 23)
        dtpOrderDate.TabIndex = 4
        ' 
        ' cmbMeal
        ' 
        cmbMeal.FormattingEnabled = True
        cmbMeal.Items.AddRange(New Object() {"Pizza", "Burger", "Salad", "Sushi"})
        cmbMeal.Location = New Point(13, 43)
        cmbMeal.Name = "cmbMeal"
        cmbMeal.Size = New Size(121, 23)
        cmbMeal.TabIndex = 5
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(149, 43)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(100, 23)
        txtQuantity.TabIndex = 6
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(278, 43)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(100, 23)
        txtPrice.TabIndex = 7
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(13, 84)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(114, 84)
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
        dgvOrder.Location = New Point(13, 139)
        dgvOrder.Name = "dgvOrder"
        dgvOrder.Size = New Size(443, 80)
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
        lblTotal.Location = New Point(8, 520)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(34, 15)
        lblTotal.TabIndex = 11
        lblTotal.Text = "$0.00"
        ' 
        ' lblGST
        ' 
        lblGST.AutoSize = True
        lblGST.Location = New Point(8, 535)
        lblGST.Name = "lblGST"
        lblGST.Size = New Size(34, 15)
        lblGST.TabIndex = 12
        lblGST.Text = "$0.00"
        ' 
        ' lblToPay
        ' 
        lblToPay.AutoSize = True
        lblToPay.Location = New Point(8, 550)
        lblToPay.Name = "lblToPay"
        lblToPay.Size = New Size(34, 15)
        lblToPay.TabIndex = 13
        lblToPay.Text = "$0.00"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(405, 539)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 14
        btnExit.Text = "Exit Form"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtCustomerName)
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(dtpOrderDate)
        GroupBox1.Location = New Point(8, 27)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(473, 221)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Customer Details"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(9, 22)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(36, 34)
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.oneko___Copyd
        PictureBox1.Location = New Point(431, 181)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(36, 34)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(54, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 7
        Label4.Text = "Order Date:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(54, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 15)
        Label3.TabIndex = 6
        Label3.Text = "Address:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(54, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 5
        Label2.Text = "Full Name:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(dgvOrder)
        GroupBox2.Controls.Add(txtQuantity)
        GroupBox2.Controls.Add(txtPrice)
        GroupBox2.Controls.Add(cmbMeal)
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(btnDelete)
        GroupBox2.Location = New Point(8, 254)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(473, 252)
        GroupBox2.TabIndex = 16
        GroupBox2.TabStop = False
        GroupBox2.Text = "Order Details"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 25)
        Label7.Name = "Label7"
        Label7.Size = New Size(33, 15)
        Label7.TabIndex = 13
        Label7.Text = "Meal"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(278, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(33, 15)
        Label6.TabIndex = 12
        Label6.Text = "Price"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(149, 25)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 15)
        Label5.TabIndex = 11
        Label5.Text = "Quantity"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(439, 501)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(36, 34)
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(106, 539)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(36, 34)
        PictureBox4.TabIndex = 17
        PictureBox4.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(492, 578)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(GroupBox2)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        Controls.Add(lblToPay)
        Controls.Add(lblTime)
        Controls.Add(lblGST)
        Controls.Add(lblTotal)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Order Form - QuickDelight"
        CType(dgvOrder, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox

End Class
