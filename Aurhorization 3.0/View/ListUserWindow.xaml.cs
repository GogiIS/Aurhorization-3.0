using Aurhorization_3._0.Core;
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

namespace Aurhorization_3._0.View
{
    /// <summary>
    /// Логика взаимодействия для ListUserWindow.xaml
    /// </summary>
    public partial class ListUserWindow : Window
    {
        public ListUserWindow()
        {
            InitializeComponent();

            List<User> users = new List<User>()
            {
                new User("aaa","bbb","ccc","admin","admin"),
                new User("aaa","bbb","ccc","admin","admin"),
                new User("aaa","bbb","ccc","admin","admin"),
                new User("aaa","bbb","ccc","admin","admin"),
            };
            lvUsers.ItemsSource = users;
        }
    }
}
