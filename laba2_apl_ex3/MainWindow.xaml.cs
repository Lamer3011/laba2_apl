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

namespace laba2_apl_ex3
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

        private void log_button_Click(object sender, RoutedEventArgs e)
        {
            string username = user_log.Text;
            string password = pass_log.Password;
            if (username.Length <= 2)
            {
                MessageBox.Show("Введіть логін(більше 2 букв)");
            } else if (password.Length <= 2)
            {
                MessageBox.Show("Введіть пароль(більше 2 букв)");
            } else
            {
                if (username == "admin")
                {
                    if (password == "admin")
                    {
                        MessageBox.Show("Ви успішно увійшли");
                    } else
                    {
                        MessageBox.Show("Неправильний пароль", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Неправильний логін", "Error");
                }
            }
        }
    }
}
