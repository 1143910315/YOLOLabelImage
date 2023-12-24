using System.Collections.ObjectModel;
using UraniumUI.Pages;
using YOLOLabelImage.ViewModel;

namespace YOLOLabelImage {
    public partial class MainPage : UraniumContentPage {

        public MainPage() {
            InitializeComponent();

            if (LabelDataGridView.ItemsSource is ObservableCollection<SettingViewModel.Label> labelList) {
                labelList.Add(new("测试"));
            }
            //DisplayImageView .= ContentRow.Height
        }

        private void Button_Clicked(object sender, EventArgs e) {
            foreach (var item in Resources) {
                if (item.Value is SettingViewModel setting) {
                    //setting.PictureHeight = ContentRow.Height;
                    GridView.Measure(5, 6);
                }
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e) {

        }
    }
}