using System;
using System.Linq;
using DevExpress.Xpf.Docking;
using DXSample.ViewModels;

namespace DXSample.Common {

    public class LayoutAdapter : ILayoutAdapter {
        public string Resolve(DockLayoutManager owner, object item) {
            if (item is PanelViewModel panelViewModel) {
                switch (panelViewModel.State) {
                    case State.Float:
                        FloatGroup floatGroup = new FloatGroup() { Name = $"floatGroup{owner.FloatGroups.Count}" };
                        owner.FloatGroups.Add(floatGroup);
                        return floatGroup.Name;                        
                    case State.Regular:
                        return "documentGroup";
                    default:
                        return panelViewModel.ParentName;
                }
            }
            return String.Empty;
        }
    }
}
