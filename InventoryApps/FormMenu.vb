Public Class FormMenu
    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Cursor = Cursors.WaitCursor
        Try
            FormMenuList.MdiParent = Me
            FormMenuList.Show()
            FormMenuList.WindowState = FormWindowState.Maximized
            FormMenuList.Focus()
        Catch ex As Exception
            errorProcess()
        End Try
        Cursor = Cursors.Default
    End Sub
End Class