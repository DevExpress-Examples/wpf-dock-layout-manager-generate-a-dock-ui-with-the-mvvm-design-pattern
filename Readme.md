<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128643582/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4867)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication19/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication19/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/WpfApplication19/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication19/MainWindow.xaml.vb))**
<!-- default file list end -->
# How to generate a dock UI using the MVVM design pattern


<p>The following example shows how to create layout items (DevExpress.Xpf.Docking.LayoutPanel and DevExpress.Xpf.Docking.DocumentPanel objects) from a data source according to the MVVM design pattern and how to implement template selection. </p><p>In this example, the MainViewModel class provides the Items collection that contains objects to be rendered as layout items in the DevExpress.Xpf.Docking.DockLayoutManager. An instance of the MainViewModel class is assigned to the Window's DataContext. The DevExpress.Xpf.Docking.DockLayoutManager.ItemsSource property is bound to the Items property in the MainViewModel. This way, the DevExpress.Xpf.Docking.DockLayoutManager gets the source of objects to be visualized as layout items. </p><br />
<p>The Items collection contains items of two types: </p><p>1)ViewModel objects - contain data for creating DevExpress.Xpf.Docking.LayoutPanels </p><p>2)DocumentViewModel objects - contain data for creating DevExpress.Xpf.Docking.DocumentPanels </p><p>There are two templates declared in XAML that render input objects as either DevExpress.Xpf.Docking.LayoutPanels or DevExpress.Xpf.Docking.DocumentPanels. </p><br />
<p>The custom DockItemTemplateSelector class overrides the SelectTemplate method to choose a template that corresponds to a specific item in the DevExpress.Xpf.Docking.DockLayoutManager.ItemsSource. This template selector is assigned in XAML to the DevExpress.Xpf.Docking.DockLayoutManager.ItemTemplateSelector property. </p><br />
<p>In this example, the DevExpress.Xpf.Docking.DockLayoutManager contains two groups explicitly created in XAML: a DevExpress.Xpf.Docking.LayoutGroup named panelHost and a DevExpress.Xpf.Docking.DocumentGroup named documentHost. Items from the Items collection are automatically placed in one of these groups based on their IMVVMDockingProperties.TargetName property values. </p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-dock-layout-manager-generate-a-dock-ui-with-the-mvvm-design-pattern&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-dock-layout-manager-generate-a-dock-ui-with-the-mvvm-design-pattern&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
