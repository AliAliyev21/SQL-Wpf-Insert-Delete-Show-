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
        public class Author
        {
            public string Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

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
                var query = "SELECT * FROM Authors";

                using (var command = new SqlCommand(query, con))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    List<Author> authorsList = new List<Author>();
                    while (reader.Read())
                    {
                        Author author = new Author
                        {
                            Id = reader["Id"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString()
                        };
                        authorsList.Add(author);
                    }
                    myDataGrid.ItemsSource = authorsList;
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
