using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ManageReturn : Form
    {
        public ManageReturn()
        {
            InitializeComponent();
        }

        private void ManageReturn_Load(object sender, EventArgs e)
        {

        }

        private void emailInput_Click(object sender, EventArgs e)
        {
            if (emailInput.Text == "Enter the tracking number here.")
            {
                emailInput.Text = "";
            }
        }
    }
}
