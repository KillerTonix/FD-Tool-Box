using Microsoft.Win32;

namespace FD_Tool_Box.Utilities.Materials
{
    public class MaterialsSelection
    {
        public static string SelectedMaterial(string fileType)
        {
            var (filter, title) = GetFileDialogSettings(fileType);
            var openFileDialog = new OpenFileDialog
            {
                Filter = filter,
                Title = title,
                Multiselect = false,
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
               return filePath;
            }
            return string.Empty;
        }

        public static (string Filter, string Title) GetFileDialogSettings(string fileType)
        {
            if (AppSettings.Default.Language == "English")
            {
                return fileType switch
                {
                    "Video" => ("Video files (*.mp4;*.avi;*.mkv;*.mpeg;*.mpg;*.mov;*.webm;*.ts;*.m4v)| *.mp4; *.avi; *.mkv; *.mpeg; *.mpg; *.mov; *.webm; *.ts; *.m4v", "Select Video File"),
                    "Audio" => ("Audio files (*.mp3;*.wav;*.flac)| *.mp3; *.wav; *.flac", "Select Audio File"),
                    "Image" => ("Images (*.jpg;*.jpeg;*.png)| *.jpg; *.jpeg; *.png", "Select Image"),
                    "Subtitle" => ("Subtitles (*.ass;*.srt)| *.ass; *.srt", "Select Subtitles"),
                    _ => ("All files(*.*) | *.* ", "Select file")
                };
            }

            return fileType switch
            {
                "Video" => ("Видеофайлы (*.mp4;*.avi;*.mkv;*.mpeg;*.mpg;*.mov;*.webm;*.ts;*.m4v)| *.mp4; *.avi; *.mkv; *.mpeg; *.mpg; *.mov; *.webm; *.ts; *.m4v", "Выберите видеофайл"),
                "Audio" => ("Аудиофайлы (*.mp3;*.wav;*.flac)| *.mp3; *.wav; *.flac", "Выберите аудиофайл"),
                "Image" => ("Изображения (*.jpg;*.jpeg;*.png)| *.jpg; *.jpeg; *.png", "Выберите изображение"),
                "Subtitle" => ("Субтитры (*.ass;*.srt)| *.ass; *.srt", "Выберите Субтитры"),
                _ => ("Все файлы (*.*)| *.*", "Выберите файл"),
            };
        }
    }
}
