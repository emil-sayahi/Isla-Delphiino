<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.percent = New System.Windows.Forms.Label()
        Me.Build = New System.Windows.Forms.PictureBox()
        Me.BuildLabel = New System.Windows.Forms.Label()
        Me.systemBottom = New System.Windows.Forms.PictureBox()
        Me.systemTop = New System.Windows.Forms.PictureBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        CType(Me.Build, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.systemBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.systemTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'percent
        '
        Me.percent.AutoSize = True
        Me.percent.BackColor = System.Drawing.Color.Transparent
        Me.percent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percent.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.percent.Location = New System.Drawing.Point(550, 354)
        Me.percent.Name = "percent"
        Me.percent.Size = New System.Drawing.Size(86, 13)
        Me.percent.TabIndex = 0
        Me.percent.Text = "PLACEHOLDER"
        '
        'Build
        '
        Me.Build.BackColor = System.Drawing.Color.Transparent
        Me.Build.Image = CType(resources.GetObject("Build.Image"), System.Drawing.Image)
        Me.Build.Location = New System.Drawing.Point(443, 301)
        Me.Build.Name = "Build"
        Me.Build.Size = New System.Drawing.Size(302, 50)
        Me.Build.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Build.TabIndex = 1
        Me.Build.TabStop = False
        '
        'BuildLabel
        '
        Me.BuildLabel.AutoSize = True
        Me.BuildLabel.BackColor = System.Drawing.Color.Transparent
        Me.BuildLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BuildLabel.Location = New System.Drawing.Point(557, 310)
        Me.BuildLabel.Name = "BuildLabel"
        Me.BuildLabel.Size = New System.Drawing.Size(30, 13)
        Me.BuildLabel.TabIndex = 2
        Me.BuildLabel.Text = "Build"
        Me.BuildLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'systemBottom
        '
        Me.systemBottom.BackColor = System.Drawing.Color.Transparent
        Me.systemBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.systemBottom.Image = CType(resources.GetObject("systemBottom.Image"), System.Drawing.Image)
        Me.systemBottom.Location = New System.Drawing.Point(1, 458)
        Me.systemBottom.Name = "systemBottom"
        Me.systemBottom.Size = New System.Drawing.Size(1133, 73)
        Me.systemBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.systemBottom.TabIndex = 3
        Me.systemBottom.TabStop = False
        '
        'systemTop
        '
        Me.systemTop.Image = CType(resources.GetObject("systemTop.Image"), System.Drawing.Image)
        Me.systemTop.Location = New System.Drawing.Point(1, -2)
        Me.systemTop.Name = "systemTop"
        Me.systemTop.Size = New System.Drawing.Size(1133, 61)
        Me.systemTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.systemTop.TabIndex = 4
        Me.systemTop.TabStop = False
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.BackColor = System.Drawing.Color.Transparent
        Me.titleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.titleLabel.Location = New System.Drawing.Point(196, 23)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(70, 13)
        Me.titleLabel.TabIndex = 5
        Me.titleLabel.Text = "Isla Delphiino"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1134, 531)
        Me.Controls.Add(Me.BuildLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.systemTop)
        Me.Controls.Add(Me.systemBottom)
        Me.Controls.Add(Me.percent)
        Me.Controls.Add(Me.Build)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainForm"
        Me.Text = "Isla Delphiino"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        CType(Me.Build, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.systemBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.systemTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents percent As Label
    Friend WithEvents Build As PictureBox
    Friend WithEvents BuildLabel As Label
    Friend WithEvents systemBottom As PictureBox
    Friend WithEvents systemTop As PictureBox
    Friend WithEvents titleLabel As Label
End Class
