using System.Windows;
using System.Windows.Media;
using System.Linq;
using System.Windows.Navigation;

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        u1255664_testdriveEntities db = new u1255664_testdriveEntities();
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = passBox.Text.Trim();
            string passAgain = passBoxAgain.Text.Trim();

            //Account account = new Account()
            //{
            //    Login = textBoxLogin.Text,
            //    Password = passBox.Text
            //};


            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "Это поле введено не корректно!";
                textBoxLogin.Background = Brushes.DarkRed;
            }
            else if (pass.Length < 5)
            {
                passBox.ToolTip = "Это поле введено не корректно!";
                passBox.Background = Brushes.DarkRed;
            }
            else if (pass != passAgain)
            {
                passBoxAgain.ToolTip = "Данные не совпадают!";
                passBoxAgain.Background = Brushes.DarkRed;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBoxAgain.ToolTip = "";
                passBoxAgain.Background = Brushes.Transparent;


                MessageBox.Show("Все отлично!");

                Account account1 = new Account(login, pass);
                
                db.Accounts1.Add(account1);
                db.SaveChanges();
                //NavigationService.Navigate(new Authorization());


                #region actual
                //var countLogin = from Account in db.Accounts1
                //                 where Account.Login == login
                //                 select Account;

                //if (countLogin.Count() > 0)
                //{
                //    MessageBox.Show("Данный пользователь с таким логином уже существует. Попробуйте другой!");
                //}
                //else
                //{
                //    db.Accounts1.Add(account);
                //    db.SaveChanges();
                //    MessageBox.Show("Регистрация прошла успешно!");
                //    NavigationService.GetNavigationService(new Authorization());
                //}
                #endregion

                #region noActual
                //Account account = new Account(login, pass);

                //using (test_driveEntities1 db = new test_driveEntities1())
                //{
                //db.Accounts1.Add(new Account(login, pass));
                //db.SaveChanges();
                //}

                //test_driveEntities1 db = new test_driveEntities1();

                //db.Accounts1.Add(new Account());
                //db.SaveChanges();

                //MessageBox.Show("Регистрация прошла успешно!");
                #endregion
            }
        }
    }
}
