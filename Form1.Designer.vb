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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSpeak = New System.Windows.Forms.TextBox()
        Me.cmdSpeak = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdAddSpace = New System.Windows.Forms.Button()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start Typing"
        '
        'txtSpeak
        '
        Me.txtSpeak.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpeak.Location = New System.Drawing.Point(44, 152)
        Me.txtSpeak.Name = "txtSpeak"
        Me.txtSpeak.Size = New System.Drawing.Size(408, 29)
        Me.txtSpeak.TabIndex = 1
        '
        'cmdSpeak
        '
        Me.cmdSpeak.Location = New System.Drawing.Point(44, 226)
        Me.cmdSpeak.Name = "cmdSpeak"
        Me.cmdSpeak.Size = New System.Drawing.Size(408, 46)
        Me.cmdSpeak.TabIndex = 2
        Me.cmdSpeak.Text = "Speak"
        Me.cmdSpeak.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(548, 76)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(65, 60)
        Me.cmdNext.TabIndex = 3
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(548, 139)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(65, 60)
        Me.cmdReset.TabIndex = 4
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdAddSpace
        '
        Me.cmdAddSpace.Location = New System.Drawing.Point(548, 213)
        Me.cmdAddSpace.Name = "cmdAddSpace"
        Me.cmdAddSpace.Size = New System.Drawing.Size(65, 96)
        Me.cmdAddSpace.TabIndex = 5
        Me.cmdAddSpace.Text = "Add Space"
        Me.cmdAddSpace.UseVisualStyleBackColor = True
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(548, 316)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(65, 60)
        Me.cmdSelect.TabIndex = 6
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Current Word"
        '
        'txtCurrent
        '
        Me.txtCurrent.Font = New System.Drawing.Font("Book Antiqua", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrent.Location = New System.Drawing.Point(259, 345)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(63, 36)
        Me.txtCurrent.TabIndex = 8
        Me.txtCurrent.Text = "A"
        Me.txtCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 428)
        Me.Controls.Add(Me.txtCurrent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdAddSpace)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdSpeak)
        Me.Controls.Add(Me.txtSpeak)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Awaaz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSpeak As TextBox
    Friend WithEvents cmdSpeak As Button
    Friend WithEvents cmdNext As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdAddSpace As Button
    Friend WithEvents cmdSelect As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCurrent As TextBox
End Class
