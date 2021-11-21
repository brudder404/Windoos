Public Class Form1









    'moveing form
    Dim firstX As Integer
    Dim firstY As Integer
    Dim lbuttonDown As Boolean

    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MovePanel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbuttonDown = True
            firstX = e.X
            firstY = e.Y
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MovePanel.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbuttonDown = False
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MovePanel.MouseMove
        If lbuttonDown Then
            Me.Left = -firstX + PointToScreen(e.Location).X
            Me.Top = PointToScreen(e.Location).Y
        End If
    End Sub
    'moveing form

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Iconbox.Image = System.Drawing.Image.FromFile("icon.ico")

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
    End Sub
    Dim Maximized As Boolean

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Maximizebutton.Click
        If Maximized = False Then
            Me.WindowState = FormWindowState.Maximized
            Maximized = True
        Else
            Me.WindowState = FormWindowState.Maximized = 1
            Maximized = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Minimizebutton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Iconbox.Click
        Iconboxmenu.Show()
        Iconboxmenu.Location = MousePosition
    End Sub

    Private Sub ToolStripMinimize_Click(sender As Object, e As EventArgs) Handles ToolStripMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ToolStripMaximize_Click(sender As Object, e As EventArgs) Handles ToolStripMaximize.Click
        If Maximized = False Then
            Me.WindowState = FormWindowState.Maximized
            Maximized = True
            ToolStripMaximize.Text = "Restore"
        Else
            Me.WindowState = FormWindowState.Maximized = 1
            Maximized = False
            ToolStripMaximize.Text = "Maximize"
        End If
    End Sub

    Private Sub ToolStripClose_Click(sender As Object, e As EventArgs) Handles ToolStripClose.Click
        Close()
    End Sub


End Class
