using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HopitalSystem.BussinessLayer;
using HopitalSystem.DataBaseLayer;

namespace HopitalSystem
{
    public partial class DeleteRecord : Form
    {
        int id = 0;
        public DeleteRecord()
        {
            InitializeComponent();
        }

        private void DeleteRecord_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = Connection.GetPIDs();
            while (reader.Read())
            {
                CID.Items.Add(reader[0]);

            }

           
        }

        private void CID_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = Convert.ToInt32(CID.SelectedItem);
            SqlConnection n = Connection.GetConnection();
            string Query = "Select Name From Patient where PID=" + id + "";
            SqlCommand cmd = new SqlCommand(Query, n);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CName.Text = reader[0].ToString();
            }

            n.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection n = Connection.GetConnection();
            string Query = "DELETE FROM Patient WHERE [PID] =" + id+"";
            string q2= "DELETE FROM Diagnose WHERE [PID] =" + id + "";
            SqlCommand cmd = new SqlCommand(Query, n);
            SqlCommand cmd1 = new SqlCommand(q2,n);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            n.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(CID.SelectedItem);
           
            SqlConnection n = Connection.GetConnection();
            string Query = "SELECT * FROM Patient INNER JOIN Diagnose ON Patient.[PID] = Diagnose.[PID]";

            SqlCommand cmd = new SqlCommand(Query, n);
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            GridView2.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashBoard d = new dashBoard();
            d.Show();
            this.Hide();
        }
    }
}
