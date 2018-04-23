Imports DevExpress.Diagram.Core
Imports DXDiagram.CustomShapeProperties.DXDiagram.CustomShapeProperties
Imports System.ComponentModel

Class MainWindow
    Public Sub New()
        InitializeComponent()
        RegisterStencil()
        LoadData()
    End Sub
    Private Sub LoadData()
        diagram.DocumentSource = "DiagramData.xml"
    End Sub
    Private Sub RegisterStencil()
        Dim stencil = New DevExpress.Diagram.Core.DiagramStencil("CustomStencil", "Custom Shapes")
        stencil.RegisterTool(New FactoryItemTool("CustomShape", Function() "Custom Shape", Function(diagram) New DiagramShapeEx(), New System.Windows.Size(230, 110), False))
        DevExpress.Diagram.Core.DiagramToolboxRegistrator.RegisterStencil(stencil)
        DevExpress.Xpf.Diagram.DiagramControl.ItemTypeRegistrator.Register(GetType(DiagramShapeEx))
    End Sub

    Private Sub diagram_CustomGetEditableItemProperties(sender As Object, e As DevExpress.Xpf.Diagram.DiagramCustomGetEditableItemPropertiesEventArgs) Handles diagram.CustomGetEditableItemProperties
        If TypeOf e.Item Is DiagramShapeEx Then
            e.Properties.Add(TypeDescriptor.GetProperties(GetType(DiagramShapeEx))("Description"))
        End If
    End Sub
End Class
