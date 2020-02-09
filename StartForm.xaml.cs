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

namespace WPF_3._0
{
    /// <summary>
    /// Логика взаимодействия для StartForm.xaml
    /// </summary>
    public partial class StartForm : Window
    {
        public StartForm()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void TransToRunners_Click(object sender, RoutedEventArgs e)
        {
            RunnerBranches RunnerBranchesForm = new RunnerBranches();
            RunnerBranchesForm.Owner = this;
            this.Hide();
            RunnerBranchesForm.ShowDialog();
          //  this.Show();
        }
    }
}
