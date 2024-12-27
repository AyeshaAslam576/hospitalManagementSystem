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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            DataTable myTable = Connection.GetPatientHistoryAdapterData();
            dataGridh.DataSource = myTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashBoard d = new dashBoard();
            d.Show();
            this.Hide();
        }
    }
}
