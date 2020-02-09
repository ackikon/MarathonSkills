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

namespace WPF_3._0
{
    /// <summary>
    /// Логика взаимодействия для NewRunnerRegistrationForm.xaml
    /// </summary>
    public partial class NewRunnerRegistrationForm : Window
    {
        Entities Context = new Entities();
        public NewRunnerRegistrationForm()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();   
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.Show();
        }



        // Show(); показывает окно и не блокирует предыдущее
        // ShowDialog() Показывает окно и запрещает использование предыдущей формы
        // Application.Current.ShutDown();
        // Правка Шаблона - Правка копии - Копируем появившийся блок в app.xaml
        // dGrid.ItemsSource = context.НазваниеТаблицы.ToList();
        // dGrid.ItemsSource = context.НазваниеТаблицы.Select(i => i.НазваниеСтолбца).ToList();
    }
}
