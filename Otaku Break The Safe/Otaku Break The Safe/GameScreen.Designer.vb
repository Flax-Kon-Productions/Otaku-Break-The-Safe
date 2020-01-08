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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 413)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 46)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Player1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(219, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 46)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Player2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(455, 413)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 46)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Player3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(631, 413)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 46)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Player4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(870, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 46)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Player5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1061, 413)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 46)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Player6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1061, 490)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 46)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Player6"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(870, 490)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 46)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Player5"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(631, 490)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 46)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Player4"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(455, 490)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 46)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Player3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(219, 490)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(155, 46)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Player2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(49, 490)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(155, 46)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Player1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(104, 595)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 46)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "¥"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(513, 595)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 46)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "¥"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(954, 595)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 46)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "¥"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(172, 595)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 46)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(579, 595)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 46)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1002, 595)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 46)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "0"
        '
        'GameScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
