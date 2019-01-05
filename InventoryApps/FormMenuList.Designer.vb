<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuList
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
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TGMaster = New DevExpress.XtraEditors.TileGroup()
        Me.TIProduct = New DevExpress.XtraEditors.TileItem()
        Me.TIUserManage = New DevExpress.XtraEditors.TileItem()
        Me.TGTransaction = New DevExpress.XtraEditors.TileGroup()
        Me.TGReport = New DevExpress.XtraEditors.TileGroup()
        Me.SuspendLayout()
        '
        'TileControl1
        '
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.DragSize = New System.Drawing.Size(0, 0)
        Me.TileControl1.Groups.Add(Me.TGMaster)
        Me.TileControl1.Groups.Add(Me.TGTransaction)
        Me.TileControl1.Groups.Add(Me.TGReport)
        Me.TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.TileControl1.MaxId = 2
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.ShowGroupText = True
        Me.TileControl1.ShowText = True
        Me.TileControl1.Size = New System.Drawing.Size(883, 569)
        Me.TileControl1.TabIndex = 0
        Me.TileControl1.Text = "Inventory Application"
        '
        'TGMaster
        '
        Me.TGMaster.Items.Add(Me.TIProduct)
        Me.TGMaster.Items.Add(Me.TIUserManage)
        Me.TGMaster.Name = "TGMaster"
        Me.TGMaster.Text = "Master"
        '
        'TIProduct
        '
        TileItemElement1.Text = "Product"
        Me.TIProduct.Elements.Add(TileItemElement1)
        Me.TIProduct.Id = 0
        Me.TIProduct.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TIProduct.Name = "TIProduct"
        '
        'TIUserManage
        '
        TileItemElement2.Text = "User Management"
        Me.TIUserManage.Elements.Add(TileItemElement2)
        Me.TIUserManage.Id = 1
        Me.TIUserManage.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TIUserManage.Name = "TIUserManage"
        '
        'TGTransaction
        '
        Me.TGTransaction.Name = "TGTransaction"
        Me.TGTransaction.Text = "Transaction"
        '
        'TGReport
        '
        Me.TGReport.Name = "TGReport"
        Me.TGReport.Text = "Report"
        '
        'FormMenuList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 569)
        Me.Controls.Add(Me.TileControl1)
        Me.MinimizeBox = False
        Me.Name = "FormMenuList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TGMaster As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TIProduct As DevExpress.XtraEditors.TileItem
    Friend WithEvents TIUserManage As DevExpress.XtraEditors.TileItem
    Friend WithEvents TGTransaction As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TGReport As DevExpress.XtraEditors.TileGroup
End Class
