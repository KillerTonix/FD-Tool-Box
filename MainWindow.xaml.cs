using FD_Tool_Box.Utilities.Collections;
using Microsoft.Win32;
using ModernWpf;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Data;

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

        private void AddIntroBtn_Checked(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Видеофайлы (*.mp4;*.avi;*.mkv;*.mpeg;*.mpg;*.mov;*.webm;*.ts;*.m4v)| *.mp4; *.avi; *.mkv; *.mpeg; *.mpg; *.mov; *.webm; *.ts; *.m4v",
                Title = "Выберите Интро",
                Multiselect = false,
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                MaterialsData.Add(new MaterialsListData
                {
                    MaterialType = "Интро",
                    MaterialPath = filePath
                });
            }
            else
            {
                
            }
        }
    }
}