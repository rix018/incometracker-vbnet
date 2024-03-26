Module modUIBehavior
    Public bDraggable As Boolean

    Public Sub btnMenu_MouseHover(sender As Object, e As EventArgs)
        Dim thisBtn As Button
        Dim thisBtnTag As String

        thisBtn = sender

        thisBtnTag = "menu_b_" & thisBtn.Tag

        thisBtn.ForeColor = Color.FromArgb(255, 255, 255, 255)

        thisBtn.Image = My.Resources.ResourceManager.GetObject(thisBtnTag)
    End Sub

    Public Sub btnMenu_MouseLeave(sender As Object, e As EventArgs)
        Dim thisBtn As Button
        Dim thisBtnTag As String

        thisBtn = sender

        thisBtnTag = "menu_a_" & thisBtn.Tag

        thisBtn.ForeColor = Color.FromArgb(255, 176, 176, 176)

        thisBtn.Image = My.Resources.ResourceManager.GetObject(thisBtnTag)
    End Sub

    Public Sub btnfrmctrl_MouseHover(sender As Object, e As EventArgs)
        Dim thisBtn As Button
        Dim thisBtnTag As String

        thisBtn = sender

        thisBtnTag = "frm_b_" & thisBtn.Tag
        thisBtn.Image = My.Resources.ResourceManager.GetObject(thisBtnTag)
    End Sub

    Public Sub btnfrmctrl_MouseLeave(sender As Object, e As EventArgs)
        Dim thisBtn As Button
        Dim thisBtnTag As String

        thisBtn = sender

        thisBtnTag = "frm_a_" & thisBtn.Tag
        thisBtn.Image = My.Resources.ResourceManager.GetObject(thisBtnTag)
    End Sub

End Module
