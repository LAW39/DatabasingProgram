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
        Me.Input = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Output1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.WriteBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.Location = New System.Drawing.Point(2, 12)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(64, 33)
        Me.Input.TabIndex = 0
        Me.Input.Text = "Input"
        Me.Input.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(2, 51)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(64, 33)
        Me.Clear.TabIndex = 1
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Output1
        '
        Me.Output1.Location = New System.Drawing.Point(73, 214)
        Me.Output1.Name = "Output1"
        Me.Output1.Size = New System.Drawing.Size(192, 33)
        Me.Output1.TabIndex = 2
        Me.Output1.Text = "Read from file"
        Me.Output1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.CausesValidation = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(73, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(192, 199)
        Me.ListBox1.TabIndex = 3
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(2, 90)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(64, 33)
        Me.EditBtn.TabIndex = 4
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'WriteBtn
        '
        Me.WriteBtn.Location = New System.Drawing.Point(73, 253)
        Me.WriteBtn.Name = "WriteBtn"
        Me.WriteBtn.Size = New System.Drawing.Size(192, 33)
        Me.WriteBtn.TabIndex = 6
        Me.WriteBtn.Text = "Write to file"
        Me.WriteBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 298)
        Me.Controls.Add(Me.WriteBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Output1)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Input)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Input As System.Windows.Forms.Button
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents Output1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents WriteBtn As System.Windows.Forms.Button

End Class
