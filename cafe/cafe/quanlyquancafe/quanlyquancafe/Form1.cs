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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightCyan;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightYellow;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.GreenYellow;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Tomato;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Lime;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Cyan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatMon frm_order = new DatMon();
            frm_order.Show();
            frm_order.FormClosing += Frm_order_FormClosing;
        }

        private void Frm_order_FormClosing(object sender, FormClosingEventArgs e)
        {
           this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimKiem frm_TK =new TimKiem();
            frm_TK.Show();
            frm_TK.FormClosing += Frm_order_FormClosing;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
          Thongke frm_thongke = new Thongke();
            frm_thongke.Show();
            frm_thongke.FormClosing += Frm_order_FormClosing;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?","warning",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
