using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADO.NET_Disconnected_Mode
{
    public partial class Form1 : Form
    {
        DataSet? dataSet = null;
        SqlConnection? connection = null;
        SqlDataAdapter? adapter = null;
        SqlCommand? cmd = null;
        SqlDataReader? reader = null;


        public Form1()
        {
            InitializeComponent();
            string conStr = "Data Source=DESKTOP-KOTE4M2\\SQLEXPRESS02;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            connection = new SqlConnection(conStr);
            ReadAuthorsData("Select * From Authors");
        }


        public void ReadAuthorsData(string query)
        {
            try
            {
                dataSet = new DataSet();
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables["table"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // SqlCommandBuilder
        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommandBuilder(adapter).GetInsertCommand();
                adapter.Update(dataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // RawSql
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Id"].Value != null)
                    {
                        int id = Convert.ToInt32(row.Cells["Id"].Value);

                        string firstn = row.Cells["FirstName"].Value.ToString();
                        string lastn = row.Cells["LastName"].Value.ToString();

                        string updateQuery = "UPDATE Authors SET FirstName = @firstn, LastName = @lastn WHERE Id = @id";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@firstn", firstn);
                            command.Parameters.AddWithValue("@lastn", lastn);
                            command.Parameters.AddWithValue("@id", id);
                            command.ExecuteNonQuery();
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        // StoredProcedure
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("usp_deleteAuthor", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@AuthorId", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value));


                command.ExecuteNonQuery();
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                adapter.DeleteCommand = command;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ReadAuthorsData($"Select * From Authors WHERE FirstName='{SearchTextBox.Text}'");
        }
    }
}