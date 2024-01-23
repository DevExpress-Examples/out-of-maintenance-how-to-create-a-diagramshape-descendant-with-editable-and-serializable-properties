Imports System.Windows
Imports DevExpress.Diagram.Core
Imports DevExpress.Xpf.Diagram
Imports System.ComponentModel

Namespace DXDiagram.CustomShapeProperties

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            RegisterStencil()
            LoadData()
        End Sub

        Private Sub LoadData()
            Me.diagramControl.DocumentSource = "DiagramData.xml"
        End Sub

        Private Sub RegisterStencil()
            Dim stencil = New DiagramStencil("CustomStencil", "Custom Shapes")
            Dim itemTool = New FactoryItemTool("CustomShape", Function() "Custom Shape", Function(diagram)
                Dim customShape As DiagramShapeEx = New DiagramShapeEx() With {.Width = 100, .Height = 50}
                Return customShape
            End Function, New Size(100, 50), False)
            stencil.RegisterTool(itemTool)
            DiagramToolboxRegistrator.RegisterStencil(stencil)
            DiagramControl.ItemTypeRegistrator.Register(GetType(DiagramShapeEx))
        End Sub

        Private Sub diagramControl_CustomGetEditableItemProperties(ByVal sender As Object, ByVal e As DiagramCustomGetEditableItemPropertiesEventArgs)
            If TypeOf e.Item Is DiagramShapeEx Then
                e.Properties.Add(TypeDescriptor.GetProperties(GetType(DiagramShapeEx))("Description"))
            End If
        End Sub
    End Class
End Namespace
