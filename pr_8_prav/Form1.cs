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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new zd_1();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Задание_2();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.Show();
        }

     
    }
}
