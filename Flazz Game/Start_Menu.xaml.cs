using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Flazz_Game
{
    /// <summary>
    /// Interaction logic for Start_Menu.xaml
    /// </summary>
    public partial class Start_Menu : Window
    {
        public Start_Menu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)//Categories
        {
        

        }
        private void Button_Click_1(object sender, RoutedEventArgs e) {//Difficulty

        
        
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Visibility = Visibility.Hidden;//https://stackoverflow.com/questions/33823326/this-close-doesnt-work-in-window-wpf/33823397
            this.Close();
        }
    }
}
