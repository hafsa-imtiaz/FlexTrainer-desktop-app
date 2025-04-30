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
    public partial class Khana : Form
    {
        string connectionString;
        public Khana(string connection)
        {
            InitializeComponent();
            connectionString = connection;
            allergeninput.Text = string.Empty;
            allergeninput.Visible = false;
            pictureBox2.Visible = false;

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Description, Calories, Fibre, Fat, Proteins, MealID Carbs FROM Meal", connect);
                DataTable mealTable = new DataTable();
                adapter.Fill(mealTable);
                mealtable.DataSource = mealTable;
                connect.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void infotable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            name.Text = descrip.Text = fats.Text = carbs.Text = fibre.Text = proteins.Text = calories.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(descrip.Text) || string.IsNullOrEmpty(fats.Text) || string.IsNullOrEmpty(carbs.Text) || string.IsNullOrEmpty(fibre.Text) || string.IsNullOrEmpty(proteins.Text) || string.IsNullOrEmpty(calories.Text))
            {
                MessageBox.Show("Fill all fields!");
            }
            else
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT count(*) FROM MEAL WHERE NAME = '" + name.Text + "';";
                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if((int)cmd.ExecuteScalar() == 0)
                        {
                            query = query = "INSERT INTO Meal (Name, Description, Fat, Carbs, Proteins, Fibre, Calories) " +
                               "VALUES (@MealName, @Description, @Fat, @Carbs, @Proteins, @Fibre, @Calories)";
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@MealName", name.Text);
                            cmd.Parameters.AddWithValue("@Description", descrip.Text);
                            cmd.Parameters.AddWithValue("@Fat", fats.Text);
                            cmd.Parameters.AddWithValue("@Carbs", carbs.Text);
                            cmd.Parameters.AddWithValue("@Proteins", proteins.Text);
                            cmd.Parameters.AddWithValue("@Fibre", fibre.Text);
                            cmd.Parameters.AddWithValue("@Calories", calories.Text);
                            if ((int) cmd.ExecuteNonQuery() == 0){
                                MessageBox.Show("Meal could nto be added.");
                            }
                            else
                            {
                                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Description, Calories, Fibre, Fat, Proteins, MealID Carbs FROM Meal", conn);
                                DataTable mealTable = new DataTable();
                                adapter.Fill(mealTable);
                                mealtable.DataSource = mealTable;

                                query = "SELECT max(MealID) FROM MEAL";
                                cmd.CommandText= query; 
                                string mealid = (cmd.ExecuteScalar()).ToString();

                                foreach (var allergen in allergies.Items)
                                {
                                    string allergenName = allergen.ToString();
                                    using (SqlConnection connection = new SqlConnection(connectionString))
                                    {
                                        connection.Open();
                                        string insertAllergenQuery = "INSERT INTO Meal_Allergens (MealID, AllergenName) VALUES (@MealID, @AllergenName)";
                                        using (SqlCommand command = new SqlCommand(insertAllergenQuery, connection))
                                        {
                                            command.Parameters.AddWithValue("@MealID", mealid);
                                            command.Parameters.AddWithValue("@AllergenName", allergenName);
                                            command.ExecuteNonQuery();
                                        }
                                    }
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Meal already exists!");
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void addday_Click(object sender, EventArgs e)
        {
            allergeninput.Visible = true;
            allergeninput.Text = string.Empty;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            allergies.Items.Add(allergeninput.Text);
            allergeninput.Text = string.Empty;
            allergeninput.Visible=false;
            pictureBox2.Visible=false;
        }

        private void toppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if(name.Text.Length > 0) { namelabel.Visible = false; }
            else namelabel.Visible = true;
        }

        private void descrip_TextChanged(object sender, EventArgs e)
        {
            if(descrip.Text.Length > 0) { desclabel.Visible = false; } else desclabel.Visible = true;
        }

        private void namelabel_Click(object sender, EventArgs e)
        {
            name.Focus();
        }

        private void desclabel_Click(object sender, EventArgs e)
        {
            descrip.Focus();
        }
    }
}
