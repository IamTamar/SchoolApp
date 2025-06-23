using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using BAL;
using entities;


namespace SchoolApp
{
    /// <summary>  
    /// Interaction logic for StudentsWindow.xaml  
    /// </summary>  
    public partial class StudentsWindow : Window
    {
        IEnumerable<Student> students;
        IEnumerable<string> classes;
        public List<Student> Students { get; set; }  
        //public List<HomeroomTeacherOfClass> Classes { get; set; }

        public StudentsWindow()
        {
            InitializeComponent();
            DataContext = this;
            var bal = new functions();
            var allStudents = bal.readAllStudents();
            var allClasses = bal.readAllClasses();

            students = allStudents.ToList();
            classes = allClasses.ToList();  
            grid.ItemsSource = students;
            classesButton.ItemsSource = classes;    
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = "ALL";
            selected = classesButton.SelectedItem.ToString() != null ? classesButton.SelectedItem.ToString() : selected;
            var selectedStudents = selected=="ALL" ? students = from student in students select student :
            from student in students where student.Class == selected select student;
            grid.ItemsSource = selectedStudents;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }
    }
}
