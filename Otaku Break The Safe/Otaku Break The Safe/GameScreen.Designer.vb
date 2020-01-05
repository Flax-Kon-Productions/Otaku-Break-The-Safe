<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameScreen
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
        Me.topMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.MasterButton = New System.Windows.Forms.Button()
        Me.Min = New System.Windows.Forms.Label()
        Me.TenSec = New System.Windows.Forms.Label()
        Me.OnesSec = New System.Windows.Forms.Label()
        Me.TimePlaceholder = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.topMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'topMenu
        '
        Me.topMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.topMenu.Location = New System.Drawing.Point(0, 0)
        Me.topMenu.Name = "topMenu"
        Me.topMenu.Size = New System.Drawing.Size(1264, 24)
        Me.topMenu.TabIndex = 3
        Me.topMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(159, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(406, 67)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(521, 178)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(406, 296)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 7
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(159, 296)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 8
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(34, 178)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 9
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(878, 67)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(41, 20)
        Me.TextBox7.TabIndex = 10
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(1039, 67)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(41, 20)
        Me.TextBox8.TabIndex = 11
        '
        'MasterButton
        '
        Me.MasterButton.Location = New System.Drawing.Point(784, 125)
        Me.MasterButton.Name = "MasterButton"
        Me.MasterButton.Size = New System.Drawing.Size(416, 73)
        Me.MasterButton.TabIndex = 12
        Me.MasterButton.Text = "Button1"
        Me.MasterButton.UseVisualStyleBackColor = True
        '
        'Min
        '
        Me.Min.AutoSize = True
        Me.Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Min.Location = New System.Drawing.Point(253, 125)
        Me.Min.Name = "Min"
        Me.Min.Size = New System.Drawing.Size(64, 46)
        Me.Min.TabIndex = 13
        Me.Min.Text = "40"
        '
        'TenSec
        '
        Me.TenSec.AutoSize = True
        Me.TenSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TenSec.Location = New System.Drawing.Point(334, 125)
        Me.TenSec.Name = "TenSec"
        Me.TenSec.Size = New System.Drawing.Size(42, 46)
        Me.TenSec.TabIndex = 14
        Me.TenSec.Text = "0"
        '
        'OnesSec
        '
        Me.OnesSec.AutoSize = True
        Me.OnesSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnesSec.Location = New System.Drawing.Point(367, 125)
        Me.OnesSec.Name = "OnesSec"
        Me.OnesSec.Size = New System.Drawing.Size(42, 46)
        Me.OnesSec.TabIndex = 15
        Me.OnesSec.Text = "0"
        '
        'TimePlaceholder
        '
        Me.TimePlaceholder.AutoSize = True
        Me.TimePlaceholder.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimePlaceholder.Location = New System.Drawing.Point(313, 125)
        Me.TimePlaceholder.Name = "TimePlaceholder"
        Me.TimePlaceholder.Size = New System.Drawing.Size(31, 46)
        Me.TimePlaceholder.TabIndex = 16
        Me.TimePlaceholder.Text = ":"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(784, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 73)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Correct"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1004, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 73)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Incorrect"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(784, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(416, 73)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GameScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TimePlaceholder)
        Me.Controls.Add(Me.OnesSec)
        Me.Controls.Add(Me.TenSec)
        Me.Controls.Add(Me.Min)
        Me.Controls.Add(Me.MasterButton)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.topMenu)
        Me.Name = "GameScreen"
        Me.Text = "GameScreen"
        Me.topMenu.ResumeLayout(False)
        Me.topMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents topMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents MasterButton As Button
    Friend WithEvents Min As Label
    Friend WithEvents TenSec As Label
    Friend WithEvents OnesSec As Label
    Friend WithEvents TimePlaceholder As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
