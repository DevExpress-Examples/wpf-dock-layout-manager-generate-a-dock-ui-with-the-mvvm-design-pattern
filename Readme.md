<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4867)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Dock Layout Manager - Generate a Dock UI with the MVVM Design Pattern

The following example creates [LayoutPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.LayoutPanel) and [DocumentPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DocumentPanel) objects from a data source according to the MVVM design pattern and implements template selection.

<img src="https://user-images.githubusercontent.com/12169834/175355745-d50cc84d-c36e-4f4b-9db5-7b0dbd211b8a.png" width=600px/>

In this example, the **MainViewModel** class contains the **Items** collection that contains objects that are displayed as layout items in the [DockLayoutManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager). An instance of the **MainViewModel** class is assigned to the Window's **DataContext**. The [DockLayoutManager.ItemsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager.ItemsSource) property is bound to the **Items** property in the **MainViewModel**. In this case, the [DockLayoutManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager) gets the source of objects to  visualize it as layout items.

The **Items** collection contains the following types of items:

1. **ViewModel** objects — contain data to create [LayoutPanels](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.LayoutPanel)

1. **DocumentViewModel** objects - contain data to create [DocumentPanels](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DocumentPanel)

The example's XAML includes two templates that render input objects as [LayoutPanels](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.LayoutPanel) or [DocumentPanels](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DocumentPanel).

The custom `DockItemTemplateSelector` class overrides the `SelectTemplate` method to choose a template that corresponds to a specific item in the [DockLayoutManager.ItemsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager.ItemsSource). This template selector is assigned in XAML to the [ItemTemplateSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager.ItemTemplateSelector) property.
  
In this example, the [DockLayoutManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager) contains two groups created in XAML: a [LayoutGroup](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.LayoutGroup) (_panelHost_) and a [DocumentGroup](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DocumentGroup) (_documentHost_). Items from the **Items** collection are placed in one of these groups based on their `IMVVMDockingProperties.TargetName` property values.

<!-- default file list -->
## Files to Look At

* [MainWindow.xaml](./CS/WpfApplication19/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication19/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication19/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication19/MainWindow.xaml.vb))
<!-- default file list end -->

## More Examples

- [WPF Dock Layout Manager - Use IMVVMDockingProperties Interface to Build Dock UI with the MVVM Pattern](https://github.com/DevExpress-Examples/wpf-docklayoutmanager-use-imvvmdockingproperties-to-build-dock-ui-with-mvvm)
