<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/328663136/20.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T963699)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# DockLayoutManager - Bind the View Model Collection with LayoutAdapters
You can use the LayoutAdapters to place dock panels to existing dock groups, but also to groups which are not created yet. In this case, you should create the target group before you populate it with panels.

Follow the steps below to use the LayoutAdapter in your application:

1. Create a LayoutAdapter class that implements the **ILayoutAdapter** interface.

2. Implement the **Resolve** method. The method returns the target layout group name for the specified **DockLayoutManager** and the panel's ViewModel. When you implement the **Resolve** method, you can perform any action before a target name is returned. 

     *File to look at*: [LayoutAdapter.cs](./CS/DXSample/Common/LayoutAdapter.cs) (**VB**: [LayoputAdapter.vb](./VB/DXSample/Common/LayoutAdapter.vb))

3. Assign a LayoutAdapter instance to the **MVVMHelper.LayoutAdapter** attached property on the [DockLayoutManager](https://docs.devexpress.com/wpf/DevExpress.Xpf.Docking.DockLayoutManager) to add the LayoutAdapter to DockLayoutManager.

     *File to look at*: [MainWindow.xaml](./CS/DXSample/MainWindow.xaml) (**VB**: [MainWindow.xaml](./VB/DXSample/MainWindow.xaml))

Refer to the [MVVM Support - Bind to a Collection of Dock Panels](https://docs.devexpress.com/WPF/11386/#non-existing-dock-panels-advanced) documentation topic for more information on how to bind a ViewModel collection to the **DockLayoutManager**.
