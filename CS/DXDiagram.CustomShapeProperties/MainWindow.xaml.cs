using System.Windows;
using DevExpress.Diagram.Core;
using DevExpress.Xpf.Diagram;
using System.ComponentModel;

namespace DXDiagram.CustomShapeProperties {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            RegisterStencil();
            LoadData();
        }
        void LoadData() {
            diagramControl.DocumentSource = "DiagramData.xml";
        }
        void RegisterStencil() {
            var stencil = new DevExpress.Diagram.Core.DiagramStencil("CustomStencil", "Custom Shapes");
            var itemTool = new FactoryItemTool(
                "CustomShape",
                () => "Custom Shape", diagram => {
                    DiagramShapeEx customShape = new DiagramShapeEx() { Width = 100, Height = 50 };
                    return customShape;
                },
                new Size(100, 50),
                false
            );
            stencil.RegisterTool(itemTool);
            DiagramToolboxRegistrator.RegisterStencil(stencil);
            DiagramControl.ItemTypeRegistrator.Register(typeof(DiagramShapeEx));
        }

        private void diagramControl_CustomGetEditableItemProperties(object sender, DiagramCustomGetEditableItemPropertiesEventArgs e) {
            if (e.Item is DiagramShapeEx) {
                e.Properties.Add(TypeDescriptor.GetProperties(typeof(DiagramShapeEx))["Description"]);
            }
        }
    }
}
