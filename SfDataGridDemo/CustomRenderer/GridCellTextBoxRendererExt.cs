using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Syncfusion.UI.Xaml.DataGrid;
using Syncfusion.UI.Xaml.DataGrid.Renderers;

namespace SfDataGridDemo
{
    public class GridCellTextBoxRendererExt : GridCellTextBoxRenderer
    {
        public override void OnInitializeDisplayElement(DataColumnBase dataColumn, TextBlock uiElement, object dataContext)
        {
            base.OnInitializeDisplayElement(dataColumn, uiElement, dataContext);
            uiElement.Padding = new Thickness(0);
        }
    }
}
