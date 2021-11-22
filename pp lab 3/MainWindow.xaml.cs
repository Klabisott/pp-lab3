using System;
using System.Collections.Generic;
using System.Data;
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
using pp_lab_3.PP_Lab_2DataSetTableAdapters;
using System.Xml.Schema;

namespace pp_lab_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="|DataDirectory|\PP Lab 2 (2).mdf";Integrated Security=True
        private void startup(object sender, EventArgs e)
        {
            listBox.Items.Add("Cars");
            listBox.Items.Add("Driver");
            listBox.Items.Add("Schedule");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TableView tv = new TableView(listBox.SelectedItem.ToString());
            tv.Show();
        }
    }
}
