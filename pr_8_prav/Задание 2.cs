using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_8_prav
{
    public partial class Задание_2 : Form
    {
        public Задание_2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            if ((a.Substring(0, 1)) == (b.Substring(b.Length - 1, 1)))
            {
                label4.Text = "верно";
            }
            else if ((a.Substring(0, 1)) != (b.Substring(b.Length - 1, 1)))
            {
                label4.Text = "неверно";
            }
        }
    }
}
