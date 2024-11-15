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

namespace Uhebka_Mubarakshin
{
    /// <summary>
    /// Логика взаимодействия для EmployeeListPage.xaml
    /// </summary>
    public partial class EmployeeListPage : Page
    {

        public EmployeeListPage()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            using (var dbContext = new Uhebnia_Praktika_321Entities1())
            {
                var employees = dbContext.Sotrudnik
                    .Join(dbContext.Prepodovatel, s => s.Tab_Number_Sot, p => p.Tab_Nomer, (s, p) => new
                    {
                        s.Tab_Number_Sot,
                        s.Doljnost,
                        s.Zarplata,
                        //s.Staj,
                        p.Zvanie,
                        p.Stepen
                    })
                    .ToList();

                EmployeeDataGrid.ItemsSource = employees;
            }
        }
    }
}