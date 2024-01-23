Imports DevExpress.Utils.Serializing
Imports DevExpress.Xpf.Diagram

Namespace DXDiagram.CustomShapeProperties

    Public Class DiagramShapeEx
        Inherits DiagramShape

        <XtraSerializableProperty>
        Public Property Description As String

        Shared Sub New()
            DiagramControl.ItemTypeRegistrator.Register(GetType(DiagramShapeEx))
        End Sub
    End Class
End Namespace
