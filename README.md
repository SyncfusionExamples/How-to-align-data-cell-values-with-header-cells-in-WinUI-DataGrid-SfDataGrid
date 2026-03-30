# How to align data cell values with header cells in WinUI DataGrid (SfDataGrid)?

In [WinUI DataGrid](https://www.syncfusion.com/winui-controls/datagrid) (SfDataGrid), When padding is applied to `GridHeaderCellControl` and `GridCell` using `Style`, the padding for the GridCell is not updated correctly. This happens because the display control applies internal padding within the [GridColumn](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.DataGrid.GridColumn.html). As a result, the padding set on the GridCell through styles is not reflected as expected.

To overcome this, set the padding directly on the [GridColumn](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.DataGrid.GridColumn.html) to 0. This ensures that the padding is applied and updated correctly.

**XML**
```
<dataGrid:SfDataGrid.Columns>
    <dataGrid:GridTextColumn MappingName="OrderID" HeaderText="Order ID" Padding="0"/>
</dataGrid:SfDataGrid.Columns>
```

Alternatively, you can set the display control’s padding to 0 by customizing the [GridCellTextBoxRenderer](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.DataGrid.Renderers.GridCellTextBoxRenderer.html) and overriding the [OnInitializeDisplayElement](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.DataGrid.Renderers.GridCellTextBoxRenderer.html#Syncfusion_UI_Xaml_DataGrid_Renderers_GridCellTextBoxRenderer_OnInitializeDisplayElement_Syncfusion_UI_Xaml_DataGrid_DataColumnBase_Microsoft_UI_Xaml_Controls_TextBlock_System_Object_) method.

**C#**
```
 this.sfDataGrid.CellRenderers.Remove("TextBox");
 this.sfDataGrid.CellRenderers.Add("TextBox", new GridCellTextBoxRendererExt());

 public class GridCellTextBoxRendererExt : GridCellTextBoxRenderer
 {
     public override void OnInitializeDisplayElement(DataColumnBase dataColumn, TextBlock uiElement, object dataContext)
     {
         base.OnInitializeDisplayElement(dataColumn, uiElement, dataContext);
         uiElement.Padding = new Thickness(0);
     }
 }
```

**Note**: You need to customize the renderer based on the column type being used.

![Align data cell with header cells](Align%20data%20cell%20with%20header%20cells.gif)

Take a moment to peruse the [WinUI DataGrid - Columns](https://help.syncfusion.com/winui/datagrid/column-types) documentation, to learn more about columns and it's types.