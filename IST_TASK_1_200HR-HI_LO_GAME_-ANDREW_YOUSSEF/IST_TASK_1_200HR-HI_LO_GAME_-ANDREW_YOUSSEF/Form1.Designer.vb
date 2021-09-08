<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmwelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmwelcome))
        Me.lblusername = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.picgamelogo = New System.Windows.Forms.PictureBox()
        CType(Me.picgamelogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(329, 51)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(298, 37)
        Me.lblusername.TabIndex = 2
        Me.lblusername.Text = "Please Enter Your Name"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(373, 120)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(202, 33)
        Me.txtusername.TabIndex = 3
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.Location = New System.Drawing.Point(429, 173)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(102, 42)
        Me.btnsubmit.TabIndex = 4
        Me.btnsubmit.Text = "Enter"
        Me.btnsubmit.UseVisualStyleBackColor = False
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
        Me.btnclose.TabIndex = 5
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'picgamelogo
        '
        Me.picgamelogo.Image = Global.IST_TASK_1_200HR_HI_LO_GAME__ANDREW_YOUSSEF.My.Resources.Resources.HI_LO_Game_Logo2
        Me.picgamelogo.InitialImage = CType(resources.GetObject("picgamelogo.InitialImage"), System.Drawing.Image)
        Me.picgamelogo.Location = New System.Drawing.Point(26, 12)
        Me.picgamelogo.Name = "picgamelogo"
        Me.picgamelogo.Size = New System.Drawing.Size(250, 250)
        Me.picgamelogo.TabIndex = 1
        Me.picgamelogo.TabStop = False
        '
        'frmwelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(667, 290)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.picgamelogo)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmwelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Hi-Lo"
        CType(Me.picgamelogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picgamelogo As PictureBox
    Friend WithEvents lblusername As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents btnsubmit As Button
    Friend WithEvents btnclose As Button
End Class
