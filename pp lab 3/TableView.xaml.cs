using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace pp_lab_3
{
    /// <summary>
    /// Логика взаимодействия для TableView.xaml
    /// </summary>
    public partial class TableView : Window
    {
        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataSet sDs;
        DataTable sTable;
        string table;
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\PP Lab 2.mdf"";Integrated Security=True";

        public TableView(string table)
        {
            InitializeComponent();

            this.table = table;

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;

            GetData();

            foreach (DataColumn dc in sTable.Columns)
            {
                columns.Items.Add(dc.ColumnName);
            }
            columns.SelectedIndex = 0;
        }

        void GetData()
        {
            string sql = $"SELECT * FROM {table}";
            SqlConnection connection = new SqlConnection(cs);
            connection.Open();
            sCommand = new SqlCommand(sql, connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, table);
            sTable = sDs.Tables[table];
            connection.Close();
            dataGridView1.ItemsSource = sDs.Tables[table].DefaultView;
            sDs.Tables[table].DefaultView.AllowDelete = true;
            sDs.Tables[table].DefaultView.AllowEdit = true;
            sDs.Tables[table].DefaultView.AllowNew = true;
            dataGridView1.SelectionMode = DataGridSelectionMode.Single;
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            GetData();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sAdapter.Update(sDs, table);
                GetData();
                MessageBox.Show("Сохранено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);

                MessageBox.Show("Произошла ошибка! Наведите на красный круг для получения информации, либо нажмите на 🔄 для возвращения таблицы в актуальный вид");
            }
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            string colName = columns.SelectedItem.ToString();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле \"Значение\" не должно быть пустым!");
                return;
            }

            Result res = new Result(table, sTable.Columns[colName], textBox1.Text);
            try
            {
                res.Show();
            }
            catch (ObjectDisposedException)
            {
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedItems.Count > 0)
                {
                    int index = dataGridView1.SelectedIndex;
                    sDs.Tables[table].DefaultView.Delete(index);
                    //sDs.Tables[table].DefaultView.Table.Rows.RemoveAt(index);
                    //dataGridView1.Items.RemoveAt(index);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void columns_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            string colName = columns.SelectedItem.ToString();
            if (sTable.Columns[colName].DataType.Name == "DateTime")
                textBox1.Text = "ГОД/МЕСЯЦ/ДЕНЬ";
        }
    }
}
