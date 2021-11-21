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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MovePanel = New System.Windows.Forms.Panel()
        Me.Iconbox = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Closebutton = New System.Windows.Forms.Button()
        Me.Minimizebutton = New System.Windows.Forms.Button()
        Me.Maximizebutton = New System.Windows.Forms.Button()
        Me.Iconboxmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMinimize = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMaximize = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovePanel.SuspendLayout()
        CType(Me.Iconbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Iconboxmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MovePanel
        '
        Me.MovePanel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MovePanel.Controls.Add(Me.Iconbox)
        Me.MovePanel.Controls.Add(Me.Panel2)
        Me.MovePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MovePanel.Location = New System.Drawing.Point(0, 0)
        Me.MovePanel.Name = "MovePanel"
        Me.MovePanel.Size = New System.Drawing.Size(664, 31)
        Me.MovePanel.TabIndex = 0
        '
        'Iconbox
        '
        Me.Iconbox.Location = New System.Drawing.Point(3, 3)
        Me.Iconbox.Name = "Iconbox"
        Me.Iconbox.Size = New System.Drawing.Size(25, 25)
        Me.Iconbox.TabIndex = 1
        Me.Iconbox.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Closebutton)
        Me.Panel2.Controls.Add(Me.Minimizebutton)
        Me.Panel2.Controls.Add(Me.Maximizebutton)
        Me.Panel2.Location = New System.Drawing.Point(572, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(92, 30)
        Me.Panel2.TabIndex = 3
        '
        'Closebutton
        '
        Me.Closebutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Closebutton.Location = New System.Drawing.Point(62, 0)
        Me.Closebutton.Name = "Closebutton"
        Me.Closebutton.Size = New System.Drawing.Size(30, 30)
        Me.Closebutton.TabIndex = 0
        Me.Closebutton.Text = "X"
        Me.Closebutton.UseVisualStyleBackColor = True
        '
        'Minimizebutton
        '
        Me.Minimizebutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimizebutton.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Minimizebutton.Location = New System.Drawing.Point(0, 0)
        Me.Minimizebutton.Name = "Minimizebutton"
        Me.Minimizebutton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Minimizebutton.Size = New System.Drawing.Size(30, 30)
        Me.Minimizebutton.TabIndex = 2
        Me.Minimizebutton.Text = "-"
        Me.Minimizebutton.UseVisualStyleBackColor = True
        '
        'Maximizebutton
        '
        Me.Maximizebutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Maximizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Maximizebutton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Maximizebutton.Location = New System.Drawing.Point(31, 0)
        Me.Maximizebutton.Name = "Maximizebutton"
        Me.Maximizebutton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Maximizebutton.Size = New System.Drawing.Size(30, 30)
        Me.Maximizebutton.TabIndex = 1
        Me.Maximizebutton.Text = "□"
        Me.Maximizebutton.UseVisualStyleBackColor = True
        '
        'Iconboxmenu
        '
        Me.Iconboxmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMinimize, Me.ToolStripMaximize, Me.ToolStripClose})
        Me.Iconboxmenu.Name = "ContextMenuStrip1"
        Me.Iconboxmenu.Size = New System.Drawing.Size(126, 70)
        '
        'ToolStripMinimize
        '
        Me.ToolStripMinimize.Name = "ToolStripMinimize"
        Me.ToolStripMinimize.Size = New System.Drawing.Size(125, 22)
        Me.ToolStripMinimize.Text = "Minimize"
        '
        'ToolStripMaximize
        '
        Me.ToolStripMaximize.Name = "ToolStripMaximize"
        Me.ToolStripMaximize.Size = New System.Drawing.Size(125, 22)
        Me.ToolStripMaximize.Text = "Maximize"
        '
        'ToolStripClose
        '
        Me.ToolStripClose.Name = "ToolStripClose"
        Me.ToolStripClose.Size = New System.Drawing.Size(125, 22)
        Me.ToolStripClose.Text = "Close"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 538)
        Me.Controls.Add(Me.MovePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.MovePanel.ResumeLayout(False)
        CType(Me.Iconbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Iconboxmenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MovePanel As Panel
    Friend WithEvents Minimizebutton As Button
    Friend WithEvents Maximizebutton As Button
    Friend WithEvents Closebutton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Iconbox As PictureBox
    Friend WithEvents Iconboxmenu As ContextMenuStrip
    Friend WithEvents ToolStripMinimize As ToolStripMenuItem
    Friend WithEvents ToolStripMaximize As ToolStripMenuItem
    Friend WithEvents ToolStripClose As ToolStripMenuItem
End Class
