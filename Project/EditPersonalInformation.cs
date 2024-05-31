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
    public partial class EditPersonalInformation : Form
    {
        public EditPersonalInformation()
        {
            InitializeComponent();
        }

        private void EditPersonalInformation_Load(object sender, EventArgs e)
        {

        }

        private void emailInput_Click(object sender, EventArgs e)
        {
            if (emailInput.Text == "Example: user@lm.com")
            {
                emailInput.Text = "";
            }
        }
    }
}
