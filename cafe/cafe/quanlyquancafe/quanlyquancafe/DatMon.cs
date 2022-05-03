using quanlyquancafe.ServiceReference1;
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
    public partial class DatMon : Form
    {
        Service1Client Service1Client;
        public DatMon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client = new Service1Client();
            coffee c = new coffee()
            {
                id = Convert.ToInt32(textBox1.Text),
                numberOrder = Convert.ToInt32(textBox5.Text)
            };
            if (Service1Client.datMon(c)!=0)
            {
                MessageBox.Show("Đặt thành công","Thông báo");
                Service1Client.getInfo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightCyan;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Cyan;
        }

       

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Tomato;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }
        

        private void DatMon_Load(object sender, EventArgs e)
        {
            Service1Client = new Service1Client();
            dataGridView1.DataSource = Service1Client.getInfo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0,e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[3,e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[4,e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[2, e.RowIndex].Value.ToString();
        }
    }
}
