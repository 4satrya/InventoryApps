Public Class FormItemvb
    Private Sub FormItemvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewProduct()
    End Sub

    Private Sub FormItemvb_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Sub viewProduct()
        Dim i As New ClassItem()
        Dim data As DataTable = i.dataMain("", "2")
        GCProduct.DataSource = data
        GVProduct.BestFitColumns()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        viewProduct()
    End Sub
End Class