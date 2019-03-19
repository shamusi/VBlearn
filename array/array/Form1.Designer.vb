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
        Me.lstArray = New System.Windows.Forms.ListBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.dtpHour = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lstArray
        '
        Me.lstArray.FormattingEnabled = True
        Me.lstArray.Location = New System.Drawing.Point(13, 23)
        Me.lstArray.Name = "lstArray"
        Me.lstArray.Size = New System.Drawing.Size(165, 212)
        Me.lstArray.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(202, 23)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "Button1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(202, 72)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 23)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "Button2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(202, 119)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 23)
        Me.btn3.TabIndex = 3
        Me.btn3.Text = "Button3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'dtpHour
        '
        Me.dtpHour.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHour.Location = New System.Drawing.Point(117, 252)
        Me.dtpHour.Name = "dtpHour"
        Me.dtpHour.ShowUpDown = True
        Me.dtpHour.Size = New System.Drawing.Size(200, 20)
        Me.dtpHour.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 321)
        Me.Controls.Add(Me.dtpHour)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lstArray)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstArray As ListBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents dtpHour As DateTimePicker
End Class
