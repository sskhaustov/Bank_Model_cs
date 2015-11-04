using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMO
{
    public partial class Form3 : Form
    {
        public Form Parent;
        public Form3(int [] _info)
        {
            InitializeComponent();
            //статистика по клиентам
            total.Text = Convert.ToString(_info[0]);
            refu.Text = Convert.ToString(_info[1]);
            acc.Text = Convert.ToString(_info[0] - _info[1]);
            //статистика по заявкам
            xc.Text = Convert.ToString(_info[2]);
            ac.Text = Convert.ToString(_info[3]);
            cr.Text = Convert.ToString(_info[4]);
            ca.Text = Convert.ToString(_info[5]);
            //статистика по кассам
            w1.Text = Convert.ToString(_info[6] / 60) + ':' + Convert.ToString(_info[6] % 60);
            w2.Text = Convert.ToString(_info[7] / 60) + ':' + Convert.ToString(_info[7] % 60);
            w3.Text = Convert.ToString(_info[8] / 60) + ':' +Convert.ToString(_info[8] % 60);
            w4.Text = Convert.ToString(_info[9] / 60) + ':' +Convert.ToString(_info[9] % 60);
            w5.Text = Convert.ToString(_info[10] / 60) + ':' +Convert.ToString(_info[10] % 60);
            w6.Text = Convert.ToString(_info[11] / 60) + ':' +Convert.ToString(_info[11] % 60);
            w7.Text = Convert.ToString(_info[12] / 60) + ':' +Convert.ToString(_info[12] % 60);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Close();
        }
    }
}
