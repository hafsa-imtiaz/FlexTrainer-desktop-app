using System;
using System.Collections;
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
    public partial class AddMeal : Form
    {
        int planid;
        int din;
        string connectionString;
        int doneselected;
        int addselect;
        int totalcalories;
        int daily;
        public AddMeal(int id, int din, string connectionString, int d)
        {
            InitializeComponent();
            this.planid = id;
            this.din = din;
            this.dayno.Text = "Day " + din.ToString();
            this.connectionString = connectionString;
            doneselected = -1;
            addselect = -1;
            chosenid.Visible = false;
            totalcalories = 0;
            daily = d;
            calories.Text = "Total Calories: " + totalcalories.ToString();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Description, Calories, Fibre, Fat, Proteins, Carbs, MealID FROM Meal", connect);
                DataTable mealTable = new DataTable();
                adapter.Fill(mealTable);
                mealtable.DataSource = mealTable;

                SqlDataAdapter moreinfo = new SqlDataAdapter("SELECT Day, Meal.Name FROM Diet_Meal INNER JOIN MEAL ON MEAL.MEALID = DIET_MEAL.MEALID WHERE DAY = '" + din + "' AND DPLANID = '" + planid + "';", connect);
                DataTable mymeal = new DataTable();
                moreinfo.Fill(mymeal);
                urfoodtable.DataSource = mymeal;

                string query = "SELECT PlanName FROM DIETPLAN WHERE DPlanID = '" + planid + "';";
                using (SqlCommand pls = new SqlCommand(@query, connect))
                {
                    name.Text = (pls.ExecuteScalar()).ToString();
                }
                connect.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            doneselected = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doneselected = -1;
            addselect = -1;
        }

        private void infotable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addselect = e.RowIndex;
            if (addselect >= 0 && addselect < mealtable.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow chosenrow = mealtable.Rows[addselect];
                descrip.Text = Convert.ToString(chosenrow.Cells["Description"].Value);
                fats.Text = Convert.ToString(chosenrow.Cells["Fat"].Value);
                fibre.Text = Convert.ToString(chosenrow.Cells["Fibre"].Value);
                carbs.Text = Convert.ToString(chosenrow.Cells["Carbs"].Value);
                proteins.Text = Convert.ToString(chosenrow.Cells["Proteins"].Value);
                calories.Text = Convert.ToString(chosenrow.Cells["Calories"].Value);
                chosenid.Text = Convert.ToString(chosenrow.Cells["MealID"].Value);
                mealname.Text = Convert.ToString(chosenrow.Cells["Name"].Value);

                using (SqlConnection rabta = new SqlConnection(connectionString))
                {
                    rabta.Open();
                    SqlCommand plswork = new SqlCommand("SELECT AllergenName FROM Meal_Allergens WHERE MealID = @MealID", rabta);
                    plswork.Parameters.AddWithValue("@MealID", chosenid.Text);
                    SqlDataReader reader = plswork.ExecuteReader();
                    allergies.Items.Clear();
                    while (reader.Read())
                    {
                        string allergenName = reader.GetString(0);
                        allergies.Items.Add(allergenName);
                    }
                    reader.Close();
                    rabta.Close();
                }

            }
            else
            {
                descrip.Text = string.Empty;
                fibre.Text = string.Empty;
                carbs.Text = string.Empty;
                proteins.Text = string.Empty;
                calories.Text = string.Empty;
                fats.Text = string.Empty;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(addselect < 0)
            {
                MessageBox.Show("No meal selected!");
            }
            else if (mealtype.SelectedIndex < 0)
            {
                MessageBox.Show("Select your meal type!");

            }
            else
            {
                using (SqlConnection rabta = new SqlConnection(connectionString))
                {
                    rabta.Open();
                    string query = @"SELECT COUNT(*) FROM Diet_Meal " +
                                    "WHERE DPlanID = @PlanID AND Day = @Day AND MealID = @khana;";
                    using (SqlCommand pls = new SqlCommand(query, rabta))
                    {
                        pls.Parameters.AddWithValue("@PlanID", planid);
                        pls.Parameters.AddWithValue("@Day", din);
                        pls.Parameters.AddWithValue("@khana", chosenid.Text);

                        if ((int)pls.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Meal already exists for this day.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            query = @"INSERT INTO Diet_Meal (DPlanID, Day, MealID, MealType) 
                                 VALUES (@DPlanID, @Day, @MealID, @MealType)"; 
                            pls.CommandText = query;
                            pls.Parameters.AddWithValue("@DPlanID", planid);
                            pls.Parameters.AddWithValue("@Din", din);
                            pls.Parameters.AddWithValue("@MealID", chosenid.Text);
                            pls.Parameters.AddWithValue("@MealType", mealtype.SelectedItem.ToString());
                            if ((int)pls.ExecuteNonQuery() > 0)
                            {
                                addselect = -1;
                                doneselected = -1;
                                MessageBox.Show("Meal Added!");
                                refresh();
                            }
                            else
                            {
                                MessageBox.Show("This meal could not be added.");
                            }
                        }
                    }
                    rabta.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (doneselected >= 0 && doneselected < urfoodtable.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow chosenrow = mealtable.Rows[doneselected];
                string naam = Convert.ToString(chosenrow.Cells["Name"].Value);
                int mealid = -1;
                using (SqlConnection rabta = new SqlConnection(connectionString))
                {
                    rabta.Open();
                    string query = "SELECT dm.MealID FROM Diet_Meal dm INNER JOIN Meal m ON dm.MealID = m.MealID WHERE m.Name = '" + naam + "' AND dm.DAY = '" + din.ToString() + "' AND dm.DPlanID = " + planid.ToString() + ";";
                    using(SqlCommand pls = new SqlCommand(query, rabta))
                    {
                        mealid = (int)pls.ExecuteScalar();
                        if(mealid == -1)
                        {
                            MessageBox.Show("Meal could not be deleted!");
                        }
                        else
                        {
                            query = "DELETE FROM Diet_Meal WHERE DPlanID = '" + planid + "' AND DAY = '" + din + "' AND MealID = '" + mealid + "';";
                            pls.CommandText = query;
                            if ((int)pls.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Meal Removed Succesffully!");
                                refresh();
                            }
                            else
                            {
                                MessageBox.Show("Meal could not be deleted!");
                            }
                        }
                    }
                    rabta.Close(); 
                }
            }
            else
            {
                doneselected = addselect = -1;
                MessageBox.Show("No meal selected!");
            }
        }

        public void refresh()
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter moreinfo = new SqlDataAdapter("SELECT Day, Meal.Name FROM Diet_Meal INNER JOIN MEAL ON MEAL.MEALID = DIET_MEAL.MEALID WHERE DAY = '" + din + "' AND DPLANID = '" + planid + "';", conn);
                DataTable mymeal = new DataTable();
                moreinfo.Fill(mymeal);
                urfoodtable.DataSource = mymeal;

                string query = "SELECT SUM(m.Calories) AS TotalCalories FROM Diet_Meal dm JOIN Meal m ON dm.MealID = m.MealID WHERE  dm.DPlanID = '" + planid + "' AND dm.Day = '" + din + "' GROUP BY dm.DPlanID, dm.Day;";
                SqlCommand pls = new SqlCommand(query, conn);
                pls.CommandText = query;
                int ans = Convert.ToInt32(pls.ExecuteScalar());

                if (ans > 0)
                {
                    query = "SELECT Calorie_Intake FROM DietPlan WHERE DPlanID = '" + planid + "';";
                    pls.CommandText = query;
                    int maxi = Convert.ToInt32(pls.ExecuteScalar());

                    calories.Text = "Total Calories: " + ans;
                    if (ans > maxi)
                    {
                        MessageBox.Show("You have reached your daily calorie limit!");
                    }
                }

                conn.Close();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Khana(connectionString).Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("", "Are you sure you wish to leave?",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form is MemberDiet4)
                    {
                        form.Enabled = true;
                        break;
                    }
                }
                this.Hide();
            }
        }
    }
}
