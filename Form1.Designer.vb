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
        btnSALanguage = New Button()
        txtSALanguage = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnSALanguage
        ' 
        btnSALanguage.BackColor = Color.Coral
        btnSALanguage.Location = New Point(473, 306)
        btnSALanguage.Name = "btnSALanguage"
        btnSALanguage.Size = New Size(156, 84)
        btnSALanguage.TabIndex = 0
        btnSALanguage.Text = "Greetings in SA Language"
        btnSALanguage.UseVisualStyleBackColor = False
        ' 
        ' txtSALanguage
        ' 
        txtSALanguage.Location = New Point(473, 215)
        txtSALanguage.Name = "txtSALanguage"
        txtSALanguage.Size = New Size(156, 31)
        txtSALanguage.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(306, 221)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 25)
        Label1.TabIndex = 2
        Label1.Text = "SA Language"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(txtSALanguage)
        Controls.Add(btnSALanguage)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSALanguage As Button
    Friend WithEvents txtSALanguage As TextBox
    Friend WithEvents Label1 As Label
End Class
