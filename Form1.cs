using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_4
{
    /*
     * Enrique Sanchezmurillo
    * CST-150, Milestone 4 & 5
    * 21 AUG 2022
    */
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void ShopButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.ShowDialog();
            form2 = null;
            this.Show();

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
