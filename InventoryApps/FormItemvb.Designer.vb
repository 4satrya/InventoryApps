<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormItemvb
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormItemvb))
        Me.XTCProduct = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GCProduct = New DevExpress.XtraGrid.GridControl()
        Me.GVProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.ContextMenuStripProduct = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.XTCProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCProduct.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GCProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.ContextMenuStripProduct.SuspendLayout()
        Me.SuspendLayout()
        '
        'XTCProduct
        '
        Me.XTCProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCProduct.Location = New System.Drawing.Point(0, 0)
        Me.XTCProduct.Name = "XTCProduct"
        Me.XTCProduct.SelectedTabPage = Me.XtraTabPage1
        Me.XTCProduct.Size = New System.Drawing.Size(733, 541)
        Me.XTCProduct.TabIndex = 0
        Me.XTCProduct.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GCProduct)
        Me.XtraTabPage1.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(727, 513)
        Me.XtraTabPage1.Text = "Product Items"
        '
        'GCProduct
        '
        Me.GCProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCProduct.Location = New System.Drawing.Point(0, 46)
        Me.GCProduct.MainView = Me.GVProduct
        Me.GCProduct.Name = "GCProduct"
        Me.GCProduct.Size = New System.Drawing.Size(727, 467)
        Me.GCProduct.TabIndex = 0
        Me.GCProduct.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVProduct})
        '
        'GVProduct
        '
        Me.GVProduct.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumnPrice, Me.GridColumn7})
        Me.GVProduct.GridControl = Me.GCProduct
        Me.GVProduct.Name = "GVProduct"
        Me.GVProduct.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVProduct.OptionsBehavior.Editable = False
        Me.GVProduct.OptionsFind.AlwaysVisible = True
        Me.GVProduct.OptionsView.ShowGroupPanel = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BtnRefresh)
        Me.PanelControl1.Controls.Add(Me.BtnAdd)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(727, 46)
        Me.PanelControl1.TabIndex = 1
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.Location = New System.Drawing.Point(549, 2)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(95, 42)
        Me.BtnRefresh.TabIndex = 2
        Me.BtnRefresh.Text = "Refresh"
        '
        'BtnAdd
        '
        Me.BtnAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(644, 2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(81, 42)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "Add"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(727, 513)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'ContextMenuStripProduct
        '
        Me.ContextMenuStripProduct.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStripProduct.Name = "ContextMenuStripProduct"
        Me.ContextMenuStripProduct.Size = New System.Drawing.Size(108, 48)
        '
        'DetailToolStripMenuItem
        '
        Me.DetailToolStripMenuItem.Name = "DetailToolStripMenuItem"
        Me.DetailToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DetailToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Id"
        Me.GridColumn1.FieldName = "id_item"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Code"
        Me.GridColumn2.FieldName = "item_code"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Name"
        Me.GridColumn3.FieldName = "item_name"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Category"
        Me.GridColumn4.FieldName = "item_cat"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "UOM"
        Me.GridColumn5.FieldName = "uom"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Cost"
        Me.GridColumn6.DisplayFormat.FormatString = "N2"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "item_cost"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GridColumnPrice
        '
        Me.GridColumnPrice.Caption = "Price"
        Me.GridColumnPrice.DisplayFormat.FormatString = "N2"
        Me.GridColumnPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnPrice.FieldName = "item_price"
        Me.GridColumnPrice.Name = "GridColumnPrice"
        Me.GridColumnPrice.Visible = True
        Me.GridColumnPrice.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Status"
        Me.GridColumn7.FieldName = "active"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'FormItemvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 541)
        Me.Controls.Add(Me.XTCProduct)
        Me.MinimizeBox = False
        Me.Name = "FormItemvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        CType(Me.XTCProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCProduct.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GCProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ContextMenuStripProduct.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XTCProduct As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCProduct As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStripProduct As ContextMenuStrip
    Friend WithEvents DetailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
