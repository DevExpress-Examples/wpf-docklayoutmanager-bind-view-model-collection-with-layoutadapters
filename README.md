<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/328663136/20.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T963699)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Dock Layout Manager - Bind the View Model Collection with LayoutAdapters

You can use LayoutAdapters to place dock panels in existing dock groups, as well as groups that have not yet been created. In this case, you should create the target group before you populate it with panels.

![image](https://user-images.githubusercontent.com/12169834/174016482-6466bbd9-3dde-4776-95bd-ac1423a09875.png)

Follow the steps below to use the LayoutAdapter in your application:

1. Create a LayoutAdapter class that implements the **ILayoutAdapter** interface.
2. Implement the **Resolve** method. This method returns the target layout group name for the specified **DockLayoutManager** and the panel's ViewModel. When you implement the **Resolve** method, you can perform any action before the target name is returned.
3. Assign a LayoutAdapter instance to the [DockLayoutManager](https://docs.devexpress.com/wpf/DevExpress.Xpf.Docking.DockLayoutManager)'s **MVVMHelper.LayoutAdapter** attached property to add the LayoutAdapter to the DockLayoutManager.


<!-- default file list -->
## Files to Look At:
* [MainWindow.xaml](./CS/DXSample/MainWindow.xaml) (**VB**: [MainWindow.xaml](./VB/DXSample/MainWindow.xaml))
* [LayoutAdapter.cs](./CS/DXSample/Common/LayoutAdapter.cs) (**VB**: [LayoputAdapter.vb](./VB/DXSample/Common/LayoutAdapter.vb))
<!-- default file list end -->

## Documentation

- [MVVM Support - Bind to a Collection of Dock Panels](https://docs.devexpress.com/WPF/11386/#non-existing-dock-panels-advanced)

## More Examples

- [WPF Dock Layout Manager - Bind the View Model Collection with IMVVMDockingProperties](https://github.com/DevExpress-Examples/wpf-docklayoutmanager-bind-view-model-collection-with-IMVVMDockingProperties)
- [WPF Dock Layout Manager - Populate a LayoutGroup with the ViewModels Collection](https://github.com/DevExpress-Examples/wpf-docklayoutmanager-display-viewmodels-collection-in-layoutgroup)
- [WPF Dock Layout Manager - Use Services That Implement the IDocumentManagerService Interface](https://github.com/DevExpress-Examples/wpf-docklayoutmanager-use-services-that-implement-the-idocumentmanagerservice)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-docklayoutmanager-bind-view-model-collection-with-layoutadapters&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-docklayoutmanager-bind-view-model-collection-with-layoutadapters&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
