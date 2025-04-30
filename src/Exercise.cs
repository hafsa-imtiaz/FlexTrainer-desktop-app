using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class Exercise : Form
    {
        string connectionString;
        public Exercise(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;

            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            string query = "SELECT ExerciseName, EDescrip, Difficulty, TargetMuscle, MachineName FROM Exercise;";
            SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
            DataTable userdata = new DataTable();
            userTable.Fill(userdata);
            infotable.DataSource = userdata;

            query = "SELECT MachineName FROM Exercise";
            using (SqlCommand command = new SqlCommand(query, connect))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    machine.Items.Add(reader["MachineName"].ToString());
                }
                reader.Close();
            }

            connect.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void namelabel_Click(object sender, EventArgs e)
        {
            name.Focus();
        }

        private void desclabel_Click(object sender, EventArgs e)
        {
            descrip.Focus();
        }

        private void musclabel_Click(object sender, EventArgs e)
        {
            muscle.Focus();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if(name.Text != "") { namelabel.Visible = false; }
            else { namelabel.Visible = true; }
        }

        private void descrip_TextChanged(object sender, EventArgs e)
        {
            if(descrip.Text != "") desclabel.Visible = false;
            else desclabel.Visible = true;
        }

        private void muscle_TextChanged(object sender, EventArgs e)
        {
            if(muscle.Text != "") musclabel.Visible = false;
            else musclabel.Visible = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            name.Text = "";
            descrip.Text = "";
            muscle.Text = "";
            machine.SelectedIndex = -1;
            diffi.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(descrip.Text) || string.IsNullOrWhiteSpace(muscle.Text) || diffi.SelectedIndex == -1 || machine.SelectedIndex == -1) {
                MessageBox.Show("All fields must be filled!", "Input Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string query = "INSERT INTO Exercise (ExerciseName, EDescrip, Difficulty, MachineName, TargetMuscle) " +
                                   "VALUES (@ExerciseName, @Description, @Difficulty, @MachineName, @TargetMuscle)";

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@ExerciseName", name.Text);
                        command.Parameters.AddWithValue("@Description", descrip.Text);
                        command.Parameters.AddWithValue("@Difficulty", diffi.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@MachineName", machine.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@TargetMuscle", muscle.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Exercise added successfully.");
                            name.Text = "";
                            descrip.Text = "";
                            muscle.Text = "";
                            machine.SelectedIndex = -1;
                            diffi.SelectedIndex = -1;
                            
                            query = "SELECT ExerciseName, EDescrip, Difficulty, TargetMuscle, MachineName FROM Exercise;";
                            SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
                            DataTable userdata = new DataTable();
                            userTable.Fill(userdata);
                            infotable.DataSource = userdata;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add exercise.");
                        }
                    }
                }
            }
        }

        private void infotable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
