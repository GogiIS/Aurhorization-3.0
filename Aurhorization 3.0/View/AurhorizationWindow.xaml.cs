using Aurhorization_3._0.Core;
using Aurhorization_3._0.View;
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

namespace Aurhorization_3._0
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

        private void SingIn_Click(object sender, RoutedEventArgs e)
        {
            if (UserValidator.Validate(tbLogin.Text, tbPassword.Text))
            {
                new ListUserWindow().Show();
                Close();
            }
            else MessageBox.Show("Invalid log or pass");
        }
    }
}
