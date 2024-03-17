<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlOperations = New System.Windows.Forms.Panel()
        Me.pnlLegend = New System.Windows.Forms.Panel()
        Me.pnlMap = New System.Windows.Forms.Panel()
        Me.pnlAttribute = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapefileOperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PointToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PolylineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PolygonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreatePointShapefileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavePointToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreatePolylineShapefileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreatePolygonShapefileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapOptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeasurementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToExtendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintMapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttributeTableOperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAttributeTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAColumnInTheAttributeTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAColumnInTheAttributeTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAttributeTableInShapefileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAttributeTableToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Map1 = New DotSpatial.Controls.Map()
        Me.Legend1 = New DotSpatial.Controls.Legend()
        Me.dgvAttributeTable = New System.Windows.Forms.DataGridView()
        Me.pnlOperations.SuspendLayout()
        Me.pnlLegend.SuspendLayout()
        Me.pnlMap.SuspendLayout()
        Me.pnlAttribute.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvAttributeTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlOperations
        '
        Me.pnlOperations.Controls.Add(Me.MenuStrip1)
        Me.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlOperations.Location = New System.Drawing.Point(0, 0)
        Me.pnlOperations.Name = "pnlOperations"
        Me.pnlOperations.Size = New System.Drawing.Size(800, 55)
        Me.pnlOperations.TabIndex = 0
        '
        'pnlLegend
        '
        Me.pnlLegend.Controls.Add(Me.Legend1)
        Me.pnlLegend.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLegend.Location = New System.Drawing.Point(0, 55)
        Me.pnlLegend.Name = "pnlLegend"
        Me.pnlLegend.Size = New System.Drawing.Size(200, 395)
        Me.pnlLegend.TabIndex = 1
        '
        'pnlMap
        '
        Me.pnlMap.Controls.Add(Me.Map1)
        Me.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMap.Location = New System.Drawing.Point(200, 55)
        Me.pnlMap.Name = "pnlMap"
        Me.pnlMap.Size = New System.Drawing.Size(600, 395)
        Me.pnlMap.TabIndex = 2
        '
        'pnlAttribute
        '
        Me.pnlAttribute.Controls.Add(Me.dgvAttributeTable)
        Me.pnlAttribute.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlAttribute.Location = New System.Drawing.Point(200, 350)
        Me.pnlAttribute.Name = "pnlAttribute"
        Me.pnlAttribute.Size = New System.Drawing.Size(600, 100)
        Me.pnlAttribute.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ShapefileOperationsToolStripMenuItem, Me.MapOptionToolStripMenuItem, Me.AttributeTableOperationsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ShapefileOperationsToolStripMenuItem
        '
        Me.ShapefileOperationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PointToolStripMenuItem, Me.PolylineToolStripMenuItem, Me.PolygonToolStripMenuItem})
        Me.ShapefileOperationsToolStripMenuItem.Name = "ShapefileOperationsToolStripMenuItem"
        Me.ShapefileOperationsToolStripMenuItem.Size = New System.Drawing.Size(193, 29)
        Me.ShapefileOperationsToolStripMenuItem.Text = "Shapefile Operations"
        '
        'PointToolStripMenuItem
        '
        Me.PointToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreatePointShapefileToolStripMenuItem, Me.SavePointToolStripMenuItem})
        Me.PointToolStripMenuItem.Name = "PointToolStripMenuItem"
        Me.PointToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.PointToolStripMenuItem.Text = "Point"
        '
        'PolylineToolStripMenuItem
        '
        Me.PolylineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreatePolylineShapefileToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.PolylineToolStripMenuItem.Name = "PolylineToolStripMenuItem"
        Me.PolylineToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.PolylineToolStripMenuItem.Text = "Polyline "
        '
        'PolygonToolStripMenuItem
        '
        Me.PolygonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreatePolygonShapefileToolStripMenuItem, Me.SaveToolStripMenuItem1})
        Me.PolygonToolStripMenuItem.Name = "PolygonToolStripMenuItem"
        Me.PolygonToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.PolygonToolStripMenuItem.Text = "Polygon"
        '
        'CreatePointShapefileToolStripMenuItem
        '
        Me.CreatePointShapefileToolStripMenuItem.Name = "CreatePointShapefileToolStripMenuItem"
        Me.CreatePointShapefileToolStripMenuItem.Size = New System.Drawing.Size(291, 34)
        Me.CreatePointShapefileToolStripMenuItem.Text = " Create Point Shapefile"
        '
        'SavePointToolStripMenuItem
        '
        Me.SavePointToolStripMenuItem.Name = "SavePointToolStripMenuItem"
        Me.SavePointToolStripMenuItem.Size = New System.Drawing.Size(291, 34)
        Me.SavePointToolStripMenuItem.Text = " Save Point Shapefile"
        '
        'CreatePolylineShapefileToolStripMenuItem
        '
        Me.CreatePolylineShapefileToolStripMenuItem.Name = "CreatePolylineShapefileToolStripMenuItem"
        Me.CreatePolylineShapefileToolStripMenuItem.Size = New System.Drawing.Size(306, 34)
        Me.CreatePolylineShapefileToolStripMenuItem.Text = "Create Polyline Shapefile"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(306, 34)
        Me.SaveToolStripMenuItem.Text = "Save Polyline Shapefile"
        '
        'CreatePolygonShapefileToolStripMenuItem
        '
        Me.CreatePolygonShapefileToolStripMenuItem.Name = "CreatePolygonShapefileToolStripMenuItem"
        Me.CreatePolygonShapefileToolStripMenuItem.Size = New System.Drawing.Size(311, 34)
        Me.CreatePolygonShapefileToolStripMenuItem.Text = "Create Polygon Shapefile"
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(311, 34)
        Me.SaveToolStripMenuItem1.Text = "Save Polygon Shapefile"
        '
        'MapOptionToolStripMenuItem
        '
        Me.MapOptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem, Me.InformationToolStripMenuItem, Me.MeasurementToolStripMenuItem, Me.ZoomInToolStripMenuItem, Me.ZoomOutToolStripMenuItem, Me.ZoomToExtendToolStripMenuItem, Me.PanToolStripMenuItem, Me.PrintMapToolStripMenuItem})
        Me.MapOptionToolStripMenuItem.Name = "MapOptionToolStripMenuItem"
        Me.MapOptionToolStripMenuItem.Size = New System.Drawing.Size(125, 29)
        Me.MapOptionToolStripMenuItem.Text = "Map Option"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.DefaultToolStripMenuItem.Text = "Default"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.InformationToolStripMenuItem.Text = "Information"
        '
        'MeasurementToolStripMenuItem
        '
        Me.MeasurementToolStripMenuItem.Name = "MeasurementToolStripMenuItem"
        Me.MeasurementToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.MeasurementToolStripMenuItem.Text = "Measurement"
        '
        'ZoomInToolStripMenuItem
        '
        Me.ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem"
        Me.ZoomInToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ZoomInToolStripMenuItem.Text = "Zoom In"
        '
        'ZoomOutToolStripMenuItem
        '
        Me.ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem"
        Me.ZoomOutToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ZoomOutToolStripMenuItem.Text = "Zoom Out"
        '
        'ZoomToExtendToolStripMenuItem
        '
        Me.ZoomToExtendToolStripMenuItem.Name = "ZoomToExtendToolStripMenuItem"
        Me.ZoomToExtendToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ZoomToExtendToolStripMenuItem.Text = "Zoom to Extend"
        '
        'PanToolStripMenuItem
        '
        Me.PanToolStripMenuItem.Name = "PanToolStripMenuItem"
        Me.PanToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.PanToolStripMenuItem.Text = "Pan"
        '
        'PrintMapToolStripMenuItem
        '
        Me.PrintMapToolStripMenuItem.Name = "PrintMapToolStripMenuItem"
        Me.PrintMapToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.PrintMapToolStripMenuItem.Text = "Print Map"
        '
        'AttributeTableOperationsToolStripMenuItem
        '
        Me.AttributeTableOperationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAttributeTableToolStripMenuItem, Me.AddAColumnInTheAttributeTableToolStripMenuItem, Me.DeleteAColumnInTheAttributeTableToolStripMenuItem, Me.UpdateAttributeTableInShapefileToolStripMenuItem, Me.ExportAttributeTableToExcelToolStripMenuItem})
        Me.AttributeTableOperationsToolStripMenuItem.Name = "AttributeTableOperationsToolStripMenuItem"
        Me.AttributeTableOperationsToolStripMenuItem.Size = New System.Drawing.Size(236, 29)
        Me.AttributeTableOperationsToolStripMenuItem.Text = "Attribute Table Operations"
        '
        'ViewAttributeTableToolStripMenuItem
        '
        Me.ViewAttributeTableToolStripMenuItem.Name = "ViewAttributeTableToolStripMenuItem"
        Me.ViewAttributeTableToolStripMenuItem.Size = New System.Drawing.Size(407, 34)
        Me.ViewAttributeTableToolStripMenuItem.Text = "View Attribute table"
        '
        'AddAColumnInTheAttributeTableToolStripMenuItem
        '
        Me.AddAColumnInTheAttributeTableToolStripMenuItem.Name = "AddAColumnInTheAttributeTableToolStripMenuItem"
        Me.AddAColumnInTheAttributeTableToolStripMenuItem.Size = New System.Drawing.Size(407, 34)
        Me.AddAColumnInTheAttributeTableToolStripMenuItem.Text = "Add a column in the attribute table"
        '
        'DeleteAColumnInTheAttributeTableToolStripMenuItem
        '
        Me.DeleteAColumnInTheAttributeTableToolStripMenuItem.Name = "DeleteAColumnInTheAttributeTableToolStripMenuItem"
        Me.DeleteAColumnInTheAttributeTableToolStripMenuItem.Size = New System.Drawing.Size(407, 34)
        Me.DeleteAColumnInTheAttributeTableToolStripMenuItem.Text = "Delete a column in the attribute table"
        '
        'UpdateAttributeTableInShapefileToolStripMenuItem
        '
        Me.UpdateAttributeTableInShapefileToolStripMenuItem.Name = "UpdateAttributeTableInShapefileToolStripMenuItem"
        Me.UpdateAttributeTableInShapefileToolStripMenuItem.Size = New System.Drawing.Size(407, 34)
        Me.UpdateAttributeTableInShapefileToolStripMenuItem.Text = "Update attribute table in Shapefile"
        '
        'ExportAttributeTableToExcelToolStripMenuItem
        '
        Me.ExportAttributeTableToExcelToolStripMenuItem.Name = "ExportAttributeTableToExcelToolStripMenuItem"
        Me.ExportAttributeTableToExcelToolStripMenuItem.Size = New System.Drawing.Size(407, 34)
        Me.ExportAttributeTableToExcelToolStripMenuItem.Text = " Export Attribute table to Excel."
        '
        'Map1
        '
        Me.Map1.AllowDrop = True
        Me.Map1.BackColor = System.Drawing.Color.White
        Me.Map1.CollectAfterDraw = False
        Me.Map1.CollisionDetection = False
        Me.Map1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Map1.ExtendBuffer = False
        Me.Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        Me.Map1.IsBusy = False
        Me.Map1.Legend = Me.Legend1
        Me.Map1.Location = New System.Drawing.Point(0, 0)
        Me.Map1.Name = "Map1"
        Me.Map1.ProgressHandler = Nothing
        Me.Map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.RedrawLayersWhileResizing = False
        Me.Map1.SelectionEnabled = True
        Me.Map1.Size = New System.Drawing.Size(600, 395)
        Me.Map1.TabIndex = 0
        '
        'Legend1
        '
        Me.Legend1.BackColor = System.Drawing.Color.White
        Me.Legend1.ControlRectangle = New System.Drawing.Rectangle(0, 0, 200, 395)
        Me.Legend1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Legend1.DocumentRectangle = New System.Drawing.Rectangle(0, 0, 187, 428)
        Me.Legend1.HorizontalScrollEnabled = True
        Me.Legend1.Indentation = 30
        Me.Legend1.IsInitialized = False
        Me.Legend1.Location = New System.Drawing.Point(0, 0)
        Me.Legend1.MinimumSize = New System.Drawing.Size(5, 5)
        Me.Legend1.Name = "Legend1"
        Me.Legend1.ProgressHandler = Nothing
        Me.Legend1.ResetOnResize = False
        Me.Legend1.SelectionFontColor = System.Drawing.Color.Black
        Me.Legend1.SelectionHighlight = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Legend1.Size = New System.Drawing.Size(200, 395)
        Me.Legend1.TabIndex = 0
        Me.Legend1.Text = "Legend1"
        Me.Legend1.VerticalScrollEnabled = True
        '
        'dgvAttributeTable
        '
        Me.dgvAttributeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAttributeTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAttributeTable.Location = New System.Drawing.Point(0, 0)
        Me.dgvAttributeTable.Name = "dgvAttributeTable"
        Me.dgvAttributeTable.RowHeadersWidth = 62
        Me.dgvAttributeTable.RowTemplate.Height = 28
        Me.dgvAttributeTable.Size = New System.Drawing.Size(600, 100)
        Me.dgvAttributeTable.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlAttribute)
        Me.Controls.Add(Me.pnlMap)
        Me.Controls.Add(Me.pnlLegend)
        Me.Controls.Add(Me.pnlOperations)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlOperations.ResumeLayout(False)
        Me.pnlOperations.PerformLayout()
        Me.pnlLegend.ResumeLayout(False)
        Me.pnlMap.ResumeLayout(False)
        Me.pnlAttribute.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvAttributeTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlOperations As Panel
    Friend WithEvents pnlLegend As Panel
    Friend WithEvents pnlMap As Panel
    Friend WithEvents pnlAttribute As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShapefileOperationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PointToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreatePointShapefileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SavePointToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PolylineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreatePolylineShapefileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PolygonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreatePolygonShapefileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MapOptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MeasurementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToExtendToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintMapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttributeTableOperationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAttributeTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAColumnInTheAttributeTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAColumnInTheAttributeTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateAttributeTableInShapefileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportAttributeTableToExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Legend1 As DotSpatial.Controls.Legend
    Friend WithEvents Map1 As DotSpatial.Controls.Map
    Friend WithEvents dgvAttributeTable As DataGridView
End Class
