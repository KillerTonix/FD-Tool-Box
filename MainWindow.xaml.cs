using FD_Tool_Box.Utilities;
using FD_Tool_Box.Utilities.Collections;
using FD_Tool_Box.Utilities.Materials;
using ModernWpf;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace FD_Tool_Box
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<MaterialsListData> MaterialsData { get; set; } = [];

        public MainWindow()
        {
            InitializeComponent();
            MaterialsListView.ItemsSource = MaterialsData;
            this.DataContext = this;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ThemeManager.Current.ApplicationTheme = ApplicationTheme.Dark;

        }

        private void AddIntroToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if (MaterialsSelection.SelectedMaterial("Video") is string filePath && !string.IsNullOrEmpty(filePath))
            {
                MaterialsData.Add(new MaterialsListData
                {
                    MaterialType = "Интро",
                    MaterialPath = filePath
                });
                MaterialsListView.Items.Refresh();
                ListViewColumnsAutoResize.AutoResizeColumns();
            }
            else
            {
                AddIntroToggleButton.IsChecked = false;
            }

        }

        private void DeleteMaterialButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is MaterialsListData item)
            {
                MaterialsData.Remove(item);
            }

        }

        private void AddVideoToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if (MaterialsSelection.SelectedMaterial("Video") is string filePath && !string.IsNullOrEmpty(filePath))
            {
                MaterialsData.Add(new MaterialsListData
                {
                    MaterialType = "Видео",
                    MaterialPath = filePath
                });
                MaterialsListView.Items.Refresh();
                ListViewColumnsAutoResize.AutoResizeColumns();
            }
            else
            {
                AddVideoToggleButton.IsChecked = false;
            }
        }

        private void AddLogoToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if (MaterialsSelection.SelectedMaterial("Image") is string filePath && !string.IsNullOrEmpty(filePath))
            {
                MaterialsData.Add(new MaterialsListData
                {
                    MaterialType = "Лого",
                    MaterialPath = filePath
                });
                MaterialsListView.Items.Refresh();
                ListViewColumnsAutoResize.AutoResizeColumns();
            }
            else
            {
                AddLogoToggleButton.IsChecked = false;
            }
        }

        private void AddSubtitlesToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if (MaterialsSelection.SelectedMaterial("Subtitle") is string filePath && !string.IsNullOrEmpty(filePath))
            {
                MaterialsData.Add(new MaterialsListData
                {
                    MaterialType = "Субтитры",
                    MaterialPath = filePath
                });
                MaterialsListView.Items.Refresh();
                ListViewColumnsAutoResize.AutoResizeColumns();
            }
            else
            {
                AddSubtitlesToggleButton.IsChecked = false;
            }
        }

        private void AddAuidioToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if (MaterialsSelection.SelectedMaterial("Audio") is string filePath && !string.IsNullOrEmpty(filePath))
            {
                MaterialsData.Add(new MaterialsListData
                {
                    MaterialType = "Аудио",
                    MaterialPath = filePath
                });
                MaterialsListView.Items.Refresh();
                ListViewColumnsAutoResize.AutoResizeColumns();
            }
            else
            {
                AddAuidioToggleButton.IsChecked = false;
            }
        }

        private void AddOutroToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if (MaterialsSelection.SelectedMaterial("Video") is string filePath && !string.IsNullOrEmpty(filePath))
            {
                MaterialsData.Add(new MaterialsListData
                {
                    MaterialType = "Аутро",
                    MaterialPath = filePath
                });
                MaterialsListView.Items.Refresh();
                ListViewColumnsAutoResize.AutoResizeColumns();
            }
            else
            {
                AddOutroToggleButton.IsChecked = false;
            }

        }
    }
}