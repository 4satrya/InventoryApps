<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.NBMenu = New DevExpress.XtraNavBar.NavBarControl()
        Me.NBGMaster = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NBProduct = New DevExpress.XtraNavBar.NavBarItem()
        Me.PanelMenu = New DevExpress.XtraEditors.PanelControl()
        Me.NBUser = New DevExpress.XtraNavBar.NavBarItem()
        CType(Me.NBMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'NBMenu
        '
        Me.NBMenu.ActiveGroup = Me.NBGMaster
        Me.NBMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NBMenu.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NBGMaster})
        Me.NBMenu.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NBProduct, Me.NBUser})
        Me.NBMenu.Location = New System.Drawing.Point(0, 0)
        Me.NBMenu.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.NBMenu.LookAndFeel.UseDefaultLookAndFeel = False
        Me.NBMenu.Name = "NBMenu"
        Me.NBMenu.OptionsNavPane.ExpandedWidth = 205
        Me.NBMenu.Size = New System.Drawing.Size(205, 562)
        Me.NBMenu.TabIndex = 1
        Me.NBMenu.Text = "NavBarControl1"
        Me.NBMenu.View = New DevExpress.XtraNavBar.ViewInfo.SkinExplorerBarViewInfoRegistrator()
        '
        'NBGMaster
        '
        Me.NBGMaster.Caption = "Master"
        Me.NBGMaster.Expanded = True
        Me.NBGMaster.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NBProduct), New DevExpress.XtraNavBar.NavBarItemLink(Me.NBUser)})
        Me.NBGMaster.Name = "NBGMaster"
        '
        'NBProduct
        '
        Me.NBProduct.Caption = "Product"
        Me.NBProduct.Name = "NBProduct"
        Me.NBProduct.SmallImage = CType(resources.GetObject("NBProduct.SmallImage"), System.Drawing.Image)
        '
        'PanelMenu
        '
        Me.PanelMenu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelMenu.Controls.Add(Me.NBMenu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(205, 562)
        Me.PanelMenu.TabIndex = 2
        '
        'NBUser
        '
        Me.NBUser.Caption = "User Management"
        Me.NBUser.Name = "NBUser"
        Me.NBUser.SmallImage = CType(resources.GetObject("NBUser.SmallImage"), System.Drawing.Image)
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 562)
        Me.Controls.Add(Me.PanelMenu)
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Application"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NBMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NBMenu As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NBGMaster As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents PanelMenu As DevExpress.XtraEditors.PanelControl
    Friend WithEvents NBProduct As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBUser As DevExpress.XtraNavBar.NavBarItem
End Class
