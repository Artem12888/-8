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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = Convert.ToString(textBox1.Text);
            int n = s.Length;
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'А' || s[i] == 'а' || s[i] == 'У' || s[i] == 'у'
                   || s[i] == 'Е' || s[i] == 'е' || s[i] == 'Ё' || s[i] == 'ё'
                    || s[i] == 'Ы' || s[i] == 'ы' || s[i] == 'О' || s[i] == 'о'
                    || s[i] == 'Э' || s[i] == 'э'|| s[i] == 'Я' || s[i] == 'я' 
                    || s[i] == 'И' || s[i] == 'и' || s[i] == 'Ю' || s[i] == 'ю')
                {
                    k++;
                }    
            }
            double p= 100.0 / n * k;
            label1.Text = p.ToString();
        }
    }
}
