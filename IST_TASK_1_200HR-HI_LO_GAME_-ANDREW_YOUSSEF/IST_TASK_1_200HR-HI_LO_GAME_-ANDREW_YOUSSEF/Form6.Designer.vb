<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhardgame
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhardgame))
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btngo = New System.Windows.Forms.Button()
        Me.lblinstructions = New System.Windows.Forms.Label()
        Me.nudguess = New System.Windows.Forms.NumericUpDown()
        Me.lblname = New System.Windows.Forms.Label()
        Me.piclow = New System.Windows.Forms.PictureBox()
        Me.pichigh = New System.Windows.Forms.PictureBox()
        Me.lbltimetitle = New System.Windows.Forms.Label()
        Me.lblhardgametim = New System.Windows.Forms.Label()
        Me.timhardgame = New System.Windows.Forms.Timer(Me.components)
        CType(Me.nudguess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichigh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.DarkRed
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(580, 252)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 32)
        Me.btnclose.TabIndex = 20
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btngo
        '
        Me.btngo.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.btngo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btngo.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngo.Location = New System.Drawing.Point(257, 198)
        Me.btngo.Name = "btngo"
        Me.btngo.Size = New System.Drawing.Size(120, 48)
        Me.btngo.TabIndex = 24
        Me.btngo.Text = "Go!"
        Me.btngo.UseVisualStyleBackColor = False
        '
        'lblinstructions
        '
        Me.lblinstructions.AutoSize = True
        Me.lblinstructions.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinstructions.Location = New System.Drawing.Point(126, 54)
        Me.lblinstructions.Name = "lblinstructions"
        Me.lblinstructions.Size = New System.Drawing.Size(426, 40)
        Me.lblinstructions.TabIndex = 21
        Me.lblinstructions.Text = "Choose a number from 1 to 100"
        '
        'nudguess
        '
        Me.nudguess.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudguess.Location = New System.Drawing.Point(257, 128)
        Me.nudguess.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudguess.Name = "nudguess"
        Me.nudguess.Size = New System.Drawing.Size(120, 35)
        Me.nudguess.TabIndex = 19
        Me.nudguess.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(218, 6)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(200, 37)
        Me.lblname.TabIndex = 18
        Me.lblname.Text = "Player's Name"
        '
        'piclow
        '
        Me.piclow.Image = Global.IST_TASK_1_200HR_HI_LO_GAME__ANDREW_YOUSSEF.My.Resources.Resources.Low_label1
        Me.piclow.Location = New System.Drawing.Point(458, 80)
        Me.piclow.Name = "piclow"
        Me.piclow.Size = New System.Drawing.Size(170, 170)
        Me.piclow.TabIndex = 23
        Me.piclow.TabStop = False
        Me.piclow.Visible = False
        '
        'pichigh
        '
        Me.pichigh.Image = Global.IST_TASK_1_200HR_HI_LO_GAME__ANDREW_YOUSSEF.My.Resources.Resources.High_label1
        Me.pichigh.Location = New System.Drawing.Point(12, 80)
        Me.pichigh.Name = "pichigh"
        Me.pichigh.Size = New System.Drawing.Size(170, 170)
        Me.pichigh.TabIndex = 22
        Me.pichigh.TabStop = False
        Me.pichigh.Visible = False
        '
        'lbltimetitle
        '
        Me.lbltimetitle.AutoSize = True
        Me.lbltimetitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimetitle.Location = New System.Drawing.Point(546, 9)
        Me.lbltimetitle.Name = "lbltimetitle"
        Me.lbltimetitle.Size = New System.Drawing.Size(50, 20)
        Me.lbltimetitle.TabIndex = 26
        Me.lbltimetitle.Text = "Timer:"
        '
        'lblhardgametim
        '
        Me.lblhardgametim.AutoSize = True
        Me.lblhardgametim.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhardgametim.Location = New System.Drawing.Point(546, 29)
        Me.lblhardgametim.Name = "lblhardgametim"
        Me.lblhardgametim.Size = New System.Drawing.Size(18, 20)
        Me.lblhardgametim.TabIndex = 25
        Me.lblhardgametim.Text = "1"
        '
        'timhardgame
        '
        Me.timhardgame.Interval = 1000
        '
        'frmhardgame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(667, 290)
        Me.Controls.Add(Me.lbltimetitle)
        Me.Controls.Add(Me.lblhardgametim)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btngo)
        Me.Controls.Add(Me.lblinstructions)
        Me.Controls.Add(Me.nudguess)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.piclow)
        Me.Controls.Add(Me.pichigh)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmhardgame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hi-Lo - Hard"
        CType(Me.nudguess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichigh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnclose As Button
    Friend WithEvents btngo As Button
    Friend WithEvents lblinstructions As Label
    Friend WithEvents nudguess As NumericUpDown
    Friend WithEvents lblname As Label
    Friend WithEvents piclow As PictureBox
    Friend WithEvents pichigh As PictureBox
    Friend WithEvents lbltimetitle As Label
    Friend WithEvents lblhardgametim As Label
    Friend WithEvents timhardgame As Timer
End Class
