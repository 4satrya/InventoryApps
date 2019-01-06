Imports DevExpress.LookAndFeel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System.Reflection

Module Common
    Public report_mark_is_bom As String = "-1"
    Public title_print As String
    Public formName As String
    Public id_user As String
    Public is_auto_load_workplace As String
    Public id_comp_user As String
    Public id_employee_user As String
    Public id_role_login As String
    Public id_departement_user As String
    Public id_departement_sub_user As String
    Public username_user As String
    Public name_user As String
    Public code_user As String
    Public product_image_path As String = ""
    Public emp_image_path As String = ""
    Public is_change_pass_user As String = ""
    Public again_awb As String = ""

    Sub errorProcess()
        XtraMessageBox.Show("Process Error, please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub errorConnection()
        XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub errorDuplicate(ByVal value As String)
        XtraMessageBox.Show("Proses Failed, Duplicate" & value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub errorDelete()
        XtraMessageBox.Show("Delete failed, this data currently used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub errorInput()
        XtraMessageBox.Show("Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub errorCustom(ByVal err_msg As String)
        XtraMessageBox.Show(err_msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub stopCustom(ByVal stop_msg As String)
        XtraMessageBox.Show(stop_msg, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Sub

    Sub infoCustom(ByVal info_msg As String)
        XtraMessageBox.Show(info_msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub warningCustom(ByVal warning_msg As String)
        XtraMessageBox.Show(warning_msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    '--------Lookup---------------------
    'View Lookup with Query
    Public Sub viewLookupQuery(ByVal LE As DevExpress.XtraEditors.LookUpEdit, ByVal query As String, ByVal index_selected As Integer, ByVal display As String, ByVal value As String)
        Try
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            LE.Properties.DataSource = Nothing
            LE.Properties.DataSource = data
            LE.Properties.DisplayMember = display
            LE.Properties.ValueMember = value
            LE.ItemIndex = index_selected
        Catch ex As Exception
            'errorConnection()
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    'View Lookup with Query
    Public Sub viewSearchLookupQuery(ByVal SLE As DevExpress.XtraEditors.SearchLookUpEdit, ByVal query As String, ByVal index_selected As String, ByVal display As String, ByVal value As String)
        'Try
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        SLE.Properties.DataSource = Nothing
        SLE.Properties.DataSource = data
        SLE.Properties.DisplayMember = display
        SLE.Properties.ValueMember = value
        If data.Rows.Count.ToString >= 1 Then
            SLE.EditValue = data.Rows(0)(index_selected).ToString
        Else
            SLE.EditValue = Nothing
        End If
        'Catch ex As Exception
        'errorConnection()
        'errorCustom(ex.ToString)
        'End Try
    End Sub
    '--------End Of Lookup---------------------
End Module