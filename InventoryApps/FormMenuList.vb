Public Class FormMenuList
    Private Sub TIProduct_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TIProduct.ItemClick
        Cursor = Cursors.WaitCursor
        Try
            FormItemvb.MdiParent = FormMenu
            FormItemvb.Show()
            FormItemvb.WindowState = FormWindowState.Maximized
            FormItemvb.Focus()
        Catch ex As Exception
            errorProcess()
        End Try
        Cursor = Cursors.Default
    End Sub
End Class