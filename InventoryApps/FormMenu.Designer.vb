<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnMenu = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PanelControl1.Controls.Add(Me.BtnMenu)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(47, 595)
        Me.PanelControl1.TabIndex = 0
        '
        'BtnMenu
        '
        Me.BtnMenu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.BtnMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMenu.Image = CType(resources.GetObject("BtnMenu.Image"), System.Drawing.Image)
        Me.BtnMenu.Location = New System.Drawing.Point(2, 2)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(43, 34)
        Me.BtnMenu.TabIndex = 0
        Me.BtnMenu.ToolTipTitle = "Main Menu"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 595)
        Me.Controls.Add(Me.PanelControl1)
        Me.IsMdiContainer = True
        Me.MinimizeBox = False
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Application"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnMenu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
End Class
