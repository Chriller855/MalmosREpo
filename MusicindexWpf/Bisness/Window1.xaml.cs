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

namespace Bisness
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window1_OnLoaded(object sender, RoutedEventArgs e)
        {
            MusicDataDataContext con =new MusicDataDataContext();

            List<Musik> musiks = (from s in con.Musiks select s).ToList();

            Musicgrid.ItemsSource = musiks;

        }

       
    }
}
