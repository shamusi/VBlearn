﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnsubString = New System.Windows.Forms.Button()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnsubString
        '
        Me.btnsubString.Location = New System.Drawing.Point(12, 38)
        Me.btnsubString.Name = "btnsubString"
        Me.btnsubString.Size = New System.Drawing.Size(75, 23)
        Me.btnsubString.TabIndex = 0
        Me.btnsubString.Text = "Substring"
        Me.btnsubString.UseVisualStyleBackColor = True
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(12, 12)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(100, 20)
        Me.txtString.TabIndex = 1
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.IntegralHeight = False
        Me.lstData.Location = New System.Drawing.Point(242, 94)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(164, 144)
        Me.lstData.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 292)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.btnsubString)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsubString As Button
    Friend WithEvents txtString As TextBox
    Friend WithEvents lstData As ListBox
End Class
