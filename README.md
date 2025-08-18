# How to show vertical border to the column wise summary rows in WPF DataGrid (SfDataGrid)?

This example illustrates how to show vertical border to the column wise summary rows in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid).

The vertical borders is not shows for each cell in summary rows when [ShowSummartInRow](http://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfGrid.WPF~Syncfusion.UI.Xaml.Grid.GridSummaryRow~ShowSummaryInRow.html) is disabled in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid).

The summary rows will be displayed as shown in the following image.

![](https://www.syncfusion.com/uploads/user/kb/wpf/wpf-45086/wpf-45086_img1.png)

To show the vertical borders for each cell in summary row, write style for BorderThickness of [GridTableSummaryCell](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridTableSummaryCell.html) for [GridTableSummaryRow](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridTableSummaryRow.html), [GridCaptionSummaryCell](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridCaptionSummaryCell.html) for [CaptionSummaryRow](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.SfDataGrid.html#Syncfusion_UI_Xaml_Grid_SfDataGrid_CaptionSummaryRow), and [GridGroupSummaryCell](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridGroupSummaryCell.html) for [GroupSummaryRows](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.SfDataGrid.html#Syncfusion_UI_Xaml_Grid_SfDataGrid_GroupSummaryRows).

Refer to the following code for writing style for summary cells to show the vertical border.

```xml
<Style TargetType="syncfusion:GridTableSummaryCell">
     <Setter Property="BorderThickness" Value="0,0,1,0"/>
</Style>
<Style TargetType="syncfusion:GridCaptionSummaryCell">
     <Setter Property="BorderThickness" Value="0,0,1,1"/>
</Style>
<Style TargetType="syncfusion:GridGroupSummaryCell">
     <Setter Property="BorderThickness" Value="0,0,1,1"/>
</Style>
```

When the vertical border is applied, the summary rows will be appeared as shown in the following image.

![](https://www.syncfusion.com/uploads/user/kb/wpf/wpf-45086/wpf-45086_img2.png)
