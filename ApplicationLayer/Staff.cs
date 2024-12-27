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
using HopitalSystem.BussinessLayer;
using HopitalSystem.DataBaseLayer;

namespace HopitalSystem
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=DESKTOP-037AGVV;Initial Catalog=Hospital;Integrated Security=True";
            SqlConnection n = new SqlConnection(connection);
            n.Open();
            string Query = "Select * From Staff ";
            SqlCommand cmd = new SqlCommand(Query, n);
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            reader.Close();
            adapter.Fill(ds);
            dataView1.DataSource = ds.Tables[0];
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashBoard d = new dashBoard();
            d.Show();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }
    }
}
