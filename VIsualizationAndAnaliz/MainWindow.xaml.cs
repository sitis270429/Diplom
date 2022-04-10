using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace VIsualizationAndAnaliz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> Students = new List<Student>();

        public MainWindow() {
            InitializeComponent();
        }

        private void FileUpload_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\Corp\Desktop\test";
            openFileDialog.Filter = "txt files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == true) {
                var lines = File.ReadAllLines(openFileDialog.FileName);
                for (int i = 1; i < lines.Length; i++) {
                    var cells = lines[i].Split(',');
                    var stud = new Student((cells[0] + " " + cells[1]), cells[2], Convert.ToDouble(cells[10].Trim('"') + "," + cells[11].Trim('"')));
                    Students.Add(stud);
                }
            }
            gridStudents.ItemsSource = Students;
            students.Focus();
        }

        private void Less50proc_Click(object sender, RoutedEventArgs e) {
            var studLess50 = new List<Student>();
            foreach (var student in Students) {
                if(student.Score <= 5.0) {
                    studLess50.Add(student);
                }
            }
            gridStudents.ItemsSource = studLess50;
        }

        private void AllStudents_Click(object sender, RoutedEventArgs e) {
            gridStudents.ItemsSource = Students;
        }


        private void IncorrectQuestions_Click(object sender, RoutedEventArgs e) {

        }
    }
}
