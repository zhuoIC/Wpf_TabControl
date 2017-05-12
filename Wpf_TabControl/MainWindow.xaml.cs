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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_TabControl
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int nTab = tbcControles.Items.Count;
            tbcControles.SelectedIndex = (tbcControles.SelectedIndex+1) % nTab;
        }

        private void Retroceder(object sender, RoutedEventArgs e)
        {
            int nTab = tbcControles.Items.Count;
            tbcControles.SelectedIndex = (tbcControles.SelectedIndex + nTab- 1) % nTab;
        }

        private void mniCasado_Click(object sender, RoutedEventArgs e)
        {
            if (mniCasado.IsChecked)
            {
                MessageBox.Show("Si");
            }
            else
            {
                MessageBox.Show("No");
            }
        }
    }
}
