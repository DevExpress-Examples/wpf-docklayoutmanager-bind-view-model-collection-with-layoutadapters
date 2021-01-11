using DevExpress.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace DXSample.ViewModels {
    public class MainViewModel : ViewModelBase {
        public ObservableCollection<PanelViewModel> Panels {
            get { return GetValue<ObservableCollection<PanelViewModel>>(); }
            set { SetValue(value); }
        }

        public MainViewModel() {
            Panels = new ObservableCollection<PanelViewModel>() {
                new PanelViewModel() { Caption = "One", Content = "A regular panel", State = State.Regular },
                new PanelViewModel() { Caption = "Two", Content = "A regular panel", State = State.Regular },
                new PanelViewModel() { Caption = "Three", Content = "A regular panel", State = State.Regular },
                new PanelViewModel() { Caption = "Four", Content = "A float panel", State = State.Float },
                new PanelViewModel() { Caption = "Five", Content = "A panel", ParentName = "layoutGroup" },

            };
        }
    }
    public enum State { None, Float, Regular }

    public class PanelViewModel : ViewModelBase {
        public string Caption {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public string Content {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public State State {
            get { return GetValue<State>(); }
            set { SetValue(value); }
        }
        public string ParentName {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}