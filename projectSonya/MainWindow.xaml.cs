using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace projectSonya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nameconnection = "Data Source=GK216_4\\SQLEXPRESS;Initial Catalog=Sonya;Integrated Security=True";

        List<string> name = new List<string>();
        List<string> number = new List<string>();
        List<string> type = new List<string>();
        List<string> price = new List<string>();
        List<string> location = new List<string>();
        List<string> all = new List<string>();

        private string oldName;

        public MainWindow()
        {
            InitializeComponent();
            Hidden();
            ViewData();

            SortBox.Items.Add("ФИО");
            SortBox.Items.Add("Инвертарный номер");
            SortBox.Items.Add("Тип оборудования");
            SortBox.Items.Add("Стоимость обрудование");
            SortBox.Items.Add("Место расположения");

            this.ResizeMode = ResizeMode.NoResize;
        }

        private void Hidden()
        {
            SortGrid.Visibility = Visibility.Hidden;
            SereachGrid.Visibility = Visibility.Hidden; 
            AddGrid.Visibility = Visibility.Hidden; 
            ToolsGrid.Visibility = Visibility.Hidden;
            EditGrid.Visibility = Visibility.Hidden;
            EditFormGrid.Visibility = Visibility.Hidden;
            BtnExit.Visibility = Visibility.Hidden;
        }

        private void ViewData()
        {
            string query = "SELECT name, number, type, price, location FROM dbo.Info";

            using (SqlConnection connection = new SqlConnection(nameconnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    all.Add(reader["name"].ToString());
                    all.Add(reader["number"].ToString());
                    all.Add(reader["type"].ToString());
                    all.Add(reader["price"].ToString());
                    all.Add(reader["location"].ToString());
                }
                connection.Close();

                foreach (object elements in all)
                {
                    DataBox.Items.Add(elements);
                }
            }
        }

        private void AddNewData(string name, string number, string type, string price, string location)
        {
            string query = "INSERT INTO dbo.Info (name, number, type, price, location) VALUES (@name, @number, @type, @price, @location)";

            using (SqlConnection connection = new SqlConnection(nameconnection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@number", number);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@location", location);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void BtnSort_Click(object sender, RoutedEventArgs e)
        {
            SortGrid.Visibility = Visibility.Visible;
            BtnExit.Visibility = Visibility.Visible;
        }

        private void BtnSereach_Click(object sender, RoutedEventArgs e)
        {
            SereachGrid.Visibility = Visibility.Visible;
            BtnExit.Visibility = Visibility.Visible;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddGrid.Visibility = Visibility.Visible;
            BtnExit.Visibility = Visibility.Visible;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Hidden();
        }

        private void SortBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SortBox.SelectedItem == null)
            {
                return;
            }

            string selected = SortBox.SelectedItem.ToString();

            switch (selected)
            {
                case "ФИО":
                    DataBox.Items.Clear();
                    name.Clear();
                    string queryName = "SELECT name FROM dbo.Info";

                    using (SqlConnection connection = new SqlConnection(nameconnection))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(queryName, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            name.Add(reader["name"].ToString());
                        }
                        connection.Close();
                    }

                    foreach (object names in name)
                    {
                        DataBox.Items.Add(names);
                    }

                    break;

                case "Инвертарный номер":
                    DataBox.Items.Clear();
                    number.Clear();
                    string queryNumber = "SELECT number FROM dbo.Info";

                    using (SqlConnection connection = new SqlConnection(nameconnection))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(queryNumber, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            number.Add(reader["number"].ToString());
                        }
                        connection.Close();
                    }

                    foreach (object numbers in number)
                    {
                        DataBox.Items.Add(numbers);
                    }

                    break;

                case "Тип оборудования":
                    DataBox.Items.Clear();
                    type.Clear();
                    string queryType = "SELECT type FROM dbo.Info";

                    using (SqlConnection connection = new SqlConnection(nameconnection))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(queryType, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            type.Add(reader["type"].ToString());
                        }
                        connection.Close();
                    }

                    foreach (object types in type)
                    {
                        DataBox.Items.Add(types);
                    }

                    break;

                case "Стоимость обрудование":
                    DataBox.Items.Clear();
                    price.Clear();
                    string queryPrice = "SELECT price FROM dbo.Info";

                    using (SqlConnection connection = new SqlConnection(nameconnection))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(queryPrice, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            price.Add(reader["price"].ToString());
                        }
                        connection.Close();
                    }

                    foreach (object prices in price)
                    {
                        DataBox.Items.Add(prices);
                    }

                    break;

                case "Место расположения":
                    DataBox.Items.Clear();
                    location.Clear();
                    string queryLocation = "SELECT location FROM dbo.Info";

                    using (SqlConnection connection = new SqlConnection(nameconnection))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(queryLocation, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            location.Add(reader["location"].ToString());
                        }
                        connection.Close();
                    }

                    foreach (object locations in location)
                    {
                        DataBox.Items.Add(locations);
                    }

                    break;
            }
        }

        private void SereachTxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            string searchText = SereachTxtBox.Text.ToLower();
            var filteredData = all.Where(d => d.ToLower().Contains(searchText)).ToList();
            ResultBox.ItemsSource = filteredData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            AddNewData(nameTxtBox.Text, numberTxtBox.Text, typeTxtBox.Text, priceTxtBox.Text, locationTxtBox.Text);
            Hidden();
        }

        private void BtnTool_Click(object sender, RoutedEventArgs e)
        {
            ToolsGrid.Visibility = Visibility.Visible;
            BtnExit.Visibility = Visibility.Visible;
            OpenInfoData();
        }

        private void OpenInfoData()
        {
            foreach (var item in all)
                ToolDataBox.Items.Add(item);
            foreach (var items in all)
                EditListBox.Items.Add(items);   
        }

        private void Restart()
        {
            string path = Process.GetCurrentProcess().MainModule.FileName;
            Process.Start(path);
            Application.Current.Shutdown();
        }

        private void ToolDataBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var choice = MessageBox.Show("Вы действительно хотите удалить?", "ВНИМАНИЕ",
       MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (choice == MessageBoxResult.Yes)
            {
                if (ToolDataBox.SelectedItem != null)
                {
                    string selectedItem = ToolDataBox.SelectedItem.ToString();
                    string[] parts = selectedItem.Split(',');
                    string nameToDelete = parts[0].Trim();
                    string query = "DELETE FROM dbo.Info WHERE name = @name";

                    using (SqlConnection connection = new SqlConnection(nameconnection))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("name", nameToDelete);
                            command.ExecuteNonQuery();

                            ToolDataBox.Items.Remove(ToolDataBox.SelectedItem);

                            Restart();
                        }
                    }
                }
            }

            else return;
        }

        private void EditListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            EditFormGrid.Visibility = Visibility.Visible;

            if (EditListBox.SelectedItem != null)
            {
                string selectedItem = EditListBox.SelectedItem.ToString();
                string query = "SELECT * FROM dbo.Info WHERE name = @name";

                using (SqlConnection connection = new SqlConnection(nameconnection))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", selectedItem);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        nameBox.Text = reader["name"].ToString();   
                        numberBox.Text = reader["number"].ToString();
                        typeBox.Text = reader["type"].ToString();   
                        priceBox.Text = reader["price"].ToString();
                        locationBox.Text = reader["location"].ToString();

                        oldName = nameBox.Text;
                    }

                    reader.Close();
                }
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

            EditGrid.Visibility = Visibility.Visible;
        }

        private void BtnSaveEdit_Click(object sender, RoutedEventArgs e)
        {
            string query = "UPDATE dbo.Info SET name=@name, number=@number, type=@type, price=@price, location=@location WHERE name=@oldname";

            using (SqlConnection connection = new SqlConnection(nameconnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", nameBox.Text);
                command.Parameters.AddWithValue("@number", numberBox.Text);
                command.Parameters.AddWithValue("@type", typeBox.Text);
                command.Parameters.AddWithValue("@price", priceBox.Text);
                command.Parameters.AddWithValue("@location", locationBox.Text);
                command.Parameters.AddWithValue("@oldname", oldName);

                connection.Open();
                command.ExecuteNonQuery();

                Restart();
            }
        }
    }
}
