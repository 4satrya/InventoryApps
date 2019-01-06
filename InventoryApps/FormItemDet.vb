Public Class FormItemDet
    Public action As String = ""

    Private Sub FormItemDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewCat()
        viewUom()
        actionLoad()
    End Sub

    Sub actionLoad()
        ActiveControl = TxtCode
        If action = "ins" Then
            TxtUnitCost.EditValue = 0.0
            TxtUnitPrice.EditValue = 0.0
        ElseIf action = "upd" Then

        End If
    End Sub

    Sub viewCat()
        Dim query As String = "SELECT * FROM tb_item_cat "
        viewSearchLookupQuery(SLECat, query, "id_item_cat", "item_cat", "id_item_cat")
    End Sub

    Sub viewUom()
        Dim query As String = "SELECT * FROM tb_m_uom "
        viewSearchLookupQuery(SLEUOM, query, "id_uom", "uom", "id_uom")
    End Sub

    Private Sub FormItemDet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Cursor = Cursors.WaitCursor
        Dim id_item_cat As String = SLECat.EditValue.ToString
        Dim id_uom As String = SLEUOM.EditValue.ToString

        If action = "ins" Then

        Else

        End If
        Cursor = Cursors.Default
    End Sub
End Class