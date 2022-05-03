using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyquancafe
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }
        ServiceReference1.Service1Client Service1Client;
        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client = new ServiceReference1.Service1Client();
            dataGridView1.DataSource = Service1Client.Daban();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service1Client = new ServiceReference1.Service1Client();
            dataGridView1.DataSource = Service1Client.conlai();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Service1Client = new ServiceReference1.Service1Client();
            MessageBox.Show($"Doanh thu {Service1Client.doanhthu()} VND","Thông báo",MessageBoxButtons.YesNo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.GreenYellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightYellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightCyan;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Cyan;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Tomato;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
        }
    }
}
