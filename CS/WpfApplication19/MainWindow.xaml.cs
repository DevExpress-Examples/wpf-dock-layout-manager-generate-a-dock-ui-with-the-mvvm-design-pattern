using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication19 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class MainViewModel : ViewModelBase {
        public MainViewModel() {
            Items = new ObservableCollection<object>() { new ViewModel() { DisplayName = "Item1" }, new ViewModel() { DisplayName = "Item2" }, new DocumentViewModel() { DisplayName = "Item3" }, new DocumentViewModel() { DisplayName = "Item4" } };
        }
        // Fields...
        private ObservableCollection<object> _Items;

        public ObservableCollection<object> Items {
            get { return _Items; }
            private set { SetProperty(ref _Items, value, "Items"); }
        }
    }
    public class DocumentViewModel : ViewModel, IMVVMDockingProperties {
        protected override string GetTargetName() {
            return "documentHost";
        }
    }
    public class ViewModel : ViewModelBase, IMVVMDockingProperties {
        // Fields...
        private string _DisplayName;

        public string DisplayName {
            get { return _DisplayName; }
            set { SetProperty(ref _DisplayName, value, "DisplayName"); }
        }
        protected virtual string GetTargetName() {
            return "panelHost";
        }
        #region IMVVMDockingProperties Members

        string IMVVMDockingProperties.TargetName {
            get { return GetTargetName(); }
            set { throw new NotImplementedException(); }
        }

        #endregion
    }
    public class DockItemTemplateSelector : DataTemplateSelector {
        public DataTemplate LayoutPanelTemplate { get; set; }
        public DataTemplate DocumentPanelTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            return item is DocumentViewModel ? DocumentPanelTemplate : LayoutPanelTemplate;
        }
    }
}
