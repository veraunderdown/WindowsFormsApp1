using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            uiGoodbyeDaveButton.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye Dave!");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Well done!");
        }
    }
}
