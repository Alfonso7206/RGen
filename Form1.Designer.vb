<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TexGen = New System.Windows.Forms.TextBox()
        Me.NumericUpDownCountChar = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGen = New System.Windows.Forms.Button()
        Me.TextNato = New System.Windows.Forms.TextBox()
        CType(Me.NumericUpDownCountChar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TexGen
        '
        Me.TexGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TexGen.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGen.Location = New System.Drawing.Point(12, 10)
        Me.TexGen.Name = "TexGen"
        Me.TexGen.ReadOnly = True
        Me.TexGen.Size = New System.Drawing.Size(363, 30)
        Me.TexGen.TabIndex = 7
        Me.TexGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDownCountChar
        '
        Me.NumericUpDownCountChar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDownCountChar.Font = New System.Drawing.Font("Consolas", 14.25!)
        Me.NumericUpDownCountChar.Location = New System.Drawing.Point(386, 10)
        Me.NumericUpDownCountChar.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDownCountChar.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownCountChar.Name = "NumericUpDownCountChar"
        Me.NumericUpDownCountChar.ReadOnly = True
        Me.NumericUpDownCountChar.Size = New System.Drawing.Size(56, 30)
        Me.NumericUpDownCountChar.TabIndex = 8
        Me.NumericUpDownCountChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDownCountChar.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(12, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 10)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1"
        '
        'BtnGen
        '
        Me.BtnGen.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.BtnGen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnGen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGen.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGen.Image = Global.RGen.My.Resources.Resources.copy
        Me.BtnGen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGen.Location = New System.Drawing.Point(11, 83)
        Me.BtnGen.Name = "BtnGen"
        Me.BtnGen.Size = New System.Drawing.Size(431, 36)
        Me.BtnGen.TabIndex = 6
        Me.BtnGen.Text = "G E N E R A T E"
        Me.BtnGen.UseVisualStyleBackColor = True
        '
        'TextNato
        '
        Me.TextNato.BackColor = System.Drawing.SystemColors.Control
        Me.TextNato.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextNato.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TextNato.Location = New System.Drawing.Point(12, 125)
        Me.TextNato.Multiline = True
        Me.TextNato.Name = "TextNato"
        Me.TextNato.ReadOnly = True
        Me.TextNato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextNato.Size = New System.Drawing.Size(430, 230)
        Me.TextNato.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(453, 367)
        Me.Controls.Add(Me.TextNato)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.NumericUpDownCountChar)
        Me.Controls.Add(Me.TexGen)
        Me.Controls.Add(Me.BtnGen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RGen"
        CType(Me.NumericUpDownCountChar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGen As Button
    Friend WithEvents TexGen As TextBox
    Friend WithEvents NumericUpDownCountChar As NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextNato As TextBox
End Class
