Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.Docking
Imports DevExpress.Xpf.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace WpfApplication19
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
	Public Class MainViewModel
		Inherits ViewModelBase
		Public Sub New()
			Items = New ObservableCollection(Of Object) (New Object() {New ViewModel() With {.DisplayName = "Item1"}, New ViewModel() With {.DisplayName = "Item2"}, New DocumentViewModel() With {.DisplayName = "Item3"}, New DocumentViewModel() With {.DisplayName = "Item4"}})
		End Sub
		' Fields...
		Private _Items As ObservableCollection(Of Object)

		Public Property Items() As ObservableCollection(Of Object)
			Get
				Return _Items
			End Get
			Private Set(ByVal value As ObservableCollection(Of Object))
				SetProperty(_Items, value, "Items")
			End Set
		End Property
	End Class
	Public Class DocumentViewModel
		Inherits ViewModel
		Implements IMVVMDockingProperties
		Protected Overrides Function GetTargetName() As String
			Return "documentHost"
		End Function
	End Class
	Public Class ViewModel
		Inherits ViewModelBase
		Implements IMVVMDockingProperties
		' Fields...
		Private _DisplayName As String

		Public Property DisplayName() As String
			Get
				Return _DisplayName
			End Get
			Set(ByVal value As String)
				SetProperty(_DisplayName, value, "DisplayName")
			End Set
		End Property
		Protected Overridable Function GetTargetName() As String
			Return "panelHost"
		End Function
		#Region "IMVVMDockingProperties Members"

		Private Property TargetName() As String Implements IMVVMDockingProperties.TargetName
			Get
				Return GetTargetName()
			End Get
			Set(ByVal value As String)
				Throw New NotImplementedException()
			End Set
		End Property

		#End Region
	End Class
	Public Class DockItemTemplateSelector
		Inherits DataTemplateSelector
		Private privateLayoutPanelTemplate As DataTemplate
		Public Property LayoutPanelTemplate() As DataTemplate
			Get
				Return privateLayoutPanelTemplate
			End Get
			Set(ByVal value As DataTemplate)
				privateLayoutPanelTemplate = value
			End Set
		End Property
		Private privateDocumentPanelTemplate As DataTemplate
		Public Property DocumentPanelTemplate() As DataTemplate
			Get
				Return privateDocumentPanelTemplate
			End Get
			Set(ByVal value As DataTemplate)
				privateDocumentPanelTemplate = value
			End Set
		End Property
		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			Return If(TypeOf item Is DocumentViewModel, DocumentPanelTemplate, LayoutPanelTemplate)
		End Function
	End Class
End Namespace
