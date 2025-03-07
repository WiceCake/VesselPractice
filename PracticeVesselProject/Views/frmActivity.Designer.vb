<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivity
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnCreate = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDec = New DevExpress.XtraEditors.TextEdit()
        Me.lueVessel = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbLoc = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dateAct = New DevExpress.XtraEditors.DateEdit()
        Me.lueAct = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtLong = New DevExpress.XtraEditors.SpinEdit()
        Me.txtLat = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtDec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueVessel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateAct.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateAct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnCreate)
        Me.LayoutControl1.Controls.Add(Me.txtDec)
        Me.LayoutControl1.Controls.Add(Me.lueVessel)
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.cbLoc)
        Me.LayoutControl1.Controls.Add(Me.dateAct)
        Me.LayoutControl1.Controls.Add(Me.lueAct)
        Me.LayoutControl1.Controls.Add(Me.txtLong)
        Me.LayoutControl1.Controls.Add(Me.txtLat)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(612, 335)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(391, 22)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(199, 33)
        Me.btnCreate.StyleController = Me.LayoutControl1
        Me.btnCreate.TabIndex = 14
        Me.btnCreate.Text = "Create"
        '
        'txtDec
        '
        Me.txtDec.Location = New System.Drawing.Point(95, 261)
        Me.txtDec.Name = "txtDec"
        Me.txtDec.Size = New System.Drawing.Size(495, 22)
        Me.txtDec.StyleController = Me.LayoutControl1
        Me.txtDec.TabIndex = 13
        '
        'lueVessel
        '
        Me.lueVessel.Location = New System.Drawing.Point(95, 131)
        Me.lueVessel.Name = "lueVessel"
        Me.lueVessel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueVessel.Size = New System.Drawing.Size(495, 22)
        Me.lueVessel.StyleController = Me.LayoutControl1
        Me.lueVessel.TabIndex = 12
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(22, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(162, 33)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Add Activity"
        '
        'cbLoc
        '
        Me.cbLoc.Location = New System.Drawing.Point(95, 157)
        Me.cbLoc.Name = "cbLoc"
        Me.cbLoc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLoc.Size = New System.Drawing.Size(495, 22)
        Me.cbLoc.StyleController = Me.LayoutControl1
        Me.cbLoc.TabIndex = 6
        '
        'dateAct
        '
        Me.dateAct.EditValue = Nothing
        Me.dateAct.Location = New System.Drawing.Point(95, 105)
        Me.dateAct.Name = "dateAct"
        Me.dateAct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateAct.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateAct.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew
        Me.dateAct.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dateAct.Size = New System.Drawing.Size(495, 22)
        Me.dateAct.StyleController = Me.LayoutControl1
        Me.dateAct.TabIndex = 4
        '
        'lueAct
        '
        Me.lueAct.Location = New System.Drawing.Point(95, 183)
        Me.lueAct.Name = "lueAct"
        Me.lueAct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAct.Properties.NullText = ""
        Me.lueAct.Properties.PopupSizeable = False
        Me.lueAct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lueAct.Size = New System.Drawing.Size(495, 22)
        Me.lueAct.StyleController = Me.LayoutControl1
        Me.lueAct.TabIndex = 7
        '
        'txtLong
        '
        Me.txtLong.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLong.Location = New System.Drawing.Point(95, 235)
        Me.txtLong.Name = "txtLong"
        Me.txtLong.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLong.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtLong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtLong.Size = New System.Drawing.Size(495, 22)
        Me.txtLong.StyleController = Me.LayoutControl1
        Me.txtLong.TabIndex = 9
        '
        'txtLat
        '
        Me.txtLat.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLat.Location = New System.Drawing.Point(95, 209)
        Me.txtLat.Name = "txtLat"
        Me.txtLat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLat.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtLat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtLat.Size = New System.Drawing.Size(495, 22)
        Me.txtLat.StyleController = Me.LayoutControl1
        Me.txtLat.TabIndex = 8
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.EmptySpaceItem2, Me.LayoutControlItem9, Me.LayoutControlItem2, Me.LayoutControlItem7, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(612, 335)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dateAct
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 83)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(572, 26)
        Me.LayoutControlItem1.Text = "Activity Date"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(70, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 265)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(572, 30)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbLoc
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 135)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(572, 26)
        Me.LayoutControlItem3.Text = "Location"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(70, 16)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.lueAct
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 161)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(572, 26)
        Me.LayoutControlItem4.Text = "Activity"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(70, 16)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtLat
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 187)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(572, 26)
        Me.LayoutControlItem5.Text = "Latitude"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(70, 16)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtLong
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 213)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(572, 26)
        Me.LayoutControlItem6.Text = "Longitude"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(70, 16)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.LabelControl1
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(166, 37)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 37)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(572, 46)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.lueVessel
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 109)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(572, 26)
        Me.LayoutControlItem9.Text = "Vessel"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(70, 16)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtDec
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 239)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(572, 26)
        Me.LayoutControlItem2.Text = "Description"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(70, 16)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnCreate
        Me.LayoutControlItem7.Location = New System.Drawing.Point(369, 0)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(49, 31)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(203, 37)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(166, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(203, 37)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Light Gray"
        '
        'frmActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 335)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmActivity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Activity"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtDec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueVessel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateAct.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateAct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbLoc As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dateAct As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lueVessel As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents lueAct As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtLong As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtDec As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtLat As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnCreate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
End Class
