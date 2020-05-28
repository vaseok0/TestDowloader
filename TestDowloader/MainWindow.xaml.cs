using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestDowloader
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public  void Button_Click(object sender, RoutedEventArgs e)
        {
            var Loaded = new Loader();

            if (checkBox1.IsChecked == true)
            {
                checkBox2.IsChecked = checkBox3.IsChecked = false;
                string uri = "https://www.aimp.ru/?do=download.file&id=4";
                Loaded.Loaded(uri, label1, progressBar1, "Aimp4");
                
            }
            else if(checkBox2.IsChecked == true)
            {
                string uri = "https://t1.daumcdn.net/potplayer/PotPlayer/Version/Latest/PotPlayerSetup64.exe";
                Loaded.Loaded(uri, label1, progressBar1, "PotPlayer");
            }
            else if (checkBox3.IsChecked == true)
            {
                string uri = "https://download.tenorshare.net/go/ultdata-for-windows_1094.exe";
                Loaded.Loaded(uri, label1, progressBar1, "PuranFileReovery");
            }

        }
    }
}
