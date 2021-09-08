<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frminstructions))
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblinstructions1 = New System.Windows.Forms.Label()
        Me.lblinstructions2 = New System.Windows.Forms.Label()
        Me.btneasy = New System.Windows.Forms.Button()
        Me.lblabove = New System.Windows.Forms.Label()
        Me.lblhigh = New System.Windows.Forms.Label()
        Me.lblbelow = New System.Windows.Forms.Label()
        Me.lbllow = New System.Windows.Forms.Label()
        Me.btnmedium = New System.Windows.Forms.Button()
        Me.btnhard = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.DarkRed
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(580, 255)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 32)
        Me.btnclose.TabIndex = 6
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(239, 9)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(162, 37)
        Me.lbltitle.TabIndex = 7
        Me.lbltitle.Text = "How To Play"
        '
        'lblinstructions1
        '
        Me.lblinstructions1.AutoSize = True
        Me.lblinstructions1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinstructions1.Location = New System.Drawing.Point(29, 62)
        Me.lblinstructions1.Name = "lblinstructions1"
        Me.lblinstructions1.Size = New System.Drawing.Size(573, 63)
        Me.lblinstructions1.TabIndex = 8
        Me.lblinstructions1.Text = resources.GetString("lblinstructions1.Text")
        Me.lblinstructions1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblinstructions2
        '
        Me.lblinstructions2.AutoSize = True
        Me.lblinstructions2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinstructions2.Location = New System.Drawing.Point(69, 142)
        Me.lblinstructions2.Name = "lblinstructions2"
        Me.lblinstructions2.Size = New System.Drawing.Size(473, 63)
        Me.lblinstructions2.TabIndex = 9
        Me.lblinstructions2.Text = "Seems simple enough?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Choose the difficulty of your preference when you're read" &
    "y to start."
        Me.lblinstructions2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btneasy
        '
        Me.btneasy.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.btneasy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneasy.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneasy.Location = New System.Drawing.Point(104, 228)
        Me.btneasy.Name = "btneasy"
        Me.btneasy.Size = New System.Drawing.Size(102, 50)
        Me.btneasy.TabIndex = 10
        Me.btneasy.Text = "EASY:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1-20"
        Me.btneasy.UseVisualStyleBackColor = False
        '
        'lblabove
        '
        Me.lblabove.AutoSize = True
        Me.lblabove.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblabove.Location = New System.Drawing.Point(153, 86)
        Me.lblabove.Name = "lblabove"
        Me.lblabove.Size = New System.Drawing.Size(45, 17)
        Me.lblabove.TabIndex = 11
        Me.lblabove.Text = "above"
        '
        'lblhigh
        '
        Me.lblhigh.AutoSize = True
        Me.lblhigh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhigh.Location = New System.Drawing.Point(452, 86)
        Me.lblhigh.Name = "lblhigh"
        Me.lblhigh.Size = New System.Drawing.Size(50, 17)
        Me.lblhigh.TabIndex = 12
        Me.lblhigh.Text = """High"""
        '
        'lblbelow
        '
        Me.lblbelow.AutoSize = True
        Me.lblbelow.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbelow.Location = New System.Drawing.Point(170, 107)
        Me.lblbelow.Name = "lblbelow"
        Me.lblbelow.Size = New System.Drawing.Size(45, 17)
        Me.lblbelow.TabIndex = 14
        Me.lblbelow.Text = "below"
        '
        'lbllow
        '
        Me.lbllow.AutoSize = True
        Me.lbllow.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllow.Location = New System.Drawing.Point(470, 107)
        Me.lbllow.Name = "lbllow"
        Me.lbllow.Size = New System.Drawing.Size(45, 17)
        Me.lbllow.TabIndex = 15
        Me.lbllow.Text = """Low"""
        '
        'btnmedium
        '
        Me.btnmedium.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.btnmedium.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmedium.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmedium.Location = New System.Drawing.Point(261, 228)
        Me.btnmedium.Name = "btnmedium"
        Me.btnmedium.Size = New System.Drawing.Size(102, 50)
        Me.btnmedium.TabIndex = 16
        Me.btnmedium.Text = "MEDIUM:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1-50"
        Me.btnmedium.UseVisualStyleBackColor = False
        '
        'btnhard
        '
        Me.btnhard.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.btnhard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhard.Location = New System.Drawing.Point(408, 228)
        Me.btnhard.Name = "btnhard"
        Me.btnhard.Size = New System.Drawing.Size(102, 50)
        Me.btnhard.TabIndex = 17
        Me.btnhard.Text = "HARD:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1-100"
        Me.btnhard.UseVisualStyleBackColor = False
        '
        'frminstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(667, 290)
        Me.Controls.Add(Me.btnhard)
        Me.Controls.Add(Me.btnmedium)
        Me.Controls.Add(Me.lbllow)
        Me.Controls.Add(Me.lblbelow)
        Me.Controls.Add(Me.lblhigh)
        Me.Controls.Add(Me.lblabove)
        Me.Controls.Add(Me.btneasy)
        Me.Controls.Add(Me.lblinstructions2)
        Me.Controls.Add(Me.lblinstructions1)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.btnclose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frminstructions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "How To Play"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnclose As Button
    Friend WithEvents lbltitle As Label
    Friend WithEvents lblinstructions1 As Label
    Friend WithEvents lblinstructions2 As Label
    Friend WithEvents btneasy As Button
    Friend WithEvents lblabove As Label
    Friend WithEvents lblhigh As Label
    Friend WithEvents lblbelow As Label
    Friend WithEvents lbllow As Label
    Friend WithEvents btnmedium As Button
    Friend WithEvents btnhard As Button
End Class
