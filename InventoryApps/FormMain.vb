Public Class FormMain
    Private Sub NBProduct_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NBProduct.LinkClicked
        Cursor = Cursors.WaitCursor
        Try
            FormItemvb.MdiParent = Me
            FormItemvb.Show()
            FormItemvb.WindowState = FormWindowState.Maximized
            FormItemvb.Focus()
        Catch ex As Exception
            errorProcess()
        End Try
        Cursor = Cursors.Default
    End Sub
End Class