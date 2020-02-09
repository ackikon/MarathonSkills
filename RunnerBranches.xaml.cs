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
    /// Логика взаимодействия для RunnerBranches.xaml
    /// </summary>
    public partial class RunnerBranches : Window
    {
        public RunnerBranches()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void TransToRunnerReg_Click(object sender, RoutedEventArgs e)
        {
            NewRunnerRegistrationForm newRunnerRegistrationFormExample = new NewRunnerRegistrationForm();
            newRunnerRegistrationFormExample.Owner = this;
            this.Hide();
            newRunnerRegistrationFormExample.ShowDialog();
          //  this.Show();

        }

       private void exit_Click(object sender, RoutedEventArgs e)
       {
            this.Close();
            this.Owner.Show();
        }
    }
}
