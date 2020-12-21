using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_in sign = new Sign_in();
            sign.Show();
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "") {
                MessageBox.Show("Введите имя");
                return;
            }


            if (bunifuMaterialTextbox2.Text == "")
            {
                MessageBox.Show("Введите Пароль");
                return;
            }



            if (bunifuMaterialTextbox4.Text == "")
            {
                MessageBox.Show("Введите email");
                return;
            }



            if (bunifuMaterialTextbox2.Text != bunifuMaterialTextbox3.Text)
                MessageBox.Show("Пароли не совпадают");
        }
    }
}
