<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Splash))
        SplashLabel = New Label()
        Timer1 = New Timer(components)
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' SplashLabel
        ' 
        SplashLabel.AutoSize = True
        SplashLabel.Font = New Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point)
        SplashLabel.Location = New Point(12, 11)
        SplashLabel.Name = "SplashLabel"
        SplashLabel.Size = New Size(367, 33)
        SplashLabel.TabIndex = 0
        SplashLabel.Text = "Welcome To Useless Oggy App!"
        SplashLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 5000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 5.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(161, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 10)
        Label1.TabIndex = 1
        Label1.Text = "Im a splash screen!"
        ' 
        ' Splash
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(384, 53)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(SplashLabel)
        ForeColor = SystemColors.ControlLightLight
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Splash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Splash"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SplashLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
