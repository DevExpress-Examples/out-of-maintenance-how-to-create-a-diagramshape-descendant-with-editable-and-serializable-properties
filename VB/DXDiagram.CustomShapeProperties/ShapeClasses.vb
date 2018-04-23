Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Windows
Imports DevExpress.Diagram.Core
Imports DevExpress.Xpf.Diagram
Imports DevExpress.Utils.Serializing

Namespace DXDiagram.CustomShapeProperties

    Public Class DiagramShapeEx
        Inherits DiagramShape

        <XtraSerializableProperty>
        Public Property Description() As String

        <XtraSerializableProperty>
        Public Property ShapeID() As Integer

        Shared Sub New()
            DiagramControl.ItemTypeRegistrator.Register(GetType(DiagramShapeEx))
        End Sub

    End Class

End Namespace
