using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Data.Common;
using System.Reflection;
using System.Security.Cryptography;
using HopitalSystem.BussinessLayer;
using HopitalSystem.DataBaseLayer;
using System.Numerics;

namespace HopitalSystem
{
    public partial class dashBoard : Form
    {
        public int Id;
        public dashBoard()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            PanelUpdate.Visible = false;
            lbl1.ForeColor = Color.Black;
            lbl2.ForeColor = Color.Black;
            lbl3.ForeColor = Color.Black;
            lbl4.ForeColor = Color.Red;
            lbl5.ForeColor = Color.Black;
            lbl6.ForeColor = Color.Black;
            lbl7.ForeColor = Color.Black;
            DeleteRecord n = new DeleteRecord();
            n.Show();
            this.Hide();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {

            lbl1.ForeColor = Color.Black;
            lbl2.ForeColor = Color.Black;
            lbl3.ForeColor = Color.Black;
            lbl4.ForeColor = Color.Black;
            lbl5.ForeColor = Color.Red;
            lbl6.ForeColor = Color.Black;
            lbl7.ForeColor = Color.Black;
            this.Hide();
            View v = new View();
            v.Show();


        }

        private void btn_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.Show();
            this.Hide();
            lbl1.ForeColor = Color.Black;
            lbl2.ForeColor = Color.Black;
            lbl3.ForeColor = Color.Black;
            lbl4.ForeColor = Color.Black;
            lbl5.ForeColor = Color.Black;
            lbl6.ForeColor = Color.Red;
            lbl7.ForeColor = Color.Black;
        }

        private void btnhospital_Click(object sender, EventArgs e)
        {
            History h = new History();
            h.Show();
            this.Hide();
            lbl1.ForeColor = Color.Black;
            lbl2.ForeColor = Color.Black;
            lbl3.ForeColor = Color.Black;
            lbl4.ForeColor = Color.Black;
            lbl5.ForeColor = Color.Black;
            lbl6.ForeColor = Color.Black;
            lbl7.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dashBoard_Load(object sender, EventArgs e)
        {
            PanelUpdate.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            PanelUpdate.Visible = false;

            SqlDataReader reader = Connection.GetPIDs();

            while (reader.Read())
            {
                cmbID.Items.Add(reader[0]);
                cmboDiagnose.Items.Add(reader[0]);
                ComboPatientID.Items.Add(reader[0]);
            }


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtName.Text;
                string Address = txtAdress.Text;
                string Disease = txtIssue.Text;
                string cntct = txtContact.Text;
                BigInteger Contact = Convert.ToInt64(txtContact.Text);
                int Age = Convert.ToInt32(txtAge.Text);
                string Gender = cmboGender.Text;

                string Blood = txtBlood.Text;

                Patient p = new Patient(Name, Address, Contact, Age, Gender, Blood, Disease);
                if (cntct.Length < 10)
                {
                    MessageBox.Show("Length should be of 11 digits!");
                    txtContact.Clear();
                }
                else if (txtName.Text == "")
                {
                    MessageBox.Show("Name of the Patient is required!");
                    txtName.Focus();
                }
                else if (txtBlood.Text == "")
                {
                    MessageBox.Show("Blood group is required");
                    txtBlood.Focus();
                }
                else if (txtAge.Text == "")
                {
                    MessageBox.Show("Age of the Patient is required!");
                    txtAge.Focus();
                }
                else if (txtAdress.Text == "")
                {
                    MessageBox.Show("Address of the Patient is required!");
                    txtAdress.Focus();
                }
                else if (txtIssue.Text == "")
                {
                    MessageBox.Show("Major Disease Like is the Patient is of Heart Patient Required!");
                    txtIssue.Focus();
                }
                else if (cmboGender.SelectedItem == null)
                {
                    MessageBox.Show("Gender Type of the Patient is required!");
                    cmboGender.Focus();
                }

                else
                {
                    Connection.InsertPatientData(p);
                    MessageBox.Show("Data Saved Successfully");
                    txtName.Clear();
                    txtIssue.Clear();

                    txtContact.Clear();
                    txtBlood.Clear();
                    txtAge.Clear();
                    cmboGender.ResetText();
                    txtAdress.Clear();
                }

            }
            catch
            {

                throw;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbID_TextChanged(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(cmbID.SelectedItem);
            SqlConnection n = Connection.GetConnection();
            string Query = "Select * From Patient where PID=" + Id + "";
            SqlCommand cmd = new SqlCommand(Query, n);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(cmbID.Text);
                string Sysmptoms = txtSymptoms.Text;
                string WardRequirement = cmbRequired.Text;
                string WardType = cmbWardType.Text;
                string Medicine = txtMedicine.Text;
                string Diagnose = txtDiagnose.Text;
                Patient p = new Patient(pid, Sysmptoms, Medicine, WardRequirement, WardType);
                Connection.InsertDiagnose(p);
                MessageBox.Show("Data is Saved Successfully");
                txtDiagnose.Clear();
                txtMedicine.Clear();
                cmbID.ResetText();
                cmbWardType.ResetText();
                cmbRequired.ResetText();
                txtSymptoms.ResetText();
                cmbDoctor.ResetText();
            }
            catch (Exception)
            {
                MessageBox.Show("Any Field is null or invalid requirements");
            }

        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection n = Connection.GetConnection();

                if (int.TryParse(ComboPatientID.SelectedItem?.ToString(), out int patientID))
                {
                    string Query = "update Patient SET Name='" + txtUpName.Text + "', P_Adress='" + txtUpAdress.Text + "', Contact='" + txtUpcontact.Text + "', Age='" + txtUpAge.Text + "', Gender='" + cmboUpgender.SelectedItem?.ToString() + "', Blood_Group='" + txtUpBlood.Text + "', Disease='" + txtUpDisease.Text + "' where PID ='" + patientID + "'";

                    SqlCommand cmd = new SqlCommand(Query, n);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Updated!");

                    txtUpName.Clear();
                    txtUpAdress.Clear();
                    txtUpAge.Clear();
                    txtUpcontact.Clear();
                    txtUpBlood.Clear();
                    txtUpDisease.Clear();
                    ComboPatientID.ResetText();
                    cmboUpgender.ResetText();

                    n.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Patient ID selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!! Could Not update!!\n" + ex.Message);
            }
        }

        private void ComboPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(ComboPatientID.SelectedItem);
                SqlConnection n = Connection.GetConnection();
                MessageBox.Show("You are connected");
                string Query = "Select Name, P_Adress, Contact, Age, Gender, Blood_Group, Disease FROM Patient WHERE PID = @Id";
                SqlCommand cmd = new SqlCommand(Query, n);
                cmd.Parameters.AddWithValue("@Id", Id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtUpName.Text = reader["Name"].ToString();
                    txtUpAdress.Text = reader["P_Adress"].ToString();
                    txtUpcontact.Text = reader["Contact"].ToString();
                    txtUpAge.Text = reader["Age"].ToString();
                    cmboUpgender.Text = reader["Gender"].ToString();
                    txtUpBlood.Text = reader["Blood_Group"].ToString();
                    txtUpDisease.Text = reader["Disease"].ToString();
                }
                else
                {
                    MessageBox.Show("Reader is unable to read");
                }

                reader.Close();
                n.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ComboPatientID_TextChanged(object sender, EventArgs e)
        {


        }

        private void cmboDiagnose_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(cmboDiagnose.SelectedItem);
            SqlConnection n = Connection.GetConnection();
            string Query = "Select Symptoms,Medicines,Ward,Ward_Type From Diagnose where PID=" + Id + "";
            SqlCommand cmd = new SqlCommand(Query, n);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtUpSymptoms.Text = reader[0].ToString();
                txtUpMedicine.Text = reader[1].ToString();
                cmboUpwardRequired.Text = reader[2].ToString();
                cmboUpwardType.Text = reader[3].ToString();
            }
            reader.Close();
            
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SqlConnection n = Connection.GetConnection();
        //        //Id = Convert.ToInt32(cmboDiagnose.SelectedItem);
        //        string Query = "update Diagnose SET Symptoms='" + txtUpSymptoms.Text + "', Medicines='" + txtUpMedicine.Text + "', Ward='" + cmboUpwardRequired.SelectedItem + "', Ward_Type='" + cmboUpwardType.SelectedItem + "' ";
        //        SqlCommand cmd = new SqlCommand(Query, n);
        //        cmd.ExecuteNonQuery();
        //        n.Close();
        //        MessageBox.Show("Successfully Updated!");
        //        txtUpSymptoms.Clear();
        //        txtUpMedicine.Clear();
        //        cmboUpwardRequired.ResetText();
        //        cmboDiagnose.ResetText();
        //        cmboUpwardType.ResetText();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Oops!! Could Not update!!\n" + ex.Message);
        //    }

        //}
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection n = Connection.GetConnection();

                if (int.TryParse(cmboDiagnose.SelectedItem?.ToString(), out int diagnoseID))
                {
                    string Query = "update Diagnose SET Symptoms=@Symptoms, Medicines=@Medicines, Ward=@Ward, Ward_Type=@Ward_Type WHERE PID=@DiagnoseID";

                    SqlCommand cmd = new SqlCommand(Query, n);

                    // Use parameters to avoid conversion issues
                    cmd.Parameters.AddWithValue("@Symptoms", txtUpSymptoms.Text);
                    cmd.Parameters.AddWithValue("@Medicines", txtUpMedicine.Text);
                    cmd.Parameters.AddWithValue("@Ward", cmboUpwardRequired.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@Ward_Type", cmboUpwardType.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@DiagnoseID", diagnoseID);

                    cmd.ExecuteNonQuery();
                    n.Close();
                    MessageBox.Show("Successfully Updated!");

                    txtUpSymptoms.Clear();
                    txtUpMedicine.Clear();
                    cmboUpwardRequired.ResetText();
                    cmboDiagnose.ResetText();
                    cmboUpwardType.ResetText();
                }
                else
                {
                    MessageBox.Show("Invalid Diagnose ID selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!! Could Not update!!\n" + ex.Message);
            }
        }

        private void PanelUpdate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonUpdate_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnAddPatientClick(object sender, EventArgs e)
        {

           

            panel1.Visible = true;
            panel2.Visible = false;
            PanelUpdate.Visible = false;

            lbl1.ForeColor = Color.Red;
            lbl2.ForeColor = Color.Black;
            lbl3.ForeColor = Color.Black;
            lbl4.ForeColor = Color.Black;
            lbl5.ForeColor = Color.Black;
            lbl6.ForeColor = Color.Black;
            lbl7.ForeColor = Color.Black;
        }

        private void btnDiagnoseClick(object sender, EventArgs e)
        {

         

            panel1.Visible = false;
            panel2.Visible = true;
            PanelUpdate.Visible = false;

            lbl1.ForeColor = Color.Black;
            lbl2.ForeColor = Color.Red;
            lbl3.ForeColor = Color.Black;
            lbl4.ForeColor = Color.Black;
            lbl5.ForeColor = Color.Black;
            lbl6.ForeColor = Color.Black;
            lbl7.ForeColor = Color.Black;
        }

        private void btnUpdatePatientClick(object sender, EventArgs e)
        {

            

            panel1.Visible = false;
            panel2.Visible = false;
            PanelUpdate.Visible = true;

            lbl1.ForeColor = Color.Black;
            lbl2.ForeColor = Color.Black;
            lbl3.ForeColor = Color.Red;
            lbl4.ForeColor = Color.Black;
            lbl5.ForeColor = Color.Black;
            lbl6.ForeColor = Color.Black;
            lbl7.ForeColor = Color.Black;
        }
    }
}
