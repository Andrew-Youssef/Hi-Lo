<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcongrats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcongrats))
        Me.lblcongratulations = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.lblvalue = New System.Windows.Forms.Label()
        Me.lblstats4 = New System.Windows.Forms.Label()
        Me.lblstats2 = New System.Windows.Forms.Label()
        Me.lblstats1 = New System.Windows.Forms.Label()
        Me.lblstats3 = New System.Windows.Forms.Label()
        Me.btnrestart = New System.Windows.Forms.Button()
        Me.lblstats5 = New System.Windows.Forms.Label()
        Me.lblstats6 = New System.Windows.Forms.Label()
        Me.lblmedium = New System.Windows.Forms.Label()
        Me.lbleasy = New System.Windows.Forms.Label()
        Me.lblhard = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lblstats7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblcongratulations
        '
        Me.lblcongratulations.AutoSize = True
        Me.lblcongratulations.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcongratulations.Location = New System.Drawing.Point(64, -11)
        Me.lblcongratulations.Name = "lblcongratulations"
        Me.lblcongratulations.Size = New System.Drawing.Size(528, 128)
        Me.lblcongratulations.TabIndex = 0
        Me.lblcongratulations.Text = "You Did It!"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(367, 114)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(127, 32)
        Me.lblusername.TabIndex = 1
        Me.lblusername.Text = "Username"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.DarkRed
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(580, 284)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 32)
        Me.btnclose.TabIndex = 7
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcount.Location = New System.Drawing.Point(355, 154)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(29, 32)
        Me.lblcount.TabIndex = 8
        Me.lblcount.Text = "0"
        '
        'lblvalue
        '
        Me.lblvalue.AutoSize = True
        Me.lblvalue.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalue.Location = New System.Drawing.Point(467, 195)
        Me.lblvalue.Name = "lblvalue"
        Me.lblvalue.Size = New System.Drawing.Size(29, 32)
        Me.lblvalue.TabIndex = 9
        Me.lblvalue.Text = "0"
        '
        'lblstats4
        '
        Me.lblstats4.AutoSize = True
        Me.lblstats4.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstats4.Location = New System.Drawing.Point(159, 195)
        Me.lblstats4.Name = "lblstats4"
        Me.lblstats4.Size = New System.Drawing.Size(314, 32)
        Me.lblstats4.TabIndex = 10
        Me.lblstats4.Text = "to guess the secret number"
        '
        'lblstats2
        '
        Me.lblstats2.AutoSize = True
        Me.lblstats2.BackColor = System.Drawing.Color.PeachPuff
        Me.lblstats2.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstats2.Location = New System.Drawing.Point(223, 154)
        Me.lblstats2.Name = "lblstats2"
        Me.lblstats2.Size = New System.Drawing.Size(144, 32)
        Me.lblstats2.TabIndex = 11
        Me.lblstats2.Text = "It took you "
        '
        'lblstats1
        '
        Me.lblstats1.AutoSize = True
        Me.lblstats1.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstats1.Location = New System.Drawing.Point(173, 114)
        Me.lblstats1.Name = "lblstats1"
        Me.lblstats1.Size = New System.Drawing.Size(197, 32)
        Me.lblstats1.TabIndex = 12
        Me.lblstats1.Text = "Congratulations"
        '
        'lblstats3
        '
        Me.lblstats3.AutoSize = True
        Me.lblstats3.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstats3.Location = New System.Drawing.Point(395, 154)
        Me.lblstats3.Name = "lblstats3"
        Me.lblstats3.Size = New System.Drawing.Size(65, 32)
        Me.lblstats3.TabIndex = 13
        Me.lblstats3.Text = "tries"
        '
        'btnrestart
        '
        Me.btnrestart.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.btnrestart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrestart.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrestart.Location = New System.Drawing.Point(580, 249)
        Me.btnrestart.Name = "btnrestart"
        Me.btnrestart.Size = New System.Drawing.Size(75, 29)
        Me.btnrestart.TabIndex = 14
        Me.btnrestart.Text = "Restart"
        Me.btnrestart.UseVisualStyleBackColor = False
        '
        'lblstats5
        '
        Me.lblstats5.AutoSize = True
        Me.lblstats5.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstats5.Location = New System.Drawing.Point(184, 237)
        Me.lblstats5.Name = "lblstats5"
        Me.lblstats5.Size = New System.Drawing.Size(85, 32)
        Me.lblstats5.TabIndex = 16
        Me.lblstats5.Text = "on the"
        '
        'lblstats6
        '
        Me.lblstats6.AutoSize = True
        Me.lblstats6.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstats6.Location = New System.Drawing.Point(358, 237)
        Me.lblstats6.Name = "lblstats6"
        Me.lblstats6.Size = New System.Drawing.Size(125, 32)
        Me.lblstats6.TabIndex = 15
        Me.lblstats6.Text = "difficulty."
        '
        'lblmedium
        '
        Me.lblmedium.AutoSize = True
        Me.lblmedium.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmedium.Location = New System.Drawing.Point(261, 237)
        Me.lblmedium.Name = "lblmedium"
        Me.lblmedium.Size = New System.Drawing.Size(106, 32)
        Me.lblmedium.TabIndex = 17
        Me.lblmedium.Text = "Medium"
        Me.lblmedium.Visible = False
        '
        'lbleasy
        '
        Me.lbleasy.AutoSize = True
        Me.lbleasy.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleasy.Location = New System.Drawing.Point(278, 237)
        Me.lbleasy.Name = "lbleasy"
        Me.lbleasy.Size = New System.Drawing.Size(66, 32)
        Me.lbleasy.TabIndex = 18
        Me.lbleasy.Text = "Easy"
        Me.lbleasy.Visible = False
        '
        'lblhard
        '
        Me.lblhard.AutoSize = True
        Me.lblhard.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhard.Location = New System.Drawing.Point(275, 235)
        Me.lblhard.Name = "lblhard"
        Me.lblhard.Size = New System.Drawing.Size(71, 32)
        Me.lblhard.TabIndex = 19
        Me.lblhard.Text = "Hard"
        Me.lblhard.Visible = False
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(323, 284)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(29, 32)
        Me.lbltime.TabIndex = 20
        Me.lbltime.Text = "0"
        '
        'lblstats7
        '
        Me.lblstats7.AutoSize = True
        Me.lblstats7.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstats7.Location = New System.Drawing.Point(214, 284)
        Me.lblstats7.Name = "lblstats7"
        Me.lblstats7.Size = New System.Drawing.Size(114, 32)
        Me.lblstats7.TabIndex = 21
        Me.lblstats7.Text = "Time (s):"
        '
        'frmcongrats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(667, 328)
        Me.Controls.Add(Me.lblstats7)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.lbleasy)
        Me.Controls.Add(Me.lblstats6)
        Me.Controls.Add(Me.btnrestart)
        Me.Controls.Add(Me.lblstats1)
        Me.Controls.Add(Me.lblstats4)
        Me.Controls.Add(Me.lblvalue)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.lblcongratulations)
        Me.Controls.Add(Me.lblcount)
        Me.Controls.Add(Me.lblstats2)
        Me.Controls.Add(Me.lblstats3)
        Me.Controls.Add(Me.lblmedium)
        Me.Controls.Add(Me.lblstats5)
        Me.Controls.Add(Me.lblhard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcongrats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Congratulations!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcongratulations As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents btnclose As Button
    Friend WithEvents lblcount As Label
    Friend WithEvents lblvalue As Label
    Friend WithEvents lblstats4 As Label
    Friend WithEvents lblstats2 As Label
    Friend WithEvents lblstats1 As Label
    Friend WithEvents lblstats3 As Label
    Friend WithEvents btnrestart As Button
    Friend WithEvents lblstats5 As Label
    Friend WithEvents lblstats6 As Label
    Friend WithEvents lblmedium As Label
    Friend WithEvents lbleasy As Label
    Friend WithEvents lblhard As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents lblstats7 As Label
End Class
