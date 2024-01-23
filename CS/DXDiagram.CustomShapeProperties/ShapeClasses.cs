using DevExpress.Utils.Serializing;
using DevExpress.Xpf.Diagram;

namespace DXDiagram.CustomShapeProperties {
    public class DiagramShapeEx : DiagramShape {
        [XtraSerializableProperty]
        public string Description { get; set; }
        static DiagramShapeEx() {
            DiagramControl.ItemTypeRegistrator.Register(typeof(DiagramShapeEx));
        }
    }
}
