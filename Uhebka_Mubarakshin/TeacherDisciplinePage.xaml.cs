using System.Linq;
using System.Windows.Controls;

namespace Uhebka_Mubarakshin
{
    /// <summary>
    /// Логика взаимодействия для TeacherDisciplinePage.xaml
    /// </summary>
    public partial class TeacherDisciplinePage : Page
    {
        public TeacherDisciplinePage()
        {
            InitializeComponent();
            LoadTeachers();
        }

        private void LoadTeachers()
        {
            using (var dbContext = new Uhebnia_Praktika_321Entities1())
            {
                // Получаем список сотрудников, которые являются преподавателями
                var teachers = dbContext.Sotrudnik
                    .Where(s => s.Doljnost.Contains("преподаватель")) // Фильтруем по должности
                    .ToList();

                TeacherComboBox.ItemsSource = teachers;
                TeacherComboBox.DisplayMemberPath = "Familia"; // Отображаем фамилии сотрудников
            }
        }

        private void OnTeacherSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TeacherComboBox.SelectedItem is Sotrudnik selectedTeacher)
            {
                // Загружаем дисциплины для выбранного преподавателя
                using (var dbContext = new Uhebnia_Praktika_321Entities1())
                {
                    var disciplines = dbContext.Disciplina
                        .Where(d => d.Ispolnitel == selectedTeacher.Tab_Number_Sot.ToString()) // Связываем через Tab_Number
                        .Select(d => new { d.Nazvanie, d.Obyom })
                        .ToList();

                    DisciplineDataGrid.ItemsSource = disciplines;
                }
            }
        }
    }
}
