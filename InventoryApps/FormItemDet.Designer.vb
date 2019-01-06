<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormItemDet
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormItemDet))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtName = New DevExpress.XtraEditors.TextEdit()
        Me.MEDescription = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.SLEUOM = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.GridColumnIdUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SLECat = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUnitPrice = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.CEActive = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.TxtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SLEUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.SLECat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUnitPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEActive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(22, 27)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Code"
        '
        'TxtCode
        '
        Me.TxtCode.Location = New System.Drawing.Point(112, 24)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(364, 20)
        Me.TxtCode.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(22, 53)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Name"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(112, 50)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(364, 20)
        Me.TxtName.TabIndex = 2
        '
        'MEDescription
        '
        Me.MEDescription.Location = New System.Drawing.Point(112, 128)
        Me.MEDescription.Name = "MEDescription"
        Me.MEDescription.Size = New System.Drawing.Size(364, 47)
        Me.MEDescription.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(22, 130)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Description"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(22, 105)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Unit of Measure"
        '
        'SLEUOM
        '
        Me.SLEUOM.Location = New System.Drawing.Point(112, 102)
        Me.SLEUOM.Name = "SLEUOM"
        Me.SLEUOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLEUOM.Properties.ShowClearButton = False
        Me.SLEUOM.Properties.View = Me.SearchLookUpEdit1View
        Me.SLEUOM.Size = New System.Drawing.Size(364, 20)
        Me.SLEUOM.TabIndex = 4
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnIdUom, Me.GridColumnUom})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BtnCancel)
        Me.PanelControl1.Controls.Add(Me.BtnSave)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 273)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(500, 46)
        Me.PanelControl1.TabIndex = 8
        '
        'BtnSave
        '
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(417, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(81, 42)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "Save"
        '
        'BtnCancel
        '
        Me.BtnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(336, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(81, 42)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "Cancel"
        '
        'GridColumnIdUom
        '
        Me.GridColumnIdUom.Caption = "Id"
        Me.GridColumnIdUom.FieldName = "id_uom"
        Me.GridColumnIdUom.Name = "GridColumnIdUom"
        '
        'GridColumnUom
        '
        Me.GridColumnUom.Caption = "GridColumnUom"
        Me.GridColumnUom.FieldName = "uom"
        Me.GridColumnUom.Name = "GridColumnUom"
        Me.GridColumnUom.Visible = True
        Me.GridColumnUom.VisibleIndex = 0
        '
        'SLECat
        '
        Me.SLECat.Location = New System.Drawing.Point(112, 76)
        Me.SLECat.Name = "SLECat"
        Me.SLECat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLECat.Properties.ShowClearButton = False
        Me.SLECat.Properties.View = Me.GridView1
        Me.SLECat.Size = New System.Drawing.Size(364, 20)
        Me.SLECat.TabIndex = 3
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Id"
        Me.GridColumn1.FieldName = "id_item_cat"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Category"
        Me.GridColumn2.FieldName = "item_cat"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(22, 79)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "Category"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(22, 184)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "Unit Cost"
        '
        'TxtUnitCost
        '
        Me.TxtUnitCost.Location = New System.Drawing.Point(112, 181)
        Me.TxtUnitCost.Name = "TxtUnitCost"
        Me.TxtUnitCost.Properties.DisplayFormat.FormatString = "N2"
        Me.TxtUnitCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUnitCost.Properties.Mask.EditMask = "N2"
        Me.TxtUnitCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtUnitCost.Size = New System.Drawing.Size(364, 20)
        Me.TxtUnitCost.TabIndex = 6
        '
        'TxtUnitPrice
        '
        Me.TxtUnitPrice.Location = New System.Drawing.Point(112, 207)
        Me.TxtUnitPrice.Name = "TxtUnitPrice"
        Me.TxtUnitPrice.Properties.DisplayFormat.FormatString = "N2"
        Me.TxtUnitPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUnitPrice.Properties.Mask.EditMask = "N2"
        Me.TxtUnitPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtUnitPrice.Size = New System.Drawing.Size(364, 20)
        Me.TxtUnitPrice.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(22, 210)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl7.TabIndex = 14
        Me.LabelControl7.Text = "Unit Price"
        '
        'CEActive
        '
        Me.CEActive.Location = New System.Drawing.Point(112, 233)
        Me.CEActive.Name = "CEActive"
        Me.CEActive.Properties.Caption = "Active"
        Me.CEActive.Size = New System.Drawing.Size(63, 19)
        Me.CEActive.TabIndex = 8
        '
        'FormItemDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 319)
        Me.Controls.Add(Me.CEActive)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.TxtUnitPrice)
        Me.Controls.Add(Me.TxtUnitCost)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.SLECat)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.SLEUOM)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.MEDescription)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.TxtCode)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormItemDet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Details"
        CType(Me.TxtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SLEUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.SLECat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUnitPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEActive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MEDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SLEUOM As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumnIdUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SLECat As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUnitPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CEActive As DevExpress.XtraEditors.CheckEdit
End Class
