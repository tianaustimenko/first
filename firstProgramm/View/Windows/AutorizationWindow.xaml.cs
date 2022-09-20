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

namespace firstProgramm.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AutorizationWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {
        private List<User> _users;
        public AutorizationWindow()
        {
            InitializeComponent();

        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (UserLogic.Validate(tbLogin.Text, tbPassword.Password))
            {
                new AdminWindow().Show();
                Close();
            }
            else MessageBox.Show("Ошибка", "Неправильный логин или пароль",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
