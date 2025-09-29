using System.Collections.ObjectModel;
using FD_Tool_Box.Commands;
using FD_Tool_Box.Models;

namespace FD_Tool_Box.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private Material? _selected;
        public ObservableCollection<Material> Materials { get; } = new();

        public Material? SelectedMaterial
        {
            get => _selected;
            set { if (Set(ref _selected, value)) DeleteMaterialCommand.RaiseCanExecuteChanged(); }
        }

        public RelayCommand AddMaterialCommand { get; }
        public RelayCommand DeleteMaterialCommand { get; }

        public MainViewModel()
        {
            // seed (replace with your real loading later)
            Materials.Add(new Material { MaterialType = "Audio", MaterialPath = @"C:\Audio\clip.wav" });
            Materials.Add(new Material { MaterialType = "Subtitle", MaterialPath = @"C:\Subs\file.ass" });

            AddMaterialCommand = new RelayCommand(_ =>
            {
                Materials.Add(new Material { MaterialType = "New", MaterialPath = "…" });
            });

            DeleteMaterialCommand = new RelayCommand(
                exec: p =>
                {
                    var target = p as Material ?? SelectedMaterial;
                    if (target is not null && Materials.Contains(target))
                        Materials.Remove(target);
                },
                can: p =>
                {
                    var target = p as Material ?? SelectedMaterial;
                    return target is not null && Materials.Contains(target);
                });
        }
    }
}
