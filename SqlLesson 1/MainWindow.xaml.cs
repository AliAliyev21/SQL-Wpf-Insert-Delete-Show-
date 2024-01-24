using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SqlLesson_1
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

       
        private void showall_Click(object sender, RoutedEventArgs e)
        {
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataReader reader = null;
                var query = "SELECT * FROM Authors";

                using (var command = new SqlCommand(query, con))
                {
                    reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    myDataGrid.ItemsSource = dataTable.DefaultView;
                }
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            string deleteId = id.Text;

            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                var query = "DELETE FROM Authors WHERE Id = @id";

                using (var command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", deleteId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Deleted successfully");
                        showall_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No Deleted");
                    }
                }
            }
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            string newId = id.Text;
            string newFirstName = firstName.Text;
            string newLastName = lastName.Text;

            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                var query = "INSERT INTO Authors (Id, FirstName, LastName) VALUES (@id, @firstName, @lastName)";

                using (var command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", newId);
                    command.Parameters.AddWithValue("@firstName", newFirstName);
                    command.Parameters.AddWithValue("@lastName", newLastName);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Inserted successfully");
                        showall_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No Inserted.Check your data");
                    }
                }
            }
        } 
    }
}
