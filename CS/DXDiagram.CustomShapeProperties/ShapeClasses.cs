using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using DevExpress.Diagram.Core;
using DevExpress.Utils.Serializing;
using DevExpress.Xpf.Diagram;

namespace DXDiagram.CustomShapeProperties {
    public class DiagramShapeEx : DiagramShape {
        [XtraSerializableProperty]
        public string Description { get; set; }
        [XtraSerializableProperty]
        public int ShapeID { get; set;}
        static DiagramShapeEx() {
            DiagramControl.ItemTypeRegistrator.Register(typeof(DiagramShapeEx));
        }
    }
}
