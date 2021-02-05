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

namespace laba2_apl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(name_box.Text.Length == 0)
            {
                MessageBox.Show("You haven't typed in a name!", "Error");
                name_box.Focus();
            } else if (group_box.Text.Length == 0)
            {
                MessageBox.Show("You haven't typed in a group!", "Error");
                group_box.Focus();
            } else
            {
                MessageBox.Show("Hello, " + name_box.Text + " from " + group_box.Text + " group");
            }
        }
    }
}
