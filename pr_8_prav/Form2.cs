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
    public partial class zd_1 : Form
    {
        public zd_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string F= Convert.ToString(textBox1.Text);
            string F2 = Convert.ToString(textBox2.Text);
           if (F.Length > F2.Length)
           {
                textBox3.Text = "Первая фамилия длинее"; 
           }
           else if (F.Length < F2.Length)
           {
                textBox3.Text = "Вторая фамилия длинее";
           }
            if (F.Length == F2.Length)
            {
                textBox3.Text = "Фамилии равной длины";
            }



        }
    }
}
