using BAL;
using entities;
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

namespace SchoolApp
{
    /// <summary>
    /// Interaction logic for TeachersWindow.xaml
    /// </summary>
    public partial class TeachersWindow : Window
    {
        IEnumerable<Teacher> teachers;

        public TeachersWindow()
        {
            InitializeComponent();
            DataContext = this;
            var bal = new functions();
            var all = bal.readAllTeachers();

            teachers = all.ToList();
            grid.ItemsSource = teachers;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        //public List<Teacher> Teachers { get; set; }
    }
}
