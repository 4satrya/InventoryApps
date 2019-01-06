Public Class ClassItem
    Public Function dataMain(ByVal cond As String, ByVal order As String) As DataTable
        If order = "1" Then
            order = "ASC "
        Else
            order = "DESC "
        End If

        Dim query As String = "SELECT i.id_item, i.id_item_cat, cat.item_cat, i.id_uom, u.uom, i.item_code, i.item_name, i.item_description, i.item_cost, i.item_price, i.id_active, a.active
        FROM tb_item i 
        INNER JOIN tb_item_cat cat ON cat.id_item_cat = i.id_item_cat
        INNER JOIN tb_m_uom u ON u.id_uom = i.id_uom
        INNER JOIN tb_lookup_active a ON a.id_active = i.id_active
        WHERE i.id_item>0 " + cond
        query += "order BY i.id_item " + order
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        Return data
    End Function
End Class
