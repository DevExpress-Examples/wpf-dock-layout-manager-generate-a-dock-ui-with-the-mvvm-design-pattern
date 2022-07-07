Imports DevExpress.Xpf.Docking
Imports DevExpress.Mvvm
Imports System
Imports System.Collections.ObjectModel
Imports System.Windows
Imports System.Windows.Controls

Namespace WpfApplication19

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Sub New()
            Items = New ObservableCollection(Of Object)() From {New ViewModel() With {.DisplayName = "Item1"}, New ViewModel() With {.DisplayName = "Item2"}, New DocumentViewModel() With {.DisplayName = "Item3"}, New DocumentViewModel() With {.DisplayName = "Item4"}}
        End Sub

        ' Fields...
        Private _Items As ObservableCollection(Of Object)

        Public Property Items As ObservableCollection(Of Object)
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

        Public Property DisplayName As String
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

'#Region "IMVVMDockingProperties Members"
        Private Property TargetName As String Implements IMVVMDockingProperties.TargetName
            Get
                Return GetTargetName()
            End Get

            Set(ByVal value As String)
                Throw New NotImplementedException()
            End Set
        End Property
'#End Region
    End Class

    Public Class DockItemTemplateSelector
        Inherits DataTemplateSelector

        Public Property LayoutPanelTemplate As DataTemplate

        Public Property DocumentPanelTemplate As DataTemplate

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Return If(TypeOf item Is DocumentViewModel, DocumentPanelTemplate, LayoutPanelTemplate)
        End Function
    End Class
End Namespace
