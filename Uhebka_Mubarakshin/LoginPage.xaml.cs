using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Uhebka_Mubarakshin
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClick(object sender, RoutedEventArgs e)
        {
            string tabNumber = TabNumberTextBox.Text;
            string password = ShifrPasswordBox.Password;

            // Подключение к базе данных
            using (var dbContext = new Uhebnia_Praktika_321Entities1()) // Здесь создаем экземпляр контекста базы данных
            {
                var employee = dbContext.Sotrudnik
                    .FirstOrDefault(s => s.Tab_Number_Sot.ToString() == tabNumber && s.Shifr == password);

                if (employee != null)
                {
                    // Успешный вход, переходим на следующую страницу
                    NavigationService.Navigate(new EmployeeListPage());
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
