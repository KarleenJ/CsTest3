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

namespace CTest3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public class Student
        {
            public int id;
            public string fname;
            public string lname;
            public Boolean isRegistered;

        }

        public static List<Student> StudList;
        Student stud = new Student();


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //had trouble converting to string
            stud.fname = tbFName.Text;
            stud.lname = tbFName.Text;

            StudList.Add(stud);

            MessageBox.Show($"{StudList.Count} Students Added");

        }

        private int ToString(string text)
        {
            throw new NotImplementedException();
        }

        private void chkbox_Checked(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
