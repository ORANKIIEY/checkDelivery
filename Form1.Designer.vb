<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtnumber = New TextBox()
        btnCheckDelievery = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(83, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter Number of Items"
        ' 
        ' txtnumber
        ' 
        txtnumber.Location = New Point(216, 35)
        txtnumber.Name = "txtnumber"
        txtnumber.Size = New Size(100, 23)
        txtnumber.TabIndex = 1
        ' 
        ' btnCheckDelievery
        ' 
        btnCheckDelievery.Location = New Point(123, 64)
        btnCheckDelievery.Name = "btnCheckDelievery"
        btnCheckDelievery.Size = New Size(193, 23)
        btnCheckDelievery.TabIndex = 2
        btnCheckDelievery.Text = "Check Delivery "
        btnCheckDelievery.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCheckDelievery)
        Controls.Add(txtnumber)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnumber As TextBox
    Friend WithEvents btnCheckDelievery As Button

End Class
