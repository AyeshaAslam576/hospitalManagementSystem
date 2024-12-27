using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopitalSystem
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashBoard d = new dashBoard();
            d.Show();
            this.Hide();
        }

        private void History_Load(object sender, EventArgs e)
        {

        }
    }
}
