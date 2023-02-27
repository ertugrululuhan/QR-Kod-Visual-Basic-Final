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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnOlustur = New System.Windows.Forms.Button()
        Me.btnKaydet = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(80, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(314, 253)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(80, 287)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(314, 27)
        Me.TextBox1.TabIndex = 1
        '
        'btnOlustur
        '
        Me.btnOlustur.Location = New System.Drawing.Point(80, 335)
        Me.btnOlustur.Name = "btnOlustur"
        Me.btnOlustur.Size = New System.Drawing.Size(94, 29)
        Me.btnOlustur.TabIndex = 2
        Me.btnOlustur.Text = "oluştur"
        Me.btnOlustur.UseVisualStyleBackColor = True
        '
        'btnKaydet
        '
        Me.btnKaydet.Location = New System.Drawing.Point(300, 335)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(94, 29)
        Me.btnKaydet.TabIndex = 3
        Me.btnKaydet.Text = "kaydeyt"
        Me.btnKaydet.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 450)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.btnOlustur)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnOlustur As Button
    Friend WithEvents btnKaydet As Button
End Class
