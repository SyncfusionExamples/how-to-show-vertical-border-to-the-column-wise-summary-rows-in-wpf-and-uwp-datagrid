# How to show vertical border to the column wise summary rows in WPF DataGrid (SfDataGrid)
 
The vertical borders is not shows for each cell in summary rows when [ShowSummartInRow](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridSummaryRow.html?_gl=1*2hs72g*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODE0ODc4MS4yOTYuMS4xNjY4MTUwNDU1LjAuMC4w&_ga=2.209263514.967019853.1668146580-766490130.1650530957#Syncfusion_UI_Xaml_Grid_GridSummaryRow_ShowSummaryInRow) is disabled in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid).

To show the vertical borders for each cell in summary row, write style for BorderThickness of  [GridTableSummaryCell](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridTableSummaryCell.html?_gl=1*vamhcg*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODE0ODc4MS4yOTYuMS4xNjY4MTUwODI5LjAuMC4w&_ga=2.184081454.967019853.1668146580-766490130.1650530957) for [GridTableSummaryRow](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridTableSummaryRow.html?_gl=1*yw6gvu*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODE0ODc4MS4yOTYuMS4xNjY4MTUwODgyLjAuMC4w&_ga=2.188888099.967019853.1668146580-766490130.1650530957), [GridCaptionSummaryCell](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridCaptionSummaryCell.html?_gl=1*17c5563*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODE0ODc4MS4yOTYuMS4xNjY4MTUwOTMxLjAuMC4w&_ga=2.188888099.967019853.1668146580-766490130.1650530957) for [CaptionSummaryRow](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.SfDataGrid.html#Syncfusion_UI_Xaml_Grid_SfDataGrid_CaptionSummaryRow), and [GridGroupSummaryCell](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridGroupSummaryCell.html?_gl=1*xuo47h*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODE0ODc4MS4yOTYuMS4xNjY4MTUwOTYxLjAuMC4w&_ga=2.223198995.967019853.1668146580-766490130.1650530957) for [GroupSummaryRow](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.SfDataGrid.html?_gl=1*eney17*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODE0ODc4MS4yOTYuMS4xNjY4MTUxMDQ4LjAuMC4w&_ga=2.223198995.967019853.1668146580-766490130.1650530957#Syncfusion_UI_Xaml_Grid_SfDataGrid_GroupSummaryRows).

Refer to the following code for writing style for summary cells to show the vertical border.

```
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