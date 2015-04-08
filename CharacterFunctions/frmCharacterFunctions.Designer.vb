<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharFunctions
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
        Me.txtIn = New System.Windows.Forms.TextBox()
        Me.btnXor = New System.Windows.Forms.Button()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtIn
        '
        Me.txtIn.Location = New System.Drawing.Point(47, 14)
        Me.txtIn.Name = "txtIn"
        Me.txtIn.Size = New System.Drawing.Size(455, 26)
        Me.txtIn.TabIndex = 0
        '
        'btnXor
        '
        Me.btnXor.Location = New System.Drawing.Point(146, 113)
        Me.btnXor.Name = "btnXor"
        Me.btnXor.Size = New System.Drawing.Size(88, 31)
        Me.btnXor.TabIndex = 1
        Me.btnXor.Text = "Xor"
        Me.btnXor.UseVisualStyleBackColor = True
        '
        'txtOut
        '
        Me.txtOut.Location = New System.Drawing.Point(47, 46)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(455, 26)
        Me.txtOut.TabIndex = 0
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(47, 115)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(81, 26)
        Me.txtNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "in"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "out"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "no."
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(240, 113)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(88, 31)
        Me.btnSubtract.TabIndex = 1
        Me.btnSubtract.Text = "Subtract"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'frmCharFunctions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 386)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnXor)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.txtIn)
        Me.Name = "frmCharFunctions"
        Me.Text = "Character Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIn As System.Windows.Forms.TextBox
    Friend WithEvents btnXor As System.Windows.Forms.Button
    Friend WithEvents txtOut As System.Windows.Forms.TextBox
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSubtract As System.Windows.Forms.Button

End Class
