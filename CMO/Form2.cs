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
    public partial class Form2 : Form
    {
        int max_client;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                max_client = Convert.ToInt16(max.Text);
                if (max_client <= 0)
                    throw new ArgumentNullException("Максимум клиентов");
                Form1 w = new Form1(max_client);
                w.Parent = this;
                w.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Warning " + ex.GetType().Name + " " + ex.Message);
            }
        }
    }
}
