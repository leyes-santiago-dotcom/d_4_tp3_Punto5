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
        cmdEjecutar = New Button()
        lstVector10 = New ListBox()
        lstVector15 = New ListBox()
        SuspendLayout()
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.Location = New Point(12, 12)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(94, 29)
        cmdEjecutar.TabIndex = 0
        cmdEjecutar.Text = "Ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' lstVector10
        ' 
        lstVector10.FormattingEnabled = True
        lstVector10.Location = New Point(12, 47)
        lstVector10.Name = "lstVector10"
        lstVector10.Size = New Size(150, 244)
        lstVector10.TabIndex = 1
        ' 
        ' lstVector15
        ' 
        lstVector15.FormattingEnabled = True
        lstVector15.Location = New Point(168, 47)
        lstVector15.Name = "lstVector15"
        lstVector15.Size = New Size(150, 384)
        lstVector15.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(330, 450)
        Controls.Add(lstVector15)
        Controls.Add(lstVector10)
        Controls.Add(cmdEjecutar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents lstVector10 As ListBox
    Friend WithEvents lstVector15 As ListBox

End Class
