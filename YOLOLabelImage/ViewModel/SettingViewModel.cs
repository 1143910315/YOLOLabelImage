using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOLOLabelImage.ViewModel {
    internal class SettingViewModel : ViewModelBase {
        public ObservableCollection<Label> LabelList { get; } = new();
        public double PictureHeight { get; set; } = 100;
        public class Label {
            public String Name { get; set; }
            public Label(String Name) {
                this.Name = Name;
            }
        }
        public SettingViewModel() {
            Console.WriteLine("");
        }
    }
}
