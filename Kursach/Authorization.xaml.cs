using MySql.Data.MySqlClient;
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

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        u1255664_testdriveEntities db = new u1255664_testdriveEntities();

        public Authorization()
        {
            InitializeComponent();
        }

        private void EnterToAccount(object sender, RoutedEventArgs e)
        {
            string login = textBoxLoginAuth.Text.Trim();
            string pass = textBoxPassAuth.Password.Trim();

            if (login.Length < 5)
            {
                textBoxLoginAuth.ToolTip = "Это поле введено не корректно!";
                textBoxLoginAuth.Background = Brushes.DarkRed;
            }
            else if (pass.Length < 5)
            {
                textBoxPassAuth.ToolTip = "Это поле введено не корректно!";
                textBoxPassAuth.Background = Brushes.DarkRed;
            }
            else
            {
                textBoxLoginAuth.ToolTip = "";
                textBoxLoginAuth.Background = Brushes.Transparent;
                textBoxPassAuth.ToolTip = "";
                textBoxPassAuth.Background = Brushes.Transparent;

                Account account12 = null;
                using(u1255664_testdriveEntities db = new u1255664_testdriveEntities())
                {
                    account12 = db.Accounts1.Where(b => b.Login == login && b.Password == pass).FirstOrDefault();
                }
                MessageBox.Show("Вход выполнен!");
            }
        }
    }
}
