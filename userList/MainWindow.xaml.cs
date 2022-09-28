using System.Windows;
using userList.Core;

namespace userList
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsLogged { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in UserParser.Parse("users3.txt"))
            {
                if (login.Text == item.Login && password.Password == item.Password)
                {
                    IsLogged = true;

                    if (item.Role == "Admin")
                    {
                        Admin admin = new Admin();
                        admin.Show();
                        MessageBox.Show($"Добро пожаловать {item.Name}");
                    }
                    else
                    {
                        MessageBox.Show($"Добро пожаловать {item.Name}");
                    }
                                          
                }
                else
                {
                    IsLogged = false;
                }
            }
            if (!IsLogged)
            {
                MessageBox.Show("Bad login and password");
            }
        }
    }
}
