using FD_Tool_Box.Utilities.Logger;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace FD_Tool_Box.Utilities
{
    public class ListViewColumnsAutoResize
    {
        private static readonly MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

        public static void AutoResizeColumns()
        {
            try
            {
                ListView? listView = mainWindow.MaterialsListView;
                if (listView.View is GridView gridView)
                {
                    foreach (var column in gridView.Columns)
                    {
                        if (double.IsNaN(column.Width))
                        {
                            column.Width = column.ActualWidth;
                        }
                        column.Width = double.NaN;
                    }
                }                
            }
            catch (Exception ex)
            {
               ExceptionLogger.LogException(ex, "ListViewColumnsAutoResize", MethodBase.GetCurrentMethod()?.Name);
            }
        }
    }
}
