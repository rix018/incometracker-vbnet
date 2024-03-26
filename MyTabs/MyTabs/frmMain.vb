Public Class frmMain
    Dim bDraggable As Boolean
    Dim thisX As Integer
    Dim thisY As Integer
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        thisFrmIni()
    End Sub

    Private Sub thisFrmIni()

        bDraggable = False

        AddHandler Me.btnHome.MouseMove, AddressOf btnMenu_MouseHover
        AddHandler Me.btnTransaction.MouseMove, AddressOf btnMenu_MouseHover
        AddHandler Me.btnMntArticles.MouseMove, AddressOf btnMenu_MouseHover
        AddHandler Me.btnMntCategories.MouseMove, AddressOf btnMenu_MouseHover
        AddHandler Me.btnMntCustomers.MouseMove, AddressOf btnMenu_MouseHover
        AddHandler Me.btnMntReport.MouseMove, AddressOf btnMenu_MouseHover

        AddHandler Me.btnHome.MouseLeave, AddressOf btnMenu_MouseLeave
        AddHandler Me.btnTransaction.MouseLeave, AddressOf btnMenu_MouseLeave
        AddHandler Me.btnMntArticles.MouseLeave, AddressOf btnMenu_MouseLeave
        AddHandler Me.btnMntCategories.MouseLeave, AddressOf btnMenu_MouseLeave
        AddHandler Me.btnMntCustomers.MouseLeave, AddressOf btnMenu_MouseLeave
        AddHandler Me.btnMntReport.MouseLeave, AddressOf btnMenu_MouseLeave

        AddHandler Me.btnfrmclose.MouseMove, AddressOf btnfrmctrl_MouseHover
        AddHandler Me.btnfrmmin.MouseMove, AddressOf btnfrmctrl_MouseHover

        AddHandler Me.btnfrmclose.MouseLeave, AddressOf btnfrmctrl_MouseLeave
        AddHandler Me.btnfrmmin.MouseLeave, AddressOf btnfrmctrl_MouseLeave
    End Sub
    Private Sub frmMain_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        fFormMove_Down(Me)
    End Sub

    Private Sub frmMain_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        fFormMove_Move(Me)
    End Sub

    Private Sub frmMain_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        fFormMove_Up(Me)
    End Sub

    Private Sub pnTitlebar_MouseDown(sender As Object, e As MouseEventArgs) Handles pnTitlebar.MouseDown
        fFormMove_Down(Me)
    End Sub

    Private Sub pnTitlebar_MouseMove(sender As Object, e As MouseEventArgs) Handles pnTitlebar.MouseMove
        fFormMove_Move(Me)
    End Sub

    Private Sub pnTitlebar_MouseUp(sender As Object, e As MouseEventArgs) Handles pnTitlebar.MouseUp
        fFormMove_Up(Me)
    End Sub

    Private Sub fFormMove_Down(ByRef thisFrm As Form)
        Me.bDraggable = True
        thisX = Windows.Forms.Cursor.Position.X - Me.Left
        thisY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub fFormMove_Move(ByRef thisFrm As Form)
        If bDraggable = True Then
            Me.Top = Windows.Forms.Cursor.Position.Y - thisY
            Me.Left = Windows.Forms.Cursor.Position.X - thisX
        End If
    End Sub

    Private Sub fFormMove_Up(ByRef thisFrm As Form)
        bDraggable = False
    End Sub

    Private Sub btnfrmmin_Click(sender As Object, e As EventArgs) Handles btnfrmmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnfrmclose_Click(sender As Object, e As EventArgs) Handles btnfrmclose.Click
        Me.Dispose()
    End Sub
End Class
