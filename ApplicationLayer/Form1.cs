using HopitalSystem.BussinessLayer;
using HopitalSystem.DataBaseLayer;
namespace HopitalSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string Pass = txtpassword.Text;
            if (user == "MFA" && Pass == "12")
            {
                this.Hide();
                dashBoard d = new dashBoard();
                d.Show();
            }
            else
            {
                MessageBox.Show("You have entered either username or password incorrect ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}