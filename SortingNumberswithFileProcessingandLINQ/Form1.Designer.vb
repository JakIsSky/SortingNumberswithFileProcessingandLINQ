<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.lstSortedNumber = New System.Windows.Forms.ListBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(296, 102)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(75, 23)
        Me.btnWrite.TabIndex = 0
        Me.btnWrite.Text = "Write"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(96, 146)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(75, 23)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'lstSortedNumber
        '
        Me.lstSortedNumber.FormattingEnabled = True
        Me.lstSortedNumber.Location = New System.Drawing.Point(96, 197)
        Me.lstSortedNumber.Name = "lstSortedNumber"
        Me.lstSortedNumber.Size = New System.Drawing.Size(120, 95)
        Me.lstSortedNumber.TabIndex = 2
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(177, 102)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter a number:"
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(96, 315)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 23)
        Me.btnSort.TabIndex = 5
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lstSortedNumber)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnWrite)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnWrite As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents lstSortedNumber As ListBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSort As Button
End Class
